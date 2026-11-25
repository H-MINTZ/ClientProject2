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
        List<Products> lstProducts;
        public FrmAllProducts()
        {
            InitializeComponent();
            con = new Connect();
        }

        private async void FrmAllProducts_Load(object sender, EventArgs e)
        {
            
        }

        private async void FrmAllProducts_Load_1(object sender, EventArgs e)
        {
           lstProducts = await con.GetAllProducts();
            dgvAllProducts.DataSource = lstProducts.Select(p => new
            {
                p.ProductId,
                p.ProductName,
                p.Category,
                p.Material,
                p.Price,
            }).ToList();
            dgvAllProducts.Columns[0].HeaderText = "קוד המוצר";
            dgvAllProducts.Columns[1].HeaderText = "שם המוצר";
            dgvAllProducts.Columns[2].HeaderText = "קטגוריה";
            dgvAllProducts.Columns[3].HeaderText = "סוג החומר";
            dgvAllProducts.Columns[4].HeaderText = "מחיר";
            dgvAllProducts.Columns[0].Width = 50;



        }
    }
}
