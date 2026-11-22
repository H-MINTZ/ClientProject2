using clientShop.Model;
using clientShop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace clientShop.Model
{
    internal class Connect
    {
        HttpClient Client;//אוביקט שתפקידו לתקשר עם השרת
        HttpResponseMessage response;//אוביקט שמקבל את התגובה מהשרת
        List<Customers> lstCustomers; //רשימה שתכיל את כל מאגר הלקוחות
        List<Shipping> lstShipping; //רשימה שתכיל את כל מאגר הלקוחות
        List<Orders> lstOrders;
        List<GiftCards> lstGiftCards;
        List<Products> lstProducts;
        List<OederDetail> lstOederDetail;
        public Connect()
        {
            Client = new HttpClient();
            response = new HttpResponseMessage();
        }

        public async Task< List<Customers>> GetAllCustomer()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Customers");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstCustomers = JsonConvert.DeserializeObject<List<Customers>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstCustomers;    
        }
        public async Task<List<Shipping>> GetAllShipping()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Shipping");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstShipping = JsonConvert.DeserializeObject<List<Shipping>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstShipping;
        }
        public async Task<List<Orders>> GetAllOrders()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Orders");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstOrders = JsonConvert.DeserializeObject<List<Orders>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstOrders;
        }
        public async Task<List<GiftCards>> GetAllGiftCards()
        {
            response = await Client.GetAsync("https://localhost:7180/api/GiftCards");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstGiftCards = JsonConvert.DeserializeObject<List<GiftCards>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstGiftCards;
        }
        public async Task<List<Products>> GetAllProducts()
        {
            response = await Client.GetAsync("https://localhost:7180/api/Products");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstProducts = JsonConvert.DeserializeObject<List<Products>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstProducts;
        }
        public async Task<List<OederDetail>> GetAllOederDetail()
        {
            response = await Client.GetAsync("https://localhost:7180/api/OederDetail");
            if (response.IsSuccessStatusCode)//האם הקוד שחזר מהשרת הוא 200
            {
                string data = await response.Content.ReadAsStringAsync();//קורא את תוכן גוף התשובה שהגיע מהשרת כ מחרוזת טקסט (בדרך כלל במבנה JSON).
                lstOederDetail = JsonConvert.DeserializeObject<List<OederDetail>>(data);//משתמש בספריית Newtonsoft.Json כדי להמיר (לרדות) את מחרוזת ה-JSON שקיבלנו לתוך רשימה של אובייקטים מסוג List<Customers> ב-C#.
            }
            else
                MessageBox.Show("error ");//מציג הודעת שגיאה קופצת למשתמש (MessageBox) המעידה שמשהו השתבש בקריאה.
            return lstOederDetail;
        }



    }




}