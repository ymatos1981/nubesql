<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPDF
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
        Me.PdfViewer1 = New DevExpress.XtraPdfViewer.PdfViewer()
        Me.PdfBarController1 = New DevExpress.XtraPdfViewer.Bars.PdfBarController()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PdfCommandBar1 = New DevExpress.XtraPdfViewer.Bars.PdfCommandBar()
        Me.PdfFileOpenBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem()
        Me.PdfFileSaveAsBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem()
        Me.PdfFilePrintBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem()
        Me.PdfFindTextBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem()
        Me.PdfPreviousPageBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem()
        Me.PdfNextPageBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem()
        Me.PdfSetPageNumberBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem()
        Me.RepositoryItemPageNumberEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit()
        Me.PdfZoomOutBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem()
        Me.PdfZoomInBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem()
        Me.PdfExactZoomListBarSubItem2 = New DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem()
        Me.PdfZoom10CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem()
        Me.PdfZoom25CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem()
        Me.PdfZoom50CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem()
        Me.PdfZoom75CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem()
        Me.PdfZoom100CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem()
        Me.PdfZoom125CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem()
        Me.PdfZoom150CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem()
        Me.PdfZoom200CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem()
        Me.PdfZoom400CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem()
        Me.PdfZoom500CheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem()
        Me.PdfSetActualSizeZoomModeCheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem()
        Me.PdfSetPageLevelZoomModeCheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem()
        Me.PdfSetFitWidthZoomModeCheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem()
        Me.PdfSetFitVisibleZoomModeCheckItem2 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem()
        Me.PdfExportFormDataBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem()
        Me.PdfImportFormDataBarItem2 = New DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem()
        CType(Me.PdfBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPageNumberEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PdfViewer1
        '
        Me.PdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfViewer1.Location = New System.Drawing.Point(0, 31)
        Me.PdfViewer1.MenuManager = Me.BarManager1
        Me.PdfViewer1.Name = "PdfViewer1"
        Me.PdfViewer1.Size = New System.Drawing.Size(716, 261)
        Me.PdfViewer1.TabIndex = 0
        '
        'PdfBarController1
        '
        Me.PdfBarController1.BarItems.Add(Me.PdfFileOpenBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfFileSaveAsBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfFilePrintBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfFindTextBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfPreviousPageBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfNextPageBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetPageNumberBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoomOutBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoomInBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfExactZoomListBarSubItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom10CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom25CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom50CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom75CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom100CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom125CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom150CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom200CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom400CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfZoom500CheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetActualSizeZoomModeCheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetPageLevelZoomModeCheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetFitWidthZoomModeCheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfSetFitVisibleZoomModeCheckItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfExportFormDataBarItem2)
        Me.PdfBarController1.BarItems.Add(Me.PdfImportFormDataBarItem2)
        Me.PdfBarController1.Control = Me.PdfViewer1
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.PdfCommandBar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.PdfFileOpenBarItem2, Me.PdfFileSaveAsBarItem2, Me.PdfFilePrintBarItem2, Me.PdfFindTextBarItem2, Me.PdfPreviousPageBarItem2, Me.PdfNextPageBarItem2, Me.PdfSetPageNumberBarItem2, Me.PdfZoomOutBarItem2, Me.PdfZoomInBarItem2, Me.PdfExactZoomListBarSubItem2, Me.PdfZoom10CheckItem2, Me.PdfZoom25CheckItem2, Me.PdfZoom50CheckItem2, Me.PdfZoom75CheckItem2, Me.PdfZoom100CheckItem2, Me.PdfZoom125CheckItem2, Me.PdfZoom150CheckItem2, Me.PdfZoom200CheckItem2, Me.PdfZoom400CheckItem2, Me.PdfZoom500CheckItem2, Me.PdfSetActualSizeZoomModeCheckItem2, Me.PdfSetPageLevelZoomModeCheckItem2, Me.PdfSetFitWidthZoomModeCheckItem2, Me.PdfSetFitVisibleZoomModeCheckItem2, Me.PdfExportFormDataBarItem2, Me.PdfImportFormDataBarItem2})
        Me.BarManager1.MaxItemId = 26
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPageNumberEdit2})
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(716, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 292)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(716, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 261)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(716, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 261)
        '
        'PdfCommandBar1
        '
        Me.PdfCommandBar1.Control = Me.PdfViewer1
        Me.PdfCommandBar1.DockCol = 0
        Me.PdfCommandBar1.DockRow = 0
        Me.PdfCommandBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.PdfCommandBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PdfFileOpenBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfFileSaveAsBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfFilePrintBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfFindTextBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfPreviousPageBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfNextPageBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetPageNumberBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoomOutBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoomInBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfExactZoomListBarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfExportFormDataBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfImportFormDataBarItem2)})
        '
        'PdfFileOpenBarItem2
        '
        Me.PdfFileOpenBarItem2.Id = 0
        Me.PdfFileOpenBarItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
        Me.PdfFileOpenBarItem2.Name = "PdfFileOpenBarItem2"
        '
        'PdfFileSaveAsBarItem2
        '
        Me.PdfFileSaveAsBarItem2.Id = 1
        Me.PdfFileSaveAsBarItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.PdfFileSaveAsBarItem2.Name = "PdfFileSaveAsBarItem2"
        '
        'PdfFilePrintBarItem2
        '
        Me.PdfFilePrintBarItem2.Id = 2
        Me.PdfFilePrintBarItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.PdfFilePrintBarItem2.Name = "PdfFilePrintBarItem2"
        '
        'PdfFindTextBarItem2
        '
        Me.PdfFindTextBarItem2.Id = 3
        Me.PdfFindTextBarItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        Me.PdfFindTextBarItem2.Name = "PdfFindTextBarItem2"
        '
        'PdfPreviousPageBarItem2
        '
        Me.PdfPreviousPageBarItem2.Id = 4
        Me.PdfPreviousPageBarItem2.Name = "PdfPreviousPageBarItem2"
        '
        'PdfNextPageBarItem2
        '
        Me.PdfNextPageBarItem2.Id = 5
        Me.PdfNextPageBarItem2.Name = "PdfNextPageBarItem2"
        '
        'PdfSetPageNumberBarItem2
        '
        Me.PdfSetPageNumberBarItem2.Edit = Me.RepositoryItemPageNumberEdit2
        Me.PdfSetPageNumberBarItem2.Id = 6
        Me.PdfSetPageNumberBarItem2.Name = "PdfSetPageNumberBarItem2"
        '
        'RepositoryItemPageNumberEdit2
        '
        Me.RepositoryItemPageNumberEdit2.AutoHeight = False
        Me.RepositoryItemPageNumberEdit2.LabelFormat = "de {0}"
        Me.RepositoryItemPageNumberEdit2.Mask.EditMask = "########;"
        Me.RepositoryItemPageNumberEdit2.Name = "RepositoryItemPageNumberEdit2"
        Me.RepositoryItemPageNumberEdit2.Orientation = DevExpress.XtraEditors.PagerOrientation.Horizontal
        '
        'PdfZoomOutBarItem2
        '
        Me.PdfZoomOutBarItem2.Id = 7
        Me.PdfZoomOutBarItem2.Name = "PdfZoomOutBarItem2"
        '
        'PdfZoomInBarItem2
        '
        Me.PdfZoomInBarItem2.Id = 8
        Me.PdfZoomInBarItem2.Name = "PdfZoomInBarItem2"
        '
        'PdfExactZoomListBarSubItem2
        '
        Me.PdfExactZoomListBarSubItem2.Id = 9
        Me.PdfExactZoomListBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom10CheckItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom25CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom50CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom75CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom100CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom125CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom150CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom200CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom400CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfZoom500CheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetActualSizeZoomModeCheckItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetPageLevelZoomModeCheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetFitWidthZoomModeCheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.PdfSetFitVisibleZoomModeCheckItem2)})
        Me.PdfExactZoomListBarSubItem2.Name = "PdfExactZoomListBarSubItem2"
        Me.PdfExactZoomListBarSubItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
        '
        'PdfZoom10CheckItem2
        '
        Me.PdfZoom10CheckItem2.Id = 10
        Me.PdfZoom10CheckItem2.Name = "PdfZoom10CheckItem2"
        '
        'PdfZoom25CheckItem2
        '
        Me.PdfZoom25CheckItem2.Id = 11
        Me.PdfZoom25CheckItem2.Name = "PdfZoom25CheckItem2"
        '
        'PdfZoom50CheckItem2
        '
        Me.PdfZoom50CheckItem2.Id = 12
        Me.PdfZoom50CheckItem2.Name = "PdfZoom50CheckItem2"
        '
        'PdfZoom75CheckItem2
        '
        Me.PdfZoom75CheckItem2.Id = 13
        Me.PdfZoom75CheckItem2.Name = "PdfZoom75CheckItem2"
        '
        'PdfZoom100CheckItem2
        '
        Me.PdfZoom100CheckItem2.Id = 14
        Me.PdfZoom100CheckItem2.Name = "PdfZoom100CheckItem2"
        '
        'PdfZoom125CheckItem2
        '
        Me.PdfZoom125CheckItem2.Id = 15
        Me.PdfZoom125CheckItem2.Name = "PdfZoom125CheckItem2"
        '
        'PdfZoom150CheckItem2
        '
        Me.PdfZoom150CheckItem2.Id = 16
        Me.PdfZoom150CheckItem2.Name = "PdfZoom150CheckItem2"
        '
        'PdfZoom200CheckItem2
        '
        Me.PdfZoom200CheckItem2.Id = 17
        Me.PdfZoom200CheckItem2.Name = "PdfZoom200CheckItem2"
        '
        'PdfZoom400CheckItem2
        '
        Me.PdfZoom400CheckItem2.Id = 18
        Me.PdfZoom400CheckItem2.Name = "PdfZoom400CheckItem2"
        '
        'PdfZoom500CheckItem2
        '
        Me.PdfZoom500CheckItem2.Id = 19
        Me.PdfZoom500CheckItem2.Name = "PdfZoom500CheckItem2"
        '
        'PdfSetActualSizeZoomModeCheckItem2
        '
        Me.PdfSetActualSizeZoomModeCheckItem2.Id = 20
        Me.PdfSetActualSizeZoomModeCheckItem2.Name = "PdfSetActualSizeZoomModeCheckItem2"
        '
        'PdfSetPageLevelZoomModeCheckItem2
        '
        Me.PdfSetPageLevelZoomModeCheckItem2.Id = 21
        Me.PdfSetPageLevelZoomModeCheckItem2.Name = "PdfSetPageLevelZoomModeCheckItem2"
        '
        'PdfSetFitWidthZoomModeCheckItem2
        '
        Me.PdfSetFitWidthZoomModeCheckItem2.Id = 22
        Me.PdfSetFitWidthZoomModeCheckItem2.Name = "PdfSetFitWidthZoomModeCheckItem2"
        '
        'PdfSetFitVisibleZoomModeCheckItem2
        '
        Me.PdfSetFitVisibleZoomModeCheckItem2.Id = 23
        Me.PdfSetFitVisibleZoomModeCheckItem2.Name = "PdfSetFitVisibleZoomModeCheckItem2"
        '
        'PdfExportFormDataBarItem2
        '
        Me.PdfExportFormDataBarItem2.Id = 24
        Me.PdfExportFormDataBarItem2.Name = "PdfExportFormDataBarItem2"
        '
        'PdfImportFormDataBarItem2
        '
        Me.PdfImportFormDataBarItem2.Id = 25
        Me.PdfImportFormDataBarItem2.Name = "PdfImportFormDataBarItem2"
        '
        'FrmPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 292)
        Me.Controls.Add(Me.PdfViewer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmPDF"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "FrmPDF"
        Me.ThemeName = "Office2013Light"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PdfBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPageNumberEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PdfViewer1 As DevExpress.XtraPdfViewer.PdfViewer
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents PdfCommandBar1 As DevExpress.XtraPdfViewer.Bars.PdfCommandBar
    Friend WithEvents PdfFileOpenBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem
    Friend WithEvents PdfFileSaveAsBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem
    Friend WithEvents PdfFilePrintBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem
    Friend WithEvents PdfFindTextBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem
    Friend WithEvents PdfPreviousPageBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem
    Friend WithEvents PdfNextPageBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem
    Friend WithEvents PdfSetPageNumberBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem
    Friend WithEvents RepositoryItemPageNumberEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit
    Friend WithEvents PdfZoomOutBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem
    Friend WithEvents PdfZoomInBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem
    Friend WithEvents PdfExactZoomListBarSubItem2 As DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem
    Friend WithEvents PdfZoom10CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem
    Friend WithEvents PdfZoom25CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem
    Friend WithEvents PdfZoom50CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem
    Friend WithEvents PdfZoom75CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem
    Friend WithEvents PdfZoom100CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem
    Friend WithEvents PdfZoom125CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem
    Friend WithEvents PdfZoom150CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem
    Friend WithEvents PdfZoom200CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem
    Friend WithEvents PdfZoom400CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem
    Friend WithEvents PdfZoom500CheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem
    Friend WithEvents PdfSetActualSizeZoomModeCheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem
    Friend WithEvents PdfSetPageLevelZoomModeCheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem
    Friend WithEvents PdfSetFitWidthZoomModeCheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem
    Friend WithEvents PdfSetFitVisibleZoomModeCheckItem2 As DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem
    Friend WithEvents PdfExportFormDataBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem
    Friend WithEvents PdfImportFormDataBarItem2 As DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PdfBarController1 As DevExpress.XtraPdfViewer.Bars.PdfBarController
End Class

