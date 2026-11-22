using clientShop.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clientShop
{
    public partial class Form1 : Form
    {
        HttpClient Client;//אוביקט שתפקידו לתקשר עם השרת
        List<Customers> lstCustomers; //רשימה שתכיל את כל מאגר הלקוחות
        HttpResponseMessage response;//אוביקט שמקבל את התגובה מהשרת
        public Form1()
        {
            InitializeComponent();
            Client = new HttpClient();
            response = new HttpResponseMessage();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            response = await Client.GetAsync("https://localhost:7180/api/Customers");


            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstCustomers = JsonConvert.DeserializeObject<List<Customers>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }

            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            dataGridView1.DataSource = lstCustomers;//מגדיר את רשימת הלקוחות (lstCustomers) כמקור הנתונים של פקד הטבלה (dataGridView1), כך שהנתונים יוצגו בצורה טבלאית ויפה על גבי המסך.
        }
    }


}
    

