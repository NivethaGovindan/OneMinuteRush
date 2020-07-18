Imports System.Data.OleDb
Public Class picturequiz_form2_
    Dim timeleft As Integer
    Dim picno As Integer = 1
    Dim rndvalue As Integer
    Dim hintcounter As Integer = 5
    Dim hleft As Integer = 4
    Dim Rememberset As HashSet(Of Integer) = New HashSet(Of Integer)
    Dim pname As String
    Dim inval As String
    Dim score As Integer
    Dim score1 As Integer
    Dim score2 As Integer
    Dim score3 As Integer


    Function strtfunction()


        rndvalue = CInt(Math.Floor((26 - 1 + 1) * Rnd())) + 1
        If Rememberset.Add(rndvalue) Then
            Select Case rndvalue
                Case 1
                    pic1()

                Case 2
                    pic2()
                Case 3
                    pic3()
                Case 4
                    pic4()
                Case 5
                    pic5()
                Case 6
                    pic6()
                Case 7
                    pic7()
                Case 8
                    pic8()
                Case 9
                    pic9()
                Case 10
                    pic10()
                Case 11
                    pic11()
                Case 12
                    pic12()
                Case 13
                    pic13()
                Case 14
                    pic14()
                Case 15
                    pic15()
                Case 16
                    pic16()
                Case 17
                    pic17()
                Case 18
                    pic18()
                Case 19
                    pic19()
                Case 20
                    pic20()
                Case 21
                    pic21()
                Case 22
                    pic22()
                Case 23
                    pic23()
                Case 24
                    pic24()
                Case 25
                    pic25()
                Case 26
                    pic26()
            End Select

        End If
    End Function

    Function evaluate()
        Select Case picno
            Case 1

                If (LCase(TextBox1.Text) = "dennis" And LCase(TextBox2.Text) = "ritchie") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 2
                If (LCase(TextBox1.Text) = "paris") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()

                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 3
                If (LCase(TextBox1.Text) = "finding" And LCase(TextBox2.Text) = "nemo") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 4
                If (LCase(TextBox1.Text) = "avatar") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 5
                If (LCase(TextBox1.Text) = "venice") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 6
                If (LCase(TextBox1.Text) = "shinchan") Then
                    Label2.Text = "CORRECT"
                    score += 1
                    Label5.Text = ""
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 7
                If (LCase(TextBox1.Text) = "remo") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 8
                If (LCase(TextBox1.Text) = "usa") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 9
                If (LCase(TextBox1.Text) = "aloevera") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 10
                If (LCase(TextBox1.Text) = "charles" And LCase(TextBox2.Text) = "dickens") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 11
                If (LCase(TextBox1.Text) = "dan" And LCase(TextBox2.Text) = "brown") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 12
                If (LCase(TextBox1.Text) = "doraemon") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 13
                If (LCase(TextBox1.Text) = "ecg") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 14
                If (LCase(TextBox1.Text) = "friends") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 15
                If (LCase(TextBox1.Text) = "gandhari") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 16
                If (LCase(TextBox1.Text) = "gulab" And LCase(TextBox2.Text) = "jamun") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 17
                If (LCase(TextBox1.Text) = "harper" And LCase(TextBox2.Text) = "lee") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 18
                If (LCase(TextBox1.Text) = "jhansi" And LCase(TextBox2.Text) = "rani") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 19
                If (LCase(TextBox1.Text) = "angioplasty") Then
                    Label2.Text = "CORRECT"
                    score += 1
                    Label5.Text = ""
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 20
                If (LCase(TextBox1.Text) = "abraham" And LCase(TextBox2.Text) = "lincoln") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 21
                If (LCase(TextBox1.Text) = "mark" And LCase(TextBox2.Text) = "zuckerberg") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 22
                If (LCase(TextBox1.Text) = "kalki") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 23
                If (LCase(TextBox1.Text) = "ratatouille") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 24
                If (LCase(TextBox1.Text) = "ronaldo") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 25
                If (LCase(TextBox1.Text) = "sindhu") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
            Case 26
                If (LCase(TextBox1.Text) = "sitar") Then
                    Label2.Text = "CORRECT"
                    Label5.Text = ""
                    score += 1
                    strtfunction()
                Else
                    Label2.Text = "WRONG"
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                End If
        End Select
    End Function
    Function pic1()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.Visible = True
        picno = 1
        PictureBox1.Image = My.Resources.dennis
        Label1.Text = "Guess the personality"
    End Function
    Function pic2()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 2
        PictureBox1.Image = My.Resources.paris
        Label1.Text = "Guess the City"

    End Function
    Function pic3()
        TextBox2.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 3
        PictureBox1.Image = My.Resources.nemo
        Label1.Text = "Guess the animation movie"
    End Function
    Function pic4()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 4
        PictureBox1.Image = My.Resources.avatar
        Label1.Text = "Guess the movie"
    End Function
    Function pic5()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 5
        PictureBox1.Image = My.Resources.venice
        Label1.Text = "Guess the city"
    End Function
    Function pic6()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 6
        PictureBox1.Image = My.Resources.shinchan
        Label1.Text = "Guess the cartoon character"

    End Function
    Function pic7()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 7
        PictureBox1.Image = My.Resources.remo
        Label1.Text = "Guess the movie"
    End Function
    Function pic8()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 8
        PictureBox1.Image = My.Resources.usa
        Label1.Text = "Guess the country"

    End Function
    Function pic9()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 9
        PictureBox1.Image = My.Resources.alovera
        Label1.Text = "Guess the medicinal plant"
    End Function

    Function pic10()
        TextBox2.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 10
        PictureBox1.Image = My.Resources.Charles_Dickens
        Label1.Text = "Guess the Novelist"
    End Function
    Function pic11()
        TextBox2.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 11
        PictureBox1.Image = My.Resources.Dan_brown
        Label1.Text = "Guess the Novelist"
    End Function
    Function pic12()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 12
        PictureBox1.Image = My.Resources.Doraemon
        Label1.Text = "Guess the cartoon character"
    End Function
    Function pic13()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 13
        PictureBox1.Image = My.Resources.ecg
        Label1.Text = "Guess the diagnostic method"
    End Function
    Function pic14()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 14
        PictureBox1.Image = My.Resources.friends
        Label1.Text = "Guess the series"
    End Function
    Function pic15()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 15
        PictureBox1.Image = My.Resources.Gandhari
        Label1.Text = "Guess the mahabharata character"
    End Function
    Function pic16()
        TextBox2.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 16
        PictureBox1.Image = My.Resources.Gulab_Jamun
        Label1.Text = "Guess the sweet"
    End Function
    Function pic17()
        TextBox2.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 17
        PictureBox1.Image = My.Resources.harper_lee
        Label1.Text = "Guess the novelist"
    End Function
    Function pic18()
        TextBox2.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 18
        PictureBox1.Image = My.Resources.jhansi
        Label1.Text = "Guess the woman warrior"
    End Function
    Function pic19()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 19
        PictureBox1.Image = My.Resources.angioplasty
        Label1.Text = "Guess the surgical treatment"
    End Function
    Function pic20()
        TextBox2.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 20
        PictureBox1.Image = My.Resources.lincoln
        Label1.Text = "Guess the personality"
    End Function
    Function pic21()
        TextBox2.Visible = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 21
        PictureBox1.Image = My.Resources.mark__1_
        Label1.Text = "Guess the personality"
    End Function
    Function pic22()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 22
        PictureBox1.Image = My.Resources.ponniyin_selvan
        Label1.Text = "Guess the author for this novel"
    End Function
    Function pic23()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 23
        PictureBox1.Image = My.Resources.ratatouille
        Label1.Text = "Guess the movie"
    End Function
    Function pic24()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 24
        PictureBox1.Image = My.Resources.Ronaldo
        Label1.Text = "Guess the  sports personality"
    End Function
    Function pic25()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 25
        PictureBox1.Image = My.Resources.sindhu
        Label1.Text = "Guess the personality"
    End Function
    Function pic26()
        TextBox2.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        picno = 26
        PictureBox1.Image = My.Resources.sitar
        Label1.Text = "Guess the musical instrument"
    End Function

    Private Sub picturequiz_form2__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        Label1.Text = ""
        Label2.Text = ""
        Label5.Text = ""
        timeleft = 60
        Timer1.Enabled = True

        strtfunction()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        evaluate()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If timeleft > 0 Then
            timeleft -= 1
            Label4.Text = timeleft.ToString + " seconds"
        Else
            Timer1.Enabled = False
            PictureBox1.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Button1.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            Button2.Visible = False
            Dim con As OleDbConnection
            Dim cmd As OleDbCommand
            Dim cmd2 As OleDbCommand
            Dim cmd3 As OleDbCommand
            Dim dr As OleDbDataReader


            Try
                con = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\MiniGame.mdb")
                con.Open()
                cmd = New OleDbCommand("select scores from picquizleaderboard where Rank=@s1", con)
                cmd.Parameters.AddWithValue("@s1", 1)
                dr = cmd.ExecuteReader()
                dr.Read()
                score1 = dr.Item(0)

                cmd2 = New OleDbCommand("select scores from picquizleaderboard where Rank=@s2", con)
                cmd2.Parameters.AddWithValue("@s2", 2)
                dr = cmd2.ExecuteReader()
                dr.Read()
                score2 = dr.Item(0)



                cmd3 = New OleDbCommand("select scores from picquizleaderboard where Rank=@s3", con)
                cmd3.Parameters.AddWithValue("@s3", 3)
                dr = cmd3.ExecuteReader()
                dr.Read()
                score3 = dr.Item(0)


                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            If score <= score3 Then
                MsgBox("Game Over!!!" & vbCrLf & "scores:" & score.ToString(), , "Picture Quiz")
                Me.Close()

            Else
                If score > Val(score1) Then
                    MsgBox("Congrats!!! you have won gold medal" & vbCrLf & "scores:" & score.ToString(), , "Picture Quiz")
                    'MsgBox("Congrats!!! you have won gold medal")
                    pname = InputBox("Enter your Name", "Gold Medalist", "")
                    inval = "1"
                    insertdbgold()
                    Me.Close()


                ElseIf score > Val(score2) Then
                    MsgBox("Congrats!!!You have won silver Medal" & vbCrLf & "scores:" & score.ToString(), , "Picture Quiz")
                    ' MsgBox("Congrats!!!You have won silver Medal")
                    pname = InputBox("Enter your Name", "Silver Medalist", "")
                    inval = "2"
                    insertdbsilver()
                    Me.Close()



                ElseIf score > Val(score3) Then
                    MsgBox("Congrats!!! You have won bronze Medal" & " " & "scores:" & score.ToString(), , "Picture Quiz")
                    'MsgBox("Congrats!!! You have won bronze Medal")
                    pname = InputBox("Enter your Name", "Bronze Medalist", "")
                    inval = "3"
                    insertdb()
                    Me.Close()


                End If


            End If
        End If
    End Sub
    Function insertdb()
        Dim con As OleDbConnection
        Dim ad As OleDbDataAdapter = New OleDbDataAdapter
        Dim sql As String
        con = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\MiniGame.mdb")
        sql = "update picquizleaderboard set PlayerName='" + pname + "',scores='" + score.ToString + "' where Rank='" + inval.ToString + "'"
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
        sql2 = "update picquizleaderboard set Rank='" + l.ToString + "' where Rank='" + j.ToString + "'"
        sql3 = "update picquizleaderboard set Rank='" + j.ToString + "' where Rank='" + k.ToString + "'"
        sql = "update  picquizleaderboard set PlayerName='" + pname + "',scores='" + score.ToString + "',Rank='" + k.ToString + "' where Rank='" + l.ToString + "'"
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
        sql1 = "update picquizleaderboard set Rank='" + m.ToString + "' where Rank='" + l.ToString + "'"
        sql2 = "update picquizleaderboard set Rank='" + l.ToString + "' where Rank='" + k.ToString + "'"
        sql3 = "update picquizleaderboard set Rank='" + k.ToString + "' where Rank='" + j.ToString + "'"
        sql4 = "update picquizleaderboard set PlayerName='" + pname + "',scores='" + score.ToString + "',Rank='" + j.ToString + "' where Rank='" + m.ToString + "'"
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


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Button2.Text = "Hints(" & hleft & ")"
        If hintcounter > 0 Then

            Select Case picno
                Case 1
                    Label5.Text = "He created the C programming language"
                Case 2
                    Label5.Text = "Capital of France"
                Case 3
                    Label5.Text = "The story of fish Marlin who searches for his abducted son"
                Case 4
                    Label5.Text = "The movie directed by James Cameron"
                Case 5
                    Label5.Text = "The capital of northern Italy"
                Case 6
                    Label5.Text = "He is the son of Nohara in the japanese series"
                Case 7
                    Label5.Text = "Hero for the movie is sivakarthikeyan"
                Case 8
                    Label5.Text = "Barack Obama is the president of the country"
                Case 9
                    Label5.Text = "It belongs to the genus Aloe"
                Case 10
                    Label5.Text = "Oliver twist is one of his novel"
                Case 11
                    Label5.Text = "Inferno,Digital Fortress are some of his other novels"
                Case 12
                    Label5.Text = "The character is known for its gadgets bag"
                Case 13
                    Label5.Text = "It is a test that checks the electrical activity of heart"
                Case 14
                    Label5.Text = "Follow the lives of six adults in Manhattan"
                Case 15
                    Label5.Text = "Mother of duriyodana"
                Case 16
                    Label5.Text = "It is served with jeera"
                Case 17
                    Label5.Text = "Go set a Watchman - her other novel"
                Case 18
                    Label5.Text = "She was the ruler of the Maratha-ruled state"

                Case 19
                    Label5.Text = "Angiogram test is done before this treatment"
                Case 20
                    Label5.Text = "16th President of United States"
                Case 21
                    Label5.Text = "He is the co-founder of Facebook"
                Case 22
                    Label5.Text = "The short story Idintha kottai was written by him"
                Case 23
                    Label5.Text = "The movie revolves around the rat that aspires to become a chef"
                Case 24
                    Label5.Text = "Portuguese footballer"
                Case 25
                    Label5.Text = "She won Silver in the RioOlympics 2016 in badminton"
                Case 26
                    Label5.Text = "The origin of this insstrument lies with veena and guitar"
            End Select
        Else
            Label5.Text = "You have no more hints"
        End If

        hintcounter -= 1
        If hleft > 0 Then
            hleft -= 1
        End If

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class