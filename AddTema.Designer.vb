<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTema
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
        Me.cmdAreas = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.cmdAreas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAreas
        '
        Me.cmdAreas.Location = New System.Drawing.Point(202, 28)
        Me.cmdAreas.Name = "cmdAreas"
        Me.cmdAreas.Size = New System.Drawing.Size(253, 20)
        Me.cmdAreas.TabIndex = 1
        Me.cmdAreas.Text = "RadDropDownList1"
        Me.cmdAreas.ThemeName = "VisualStudio2012Light"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(202, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Seleccione el Area"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(202, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre del Tema"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Location = New System.Drawing.Point(202, 67)
        Me.RadTextBox1.MaxLength = 150
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(253, 20)
        Me.RadTextBox1.TabIndex = 6
        Me.RadTextBox1.ThemeName = "VisualStudio2012Light"
        '
        'RadButton2
        '
        Me.RadButton2.Image = Global.GestionDocumental.My.Resources.Resources.Cancel_16x16
        Me.RadButton2.Location = New System.Drawing.Point(375, 99)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(82, 22)
        Me.RadButton2.TabIndex = 7
        Me.RadButton2.Text = "Cancelar"
        Me.RadButton2.ThemeName = "VisualStudio2012Light"
        '
        'RadButton1
        '
        Me.RadButton1.Image = Global.GestionDocumental.My.Resources.Resources.Apply_16x16
        Me.RadButton1.Location = New System.Drawing.Point(202, 99)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(82, 23)
        Me.RadButton1.TabIndex = 5
        Me.RadButton1.Text = "Insertar"
        Me.RadButton1.ThemeName = "VisualStudio2012Light"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GestionDocumental.My.Resources.Resources.pdp
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 134)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'AddTema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 130)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdAreas)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddTema"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.cmdAreas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdAreas As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class

