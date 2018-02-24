Imports System.IO
Public Class NuevoDocumento
    Public fs As System.IO.FileStream
    Public mcorr_documento As Int32
    Public bw As System.IO.BinaryWriter
    Public dtw As DataTable

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        Dim fdlg As New OpenFileDialog
        fdlg.ShowDialog()
        Me.RadTextBox1.Text = fdlg.FileName
        Dim txt As String = Mid(RadTextBox1.Text, (Len(RadTextBox1.Text) - 2), 3)
        Select Case LCase(txt)
            Case Is = "lsx"
                cmdTipo.Text = "xls"
            Case Is = "ptx"
                cmdTipo.Text = "ppt"
            Case Is = "ocx"
                cmdTipo.Text = "doc"
            Case Else
                cmdTipo.Text = Mid(RadTextBox1.Text, (Len(RadTextBox1.Text) - 2), 3)
        End Select

    End Sub

    Private Sub cmdAreas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles cmdAreas.SelectedIndexChanged
        RadListView1.Items.Clear()
        If cmdAreas.Text.ToString = "" Then
        Else
            Dim c As New DataTable
            dtw = Nothing
            dtw = New DataTable
            c = CargaArea(cmdAreas.Text)
            dtw = CargaTemas(c.Rows(0)("CODAREA"))
            RadListView1.DataSource = dtw

            RadListView1.Columns(0).Width = 50
            RadListView1.Columns(0).HeaderText = "Codigo"

            RadListView1.Columns(1).Width = 300
            RadListView1.Columns(1).HeaderText = "Titulo"

        End If
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Me.Close()
    End Sub

    Private Sub NuevoDocumento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cmdAreas.Items.Clear()
        OpenTableView(11, "SELECT * FROM DEPARTAMENTOS ORDER BY CODAREA ASC;")
        Do Until rstTables(11).EOF
            cmdAreas.Items.Add(rstTables(11).Fields("AREA").Value.ToString)
            rstTables(11).MoveNext()
        Loop
        rstTables(11).Close()
    End Sub

    Private Sub RadButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton3.Click
        Dim Myfile As System.IO.FileStream

        If Me.RadTextBox1.Text.ToString <> "" And cmdAreas.Text.ToString <> "" And dtw.Rows(RadListView1.SelectedIndex)("idTema") <> 0 And RadTextBox2.Text.ToString <> "" And RadTextBox3.Text.ToString <> "" And cmdTipo.Text.ToString <> "" Then


            'Myfile = System.IO.File.OpenRead(Me.RadTextBox1.Text)
            'Dim Arr(Myfile.Length) As Byte 'Declaramos el array para manejar los bytes almacenar

            ' Try
            Dim tipo As String = Mid(RadTextBox1.Text, (Len(RadTextBox1.Text) - 3), 3)
            ' Myfile.Read(Arr, 0, Myfile.Length)
            Dim c = SubirDoc(CargaArea(cmdAreas.Text).Rows(0)("CodArea"), dtw.Rows(RadListView1.SelectedIndex)("idTema"), RadTextBox2.Text, RadTextBox3.Text, cmdTipo.Text, nUsuario, Now.Date, Me.RadTextBox1.Text)
            Me.Close()

            'Catch ex As Exception

            'MsgBox("Error al almacenar el dato:" & ex.ToString)

            'End Try
        End If

    End Sub

    Private Sub RadListView1_ItemMouseClick(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewItemEventArgs) Handles RadListView1.ItemMouseClick

    End Sub

    Private Sub RadListView1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadListView1.SelectedItemChanged

    End Sub
End Class
