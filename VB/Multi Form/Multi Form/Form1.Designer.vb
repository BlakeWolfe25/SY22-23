﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ATextBox = New System.Windows.Forms.TextBox()
        Me.BTextBox = New System.Windows.Forms.TextBox()
        Me.CTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'ATextBox
        '
        Me.ATextBox.Location = New System.Drawing.Point(300, 82)
        Me.ATextBox.Name = "ATextBox"
        Me.ATextBox.Size = New System.Drawing.Size(100, 25)
        Me.ATextBox.TabIndex = 3
        '
        'BTextBox
        '
        Me.BTextBox.Location = New System.Drawing.Point(300, 204)
        Me.BTextBox.Name = "BTextBox"
        Me.BTextBox.Size = New System.Drawing.Size(100, 25)
        Me.BTextBox.TabIndex = 4
        '
        'CTextBox
        '
        Me.CTextBox.Location = New System.Drawing.Point(300, 310)
        Me.CTextBox.Name = "CTextBox"
        Me.CTextBox.Size = New System.Drawing.Size(100, 25)
        Me.CTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(458, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 56)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Get Values"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(458, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 56)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Form 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(458, 310)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 56)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Form3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 534)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CTextBox)
        Me.Controls.Add(Me.BTextBox)
        Me.Controls.Add(Me.ATextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Multi Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ATextBox As TextBox
    Friend WithEvents BTextBox As TextBox
    Friend WithEvents CTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
