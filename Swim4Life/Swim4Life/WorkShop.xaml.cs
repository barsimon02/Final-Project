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
	/// Interaction logic for WorkShop.xaml
	/// </summary>
	public partial class WorkShop : Window
	{
		dbEntities db = new dbEntities();
		public WorkShop()
		{
			InitializeComponent();
		}

		private void Add_Click(object sender, RoutedEventArgs e)
		{
			int Emp;
			String Name = WorkN.Text;
			String Date = WorkD.Text;
			String EmpName= (Ecombo.SelectedItem as Employees_Tbl).EmpName;

			try { Emp = (Ecombo.SelectedItem as Employees_Tbl).EmpId; }
			catch
			{
				this.Title = "Erorr";
				return; 
			}

			/*בודק שהוכנסו כל הנתונים שהם חובה
			   EmpN name of textBox*/
			if (WorkN.Text == "" || WorkD.Text == "" )
			{
				this.Title = "Erorr";
				return;
			}
			/*   שומר את הנתונים שהוקלדו והוכנסו אל המשתנים המתאימים בטבלה
		 EmpName השם של העמודה בטבלה*/
			WorkShop_Tbl a1 = new WorkShop_Tbl();
			a1.WorkShopDate = Date;
			a1.WorkShopName = Name;
			a1.WorkShopEmployee = Emp;
			a1.WorkShopEmployeeName = EmpName;




			db.WorkShop_Tbl.Add(a1);
			db.SaveChanges();
			this.Title = "Employee Add";

			WorkD.Text = "";
			WorkN.Text = "";
			Ecombo.Text = "";
			

			this.Title = "sucsses";
			UpdateDGV();
			updateCB();

		}

		private void Delete_Click(object sender, RoutedEventArgs e)
		{
			db.WorkShop_Tbl.Remove((WorkShop_Tbl)work_tbl.SelectedItem);
			db.SaveChanges();
			UpdateDGV();
			updateCB();
		}

		private void Update_Click(object sender, RoutedEventArgs e)
		{
			WorkShop_Tbl a1 = (WorkShop_Tbl)CB.SelectedItem;
			WorkShop_Tbl a2 = (from s in db.WorkShop_Tbl where s.WorkShopId == a1.WorkShopId select s).FirstOrDefault();
			a2.WorkShopDate = WorkD.Text;
			a2.WorkShopName = WorkN.Text;
			a2.WorkShopEmployee = (Ecombo.SelectedItem as Employees_Tbl).EmpId;
			a2.WorkShopEmployeeName = (Ecombo.SelectedItem as Employees_Tbl).EmpName;


			db.SaveChanges();
			updateCB();
			UpdateDGV();
		}

		private void CB_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			WorkShop_Tbl a1 = (WorkShop_Tbl)CB.SelectedItem;
			if (a1 == null)
			{
				WorkN.Text = "";
				WorkD.Text = "";
				Ecombo.Text = "";
				
				return;

			}
			WorkN.Text = a1.WorkShopName;
			WorkD.Text = a1.WorkShopDate;
			Ecombo.Text = a1.Employees_Tbl.EmpName;
			
		}

		private void OnLoad(object sender, RoutedEventArgs e)
		{
			UpdateDGV();
			updateCB();

		}
		private void UpdateDGV()
		{
			dbEntities db1 = new dbEntities();
			db = db1;
			List<WorkShop_Tbl> lst = (from s in db.WorkShop_Tbl select s).ToList();
			work_tbl.ItemsSource = lst;
			work_tbl.Columns[0].Visibility = Visibility.Hidden;
			/* פעולה לעדכון הטבלה*/

		}
		private void updateCB()
		{
			/*עדכון קומבובוקס*/

			CB.ItemsSource = null;
			CB.Text = "";

			List<WorkShop_Tbl> lst = (from s in db.WorkShop_Tbl select s).ToList();
			CB.ItemsSource = lst;
			CB.DisplayMemberPath = "WorkShopName";
			CB.SelectedValuePath = "WorkShopId";

			Ecombo.ItemsSource = GetEmployees();
			Ecombo.DisplayMemberPath = "EmpName";
		}
		public List<Employees_Tbl> GetEmployees()
		{
			return db.Employees_Tbl.ToList();
		}
	}
}
