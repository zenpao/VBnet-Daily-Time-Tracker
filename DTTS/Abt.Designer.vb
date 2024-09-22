<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Abt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Abt))
        Me.rchAbout = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rchAbout
        '
        Me.rchAbout.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rchAbout.ForeColor = System.Drawing.Color.Black
        Me.rchAbout.Location = New System.Drawing.Point(16, 15)
        Me.rchAbout.Margin = New System.Windows.Forms.Padding(4)
        Me.rchAbout.Name = "rchAbout"
        Me.rchAbout.ReadOnly = True
        Me.rchAbout.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rchAbout.Size = New System.Drawing.Size(355, 218)
        Me.rchAbout.TabIndex = 0
        Me.rchAbout.Text = resources.GetString("rchAbout.Text")
        '
        'Abt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(388, 251)
        Me.Controls.Add(Me.rchAbout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Abt"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About DTTS"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rchAbout As System.Windows.Forms.RichTextBox
End Class
