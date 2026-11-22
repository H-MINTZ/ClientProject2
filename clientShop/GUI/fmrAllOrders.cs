using clientShop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientShop.GUI
{
    public partial class FrmAllOrders : Form
    {
        Connect con;
        public FrmAllOrders()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmAllOrders_Load(object sender, EventArgs e)
        {
            dgvAllOrders.DataSource = await con.GetAllOrders();
        }
    }
}
