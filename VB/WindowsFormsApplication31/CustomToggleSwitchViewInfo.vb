Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace WindowsFormsApplication31
    Public Class CustomToggleSwitchViewInfo
        Inherits ToggleSwitchViewInfo

        Public Sub New(ByVal item As RepositoryItem)
            MyBase.New(item)
        End Sub
        Protected Overrides Function CreateCheckPainter() As BaseCheckObjectPainter
            Return New CustomToggleObjectPainter(Me.LookAndFeel)
        End Function
    End Class

End Namespace
