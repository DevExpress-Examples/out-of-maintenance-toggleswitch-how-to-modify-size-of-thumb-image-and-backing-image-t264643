using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsFormsApplication31 {
    public class CustomToggleSwitchViewInfo : ToggleSwitchViewInfo {
        public CustomToggleSwitchViewInfo(RepositoryItem item)
            : base(item) {
        }
        protected override BaseCheckObjectPainter CreateCheckPainter() {
            return new CustomToggleObjectPainter(this.LookAndFeel);
        }
    }
    
}
