<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnAddProduct = New Button()
        lstProducts = New ListBox()
        btnCancel = New Button()
        lblProductsDescription = New Label()
        SuspendLayout()
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.Location = New Point(95, 415)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(116, 23)
        btnAddProduct.TabIndex = 2
        btnAddProduct.Text = "Add product"
        btnAddProduct.UseVisualStyleBackColor = True
        ' 
        ' lstProducts
        ' 
        lstProducts.FormattingEnabled = True
        lstProducts.ItemHeight = 15
        lstProducts.Location = New Point(12, 42)
        lstProducts.Name = "lstProducts"
        lstProducts.Size = New Size(285, 364)
        lstProducts.TabIndex = 3
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(217, 415)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(80, 23)
        btnCancel.TabIndex = 4
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' lblProductsDescription
        ' 
        lblProductsDescription.AutoSize = True
        lblProductsDescription.Location = New Point(11, 16)
        lblProductsDescription.Name = "lblProductsDescription"
        lblProductsDescription.Size = New Size(168, 15)
        lblProductsDescription.TabIndex = 5
        lblProductsDescription.Text = "Number of products on hand: "
        ' 
        ' frmProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(308, 450)
        Controls.Add(lblProductsDescription)
        Controls.Add(btnCancel)
        Controls.Add(lstProducts)
        Controls.Add(btnAddProduct)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmProducts"
        StartPosition = FormStartPosition.CenterParent
        Text = "Products"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddProduct As Button
    Friend WithEvents lstProducts As ListBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblProductsDescription As Label
End Class
