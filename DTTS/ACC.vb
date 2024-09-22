Imports System
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports System.Data.OleDb

Public Class ACC

    Dim objConn As OleDbConnection = New OleDbConnection(" Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbTimeline.mdb")
    Dim objComm As OleDbCommand
    Dim objAdap As OleDbDataAdapter
    Dim objDt As DataTable

    Public empID As Integer
    Public NameHeader As String
    Public regKey As Microsoft.Win32.RegistryKey
    Public InstallPath As String = My.Application.Info.DirectoryPath & "\DTTS.exe"

    Private Sub ACC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

        MessageBox.Show("Hi! Make sure to Clock In & Out.", "DTTS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        txtID.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblDate.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now)
        lblTime.Text = TimeOfDay.ToString("h:mm tt")

    End Sub

    Private Sub btnAccess_Click(sender As Object, e As EventArgs) Handles btnAccess.Click

        objDt = New DataTable
        objComm = New OleDbCommand("SELECT * FROM Users WHERE User_ID=" & CInt(txtID.Text) & "AND User_Password ='" & txtPassword.Text & "'", objConn)
        objAdap = New OleDbDataAdapter(objComm)
        objConn.Open()

        Dim oledbreader As OleDbDataReader = objComm.ExecuteReader()
        If (oledbreader.Read() = True) Then
            empID = oledbreader(0)
            NameHeader = oledbreader(1)
            DTR.lnkViewUserRecords.Text = NameHeader
            MessageBox.Show("Welcome " + NameHeader + " !", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Hide()
            DTR.ShowDialog()
        Else
            txtID.Clear()
            txtPassword.Clear()
            MessageBox.Show("Invalid username or password! Please try again.")
        End If
        objConn.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Me.Hide()
        REG.ShowDialog()

    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click

        Try
            'Write to register
            regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            regKey.SetValue("DTTS", InstallPath)
            regKey.Close()
        Catch ex As Exception
            MessageBox.Show("Make sure that you have DTTS -Run As Administrator." & Environment.NewLine & "Error: " & ex.Message, "DTTS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        Try
            regKey.DeleteValue("DTTS", False)
        Catch ex As Exception
            MessageBox.Show("Make sure triggered Run at Startup." & Environment.NewLine & "Error: " & ex.Message, "DTTS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try

    End Sub

End Class