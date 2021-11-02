using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibility
{
    //Bir nesne, sadece bir işten sorumlu olmalıdır.
    //Bir sınıf içinde, kod değişikliği yapmak için birden fazla sebebiniz varsa, bu prensibi ihlal ediyorsunuz demektir.
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            double price = Convert.ToDouble(textBoxPrice.Text);
            var result = new ProductService(). AddProduct(name,price);
            string message = result > 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(message);

        }

     
    }
}
