<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Fisk = New System.Windows.Forms.PictureBox()
        Me.Akvarie = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Fisk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Akvarie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(165, 19)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(346, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 71)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'Fisk
        '
        Me.Fisk.BackColor = System.Drawing.Color.Transparent
        Me.Fisk.Image = Global.Fiske_spil.My.Resources.Resources.Fisk
        Me.Fisk.Location = New System.Drawing.Point(193, 222)
        Me.Fisk.Name = "Fisk"
        Me.Fisk.Size = New System.Drawing.Size(139, 77)
        Me.Fisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Fisk.TabIndex = 1
        Me.Fisk.TabStop = False
        '
        'Akvarie
        '
        Me.Akvarie.BackColor = System.Drawing.Color.Transparent
        Me.Akvarie.Image = Global.Fiske_spil.My.Resources.Resources.Starter
        Me.Akvarie.Location = New System.Drawing.Point(0, 171)
        Me.Akvarie.Name = "Akvarie"
        Me.Akvarie.Size = New System.Drawing.Size(550, 317)
        Me.Akvarie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Akvarie.TabIndex = 0
        Me.Akvarie.TabStop = False
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 488)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Fisk)
        Me.Controls.Add(Me.Akvarie)
        Me.Name = "StartForm"
        Me.Text = "Fiske spil!"
        Me.TransparencyKey = System.Drawing.Color.DarkOrange
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Fisk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Akvarie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Akvarie As System.Windows.Forms.PictureBox
    Friend WithEvents Fisk As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
