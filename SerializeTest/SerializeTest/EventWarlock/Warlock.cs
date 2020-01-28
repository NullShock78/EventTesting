using SerializeTest.EventWarlock;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RTCV.CorruptCore.EventWarlock
{
    /// <summary>
    /// I'm a wizard hagrid
    /// </summary>
    public static class Warlock
    {
        public static Grimoire BookOfSpells = new Grimoire();
        public static bool LastResult { get; private set; } = false;


        public static void Clear()
        {
            BookOfSpells.LoadSpells.Clear();
            BookOfSpells.PreExecuteSpells.Clear();
            BookOfSpells.PostExecuteSpells.Clear();
        }

        public static void SaveGrimoire(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(path, FileMode.Create, FileAccess.Write);
            formatter.Serialize(s, BookOfSpells);
            s.Close();
        }

        public static void LoadGrimoire(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream s = new FileStream(path, FileMode.Open, FileAccess.Read);
            BookOfSpells = (Grimoire)formatter.Deserialize(s);
            s.Close();
        }


        public static void AddLoadSpell(Spell spell)
        {
            BookOfSpells.LoadSpells.Add(spell);
        }

        public static void AddPreExecuteSpell(Spell spell)
        {
            BookOfSpells.PreExecuteSpells.Add(spell);
        }

        public static void AddPostExecuteSpell(Spell spell)
        {
            BookOfSpells.PostExecuteSpells.Add(spell);
        }


        public static void Load()
        {
            for (int j = 0; j < BookOfSpells.LoadSpells.Count; j++)
            {
                LastResult = BookOfSpells.LoadSpells[j].Execute();
            }
        }

        public static void PreExecute()
        {
            for (int j = 0; j < BookOfSpells.PreExecuteSpells.Count; j++)
            {
                LastResult = BookOfSpells.PreExecuteSpells[j].Execute();
            }
        }

        public static void PostExecute()
        {
            for (int j = 0; j < BookOfSpells.PostExecuteSpells.Count; j++)
            {
                LastResult = BookOfSpells.PostExecuteSpells[j].Execute();
            }
        }
    }
}
