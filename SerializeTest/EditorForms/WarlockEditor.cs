using EditorForms.UserControls;
using RTCV.CorruptCore.EventWarlock;
using RTCV.CorruptCore.EventWarlock.WarlockActions;
using SerializeTest.EventWarlock.WarlockActions;
using SerializeTest.EventWarlock.WarlockConditions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorForms
{
    public partial class WarlockEditor : Form
    {
        public WarlockEditor()
        {
            InitializeComponent();
            buttonTest.Enabled = false;

        }

        Grimoire curGrim = null;

        int stressTestVal = 300;
        void Generate()
        {
            Warlock.Reset();
            Grimoire grimoire = new Grimoire();
            grimoire.Name = "Default";

            Spell a = new Spell();
            var eqA = new FirstEqualsSecond("a", "d");
            a.SetConditional(eqA);
            a.AddAction(new WarlockActionEcho("Test"));
            a.AddAction(new WarlockActionEcho("Test 1"));
            a.AddAction(new WarlockActionEcho("Test 1"));
            grimoire.LoadSpells.Add(a);

            string[] s = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i" };
            Random r = new Random();
            stressTestVal = (int)numericUpDownStress.Value;
            for (int j = 0; j < stressTestVal; j++)
            {
                string N() {
                    return s[r.Next(9)];
                }

                Spell a1 = new Spell();
                var aeqC = new EWConditionGroup();
                var aeqC1 = new EWConditionGroup();
                var aeqC2 = new EWConditionGroup();

                //Group1
                aeqC1.AddConditional(new FirstEqualsSecond(N(), N()));
                aeqC1.AddOperator(QuestionOp.AND);
                aeqC1.AddConditional(new FirstEqualsSecond(N(), N()));

                aeqC.AddConditional(aeqC1);

                //if (r.Next(0, 2) == 0)
                //{
                    aeqC.AddOperator(QuestionOp.OR);

                    //Group 2
                    aeqC2.AddConditional(new FirstEqualsSecond("a", "a"));
                    aeqC2.AddOperator(QuestionOp.AND);
                    aeqC2.AddConditional(new FirstEqualsSecond("a", "a"));
                    aeqC.AddConditional(aeqC2);
                //}

                a1.SetConditional(aeqC);

                a1.AddAction(new WarlockActionNone());
                grimoire.LoadSpells.Add(a1);
            }
            //a.AddAction(new WarlockActionMega());


            Spell b = new Spell();
            var eqB = new FirstEqualsSecond("a", "b");
            b.SetConditional(eqB, true);
            b.AddAction(new WarlockActionEcho("Test Else"));
            grimoire.LoadSpells.Add(b);

            Spell b2 = new Spell();
            var eqB2 = new FirstEqualsSecond("a", "a");
            b2.SetConditional(eqB2, true);
            b2.AddAction(new WarlockActionEcho("Test Else 2"));
            b2.AddAction(new WarlockActionCoroutineTest());
            grimoire.LoadSpells.Add(b2);

            Spell c = new Spell();
            //(("a"=="l" AND "c"=="c") OR ("b"=="b" AND "c"=="c"))
            //should always create group as base, otherwise if only one conditional just set as that conditional
            var eqC = new EWConditionGroup();
            var eqC1 = new EWConditionGroup();
            var eqC2 = new EWConditionGroup();

            //Group1
            eqC1.AddConditional(new FirstEqualsSecond("a", "l"));
            eqC1.AddOperator(QuestionOp.AND);
            eqC1.AddConditional(new FirstEqualsSecond("c", "c"));

            eqC.AddConditional(eqC1);
            eqC.AddOperator(QuestionOp.OR);

            //Group 2
            eqC2.AddConditional(new FirstEqualsSecond("b", "b"));
            eqC2.AddOperator(QuestionOp.AND);
            eqC2.AddConditional(new FirstEqualsSecond("c", "c"));

            eqC.AddConditional(eqC2);
            c.SetConditional(eqC);

            c.AddAction(new WarlockActionEcho("Big Test"));
            
            var wam = (WarlockActionMega)FormatterServices.GetUninitializedObject(typeof(WarlockActionMega));
            c.AddAction(wam);
            //c.AddAction(new WarlockActionMega());
            //c.AddAction(new WarlockActionMega());
            grimoire.PostExecuteSpells.Add(c);

            Warlock.AddGrimoire(grimoire);
            curGrim = grimoire;
            buttonTest.Enabled = true;
            Console.WriteLine("Spell c: " + eqC.ToString());
            LoadEditor();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Generate();
           // Warlock.SaveGrimoire("./grimoire.dat");
        }


        public static void SaveGrimoires(string path, List<Grimoire> grimoires)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(path, FileMode.Create, FileAccess.Write);
            formatter.Serialize(s, grimoires);
            s.Close();
        }

        public static List<Grimoire> LoadGrimoires(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(path, FileMode.Open, FileAccess.Read);
            var grimoires = (List<Grimoire>)formatter.Deserialize(s);
            s.Close();
            return grimoires;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           SaveGrimoires("./grimoires.dat", Warlock.Grimoires);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                Warlock.Reset();
                Warlock.LoadGrimoires(LoadGrimoires("./grimoires.dat"));
            }
            catch
            {
                Generate();
                SaveGrimoires("./grimoires.dat", Warlock.Grimoires);
            }

            LoadEditor();
        }

        public void ClearAll()
        {
            flowPanel.Controls.Clear();
            testL.Clear();
            buttonTest.Enabled = true;
        }


        private void LoadEditor()
        {
            ClearAll();
            var spells = Warlock.GetByName("Default").PostExecuteSpells;
            for (int j = 0; j < spells.Count; j++)
            {
                //would load only one spell at a time, both conditionals and 
                for (int k = 0; k < spells[j].Actions.Count; k++)
                {
                    var lc = new LoadControl(spells[j].Actions[k]);
                    flowPanel.Controls.Add(lc);
                    testL.Add(lc);
                }
            }
        }

        List<LoadControl> testL = new List<LoadControl>();
        private void buttonTest_Click(object sender, EventArgs e)
        {
            LoadEditor();

            //TestClass cl = new TestClass("123", false, true, "abc");
            //condTest = new FirstEqualsSecond("a", "b");
            //testL = new LoadControl(condTest);
            //flowPanel.Controls.Add(testL);
        }

        private void buttonLoadTest_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Warlock Load");
            Stopwatch w = new Stopwatch();
            w.Start();
            Warlock.Load();
            //w.Stop();
            Console.WriteLine("Time taken: " + w.Elapsed);
            w.Stop();
        }

        private void buttonRunTest_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Warlock PreExecute");
            Warlock.PreExecute();

            Console.WriteLine("Warlock Execute");
            Warlock.Execute();

            Console.WriteLine("Warlock PostExecute");
            Warlock.PostExecute();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < testL.Count; j++)
            {
                testL[j].Apply();
            }
            Warlock.Smallify();
            //Warlock.Smallify2();
            SaveGrimoires("./grimoires.dat", Warlock.Grimoires);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
