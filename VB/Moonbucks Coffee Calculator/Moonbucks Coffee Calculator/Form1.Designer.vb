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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AdressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.RegularTextBox = New System.Windows.Forms.TextBox()
        Me.DecafTextBox = New System.Windows.Forms.TextBox()
        Me.PoundsTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(822, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Caculate Order:"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(822, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 58)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "&Print Order:"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(822, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 52)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "&Clear Order:"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(822, 470)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 53)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "&Exit:"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "&Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "&Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&City:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 470)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&State:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(256, 470)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Zip:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(361, 470)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "&Regular:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(482, 470)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "&Decaf:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(818, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Pounds Ordered:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(818, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Total Price:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(124, 79)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(225, 27)
        Me.NameTextBox.TabIndex = 13
        '
        'AdressTextBox
        '
        Me.AdressTextBox.Location = New System.Drawing.Point(124, 146)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(225, 27)
        Me.AdressTextBox.TabIndex = 14
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(124, 220)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(225, 27)
        Me.CityTextBox.TabIndex = 15
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(106, 496)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 27)
        Me.StateTextBox.TabIndex = 16
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(227, 496)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 27)
        Me.ZipTextBox.TabIndex = 17
        '
        'RegularTextBox
        '
        Me.RegularTextBox.Location = New System.Drawing.Point(347, 496)
        Me.RegularTextBox.Name = "RegularTextBox"
        Me.RegularTextBox.Size = New System.Drawing.Size(100, 27)
        Me.RegularTextBox.TabIndex = 18
        '
        'DecafTextBox
        '
        Me.DecafTextBox.Location = New System.Drawing.Point(467, 496)
        Me.DecafTextBox.Name = "DecafTextBox"
        Me.DecafTextBox.Size = New System.Drawing.Size(100, 27)
        Me.DecafTextBox.TabIndex = 19
        '
        'PoundsTextBox
        '
        Me.PoundsTextBox.Location = New System.Drawing.Point(822, 123)
        Me.PoundsTextBox.Name = "PoundsTextBox"
        Me.PoundsTextBox.Size = New System.Drawing.Size(100, 27)
        Me.PoundsTextBox.TabIndex = 20
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(822, 201)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 27)
        Me.TotalTextBox.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 562)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.PoundsTextBox)
        Me.Controls.Add(Me.DecafTextBox)
        Me.Controls.Add(Me.RegularTextBox)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AdressTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Moonbucks Coffee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AdressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents RegularTextBox As TextBox
    Friend WithEvents DecafTextBox As TextBox
    Friend WithEvents PoundsTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
End Class
