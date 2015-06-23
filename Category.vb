Public Class Category
    Public Sub New(ByVal InName As String)
        _Name = InName
        _Selected = True
    End Sub
    Public Sub New(ByVal InName As String, ByVal ParamArray InConditions() As String)
        _Name = InName
        _Conditions = New Conditions(InConditions)
        _Selected = True
    End Sub
    Public Sub New()
        _Selected = True
    End Sub

    Private _Selected As Boolean
    Public Property [Selected]() As Boolean
        Get
            Return _Selected
        End Get
        Set(ByVal value As Boolean)
            _Selected = value
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
Public Class Condition
    Public Sub New()

    End Sub
    Public Sub New(ByVal InCondition As String)
        _Condition = InCondition
    End Sub
    Private _Condition As String
    Public Property Condition() As String
        Get
            Return _Condition
        End Get
        Set(ByVal value As String)
            _Condition = value
        End Set
    End Property

End Class
Public Class Conditions
    Inherits List(Of Condition)
    Public Sub New()

    End Sub
    Public Sub New(ByVal InStringArray() As String)
        Me.AddRange(From strCondition In InStringArray Select New Condition(strCondition))
    End Sub
End Class
Public Class Categories
    Inherits List(Of Category)
    Public Sub New()

    End Sub
    Public Function GetCategory(ByVal InText As String) As Category
        For Each oCategory In Me
            If oCategory.IsInCondition(InText) Then
                Return oCategory
            End If
        Next
        Return New Category("UNKNOWN")
    End Function
    Public Sub Save()
        Try
            Dim oxml As System.Xml.Serialization.XmlSerializer = New System.Xml.Serialization.XmlSerializer(Me.GetType)

            Dim oWrite = New System.IO.StreamWriter(Application.StartupPath & "\Categories.xml")
            oxml.Serialize(oWrite, Me)
            oWrite.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving XML" & vbCrLf & ex.Message, "Error")
        End Try
    End Sub
    Public Sub Load()        

        Try
            Dim oxml As System.Xml.Serialization.XmlSerializer = New System.Xml.Serialization.XmlSerializer(Me.GetType)
            Dim collCategories As Categories
            Dim oRead = New System.IO.StreamReader(Application.StartupPath & "\Categories.xml")
            collCategories = CType(oxml.Deserialize(oRead), Categories)
            oRead.Close()
            For Each oCat In (From oCategory In collCategories Where oCategory.Name.ToUpper <> "UNKNOWN" And oCategory.Name.Trim <> "").ToList
                Add(oCat)
            Next
            Add(New Category("UNKNOWN"))
        Catch ex As Exception
            MsgBox("Error Loading" & vbCrLf & ex.Message)
            Add(New Category("Bill", "Online Payment", "EINSTEIN WIRELESS", "AIRADIGM COMMUNICAT"))
            Add(New Category("CarMaint", "GUSTMAN", "J & S AUTO", "STATE WI REG & LIC"))
            Add(New Category("CHECK", "CHECK"))
            Add(New Category("DEPOSIT", "DEPOSIT", "THE LAKE CO"))
            Add(New Category("DoctorBill", "AURORA HEALTH", "KEESLER ORTHODONTICS", "DR. BRUCE WALTERS", "PREVEA CLINIC"))
            Add(New Category("ExtrasAndEntertainment", "OLD NAVY", "MAC", "MALL OF AMERICA", "KOHL'S", "EAST TOWN 124", "FAMILY VIDEO", "GREEN BAY BLIZZARD", "BEST BUY", "TJMAXX", "PINNACHE SALON", "OFFICE MAX", "JCPENNEY", "JO-ANN ETC", "MARCUS CINEMA", "PANNACHE", "FACTORY CARD OUTLET", "WINSLOW'S HALLMARK", "HOTWIRE", "EXPRESS", "RAINFOREST", "AEROPOSTALE", "ARCHIVERS", "JUSTICE", "PERSONALIZATION", "GREEN BAY PACKERS", "ROLARENA", "BROWN COUNTY NEW ZOO", "ICING BY CLAIRES", "HOT TOPIC", "CYBER WORKS", "YOUNKERS", "CNS VICTORIA'S SECR", "BARNES & NOBLE", "PAYLESSSHOES", "KIRKLAND'S", "BELLA SALON", "FOREVER 21", "GREATER GREEN BAY YM", "SS PETER AND PAUL"))
            Add(New Category("Gas", "SHELL OIL", "EXXONMOBIL", "UNIVERSITY BP", "KWIK TRIP", "CLARK", "MYSZKA ONE STOP"))
            Add(New Category("KidsLunch", "Green Bay Area P E FUNDS"))
            Add(New Category("MenardsFleetFarm", "MENARDS""Mills Fleet Farm"))
            Add(New Category("Grocery", "COPPS", "FESTIVAL FOODS", "ALDI", "WEBSTER AVENUE MARK", "WOODMAN'S", "UNIVERSITY SUPE"))
            Add(New Category("Restaurant", "MCDONALD'S", "TACO BELL", "HARDEE", "SUBWAY", "A & W", "KFC", "PANDA HOUSE", "WENDY'S", "PRIME QTR", "APPLEBEES", "EL SARAPE", "CHEVY'S FRESH MEX", "FAMOUS DAVE'S", "MILL TOWN CAFE", "MARGARITAS", "PAPA JOHNS", "FAZOLI'S", "GREEN BAY PIZZA CO", "CHEVYS FRESH MEX", "COLDSTN CREAM", "BOULEVARD CAFE", "CARIBOU COFFEE"))
            Add(New Category("Transfer", "Online Transfer"))
            Add(New Category("WeeklyNeeds", "WAL-MART", "AERIAL", "TARGET", "WALGREENS", "WM SUPERCENTER", "REGIS", "SHOPKO", "KMART", "DOLRTREE"))
            Add(New Category("UNKNOWN"))
        End Try
    End Sub
End Class
