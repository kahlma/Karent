﻿using MaterialSkin;
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
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (frm3 == null)
            {
                frm3 = new Form3();  
                frm3.FormClosed += frm2_FormClosed;  
            }

            frm3.Show(this);  
            Hide();
        }

        void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm3 = null;  
            Show();
        }
    }
}
