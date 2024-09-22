Imports System.Data.OleDb
Public Class REG

    Dim objConn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbTimeline.mdb")
    Dim objComm As OleDbCommand
    Dim objAdap As OleDbDataAdapter
    Dim objDt As DataTable

    Friend generatedUserID As Integer
    Private Sub REG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

        ACC.txtID.Clear()
        ACC.txtPassword.Clear()

        txtSurname.Clear()
        txtFirstname.Clear()
        txtMiddlename.Clear()
        'cmbHH1.SelectedIndex() = -1
        'cmbMM1.SelectedIndex() = -1
        'cmbTT1.SelectedIndex() = -1

        ACC.txtID.Clear()
        ACC.txtPassword.Clear()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblDate.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now)
        lblTime.Text = TimeOfDay.ToString("h:mm tt")

    End Sub
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim result As Integer = MessageBox.Show("Confirm to save? ", "Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then

            If (txtPassword.Text = txtPassword2.Text) Then

                RandomGenerator()

                Dim mergedFullName As String
                Dim mergeNames As New System.Text.StringBuilder()
                mergedFullName = mergeNames.Append("" + txtSurname.Text).Append(", ").Append("" + txtFirstname.Text).Append(" " + txtMiddlename.Text).ToString()

                'Dim mergedTimeIn As String
                'Dim mergeTime1 As New System.Text.StringBuilder()
                'mergedTimeIn = mergeTime1.Append("" + cmbHH1.SelectedItem.ToString).Append(":").Append("" + cmbMM1.SelectedItem.ToString).Append(" ").Append("" + cmbTT1.SelectedItem.ToString).ToString

                'Dim defDate As String = "--undefined--"
                'Dim defIn As String = "--undefined--"
                'Dim defOut As String = "--undefined--"
                'Dim defRen As String = "--undefined--"

                Dim retryCount As Integer = 0
                Dim wasSuccessful As Boolean = False

                Do
                    Try
                        objComm = New OleDbCommand("INSERT INTO Users VALUES ('" & CInt(generatedUserID) & "','" & mergedFullName.ToUpper & "','" & txtPassword.Text & "')", objConn)
                        objAdap = New OleDbDataAdapter(objComm)
                        objDt = New DataTable
                        objAdap.Fill(objDt)
                        wasSuccessful = True
                        MsgBox("Log into your account using the ID: " & generatedUserID, MsgBoxStyle.Information, "Registration Successful")
                        MsgBox("Log into your account using the ID: " & generatedUserID, MsgBoxStyle.Information, "Registration Successful")
                        'Reset()

                        txtSurname.Clear()
                        txtFirstname.Clear()
                        txtMiddlename.Clear()
                        txtPassword.Clear()
                        txtPassword2.Clear()

                        Me.Close()
                        ACC.Show()
                    Catch
                        retryCount += 1
                    End Try
                Loop Until wasSuccessful = True OrElse retryCount >= 3
                'check if the statements were unsuccessful'
                If Not wasSuccessful Then
                    MsgBox("Fill-up each field with the proper format and save. If the problem still occurs, please try again.", MsgBoxStyle.Exclamation, "Failed")
                    txtSurname.Clear()
                    txtFirstname.Clear()
                    txtMiddlename.Clear()
                    txtPassword.Clear()
                    txtPassword2.Clear()
                End If

            Else
                MsgBox("Password does not match. Try again", MsgBoxStyle.Exclamation, "Registration Failure")
                txtPassword.Clear()
                txtPassword2.Clear()
            End If

        End If

    End Sub

    Private Sub REG_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        ACC.txtID.Clear()
        ACC.txtPassword.Clear()
        Me.Close()
        ACC.Show()

    End Sub

    Public Sub RandomGenerator()

        generatedUserID = 0 'resets every new registration
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

        generatedUserID = String.Format("{0:yyyy}", DateTime.Now)

        For i = 0 To 3
            generatedUserID = generatedUserID & (arrNumber(i))
        Next

    End Sub

    Public Sub Reset()

        'DTR.cmbNames.Items.Clear()
        'DTR.cmbNames.SelectedIndex() = -1

        'objDt = New DataTable
        'objComm = New OleDbCommand("SELECT User_Name FROM Records", objConn)
        'objAdap = New OleDbDataAdapter(objComm)

        'objConn.Open()

        'Try
        '    Using reader As OleDbDataReader = objComm.ExecuteReader()
        '        While (reader.Read())
        '            DTR.cmbNames.Items.Add(reader(0).ToString)
        '            DTR.list.Add(reader(0).ToString)
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

End Class