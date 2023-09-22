Public Class frmProducts
    Private productService As New ProductService()
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        frmAddProduct.ShowDialog()
        populateProductList()
    End Sub

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateProductList()
    End Sub

    Private Sub populateProductList()
        Dim products() = productService.getProducts()
        lstProducts.Items.Clear()
        If Not products Is Nothing Then
            For Each product As Product In products
                lstProducts.Items.Add(product.productName + " " + IIf(product.isAvailable, "Available", "Not available"))
            Next

            lblProductsDescription.Text += products.Length.ToString()
        End If
    End Sub

End Class