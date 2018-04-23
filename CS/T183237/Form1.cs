using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace T183237 {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            pictureEdit1.Image = imageCollection1.Images[0];
        }
    }
}
