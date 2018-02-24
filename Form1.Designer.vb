<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits Telerik.WinControls.UI.RadForm


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ListViewDetailColumn1 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Numero")
        Dim ListViewDetailColumn2 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Titulo")
        Dim ListViewDetailColumn3 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Subido Por")
        Dim ListViewDetailColumn4 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Fecha")
        Dim ListViewDetailColumn5 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 4", "Tipo Documento")
        Me.Office2013LightTheme1 = New Telerik.WinControls.Themes.Office2013LightTheme()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadListView1 = New Telerik.WinControls.UI.RadListView()
        Me.ImageList3 = New System.Windows.Forms.ImageList()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList2 = New System.Windows.Forms.ImageList()
        Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.cmdConectar = New Telerik.WinControls.UI.CommandBarButton()
        Me.cmdSubir = New Telerik.WinControls.UI.CommandBarButton()
        Me.cmdDescargar = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cmdSubirTema = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.cmdAddUser = New Telerik.WinControls.UI.CommandBarButton()
        Me.cmdDeclararPermisos = New Telerik.WinControls.UI.CommandBarButton()
        Me.RadCommandBar1 = New Telerik.WinControls.UI.RadCommandBar()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.RadListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel4.SuspendLayout()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.RadPanel1.Controls.Add(Me.TreeView1)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(199, 444)
        Me.RadPanel1.TabIndex = 0
        Me.RadPanel1.ThemeName = "VisualStudio2012Dark"
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.LightGray
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(199, 444)
        Me.TreeView1.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "root")
        Me.ImageList1.Images.SetKeyName(1, "tema")
        Me.ImageList1.Images.SetKeyName(2, "doc")
        Me.ImageList1.Images.SetKeyName(3, "root1")
        Me.ImageList1.Images.SetKeyName(4, "tema1")
        Me.ImageList1.Images.SetKeyName(5, "doc1")
        '
        'RadPanel2
        '
        Me.RadPanel2.Controls.Add(Me.RadListView1)
        Me.RadPanel2.Controls.Add(Me.RadPanel4)
        Me.RadPanel2.Controls.Add(Me.RadPanel3)
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel2.Location = New System.Drawing.Point(199, 34)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(880, 410)
        Me.RadPanel2.TabIndex = 2
        Me.RadPanel2.ThemeName = "VisualStudio2012Dark"
        '
        'RadListView1
        '
        Me.RadListView1.BackgroundImage = Global.GestionDocumental.My.Resources.Resources._146129_document_512x512
        Me.RadListView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        ListViewDetailColumn1.HeaderText = "Numero"
        ListViewDetailColumn1.Width = 50.0!
        ListViewDetailColumn2.HeaderText = "Titulo"
        ListViewDetailColumn2.Width = 500.0!
        ListViewDetailColumn3.HeaderText = "Subido Por"
        ListViewDetailColumn3.Width = 150.0!
        ListViewDetailColumn4.HeaderText = "Fecha"
        ListViewDetailColumn4.Width = 100.0!
        ListViewDetailColumn5.HeaderText = "Tipo Documento"
        ListViewDetailColumn5.Width = 100.0!
        Me.RadListView1.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {ListViewDetailColumn1, ListViewDetailColumn2, ListViewDetailColumn3, ListViewDetailColumn4, ListViewDetailColumn5})
        Me.RadListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadListView1.ImageList = Me.ImageList3
        Me.RadListView1.ItemSpacing = -1
        Me.RadListView1.Location = New System.Drawing.Point(0, 36)
        Me.RadListView1.Name = "RadListView1"
        Me.RadListView1.Size = New System.Drawing.Size(880, 313)
        Me.RadListView1.TabIndex = 2
        Me.RadListView1.Text = "RadListView1"
        Me.RadListView1.ThemeName = "VisualStudio2012Light"
        Me.RadListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "doc")
        Me.ImageList3.Images.SetKeyName(1, "xls")
        Me.ImageList3.Images.SetKeyName(2, "otro")
        Me.ImageList3.Images.SetKeyName(3, "pdf")
        '
        'RadPanel4
        '
        Me.RadPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RadPanel4.Controls.Add(Me.SearchControl1)
        Me.RadPanel4.Controls.Add(Me.Label1)
        Me.RadPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel4.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(880, 36)
        Me.RadPanel4.TabIndex = 1
        Me.RadPanel4.ThemeName = "VisualStudio2012Light"
        '
        'SearchControl1
        '
        Me.SearchControl1.Location = New System.Drawing.Point(90, 10)
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Size = New System.Drawing.Size(389, 20)
        Me.SearchControl1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar tema"
        '
        'RadPanel3
        '
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.RadPanel3.Controls.Add(Me.RadPanel5)
        Me.RadPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadPanel3.Location = New System.Drawing.Point(0, 349)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(880, 61)
        Me.RadPanel3.TabIndex = 0
        '
        'RadPanel5
        '
        Me.RadPanel5.Controls.Add(Me.Label2)
        Me.RadPanel5.Controls.Add(Me.PictureBox1)
        Me.RadPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel5.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel5.Name = "RadPanel5"
        '
        '
        '
        Me.RadPanel5.RootElement.AccessibleDescription = "Vista Previa"
        Me.RadPanel5.RootElement.AccessibleName = "Vista Previa"
        Me.RadPanel5.RootElement.Text = "Vista Previa"
        Me.RadPanel5.Size = New System.Drawing.Size(880, 39)
        Me.RadPanel5.TabIndex = 0
        Me.RadPanel5.Text = "Vista Previa"
        Me.RadPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadPanel5.ThemeName = "VisualStudio2012Light"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(48, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(577, 25)
        Me.Label2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "xls")
        Me.ImageList2.Images.SetKeyName(1, "otro")
        Me.ImageList2.Images.SetKeyName(2, "doc")
        '
        'CommandBarRowElement1
        '
        Me.CommandBarRowElement1.AutoSize = False
        Me.CommandBarRowElement1.Bounds = New System.Drawing.Rectangle(0, 0, 460, 34)
        Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1})
        Me.CommandBarRowElement1.Text = ""
        '
        'CommandBarStripElement1
        '
        Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
        Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.cmdConectar, Me.cmdSubir, Me.cmdDescargar, Me.CommandBarSeparator1, Me.cmdSubirTema, Me.CommandBarSeparator2, Me.cmdAddUser, Me.cmdDeclararPermisos})
        Me.CommandBarStripElement1.Name = "CommandBarStripElement1"
        '
        'cmdConectar
        '
        Me.cmdConectar.AccessibleDescription = "CommandBarButton1"
        Me.cmdConectar.AccessibleName = "CommandBarButton1"
        Me.cmdConectar.AutoSize = False
        Me.cmdConectar.Bounds = New System.Drawing.Rectangle(0, 0, 32, 32)
        Me.cmdConectar.DisplayName = "CommandBarButton1"
        Me.cmdConectar.Image = Global.GestionDocumental.My.Resources.Resources.login
        Me.cmdConectar.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdConectar.Name = "cmdConectar"
        Me.cmdConectar.Text = "CommandBarButton1"
        Me.cmdConectar.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'cmdSubir
        '
        Me.cmdSubir.AccessibleDescription = "CommandBarButton2"
        Me.cmdSubir.AccessibleName = "CommandBarButton2"
        Me.cmdSubir.AutoSize = False
        Me.cmdSubir.Bounds = New System.Drawing.Rectangle(0, 0, 32, 32)
        Me.cmdSubir.ClipText = False
        Me.cmdSubir.DisplayName = "Crear Area"
        Me.cmdSubir.FlipText = False
        Me.cmdSubir.Image = Global.GestionDocumental.My.Resources.Resources.folder_add_icon
        Me.cmdSubir.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSubir.Name = "cmdSubir"
        Me.cmdSubir.Text = "Crear Area"
        Me.cmdSubir.TextWrap = True
        Me.cmdSubir.ToolTipText = "Crear Area"
        Me.cmdSubir.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'cmdDescargar
        '
        Me.cmdDescargar.AccessibleDescription = "CommandBarButton1"
        Me.cmdDescargar.AccessibleName = "CommandBarButton1"
        Me.cmdDescargar.AutoSize = False
        Me.cmdDescargar.Bounds = New System.Drawing.Rectangle(0, 0, 32, 32)
        Me.cmdDescargar.DisplayName = "CommandBarButton1"
        Me.cmdDescargar.Image = Global.GestionDocumental.My.Resources.Resources.folder_add_icon1
        Me.cmdDescargar.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdDescargar.Name = "cmdDescargar"
        Me.cmdDescargar.Text = "Crear Tema"
        Me.cmdDescargar.ToolTipText = "Crear Tema"
        Me.cmdDescargar.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.AccessibleDescription = "CommandBarSeparator1"
        Me.CommandBarSeparator1.AccessibleName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.DisplayName = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'cmdSubirTema
        '
        Me.cmdSubirTema.AccessibleDescription = "Subir Tema"
        Me.cmdSubirTema.AccessibleName = "Subir Tema"
        Me.cmdSubirTema.AutoSize = False
        Me.cmdSubirTema.Bounds = New System.Drawing.Rectangle(0, 0, 32, 32)
        Me.cmdSubirTema.DisplayName = "Subir Tema"
        Me.cmdSubirTema.Image = CType(resources.GetObject("cmdSubirTema.Image"), System.Drawing.Image)
        Me.cmdSubirTema.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSubirTema.Name = "cmdSubirTema"
        Me.cmdSubirTema.Text = "Subir Tema"
        Me.cmdSubirTema.ToolTipText = "Subir Tema"
        Me.cmdSubirTema.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.AccessibleDescription = "CommandBarSeparator2"
        Me.CommandBarSeparator2.AccessibleName = "CommandBarSeparator2"
        Me.CommandBarSeparator2.DisplayName = "CommandBarSeparator2"
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'cmdAddUser
        '
        Me.cmdAddUser.AccessibleDescription = "Agregar Usuario"
        Me.cmdAddUser.AccessibleName = "Agregar Usuario"
        Me.cmdAddUser.AutoSize = False
        Me.cmdAddUser.Bounds = New System.Drawing.Rectangle(0, 0, 32, 32)
        Me.cmdAddUser.DisplayName = "CommandBarButton1"
        Me.cmdAddUser.Image = Global.GestionDocumental.My.Resources.Resources.w256h2561350597246folderuser
        Me.cmdAddUser.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAddUser.Name = "cmdAddUser"
        Me.cmdAddUser.Text = "Agregar Usuario"
        Me.cmdAddUser.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'cmdDeclararPermisos
        '
        Me.cmdDeclararPermisos.AccessibleDescription = "CommandBarButton1"
        Me.cmdDeclararPermisos.AccessibleName = "CommandBarButton1"
        Me.cmdDeclararPermisos.AutoSize = False
        Me.cmdDeclararPermisos.Bounds = New System.Drawing.Rectangle(0, 0, 32, 32)
        Me.cmdDeclararPermisos.DisplayName = "CommandBarButton1"
        Me.cmdDeclararPermisos.Image = CType(resources.GetObject("cmdDeclararPermisos.Image"), System.Drawing.Image)
        Me.cmdDeclararPermisos.ImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdDeclararPermisos.Name = "cmdDeclararPermisos"
        Me.cmdDeclararPermisos.Text = "CommandBarButton1"
        Me.cmdDeclararPermisos.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadCommandBar1
        '
        Me.RadCommandBar1.BackColor = System.Drawing.Color.Maroon
        Me.RadCommandBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadCommandBar1.Location = New System.Drawing.Point(199, 0)
        Me.RadCommandBar1.Name = "RadCommandBar1"
        Me.RadCommandBar1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
        Me.RadCommandBar1.Size = New System.Drawing.Size(880, 34)
        Me.RadCommandBar1.TabIndex = 1
        Me.RadCommandBar1.Text = "RadCommandBar1"
        Me.RadCommandBar1.ThemeName = "VisualStudio2012Light"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GestionDocumental.My.Resources.Resources._146129_document_512x512
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1079, 444)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadCommandBar1)
        Me.Controls.Add(Me.RadPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Sistema de Gestion Documental"
        Me.ThemeName = "VisualStudio2012Light"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.RadListView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel4.ResumeLayout(False)
        Me.RadPanel4.PerformLayout()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2013LightTheme1 As Telerik.WinControls.Themes.Office2013LightTheme
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadListView1 As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CommandBarRowElement1 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents cmdConectar As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cmdSubir As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cmdDescargar As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cmdSubirTema As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents cmdAddUser As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents cmdDeclararPermisos As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadCommandBar1 As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents SearchControl1 As DevExpress.XtraEditors.SearchControl

End Class
