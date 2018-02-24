﻿Imports Microsoft.VisualBasic
Imports System

Public Partial Class RadAboutBox1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (Not components Is Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.logoPictureBox = New System.Windows.Forms.PictureBox()
        Me.radLabelProductName = New Telerik.WinControls.UI.RadLabel()
        Me.radLabelVersion = New Telerik.WinControls.UI.RadLabel()
        Me.radLabelCopyright = New Telerik.WinControls.UI.RadLabel()
        Me.radLabelCompanyName = New Telerik.WinControls.UI.RadLabel()
        Me.radTextBoxDescription = New Telerik.WinControls.UI.RadTextBox()
        Me.okRadButton = New Telerik.WinControls.UI.RadButton()
        Me.tableLayoutPanel.SuspendLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabelProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabelVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabelCopyright, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radLabelCompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radTextBoxDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.okRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel
        '
        Me.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutPanel.ColumnCount = 2
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
        Me.tableLayoutPanel.Controls.Add(Me.logoPictureBox, 0, 0)
        Me.tableLayoutPanel.Controls.Add(Me.radLabelProductName, 1, 0)
        Me.tableLayoutPanel.Controls.Add(Me.radLabelVersion, 1, 1)
        Me.tableLayoutPanel.Controls.Add(Me.radLabelCopyright, 1, 2)
        Me.tableLayoutPanel.Controls.Add(Me.radLabelCompanyName, 1, 3)
        Me.tableLayoutPanel.Controls.Add(Me.radTextBoxDescription, 1, 4)
        Me.tableLayoutPanel.Controls.Add(Me.okRadButton, 1, 5)
        Me.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel.Location = New System.Drawing.Point(9, 9)
        Me.tableLayoutPanel.Name = "tableLayoutPanel"
        Me.tableLayoutPanel.RowCount = 6
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel.Size = New System.Drawing.Size(572, 265)
        Me.tableLayoutPanel.TabIndex = 0
        '
        'logoPictureBox
        '
        Me.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.logoPictureBox.Image = Global.GestionDocumental.My.Resources.Resources._146129_document_512x512
        Me.logoPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.logoPictureBox.Name = "logoPictureBox"
        Me.tableLayoutPanel.SetRowSpan(Me.logoPictureBox, 6)
        Me.logoPictureBox.Size = New System.Drawing.Size(182, 259)
        Me.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoPictureBox.TabIndex = 12
        Me.logoPictureBox.TabStop = False
        '
        'radLabelProductName
        '
        Me.radLabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radLabelProductName.Location = New System.Drawing.Point(194, 0)
        Me.radLabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.radLabelProductName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.radLabelProductName.Name = "radLabelProductName"
        '
        '
        '
        Me.radLabelProductName.RootElement.MaxSize = New System.Drawing.Size(0, 17)
        Me.radLabelProductName.Size = New System.Drawing.Size(78, 17)
        Me.radLabelProductName.TabIndex = 19
        Me.radLabelProductName.Text = "Product Name"
        Me.radLabelProductName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.radLabelProductName.ThemeName = "VisualStudio2012Dark"
        '
        'radLabelVersion
        '
        Me.radLabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radLabelVersion.Location = New System.Drawing.Point(194, 26)
        Me.radLabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.radLabelVersion.MaximumSize = New System.Drawing.Size(0, 17)
        Me.radLabelVersion.Name = "radLabelVersion"
        '
        '
        '
        Me.radLabelVersion.RootElement.MaxSize = New System.Drawing.Size(0, 17)
        Me.radLabelVersion.Size = New System.Drawing.Size(44, 17)
        Me.radLabelVersion.TabIndex = 0
        Me.radLabelVersion.Text = "Version"
        Me.radLabelVersion.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.radLabelVersion.ThemeName = "VisualStudio2012Dark"
        '
        'radLabelCopyright
        '
        Me.radLabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radLabelCopyright.Location = New System.Drawing.Point(194, 52)
        Me.radLabelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.radLabelCopyright.MaximumSize = New System.Drawing.Size(0, 17)
        Me.radLabelCopyright.Name = "radLabelCopyright"
        '
        '
        '
        Me.radLabelCopyright.RootElement.MaxSize = New System.Drawing.Size(0, 17)
        Me.radLabelCopyright.Size = New System.Drawing.Size(56, 17)
        Me.radLabelCopyright.TabIndex = 21
        Me.radLabelCopyright.Text = "Copyright"
        Me.radLabelCopyright.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.radLabelCopyright.ThemeName = "VisualStudio2012Dark"
        '
        'radLabelCompanyName
        '
        Me.radLabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radLabelCompanyName.Location = New System.Drawing.Point(194, 78)
        Me.radLabelCompanyName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.radLabelCompanyName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.radLabelCompanyName.Name = "radLabelCompanyName"
        '
        '
        '
        Me.radLabelCompanyName.RootElement.MaxSize = New System.Drawing.Size(0, 17)
        Me.radLabelCompanyName.Size = New System.Drawing.Size(87, 17)
        Me.radLabelCompanyName.TabIndex = 22
        Me.radLabelCompanyName.Text = "Company Name"
        Me.radLabelCompanyName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.radLabelCompanyName.ThemeName = "VisualStudio2012Dark"
        '
        'radTextBoxDescription
        '
        Me.radTextBoxDescription.AutoSize = False
        Me.radTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radTextBoxDescription.Location = New System.Drawing.Point(194, 107)
        Me.radTextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.radTextBoxDescription.Multiline = True
        Me.radTextBoxDescription.Name = "radTextBoxDescription"
        Me.radTextBoxDescription.ReadOnly = True
        Me.radTextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.radTextBoxDescription.Size = New System.Drawing.Size(375, 126)
        Me.radTextBoxDescription.TabIndex = 23
        Me.radTextBoxDescription.TabStop = False
        Me.radTextBoxDescription.Text = "Description"
        Me.radTextBoxDescription.ThemeName = "VisualStudio2012Dark"
        '
        'okRadButton
        '
        Me.okRadButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.okRadButton.Location = New System.Drawing.Point(494, 239)
        Me.okRadButton.Name = "okRadButton"
        Me.okRadButton.Size = New System.Drawing.Size(75, 23)
        Me.okRadButton.TabIndex = 24
        Me.okRadButton.Text = "&OK"
        Me.okRadButton.ThemeName = "VisualStudio2012Dark"
        '
        'RadAboutBox1
        '
        Me.AcceptButton = Me.okRadButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 283)
        Me.Controls.Add(Me.tableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RadAboutBox1"
        Me.Padding = New System.Windows.Forms.Padding(9)
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion Documental"
        Me.ThemeName = "Office2013Light"
        Me.tableLayoutPanel.ResumeLayout(False)
        Me.tableLayoutPanel.PerformLayout()
        CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabelProductName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabelVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabelCopyright, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radLabelCompanyName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radTextBoxDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.okRadButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

	#End Region

	Private tableLayoutPanel As System.Windows.Forms.TableLayoutPanel
	Private logoPictureBox As System.Windows.Forms.PictureBox
	Private radLabelProductName As Telerik.WinControls.UI.RadLabel
	Private radLabelVersion As Telerik.WinControls.UI.RadLabel
	Private radLabelCopyright As Telerik.WinControls.UI.RadLabel
	Private radLabelCompanyName As Telerik.WinControls.UI.RadLabel
    Private WithEvents radTextBoxDescription As Telerik.WinControls.UI.RadTextBox
    Private WithEvents okRadButton As Telerik.WinControls.UI.RadButton
End Class
