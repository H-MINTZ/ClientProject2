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

        public partial class FrmAllShipping : Form
        {
            Connect con;
            public FrmAllShipping()
            {
                InitializeComponent();
                con = new Connect();
            }

            private async void FrmAllShipping_Load(object sender, EventArgs e)
            {
            dgvAllShipping.DataSource = await con.GetAllShipping();
            }
        }
    
}
