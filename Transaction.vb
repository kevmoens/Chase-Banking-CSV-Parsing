
Public Class Transaction

    Public Sub New(ByVal InType As String, ByVal InDate As String, ByVal InDesc As String, ByVal InAmt As String)
        _Type = InType.Trim
        Try
            _Date = CDate(InDate.Substring(0, 2) & "-" & InDate.Substring(3, 2) & "-" & InDate.Substring(6, 4))
        Catch ex As Exception
            Try
                _Date = CDate(InDate.Substring(0, 4) & "-" & InDate.Substring(4, 2) & "-" & InDate.Substring(6, 2))
            Catch ex2 As Exception
                Debug.Print(ex2.Message)
            End Try
        End Try
        _Amount = Val(InAmt)
        Dim intIndex = InDesc.IndexOf("*")
        If intIndex > 0 And intIndex < 5 Then
            _CardHolder = InDesc.Substring(1, intIndex)
            _Description = InDesc.Substring(6, InDesc.Length - 7)
        Else
            _CardHolder = ""
            _Description = InDesc.Substring(1, InDesc.Length - 2)
        End If
        _Category = g_AllCategories.GetCategory(_Description).Name
        _CardHolderName = g_AllCardHolders.GetCardHolder(_CardHolder).Name
    End Sub
    Private _Type As String
    Public Property Type() As String
        Get
            Return _Type
        End Get
        Set(ByVal value As String)
            _Type = value
        End Set
    End Property

    Private _Date As Date
    Public Property TrxDate() As Date
        Get
            Return _Date
        End Get
        Set(ByVal value As Date)
            _Date = value
        End Set
    End Property

    Private _Description As String
    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
        End Set
    End Property

    Private _Amount As Double
    Public Property Amount() As Double
        Get
            Return _Amount
        End Get
        Set(ByVal value As Double)
            _Amount = value
        End Set
    End Property

    Private _Category As String
    Public Property Category() As String
        Get
            Return _Category
        End Get
        Set(ByVal value As String)
            _Category = value
        End Set
    End Property

    Private _CardHolder As String
    Public Property CardHolder() As String
        Get
            Return _CardHolder
        End Get
        Set(ByVal value As String)
            _CardHolder = value
        End Set
    End Property

    Private _CardHolderName As String
    Public Property CardHolderName() As String
        Get
            Return _CardHolderName
        End Get
        Set(ByVal value As String)
            _CardHolderName = value
        End Set
    End Property

End Class