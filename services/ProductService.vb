Public Class ProductService
    Private dataStore As New dataStore()
    Public Function addProduct(productName As String, isAvailable As Boolean) As Boolean
        Return dataStore.addProduct(productName, isAvailable)
    End Function

    Public Function getProducts() As Product()
        Return dataStore.getProducts()
    End Function

End Class
