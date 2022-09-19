<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Jordan4sTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Blake_s_5_Item_Store.My.Resources.Resources.Air_Jordan_4_Red_Thunder_CT8527_016_2_2
        Me.PictureBox1.Location = New System.Drawing.Point(253, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(290, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Jordan4sTextBox
        '
        Me.Jordan4sTextBox.Location = New System.Drawing.Point(266, 324)
        Me.Jordan4sTextBox.Name = "Jordan4sTextBox"
        Me.Jordan4sTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Jordan4sTextBox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(425, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add to cart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Jordan 4s Red Thunder very comfortable"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(215, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(354, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "They work as a great everyday tennis shoe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(368, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "$200"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(621, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 55)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Close Tab"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Jordan4sTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form5"
        Me.Text = "Jordan 4s Red Thunder"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Jordan4sTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
