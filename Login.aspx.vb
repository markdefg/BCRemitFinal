Imports System.Data.SqlClient
Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        Login_User()
    End Sub

    Protected Sub Login_User()
        Dim SessionClass As New MySessionClass

        SessionClass.email = email.Text
        Session.Add("Mykey", SessionClass)

        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        objcon = New SqlConnection("Data Source=BCREMIT-011;Initial Catalog=Users;Integrated Security=True")
        objcon.Open()

        psw.Text = md5(psw.Text)

        Dim stmt As String = "SELECT * FROM accounts WHERE email ='" & email.Text & "' AND password = '" & psw.Text & "'"
        objcmd = New SqlCommand(stmt, objcon)
        Dim reader As SqlDataReader = objcmd.ExecuteReader

        If reader.Read Then

            MsgBox("Login Successful!", MsgBoxStyle.Information, "Success")
            SessionClass.email = email.Text
            Session.Add("Mykey", SessionClass)
            Response.Redirect("Dashboard.aspx")
        Else
            MsgBox("Email or password is incorrect", MsgBoxStyle.Information, "Critical")
            email.Text = ""
            psw.Text = ""
            objcon.Close()
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






