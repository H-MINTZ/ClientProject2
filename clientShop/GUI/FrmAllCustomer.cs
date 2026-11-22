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
    public partial class FrmAllCustomer : Form
    {
        Connect con;
        public FrmAllCustomer()
        {
            InitializeComponent();
            con= new Connect(); 
        }

        private async void FrmAllCustomer_Load(object sender, EventArgs e)
        {
            dgvAllCustomer.DataSource =await con.GetAllCustomer();
        }
    }
}
