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
    public partial class FrmAllProducts : Form
    {
        Connect con;
        public FrmAllProducts()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmAllProducts_Load(object sender, EventArgs e)
        {
            dgvAllProducts.DataSource = await con.GetAllProducts();
        }
    }
}
