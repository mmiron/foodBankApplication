<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnProducts = New Button()
        SuspendLayout()
        ' 
        ' btnProducts
        ' 
        btnProducts.Location = New Point(12, 12)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(77, 23)
        btnProducts.TabIndex = 0
        btnProducts.Text = "Products"
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(747, 424)
        Controls.Add(btnProducts)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmMain"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnProducts As Button
End Class
