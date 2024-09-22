Imports System.Data.OleDb
Public Class DTR

    Dim objConn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbTimeline.mdb")
    Dim objComm As OleDbCommand
    Dim objAdap As OleDbDataAdapter
    Dim objDt As DataTable

    Friend list As New List(Of Object)

    Friend generatedLogID As Integer

    Public CheckDate As String
    Private Sub DTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rad1.Checked = False
        rad2.Checked = False
        DateTimePicker1.Enabled = False
        cmbHH1.Enabled = False
        cmbHH2.Enabled = False
        cmbMM1.Enabled = False
        cmbMM2.Enabled = False
        cmbTT1.Enabled = False
        cmbTT2.Enabled = False
        txtRem.Enabled = False
        btnRecord.Enabled = False
        btnRecord.Text = "Record"
        lnkRemove.Enabled = True

        Timer1.Start()

        Reset()

        ACC.txtID.Clear()
        ACC.txtPassword.Clear()

    End Sub

    Private Sub rad1_CheckedChanged(sender As Object, e As EventArgs) Handles rad1.CheckedChanged

        Reset()
        DateTimePicker1.Enabled = True
        cmbHH1.Enabled = True
        cmbMM1.Enabled = True
        cmbTT1.Enabled = True
        cmbHH2.Enabled = False
        cmbMM2.Enabled = False
        cmbTT2.Enabled = False
        btnRecord.Enabled = True
        btnRecord.Text = "Time In"
        lnkRemove.Enabled = True
        txtRem.Clear()
        txtRem.Enabled = True

    End Sub

    Private Sub rad2_CheckedChanged(sender As Object, e As EventArgs) Handles rad2.CheckedChanged

        Reset()
        DateTimePicker1.Enabled = True
        cmbHH2.Enabled = True
        cmbMM2.Enabled = True
        cmbTT2.Enabled = True
        cmbHH1.Enabled = False
        cmbMM1.Enabled = False
        cmbTT1.Enabled = False
        btnRecord.Enabled = True
        btnRecord.Text = "Time Out"
        lnkRemove.Enabled = True
        txtRem.Clear()
        txtRem.Enabled = True

    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click

        Select Case btnRecord.Text
            Case "Time In"
                Dim result As Integer = MessageBox.Show("Confirm to save? ", "Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If (result = DialogResult.Yes) Then
                    CheckValidity()
                End If

            Case "Time Out"

                Dim defRem As String = "-" + txtRem.Text
                Dim mergedTimeOut As String
                    Dim mergeTime2 As New System.Text.StringBuilder()
                    mergedTimeOut = mergeTime2.Append("" + cmbHH2.SelectedItem.ToString).Append(":").Append("" + cmbMM2.SelectedItem.ToString).Append(" ").Append("" + cmbTT2.SelectedItem.ToString).ToString

                    Dim result As Integer = MessageBox.Show("Confirm to save? ", "Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If (result = DialogResult.Yes) Then
                        Try
                            objConn.Open()
                        'objComm = New OleDbCommand("UPDATE Records SET " & "Time_Out ='" & mergedTimeOut & "' WHERE User_Name ='" & cmbNames.Text.ToString.ToUpper & "' AND Date_Recorded =" & DateTimePicker1.Value.Date.ToString("MM/dd/yyyy"), objConn)
                        Dim sql2 As String = "UPDATE Records SET Time_Out = @TIMEOUT, Log_Remarks = @REMARKS WHERE User_Name = @USERNAME AND Date_Recorded = @DATERECORDED"
                        Using cmd2 As New OleDbCommand(sql2, objConn)
                            cmd2.Parameters.AddWithValue("@TIMEOUT", mergedTimeOut)
                            cmd2.Parameters.AddWithValue("@REMARKS", defRem.ToUpper)
                            cmd2.Parameters.AddWithValue("@USERNAME", lnkViewUserRecords.Text.ToString.ToUpper)
                            cmd2.Parameters.AddWithValue("@DATERECORDED", DateTimePicker1.Value.Date.ToString("MM/dd/yyyy"))
                            cmd2.ExecuteNonQuery()
                        End Using
                        cmbHH1.SelectedIndex() = -1
                        cmbMM1.SelectedIndex() = -1
                        cmbTT1.SelectedIndex() = -1
                        cmbHH2.SelectedIndex() = -1
                        cmbMM2.SelectedIndex() = -1
                        cmbTT2.SelectedIndex() = -1
                        txtRem.Clear()
                        'objComm.ExecuteNonQuery()
                    Catch ex As Exception
                            MsgBox(ex.Message)
                            MsgBox("Make sure the date specified is existent. If the problem still occurs, please try again.", MsgBoxStyle.Exclamation, "Failed")
                        End Try
                    End If

                    If objConn.State = ConnectionState.Open Then
                        objConn.Close()
                    End If

        End Select

    End Sub

    Private Sub lnkRemove_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRemove.LinkClicked


        Dim result As Integer = MessageBox.Show("Do you really want to permanently delete records of " & lnkViewUserRecords.Text.ToString.ToUpper & " ?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Try
                'Dim password As String = InputBox("Enter master password to continue: ", "User Account Control")
                'If CStr(password) = administrator Then
                objConn.Open()
                objComm = New OleDbCommand("DELETE * FROM Records WHERE User_Name =" & "'" & lnkViewUserRecords.Text.ToString.ToUpper & "'", objConn)
                objComm.ExecuteNonQuery()
                UpdateDataGrid(False)
                'Else
                'MsgBox("Incorrect password. Please try again or contact your supervisor.", MsgBoxStyle.Critical, "User Account Control")
                'End If

            Catch ex As Exception
                'MsgBox(ex.Message)
                If objConn.State = ConnectionState.Open Then
                    objConn.Close()
                End If
                Return
            Finally
                If objConn.State = ConnectionState.Open Then
                    objConn.Close()
                End If
            End Try
        End If

        Reset()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblDate.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now)
        lblTime.Text = TimeOfDay.ToString("h:mm tt")

        'Me.Timer1.Interval = 45000 'resets form after x seconds.
        'Me.rad1.Checked = False
        'Me.rad2.Checked = False
        'Me.DateTimePicker1.Enabled = False
        'Me.cmbHH1.Enabled = False
        'Me.cmbHH2.Enabled = False
        'Me.cmbMM1.Enabled = False
        'Me.cmbMM2.Enabled = False
        'Me.cmbTT1.Enabled = False
        'Me.cmbTT2.Enabled = False
        'Me.btnRecord.Enabled = False
        'Me.btnRecord.Text = "Record"
        'Me.lnkRemove.Enabled = False

    End Sub
    Private Sub lnkViewUserRecords_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkViewUserRecords.LinkClicked

        UpdateDataGrid(True)
        VIEW.ShowDialog()

    End Sub
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click

        ChPASS.txtOld.Clear()
        ChPASS.txtNew.Clear()
        ChPASS.txtCheck.Clear()
        ChPASS.ShowDialog()

    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        ACC.txtID.Clear()
        ACC.txtPassword.Clear()
        Me.Close()
        ACC.Show()

    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Abt.ShowDialog()

    End Sub
    Private Sub DTR_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        ACC.txtID.Clear()
        ACC.txtPassword.Clear()
        Me.Close()
        ACC.Show()

    End Sub
    Public Sub RandomGenerator()

        generatedLogID = 0 'resets every new registration
        Dim intNumber As Integer
        Dim arrNumber(0 To 3) As Integer
        Dim i, x, y As Integer

        For x = 0 To 3
Start:
            Randomize()
            intNumber = Int((9 * Rnd()) + 1) ' Random number 1 to 9
            For y = 0 To 3
                ' Check arrNumber (y)
                'If intnumber has already been selected,
                'Then go and select another one.
                If intNumber = arrNumber(y) Then
                    GoTo Start
                End If
            Next y

            'Place the next non-repeated number in the arrNumber(x).
            arrNumber(x) = intNumber

        Next x
        '----------------------------------------------------

        generatedLogID = String.Format("{0:yyyy}", DateTime.Now) & TimeOfDay.ToString("ss")

        For i = 0 To 1
            generatedLogID = generatedLogID & (arrNumber(i))
        Next

    End Sub

    Public Sub CheckValidity()

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT * FROM Records WHERE Date_Recorded ='" & DateTimePicker1.Value.Date.ToString("MM/dd/yyyy") & "'", objConn)
        objAdap = New OleDbDataAdapter(objComm)
        objConn.Open()


        Dim oledbreader As OleDbDataReader = objComm.ExecuteReader()
        If (oledbreader.Read() = True) Then
            CheckDate = oledbreader(2)
            MessageBox.Show("You have already registered that date. Please check your entry.")
        Else
            LogTimeIn()
        End If
        objConn.Close()

    End Sub
    Public Sub LogTimeIn()

        RandomGenerator()

        'Dim mergedFullName As String
        'Dim mergeNames As New System.Text.StringBuilder()
        'mergedFullName = mergeNames.Append("" + txtSurname.Text).Append(", ").Append("" + txtFirstname.Text).Append(" " + txtMiddlename.Text).ToString()

        Dim mergedTimeIn As String
        Dim mergeTime1 As New System.Text.StringBuilder()
        mergedTimeIn = mergeTime1.Append("" + cmbHH1.SelectedItem.ToString).Append(":").Append("" + cmbMM1.SelectedItem.ToString).Append(" ").Append("" + cmbTT1.SelectedItem.ToString).ToString

        Dim defDate As String = "--undefined--"
        Dim defIn As String = "--undefined--"
        Dim defOut As String = "--undefined--"
        Dim defRen As String = "--undefiend--"
        Dim defRem As String = "-" + txtRem.Text.ToUpper

        Dim retryCount As Integer = 0
        Dim wasSuccessful As Boolean = False

        Do
            Try
                objComm = New OleDbCommand("INSERT INTO Records VALUES ('" & CInt(generatedLogID) & "','" & lnkViewUserRecords.Text.ToString.ToUpper & "','" & DateTimePicker1.Value.Date.ToString("MM/dd/yyyy") & "','" & mergedTimeIn & "','" & defOut & "','" & defIn & "','" & defOut & "','" & defRen & "','" & defRem & "')", objConn)
                objAdap = New OleDbDataAdapter(objComm)
                objDt = New DataTable
                objAdap.Fill(objDt)
                wasSuccessful = True

                'cmbNames.SelectedItem() = -1
                cmbHH1.SelectedIndex() = -1
                cmbMM1.SelectedIndex() = -1
                cmbTT1.SelectedIndex() = -1
                cmbHH2.SelectedIndex() = -1
                cmbMM2.SelectedIndex() = -1
                cmbTT2.SelectedIndex() = -1
                Reset()
            Catch
                retryCount += 1
            End Try
        Loop Until wasSuccessful = True OrElse retryCount >= 3
        'check if the statements were unsuccessful'
        If Not wasSuccessful Then
            MsgBox("Fill-up each field with the proper format and save. If the problem still occurs, please try again.", MsgBoxStyle.Exclamation, "Failed")
            'cmbNames.SelectedItem() = -1
            cmbHH1.SelectedIndex() = -1
            cmbMM1.SelectedIndex() = -1
            cmbTT1.SelectedIndex() = -1
        End If

        If objConn.State = ConnectionState.Open Then
            objConn.Close()
        End If

    End Sub
    Public Sub Reset()

        cmbHH1.SelectedIndex() = -1
        cmbMM1.SelectedIndex() = -1
        cmbTT1.SelectedIndex() = -1
        cmbHH2.SelectedIndex() = -1
        cmbMM2.SelectedIndex() = -1
        cmbTT2.SelectedIndex() = -1
        txtRem.Clear()
        'cmbNames.Items.Clear()
        'cmbNames.SelectedIndex() = -1

        'objDt = New DataTable
        'objComm = New OleDbCommand("SELECT User_FullName FROM Users WHERE User_ID=" & cmbNames.Text.ToString.ToUpper & "'", objConn)
        'objAdap = New OleDbDataAdapter(objComm)

        'objConn.Open()

        'Try
        '    Using reader As OleDbDataReader = objComm.ExecuteReader()
        '        While (reader.Read())
        '            cmbNames.Items.Add(reader(0).ToString)
        '            list.Add(reader(0).ToString)
        '        End While
        '        objConn.Close()
        '    End Using
        '    objConn.Close()
        'Catch ex As Exception
        '    MsgBox("No records found.")
        'End Try

        'If objConn.State = ConnectionState.Open Then
        '    objConn.Close()
        'End If

    End Sub
    Sub UpdateDataGrid(ByVal DisplayDialog As Boolean)

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT Date_Recorded AS [Date], Time_In AS [Time In], Time_Out AS [Time Out], Log_Remarks AS [Remarks] FROM Records WHERE User_Name= '" & lnkViewUserRecords.Text.ToString.ToUpper & "' ORDER BY Date_Recorded", objConn)
        objAdap = New OleDbDataAdapter(objComm)
        SetDataGrid(DisplayDialog)

    End Sub

    Sub SetDataGrid(ByVal DisplayDialog As Boolean)

        Try
            objAdap.Fill(objDt)
            If objDt.Rows.Count > 0 Then
                VIEW.DataGridView1.DataSource = objDt
            ElseIf DisplayDialog Then
                MsgBox("No records found.", MsgBoxStyle.OkOnly, "Empty")
            Else
                VIEW.DataGridView1.DataSource = vbNull
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If objConn.State = ConnectionState.Open Then
                objConn.Close()
            End If
        End Try
    End Sub

End Class