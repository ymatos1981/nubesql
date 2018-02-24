Imports ADODB
Module DeclaracionesADO
    Public Cnn As ADODB.Connection
    Public rstTables(0 To 999) As ADODB.Recordset

    Public Const adStateOpen = ADODB.ObjectStateEnum.adStateOpen
    Public Const adStateClosed = ADODB.ObjectStateEnum.adStateClosed
    Public Const adStateConnecting = ADODB.ObjectStateEnum.adStateConnecting
    Public Const adStateExecuting = ADODB.ObjectStateEnum.adStateExecuting
    Public Const adStateFetching = ADODB.ObjectStateEnum.adStateFetching

    Public Const adUseClient = ADODB.CursorLocationEnum.adUseClient
    Public Const adUseClientBatch = ADODB.CursorLocationEnum.adUseClientBatch
    Public Const adUseNone = ADODB.CursorLocationEnum.adUseNone
    Public Const adUseServer = ADODB.CursorLocationEnum.adUseServer

    Public Const adOpenDynamic = ADODB.CursorTypeEnum.adOpenDynamic
    Public Const adOpenForwardOnly = ADODB.CursorTypeEnum.adOpenForwardOnly
    Public Const adOpenKeyset = ADODB.CursorTypeEnum.adOpenKeyset
    Public Const adOpenStatic = ADODB.CursorTypeEnum.adOpenStatic
    Public Const adOpenUnspecified = ADODB.CursorTypeEnum.adOpenUnspecified

    Public Const adLockBatchOptimistic = ADODB.LockTypeEnum.adLockBatchOptimistic
    Public Const adLockOptimistic = ADODB.LockTypeEnum.adLockOptimistic
    Public Const adLockPessimistic = ADODB.LockTypeEnum.adLockPessimistic
    Public Const adLockReadOnly = ADODB.LockTypeEnum.adLockReadOnly
    Public Const adLockUnspecified = ADODB.LockTypeEnum.adLockUnspecified


    Public Function Conectar(ByVal SQLServ As String, ByVal BD As String, ByVal Usuario As String, ByVal Clave As String) As Boolean
        Cnn = Nothing
        Cnn = New ADODB.Connection
        Dim StrConexion As String
        StrConexion = "Provider=SQLOLEDB.1;Persist Security Info= True;Initial Catalog=" & BD & ";Data Source=" & SQLServ
        REM StrConexion = "Provider=SQLOLEDB.1;Integrated Security = True;Persist Security Info= True;Initial Catalog=" & BD & ";Data Source=" & SQLServ
        Try
            Cnn.Open(StrConexion, Usuario, Clave)
            If Cnn.State <> adStateOpen Then
                Conectar = False
            Else
                Conectar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Conectar = False
        End Try
    End Function

    Public Sub OpenTableView(ByVal ID As Integer, ByVal SqlScript As String)
        rstTables(ID) = Nothing
        rstTables(ID) = New ADODB.Recordset
        If rstTables(ID).State = 1 Then rstTables(ID).Close()
        rstTables(ID).Open(SqlScript, cnn, adOpenDynamic, adLockOptimistic)
    End Sub

End Module
