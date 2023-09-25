Imports System.Security.Cryptography

Public Class dataStore

    Private conn As New ADODB.Connection()

    Public Sub New()
        Dim projectFolder = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName
        Dim databaseFile = "database.mdb"
        Dim connectionString = "Driver={Microsoft Access Driver (*.mdb)};DBQ=" & databaseFile & ";DefaultDir=" & projectFolder & ";Uid=Admin;Pwd=;"
        conn.ConnectionString = connectionString ' "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & st & "';Persist Security Info=True;Jet OLEDB:Database Password="
        conn.Open()
    End Sub

    Protected Overrides Sub Finalize()
        conn.Close()
        conn = Nothing
        MyBase.Finalize()
    End Sub

    Public Function addProduct(productName As String, isAvailable As Boolean) As Boolean
        ' database save...
        On Error GoTo ErrorHandler

        conn.Execute("insert into products (productName, isAvailable) values ('" & productName & "', " & isAvailable & ")")

        Return True
        Exit Function

ErrorHandler:

        'If Err(). <> 0 Then
        MsgBox(Err.Source & "-->" & Err.Description, , "Error")
        'End If
        Return False
    End Function

    Public Function getProducts() As Product()
        On Error GoTo ErrorHandler
        Dim products() As Product
        Dim rs As ADODB.Recordset

        ' Open employee table  
        rs = New ADODB.Recordset
        rs.Open("products", conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
        If Not (rs.EOF And rs.BOF) Then
            rs.MoveLast()
            rs.MoveFirst()
            Dim index As Integer = 0
            ReDim products(rs.RecordCount - 1)
            Do Until rs.EOF = True
                Dim product = New Product()
                product.productName = rs.Fields.Item("productName").Value
                product.isAvailable = rs.Fields.Item("isAvailable").Value
                product.id = rs.Fields.Item("id").Value
                products(index) = product
                rs.MoveNext()
                index += 1
            Loop
        End If

        ' clean up  
        rs.Close()
        rs = Nothing
        Return products
        Exit Function

ErrorHandler:
        ' clean up  
        If Not rs Is Nothing Then
            If rs.State = ADODB.ObjectStateEnum.adStateOpen Then rs.Close()
        End If
        rs = Nothing

        MsgBox(Err.Source & "-->" & Err.Description, , "Error")
        Return Nothing
    End Function
End Class
