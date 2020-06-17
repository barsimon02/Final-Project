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
	/// Interaction logic for Pool.xaml
	/// </summary>
	public partial class Pool : Window
	{
		dbEntities db = new dbEntities();
		public Pool()
		{
			InitializeComponent();
		}

		private void Add_Click(object sender, RoutedEventArgs e)
		{
			String Name = PoolN.Text;
			String City = PoolC.Text;


			/*בודק שהוכנסו כל הנתונים שהם חובה
			   EmpN name of textBox*/
			if (PoolN.Text == "" || PoolC.Text == "")
			{
				this.Title = "Erorr";
				return;
			}
			/*   שומר את הנתונים שהוקלדו והוכנסו אל המשתנים המתאימים בטבלה
		 EmpName השם של העמודה בטבלה*/
			Pool_Tbl a1 = new Pool_Tbl();
			a1.PoolCity = City;
			a1.PoolName = Name;




			db.Pool_Tbl.Add(a1);
			db.SaveChanges();
			this.Title = "Employee Add";

			PoolN.Text = "";
			PoolC.Text = "";

			this.Title = "sucsses";
			UpdateDGV();
			updateCB();
		}

		private void Delete_Click(object sender, RoutedEventArgs e)
		{
			db.Pool_Tbl.Remove((Pool_Tbl)pool_tbl.SelectedItem);
			db.SaveChanges();
			UpdateDGV();
			updateCB();
		}

		private void Update_Click(object sender, RoutedEventArgs e)
		{
			Pool_Tbl a1 = (Pool_Tbl)CB.SelectedItem;
			Pool_Tbl a2 = (from s in db.Pool_Tbl where s.PoolId == a1.PoolId select s).FirstOrDefault();
			a2.PoolCity = PoolC.Text;
			a2.PoolName = PoolC.Text;


			db.SaveChanges();
			updateCB();
			UpdateDGV();
		}

		private void CB_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Pool_Tbl a1 = (Pool_Tbl)CB.SelectedItem;
			if (a1 == null)
			{
				PoolN.Text = "";
				PoolC.Text = "";


				return;

			}
			PoolN.Text = a1.PoolName;
			PoolC.Text = a1.PoolCity;
		}
		private void UpdateDGV()
		{
			dbEntities db1 = new dbEntities();
			db = db1;
			List<Pool_Tbl> lst = (from s in db.Pool_Tbl select s).ToList();
			pool_tbl.ItemsSource = lst;
			pool_tbl.Columns[0].Visibility = Visibility.Hidden;
			/* פעולה לעדכון הטבלה*/

		}
		private void updateCB()
		{
			/*עדכון קומבובוקס*/

			CB.ItemsSource = null;
			CB.Text = "";

			List<Pool_Tbl> lst = (from s in db.Pool_Tbl select s).ToList();
			CB.ItemsSource = lst;
			CB.DisplayMemberPath = "PoolName";
			CB.SelectedValuePath = "PoolId";
		}

		private void OnLoad(object sender, RoutedEventArgs e)
		{
			updateCB();
			UpdateDGV();
		}
	}
}
