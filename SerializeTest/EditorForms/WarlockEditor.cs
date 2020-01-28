using EditorForms.UserControls;
using RTCV.CorruptCore.EventWarlock;
using RTCV.CorruptCore.EventWarlock.WarlockActions;
using SerializeTest.EventWarlock.WarlockActions;
using SerializeTest.EventWarlock.WarlockConditions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        void Generate()
        {
            Warlock.Clear();
            Spell a = new Spell();
            var eqA = new FirstEqualsSecond("a", "d");
            a.SetConditional(eqA);
            a.AddAction(new WarlockActionEcho("Test"));
            a.AddAction(new WarlockActionEcho("Test 1"));
            a.AddAction(new WarlockActionEcho("Test 2"));
            Warlock.AddLoadSpell(a);

            Spell b = new Spell();
            var eqB = new FirstEqualsSecond("a", "b");
            b.SetConditional(eqB, true);
            b.AddAction(new WarlockActionEcho("Test Else"));
            Warlock.AddLoadSpell(b);

            Spell b2 = new Spell();
            var eqB2 = new FirstEqualsSecond("a", "a");
            b2.SetConditional(eqB2, true);
            b2.AddAction(new WarlockActionEcho("Test Else 2"));
            Warlock.AddLoadSpell(b2);

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
            c.AddAction(new WarlockActionMega("a", "b", "c", false));
            Warlock.AddPostExecuteSpell(c);

            Console.WriteLine("Spell c: " + eqC.ToString());
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Generate();
           // Warlock.SaveGrimoire("./grimoire.dat");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Warlock.SaveGrimoire("./grimoire.dat");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Warlock.LoadGrimoire("./grimoire.dat");
        }


        FirstEqualsSecond condTest = null;
        LoadControl testL = null;
        private void buttonTest_Click(object sender, EventArgs e)
        {
            Generate();
            var spells = Warlock.BookOfSpells.PostExecuteSpells;
            for (int j = 0; j < spells.Count; j++)
            {
                for (int k = 0; k < spells[j].Actions.Count; k++)
                {
                    var lc = new LoadControl(spells[j].Actions[k]);
                    flowPanel.Controls.Add(lc);
                }
               
            }

            //TestClass cl = new TestClass("123", false, true, "abc");
            //condTest = new FirstEqualsSecond("a", "b");
            //testL = new LoadControl(condTest);
            //flowPanel.Controls.Add(testL);
        }

        private void buttonTestPrint_Click(object sender, EventArgs e)
        {
            var v = (EWConditional)testL.Generate();
            Console.WriteLine(v.ToString());
        }
    }
}
