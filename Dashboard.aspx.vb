Imports System.Data.SqlClient

Public Class Dashboard
    Inherits System.Web.UI.Page

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Create_Session()
        Display_Data()
    End Sub
    Protected Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Session.Clear()
        Response.Redirect("LandingPage.aspx")
    End Sub

    Public Sub Display_Data()
        con.Open()
        'cmd = con.CreateCommand()
        'cmd.CommandType = CommandType.Text
        'cmd.CommandText = "SELECT fname, lname, email FROM accounts"
        'cmd.ExecuteNonQuery()
        'Dim dt As New DataTable
        'Dim ds As New SqlDataAdapter(cmd)
        'ds.Fill(dt)
        'GridView1.DataSource = dt
        cmd.CommandText = "SELECT fname, lname, email FROM accounts"
        cmd.Connection = con
        GridView1.DataSource = cmd.ExecuteReader
        GridView1.DataBind()

        con.Close()

    End Sub

    Public Sub Create_Session()
        con.ConnectionString = ("Data Source=BCREMIT-011;Initial Catalog=Users;Integrated Security=True")
        Dim TestCall As MySessionClass
        TestCall = Session("Mykey")

        If TestCall Is Nothing Then
            Response.Redirect("Login.aspx")
        Else
            Response.Write("You are login as:" & TestCall.email)
        End If
    End Sub

End Class