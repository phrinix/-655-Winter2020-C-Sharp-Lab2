using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (TBModel.Text == "")
            {
                i = 1;
                LModel.Visible = true;
            }
            else { LModel.Visible = false; }
            try {
                Convert.ToInt32(TBYear.Text);
                LYear.Visible = false;
            }
            catch (Exception ex)
            {
                LYear.Visible = true;
                i = 1;
            }
            if (TBLicence.Text == "")
            {
                i = 1;
                LLicence.Visible = true;
            }
            else { LLicence.Visible = false; }
            try
            {
                DateTime datetest = new DateTime(Convert.ToInt32(TBRYY.Text), Convert.ToInt32(TBRMM.Text), Convert.ToInt32(TBRDD.Text));
                LDate.Visible = false;
                LDate.Visible = false;
            }
            catch (Exception ex)
            {
                i = 1;
                LDate.Visible = true;
            }
            try
            {
                Convert.ToInt32(TBMonth.Text);
                LMonth.Visible = false;
            }
            catch (Exception ex)
            {
                i = 1;
                LMonth.Visible = true;
            }
            if (RTBDescription.Text == "")
            {
                i = 1;
                LDescription.Visible = true;
            }
            else { LDescription.Visible = false; }
            if (i == 0)
            {
                LModel.Visible = false;
                LYear.Visible = false;
                LLicence.Visible = false;
                LDate.Visible = false;
                LMonth.Visible = false;
                LDescription.Visible = false;
                StreamWriter file = File.AppendText("vechileData.txt");
                file.Write(TBRDD.Text+","+TBRMM.Text + "," + TBRYY.Text + "," +TBLicence.Text + "," +TBModel.Text + "," +TBYear.Text + "," +TBMonth.Text + "," +RTBDescription.Text + "\n");
                file.Close();
                MessageBox.Show("Vehicle Added");
                this.Close();
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
