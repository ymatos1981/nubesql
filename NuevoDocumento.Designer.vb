<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoDocumento
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim ListViewDetailColumn1 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Codigo")
        Dim ListViewDetailColumn2 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Nombre del Tema")
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAreas = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.cmdTipo = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadTextBox3 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadListView1 = New Telerik.WinControls.UI.RadListView()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.cmdAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadListView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(116, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione el Area"
        '
        'cmdAreas
        '
        Me.cmdAreas.Location = New System.Drawing.Point(119, 24)
        Me.cmdAreas.Name = "cmdAreas"
        Me.cmdAreas.Size = New System.Drawing.Size(253, 20)
        Me.cmdAreas.TabIndex = 2
        Me.cmdAreas.Text = "RadDropDownList1"
        Me.cmdAreas.ThemeName = "VisualStudio2012Light"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seleccione el Tema"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(12, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Subir Fichero"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Enabled = False
        Me.RadTextBox1.Location = New System.Drawing.Point(15, 191)
        Me.RadTextBox1.MaxLength = 0
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(242, 20)
        Me.RadTextBox1.TabIndex = 7
        Me.RadTextBox1.ThemeName = "VisualStudio2012Light"
        '
        'RadTextBox2
        '
        Me.RadTextBox2.Location = New System.Drawing.Point(15, 234)
        Me.RadTextBox2.MaxLength = 150
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.Size = New System.Drawing.Size(369, 20)
        Me.RadTextBox2.TabIndex = 9
        Me.RadTextBox2.ThemeName = "VisualStudio2012Light"
        '
        'cmdTipo
        '
        RadListDataItem1.Text = "doc"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "pdf"
        RadListDataItem2.TextWrap = True
        RadListDataItem3.Text = "jpg"
        RadListDataItem3.TextWrap = True
        RadListDataItem4.Text = "png"
        RadListDataItem4.TextWrap = True
        RadListDataItem5.Text = "ppt"
        RadListDataItem5.TextWrap = True
        RadListDataItem6.Text = "xls"
        RadListDataItem6.TextWrap = True
        Me.cmdTipo.Items.Add(RadListDataItem1)
        Me.cmdTipo.Items.Add(RadListDataItem2)
        Me.cmdTipo.Items.Add(RadListDataItem3)
        Me.cmdTipo.Items.Add(RadListDataItem4)
        Me.cmdTipo.Items.Add(RadListDataItem5)
        Me.cmdTipo.Items.Add(RadListDataItem6)
        Me.cmdTipo.Location = New System.Drawing.Point(263, 191)
        Me.cmdTipo.Name = "cmdTipo"
        Me.cmdTipo.Size = New System.Drawing.Size(65, 20)
        Me.cmdTipo.TabIndex = 10
        Me.cmdTipo.ThemeName = "VisualStudio2012Light"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(12, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Titulo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(12, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Explicacion"
        '
        'RadTextBox3
        '
        Me.RadTextBox3.Location = New System.Drawing.Point(15, 278)
        Me.RadTextBox3.MaxLength = 150
        Me.RadTextBox3.Name = "RadTextBox3"
        Me.RadTextBox3.Size = New System.Drawing.Size(369, 20)
        Me.RadTextBox3.TabIndex = 12
        Me.RadTextBox3.ThemeName = "VisualStudio2012Light"
        '
        'RadListView1
        '
        ListViewDetailColumn1.HeaderText = "Codigo"
        ListViewDetailColumn1.Width = 50.0!
        ListViewDetailColumn2.HeaderText = "Nombre del Tema"
        ListViewDetailColumn2.Width = 300.0!
        Me.RadListView1.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {ListViewDetailColumn1, ListViewDetailColumn2})
        Me.RadListView1.ItemSpacing = -1
        Me.RadListView1.Location = New System.Drawing.Point(15, 70)
        Me.RadListView1.Name = "RadListView1"
        Me.RadListView1.Size = New System.Drawing.Size(368, 105)
        Me.RadListView1.TabIndex = 16
        Me.RadListView1.Text = "RadListView1"
        Me.RadListView1.ThemeName = "VisualStudio2012Light"
        Me.RadListView1.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadButton2
        '
        Me.RadButton2.Image = Global.GestionDocumental.My.Resources.Resources.Cancel_16x16
        Me.RadButton2.Location = New System.Drawing.Point(251, 328)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(82, 22)
        Me.RadButton2.TabIndex = 15
        Me.RadButton2.Text = "Cancelar"
        Me.RadButton2.ThemeName = "VisualStudio2012Light"
        '
        'RadButton3
        '
        Me.RadButton3.Image = Global.GestionDocumental.My.Resources.Resources.Apply_16x16
        Me.RadButton3.Location = New System.Drawing.Point(78, 328)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(82, 23)
        Me.RadButton3.TabIndex = 14
        Me.RadButton3.Text = "Insertar"
        Me.RadButton3.ThemeName = "VisualStudio2012Light"
        '
        'RadButton1
        '
        Me.RadButton1.Image = Global.GestionDocumental.My.Resources.Resources.FindCustomers_16x16
        Me.RadButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton1.Location = New System.Drawing.Point(334, 191)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(50, 23)
        Me.RadButton1.TabIndex = 8
        Me.RadButton1.ThemeName = "VisualStudio2012Light"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GestionDocumental.My.Resources.Resources.File_Write_Document
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 41)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'NuevoDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 352)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadListView1)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadTextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdTipo)
        Me.Controls.Add(Me.RadTextBox2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdAreas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "NuevoDocumento"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.cmdAreas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadListView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAreas As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cmdTipo As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RadTextBox3 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadListView1 As Telerik.WinControls.UI.RadListView
End Class

