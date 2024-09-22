<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DTR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DTR))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lnkRemove = New System.Windows.Forms.LinkLabel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbTT1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMM1 = New System.Windows.Forms.ComboBox()
        Me.cmbHH1 = New System.Windows.Forms.ComboBox()
        Me.lblTimeIn = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblCalendar = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad2 = New System.Windows.Forms.RadioButton()
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.cmbTT2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMM2 = New System.Windows.Forms.ComboBox()
        Me.cmbHH2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lnkViewUserRecords = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRem = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(20, 117)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lnkRemove
        '
        Me.lnkRemove.AutoSize = True
        Me.lnkRemove.BackColor = System.Drawing.Color.Transparent
        Me.lnkRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkRemove.Location = New System.Drawing.Point(380, 58)
        Me.lnkRemove.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkRemove.Name = "lnkRemove"
        Me.lnkRemove.Size = New System.Drawing.Size(40, 17)
        Me.lnkRemove.TabIndex = 3
        Me.lnkRemove.TabStop = True
        Me.lnkRemove.Text = "reset"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(253, 18)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 17)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "null"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(345, 18)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(30, 17)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "null"
        '
        'Timer1
        '
        '
        'cmbTT1
        '
        Me.cmbTT1.BackColor = System.Drawing.Color.Gold
        Me.cmbTT1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbTT1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTT1.FormattingEnabled = True
        Me.cmbTT1.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbTT1.Location = New System.Drawing.Point(303, 176)
        Me.cmbTT1.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTT1.Name = "cmbTT1"
        Me.cmbTT1.Size = New System.Drawing.Size(57, 24)
        Me.cmbTT1.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 180)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = ":"
        '
        'cmbMM1
        '
        Me.cmbMM1.BackColor = System.Drawing.Color.Gold
        Me.cmbMM1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbMM1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMM1.FormattingEnabled = True
        Me.cmbMM1.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cmbMM1.Location = New System.Drawing.Point(236, 176)
        Me.cmbMM1.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMM1.Name = "cmbMM1"
        Me.cmbMM1.Size = New System.Drawing.Size(57, 24)
        Me.cmbMM1.TabIndex = 44
        '
        'cmbHH1
        '
        Me.cmbHH1.BackColor = System.Drawing.Color.Gold
        Me.cmbHH1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbHH1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHH1.FormattingEnabled = True
        Me.cmbHH1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbHH1.Location = New System.Drawing.Point(153, 176)
        Me.cmbHH1.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbHH1.Name = "cmbHH1"
        Me.cmbHH1.Size = New System.Drawing.Size(57, 24)
        Me.cmbHH1.TabIndex = 43
        '
        'lblTimeIn
        '
        Me.lblTimeIn.AutoSize = True
        Me.lblTimeIn.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeIn.Location = New System.Drawing.Point(75, 186)
        Me.lblTimeIn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimeIn.Name = "lblTimeIn"
        Me.lblTimeIn.Size = New System.Drawing.Size(66, 17)
        Me.lblTimeIn.TabIndex = 47
        Me.lblTimeIn.Text = "Time In:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.Location = New System.Drawing.Point(79, 143)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(281, 22)
        Me.DateTimePicker1.TabIndex = 42
        '
        'lblCalendar
        '
        Me.lblCalendar.AutoSize = True
        Me.lblCalendar.BackColor = System.Drawing.Color.Transparent
        Me.lblCalendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalendar.Location = New System.Drawing.Point(27, 150)
        Me.lblCalendar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCalendar.Name = "lblCalendar"
        Me.lblCalendar.Size = New System.Drawing.Size(47, 17)
        Me.lblCalendar.TabIndex = 46
        Me.lblCalendar.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(0, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 17)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "_____________________________________________________"
        '
        'btnRecord
        '
        Me.btnRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRecord.Location = New System.Drawing.Point(320, 309)
        Me.btnRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(100, 28)
        Me.btnRecord.TabIndex = 50
        Me.btnRecord.Text = "Record"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rad2)
        Me.GroupBox1.Controls.Add(Me.rad1)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 33)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(229, 47)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "select"
        '
        'rad2
        '
        Me.rad2.AutoSize = True
        Me.rad2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rad2.Location = New System.Drawing.Point(115, 18)
        Me.rad2.Margin = New System.Windows.Forms.Padding(4)
        Me.rad2.Name = "rad2"
        Me.rad2.Size = New System.Drawing.Size(87, 21)
        Me.rad2.TabIndex = 1
        Me.rad2.TabStop = True
        Me.rad2.Text = "Time Out"
        Me.rad2.UseVisualStyleBackColor = True
        '
        'rad1
        '
        Me.rad1.AutoSize = True
        Me.rad1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rad1.Location = New System.Drawing.Point(25, 18)
        Me.rad1.Margin = New System.Windows.Forms.Padding(4)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(75, 21)
        Me.rad1.TabIndex = 0
        Me.rad1.TabStop = True
        Me.rad1.Text = "Time In"
        Me.rad1.UseVisualStyleBackColor = True
        '
        'cmbTT2
        '
        Me.cmbTT2.BackColor = System.Drawing.Color.Gold
        Me.cmbTT2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbTT2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTT2.FormattingEnabled = True
        Me.cmbTT2.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbTT2.Location = New System.Drawing.Point(303, 214)
        Me.cmbTT2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTT2.Name = "cmbTT2"
        Me.cmbTT2.Size = New System.Drawing.Size(57, 24)
        Me.cmbTT2.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(217, 218)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = ":"
        '
        'cmbMM2
        '
        Me.cmbMM2.BackColor = System.Drawing.Color.Gold
        Me.cmbMM2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbMM2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMM2.FormattingEnabled = True
        Me.cmbMM2.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cmbMM2.Location = New System.Drawing.Point(236, 214)
        Me.cmbMM2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMM2.Name = "cmbMM2"
        Me.cmbMM2.Size = New System.Drawing.Size(57, 24)
        Me.cmbMM2.TabIndex = 53
        '
        'cmbHH2
        '
        Me.cmbHH2.BackColor = System.Drawing.Color.Gold
        Me.cmbHH2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbHH2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHH2.FormattingEnabled = True
        Me.cmbHH2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbHH2.Location = New System.Drawing.Point(153, 214)
        Me.cmbHH2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbHH2.Name = "cmbHH2"
        Me.cmbHH2.Size = New System.Drawing.Size(57, 24)
        Me.cmbHH2.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 219)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Time Out:"
        '
        'lnkViewUserRecords
        '
        Me.lnkViewUserRecords.AutoSize = True
        Me.lnkViewUserRecords.BackColor = System.Drawing.Color.Transparent
        Me.lnkViewUserRecords.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkViewUserRecords.Location = New System.Drawing.Point(79, 116)
        Me.lnkViewUserRecords.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkViewUserRecords.Name = "lnkViewUserRecords"
        Me.lnkViewUserRecords.Size = New System.Drawing.Size(71, 17)
        Me.lnkViewUserRecords.TabIndex = 57
        Me.lnkViewUserRecords.TabStop = True
        Me.lnkViewUserRecords.Text = "\user:view"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(435, 30)
        Me.MenuStrip1.TabIndex = 58
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.OptionsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(75, 26)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.LogoutToolStripMenuItem.Text = "Log-out"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 255)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Remarks:"
        '
        'txtRem
        '
        Me.txtRem.Location = New System.Drawing.Point(153, 252)
        Me.txtRem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRem.Name = "txtRem"
        Me.txtRem.Size = New System.Drawing.Size(207, 22)
        Me.txtRem.TabIndex = 60
        '
        'DTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(435, 345)
        Me.Controls.Add(Me.txtRem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lnkViewUserRecords)
        Me.Controls.Add(Me.cmbTT2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbMM2)
        Me.Controls.Add(Me.cmbHH2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTT1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMM1)
        Me.Controls.Add(Me.cmbHH1)
        Me.Controls.Add(Me.lblTimeIn)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblCalendar)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lnkRemove)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "DTR"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timekeeping"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lnkRemove As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmbTT1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMM1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHH1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblTimeIn As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCalendar As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rad2 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmbTT2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMM2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHH2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lnkViewUserRecords As System.Windows.Forms.LinkLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRem As TextBox
End Class
