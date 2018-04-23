Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.Skins
Imports DevExpress.Utils.Drawing

Namespace WindowsFormsApplication31
    Public Class CustomToggleObjectPainter
        Inherits SkinToggleObjectPainter

        Public Sub New(ByVal provider As ISkinProvider)
            MyBase.New(provider)

        End Sub
        ' calculation of the switch (toggle thumb) image size
        Protected Overrides Function CalcSwitchSize(ByVal e As ToggleObjectInfoArgs) As Size
            Dim size As Size = CalcImageSize(e)
            Return New Size(10, size.Height)
            'original code
            'return new Size(size.Width * e.SwitchWidth / 100, size.Height);
        End Function
        'calculation of the thumb's backing image size
        Protected Overrides Function CalcImageSize(ByVal e As BaseCheckObjectInfoArgs) As Size
            Dim args As ToggleObjectInfoArgs = TryCast(e, ToggleObjectInfoArgs)
            If args Is Nothing Then
                Return Size.Empty
            End If
            Dim heigth As Integer = args.Appearance.FontHeight + 2 * args.TextMargin
            Dim width As Integer = CInt((Math.Floor(heigth / PercentRatio)))
            Dim delta As Integer = 50
            Return New Size(If(width > args.MinSize.Width, width + delta, args.MinSize.Width + delta),If(heigth > args.MinSize.Height, heigth, args.MinSize.Height))
            'original code
            'return new Size(width > args.MinSize.Width ? width : args.MinSize.Width , heigth > args.MinSize.Height ? heigth : args.MinSize.Height);
        End Function
        Protected Overrides Function CalcCaptionSize(ByVal e As BaseCheckObjectInfoArgs, ByVal widthText As Integer) As Size
            Return MyBase.CalcCaptionSize(e, widthText)
        End Function
        Protected Overrides Function CalcSimpleCaptionSize(ByVal e As BaseCheckObjectInfoArgs, ByVal textWidth As Integer) As Size
            Return MyBase.CalcSimpleCaptionSize(e, textWidth)
        End Function
        Protected Overrides Function CalcCheckSize(ByVal e As BaseCheckObjectInfoArgs) As Size
            Dim checkSize As Size = MyBase.CalcCheckSize(e)
            Return checkSize
        End Function
    End Class

End Namespace
