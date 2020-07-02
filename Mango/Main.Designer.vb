<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits MetroFramework.Forms.MetroForm

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
        Me.timerSpamInterval = New System.Windows.Forms.Timer(Me.components)
        Me.txtInterval = New MetroFramework.Controls.MetroTextBox()
        Me.txtInput = New MetroFramework.Controls.MetroTextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.ToolTipManager = New MetroFramework.Components.MetroToolTip()
        Me.txtLoops = New MetroFramework.Controls.MetroTextBox()
        Me.iconInput = New System.Windows.Forms.PictureBox()
        Me.iconInterval = New System.Windows.Forms.PictureBox()
        Me.iconLoops = New System.Windows.Forms.PictureBox()
        Me.btnContrast = New System.Windows.Forms.PictureBox()
        CType(Me.iconInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconLoops, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerSpamInterval
        '
        Me.timerSpamInterval.Interval = 1
        '
        'txtInterval
        '
        Me.txtInterval.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.txtInterval.CustomButton.Image = Nothing
        Me.txtInterval.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtInterval.CustomButton.Name = ""
        Me.txtInterval.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtInterval.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtInterval.CustomButton.TabIndex = 1
        Me.txtInterval.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtInterval.CustomButton.UseSelectable = True
        Me.txtInterval.CustomButton.Visible = False
        Me.txtInterval.Lines = New String(-1) {}
        Me.txtInterval.Location = New System.Drawing.Point(177, 104)
        Me.txtInterval.MaxLength = 32767
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInterval.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInterval.SelectedText = ""
        Me.txtInterval.SelectionLength = 0
        Me.txtInterval.SelectionStart = 0
        Me.txtInterval.ShortcutsEnabled = True
        Me.txtInterval.Size = New System.Drawing.Size(75, 23)
        Me.txtInterval.TabIndex = 2
        Me.txtInterval.TabStop = False
        Me.txtInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipManager.SetToolTip(Me.txtInterval, "Interval of the spam in milliseconds")
        Me.txtInterval.UseSelectable = True
        Me.txtInterval.WaterMark = "Interval"
        Me.txtInterval.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtInterval.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtInput
        '
        Me.txtInput.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.txtInput.CustomButton.Image = Nothing
        Me.txtInput.CustomButton.Location = New System.Drawing.Point(107, 1)
        Me.txtInput.CustomButton.Name = ""
        Me.txtInput.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtInput.CustomButton.TabIndex = 1
        Me.txtInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtInput.CustomButton.UseSelectable = True
        Me.txtInput.CustomButton.Visible = False
        Me.txtInput.Lines = New String(-1) {}
        Me.txtInput.Location = New System.Drawing.Point(150, 68)
        Me.txtInput.MaxLength = 32767
        Me.txtInput.Name = "txtInput"
        Me.txtInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInput.SelectedText = ""
        Me.txtInput.SelectionLength = 0
        Me.txtInput.SelectionStart = 0
        Me.txtInput.ShortcutsEnabled = True
        Me.txtInput.Size = New System.Drawing.Size(129, 23)
        Me.txtInput.TabIndex = 3
        Me.txtInput.TabStop = False
        Me.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipManager.SetToolTip(Me.txtInput, "Text you would like to output from the spammer")
        Me.txtInput.UseSelectable = True
        Me.txtInput.WaterMark = "Spam text"
        Me.txtInput.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtInput.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(150, 176)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(128, 13)
        Me.lblInfo.TabIndex = 4
        Me.lblInfo.Text = "F2 = START | F3 = STOP"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.ForeColor = System.Drawing.Color.Red
        Me.lblState.Location = New System.Drawing.Point(2, 8)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(27, 13)
        Me.lblState.TabIndex = 5
        Me.lblState.Text = "OFF"
        '
        'ToolTipManager
        '
        Me.ToolTipManager.Style = MetroFramework.MetroColorStyle.Orange
        Me.ToolTipManager.StyleManager = Nothing
        Me.ToolTipManager.Theme = MetroFramework.MetroThemeStyle.[Default]
        '
        'txtLoops
        '
        Me.txtLoops.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.txtLoops.CustomButton.Image = Nothing
        Me.txtLoops.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtLoops.CustomButton.Name = ""
        Me.txtLoops.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLoops.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLoops.CustomButton.TabIndex = 1
        Me.txtLoops.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLoops.CustomButton.UseSelectable = True
        Me.txtLoops.CustomButton.Visible = False
        Me.txtLoops.Lines = New String(-1) {}
        Me.txtLoops.Location = New System.Drawing.Point(177, 140)
        Me.txtLoops.MaxLength = 32767
        Me.txtLoops.Name = "txtLoops"
        Me.txtLoops.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLoops.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLoops.SelectedText = ""
        Me.txtLoops.SelectionLength = 0
        Me.txtLoops.SelectionStart = 0
        Me.txtLoops.ShortcutsEnabled = True
        Me.txtLoops.Size = New System.Drawing.Size(75, 23)
        Me.txtLoops.TabIndex = 6
        Me.txtLoops.TabStop = False
        Me.txtLoops.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipManager.SetToolTip(Me.txtLoops, "Number of loops the spammer will perform before turning off (OPTIONAL)")
        Me.txtLoops.UseSelectable = True
        Me.txtLoops.WaterMark = "Loops"
        Me.txtLoops.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLoops.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'iconInput
        '
        Me.iconInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconInput.Cursor = System.Windows.Forms.Cursors.Default
        Me.iconInput.Image = Global.MangoSpammer.My.Resources.Resources.darkinput
        Me.iconInput.Location = New System.Drawing.Point(116, 66)
        Me.iconInput.Name = "iconInput"
        Me.iconInput.Size = New System.Drawing.Size(28, 26)
        Me.iconInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconInput.TabIndex = 9
        Me.iconInput.TabStop = False
        '
        'iconInterval
        '
        Me.iconInterval.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconInterval.Cursor = System.Windows.Forms.Cursors.Default
        Me.iconInterval.Image = Global.MangoSpammer.My.Resources.Resources.darkinterval
        Me.iconInterval.Location = New System.Drawing.Point(143, 102)
        Me.iconInterval.Name = "iconInterval"
        Me.iconInterval.Size = New System.Drawing.Size(28, 26)
        Me.iconInterval.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconInterval.TabIndex = 8
        Me.iconInterval.TabStop = False
        '
        'iconLoops
        '
        Me.iconLoops.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.iconLoops.Cursor = System.Windows.Forms.Cursors.Default
        Me.iconLoops.Image = Global.MangoSpammer.My.Resources.Resources.darkloop
        Me.iconLoops.Location = New System.Drawing.Point(144, 138)
        Me.iconLoops.Name = "iconLoops"
        Me.iconLoops.Size = New System.Drawing.Size(28, 26)
        Me.iconLoops.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconLoops.TabIndex = 7
        Me.iconLoops.TabStop = False
        '
        'btnContrast
        '
        Me.btnContrast.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContrast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContrast.Image = Global.MangoSpammer.My.Resources.Resources.dark
        Me.btnContrast.Location = New System.Drawing.Point(396, 173)
        Me.btnContrast.Name = "btnContrast"
        Me.btnContrast.Size = New System.Drawing.Size(28, 26)
        Me.btnContrast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnContrast.TabIndex = 1
        Me.btnContrast.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 203)
        Me.Controls.Add(Me.iconInput)
        Me.Controls.Add(Me.iconInterval)
        Me.Controls.Add(Me.iconLoops)
        Me.Controls.Add(Me.txtLoops)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.txtInterval)
        Me.Controls.Add(Me.btnContrast)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(428, 203)
        Me.MinimumSize = New System.Drawing.Size(250, 203)
        Me.Name = "Main"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Mango Spammer"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.iconInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconLoops, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnContrast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents timerSpamInterval As Timer
    Friend WithEvents btnContrast As PictureBox
    Friend WithEvents txtInterval As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtInput As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblState As Label
    Friend WithEvents ToolTipManager As MetroFramework.Components.MetroToolTip
    Friend WithEvents txtLoops As MetroFramework.Controls.MetroTextBox
    Friend WithEvents iconLoops As PictureBox
    Friend WithEvents iconInterval As PictureBox
    Friend WithEvents iconInput As PictureBox
End Class
