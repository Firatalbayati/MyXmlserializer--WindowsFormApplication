using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyXmlSeri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Fırat";
            customer1.SurName = "Albayatı";
            customer1.Email = "firatalby@gmail.com";
            customer1.TcKimlikNo = "12345678910";
            customer1.Address = "İstanbul/Bostancı";
            customer1.TelNo = "05436450000";
            customer1.YearOfBirth = 1994;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Ömer";
            customer2.SurName = "Albayatı";
            customer2.Email = "ömeralby@gmail.com";
            customer2.TcKimlikNo = "12345678911";
            customer2.Address = "İstanbul/Bostancı";
            customer2.TelNo = "054311111111";
            customer2.YearOfBirth = 1994;


            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);


            MySerializer serializer = new MySerializer();
            serializer.Serilestirme<Customer>(customers, "Firat.Xml");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
