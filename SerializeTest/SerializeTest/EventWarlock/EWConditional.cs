using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace RTCV.CorruptCore.EventWarlock
{
    /// <summary>
    /// Abstract due to serialization
    /// </summary>
    [Serializable]
    public abstract class EWConditional
    {
        public QuestionOp NextOp = QuestionOp.NONE;
        public EWConditional SetNextOp(QuestionOp op) { NextOp = op; return this; }
        public abstract bool Evaluate();

        public override string ToString()
        {
            string ret = this.GetType().Name+":{";
            //var pars = this.GetType().GetConstructors()[0].GetParameters();
            var fields = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            for (int j = 0; j < fields.Length; j++)
            {
                //fields.FirstOrDefault(x => x.Name == pars.)
                var fieldName = fields[j].Name;
                if(fieldName != "NextOp")
                {
                    ret += fieldName;
                    var val = fields[j].GetValue(this).ToString();
                    ret += ": " + val.Substring(0, Math.Min(10, val.Length));
                }

                if(j != fields.Length - 1)
                {
                    ret += ", ";
                }
            }
            ret += "}";

            switch (NextOp)
            {
                case QuestionOp.AND:
                    ret += " AND ";
                    break;
                case QuestionOp.OR:
                    ret += " OR ";
                    break;
                default:
                    break;
            }

            return ret;
        }
    }
}
