Imports System.Data.SqlClient
Imports System.IO

Module Procedimientos

    Public Sub Main()
        On Error Resume Next
        MkDir(Application.StartupPath & "\Attach")
        On Error GoTo 0
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Server = GetSetting("GestionDocumental", "SQLServer", "Server", ".")
        Usuario = GetSetting("GestionDocumental", "SQLServer", "Usuario", "sa")
        BD = GetSetting("GestionDocumental", "SQLServer", "BD", "GestionDocumental")
        Clave = DeEncriptar(GetSetting("GestionDocumental", "SQLServer", "Clave", Encriptar("versat")))

        Conectado = Conectar(Server, BD, Usuario, Clave)
        If Conectado = True Then
            Dim CadenaSerSQL As String = "Data Source=" & Server & ";Initial Catalog=" & BD & ";Persist Security Info=True;User ID=" & Usuario & ";Password=" & Clave
            OpenConSQL(CadenaSerSQL)
            InsertarUsuario("admin", "admin", "admin@gestion.com", Encriptar("admon2018"), 3)
        End If
        Application.Run(New Form1)

    End Sub

    Public Sub OpenConSQL(ByVal Cadena As String)
        Try
            dbSQLBD = Nothing
            dbSQLBD = New SqlClient.SqlConnection
            dbSQLBD.ConnectionString = Cadena
            dbSQLBD.Open()

        Catch ex As Exception
            MsgBox("Ocurrió un error inicializando las conexiones, Imposible continuar" & Chr(13) & ex.Message, MsgBoxStyle.ApplicationModal)
            End
        End Try
    End Sub

    Public Function InsertarUsuario(ByVal idUsuario As String, ByVal idNombre As String, ByVal idEmail As String, ByVal idClave As String, ByVal idAcceso As Integer) As Integer
        Dim cmd As New SqlCommand

        With cmd
            .CommandType = CommandType.StoredProcedure
            .Connection = dbSQLBD
            .CommandText = "NuevoUsuario"
            .Parameters.Add("@ID", SqlDbType.NVarChar).Value = idUsuario
            .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = idNombre
            .Parameters.Add("@email", SqlDbType.NVarChar).Value = idEmail
            .Parameters.Add("@password", SqlDbType.NVarChar).Value = idClave
            .Parameters.Add("@idAcc", SqlDbType.BigInt).Value = idAcceso
            Return .ExecuteNonQuery()
        End With

    End Function

    Public Function InsertarArea(ByVal idNombre As String) As Integer
        Dim cmd As New SqlCommand

        With cmd
            .CommandType = CommandType.StoredProcedure
            .Connection = dbSQLBD
            .CommandText = "NuevaArea"
            .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = idNombre
            Return .ExecuteNonQuery()
        End With

    End Function

    Public Function InsertarTema(ByVal idCodA As Integer, ByVal idNombre As String) As Integer
        Dim cmd As New SqlCommand

        With cmd
            .CommandType = CommandType.StoredProcedure
            .Connection = dbSQLBD
            .CommandText = "NuevoTema"
            .Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = idNombre
            .Parameters.Add("@CodA", SqlDbType.BigInt).Value = idCodA
            Return .ExecuteNonQuery()
        End With

    End Function

    Public Function SubirDoc(ByVal idCodA As Integer, ByVal idTema As Integer, ByVal Contexto As String, ByVal Titulo As String, ByVal tipo As String, ByVal Usua As String, ByVal Fecha As Date, ByVal Fichero As String) As Integer
        'Dim cmd As New SqlCommand

        'With cmd
        ' .CommandType = CommandType.StoredProcedure
        ' .Connection = dbSQLBD
        ' .CommandText = "Subir"
        ' .Parameters.Add("@Tema", SqlDbType.Int).Value = idTema
        ' .Parameters.Add("@Context", SqlDbType.NVarChar).Value = Contexto
        ' .Parameters.Add("@title", SqlDbType.NVarChar).Value = Titulo
        ' .Parameters.Add("@Tip", SqlDbType.NVarChar).Value = tipo
        ' .Parameters.Add("@idUs", SqlDbType.NVarChar).Value = Usua
        ' .Parameters.Add("@CodA", SqlDbType.BigInt).Value = idCodA
        ' .Parameters.Add("@fech", SqlDbType.SmallDateTime).Value = Fecha
        ' .Parameters.Add("@fich", SqlDbType.VarBinary).Value = Fich
        ' Return .ExecuteNonQuery()
        ' End With

        Dim str As ADODB.Stream

        OpenTableView(17, "SELECT * FROM DOCUMENTOS")
        '
        str = New ADODB.Stream

        ' Configuramos y abrimos el objeto Stream binario
        With str
            .Type = ADODB.StreamTypeEnum.adTypeBinary
            .Open()
            .LoadFromFile(Fichero)

            ' Insertamos el objeto binario en la tabla
            '
            With rstTables(17)
                ' Si procede, añadimos un nuevo registro
                '

                .AddNew()
                .Fields("IDTEMA").Value = idTema
                .Fields("CODAREA").Value = idCodA
                .Fields("CONEXTO").Value = Contexto
                .Fields("TITULO").Value = Titulo
                .Fields("TIPO").Value = tipo
                .Fields("IDUSUARIO").Value = nUsuario
                .Fields("FECHA").Value = Now.Date
                .Fields("FICHERO").Value = str.Read
                .Update()
            End With

            ' Cerramos el objeto Stream
            .Close()
        End With


        str = Nothing
    End Function

    Public Function CargaUsuario(ByVal idNombre As String) As DataTable
        Dim cmd As New SqlCommand
        Dim ca As SqlDataAdapter
        Dim dt As New DataTable
        With cmd
            .CommandType = CommandType.Text
            .Connection = dbSQLBD
            .CommandText = "SELECT * FROM USUARIOS WHERE IDUSUARIO='" & idNombre & "'"
            ca = New SqlDataAdapter(cmd)
            ca.Fill(dt)
            Return dt
        End With

    End Function

    Public Function CargaArea(ByVal idNombre As String) As DataTable
        Dim cmd As New SqlCommand
        Dim ca As SqlDataAdapter
        Dim dt As New DataTable
        With cmd
            .CommandType = CommandType.Text
            .Connection = dbSQLBD
            .CommandText = "SELECT * FROM DEPARTAMENTOS WHERE AREA='" & idNombre & "'"
            ca = New SqlDataAdapter(cmd)
            ca.Fill(dt)
            Return dt
        End With

    End Function

    Public Function CargaDocumentos(ByVal idNombre As Integer) As DataTable
        Dim cmd As New SqlCommand
        Dim ca As SqlDataAdapter
        Dim dt As New DataTable
        With cmd
            .CommandType = CommandType.Text
            .Connection = dbSQLBD
            .CommandText = "SELECT idDocumentacion , Titulo, idUsuario, FECHA, tipo,fichero,conexto FROM Documentos WHERE idTema=" & idNombre
            ca = New SqlDataAdapter(cmd)
            ca.Fill(dt)
            Return dt
        End With

    End Function

    Public Function CargaTemas(ByVal idNombre As Integer) As DataTable
        Dim cmd As New SqlCommand
        Dim ca As SqlDataAdapter
        Dim dt As New DataTable
        With cmd
            .CommandType = CommandType.Text
            .Connection = dbSQLBD
            .CommandText = "SELECT idTema, Tema FROM TEMARIO WHERE CODAREA=" & idNombre & " ORDER BY IDTEMA ASC;"
            ca = New SqlDataAdapter(cmd)
            ca.Fill(dt)
            Return dt
        End With

    End Function

    Public Sub BytesAArchivo(ByVal LB As Byte(), ByVal Path As String, IDFILA As Integer)
        '  Dim K As Long
        '  If bytes Is Nothing Then Exit Sub
        '  Try
        ' K = UBound(bytes)
        ' Dim fs As New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write)
        ' fs.Write(bytes, 0, K)
        ' fs.Close()
        ' Catch ex As Exception
        ' Throw New Exception(ex.Message, ex)
        ' End Try

        'MsgBox(LB)
        
        OpenTableView(16, "SELECT * FROM DOCUMENTOS WHERE IDDOCUMENTACION=" & IDFILA)

        '  File.WriteAllBytes(Path, rstTables(16).Fields("FICHERO").)
        Dim str As ADODB.Stream
        str = New ADODB.Stream

        With str
            .Type = ADODB.StreamTypeEnum.adTypeBinary
            'adTypeBinary()
            ' Abrimos el objeto Stream
            .Open()
            ' Leemos su contenido
            .Write(rstTables(16).Fields("Fichero").Value)

            ' Guardamos el archivo en la ruta especificada
            .SaveToFile(Path, ADODB.SaveOptionsEnum.adSaveCreateOverWrite)

            ' Cerramos el objeto Stream
            .Close()
        End With
        rstTables(16).Close()

        
    End Sub
End Module
