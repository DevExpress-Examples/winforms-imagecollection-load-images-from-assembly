Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace T183237
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            pictureEdit1.Image = imageCollection1.Images(0)
        End Sub
    End Class
End Namespace
