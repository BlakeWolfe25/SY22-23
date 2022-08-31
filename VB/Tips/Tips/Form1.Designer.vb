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
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.GrandTotalLabel = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.subtotalLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(265, 97)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(108, 44)
        Me.CalcButton.TabIndex = 0
        Me.CalcButton.Text = "Confirm Tip"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'GrandTotalLabel
        '
        Me.GrandTotalLabel.AutoSize = True
        Me.GrandTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandTotalLabel.Location = New System.Drawing.Point(435, 202)
        Me.GrandTotalLabel.Name = "GrandTotalLabel"
        Me.GrandTotalLabel.Size = New System.Drawing.Size(26, 29)
        Me.GrandTotalLabel.TabIndex = 1
        Me.GrandTotalLabel.Text = "0"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(399, 97)
        Me.TotalTextBox.Multiline = True
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(125, 44)
        Me.TotalTextBox.TabIndex = 2
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(117, 252)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(124, 33)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "10% Tip"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(289, 252)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(124, 33)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "15% Tip"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(473, 252)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(124, 33)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "20% Tip"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Tips.My.Resources.Resources.MAY2019_disbursements_kickfin_cash_management_restaurant_tipping
        Me.PictureBox2.Location = New System.Drawing.Point(550, 97)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(219, 134)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Tips.My.Resources.Resources.Good_Server_Tips_and_Tricks
        Me.PictureBox1.Location = New System.Drawing.Point(14, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Grand Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(267, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Subtotal:"
        '
        'subtotalLabel
        '
        Me.subtotalLabel.AutoSize = True
        Me.subtotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotalLabel.Location = New System.Drawing.Point(435, 159)
        Me.subtotalLabel.Name = "subtotalLabel"
        Me.subtotalLabel.Size = New System.Drawing.Size(26, 29)
        Me.subtotalLabel.TabIndex = 10
        Me.subtotalLabel.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.subtotalLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.GrandTotalLabel)
        Me.Controls.Add(Me.CalcButton)
        Me.Name = "Form1"
        Me.Text = "Tip Calculator"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalcButton As Button
    Friend WithEvents GrandTotalLabel As Label
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents subtotalLabel As Label
End Class
