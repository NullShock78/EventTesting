using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTCV.CorruptCore.EventWarlock;
using RTCV.CorruptCore.EventWarlock.WarlockActions;
using SerializeTest.EventWarlock.WarlockConditions;

namespace SerializeTest
{

    class Program
    {
        static void Main(string[] args)
        {
            var k = Console.ReadKey().KeyChar.ToString().ToLower()[0];
            Console.WriteLine();
            if (k == 's')
            {
                Spell a = new Spell();
                var eqA = new FirstEqualsSecond("a", "a");
                a.SetConditional(eqA);
                a.AddAction(new WarlockActionEcho("Test"));
                a.AddAction(new WarlockActionEcho("Test 1"));
                a.AddAction(new WarlockActionEcho("Test 2"));
                Warlock.AddLoadSpell(a);

                Spell b = new Spell();
                var eqB = new FirstEqualsSecond("a", "b");
                b.SetConditional(eqB);
                b.AddAction(new WarlockActionEcho("Test 3"));
                Warlock.AddPreExecuteSpell(b);

                Spell c = new Spell();
                var eqC = new EWConditionGroup();
                eqC.AddConditional(new FirstEqualsSecond("a", "a"));
                eqC.AddOperator(QuestionOp.AND);
                eqC.AddConditional(new FirstEqualsSecond("c", "c"));
                c.SetConditional(eqC);
                c.AddAction(new WarlockActionEcho("Test 4"));
                c.AddAction(new WarlockActionEcho("Test 5"));
                Warlock.AddPostExecuteSpell(c);

                Warlock.SaveGrimoire("./grimoire.dat");
            }
            else if (k == 'l')
            {
                Warlock.LoadGrimoire("./grimoire.dat");
            }



            Console.WriteLine("Warlock Load");
            Warlock.Load();

            Console.WriteLine("Warlock PreExecute");
            Warlock.PreExecute();

            Console.WriteLine("Warlock PostExecute");
            Warlock.PostExecute();

            Console.ReadKey();
        }
    }
}
