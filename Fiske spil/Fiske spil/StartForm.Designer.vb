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
        Me.Fisk = New System.Windows.Forms.PictureBox()
        Me.Akvarie = New System.Windows.Forms.PictureBox()
        CType(Me.Fisk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Akvarie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Akvarie.Image = Global.Fiske_spil.My.Resources.Resources.Starter
        Me.Akvarie.Location = New System.Drawing.Point(-1, 175)
        Me.Akvarie.Name = "Akvarie"
        Me.Akvarie.Size = New System.Drawing.Size(387, 229)
        Me.Akvarie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Akvarie.TabIndex = 0
        Me.Akvarie.TabStop = False
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 403)
        Me.Controls.Add(Me.Fisk)
        Me.Controls.Add(Me.Akvarie)
        Me.Name = "StartForm"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.DarkOrange
        CType(Me.Fisk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Akvarie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Akvarie As System.Windows.Forms.PictureBox
    Friend WithEvents Fisk As System.Windows.Forms.PictureBox

End Class
