<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddArea
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(123, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Teclee el Nombre del Area"
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Location = New System.Drawing.Point(128, 24)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(272, 21)
        Me.RadTextBox1.TabIndex = 3
        Me.RadTextBox1.Text = "RadTextBox1"
        Me.RadTextBox1.ThemeName = "Office2013Light"
        '
        'RadButton2
        '
        Me.RadButton2.Image = Global.GestionDocumental.My.Resources.Resources.Cancel_16x16
        Me.RadButton2.Location = New System.Drawing.Point(318, 79)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(82, 28)
        Me.RadButton2.TabIndex = 4
        Me.RadButton2.Text = "Cancelar"
        Me.RadButton2.ThemeName = "VisualStudio2012Light"
        '
        'RadButton1
        '
        Me.RadButton1.Image = Global.GestionDocumental.My.Resources.Resources.Apply_16x16
        Me.RadButton1.Location = New System.Drawing.Point(136, 79)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(82, 28)
        Me.RadButton1.TabIndex = 2
        Me.RadButton1.Text = "Insertar"
        Me.RadButton1.ThemeName = "VisualStudio2012Light"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.GestionDocumental.My.Resources.Resources.b03a46db8235feb811fcae29a3f5b958_icono_de_documento_by_vexels
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(25, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 81)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'AddArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 111)
        Me.ControlBox = False
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddArea"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
End Class

