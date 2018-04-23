Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.Utils.Drawing
Imports DevExpress.Skins

Namespace WindowsFormsApplication31
    <ToolboxItem(True)> _
    Public Class CustomToggleSwitch
        Inherits ToggleSwitch

        Shared Sub New()
            RepositoryItemCustomToggleSwitch.RegisterCustomToggleSwitch()
        End Sub

        Public Sub New()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemCustomToggleSwitch
            Get
                Return TryCast(MyBase.Properties, RepositoryItemCustomToggleSwitch)
            End Get
        End Property

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemCustomToggleSwitch.CustomEditName
            End Get
        End Property
    End Class
End Namespace
