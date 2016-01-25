<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BubbleBlast
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
        Me.TheEnvironment = New Bubble_Blast_VB.Environment()
        Me.numberOfClicksLabel = New System.Windows.Forms.Label()
        Me.TheEnvironment.SuspendLayout()
        Me.SuspendLayout()
        '
        'TheEnvironment
        '
        Me.TheEnvironment.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TheEnvironment.Controls.Add(Me.numberOfClicksLabel)
        Me.TheEnvironment.Location = New System.Drawing.Point(12, 12)
        Me.TheEnvironment.Name = "TheEnvironment"
        Me.TheEnvironment.numberOfClicks = 0
        Me.TheEnvironment.Size = New System.Drawing.Size(600, 417)
        Me.TheEnvironment.TabIndex = 0
        '
        'numberOfClicksLabel
        '
        Me.numberOfClicksLabel.AutoSize = True
        Me.numberOfClicksLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.numberOfClicksLabel.Location = New System.Drawing.Point(3, 399)
        Me.numberOfClicksLabel.Name = "numberOfClicksLabel"
        Me.numberOfClicksLabel.Size = New System.Drawing.Size(138, 18)
        Me.numberOfClicksLabel.TabIndex = 1
        Me.numberOfClicksLabel.Text = "Number Of Clicks : "
        '
        'BubbleBlast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.TheEnvironment)
        Me.Name = "BubbleBlast"
        Me.Text = "Bubble Blast"
        Me.TheEnvironment.ResumeLayout(False)
        Me.TheEnvironment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TheEnvironment As Bubble_Blast_VB.Environment
    Friend WithEvents numberOfClicksLabel As System.Windows.Forms.Label

End Class
