using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class inventory_Admin :Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private DataTable Dt { get; set; }
     

        public inventory_Admin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();

        }
        private void PopulateGridView(string sql = "select * from [dbo].[Product];")
        {
            this.Dt = this.Da.Execute(sql);
            this.grid_Inventory.AutoGenerateColumns = false;
            this.grid_Inventory.DataSource = this.Dt;
            this.grid_Inventory.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inventoryF_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void grid_Inventory_DoubleClick(object sender, EventArgs e)
        {

        }

        
    }
}
