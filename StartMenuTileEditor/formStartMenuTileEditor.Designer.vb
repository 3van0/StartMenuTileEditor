<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCStartC
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCStartC))
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorSL = New System.Windows.Forms.Button()
        Me.OpenFl = New System.Windows.Forms.Button()
        Me.TRed = New System.Windows.Forms.TextBox()
        Me.TGreen = New System.Windows.Forms.TextBox()
        Me.TBlue = New System.Windows.Forms.TextBox()
        Me.HX = New System.Windows.Forms.Label()
        Me.BAppPth = New System.Windows.Forms.TextBox()
        Me.FileSL = New System.Windows.Forms.Button()
        Me.IconSL = New System.Windows.Forms.Button()
        Me.BIconPTH = New System.Windows.Forms.TextBox()
        Me.IconSLEN = New System.Windows.Forms.CheckBox()
        Me.GO = New System.Windows.Forms.Button()
        Me.pickclr = New System.Windows.Forms.PictureBox()
        Me.pickcolor = New System.Windows.Forms.PictureBox()
        CType(Me.pickclr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pickcolor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorSL
        '
        Me.ColorSL.Location = New System.Drawing.Point(152, 132)
        Me.ColorSL.Name = "ColorSL"
        Me.ColorSL.Size = New System.Drawing.Size(133, 48)
        Me.ColorSL.TabIndex = 0
        Me.ColorSL.Text = "取色器"
        Me.ColorSL.UseVisualStyleBackColor = True
        '
        'OpenFl
        '
        Me.OpenFl.Location = New System.Drawing.Point(13, 132)
        Me.OpenFl.Name = "OpenFl"
        Me.OpenFl.Size = New System.Drawing.Size(133, 48)
        Me.OpenFl.TabIndex = 2
        Me.OpenFl.Text = "打开图片"
        Me.OpenFl.UseVisualStyleBackColor = True
        '
        'TRed
        '
        Me.TRed.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TRed.Location = New System.Drawing.Point(13, 214)
        Me.TRed.Name = "TRed"
        Me.TRed.Size = New System.Drawing.Size(86, 30)
        Me.TRed.TabIndex = 3
        '
        'TGreen
        '
        Me.TGreen.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TGreen.Location = New System.Drawing.Point(105, 214)
        Me.TGreen.Name = "TGreen"
        Me.TGreen.Size = New System.Drawing.Size(87, 30)
        Me.TGreen.TabIndex = 4
        '
        'TBlue
        '
        Me.TBlue.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.TBlue.Location = New System.Drawing.Point(198, 214)
        Me.TBlue.Name = "TBlue"
        Me.TBlue.Size = New System.Drawing.Size(87, 30)
        Me.TBlue.TabIndex = 5
        '
        'HX
        '
        Me.HX.AutoSize = True
        Me.HX.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.HX.Location = New System.Drawing.Point(9, 258)
        Me.HX.Name = "HX"
        Me.HX.Size = New System.Drawing.Size(79, 20)
        Me.HX.TabIndex = 9
        Me.HX.Text = "#000000"
        '
        'BAppPth
        '
        Me.BAppPth.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.BAppPth.Location = New System.Drawing.Point(152, 12)
        Me.BAppPth.Name = "BAppPth"
        Me.BAppPth.Size = New System.Drawing.Size(489, 27)
        Me.BAppPth.TabIndex = 10
        '
        'FileSL
        '
        Me.FileSL.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.FileSL.Location = New System.Drawing.Point(13, 10)
        Me.FileSL.Name = "FileSL"
        Me.FileSL.Size = New System.Drawing.Size(133, 31)
        Me.FileSL.TabIndex = 11
        Me.FileSL.Text = "选择应用程序"
        Me.FileSL.UseVisualStyleBackColor = True
        '
        'IconSL
        '
        Me.IconSL.Enabled = False
        Me.IconSL.Location = New System.Drawing.Point(13, 86)
        Me.IconSL.Name = "IconSL"
        Me.IconSL.Size = New System.Drawing.Size(133, 31)
        Me.IconSL.TabIndex = 13
        Me.IconSL.Text = "选择图标"
        Me.IconSL.UseVisualStyleBackColor = True
        '
        'BIconPTH
        '
        Me.BIconPTH.Enabled = False
        Me.BIconPTH.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.BIconPTH.Location = New System.Drawing.Point(152, 88)
        Me.BIconPTH.Name = "BIconPTH"
        Me.BIconPTH.Size = New System.Drawing.Size(489, 27)
        Me.BIconPTH.TabIndex = 12
        '
        'IconSLEN
        '
        Me.IconSLEN.AutoSize = True
        Me.IconSLEN.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.IconSLEN.Location = New System.Drawing.Point(13, 59)
        Me.IconSLEN.Name = "IconSLEN"
        Me.IconSLEN.Size = New System.Drawing.Size(98, 21)
        Me.IconSLEN.TabIndex = 14
        Me.IconSLEN.Text = "选择图标"
        Me.IconSLEN.UseVisualStyleBackColor = True
        '
        'GO
        '
        Me.GO.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.GO.Location = New System.Drawing.Point(13, 346)
        Me.GO.Name = "GO"
        Me.GO.Size = New System.Drawing.Size(272, 136)
        Me.GO.TabIndex = 0
        Me.GO.Text = "运行"
        Me.GO.UseVisualStyleBackColor = True
        '
        'pickclr
        '
        Me.pickclr.Image = Global.StartMenuTileEditor.My.Resources.Resources.th
        Me.pickclr.InitialImage = CType(resources.GetObject("pickclr.InitialImage"), System.Drawing.Image)
        Me.pickclr.Location = New System.Drawing.Point(291, 132)
        Me.pickclr.Name = "pickclr"
        Me.pickclr.Size = New System.Drawing.Size(350, 350)
        Me.pickclr.TabIndex = 1
        Me.pickclr.TabStop = False
        '
        'pickcolor
        '
        Me.pickcolor.Location = New System.Drawing.Point(13, 281)
        Me.pickcolor.Name = "pickcolor"
        Me.pickcolor.Size = New System.Drawing.Size(272, 50)
        Me.pickcolor.TabIndex = 15
        Me.pickcolor.TabStop = False
        '
        'FCStartC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 494)
        Me.Controls.Add(Me.pickcolor)
        Me.Controls.Add(Me.GO)
        Me.Controls.Add(Me.IconSLEN)
        Me.Controls.Add(Me.IconSL)
        Me.Controls.Add(Me.BIconPTH)
        Me.Controls.Add(Me.FileSL)
        Me.Controls.Add(Me.BAppPth)
        Me.Controls.Add(Me.HX)
        Me.Controls.Add(Me.TBlue)
        Me.Controls.Add(Me.TGreen)
        Me.Controls.Add(Me.TRed)
        Me.Controls.Add(Me.OpenFl)
        Me.Controls.Add(Me.pickclr)
        Me.Controls.Add(Me.ColorSL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FCStartC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StartMenuTileEditor"
        CType(Me.pickclr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pickcolor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ColorSL As Button
    Friend WithEvents pickclr As PictureBox
    Friend WithEvents OpenFl As Button
    Friend WithEvents TRed As TextBox
    Friend WithEvents TGreen As TextBox
    Friend WithEvents TBlue As TextBox
    Friend WithEvents HX As Label
    Friend WithEvents BAppPth As TextBox
    Friend WithEvents FileSL As Button
    Friend WithEvents IconSL As Button
    Friend WithEvents BIconPTH As TextBox
    Friend WithEvents IconSLEN As CheckBox
    Friend WithEvents GO As Button
    Friend WithEvents pickcolor As PictureBox
End Class
