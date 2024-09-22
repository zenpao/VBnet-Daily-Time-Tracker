Imports System.Data.OleDb
Public Class ChPASS

    Dim objConn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbTimeline.mdb")
    Dim objComm As OleDbCommand
    Dim objAdap As OleDbDataAdapter
    Dim objDt As DataTable

    Public oldPassword As String
    Private Sub ChPASS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        FetchOld()
        Me.Close()

    End Sub

    Private Sub ChPASS_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        ACC.txtID.Clear()
        ACC.txtPassword.Clear()
        Me.Close()
        DTR.Show()

    End Sub

    Public Sub FetchOld()

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT * FROM Users WHERE User_FullName ='" & ACC.NameHeader & "'", objConn)
        objAdap = New OleDbDataAdapter(objComm)
        objConn.Open()


        Dim oledbreader As OleDbDataReader = objComm.ExecuteReader()
        If (oledbreader.Read() = True) Then
            oldPassword = oledbreader(2)
        End If

        If (oldPassword.ToString = txtOld.Text) Then
            ConfirmPass()
        Else
            txtOld.Clear()
            txtNew.Clear()
            txtCheck.Clear()
            MsgBox("Password mismatch. Please try again.", MsgBoxStyle.Exclamation, "Failed")
        End If

        If objConn.State = ConnectionState.Open Then
            objConn.Close()
        End If

    End Sub

    Public Sub ConfirmPass()

        objConn.Close()

        If (txtNew.Text = txtCheck.Text) Then

            Dim result As Integer = MessageBox.Show("Confirm to save? ", "Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (result = DialogResult.Yes) Then
                Try
                    objConn.Open()
                    Dim sql3 As String = "UPDATE Users SET User_Password = @NEWPASS WHERE User_FullName = @USERNAME"
                    Using cmd2 As New OleDbCommand(sql3, objConn)
                        cmd2.Parameters.AddWithValue("@NEWPASS", txtNew.Text)
                        cmd2.Parameters.AddWithValue("@USERNAME", ACC.NameHeader)
                        cmd2.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtOld.Clear()
                    txtNew.Clear()
                    txtCheck.Clear()
                Catch ex As Exception
                    txtOld.Clear()
                    txtNew.Clear()
                    txtCheck.Clear()
                    MsgBox("ERROR: " & ex.Message)
                End Try
            Else
                txtOld.Clear()
                txtNew.Clear()
                txtCheck.Clear()
                MsgBox("Operation aborted.", MsgBoxStyle.Exclamation, "Cancelled")
            End If

        Else
            txtOld.Clear()
            txtNew.Clear()
            txtCheck.Clear()
            MsgBox("Password mismatch. Please try again.", MsgBoxStyle.Exclamation, "Failed")
        End If

        If objConn.State = ConnectionState.Open Then
            objConn.Close()
        End If

    End Sub

End Class