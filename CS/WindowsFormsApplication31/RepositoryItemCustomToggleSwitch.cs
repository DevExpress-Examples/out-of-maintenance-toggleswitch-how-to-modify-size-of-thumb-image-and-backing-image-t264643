using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace WindowsFormsApplication31 {
    [UserRepositoryItem("RegisterCustomToggleSwitch")]
    public class RepositoryItemCustomToggleSwitch : RepositoryItemToggleSwitch {
        static RepositoryItemCustomToggleSwitch() {
            RegisterCustomToggleSwitch();
        }

        public const string CustomEditName = "CustomToggleSwitch";

        public RepositoryItemCustomToggleSwitch() {
        }

        public override string EditorTypeName {
            get {
                return CustomEditName;
            }
        }

        public static void RegisterCustomToggleSwitch() {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(CustomToggleSwitch), typeof(RepositoryItemCustomToggleSwitch), typeof(CustomToggleSwitchViewInfo), new CustomToggleSwitchPainter(), true, img));
        }

        public override void Assign(RepositoryItem item) {
            BeginUpdate();
            try {
                base.Assign(item);
                RepositoryItemCustomToggleSwitch source = item as RepositoryItemCustomToggleSwitch;
                if(source == null)
                    return;
                //
            } finally {
                EndUpdate();
            }
        }
    }

}
