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
    public partial class Form1 : Form
    {
    public Form1()
        {
            InitializeComponent();
            DGVShowData.ColumnCount = 7;
            DGVShowData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            DGVShowData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGVShowData.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            DGVShowData.GridColor = Color.Black;
            DGVShowData.RowHeadersVisible = false;
            DGVShowData.Columns[0].Name = "Recent Service Date";
            DGVShowData.Columns[1].Name = "Licence Plate Number";
            DGVShowData.Columns[2].Name = "Vehicle Model";
            DGVShowData.Columns[3].Name = "Vehicle Year";
            DGVShowData.Columns[4].Name = "Months between service";
            DGVShowData.Columns[5].Name = "Next Service Date";
            DGVShowData.Columns[6].Name = "Service Description";
            DGVShowData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void displayongrid(Service veh)
        {
            DGVShowData.Rows.Add(veh.RecentServiceDate.ToString("dd/MM/yyyy"),veh.LicencePlate,veh.Model,veh.Year,veh.Month,veh.ComputeNextServiceDate().ToString("dd/MM/yyyy"), veh.Description);
            DGVShowData.Refresh();
        }
        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BAddNewV_Click(object sender, EventArgs e)
        {

            AddForm form2 = new AddForm();
            form2.ShowDialog();
        }

        private void BSearchLicence_Click(object sender, EventArgs e)
        {
            Service veh = new Service();
            int i = 0;
            if (TBLicence.Text == "")
            {
                i = 1;
                LLicence.Visible = true;
            }
            else { LLicence.Visible = false; }
            if (i == 0)
            {
                DGVShowData.Rows.Clear();
                DGVShowData.Refresh();
                string line;
                StreamReader file = new StreamReader("vechileData.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    veh.RecentServiceDate = new DateTime(Convert.ToInt32(words[2]), Convert.ToInt32(words[1]), Convert.ToInt32(words[0]));
                    veh.LicencePlate = words[3];
                    veh.Model = words[4];
                    veh.Year = Convert.ToInt32(words[5]);
                    veh.Month = Convert.ToInt32(words[6]);
                    veh.Description = words[7];

                    if (TBLicence.Text == veh.LicencePlate)
                    {
                        displayongrid(veh);
                    }
                }
                file.Close();
            }
        }
        private void BSearchDate_Click(object sender, EventArgs e)
        {
            Service veh = new Service();
            int i = 0;
            try
            {
                DateTime datetest = new DateTime(Convert.ToInt32(TBYY.Text), Convert.ToInt32(TBMM.Text), Convert.ToInt32(TBDD.Text));
                LDate.Visible = false;
            }
            catch (Exception ex)
            {
                i = 1;
                LDate.Text = "Error! Check again!";
                LDate.Visible = true;
            }
            
            if (i == 0)
            {
                DGVShowData.Rows.Clear();
                DGVShowData.Refresh();

                string line;
                StreamReader file = new StreamReader("vechileData.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    veh.RecentServiceDate = new DateTime(Convert.ToInt32(words[2]), Convert.ToInt32(words[1]), Convert.ToInt32(words[0]));
                    veh.LicencePlate = words[3];
                    veh.Model = words[4];
                    veh.Year = Convert.ToInt32(words[5]);
                    veh.Month = Convert.ToInt32(words[6]);
                    veh.Description = words[7];
                    DateTime datetest = new DateTime(Convert.ToInt32(TBYY.Text), Convert.ToInt32(TBMM.Text), Convert.ToInt32(TBDD.Text));
                    if (datetest == veh.ComputeNextServiceDate())
                    {
                        displayongrid(veh);
                    }
                }
                file.Close();
            }
        }

    }
}
