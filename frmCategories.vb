Imports System.Xml.Serialization
Imports System.IO
Imports System.Xml

Public Class frmCategories
    Public Enum Action
        None = 0
        Add = 1
        Update = 2
    End Enum

    Private _Category As Category
    Public Property Category() As Category
        Get
            Return _Category
        End Get
        Set(ByVal value As Category)
            _Category = value
        End Set
    End Property

    Private _SavedCategory As String
    Public Property SavedCategory() As String
        Get
            Return _SavedCategory
        End Get
        Set(ByVal value As String)
            _SavedCategory = value
        End Set
    End Property

    Private _CurrentAction As Action
    Public Property CurrentAction() As Action
        Get
            Return _CurrentAction
        End Get
        Set(ByVal value As Action)
            _CurrentAction = value
        End Set
    End Property

    Private _Cancelled As Boolean = True
    Public Property Cancelled() As Boolean
        Get
            Return _Cancelled
        End Get
        Set(ByVal value As Boolean)
            _Cancelled = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(ByVal InAction As Action)
        Me.New()
        _CurrentAction = InAction
        _Category = New Category
    End Sub
    Public Sub New(ByVal InAction As Action, ByVal InCategory As Category)
        Me.New()
        _CurrentAction = InAction
        _Category = InCategory
        Dim xml_serializer As New XmlSerializer(GetType(Category))
        Dim string_writer As New StringWriter
        xml_serializer.Serialize(string_writer, InCategory)
        _SavedCategory = string_writer.ToString()
        string_writer.Close()

    End Sub

    Private Sub frmCategories_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If _Cancelled Then
            If _CurrentAction = Action.Update Then
                Try

                    Dim oReader As System.IO.StringReader = New System.IO.StringReader(_SavedCategory)
                    Dim oxml As System.Xml.Serialization.XmlSerializer = New System.Xml.Serialization.XmlSerializer(Category.GetType)
                    _Category = CType(oxml.Deserialize(oReader), Category)
                    oReader.Close()
                Catch
                End Try
            Else
                _Category = Nothing
            End If
        End If
    End Sub


    Private Sub frmCategories_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Select Case _CurrentAction
            Case Action.None
                'Make all components disabled
                txtName.Enabled = False
            Case Action.Add
                btnSave.Text = "Add"
            Case Action.Update
                txtName.Enabled = False
                btnSave.Text = "Update"
        End Select
        txtName.Text = _Category.Name
        If _Category.Conditions Is Nothing Then
            _Category.Conditions = New Conditions
            _Category.Conditions.Add(New Condition(""))
        End If

        grdConditions.DataSource = _Category.Conditions
        grdConditions.Columns(0).Width = 300
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Hide()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        _Category.Name = txtName.Text
        _Cancelled = False
        Me.Hide()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        grdConditions.DataSource = Nothing
        _Category.Conditions.Add(New Condition(""))
        grdConditions.DataSource = _Category.Conditions
        grdConditions.Columns(0).Width = 300

    End Sub


    Private Sub grdConditions_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdConditions.CellMouseClick
        Try
            If e.Button = Windows.Forms.MouseButtons.Right And e.RowIndex > -1 Then
                AddToolStripMenuItem.Visible = True
                RemoveToolStripMenuItem.Visible = True
                ConditionsContextMenuStrip.Show(Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y)
            Else
                If e.Button = Windows.Forms.MouseButtons.Right Then
                    AddToolStripMenuItem.Visible = True
                    RemoveToolStripMenuItem.Visible = False
                    ConditionsContextMenuStrip.Show(Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y)
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        Try
            If MsgBox("Are you sure you want to remove [" & grdConditions.CurrentRow.Cells(0).Value.ToString & "]?", MsgBoxStyle.YesNo, "Remove Condition") = MsgBoxResult.Yes Then
                Dim intIndex = grdConditions.CurrentRow.Index
                grdConditions.DataSource = Nothing
                _Category.Conditions.RemoveAt(intIndex)
                grdConditions.DataSource = _Category.Conditions
                grdConditions.Columns(0).Width = 300

            End If
        Catch
        End Try
    End Sub

    Private Sub grdConditions_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdConditions.DataError
        Debug.Print(e.Exception.Message)
    End Sub

    Private Sub grdConditions_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdConditions.CellContentClick

    End Sub
End Class