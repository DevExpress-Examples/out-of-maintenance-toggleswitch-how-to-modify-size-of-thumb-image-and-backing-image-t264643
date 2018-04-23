Namespace WindowsFormsApplication31
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.customToggleSwitch1 = New WindowsFormsApplication31.CustomToggleSwitch()
            DirectCast(Me.customToggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' customToggleSwitch1
            ' 
            Me.customToggleSwitch1.Location = New System.Drawing.Point(49, 38)
            Me.customToggleSwitch1.Name = "customToggleSwitch1"
            Me.customToggleSwitch1.Properties.OffText = "Off"
            Me.customToggleSwitch1.Properties.OnText = "On"
            Me.customToggleSwitch1.Size = New System.Drawing.Size(150, 24)
            Me.customToggleSwitch1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(239, 108)
            Me.Controls.Add(Me.customToggleSwitch1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.customToggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private customToggleSwitch1 As CustomToggleSwitch
    End Class
End Namespace

