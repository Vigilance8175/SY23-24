<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SpinB = New System.Windows.Forms.Button()
        Me.r1Label = New System.Windows.Forms.Label()
        Me.r2Label = New System.Windows.Forms.Label()
        Me.r3Label = New System.Windows.Forms.Label()
        Me.ReelControl3 = New Slot_Machine_Fixed.ReelControl()
        Me.ReelControl2 = New Slot_Machine_Fixed.ReelControl()
        Me.ReelControl1 = New Slot_Machine_Fixed.ReelControl()
        Me.SuspendLayout()
        '
        'SpinB
        '
        Me.SpinB.Location = New System.Drawing.Point(271, 235)
        Me.SpinB.Name = "SpinB"
        Me.SpinB.Size = New System.Drawing.Size(75, 26)
        Me.SpinB.TabIndex = 3
        Me.SpinB.Text = "Spin"
        Me.SpinB.UseVisualStyleBackColor = True
        '
        'r1Label
        '
        Me.r1Label.AutoSize = True
        Me.r1Label.Location = New System.Drawing.Point(206, 202)
        Me.r1Label.Name = "r1Label"
        Me.r1Label.Size = New System.Drawing.Size(14, 16)
        Me.r1Label.TabIndex = 4
        Me.r1Label.Text = "0"
        '
        'r2Label
        '
        Me.r2Label.AutoSize = True
        Me.r2Label.Location = New System.Drawing.Point(301, 202)
        Me.r2Label.Name = "r2Label"
        Me.r2Label.Size = New System.Drawing.Size(14, 16)
        Me.r2Label.TabIndex = 5
        Me.r2Label.Text = "0"
        '
        'r3Label
        '
        Me.r3Label.AutoSize = True
        Me.r3Label.Location = New System.Drawing.Point(395, 202)
        Me.r3Label.Name = "r3Label"
        Me.r3Label.Size = New System.Drawing.Size(14, 16)
        Me.r3Label.TabIndex = 6
        Me.r3Label.Text = "0"
        '
        'ReelControl3
        '
        Me.ReelControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReelControl3.itemValue = 0
        Me.ReelControl3.Location = New System.Drawing.Point(358, 118)
        Me.ReelControl3.Name = "ReelControl3"
        Me.ReelControl3.Size = New System.Drawing.Size(89, 81)
        Me.ReelControl3.spinTime = 2000
        Me.ReelControl3.TabIndex = 2
        '
        'ReelControl2
        '
        Me.ReelControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReelControl2.itemValue = 0
        Me.ReelControl2.Location = New System.Drawing.Point(264, 118)
        Me.ReelControl2.Name = "ReelControl2"
        Me.ReelControl2.Size = New System.Drawing.Size(89, 81)
        Me.ReelControl2.spinTime = 2000
        Me.ReelControl2.TabIndex = 1
        '
        'ReelControl1
        '
        Me.ReelControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReelControl1.itemValue = 0
        Me.ReelControl1.Location = New System.Drawing.Point(169, 118)
        Me.ReelControl1.Name = "ReelControl1"
        Me.ReelControl1.Size = New System.Drawing.Size(89, 81)
        Me.ReelControl1.spinTime = 2000
        Me.ReelControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.r3Label)
        Me.Controls.Add(Me.r2Label)
        Me.Controls.Add(Me.r1Label)
        Me.Controls.Add(Me.SpinB)
        Me.Controls.Add(Me.ReelControl3)
        Me.Controls.Add(Me.ReelControl2)
        Me.Controls.Add(Me.ReelControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents ReelControl3 As ReelControl
    Friend WithEvents SpinB As Button
    Friend WithEvents r1Label As Label
    Friend WithEvents r2Label As Label
    Friend WithEvents r3Label As Label
End Class
