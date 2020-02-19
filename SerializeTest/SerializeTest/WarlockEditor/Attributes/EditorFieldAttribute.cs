using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCV.CorruptCore.EventWarlock.WarlockEditor
{
    /// <summary>
    /// Used to link parameters to constructor arguments for the editor
    /// </summary>
    [System.AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public sealed class EditorFieldAttribute : Attribute
    {
        readonly string fieldName;
        readonly bool enabled;
        public EditorFieldAttribute(string fieldName, bool allowEditing = true)
        {
            this.fieldName = fieldName;
            this.enabled = allowEditing;
        }

        public string FieldName
        {
            get { return fieldName; }
        }

        public bool Enabled
        {
            get { return enabled; }
        }
    }
}
