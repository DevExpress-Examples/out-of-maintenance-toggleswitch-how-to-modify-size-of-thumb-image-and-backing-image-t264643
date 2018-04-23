using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils.Drawing;
using DevExpress.Skins;

namespace WindowsFormsApplication31 {
    [ToolboxItem(true)]
    public class CustomToggleSwitch : ToggleSwitch {
        static CustomToggleSwitch() {
            RepositoryItemCustomToggleSwitch.RegisterCustomToggleSwitch();
        }

        public CustomToggleSwitch() {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomToggleSwitch Properties {
            get {
                return base.Properties as RepositoryItemCustomToggleSwitch;
            }
        }

        public override string EditorTypeName {
            get {
                return RepositoryItemCustomToggleSwitch.CustomEditName;
            }
        }
    }
}
