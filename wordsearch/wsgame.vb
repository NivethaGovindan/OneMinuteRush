Imports System.Data.OleDb

Public Class wsgame
    Dim wordans As String
    Dim B1, B2, B3, B4 As Integer
    Dim timeleft As Integer
    Dim i As Integer
    Dim Rememberset As HashSet(Of Integer) = New HashSet(Of Integer)
    Dim score As Integer = 0
    Dim pname As String
    Dim inval As String
    Dim mng As String
    Dim score1 As Integer
    Dim score2 As Integer
    Dim score3 As Integer
    Dim arng As Integer = 1


    Function setVal()
        'dbconnectivity code


        Dim con As OleDbConnection
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader
        Dim letter(4) As Char
        Dim wordstr As String
        arng += 1
        i = CInt(Math.Floor((52 - 1 + 1) * Rnd())) + 1
        If Rememberset.Add(i) Then
            Try
                con = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\MiniGame.mdb")
                cmd = New OleDbCommand("select word,meaning from wordsearchtable where ID=@IDval", con)
                con.Open()
                cmd.Parameters.AddWithValue("@IDval", i)
                dr = cmd.ExecuteReader()
                dr.Read()
                wordstr = dr.Item(0)
                mng = dr.Item(1)
                wordans = wordstr
                letter = wordstr.ToCharArray
                If (arng Mod 2) = 0 Then
                    Button2.Text = letter(0)
                    Button3.Text = letter(1)
                    Button4.Text = letter(2)
                    Button1.Text = letter(3)
                    con.Close()
                Else
                    Button4.Text = letter(0)
                    Button1.Text = letter(1)
                    Button3.Text = letter(2)
                    Button2.Text = letter(3)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            setVal()
        End If
    End Function
    Function correctnextword()
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        Label1.Text = ""
        'Label4.Text = ""
        setVal()
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True

    End Function
    Function wrongsameword()
        PictureBox2.Visible = True
        Label1.Text = ""
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
    End Function
    Function anscheck()
        If (wordans.Equals(Label1.Text)) Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            Label4.Text = "correct"
            score += 1
            MsgBox("Correct" & vbCrLf & "meaning is: " & mng)
            B1 = 0
            B2 = 0
            B3 = 0
            B4 = 0
            PictureBox1.Visible = True
            If (timeleft > 0) Then
                correctnextword()
                B1 = B2 = B3 = B4 = 0
            End If

        Else
            Label4.Text = "wrong"
            PictureBox2.Visible = True
            B1 = 0
            B2 = 0
            B3 = 0
            B4 = 0
            If (timeleft > 0) Then
                wrongsameword()
            End If
        End If
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If timeleft > 0 Then
            timeleft -= 1
            Label3.Text = timeleft.ToString + " seconds"
        Else
            Timer1.Enabled = False
            MsgBox("Final word: " & wordans & vbCrLf & "Meaning" & mng, , "Scrambled")
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            Label1.Visible = False
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Button4.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Dim con As OleDbConnection
            Dim cmd As OleDbCommand
            Dim cmd2 As OleDbCommand
            Dim cmd3 As OleDbCommand
            Dim dr As OleDbDataReader
          

            Try
                con = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\MiniGame.mdb")
                con.Open()
                cmd = New OleDbCommand("select scores from wordsearchleaderboard where Rank=@s1", con)
                cmd.Parameters.AddWithValue("@s1", 1)
                dr = cmd.ExecuteReader()
                dr.Read()
                score1 = dr.Item(0)

                cmd2 = New OleDbCommand("select scores from wordsearchleaderboard where Rank=@s2", con)
                cmd2.Parameters.AddWithValue("@s2", 2)
                dr = cmd2.ExecuteReader()
                dr.Read()
                score2 = dr.Item(0)



                cmd3 = New OleDbCommand("select scores from wordsearchleaderboard where Rank=@s3", con)
                cmd3.Parameters.AddWithValue("@s3", 3)
                dr = cmd3.ExecuteReader()
                dr.Read()
                score3 = dr.Item(0)


                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            If score <= score3 Then
                MsgBox("Game Over!!!" & vbCrLf & "scores" & score.ToString(), , "Scrambled")
                Me.Close()

            Else
                If score > Val(score1) Then
                    MsgBox("Congrats!!! you have won gold medal" & vbCrLf & "scores:" & score.ToString(), , "Scrambled")
                    'MsgBox("Congrats!!! you have won gold medal")
                    pname = InputBox("Enter your Name", "Gold Medalist", "")
                    inval = "1"
                    insertdbgold()
                    Me.Close()

                ElseIf score > Val(score2) Then
                    MsgBox("Congrats!!!You have won silver Medal" & vbCrLf & "scores:" & score.ToString(), , "Scrambled")
                    'MsgBox("Congrats!!!You have won silver Medal")
                    pname = InputBox("Enter your Name", "Silver Medalist", "")
                    inval = "2"
                    insertdbsilver()
                    Me.Close()



                ElseIf score > Val(score3) Then
                    MsgBox("Congrats!!! You have won bronze Medal" & vbCrLf & "scores" & score.ToString(), , "Scrambled")
                    'MsgBox("Congrats!!! You have won bronze Medal")
                    pname = InputBox("Enter your Name", "Bronze Medalist", "")
                    inval = "3"
                    insertdb()
                    Me.Close()

                End If

            End If
            End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        Label1.Text = ""
        Label4.Text = ""
        Label3.Text = "60 seconds"
        setVal()
        B1 = 0
        B2 = 0
        B3 = 0
        B4 = 0
        i = 1
        timeleft = 60
        Timer1.Enabled = True
    End Sub
    Function insertdb()
        Dim con As OleDbConnection
        Dim ad As OleDbDataAdapter = New OleDbDataAdapter
        Dim sql As String
        con = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\MiniGame.mdb")
        sql = "update wordsearchleaderboard set PlayerName='" + pname + "',scores='" + score.ToString + "' where Rank='" + inval.ToString + "'"
        con.Open()
        ad.InsertCommand = New OleDbCommand(sql, con)
        ad.InsertCommand.ExecuteNonQuery()
        con.Close()
    End Function
    Function insertdbsilver()
        Dim con As OleDbConnection
        Dim ad As OleDbDataAdapter = New OleDbDataAdapter
        Dim sql As String
        Dim sql2 As String
        Dim sql3 As String
        Dim j As Integer = 3
        Dim k As Integer = 2
        Dim l As Integer = 4
        con = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\MiniGame.mdb")
        sql2 = "update wordsearchleaderboard set Rank='" + l.ToString + "' where Rank='" + j.ToString + "'"
        sql3 = "update wordsearchleaderboard set Rank='" + j.ToString + "' where Rank='" + k.ToString + "'"
        sql = "update wordsearchleaderboard set PlayerName='" + pname + "',scores='" + score.ToString + "',Rank='" + k.ToString + "' where Rank='" + l.ToString + "'"
        con.Open()
        
        ad.InsertCommand = New OleDbCommand(sql2, con)
        ad.InsertCommand.ExecuteNonQuery()
        ad.InsertCommand = New OleDbCommand(sql3, con)
        ad.InsertCommand.ExecuteNonQuery()
        ad.InsertCommand = New OleDbCommand(sql, con)
        ad.InsertCommand.ExecuteNonQuery()

        con.Close()
    End Function
    Function insertdbgold()
        Dim con As OleDbConnection
        Dim ad As OleDbDataAdapter = New OleDbDataAdapter
        Dim sql1 As String
        Dim sql2 As String
        Dim sql3 As String
        Dim sql4 As String
        Dim j As Integer = 1
        Dim k As Integer = 2
        Dim l As Integer = 3
        Dim m As Integer = 4
        con = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\MiniGame.mdb")
        sql1 = "update wordsearchleaderboard set Rank='" + m.ToString + "' where Rank='" + l.ToString + "'"
        sql2 = "update wordsearchleaderboard set Rank='" + l.ToString + "' where Rank='" + k.ToString + "'"
        sql3 = "update wordsearchleaderboard set Rank='" + k.ToString + "' where Rank='" + j.ToString + "'"
        sql4 = "update wordsearchleaderboard set PlayerName='" + pname + "',scores='" + score.ToString + "',Rank='" + j.ToString + "' where Rank='" + m.ToString + "'"
        con.Open()

        ad.InsertCommand = New OleDbCommand(sql1, con)
        ad.InsertCommand.ExecuteNonQuery()
        ad.InsertCommand = New OleDbCommand(sql2, con)
        ad.InsertCommand.ExecuteNonQuery()
        ad.InsertCommand = New OleDbCommand(sql3, con)
        ad.InsertCommand.ExecuteNonQuery()
        ad.InsertCommand = New OleDbCommand(sql4, con)
        ad.InsertCommand.ExecuteNonQuery()
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        B1 = 1
        Label1.Text = Label1.Text + Button1.Text
        Button1.Visible = False
        If B2 = 1 And B3 = 1 And B4 = 1 Then
            anscheck()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        B2 = 1
        Label1.Text = Label1.Text + Button2.Text
        Button2.Visible = False
        If B1 = 1 And B3 = 1 And B4 = 1 Then
            anscheck()

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        B3 = 1
        Label1.Text = Label1.Text + Button3.Text
        Button3.Visible = False
        If B1 = 1 And B2 = 1 And B4 = 1 Then
            anscheck()

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        B4 = 1
        Label1.Text = Label1.Text + Button4.Text
        Button4.Visible = False
        If B1 = 1 And B2 = 1 And B3 = 1 Then
            anscheck()

        End If

    End Sub
End Class



