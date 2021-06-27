Imports System.IO.Compression
Imports System.Net.Sockets
Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Dim get_ip_raw As String
    Dim send_ip As String
    Dim host As String
    Dim local_ip_raw As String
    Dim btn_one As Integer
    Dim last_clip As String
    Dim clipsave As New RichTextBox
    Dim clipip As New RichTextBox
    Dim cleartemp As New RichTextBox
    Dim clip_tx As New RichTextBox
    Dim anti_duplicate As New RichTextBox
    'Dim outputz As New TextBox
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Public Function GetKeyState(ByVal Key1 As Integer, Optional ByVal Key2 As Integer = -1, Optional ByVal Key3 As Integer = -1) As Boolean
        Dim s As Short
        s = GetAsyncKeyState(Key1)
        If s = 0 Then Return False
        If Key2 > -1 Then
            s = GetAsyncKeyState(Key2)
            If s = 0 Then Return False
        End If
        If Key3 > -1 Then
            s = GetAsyncKeyState(Key3)
            If s = 0 Then Return False
        End If
        Return True
    End Function
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label6.Click

    End Sub
    Dim exit_it As Integer
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If exit_it = 1 Then
            Me.Hide()
            reclipy_icon.Visible = True
        Else
            Try

                Using p As New Process
                    With p.StartInfo
                        .CreateNoWindow = True
                        .FileName = "cmd.exe"
                        .RedirectStandardInput = True
                        .RedirectStandardOutput = True
                        .UseShellExecute = False



                    End With

                    p.Start()
                    'resource.zip

                    p.StandardInput.WriteLine("taskkill /f /im regine.exe /t")



                End Using
            Catch ex As Exception

            End Try

            Try

                Using p As New Process
                    With p.StartInfo
                        .CreateNoWindow = True
                        .FileName = "cmd.exe"
                        .RedirectStandardInput = True
                        .RedirectStandardOutput = True
                        .UseShellExecute = False



                    End With

                    p.Start()
                    'resource.zip

                    p.StandardInput.WriteLine("taskkill /f /im php.exe /t")



                End Using
            Catch ex As Exception

            End Try
            Application.Exit()
        End If

    End Sub
    Public Sub Execute()
        get_ip_raw = get_ip.Text

        '// RECEIVE ZONE
        Try

            Using p As New Process
                With p.StartInfo
                    .CreateNoWindow = True
                    .FileName = "cmd.exe"
                    .RedirectStandardInput = True
                    .RedirectStandardOutput = True
                    .UseShellExecute = False



                End With

                p.Start()
                'resource.zip

                p.StandardInput.WriteLine("start resource\regine.exe")



            End Using
        Catch ex As Exception

        End Try
        If get_ip_raw = "" Then

        Else
            '// RECEIVE ZONE
            Try
                cleartemp.SaveFile("resource\syncesp.dll", RichTextBoxStreamType.PlainText)
                clipip.Text = "http://" + get_ip_raw + ":8448/clipboard.db"
                Try
                    Dim file As System.IO.StreamWriter
                    file = My.Computer.FileSystem.OpenTextFileWriter("resource\syncesp.dll", True)
                    file.WriteLine(clipip.Text)
                    file.Close()
                Catch ex As Exception

                End Try
            Catch ex As Exception

            End Try



            '// TRANSMITTER ZONE
            Try

                Using p As New Process
                    With p.StartInfo
                        .CreateNoWindow = True
                        .FileName = "cmd.exe"
                        .RedirectStandardInput = True
                        .RedirectStandardOutput = True
                        .UseShellExecute = False



                    End With

                    p.Start()
                    'resource.zip

                    p.StandardInput.WriteLine(php_string.Text)



                End Using
            Catch ex As Exception

            End Try
            get_.Start()
        End If
        host = System.Net.Dns.GetHostName()
        send_ip = System.Net.Dns.GetHostAddresses(host).GetValue(0).ToString
        TextBox2.Text = send_ip

        get_delay.Start()
    End Sub
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        btn_one += 1
        If btn_one = 1 Then
            Execute()
            GetLocalIP()
            Label5.ForeColor = Color.Red
            FlatButton1.BaseColor = Color.Red
            exit_it = 1
        ElseIf btn_one = 2 Then
            exit_it = 0
            Try

                Using p As New Process
                    With p.StartInfo
                        .CreateNoWindow = True
                        .FileName = "cmd.exe"
                        .RedirectStandardInput = True
                        .RedirectStandardOutput = True
                        .UseShellExecute = False



                    End With

                    p.Start()
                    'resource.zip

                    p.StandardInput.WriteLine("taskkill /f /im regine.exe /t")



                End Using
            Catch ex As Exception

            End Try

            Try

                Using p As New Process
                    With p.StartInfo
                        .CreateNoWindow = True
                        .FileName = "cmd.exe"
                        .RedirectStandardInput = True
                        .RedirectStandardOutput = True
                        .UseShellExecute = False



                    End With

                    p.Start()
                    'resource.zip

                    p.StandardInput.WriteLine("taskkill /f /im php.exe /t")



                End Using
            Catch ex As Exception

            End Try
            Label5.ForeColor = Color.Black
            FlatButton1.BaseColor = Color.Green
            btn_one = 0
        End If

    End Sub
    Function GetLocalIP() As System.Net.IPAddress
        Dim localIP() As System.Net.IPAddress = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName)
        For Each current As System.Net.IPAddress In localIP
            If current.ToString Like "*[.]*[.]*[.]*" Then
                Try
                    Dim SplitVar() As String = current.ToString.Split(".")
                    If Len(SplitVar(0)) <= 3 And Len(SplitVar(1)) <= 3 And Len(SplitVar(2)) <= 3 And Len(SplitVar(3)) <= 3 Then
                        Return current
                    End If
                Catch ex As Exception
                End Try
            End If

        Next

        'msgcurrent
    End Function
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TabControl1.SelectTab(1)
    End Sub
    Dim scan As Integer
    Dim scanner As String
    Private Sub get__Tick(sender As Object, e As EventArgs) Handles get_.Tick
        '//GET FROM RECEIVER 
        Try
            clipsave.LoadFile("resource/desyncesp.dll", RichTextBoxStreamType.PlainText)
            If (GetAsyncKeyState(17)) And (GetAsyncKeyState(66)) Then
                Clipboard.SetText(clipsave.Text)
            End If

        Catch ex As Exception

        End Try

        '// SENDER 
        Try
            clip_tx.Text = GetClipboardText()
            clip_tx.SaveFile("resource/server/sources/clipboard.db", RichTextBoxStreamType.PlainText)


        Catch ex As Exception

        End Try

        If last_clip = clipsave.Text Then '// WHEN CIPBOARD UPDATE
            reclipy_icon.Icon = My.Resources.clipper

        Else
            reclipy_icon.Icon = My.Resources.orange_d
        End If


    End Sub
    Public Function GetClipboardText() As String
        Dim objClipboard As IDataObject = Clipboard.GetDataObject()
        With objClipboard
            If .GetDataPresent(DataFormats.Text) Then Return _
               .GetData(DataFormats.Text)
        End With
    End Function
    Dim pass As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        TabControl1.SelectTab(2)
        Timer1.Start()





    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown, Label9.MouseDown, Label8.MouseDown, Label10.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp, Label9.MouseUp, Label8.MouseUp, Label10.MouseUp
        drag = False
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove, Label9.MouseMove, Label8.MouseMove, Label10.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Try

            Using p As New Process
                With p.StartInfo
                    .CreateNoWindow = True
                    .FileName = "cmd.exe"
                    .RedirectStandardInput = True
                    .RedirectStandardOutput = True
                    .UseShellExecute = False



                End With

                p.Start()
                'resource.zip

                p.StandardInput.WriteLine("start https://www.facebook.com/ReZier.UNkNowZ/")



            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles TabControl1.KeyDown
        If e.KeyCode = Keys.Right Then
            'your code here  
            e.Handled = True
        End If
        If e.KeyCode = Keys.Left Then
            'your code here  
            e.Handled = True
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
    Dim block_plus As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If block_plus = 0 Then
            Panel3.Width += 10
        End If

        If Panel3.Width >= 202 Then
            TabControl1.SelectTab(0)
            Timer1.Stop()
        ElseIf Panel3.Width >= 30 And Panel3.Width < 31 Then
            Try
                anti_duplicate.LoadFile("resource/regine.exe", RichTextBoxStreamType.PlainText)
                pass = True
            Catch ex As Exception
                pass = False
            End Try
        ElseIf Panel3.Width >= 50 And Panel3.Width < 51 Then
            If pass = True Then
                TabControl1.SelectTab(0)
                Timer1.Stop()

            End If
            If pass = False Then
                block_plus = 1
                Try

                    Using p As New Process
                        With p.StartInfo
                            .CreateNoWindow = True
                            .FileName = "cmd.exe"
                            .RedirectStandardInput = True
                            .RedirectStandardOutput = True
                            .UseShellExecute = False



                        End With

                        p.Start()
                        'resource.zip

                        p.StandardInput.WriteLine("mkdir resource")
                        p.StandardInput.WriteLine("mkdir resource\server")
                        Try
                            IO.File.WriteAllBytes("resource/regine.exe", My.Resources.regine)
                            IO.File.WriteAllBytes("resource/resource_server.zip", My.Resources.resource_server)
                            block_plus = 0
                        Catch ex As Exception

                        End Try


                    End Using
                Catch ex As Exception

                End Try
            End If
            ' 
        ElseIf Panel3.Width >= 150 And Panel3.Width < 151 Then
            If pass = False Then
                block_plus = 1
                ZipFile.ExtractToDirectory("resource/resource_server.zip", "resource/server")
                block_plus = 0
            End If
        ElseIf Panel3.Width >= 190 And Panel3.Width < 200 Then
            If pass = False Then
                block_plus = 1
                Try

                    Using p As New Process
                        With p.StartInfo
                            .CreateNoWindow = True
                            .FileName = "cmd.exe"
                            .RedirectStandardInput = True
                            .RedirectStandardOutput = True
                            .UseShellExecute = False



                        End With

                        p.Start()
                        'resource.zip

                        p.StandardInput.WriteLine("del resource\resource_server.zip")

                        block_plus = 0

                    End Using
                Catch ex As Exception

                End Try
            End If
        End If

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Try

            Using p As New Process
                With p.StartInfo
                    .CreateNoWindow = True
                    .FileName = "cmd.exe"
                    .RedirectStandardInput = True
                    .RedirectStandardOutput = True
                    .UseShellExecute = False



                End With

                p.Start()
                'resource.zip

                p.StandardInput.WriteLine("start https://www.facebook.com/ReZier.UNkNowZ/")



            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub reclipy_icon_DoubleClick(sender As Object, e As EventArgs) Handles reclipy_icon.DoubleClick
        reclipy_icon.Visible = False
        Me.Show()
    End Sub

    Private Sub get_delay_Tick(sender As Object, e As EventArgs) Handles get_delay.Tick
        last_clip = clipsave.Text
    End Sub
End Class
