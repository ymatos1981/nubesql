Public Class Form1
    Public Dtx As DataTable

    Public XLS As New Microsoft.Office.Interop.Excel.Application
    Public Docx As New Microsoft.Office.Interop.Word.Application
    Public Ppt As New Microsoft.Office.Interop.PowerPoint.Application

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        cmdSubir.Enabled = PermisoEscribir
        cmdDescargar.Enabled = PermisoEscribir
        Me.cmdAddUser.Enabled = PermisoAdministrar
        Me.cmdDeclararPermisos.Enabled = PermisoAdministrar
        Me.cmdSubirTema.Enabled = PermisoEscribir

        If Conectado = True And Logeado = False Then
            cmdConectar.Enabled = True
        Else
            cmdConectar.Enabled = False
        End If

        RadPanel1.Visible = Logeado
        RadPanel2.Visible = Logeado

        If Conectado = True Then
            With TreeView1
                .Nodes.Clear()
                OpenTableView(11, "SELECT * FROM DEPARTAMENTOS ORDER BY AREA ASC;")
                Do Until rstTables(11).EOF
                    Dim NDX As New TreeNode
                    NDX.Text = rstTables(11).Fields("AREA").Value.ToString
                    NDX.StateImageIndex = 3
                    NDX.SelectedImageIndex = 3
                    OpenTableView(12, "SELECT * FROM TEMARIO WHERE CODAREA=" & rstTables(11).Fields("CODAREA").Value.ToString & " ORDER BY IDTEMA ASC;")
                    Do Until rstTables(12).EOF
                        NDX.Nodes.Add("t" & rstTables(12).Fields("IDTEMA").Value.ToString, rstTables(12).Fields("TEMA").Value.ToString, 4)
                        rstTables(12).MoveNext()
                    Loop
                    rstTables(12).Close()
                    rstTables(11).MoveNext()
                    TreeView1.Nodes.Add(NDX)
                Loop
                rstTables(11).Close()

            End With
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub cmdConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConectar.Click
        Logear.ShowDialog()
    End Sub

    Private Sub RadPanel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles RadPanel2.Paint

    End Sub

    Private Sub RadListView1_CellCreating(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewCellElementCreatingEventArgs) Handles RadListView1.CellCreating

    End Sub

    Private Sub RadListView1_ItemMouseClick(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.ListViewItemEventArgs) Handles RadListView1.ItemMouseClick
        Select Case LCase(Dtx.Rows(RadListView1.SelectedIndex)("tipo"))
            Case Is = "doc"
                PictureBox1.BackgroundImage = ImageList3.Images(0)
            Case Is = "xls"
                PictureBox1.BackgroundImage = ImageList3.Images(1)
            Case Else
                PictureBox1.BackgroundImage = ImageList3.Images(2)
        End Select
        Label2.Text = Dtx.Rows(RadListView1.SelectedIndex)("conexto")
    End Sub

    Private Sub RadListView1_ItemMouseDoubleClick(sender As Object, e As Telerik.WinControls.UI.ListViewItemEventArgs) Handles RadListView1.ItemMouseDoubleClick

        Dim Fichero As String = Application.StartupPath & "\Attach\File" & Dtx.Rows(RadListView1.SelectedIndex)("idDocumentacion") & "." & Dtx.Rows(RadListView1.SelectedIndex)("tipo")
        If Dir(Fichero) <> "" Then Kill(Fichero)

        BytesAArchivo(Dtx.Rows(RadListView1.SelectedIndex)("Fichero"), Fichero, Dtx.Rows(RadListView1.SelectedIndex)("IDDOCUMENTACION"))
        Try
            Select Case LCase(Dtx.Rows(RadListView1.SelectedIndex)("tipo"))
                Case Is = "doc"
                    PictureBox1.BackgroundImage = ImageList3.Images(0)
                    'Shell("winword.exe " & Fichero)
                    Docx.Documents.Open(Fichero)
                    Docx.Visible = True
                Case Is = "xls"
                    PictureBox1.BackgroundImage = ImageList3.Images(1)
                    'Shell("excel.exe " & Fichero)
                    XLS.Workbooks.Open(Fichero)
                    XLS.Visible = True
                Case Is = "ppt"
                    PictureBox1.BackgroundImage = ImageList3.Images(2)
                    'Shell("powerpnt.exe " & Fichero)
                    Ppt.Presentations.Open(Fichero)
                    Ppt.Visible = True
                Case Is = "txt"
                    PictureBox1.BackgroundImage = ImageList3.Images(2)
                    Shell("notepad.exe " & Fichero)
                Case Is = "jpg", "png"
                    PictureBox1.BackgroundImage = ImageList3.Images(2)
                    'Shell("mspaint.exe " & Fichero)
                    Dim pc As New FrmPicture
                    With pc
                        .PictureBox1.BackgroundImage = Image.FromFile(Fichero)
                        .Text = Fichero
                        .ShowDialog()
                    End With
                Case Is = "pdf"
                    PictureBox1.BackgroundImage = ImageList3.Images(3)
                    Dim y As New FrmPDF
                    With y
                        .Text = Fichero
                        .PdfViewer1.LoadDocument(Fichero)
                        .ShowDialog()
                    End With
                Case Else
                    PictureBox1.BackgroundImage = ImageList3.Images(2)
                    Shell("explorer.exe  " & Application.StartupPath & "\Attach")
                    MsgBox("Fichero Guardado en " & Fichero)
            End Select



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RadListView1_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadListView1.SelectedItemChanged

    End Sub

    Private Sub cmdSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubir.Click
        AddArea.ShowDialog()
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If Mid(TreeView1.SelectedNode.Name, 1, 1) = "t" Then
            Dim Nd As Integer = Val(Mid(TreeView1.SelectedNode.Name, 2, 10))
            Dtx = New DataTable
            Dtx = CargaDocumentos(Nd)
            RadListView1.DataSource = Dtx
            RadListView1.Columns(0).Width = 50
            RadListView1.Columns(1).Width = 300
            RadListView1.Columns(2).Width = 80
            RadListView1.Columns(3).Width = 80
            RadListView1.Columns(4).Width = 80

            RadListView1.Columns(0).HeaderText = "Codigo"
            RadListView1.Columns(1).HeaderText = "Titulo"
            RadListView1.Columns(2).HeaderText = "Subido Por"
            RadListView1.Columns(3).HeaderText = "Fecha"
            RadListView1.Columns(4).HeaderText = "File"

            RadListView1.Columns(5).Visible = False
            RadListView1.Columns(6).Visible = False

            For x As Integer = 0 To RadListView1.Items.Count - 1
                Select Case LCase(Dtx.Rows(x)("tipo"))
                    Case Is = "doc"
                        RadListView1.Items(x).ImageIndex = 0
                    Case Is = "xls"
                        RadListView1.Items(x).ImageIndex = 1
                    Case Else
                        RadListView1.Items(x).ImageIndex = 2
                End Select
            Next
        Else
            RadListView1.DataSource = Nothing
        End If
    End Sub

    Private Sub cmdDescargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDescargar.Click
        AddTema.ShowDialog()
    End Sub

    Private Sub cmdSubirTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubirTema.Click
        NuevoDocumento.ShowDialog()
    End Sub

    Private Sub TreeView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.Click

    End Sub
End Class
