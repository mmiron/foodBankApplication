Imports System.Security.Cryptography

Public Class dataStore

    Private ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};DBQ=database.mdb;DefaultDir=c:\dev\simpleDBForm;Uid=Admin;Pwd=;"

    Public Function addProduct(productName As String, isAvailable As Boolean) As Boolean
        ' database save...
        On Error GoTo ErrorHandler

        Dim conn As New ADODB.Connection()
        Dim rs As New ADODB.Recordset()
        Dim strCnxn As String
        Dim strSQLEmployees As String
        'Dim varDate As Variant

        ' Open connection  
        Dim st = "c:\dev\simpleDBForm\database.mdb"

        conn.ConnectionString = ConnectionString ' "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & st & "';Persist Security Info=True;Jet OLEDB:Database Password="

        conn.Open()

        ' Open employee table  
        'rs = New ADODB.Recordset
        'strSQLEmployees = "products"
        'rs.Open(strSQLEmployees, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
        'Dim fields(1) As Object
        'fields(0) = "productName"
        'fields(1) = "isAvailable"

        'Dim values(1) As Object
        'values(0) = productName
        'values(1) = isAvailable
        'rs.AddNew(fields, values)

        conn.Execute("insert into products (productName, isAvailable) values ('" & productName & "', " & isAvailable & ")")

        ' clean up  
        ' rs.Close()
        conn.Close()
        rs = Nothing
        conn = Nothing
        Return True
        Exit Function

ErrorHandler:
        ' clean up  
        If Not rs Is Nothing Then
            If rs.State = ADODB.ObjectStateEnum.adStateOpen Then rs.Close()
        End If
        rs = Nothing

        If Not conn Is Nothing Then
            If conn.State = ADODB.ObjectStateEnum.adStateOpen Then conn.Close()
        End If
        conn = Nothing

        'If Err(). <> 0 Then
        MsgBox(Err.Source & "-->" & Err.Description, , "Error")
        'End If
        Return False
    End Function

    Public Function getProducts() As Product()
        On Error GoTo ErrorHandler
        Dim products() As Product
        Dim conn As New ADODB.Connection()
        Dim rs As ADODB.Recordset

        ' Open connection  
        Dim st = "c:\dev\simpleDBForm\database.mdb"

        ' conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & st & "';Persist Security Info=True;Jet OLEDB:Database Password="
        conn.ConnectionString = ConnectionString ' = "Driver={Microsoft Access Driver (*.mdb)};DBQ=database.mdb;DefaultDir=c:\dev\simpleDBForm;Uid=Admin;Pwd=;"
        conn.Open()

        ' Open employee table  
        rs = New ADODB.Recordset
        rs.Open("products", conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
        If Not (rs.EOF And rs.BOF) Then
            rs.MoveLast()
            rs.MoveFirst()
            Dim index As Integer = 0
            ReDim products(rs.RecordCount - 1)
            Do Until rs.EOF = True
                ' rs.Move(index)
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
        conn.Close()
        rs = Nothing
        conn = Nothing
        Return products
        Exit Function

ErrorHandler:
        ' clean up  
        If Not rs Is Nothing Then
            If rs.State = ADODB.ObjectStateEnum.adStateOpen Then rs.Close()
        End If
        rs = Nothing

        If Not conn Is Nothing Then
            If conn.State = ADODB.ObjectStateEnum.adStateOpen Then conn.Close()
        End If
        conn = Nothing

        MsgBox(Err.Source & "-->" & Err.Description, , "Error")
        Return Nothing
    End Function
End Class
