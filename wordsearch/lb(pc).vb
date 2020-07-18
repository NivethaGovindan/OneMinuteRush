
Imports System.Data.OleDb
Public Class lb_pc_

    Private Sub OvalShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Silver.Click

    End Sub

    Private Sub lb_pc__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As OleDbConnection
        Dim cmd As OleDbCommand
        Dim cmd2 As OleDbCommand
        Dim cmd3 As OleDbCommand
        Dim dr As OleDbDataReader
        Dim score1 As Integer
        Dim score2 As Integer
        Dim score3 As Integer
        Dim p1 As String = ""
        Dim p2 As String = ""
        Dim p3 As String = ""
        Try
            con = New OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\MiniGame.mdb")
            con.Open()
            cmd = New OleDbCommand("select PlayerName,Scores from picquizleaderboard where Rank=@s1", con)
            cmd.Parameters.AddWithValue("@s1", 1)
            dr = cmd.ExecuteReader()
            dr.Read()
            p1 = dr.Item(0)
            score1 = dr.Item(1)

            cmd2 = New OleDbCommand("select PlayerName,Scores from picquizleaderboard where Rank=@s2", con)
            cmd2.Parameters.AddWithValue("@s2", 2)
            dr = cmd2.ExecuteReader()
            dr.Read()
            p2 = dr.Item(0)
            score2 = dr.Item(1)


            cmd3 = New OleDbCommand("select PlayerName,scores from picquizleaderboard where Rank=@s3", con)
            cmd3.Parameters.AddWithValue("@s3", 3)
            dr = cmd3.ExecuteReader()

            dr.Read()
            p3 = dr.Item(0)
            score3 = dr.Item(1)


            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Label1.Text = p1
        Label2.Text = p2
        Label3.Text = p3
        Label4.Text = score1.ToString
        Label5.Text = score2.ToString
        Label6.Text = score3.ToString
    End Sub
End Class