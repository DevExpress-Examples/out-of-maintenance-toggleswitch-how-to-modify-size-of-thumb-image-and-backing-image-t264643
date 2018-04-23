using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;

namespace WindowsFormsApplication31 {
    public class CustomToggleObjectPainter : SkinToggleObjectPainter {
        public CustomToggleObjectPainter(ISkinProvider provider)
            : base(provider) {

        }
        // calculation of the switch (toggle thumb) image size
        protected override Size CalcSwitchSize(ToggleObjectInfoArgs e) {
            Size size = CalcImageSize(e);
            return new Size(10, size.Height);
            //original code
            //return new Size(size.Width * e.SwitchWidth / 100, size.Height);
        }
        //calculation of the thumb's backing image size
        protected override Size CalcImageSize(BaseCheckObjectInfoArgs e) {
            ToggleObjectInfoArgs args = e as ToggleObjectInfoArgs;
            if(args == null)
                return Size.Empty;
            int heigth = args.Appearance.FontHeight + 2 * args.TextMargin;
            int width = (int)Math.Floor(heigth / PercentRatio);
            int delta = 50;
            return new Size(width > args.MinSize.Width ? width + delta : args.MinSize.Width + delta, heigth > args.MinSize.Height ? heigth : args.MinSize.Height);
            //original code
            //return new Size(width > args.MinSize.Width ? width : args.MinSize.Width , heigth > args.MinSize.Height ? heigth : args.MinSize.Height);
        }
        protected override Size CalcCaptionSize(BaseCheckObjectInfoArgs e, int widthText) {
            return base.CalcCaptionSize(e, widthText);
        }
        protected override Size CalcSimpleCaptionSize(BaseCheckObjectInfoArgs e, int textWidth) {
            return base.CalcSimpleCaptionSize(e, textWidth);
        }
        protected override Size CalcCheckSize(BaseCheckObjectInfoArgs e) {
            Size checkSize = base.CalcCheckSize(e);
            return checkSize;
        }
    }

}
