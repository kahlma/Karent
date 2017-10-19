using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private PictureBox createPB()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new System.Drawing.Point(3, 3);
            pictureBox.Name = "pictureBox1";
            pictureBox.Size = new System.Drawing.Size(100, 50);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;

            return pictureBox;
        }
    }
}
