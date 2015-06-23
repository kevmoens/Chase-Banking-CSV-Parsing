Public Class CardHolders
    Inherits List(Of CardHolder)
    Public Sub New()

    End Sub

    Public Function GetCardHolder(ByVal InText As String) As CardHolder
        For Each oCardHolder In Me
            If oCardHolder.IsInCondition(InText) Then
                Return oCardHolder
            End If
        Next
        Return New CardHolder("", "UNKNOWN")
    End Function
    Public Sub Load()

        Try
            Try
                Dim oxml As System.Xml.Serialization.XmlSerializer = New System.Xml.Serialization.XmlSerializer(Me.GetType)
                Dim collCardHolders As CardHolders
                Dim oRead = New System.IO.StreamReader(Application.StartupPath & "\CardHolders.xml")
                collCardHolders = CType(oxml.Deserialize(oRead), CardHolders)
                oRead.Close()
                For Each oCat In (From oCardHolder In collCardHolders Where oCardHolder.Name.ToUpper <> "UNKNOWN" And oCardHolder.Name.Trim <> "").ToList
                    Add(oCat)
                Next
            Catch
            End Try
            If Me.Count = 0 Then
                Add(New CardHolder("U R*", "Kevin", "U R*"))
                Add(New CardHolder("D C*", "Chandra", "D C*"))
            End If
            Add(New CardHolder("", "UNKNOWN"))
        Catch ex As Exception
            MsgBox("Error Loading" & vbCrLf & ex.Message)
            Add(New CardHolder("", "UNKNOWN"))
        End Try
    End Sub
End Class
