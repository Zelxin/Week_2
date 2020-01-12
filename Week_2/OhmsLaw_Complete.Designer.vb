<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OhmsLaw_Complete
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
        Me.txt_Voltage = New System.Windows.Forms.TextBox()
        Me.txt_Resistance = New System.Windows.Forms.TextBox()
        Me.txt_Current = New System.Windows.Forms.TextBox()
        Me.txt_Power = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.lbl_ErrorMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_Voltage
        '
        Me.txt_Voltage.Location = New System.Drawing.Point(92, 54)
        Me.txt_Voltage.Name = "txt_Voltage"
        Me.txt_Voltage.Size = New System.Drawing.Size(100, 20)
        Me.txt_Voltage.TabIndex = 0
        '
        'txt_Resistance
        '
        Me.txt_Resistance.Location = New System.Drawing.Point(92, 106)
        Me.txt_Resistance.Name = "txt_Resistance"
        Me.txt_Resistance.Size = New System.Drawing.Size(100, 20)
        Me.txt_Resistance.TabIndex = 1
        '
        'txt_Current
        '
        Me.txt_Current.Location = New System.Drawing.Point(92, 80)
        Me.txt_Current.Name = "txt_Current"
        Me.txt_Current.Size = New System.Drawing.Size(100, 20)
        Me.txt_Current.TabIndex = 2
        '
        'txt_Power
        '
        Me.txt_Power.Location = New System.Drawing.Point(92, 132)
        Me.txt_Power.Name = "txt_Power"
        Me.txt_Power.Size = New System.Drawing.Size(100, 20)
        Me.txt_Power.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Voltage"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Current"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Resistance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Power"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Watts (W)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(198, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ohms"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(198, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Amps(A)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(198, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Volts(V)"
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(92, 159)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(75, 23)
        Me.btn_Calculate.TabIndex = 14
        Me.btn_Calculate.Text = "Calculate"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'lbl_ErrorMessage
        '
        Me.lbl_ErrorMessage.AutoSize = True
        Me.lbl_ErrorMessage.Location = New System.Drawing.Point(173, 164)
        Me.lbl_ErrorMessage.Name = "lbl_ErrorMessage"
        Me.lbl_ErrorMessage.Size = New System.Drawing.Size(0, 13)
        Me.lbl_ErrorMessage.TabIndex = 15
        '
        'OhmsLaw_Complete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_ErrorMessage)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Power)
        Me.Controls.Add(Me.txt_Current)
        Me.Controls.Add(Me.txt_Resistance)
        Me.Controls.Add(Me.txt_Voltage)
        Me.Name = "OhmsLaw_Complete"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Voltage As TextBox
    Friend WithEvents txt_Resistance As TextBox
    Friend WithEvents txt_Current As TextBox
    Friend WithEvents txt_Power As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_Calculate As Button
    Friend WithEvents lbl_ErrorMessage As Label
End Class
