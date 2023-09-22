Public Class frmAddProduct
    Dim productService As New ProductService()
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If productService.addProduct(txtProductName.Text, chkIsAvailable.Checked) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class