Imports System.IO
Public Class Form1
    Dim _AllTrxs As New List(Of Transaction)

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Done Change so all categories are loaded from XML
        'Done Add tool to manipulate categories
        'Todo Load Multiple CSV files for larger range
        g_AllCategories.Load()
        g_AllCardHolders.Load()
        grdCategories.DataSource = g_AllCategories
        grdCategories.Columns(1).ReadOnly = True
        grdCardHolders.DataSource = g_AllCardHolders
        grdCardHolders.Columns(1).ReadOnly = True
        grdCardHolders.Columns(2).ReadOnly = True
        btnLoad_Click(sender, e)
    End Sub
#Region "Process"
    Private Sub btnProcess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcess.Click


        Dim _AllCurTrxs = (From oTrx In _AllTrxs _
            Join oCat In g_AllCategories On oTrx.Category Equals oCat.Name _
            Join oCH In g_AllCardHolders On oTrx.CardHolder Equals oCH.CardHolder _
        Where oCat.Selected = True _
            And oCH.Selected = True _
            Select oTrx _
        ).ToList

        Dim _CurTrxs = (From oTrx In _AllCurTrxs _
        Where (DateTimePicker1.Value <= oTrx.TrxDate And oTrx.TrxDate <= DateTimePicker2.Value) _
            Select oTrx _
        ).ToList

        DataGridView1.DataSource = (From oTrx In _CurTrxs Group By oTrx.Category Into Sum(oTrx.Amount)).ToList
        lblSum.Text = (Aggregate oTrx In _CurTrxs Into Sum(oTrx.Amount)).ToString

    End Sub

    Private Sub btnProcessDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessDetail.Click

        Dim _AllCurTrxs = (From oTrx In _AllTrxs _
                    Join oCat In g_AllCategories On oTrx.Category Equals oCat.Name _
            Join oCH In g_AllCardHolders On oTrx.CardHolder Equals oCH.CardHolder _
        Where (DateTimePicker1.Value <= oTrx.TrxDate And oTrx.TrxDate <= DateTimePicker2.Value) _
            And oCat.Selected = True _
            And oCH.Selected = True _
            Select oTrx _
        ).ToList
        ''oTrx.Type, oTrx.TrxDate, oTrx.Description, oTrx.Amount, oTrx.Category.Name _
        Dim _CurTrxs = (From oTrx In _AllCurTrxs _
        Where (DateTimePicker1.Value <= oTrx.TrxDate And oTrx.TrxDate <= DateTimePicker2.Value) _
            Select oTrx _
        ).ToList
        'Select oTrx.Type, oTrx.TrxDate, oTrx.Description, oTrx.Amount, oTrx.Name _

        'DataGridView1.DataSource = _CurTrxs
        LoadDataGridView(_CurTrxs)
        lblSum.Text = (Aggregate oTrx In _CurTrxs Into Sum(oTrx.Amount)).ToString
    End Sub
    Public Sub LoadDataGridView(ByVal InListTrxs As List(Of Transaction))
        DataGridView1.DataSource = InListTrxs
        With DataGridView1
            .Columns.RemoveAt(.Columns.Count - 3)
            .Columns.RemoveAt(.Columns.Count - 2)
            ' Set DataGridView Combo Column for CarID field   
            Dim ColumnCar As New DataGridViewComboBoxColumn
            ' DataGridView Combo ValueMember field has name "CarID"  
            ' DataGridView Combo DisplayMember field has name "Car"  
            With ColumnCar
                .DataPropertyName = "Category"
                .HeaderText = "Category"
                .DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox

                .Width = 120
                ' Bind ColumnCar to Cars table  
                .DataSource = g_AllCategories
                .ValueMember = "Name"
                .DisplayMember = "Name"
            End With
            .Columns.Add(ColumnCar)
            .Columns(2).Width = 400
        End With
    End Sub
#End Region
#Region "Change Range"
    Private Sub btnMinusWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinusWeek.Click
        DateTimePicker1.Value = DateAdd(DateInterval.Day, -7, DateTimePicker1.Value)
        DateTimePicker2.Value = DateAdd(DateInterval.Day, -7, DateTimePicker2.Value)
    End Sub

    Private Sub btnPlusWeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlusWeek.Click
        DateTimePicker1.Value = DateAdd(DateInterval.Day, 7, DateTimePicker1.Value)
        DateTimePicker2.Value = DateAdd(DateInterval.Day, 7, DateTimePicker2.Value)
    End Sub

    Private Sub btnMinusMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinusMonth.Click
        DateTimePicker1.Value = DateAdd(DateInterval.Month, -1, DateTimePicker1.Value)
        DateTimePicker2.Value = DateAdd(DateInterval.Month, -1, DateTimePicker2.Value)
    End Sub

    Private Sub btnPlusMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlusMonth.Click
        DateTimePicker1.Value = DateAdd(DateInterval.Month, 1, DateTimePicker1.Value)
        DateTimePicker2.Value = DateAdd(DateInterval.Month, 1, DateTimePicker2.Value)
    End Sub
#End Region

    Private Sub grdCategories_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdCategories.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right And e.RowIndex > -1 Then
            CategoriesContextMenuStrip.Show(Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y)
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Dim intIndex As Integer = grdCategories.CurrentRow.Index
        Dim ofrmCat As New frmCategories(frmCategories.Action.Add)
        ofrmCat.ShowDialog()
        If ofrmCat.Category IsNot Nothing Then
            g_AllCategories.Add(ofrmCat.Category)
            g_AllCategories.Save()
            For Each oTrx In (From oAllTrx In _AllTrxs Where oAllTrx.Category = "UNKNOWN").ToList
                oTrx.Category = g_AllCategories.GetCategory(oTrx.Description).Name
            Next
            grdCategories.DataSource = Nothing
            grdCategories.DataSource = g_AllCategories
            grdCategories.Columns(1).ReadOnly = True
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim intIndex As Integer = grdCategories.CurrentRow.Index
        Dim ofrmCat As New frmCategories(frmCategories.Action.Update, g_AllCategories(intIndex))
        ofrmCat.ShowDialog()
        If ofrmCat.Category IsNot Nothing Then
            g_AllCategories.RemoveAt(intIndex)
            g_AllCategories.Insert(intIndex, ofrmCat.Category)
            g_AllCategories.Save()
            For Each oTrx In (From oAllTrx In _AllTrxs Where oAllTrx.Category = "UNKNOWN").ToList
                oTrx.Category = g_AllCategories.GetCategory(oTrx.Description).Name
            Next
        End If
        Me.Focus()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        Try
            If MsgBox("Are you sure you want to remove [" & grdCategories.CurrentRow.Cells(1).Value.ToString & "]?", MsgBoxStyle.YesNo, "Remove Category") = MsgBoxResult.Yes Then
                Dim intIndex = grdCategories.CurrentRow.Index
                grdCategories.DataSource = Nothing
                g_AllCategories.RemoveAt(intIndex)
                grdCategories.DataSource = g_AllCategories
                grdCategories.Columns(1).ReadOnly = True

            End If
        Catch
        End Try
    End Sub


    Private Sub DataGridView1_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        Debug.Print(e.Exception.Message)

    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            Dim strPath As String = String.Empty
            OpenFileDialog1.FileName = "C:\mydocs\personal\JPMC.CSV"
            OpenFileDialog1.DefaultExt = "*.csv"
            OpenFileDialog1.Filter = "Comma Seperated Text(*.csv)|*.csv"
            OpenFileDialog1.Multiselect = False
            OpenFileDialog1.ShowDialog()
            strPath = OpenFileDialog1.FileName
            If Not File.Exists(strPath) Then
                Exit Sub
            End If
            Dim oCSV As New StreamReader(strPath)
            Try
                Dim collLines = (From oline In oCSV.ReadToEnd.Split(CChar(vbCr))).ToList
                Dim collSplit = (From oData In collLines Select oData.Split(CChar(",")).ToList).ToList
                Dim collNewTrx = (From oRec In collSplit Where oRec.Count = 5 Select New Transaction(oRec.Item(0), oRec.Item(1), oRec.Item(2), oRec.Item(3))).ToList
                Dim collTrxs = (From oNewRec In collNewTrx Group Join oExist In _AllTrxs On _
                                oNewRec.TrxDate Equals oExist.TrxDate And _
                                oNewRec.Amount Equals oExist.Amount And _
                                oNewRec.Description Equals oExist.Description And _
                                oNewRec.Type Equals oExist.Type _
                                Into HaveAny = Any() _
                                Where HaveAny = False _
                                Select oNewRec).ToList

                _AllTrxs.AddRange(collTrxs)
                oCSV.Close()
            Catch ex2 As Exception
                MessageBox.Show(ex2.Message, "Error Loading CSV file:2")
                Try
                    oCSV.Close()
                Catch
                End Try
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading CSV file")
        End Try

        MessageBox.Show("Success" & vbCrLf & _AllTrxs.Count.ToString, "Loading CSV File")
    End Sub
End Class