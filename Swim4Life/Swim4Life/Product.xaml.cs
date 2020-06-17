using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Swim4Life
{
    /// <summary>
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : Window
    {
		dbEntities db = new dbEntities();
		public Product()
        {
            InitializeComponent();
        }

		private void Add_Click(object sender, RoutedEventArgs e)
		{
			String Name = ProdN.Text;
			int Price;
			try {  Price = Convert.ToInt32(ProdP.Text); }
			catch
			{
				this.Title = "Erorr";
				return;
			}
			
			if (ProdN.Text == "" || ProdP.Text == "")
			{
				this.Title = "Erorr";
				return;
			}
			Product_tbl a1 = new Product_tbl();
			a1.ProdName = Name;
			a1.ProdPrice = Price;

			db.Product_tbl.Add(a1);
			db.SaveChanges();
			this.Title = "Employee Add";

			ProdN.Text = "";
			ProdP.Text = "";

			this.Title = "sucsses";
			UpdateDGV();
			updateCB();

		}

		private void Delete_Click(object sender, RoutedEventArgs e)
		{
			db.Product_tbl.Remove((Product_tbl)prod_tbl.SelectedItem);
			db.SaveChanges();
			UpdateDGV();
			updateCB();

		}

		private void Update_Click(object sender, RoutedEventArgs e)
		{
			Product_tbl a1 = (Product_tbl)CB.SelectedItem;
			Product_tbl a2 = (from s in db.Product_tbl where s.ProdId == a1.ProdId select s).FirstOrDefault();
			a2.ProdName = ProdN.Text;
			a2.ProdPrice = Convert.ToInt32(ProdP.Text);


			db.SaveChanges();
			updateCB();
			UpdateDGV();

		}

		private void CB_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Product_tbl a1 = (Product_tbl)CB.SelectedItem;
			if (a1 == null)
			{
				ProdN.Text = "";
				ProdP.Text = "";

				return;
			}
			ProdN.Text = a1.ProdName;
			ProdP.Text = a1.ProdPrice.ToString();
		}

		private void OnLoad(object sender, RoutedEventArgs e)
		{
			updateCB();
			UpdateDGV();

		}
		private void UpdateDGV()
		{
			dbEntities db1 = new dbEntities();
			db = db1;
			List<Product_tbl> lst = (from s in db.Product_tbl select s).ToList();
			prod_tbl.ItemsSource = lst;
			prod_tbl.Columns[0].Visibility = Visibility.Hidden;
			/* פעולה לעדכון הטבלה*/

		}
		private void updateCB()
		{
			/*עדכון קומבובוקס*/

			CB.ItemsSource = null;
			CB.Text = "";

			List<Product_tbl> lst = (from s in db.Product_tbl select s).ToList();
			CB.ItemsSource = lst;
			CB.DisplayMemberPath = "ProdName";
			CB.SelectedValuePath = "ProdId";
		}

	}
}
