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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GreenTextBox = New System.Windows.Forms.TextBox()
        Me.RedTextBox = New System.Windows.Forms.TextBox()
        Me.BlueTextBox = New System.Windows.Forms.TextBox()
        Me.ColorOvalButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red (0-255)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Blue (0-255)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Green (0-255)"
        '
        'ViewButton
        '
        Me.ViewButton.Location = New System.Drawing.Point(125, 348)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(128, 79)
        Me.ViewButton.TabIndex = 3
        Me.ViewButton.Text = "&View Color"
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(295, 348)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(122, 79)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GreenTextBox
        '
        Me.GreenTextBox.Location = New System.Drawing.Point(205, 282)
        Me.GreenTextBox.Name = "GreenTextBox"
        Me.GreenTextBox.Size = New System.Drawing.Size(100, 22)
        Me.GreenTextBox.TabIndex = 5
        '
        'RedTextBox
        '
        Me.RedTextBox.Location = New System.Drawing.Point(205, 105)
        Me.RedTextBox.Name = "RedTextBox"
        Me.RedTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RedTextBox.TabIndex = 6
        '
        'BlueTextBox
        '
        Me.BlueTextBox.Location = New System.Drawing.Point(205, 192)
        Me.BlueTextBox.Name = "BlueTextBox"
        Me.BlueTextBox.Size = New System.Drawing.Size(100, 22)
        Me.BlueTextBox.TabIndex = 7
        '
        'ColorOvalButton
        '
        Me.ColorOvalButton.Location = New System.Drawing.Point(481, 105)
        Me.ColorOvalButton.Name = "ColorOvalButton"
        Me.ColorOvalButton.Size = New System.Drawing.Size(243, 220)
        Me.ColorOvalButton.TabIndex = 8
        Me.ColorOvalButton.Text = "Color:"
        Me.ColorOvalButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ColorOvalButton)
        Me.Controls.Add(Me.BlueTextBox)
        Me.Controls.Add(Me.RedTextBox)
        Me.Controls.Add(Me.GreenTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Blake's Color Mixer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ViewButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents GreenTextBox As TextBox
    Friend WithEvents RedTextBox As TextBox
    Friend WithEvents BlueTextBox As TextBox
    Friend WithEvents ColorOvalButton As Button
End Class
