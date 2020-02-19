using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using RTCV.CorruptCore.Coroutines;
using RTCV.CorruptCore.EventWarlock;
using RTCV.CorruptCore.EventWarlock.WarlockActions;
using SerializeTest.EventWarlock.WarlockConditions;

namespace SerializeTest
{

    //class Program
    //{

    //    //Note: coroutines always go to the first yield
    //    static IEnumerator<Yielder> MyCoroutine(int x)
    //    {
    //        Console.Write("passed in " + x.ToString());
    //        //Same as yielding until next frame
    //        yield return null;
    //        Console.Write("b");
    //        yield return new WaitFrames(3);
    //        Console.Write("c");

    //    }


    //    static void Main(string[] args)
    //    {
    //        CoroutineEngine.PostExecute.StartCoroutine(MyCoroutine(3));

    //        for (int j = 0; j < 10; j++)
    //        {
    //            Console.Write(j.ToString() + ": ");
    //            CoroutineEngine.PostExecute.Update();
    //            Console.Write("\r\n");
    //        }

    //        LogicStuff();
    //        Console.ReadKey();
    //    }

    //    public static void SaveGrimoires(string path, List<Grimoire> grimoires)
    //    {
    //        IFormatter formatter = new BinaryFormatter();
    //        Stream s = new FileStream(path, FileMode.Create, FileAccess.Write);
    //        formatter.Serialize(s, grimoires);
    //        s.Close();
    //    }

    //    public static List<Grimoire> LoadGrimoires(string path)
    //    {
    //        IFormatter formatter = new BinaryFormatter();
    //        Stream s = new FileStream(path, FileMode.Open, FileAccess.Read);
    //        var grimoires = (List<Grimoire>)formatter.Deserialize(s);
    //        s.Close();
    //        return grimoires;
    //    }


    //    static void LogicStuff()
    //    {
    //        var k = Console.ReadKey().KeyChar.ToString().ToLower()[0];
    //        Console.WriteLine();
    //        if (k == 's')
    //        {
    //            Grimoire grimoire = new Grimoire();

    //            Spell a = new Spell();
    //            var eqA = new FirstEqualsSecond("a", "d");
    //            a.SetConditional(eqA);
    //            a.AddAction(new WarlockActionEcho("Test"));
    //            a.AddAction(new WarlockActionEcho("Test 1"));
    //            a.AddAction(new WarlockActionEcho("Test 2"));

    //            grimoire.LoadSpells.Add(a);

    //            Spell b = new Spell();
    //            var eqB = new FirstEqualsSecond("a", "b");
    //            b.SetConditional(eqB, true);
    //            b.AddAction(new WarlockActionEcho("Test Else"));
    //            grimoire.LoadSpells.Add(b);

    //            Spell b2 = new Spell();
    //            var eqB2 = new FirstEqualsSecond("a", "a");
    //            b2.SetConditional(eqB2, true);
    //            b2.AddAction(new WarlockActionEcho("Test Else 2"));
    //            grimoire.LoadSpells.Add(b2);

    //            Spell c = new Spell();
    //            //(("a"=="l" AND "c"=="c") OR ("b"=="b" AND "c"=="c"))
    //            //should always create group as base, otherwise if only one conditional just set as that conditional
    //            var eqC = new EWConditionGroup();
    //            var eqC1 = new EWConditionGroup();
    //            var eqC2 = new EWConditionGroup();

    //            //Group1
    //            eqC1.AddConditional(new FirstEqualsSecond("a", "l"));
    //            eqC1.AddOperator(QuestionOp.AND);
    //            eqC1.AddConditional(new FirstEqualsSecond("c", "c"));

    //            eqC.AddConditional(eqC1);
    //            eqC.AddOperator(QuestionOp.OR);

    //            //Group 2
    //            eqC2.AddConditional(new FirstEqualsSecond("b", "b"));
    //            eqC2.AddOperator(QuestionOp.AND);
    //            eqC2.AddConditional(new FirstEqualsSecond("c", "c"));

    //            eqC.AddConditional(eqC2);
    //            c.SetConditional(eqC);

    //            c.AddAction(new WarlockActionEcho("Big Test"));
    //            c.AddAction(new WarlockActionEcho("Big Test 2"));
    //            grimoire.PostExecuteSpells.Add(c);

    //            Warlock.AddGrimoire(grimoire);

    //            Console.WriteLine("Spell c: " + eqC.ToString());

    //            SaveGrimoires("./grimoires.dat",Warlock.Grimoires);
    //        }
    //        else if (k == 'l')
    //        {
    //            Warlock.LoadGrimoires(LoadGrimoires("./grimoires.dat"));
    //        }


    //        Console.WriteLine("Warlock Load");
    //        Warlock.Load();

    //        Console.WriteLine("Warlock PreExecute");
    //        Warlock.PreExecute();

    //        Console.WriteLine("Warlock PostExecute");
    //        Warlock.PostExecute();
    //    }
    //}
}
