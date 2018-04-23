namespace T183237 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.RegisterAssemblies(new string[] {
            "ClassLibrary1"});
            this.imageCollection1.InsertImage(1, "Untitled.png", "ClassLibrary1.Untitled.png", 0);
            this.imageCollection1.Images.SetKeyName(0, "Untitled.png");
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "Form1";
            this.Text = "ImageCollection - How to use images from a solution-wide resource assembly";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;

    }
}

