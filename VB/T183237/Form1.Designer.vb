Namespace T183237

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T183237.Form1))
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.RegisterAssemblies(New String() {"ClassLibrary1"})
            Me.imageCollection1.InsertImage(1, "Untitled.png", "ClassLibrary1.Untitled.png", 0)
            Me.imageCollection1.Images.SetKeyName(0, "Untitled.png")
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.Location = New System.Drawing.Point(12, 12)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Size = New System.Drawing.Size(100, 96)
            Me.pictureEdit1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(632, 278)
            Me.Controls.Add(Me.pictureEdit1)
            Me.Name = "Form1"
            Me.Text = "ImageCollection - How to use images from a solution-wide resource assembly"
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
    End Class
End Namespace
