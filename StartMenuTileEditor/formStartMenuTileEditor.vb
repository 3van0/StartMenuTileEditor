Imports System.IO
Public Class FCStartC
    Dim FilePth, FileName, IconName, IconPth As String

    Private Sub ColorSL_Click(sender As Object, e As EventArgs) Handles ColorSL.Click
        Dim COL As Color
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            COL = ColorDialog1.Color
            TRed.Text = COL.R.ToString
            TGreen.Text = COL.G.ToString
            TBlue.Text = COL.B.ToString
            HX.Text = System.Drawing.ColorTranslator.ToHtml(COL)
            pickcolor.BackColor = COL
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pickclr.MouseDown
        Dim GetColor As Color = CType(pickclr.Image, Bitmap).GetPixel(e.X, e.Y) '使用GetPixel（）函数要先把图片转换成BitMap格式
        TRed.Text = GetColor.R.ToString
        TGreen.Text = GetColor.G.ToString
        TBlue.Text = GetColor.B.ToString
        HX.Text = System.Drawing.ColorTranslator.ToHtml(GetColor)
        pickcolor.BackColor = GetColor
    End Sub

    Private Sub OpenFl_Click(sender As Object, e As EventArgs) Handles OpenFl.Click
        OpenXFile()
    End Sub

    Private Sub OpenXFile()
        Dim OpenDialog1 As New OpenFileDialog
        OpenDialog1.Filter = "图片格式|*.jpg;*.jpeg;*.png;*.ico;*gif|所有文件*.*|*.*"
        If OpenDialog1.ShowDialog = DialogResult.OK Then
            Dim Path As String = OpenDialog1.FileName
            Dim imgScr As Bitmap = New Bitmap(Path)
            Dim imgDest As Bitmap = New Bitmap(pickclr.Width, pickclr.Height)
            Dim g As Graphics = Graphics.FromImage(imgDest)
            g.DrawImage(imgScr, New Rectangle(0, 0, pickclr.Width, pickclr.Height), New Rectangle(0, 0, imgScr.Width, imgScr.Height), GraphicsUnit.Pixel)
            pickclr.Image = imgDest
            g.Dispose()
        End If
    End Sub

    Private Sub IconSLEN_CheckedChanged(sender As Object, e As EventArgs) Handles IconSLEN.CheckedChanged
        If IconSLEN.Checked Then
            IconSL.Enabled = True
            BIconPTH.Enabled = True
        ElseIf IconSLEN.Checked = False Then
            IconSL.Enabled = False
            BIconPTH.Enabled = False
        End If
    End Sub


    Private Sub GO_Click(sender As Object, e As EventArgs) Handles GO.Click
        If FilePth <> "" Then
            'generate .xml file
            Dim FileFinal As FileStream = New FileStream(FileName + ".VisualElementsManifest.xml", FileMode.Create, FileAccess.ReadWrite)
            Dim names As String() = New String() {"<?xml version=" + Chr(34) + "1.0" + Chr(34) + " encoding=" + Chr(34) + "utf-8" + Chr(34) + "?>", "<Application xmlns:xsi=" + Chr(34) + "http://www.w3.org/2001/XMLSchema-instance" + Chr(34) + ">", "<VisualElements ", "ForegroundText=" + Chr(34) + "light" + Chr(34) + " "}
            Dim s As String
            Using sw As StreamWriter = New StreamWriter(FileFinal)
                For Each s In names
                    sw.WriteLine(s)
                Next s
                Dim swcolor As String = New String("BackgroundColor=" + Chr(34) + HX.Text + Chr(34))
                sw.WriteLine(swcolor)
                sw.WriteLine("ShowNameOnSquare150x150Logo=" + Chr(34) + "on" + Chr(34) + " ")
                If IconSLEN.Checked Then
                    If IconPth <> FilePth Then
                        File.Copy(IconPth + "\" + IconName, FilePth + "\" + IconName, True)
                    End If
                    sw.WriteLine("Square150x150Logo=" + Chr(34) + IconName + Chr(34))
                    sw.WriteLine("Square70x70Logo=" + Chr(34) + IconName + Chr(34))
                End If
                sw.WriteLine("></VisualElements></Application>")
            End Using
            'copy xml
            File.Copy(FileName + ".VisualElementsManifest.xml", FilePth + "\" + FileName + ".VisualElementsManifest.xml", True)

            'generate .bat file
            Dim StartPath As String = New String("C:\ProgramData\Microsoft\Windows\Start Menu\Programs")
            Dim username As String
            username = Environment.GetEnvironmentVariable("USERNAME")
            Dim Userstartpath As String = New String("C:\Users\" + username + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs")
            Dim shellfile As FileStream = New FileStream("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\RS.bat", FileMode.Create, FileAccess.ReadWrite)
            Using sws As StreamWriter = New StreamWriter(shellfile)
                sws.WriteLine("chcp 65001")
                Writedir(StartPath, sws)
                Writedir(Userstartpath, sws)
                sws.Close()
            End Using

            'run .bat file
            Dim proc As New ProcessStartInfo()
            proc.UseShellExecute = True
            proc.WorkingDirectory = "C:\"
            proc.FileName = "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\RS.bat"
            proc.Verb = "runas"
            Process.Start(proc)
        End If
    End Sub

    Private Sub BIconPTH_TextChanged(sender As Object, e As EventArgs) Handles BIconPTH.TextChanged

    End Sub

    Private Sub pickclr_Click(sender As Object, e As EventArgs) Handles pickclr.Click

    End Sub

    Private Sub IconSL_Click(sender As Object, e As EventArgs) Handles IconSL.Click
        Dim opendialog1 As New OpenFileDialog
        opendialog1.Filter = "PNG格式|*.png"
        If opendialog1.ShowDialog = DialogResult.OK Then
            Dim result As String
            result = opendialog1.FileName
            IconName = Path.GetFileName(result)
            'IconName = FileName.Substring(0, FileName.LastIndexOf("."))
            IconPth = Path.GetDirectoryName(result)
            BIconPTH.Text = IconPth
        End If
    End Sub

    Private Sub FileSL_Click(sender As Object, e As EventArgs) Handles FileSL.Click
        Dim opendialog1 As New OpenFileDialog
        opendialog1.Filter = "EXE格式|*.exe"
        If opendialog1.ShowDialog = DialogResult.OK Then
            Dim result As String
            result = opendialog1.FileName
            FileName = Path.GetFileName(result)
            FileName = FileName.Substring(0, FileName.LastIndexOf("."))
            FilePth = Path.GetDirectoryName(result)
            BAppPth.Text = FilePth
        End If
    End Sub

    Private Sub Writedir(path As String, sws As StreamWriter)
        sws.WriteLine("cd " + path)
        sws.WriteLine("for %%f in (*.*) do copy /b " + Chr(34) + "%%f" + Chr(34) + " +,,")
        Dim dir As New DirectoryInfo(path)
        For Each d As DirectoryInfo In dir.GetDirectories
            Writedir(d.FullName, sws)
        Next
    End Sub
End Class
