using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet5.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter1.Fill(this.dataSet5.DataTable1);

            // TODO: This line of code loads data into the 'dataSet4.Datajust' table. You can move, or remove it, as needed.
            //  this.dataTablejustAdapter.Fill(this.dataSet4.Datajust);
            // TODO: This line of code loads data into the 'dataSet4.Datajust' table. You can move, or remove it, as needed.
            //            this.dataTablejustAdapter.Fill(this.dataSet4.Datajust);
            // TODO: This line of code loads data into the 'dataSet3.DataTablem' table. You can move, or remove it, as needed.
            this.dataTablemTableAdapter.Fill(this.dataSet3.DataTablem);
            // TODO: This line of code loads data into the 'dataSet2.DataTable' table. You can move, or remove it, as needed.
            this.dataTableTableAdapter.Fill(this.dataSet2.DataTable);
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            dataTable1TableAdapter.FillBy(dataSet1.DataTable1);



            this.reportViewer1.RefreshReport();
            
            this.reportViewer2.RefreshReport();


            this.reportViewer4.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            if (i == 0)
                dataTable1TableAdapter.FillBy(dataSet1.DataTable1);
            else if(i == 1)
                dataTable1TableAdapter.Fill(dataSet1.DataTable1, "M");
            else if (i == 2)
                dataTable1TableAdapter.Fill(dataSet1.DataTable1, "T");
            
            this.reportViewer1.RefreshReport();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTableTableAdapter.FillBy(this.dataSet2.DataTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int malalt = Convert.ToInt32(comboBox2.SelectedValue);

            this.dataTablejustAdapter.Fill(this.dataSet4.Datajust, malalt);
            this.reportViewer3.RefreshReport();
        }
    }
}
