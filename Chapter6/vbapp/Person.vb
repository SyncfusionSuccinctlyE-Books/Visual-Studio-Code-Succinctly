Public Class Person
    Private _personName As String
    Public Property PersonName As String
        Get
            Return _personName
        End Get
        Set(ByVal value As String)
            _personName = value
        End Set
    End Property
End Class