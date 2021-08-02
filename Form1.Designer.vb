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
        Me.components = New System.ComponentModel.Container()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.lblReceivedData = New System.Windows.Forms.Label()
        Me.lblSentData = New System.Windows.Forms.Label()
        Me.buttonStartStreamingLong = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.comboBoxProtocol = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.buttonStartConnect = New System.Windows.Forms.Button()
        Me.comboBoxCodecs = New System.Windows.Forms.ComboBox()
        Me.comboBoxInputDevices = New System.Windows.Forms.ComboBox()
        Me.textBoxPortS = New System.Windows.Forms.TextBox()
        Me.textBoxIPAddressS = New System.Windows.Forms.TextBox()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Enabled = False
        Me.button1.Location = New System.Drawing.Point(89, 59)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(157, 23)
        Me.button1.TabIndex = 43
        Me.button1.Text = "Send"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox4
        '
        Me.textBox4.Enabled = False
        Me.textBox4.Location = New System.Drawing.Point(255, 32)
        Me.textBox4.Multiline = True
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(258, 50)
        Me.textBox4.TabIndex = 42
        '
        'textBox3
        '
        Me.textBox3.Enabled = False
        Me.textBox3.Location = New System.Drawing.Point(255, 6)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(258, 20)
        Me.textBox3.TabIndex = 41
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 36)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(54, 13)
        Me.label2.TabIndex = 39
        Me.label2.Text = "Port Send"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(12, 9)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(54, 13)
        Me.label6.TabIndex = 40
        Me.label6.Text = "Server IP:"
        '
        'textBox1
        '
        Me.textBox1.Enabled = False
        Me.textBox1.Location = New System.Drawing.Point(89, 33)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(157, 20)
        Me.textBox1.TabIndex = 38
        Me.textBox1.Text = "12303"
        '
        'textBox2
        '
        Me.textBox2.Enabled = False
        Me.textBox2.Location = New System.Drawing.Point(89, 6)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(157, 20)
        Me.textBox2.TabIndex = 37
        Me.textBox2.Text = "197.81.192.173"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(252, 145)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(32, 13)
        Me.label9.TabIndex = 36
        Me.label9.Text = "Sent:"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(252, 118)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(56, 13)
        Me.label8.TabIndex = 35
        Me.label8.Text = "Received:"
        '
        'lblReceivedData
        '
        Me.lblReceivedData.AutoSize = True
        Me.lblReceivedData.Location = New System.Drawing.Point(314, 118)
        Me.lblReceivedData.Name = "lblReceivedData"
        Me.lblReceivedData.Size = New System.Drawing.Size(13, 13)
        Me.lblReceivedData.TabIndex = 33
        Me.lblReceivedData.Text = "0"
        '
        'lblSentData
        '
        Me.lblSentData.AutoSize = True
        Me.lblSentData.Location = New System.Drawing.Point(314, 145)
        Me.lblSentData.Name = "lblSentData"
        Me.lblSentData.Size = New System.Drawing.Size(13, 13)
        Me.lblSentData.TabIndex = 34
        Me.lblSentData.Text = "0"
        '
        'buttonStartStreamingLong
        '
        Me.buttonStartStreamingLong.Enabled = False
        Me.buttonStartStreamingLong.Location = New System.Drawing.Point(255, 254)
        Me.buttonStartStreamingLong.Name = "buttonStartStreamingLong"
        Me.buttonStartStreamingLong.Size = New System.Drawing.Size(258, 23)
        Me.buttonStartStreamingLong.TabIndex = 32
        Me.buttonStartStreamingLong.Text = "Turn Mic On"
        Me.buttonStartStreamingLong.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 230)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(46, 13)
        Me.label5.TabIndex = 31
        Me.label5.Text = "Protocol"
        '
        'comboBoxProtocol
        '
        Me.comboBoxProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxProtocol.FormattingEnabled = True
        Me.comboBoxProtocol.Location = New System.Drawing.Point(89, 227)
        Me.comboBoxProtocol.Name = "comboBoxProtocol"
        Me.comboBoxProtocol.Size = New System.Drawing.Size(424, 21)
        Me.comboBoxProtocol.TabIndex = 30
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(12, 202)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(67, 13)
        Me.label4.TabIndex = 29
        Me.label4.Text = "Compression"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 175)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(71, 13)
        Me.label3.TabIndex = 28
        Me.label3.Text = "Input Device:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(12, 145)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(54, 13)
        Me.label7.TabIndex = 27
        Me.label7.Text = "Port Send"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 118)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(54, 13)
        Me.label1.TabIndex = 26
        Me.label1.Text = "Server IP:"
        '
        'buttonStartConnect
        '
        Me.buttonStartConnect.Location = New System.Drawing.Point(89, 254)
        Me.buttonStartConnect.Name = "buttonStartConnect"
        Me.buttonStartConnect.Size = New System.Drawing.Size(160, 23)
        Me.buttonStartConnect.TabIndex = 25
        Me.buttonStartConnect.Text = "Connect"
        Me.buttonStartConnect.UseVisualStyleBackColor = True
        '
        'comboBoxCodecs
        '
        Me.comboBoxCodecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxCodecs.FormattingEnabled = True
        Me.comboBoxCodecs.Location = New System.Drawing.Point(89, 199)
        Me.comboBoxCodecs.Name = "comboBoxCodecs"
        Me.comboBoxCodecs.Size = New System.Drawing.Size(424, 21)
        Me.comboBoxCodecs.TabIndex = 24
        '
        'comboBoxInputDevices
        '
        Me.comboBoxInputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxInputDevices.FormattingEnabled = True
        Me.comboBoxInputDevices.Location = New System.Drawing.Point(89, 172)
        Me.comboBoxInputDevices.Name = "comboBoxInputDevices"
        Me.comboBoxInputDevices.Size = New System.Drawing.Size(424, 21)
        Me.comboBoxInputDevices.TabIndex = 23
        '
        'textBoxPortS
        '
        Me.textBoxPortS.Location = New System.Drawing.Point(89, 142)
        Me.textBoxPortS.Name = "textBoxPortS"
        Me.textBoxPortS.Size = New System.Drawing.Size(157, 20)
        Me.textBoxPortS.TabIndex = 22
        Me.textBoxPortS.Text = "3030"
        '
        'textBoxIPAddressS
        '
        Me.textBoxIPAddressS.Location = New System.Drawing.Point(89, 115)
        Me.textBoxIPAddressS.Name = "textBoxIPAddressS"
        Me.textBoxIPAddressS.Size = New System.Drawing.Size(157, 20)
        Me.textBoxIPAddressS.TabIndex = 21
        Me.textBoxIPAddressS.Text = "197.81.192.173"
        '
        'timer1
        '
        Me.timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 286)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.lblReceivedData)
        Me.Controls.Add(Me.lblSentData)
        Me.Controls.Add(Me.buttonStartStreamingLong)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.comboBoxProtocol)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.buttonStartConnect)
        Me.Controls.Add(Me.comboBoxCodecs)
        Me.Controls.Add(Me.comboBoxInputDevices)
        Me.Controls.Add(Me.textBoxPortS)
        Me.Controls.Add(Me.textBoxIPAddressS)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button1 As Windows.Forms.Button
    Private WithEvents textBox4 As Windows.Forms.TextBox
    Private WithEvents textBox3 As Windows.Forms.TextBox
    Private WithEvents label2 As Windows.Forms.Label
    Private WithEvents label6 As Windows.Forms.Label
    Private WithEvents textBox1 As Windows.Forms.TextBox
    Private WithEvents textBox2 As Windows.Forms.TextBox
    Private WithEvents label9 As Windows.Forms.Label
    Private WithEvents label8 As Windows.Forms.Label
    Private WithEvents lblReceivedData As Windows.Forms.Label
    Private WithEvents lblSentData As Windows.Forms.Label
    Private WithEvents buttonStartStreamingLong As Windows.Forms.Button
    Private WithEvents label5 As Windows.Forms.Label
    Private WithEvents comboBoxProtocol As Windows.Forms.ComboBox
    Private WithEvents label4 As Windows.Forms.Label
    Private WithEvents label3 As Windows.Forms.Label
    Private WithEvents label7 As Windows.Forms.Label
    Private WithEvents label1 As Windows.Forms.Label
    Private WithEvents buttonStartConnect As Windows.Forms.Button
    Private WithEvents comboBoxCodecs As Windows.Forms.ComboBox
    Private WithEvents comboBoxInputDevices As Windows.Forms.ComboBox
    Private WithEvents textBoxPortS As Windows.Forms.TextBox
    Private WithEvents textBoxIPAddressS As Windows.Forms.TextBox
    Private WithEvents timer1 As Windows.Forms.Timer
End Class
