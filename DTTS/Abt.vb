Public Class Abt
    Private Sub Abt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Abt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Me.Close()
        DTR.Show()

    End Sub

End Class