Public Class AddArea

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        Dim C As Integer = InsertarArea(Me.RadTextBox1.Text)
        Me.Close()
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Me.Close()
    End Sub

    Private Sub AddArea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RadTextBox1.Text = ""
    End Sub
End Class
