﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            PnSubMenuProcesos.Visible = false;
            PnSubMenuConsulta.Visible = false;
            PnSubMenuReportes.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void BtnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(PnSubMenuProcesos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSubMenu(PnSubMenuConsulta);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showSubMenu(PnSubMenuReportes);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            hideSubMenu();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void BtnSubMenuProcesos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}