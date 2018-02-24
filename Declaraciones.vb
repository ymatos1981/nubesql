Imports System.Data.SqlClient

Module Declaraciones
    Public Conectado As Boolean = False

    Public Server As String = "."
    Public Usuario As String = "sa"
    Public BD As String = "GestionDocumental"
    Public Clave As String = "versat"

    Public Logeado As Boolean = False
    Public PermisoEscribir As Boolean = False
    Public PermisoAdicionar As Boolean = False
    Public PermisoAdministrar As Boolean = False
    Public UserLogin As String = ""
    Public dbSQLBD As SqlConnection

    Public nUsuario As String = ""
    Public nClave As String = ""
    Public nAcceso As Integer = 0
End Module
