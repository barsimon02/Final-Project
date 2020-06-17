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
    /// Interaction logic for Expense.xaml
    /// </summary>
    public partial class Expense : Window
    {
		dbEntities db = new dbEntities();
		public Expense()
        {
            InitializeComponent();
        }

		private void OnLoad2(object sender, RoutedEventArgs e)
		{
			UpdateDGV();
			updateCB();
		}

		private void CB_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Expense_Tbl a1 = (Expense_Tbl)CB.SelectedItem;
			if (a1 == null)
			{
				ExpD.Text = "";
				ExpA.Text = "";
				ProdCombo.Text = "";

				return;

			}
			ExpA.Text = a1.ExpenseAmount.ToString();
			ExpD.Text = a1.ExpenseDate;
			ProdCombo.Text = a1.Product_tbl.ProdName;
		}

		private void Add_Click(object sender, RoutedEventArgs e)
		{
			int Price = (ProdCombo.SelectedItem as Product_tbl).ProdPrice;
			int Amount = Convert.ToInt32(ExpA.Text);
			String Date = ExpD.Text;
			String Pname = (ProdCombo.SelectedItem as Product_tbl).ProdName;
			int Id;
			try { Id = (ProdCombo.SelectedItem as Product_tbl).ProdId; }
			catch
			{
				this.Title = "Erorr";
				return;
			}
			int Sum = Price * Amount;
			
			/*בודק שהוכנסו כל הנתונים שהם חובה
			   EmpN name of textBox*/
			if (ExpA.Text == "" || ExpD.Text == "")
			{
				this.Title = "Erorr";
				return;
			}
			/*   שומר את הנתונים שהוקלדו והוכנסו אל המשתנים המתאימים בטבלה
		 EmpName השם של העמודה בטבלה*/
			Expense_Tbl a1 = new Expense_Tbl();
			a1.ExpenseDate = Date;
			a1.ExpenseAmount = Amount;
			a1.ExpenseProductId = Id;
			a1.ExpenseSum = Sum;
			a1.ExpenseProductName = Pname;
			



			db.Expense_Tbl.Add(a1);
			db.SaveChanges();
			this.Title = "Employee Add";

			ExpD.Text = "";
			ExpA.Text = "";
			ProdCombo.Text = "";


			this.Title = "sucsses";
			UpdateDGV();
			updateCB();

		}

		private void Update_Click(object sender, RoutedEventArgs e)
		{
			Expense_Tbl a1 = (Expense_Tbl)CB.SelectedItem;
			Expense_Tbl a2 = (from s in db.Expense_Tbl where s.ExpenseProductId == a1.ExpenseProductId select s).FirstOrDefault();
			a2.ExpenseDate = ExpD.Text;
			a2.ExpenseAmount = Convert.ToInt32(ExpA.Text);
			a2.ExpenseProductId = (ProdCombo.SelectedItem as Product_tbl).ProdId;
			a2.ExpenseProductName = (ProdCombo.SelectedItem as Product_tbl).ProdName;
			a2.ExpenseSum = Convert.ToInt32(ExpA.Text) * (ProdCombo.SelectedItem as Product_tbl).ProdPrice;

			db.SaveChanges();
			updateCB();
			UpdateDGV();
		}

		private void Delete_Click(object sender, RoutedEventArgs e)
		{
			db.Expense_Tbl.Remove((Expense_Tbl)exp_tbl.SelectedItem);
			db.SaveChanges();
			UpdateDGV();
			updateCB();
		}
		private void UpdateDGV()
		{
			dbEntities db1 = new dbEntities();
			db = db1;
			List<Expense_Tbl> lst = (from s in db.Expense_Tbl select s).ToList();
			exp_tbl.ItemsSource = lst;
			exp_tbl.Columns[0].Visibility = Visibility.Hidden;
			/* פעולה לעדכון הטבלה*/

		}
		private void updateCB()
		{
			/*עדכון קומבובוקס*/

			CB.ItemsSource = null;
			CB.Text = "";

			List<Expense_Tbl> lst = (from s in db.Expense_Tbl select s).ToList();
			CB.ItemsSource = lst;
			CB.DisplayMemberPath = "ExpenseDate";
			CB.SelectedValuePath = "ExpenseId";

			ProdCombo.ItemsSource = GetProduct_s();
			ProdCombo.DisplayMemberPath = "ProdName";
		}
		public List<Product_tbl> GetProduct_s()
		{
			return db.Product_tbl.ToList();
		}
	}
}
