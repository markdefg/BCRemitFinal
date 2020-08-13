Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException


Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Create_User()
    End Sub

    Protected Sub Create_User()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmdInsert As New SqlCommand
        Dim dr As SqlDataReader

        con.ConnectionString = "Data Source=BCREMIT-011;Initial Catalog=Users;Integrated Security=True"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM accounts WHERE email = '" & email.Text & "' "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Email has already taken. Please use other Email.", MsgBoxStyle.Critical)
            email.Text = ""
            con.Close()
        Else
            con.Close()
            con.Open()

            psw.Text = md5(psw.Text)

            cmdInsert.Connection = con
            cmdInsert.CommandText = "INSERT INTO accounts (fname,lname,email,password) VALUES('" & fname.Text & "','" & lname.Text & "','" & email.Text & "','" & psw.Text & "')"
            cmdInsert.ExecuteNonQuery()

            MsgBox("You are Registered! Please Log-in", MsgBoxStyle.Information, "Success")
            Response.Redirect("Login.aspx")
            con.Close()

        End If

    End Sub
    Public Function md5(ByRef strText As String) As String
        Dim md5Service As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytes() As Byte = md5Service.ComputeHash(System.Text.Encoding.ASCII.GetBytes(strText))
        Dim s As String
        For Each by As Byte In bytes
            s += by.ToString("x2")
        Next
        Return s

    End Function
End Class