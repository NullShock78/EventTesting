using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTCV.CorruptCore.EventWarlock.WarlockEditor
{
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class WarlockEditableAttribute : Attribute
    {
        private readonly string editorName;
        private readonly string customEditorName;
        public WarlockEditableAttribute(string name = null, string customEditor = null)
        {
            editorName = name;
            customEditorName = customEditor;
        }
        public string EditorDisplayName
        {
            get { return editorName; }
        }
        public string CustomEditorName
        {
            get { return customEditorName; }
        }

    }
}
