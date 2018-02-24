Public Class AddTema

    Private Sub AddTema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdAreas.Items.Clear()
        OpenTableView(11, "SELECT * FROM DEPARTAMENTOS ORDER BY CODAREA ASC;")
        Do Until rstTables(11).EOF
            cmdAreas.Items.Add(rstTables(11).Fields("AREA").Value.ToString)
            rstTables(11).MoveNext()
        Loop
        rstTables(11).Close()
        Me.RadTextBox1.Text = ""
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Me.Close()

    End Sub

    Private Sub cmdAreas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAreas.Click

    End Sub

    Private Sub cmdAreas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cmdAreas.SelectedIndexChanged

    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        If cmdAreas.Text.ToString = "" Or Me.RadTextBox1.Text.ToString = "" Then
            MsgBox("SELECCIONE EL AREA / TEMA")
        Else
            Dim f As New DataTable
            f = CargaArea(cmdAreas.Text)
            Dim c As Integer = InsertarTema(f.Rows(0)("codarea"), Me.RadTextBox1.Text)
            Me.Close()
        End If
    End Sub
End Class
