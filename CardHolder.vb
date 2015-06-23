Public Class CardHolder
    Public Sub New()

    End Sub
    Public Sub New(ByVal InCardHolder As String, ByVal InName As String)
        _CardHolder = InCardHolder
        _Name = InName
    End Sub
    Public Sub New(ByVal InCardHolder As String, ByVal InName As String, ByVal InCondition As String)
        _CardHolder = InCardHolder
        _Name = InName
        _Conditions = New Conditions
        _Conditions.Add(New Condition(InCondition))
    End Sub

    Private _Selected As Boolean
    Public Property Selected() As Boolean
        Get
            Return _Selected
        End Get
        Set(ByVal value As Boolean)
            _Selected = value
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

    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Private _Conditions As Conditions
    Public Property Conditions() As Conditions
        Get
            Return _Conditions
        End Get
        Set(ByVal value As Conditions)
            _Conditions = value
        End Set
    End Property
    Public Function IsInCondition(ByVal InText As String) As Boolean
        If Conditions IsNot Nothing Then
            For Each strCondition In Conditions
                If InText.ToUpper.StartsWith(strCondition.Condition.ToUpper) Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function

End Class
