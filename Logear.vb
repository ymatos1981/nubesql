Public Class Logear

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton2.Click
        Logeado = False
        Me.Close()
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        PermisoEscribir = False
        PermisoAdministrar = False
        nUsuario = RadTextBox1.Text
        Logeado = False
        Dim f As New DataTable
        f = CargaUsuario(Me.RadTextBox1.Text)
        If f.Rows.Count = 0 Then
            MsgBox("Verifique el usuario", MsgBoxStyle.Information)
        Else
            If DeEncriptar(f.Rows(0)("Clave")) = Me.RadTextBox2.Text Then
                Logeado = True
                Select Case f.Rows(0)("idAcceso")
                    Case Is = 1
                        PermisoEscribir = False
                        PermisoAdministrar = False
                    Case Is = 2
                        PermisoEscribir = True
                        PermisoAdministrar = False
                    Case Is = 3
                        PermisoEscribir = True
                        PermisoAdministrar = True
                End Select
                Me.Close()
            Else
                MsgBox("Verifique la contraseña", MsgBoxStyle.Information)
            End If
        End If
    End Sub
End Class
