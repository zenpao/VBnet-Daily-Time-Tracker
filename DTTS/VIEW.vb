Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class VIEW

    Dim objConn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbTimeline.mdb")
    Dim objComm As OleDbCommand
    Dim objAdap As OleDbDataAdapter
    Dim objDt As New System.Data.DataTable

    Dim connString As String = " Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbTimeline.mdb"
    Dim excelLocation As String
    Dim path As String
    Dim MyConn As System.Data.OleDb.OleDbConnection
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Dim APP As New Excel.Application
    Dim xlWorksheet As Excel.Worksheet
    Dim xlWorkbook As Excel.Workbook

    Private Sub VIEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ACC.txtID.Clear()
        ACC.txtPassword.Clear()

        'objComm = New OleDbCommand("SELECT Date_Recorded AS [Date], Time_In AS [Time In], Time_Out AS [Time Out] FROM Records WHERE User_Name= '" & DTR.lnkViewUserRecords.Text.ToString.ToUpper & "'", objConn)
        'objAdap = New OleDbDataAdapter(objComm)

        'Try
        '    objAdap.Fill(objDt)

        '    If objDt.Rows.Count > 0 Then
        '        DataGridView1.DataSource = objDt
        '    Else
        '        MsgBox("No Records found.", MsgBoxStyle.OkOnly, "Empty")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    If objConn.State = ConnectionState.Open Then
        '        objConn.Close()
        '    End If
        'End Try

    End Sub
    Private Sub btnExport2_Click(sender As Object, e As EventArgs) Handles btnExport2.Click

        DataGridView1.EndEdit()

        '*****************GET DIRECTORY FOR WHICH THE USER WANTS TO EXPORT THE EXCEL FILE.

        Dim result As Integer = MessageBox.Show("Specify directory for saving?", "Set Directory", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            FolderBrowserDialog1.ShowDialog()
            path = CStr(FolderBrowserDialog1.SelectedPath.ToString)
        ElseIf (result = DialogResult.No) Then
            path = CStr(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
        End If

        '*****************TRANSFER EXCEL FILE IN THE CHOSEN DIRECTORY

        Dim source As String = My.Application.Info.DirectoryPath & "\DTR.xlsx" 'get directory of original file

        Dim buildDir As String
        Dim buildDir1 As New System.Text.StringBuilder()
        buildDir = buildDir1.Append("" + path).Append("\").Append("DTR").Append(".xlsx").ToString


        'If Not System.IO.File.Exists(excelLocation) Then
        '    System.IO.File.Create(excelLocation).Dispose()
        'End If

        'File.Create(excelLocation).Dispose() 'automatically creates and overwrites it while closing the reference afterwards.

        File.Copy(source, buildDir, True)

        excelLocation = buildDir

        '******************EXPORTS THE EXCEL FILE

        APP = New Excel.Application
        xlWorkbook = APP.Workbooks.Open(excelLocation)
        xlWorkbook.Application.Visible = False

        'xlWorkbook = APP.Workbooks.Open(excelLocation)
        xlWorksheet = xlWorkbook.Worksheets("sheet1")
        MyConn = New System.Data.OleDb.OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        objAdap = New OleDbDataAdapter("SELECT Date_Recorded AS [Date], Time_In AS [Time In], Time_Out AS [Time Out], Log_Remarks AS [Remarks] FROM Records WHERE User_Name= '" & DTR.lnkViewUserRecords.Text.ToString.ToUpper & "' ORDER BY Date_Recorded", MyConn) 'Change items to your database name
        objAdap.Fill(ds, "Records") 'Change items to your database name
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view
        DataGridView1.AllowUserToAddRows = False

        Dim columnsCount As Integer = DataGridView1.Columns.Count
        For Each column In DataGridView1.Columns
            xlWorksheet.Cells(1, column.Index + 1).Value = column.Name
        Next
        'Export Header Name End

        'Export Each Row Start
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim columnIndex As Integer = 0
            Do Until columnIndex = columnsCount
                xlWorksheet.Cells(i + 2, columnIndex + 1).Value = DataGridView1.Item(columnIndex, i).Value.ToString
                columnIndex += 1
            Loop
        Next
        'Export Each Row End

        MsgBox("DTR successfully saved at: " & excelLocation)

        xlWorkbook.Save()
        xlWorkbook.Close()
        APP.Quit()

    End Sub

    Private Sub VIEW_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        DataGridView1.EndEdit()
        ACC.txtID.Clear()
        ACC.txtPassword.Clear()
        DTR.txtRem.Clear()
        Me.Close()
        DTR.Show()

    End Sub

End Class