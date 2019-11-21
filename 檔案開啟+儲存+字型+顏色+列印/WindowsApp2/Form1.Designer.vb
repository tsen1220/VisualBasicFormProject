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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.選項ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開啟ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.儲存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字型大小顏色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.字型ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.顏色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.關閉ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.列印ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.列印ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.列印格式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.列印預覽ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.選項ToolStripMenuItem, Me.字型大小顏色ToolStripMenuItem, Me.列印ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(30, 69)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(696, 353)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        '選項ToolStripMenuItem
        '
        Me.選項ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.開啟ToolStripMenuItem, Me.儲存ToolStripMenuItem, Me.關閉ToolStripMenuItem})
        Me.選項ToolStripMenuItem.Name = "選項ToolStripMenuItem"
        Me.選項ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.選項ToolStripMenuItem.Text = "選項"
        '
        '開啟ToolStripMenuItem
        '
        Me.開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem"
        Me.開啟ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.開啟ToolStripMenuItem.Text = "開啟"
        '
        '儲存ToolStripMenuItem
        '
        Me.儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem"
        Me.儲存ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.儲存ToolStripMenuItem.Text = "儲存"
        '
        '字型大小顏色ToolStripMenuItem
        '
        Me.字型大小顏色ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.字型ToolStripMenuItem, Me.顏色ToolStripMenuItem})
        Me.字型大小顏色ToolStripMenuItem.Name = "字型大小顏色ToolStripMenuItem"
        Me.字型大小顏色ToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.字型大小顏色ToolStripMenuItem.Text = "字型大小顏色"
        '
        '字型ToolStripMenuItem
        '
        Me.字型ToolStripMenuItem.Name = "字型ToolStripMenuItem"
        Me.字型ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.字型ToolStripMenuItem.Text = "字型"
        '
        '顏色ToolStripMenuItem
        '
        Me.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem"
        Me.顏色ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.顏色ToolStripMenuItem.Text = "顏色"
        '
        '關閉ToolStripMenuItem
        '
        Me.關閉ToolStripMenuItem.Name = "關閉ToolStripMenuItem"
        Me.關閉ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.關閉ToolStripMenuItem.Text = "關閉"
        '
        '列印ToolStripMenuItem
        '
        Me.列印ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.列印ToolStripMenuItem1, Me.列印格式ToolStripMenuItem, Me.列印預覽ToolStripMenuItem})
        Me.列印ToolStripMenuItem.Name = "列印ToolStripMenuItem"
        Me.列印ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.列印ToolStripMenuItem.Text = "列印"
        '
        '列印ToolStripMenuItem1
        '
        Me.列印ToolStripMenuItem1.Name = "列印ToolStripMenuItem1"
        Me.列印ToolStripMenuItem1.Size = New System.Drawing.Size(216, 26)
        Me.列印ToolStripMenuItem1.Text = "列印"
        '
        '列印格式ToolStripMenuItem
        '
        Me.列印格式ToolStripMenuItem.Name = "列印格式ToolStripMenuItem"
        Me.列印格式ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.列印格式ToolStripMenuItem.Text = "列印格式"
        '
        '列印預覽ToolStripMenuItem
        '
        Me.列印預覽ToolStripMenuItem.Name = "列印預覽ToolStripMenuItem"
        Me.列印預覽ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.列印預覽ToolStripMenuItem.Text = "列印預覽"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 選項ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 開啟ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents 儲存ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 字型大小顏色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 字型ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 顏色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 關閉ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 列印ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 列印ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 列印格式ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents 列印預覽ToolStripMenuItem As ToolStripMenuItem
End Class
