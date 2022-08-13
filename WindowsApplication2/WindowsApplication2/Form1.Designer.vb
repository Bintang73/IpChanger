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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bPing = New System.Windows.Forms.Button()
        Me.boxNet = New System.Windows.Forms.ComboBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.TextIp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextMask = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextGateway = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextDns = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(96, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'bPing
        '
        Me.bPing.Location = New System.Drawing.Point(23, 216)
        Me.bPing.Name = "bPing"
        Me.bPing.Size = New System.Drawing.Size(75, 23)
        Me.bPing.TabIndex = 2
        Me.bPing.Text = "About"
        Me.bPing.UseVisualStyleBackColor = True
        '
        'boxNet
        '
        Me.boxNet.FormattingEnabled = True
        Me.boxNet.Location = New System.Drawing.Point(42, 31)
        Me.boxNet.Name = "boxNet"
        Me.boxNet.Size = New System.Drawing.Size(205, 21)
        Me.boxNet.TabIndex = 3
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'TextIp
        '
        Me.TextIp.Location = New System.Drawing.Point(96, 69)
        Me.TextIp.Name = "TextIp"
        Me.TextIp.Size = New System.Drawing.Size(151, 20)
        Me.TextIp.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ip Address"
        '
        'TextMask
        '
        Me.TextMask.Location = New System.Drawing.Point(96, 94)
        Me.TextMask.Name = "TextMask"
        Me.TextMask.Size = New System.Drawing.Size(151, 20)
        Me.TextMask.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Subnet Mask"
        '
        'TextGateway
        '
        Me.TextGateway.Location = New System.Drawing.Point(96, 120)
        Me.TextGateway.Name = "TextGateway"
        Me.TextGateway.Size = New System.Drawing.Size(151, 20)
        Me.TextGateway.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Gateway"
        '
        'TextDns
        '
        Me.TextDns.Location = New System.Drawing.Point(96, 146)
        Me.TextDns.Name = "TextDns"
        Me.TextDns.Size = New System.Drawing.Size(151, 20)
        Me.TextDns.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "DNS"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(172, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Instagram"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextDns)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextGateway)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextMask)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextIp)
        Me.Controls.Add(Me.boxNet)
        Me.Controls.Add(Me.bPing)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.Text = "Change IP"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents bPing As Button
    Friend WithEvents boxNet As ComboBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents TextIp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextMask As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextDns As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextGateway As TextBox
    Friend WithEvents Button2 As Button
End Class
