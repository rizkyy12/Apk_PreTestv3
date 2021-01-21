Imports System.Data.OleDb
Module Module1
    Public Conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Rd As OleDbDataReader
    Public Ds As DataSet
    Public Cmd As OleDbCommand
    Dim LokasiDB As String

    Public Sub Koneksi()
        LokasiDB = "provider=microsoft.jet.oledb.4.0;data source=DB_PreTest.mdb"
        Conn = New OleDbConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
