<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnSendSMS = New System.Windows.Forms.Button()
        Me.btnClearMessage = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtboxSender = New System.Windows.Forms.TextBox()
        Me.lblSender = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtboxMessage = New System.Windows.Forms.TextBox()
        Me.lblCharctersLeftNum = New System.Windows.Forms.Label()
        Me.lblCharctersLeft = New System.Windows.Forms.Label()
        Me.lblRecipients = New System.Windows.Forms.Label()
        Me.txtboxRecipients = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSendSMS
        '
        Me.btnSendSMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendSMS.Location = New System.Drawing.Point(531, 245)
        Me.btnSendSMS.Name = "btnSendSMS"
        Me.btnSendSMS.Size = New System.Drawing.Size(99, 48)
        Me.btnSendSMS.TabIndex = 0
        Me.btnSendSMS.Text = "Send SMS"
        Me.btnSendSMS.UseVisualStyleBackColor = True
        '
        'btnClearMessage
        '
        Me.btnClearMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearMessage.Location = New System.Drawing.Point(642, 245)
        Me.btnClearMessage.Name = "btnClearMessage"
        Me.btnClearMessage.Size = New System.Drawing.Size(91, 48)
        Me.btnClearMessage.TabIndex = 1
        Me.btnClearMessage.Text = "Clear Message"
        Me.btnClearMessage.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(775, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'txtboxSender
        '
        Me.txtboxSender.Location = New System.Drawing.Point(479, 50)
        Me.txtboxSender.Name = "txtboxSender"
        Me.txtboxSender.Size = New System.Drawing.Size(255, 20)
        Me.txtboxSender.TabIndex = 3
        '
        'lblSender
        '
        Me.lblSender.AutoSize = True
        Me.lblSender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSender.Location = New System.Drawing.Point(398, 49)
        Me.lblSender.Name = "lblSender"
        Me.lblSender.Size = New System.Drawing.Size(59, 18)
        Me.lblSender.TabIndex = 4
        Me.lblSender.Text = "Sender:"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(398, 100)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(73, 18)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.Text = "Message:"
        '
        'txtboxMessage
        '
        Me.txtboxMessage.Location = New System.Drawing.Point(479, 97)
        Me.txtboxMessage.MaxLength = 160
        Me.txtboxMessage.Multiline = True
        Me.txtboxMessage.Name = "txtboxMessage"
        Me.txtboxMessage.Size = New System.Drawing.Size(255, 100)
        Me.txtboxMessage.TabIndex = 6
        '
        'lblCharctersLeftNum
        '
        Me.lblCharctersLeftNum.AutoSize = True
        Me.lblCharctersLeftNum.Location = New System.Drawing.Point(694, 209)
        Me.lblCharctersLeftNum.Name = "lblCharctersLeftNum"
        Me.lblCharctersLeftNum.Size = New System.Drawing.Size(0, 13)
        Me.lblCharctersLeftNum.TabIndex = 8
        '
        'lblCharctersLeft
        '
        Me.lblCharctersLeft.AutoSize = True
        Me.lblCharctersLeft.Location = New System.Drawing.Point(639, 209)
        Me.lblCharctersLeft.Name = "lblCharctersLeft"
        Me.lblCharctersLeft.Size = New System.Drawing.Size(60, 13)
        Me.lblCharctersLeft.TabIndex = 7
        Me.lblCharctersLeft.Text = "Remaining:"
        '
        'lblRecipients
        '
        Me.lblRecipients.AutoSize = True
        Me.lblRecipients.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecipients.Location = New System.Drawing.Point(12, 49)
        Me.lblRecipients.Name = "lblRecipients"
        Me.lblRecipients.Size = New System.Drawing.Size(81, 18)
        Me.lblRecipients.TabIndex = 9
        Me.lblRecipients.Text = "Recipients:"
        '
        'txtboxRecipients
        '
        Me.txtboxRecipients.Location = New System.Drawing.Point(99, 50)
        Me.txtboxRecipients.MaxLength = 160
        Me.txtboxRecipients.Multiline = True
        Me.txtboxRecipients.Name = "txtboxRecipients"
        Me.txtboxRecipients.Size = New System.Drawing.Size(255, 147)
        Me.txtboxRecipients.TabIndex = 10
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 306)
        Me.Controls.Add(Me.txtboxRecipients)
        Me.Controls.Add(Me.lblRecipients)
        Me.Controls.Add(Me.lblCharctersLeftNum)
        Me.Controls.Add(Me.lblCharctersLeft)
        Me.Controls.Add(Me.txtboxMessage)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblSender)
        Me.Controls.Add(Me.txtboxSender)
        Me.Controls.Add(Me.btnClearMessage)
        Me.Controls.Add(Me.btnSendSMS)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = " SMS Sender"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSendSMS As System.Windows.Forms.Button
    Friend WithEvents btnClearMessage As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtboxSender As System.Windows.Forms.TextBox
    Friend WithEvents lblSender As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents txtboxMessage As System.Windows.Forms.TextBox
    Friend WithEvents lblCharctersLeftNum As System.Windows.Forms.Label
    Friend WithEvents lblCharctersLeft As System.Windows.Forms.Label
    Friend WithEvents lblRecipients As System.Windows.Forms.Label
    Friend WithEvents txtboxRecipients As System.Windows.Forms.TextBox

End Class
