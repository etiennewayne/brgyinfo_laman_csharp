﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BarangayInformation
{
    public partial class Mainform : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;

        LoginForm _frm;
        public Mainform(LoginForm _frm)
        {
            InitializeComponent();

            this._frm = _frm;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ResidentMainForm frm = new ResidentMainForm();
            frm.Show();
        }

      

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult diagresult = MessageBox.Show("Are you sure you want to logout?", "LOGOUT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(diagresult == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frm.Show();
        }

        private void nationalitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NationalityMainForm frm = new NationalityMainForm();
            frm.ShowDialog();
        }

        private void waterSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                WaterSourceMainForm frm = new WaterSourceMainForm();  
                frm.ShowDialog();
            }
        }

       
        private void toolStripSetting_ButtonClick(object sender, EventArgs e)
        {

        }

        private void religionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                {
                    ReligionMainForm frm = new ReligionMainForm();
                    frm.ShowDialog();
                }
            }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CountryMainForm frm = new CountryMainForm();
            frm.ShowDialog();
        }
    }
}
