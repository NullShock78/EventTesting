using EditorForms.UserControls;
using RTCV.CorruptCore.EventWarlock;
using RTCV.CorruptCore.EventWarlock.WarlockActions;
using RTCV.CorruptCore.EventWarlock.WarlockConditions;
using RTCV.CorruptCore.EventWarlock.WarlockEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorForms
{
    public partial class GrimoireEditor : Form
    {
        static List<ComponentInfo> ConditionalList = new List<ComponentInfo>();
        static List<ComponentInfo> ActionList = new List<ComponentInfo>();

        static Dictionary<string,Type> ControlList = new Dictionary<string, Type>();


        static WarlockPickListForm conditionalListForm;
        static WarlockPickListForm actionListForm;

        static GrimoireEditor()
        {
            var types = typeof(Warlock).Assembly.GetTypes();
            var conditionals = types.Where(x => x.IsSubclassOf(typeof(EWConditional)));
            var actions = types.Where(x => x.IsSubclassOf(typeof(WarlockAction)));
            var controls = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsSubclassOf(typeof(WarlockEditControl))).Where(x => x.GetCustomAttribute<WarlockEditorControlAttribute>() != null);

            foreach (var cond in conditionals)
            {
                var att = cond.GetCustomAttribute<WarlockEditableAttribute>();
                if (att != null)
                {
                    ConditionalList.Add(new ComponentInfo(att.EditorDisplayName, cond));
                }
            }

            foreach (var action in actions)
            {
                var att = action.GetCustomAttribute<WarlockEditableAttribute>();
                if (att != null)
                {
                    ActionList.Add(new ComponentInfo(att.EditorDisplayName, action));
                }
            }

            foreach (var c in controls)
            {
                var att = c.GetCustomAttribute<WarlockEditorControlAttribute>();
                if (att != null)
                {
                    ControlList.Add(att.Name, c);
                }
            }

            conditionalListForm = new WarlockPickListForm("Pick Conditional", ConditionalList);
            actionListForm = new WarlockPickListForm("Pick Action", ActionList);
        }

        private static string GetEditorName(object o)
        {
            return o.GetType().GetCustomAttribute<WarlockEditableAttribute>()?.EditorDisplayName;
            //if(att != null)
            //{
            //    return att.EditorName;
            //}
            //else
            //{
            //    return null;
            //}
        }

        Grimoire loadedGrimoire = null;

        Spell currentSpell = null;
        Spell CurrentSpell
        {
            get
            {
                return currentSpell;
            }
            set
            {
                currentSpell = value;
                labelCurrentSpell.Text = "Current Spell: " + currentSpell.Name;
            }
        } 

        Button addCondButton = null;
        Button buttonAddAction = null;

        WarlockEditControl editControl = null;
        Control editControlParent = null;

        public GrimoireEditor()
        {
            InitializeComponent();
            WarlockEditor.GrimoiresLoaded += NewGrimoireLoaded;
            FormClosing += GrimoireEditor_FormClosing;
            editControl = loadControlCurrent;
            editControlParent = loadControlCurrent.Parent;

            buttonAddAction = new Button();
            buttonAddAction.Dock = DockStyle.Top;
            buttonAddAction.Text = "[Add New Action]";
            buttonAddAction.BackColor = Color.Magenta;
            buttonAddAction.Click += AddActionButton_Click;
            FormClosed += GrimoireEditor_FormClosed;
            //listPanelActions.AddToBottom(addActionButton);
        }

        private void GrimoireEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            editControl.Apply();
        }

        private void SetEditControl(WarlockEditControl c)
        {
            editControlParent.Controls.Remove(editControl);
            c.Dock = DockStyle.Fill;
            editControlParent.Controls.Add(c);
            this.editControl = c;
        }

        private void KeepButtonsOnBottom()
        {
            listPanelActions.MoveToBottom(buttonAddAction);
        }

        private void AddActionButton_Click(object sender, EventArgs e)
        {
            actionListForm.Reset();
            var res = actionListForm.ShowDialog();
            if(res == DialogResult.OK)
            {
                Type t = actionListForm.SelectedType;
                var instance = (WarlockAction)FormatterServices.GetUninitializedObject(t);
                CurrentSpell.Actions.Add(instance);
                AddActionToPanel(instance);
                ShowObjectInEditor(instance, GetEditorName(instance));
            }
        }

        private ButtonDeletable CreateActionButton(WarlockAction action)
        {
            ButtonDeletable b = new ButtonDeletable();
            b.Dock = DockStyle.Top;
            b.Text = GetEditorName(action) ?? action.GetType().Name ?? "No Name";
            b.Click += (object o, EventArgs e) =>
            {
                ShowObjectInEditor(action, GetEditorName(action));
            };
            b.DeleteClick += (object o, EventArgs e) =>
            {
                listPanelActions.Remove(b);
                currentSpell.Actions.Remove(action);
                editControl.Clear();
                SetEditControl(loadControlCurrent);
                loadControlCurrent.Clear();
            };

            return b;
        }

        private ButtonDeletable CreateSpellButton(Spell spell, ListPanel panel)
        {
            ButtonDeletable b = new ButtonDeletable();
            b.Dock = DockStyle.Top;
            b.Text = spell.Name ?? "No Name";
            b.Click += (object o, EventArgs e) =>
            {
                editControl.Apply();
                editControl.Clear();
                ShowSpell(spell);
            };

            b.DeleteClick += (object o, EventArgs e) =>
            {
                loadedGrimoire.RemoveSpell(spell);
                panel.Remove(b);
                listPanelActions.Clear();
            };

            return b;
        }

        private void AddActionToPanel(WarlockAction action)
        {
            var b = CreateActionButton(action);
            listPanelActions.Add(b);
            listPanelActions.MoveToBottom(buttonAddAction);
        }

        private void GrimoireEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            WarlockEditor.GrimoiresLoaded -= NewGrimoireLoaded;
        }

        public void NewGrimoireLoaded()
        {           
            this.Close();
        }
     
        public void LoadGrimoire(Grimoire grimoire)
        {
            this.loadedGrimoire = grimoire;
            if (grimoire != null)
            {
                LoadSpellList(grimoire.LoadSpells, listPanelLoadSpells);
                LoadSpellList(grimoire.PreExecuteSpells, listPanelPreExecSpells);
                LoadSpellList(grimoire.ExecuteSpells, listPanelExecSpells);
                LoadSpellList(grimoire.PostExecuteSpells, listPanelPostExecSpells);
            }
            else
            {
                this.Shown += (object sender, EventArgs e) => { this.Close(); };
            }
        }

        void LoadSpellList(List<Spell> spellList, ListPanel panel)
        {
            panel.Clear();
            for (int j = 0; j < spellList.Count; j++)
            {
                //Todo: custom control

                //ButtonDeletable b = new ButtonDeletable();
                //b.Dock = DockStyle.Top;
                //b.Text = spellList[j].Name ?? "No Name";
                //var spell = spellList[j];
                //b.Click += (object o, EventArgs e) =>
                //{
                //    editControl.Apply();
                //    editControl.Clear();
                //    ShowSpell(spell);
                //};
                //panel.AddNoUpdate(b);
                var b = CreateSpellButton(spellList[j], panel);
                panel.AddNoUpdate(b);

            }
            panel.UpdateList();
        }

        private void AddSpellToPanel(Spell spell, ListPanel panel)
        {
            panel.Add(CreateSpellButton(spell,panel));
            //ButtonDeletable b = new ButtonDeletable();
            //b.Dock = DockStyle.Top;
            //b.Text = spell.Name ?? "No Name";
            //b.Click += (object o, EventArgs e) =>
            //{
            //    ShowSpell(spell);
            //};
            //panel.Add(b);
        }

        private void ShowSpell(Spell spell)
        {
            Console.WriteLine($"Showing Spell [{spell.Name}]");
            listPanelActions.Clear();
            for (int j = 0; j < spell.Actions.Count; j++)
            {
                listPanelActions.AddNoUpdate(CreateActionButton(spell.Actions[j]));
            }
            listPanelActions.AddNoUpdate(buttonAddAction);
            listPanelActions.UpdateList();
            CurrentSpell = spell;
        }

        private void ShowObjectInEditor(object o, string name)
        {
            var att = o.GetType().GetCustomAttribute<WarlockEditableAttribute>();
            string editorName = att.CustomEditorName;
            editControl.Apply();

            if (editorName != null)
            {
                try
                {
                    var editor = (WarlockEditControl)Activator.CreateInstance(ControlList[editorName]);
                    SetEditControl(editor);
                }
                catch(KeyNotFoundException e)
                {
                    Debugger.Break();
                }
                catch(MissingMethodException ex)
                {
                    Debugger.Break();
                }
            }
            else if(!object.ReferenceEquals(this.editControl, this.loadControlCurrent))
            {
                SetEditControl(this.loadControlCurrent);
            }

            editControl.LoadObject(o, name);
        }

        private void CheckAndAddSpell(List<Spell> spellList, ListPanel panel)
        {
            var ib = new InputBox();
            var res = ib.ShowDialog();
            if(res == DialogResult.OK)
            {
                if (loadedGrimoire.GetSpellByName(ib.Data) != null)
                {
                    MessageBox.Show($"Spell name \"{ib.Data}\" already exists in Grimoire \"{loadedGrimoire.Name}\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var s = new Spell(ib.Data);
                    spellList.Add(s);
                    AddSpellToPanel(s, panel);
                    ShowSpell(s);
                }
            }
        }

        private void buttonAddLoad_Click(object sender, EventArgs e)
        {
            CheckAndAddSpell(loadedGrimoire.LoadSpells, listPanelLoadSpells);
        }

        private void buttonAddPreExecute_Click(object sender, EventArgs e)
        {
            CheckAndAddSpell(loadedGrimoire.PreExecuteSpells, listPanelPreExecSpells);
        }

        private void buttonAddExecute_Click(object sender, EventArgs e)
        {
            CheckAndAddSpell(loadedGrimoire.ExecuteSpells, listPanelExecSpells);
        }

        private void buttonAddPostExecute_Click(object sender, EventArgs e)
        {
            CheckAndAddSpell(loadedGrimoire.PostExecuteSpells, listPanelPostExecSpells);
        }

    }
}
