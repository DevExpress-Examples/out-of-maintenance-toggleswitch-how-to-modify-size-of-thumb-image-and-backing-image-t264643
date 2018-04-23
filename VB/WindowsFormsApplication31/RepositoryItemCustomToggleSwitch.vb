Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository

Namespace WindowsFormsApplication31
    <UserRepositoryItem("RegisterCustomToggleSwitch")> _
    Public Class RepositoryItemCustomToggleSwitch
        Inherits RepositoryItemToggleSwitch

        Shared Sub New()
            RegisterCustomToggleSwitch()
        End Sub

        Public Const CustomEditName As String = "CustomToggleSwitch"

        Public Sub New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return CustomEditName
            End Get
        End Property

        Public Shared Sub RegisterCustomToggleSwitch()
            Dim img As Image = Nothing
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomToggleSwitch), GetType(RepositoryItemCustomToggleSwitch), GetType(CustomToggleSwitchViewInfo), New CustomToggleSwitchPainter(), True, img))
        End Sub

        Public Overrides Sub Assign(ByVal item As RepositoryItem)
            BeginUpdate()
            Try
                MyBase.Assign(item)
                Dim source As RepositoryItemCustomToggleSwitch = TryCast(item, RepositoryItemCustomToggleSwitch)
                If source Is Nothing Then
                    Return
                End If
                '
            Finally
                EndUpdate()
            End Try
        End Sub
    End Class

End Namespace
