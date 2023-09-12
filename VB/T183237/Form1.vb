Imports System.ComponentModel
Imports System.Drawing

Namespace T183237

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            pictureEdit1.Image = imageCollection1.Images(0)
        End Sub
    End Class
End Namespace
