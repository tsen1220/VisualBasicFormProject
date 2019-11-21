<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.編輯ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字體ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.顏色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.藍色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.紅色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.結束ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(119, 174)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(411, 25)
        Me.TextBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.編輯ToolStripMenuItem, Me.結束ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(679, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '編輯ToolStripMenuItem
        '
        Me.編輯ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.字體ToolStripMenuItem, Me.顏色ToolStripMenuItem})
        Me.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem"
        Me.編輯ToolStripMenuItem.Size = New System.Drawing.Size(51, 23)
        Me.編輯ToolStripMenuItem.Text = "編輯"
        '
        '字體ToolStripMenuItem
        '
        Me.字體ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.字體ToolStripMenuItem.Name = "字體ToolStripMenuItem"
        Me.字體ToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.字體ToolStripMenuItem.Text = "字體"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(102, 26)
        Me.ToolStripMenuItem2.Text = "16"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(102, 26)
        Me.ToolStripMenuItem3.Text = "24"
        '
        '顏色ToolStripMenuItem
        '
        Me.顏色ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.藍色ToolStripMenuItem, Me.紅色ToolStripMenuItem})
        Me.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem"
        Me.顏色ToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.顏色ToolStripMenuItem.Text = "顏色"
        '
        '藍色ToolStripMenuItem
        '
        Me.藍色ToolStripMenuItem.Name = "藍色ToolStripMenuItem"
        Me.藍色ToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.藍色ToolStripMenuItem.Text = "藍色"
        '
        '紅色ToolStripMenuItem
        '
        Me.紅色ToolStripMenuItem.Name = "紅色ToolStripMenuItem"
        Me.紅色ToolStripMenuItem.Size = New System.Drawing.Size(114, 26)
        Me.紅色ToolStripMenuItem.Text = "紅色"
        '
        '結束ToolStripMenuItem
        '
        Me.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem"
        Me.結束ToolStripMenuItem.Size = New System.Drawing.Size(51, 23)
        Me.結束ToolStripMenuItem.Text = "結束"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 502)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 編輯ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 字體ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents 顏色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 藍色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 紅色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 結束ToolStripMenuItem As ToolStripMenuItem
End Class
