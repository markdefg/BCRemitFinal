Public Class MySessionClass
    Private u_email As String

    Public Property email() As String
        Get
            Return u_email
        End Get
        Set(value As String)
            u_email = value
        End Set
    End Property

End Class
