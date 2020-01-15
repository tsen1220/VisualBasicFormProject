<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Scr1 = New System.Windows.Forms.HScrollBar()
        Me.Scr2 = New System.Windows.Forms.HScrollBar()
        Me.Scr3 = New System.Windows.Forms.HScrollBar()
        Me.Scr4 = New System.Windows.Forms.HScrollBar()
        Me.Scr5 = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(26, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 290)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.Location = New System.Drawing.Point(452, 381)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 57)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Scr1
        '
        Me.Scr1.Location = New System.Drawing.Point(452, 42)
        Me.Scr1.Name = "Scr1"
        Me.Scr1.Size = New System.Drawing.Size(303, 44)
        Me.Scr1.TabIndex = 2
        '
        'Scr2
        '
        Me.Scr2.Location = New System.Drawing.Point(452, 109)
        Me.Scr2.Name = "Scr2"
        Me.Scr2.Size = New System.Drawing.Size(303, 43)
        Me.Scr2.TabIndex = 3
        '
        'Scr3
        '
        Me.Scr3.Location = New System.Drawing.Point(452, 170)
        Me.Scr3.Name = "Scr3"
        Me.Scr3.Size = New System.Drawing.Size(303, 46)
        Me.Scr3.TabIndex = 4
        '
        'Scr4
        '
        Me.Scr4.Location = New System.Drawing.Point(452, 235)
        Me.Scr4.Name = "Scr4"
        Me.Scr4.Size = New System.Drawing.Size(303, 51)
        Me.Scr4.TabIndex = 5
        '
        'Scr5
        '
        Me.Scr5.Location = New System.Drawing.Point(452, 305)
        Me.Scr5.Name = "Scr5"
        Me.Scr5.Size = New System.Drawing.Size(303, 52)
        Me.Scr5.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "筆寬"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(379, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "顏色"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "R"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(379, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "G"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(379, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "B"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "細"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(758, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "粗"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(422, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "淺"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(758, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "深"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(592, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 57)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "清除"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(392, 402)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "調色盤"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Scr5)
        Me.Controls.Add(Me.Scr4)
        Me.Controls.Add(Me.Scr3)
        Me.Controls.Add(Me.Scr2)
        Me.Controls.Add(Me.Scr1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Scr1 As HScrollBar
    Friend WithEvents Scr2 As HScrollBar
    Friend WithEvents Scr3 As HScrollBar
    Friend WithEvents Scr4 As HScrollBar
    Friend WithEvents Scr5 As HScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
End Class
