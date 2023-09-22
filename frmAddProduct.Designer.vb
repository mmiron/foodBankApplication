<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProduct
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
        btnCancel = New Button()
        lblProductName = New Label()
        txtProductName = New TextBox()
        chkIsAvailable = New CheckBox()
        SuspendLayout()
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.Location = New Point(315, 83)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(97, 23)
        btnAddProduct.TabIndex = 0
        btnAddProduct.Text = "&Add product"
        btnAddProduct.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(418, 83)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' lblProductName
        ' 
        lblProductName.AutoSize = True
        lblProductName.Location = New Point(8, 20)
        lblProductName.Name = "lblProductName"
        lblProductName.Size = New Size(85, 15)
        lblProductName.TabIndex = 2
        lblProductName.Text = "Product name:"
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(94, 19)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(397, 23)
        txtProductName.TabIndex = 3
        ' 
        ' chkIsAvailable
        ' 
        chkIsAvailable.AutoSize = True
        chkIsAvailable.Location = New Point(11, 53)
        chkIsAvailable.Name = "chkIsAvailable"
        chkIsAvailable.Size = New Size(88, 19)
        chkIsAvailable.TabIndex = 4
        chkIsAvailable.Text = "Is available?"
        chkIsAvailable.UseVisualStyleBackColor = True
        ' 
        ' frmAddProduct
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(501, 117)
        Controls.Add(chkIsAvailable)
        Controls.Add(txtProductName)
        Controls.Add(lblProductName)
        Controls.Add(btnCancel)
        Controls.Add(btnAddProduct)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAddProduct"
        StartPosition = FormStartPosition.CenterParent
        Text = "Add product"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblProductName As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents chkIsAvailable As CheckBox
End Class
