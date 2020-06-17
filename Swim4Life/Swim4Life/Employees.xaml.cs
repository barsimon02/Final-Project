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
    /// Interaction logic for Employees.xaml
    /// </summary>
    public partial class Employees : Window
    {
		/*database גישה */
		dbEntities db = new dbEntities();
        public Employees()
        {
            InitializeComponent();
	
        }

      private void UpdateDGV()
        {
            dbEntities db1 = new dbEntities();
			db = db1;
			List<Employees_Tbl> lst = (from s in db.Employees_Tbl select s).ToList();
			emp_tbl.ItemsSource = lst;
			emp_tbl.Columns[0].Visibility = Visibility.Hidden;
			/* פעולה לעדכון הטבלה*/

		}
   
     private void Add_Click(object sender, RoutedEventArgs e)
     {
		/*מעביר את הנתונים שהוכנסו למשתנה מתאים
		 EmpN name of textBox*/
			String Name = EmpN.Text;
			String Email = EmpE.Text;
			String Phone = EmpP.Text;
			String Function = EmpF.Text;
			String Address = EmpA.Text;
			
	
			



			/*בודק שהוכנסו כל הנתונים שהם חובה
			   EmpN name of textBox*/
			if (EmpN.Text == "" || EmpF.Text == "" || EmpP.Text == "" || EmpA.Text == "")
			{
				this.Title = "Erorr";
				return;
			}
			/*   שומר את הנתונים שהוקלדו והוכנסו אל המשתנים המתאימים בטבלה
		 EmpName השם של העמודה בטבלה*/
			Employees_Tbl a1 = new Employees_Tbl();
			a1.EmpName = Name;
			a1.EmpMail = Email;
			a1.EmpPhone =Phone;
			a1.EmpFunction = Function;
			a1.EmpAddress = Address;
			
			
			
			

			db.Employees_Tbl.Add(a1);
			db.SaveChanges();
			this.Title = "Employe Add";

			EmpN.Text = "";
			EmpE.Text = "";
			EmpP.Text = "";
			EmpF.Text = "";
			EmpA.Text = "";
			
			this.Title = "sucsses";
			UpdateDGV();
			updateCB();
		}

        private void Update_Click(object sender, RoutedEventArgs e)
        {
			Employees_Tbl a1 = (Employees_Tbl)CB.SelectedItem;
			Employees_Tbl a2 = (from s in db.Employees_Tbl where s.EmpId == a1.EmpId select s).FirstOrDefault();
			a2.EmpName = EmpN.Text;
			a2.EmpMail = EmpE.Text;
			a2.EmpAddress = EmpA.Text;
			a2.EmpFunction = EmpF.Text;
			a2.EmpPhone = EmpP.Text;
			
			db.SaveChanges();
			updateCB();
			UpdateDGV();
		}

		private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void OnLoad(object sender, RoutedEventArgs e)
		{
			/*כאשר המסך נפתח*/
			UpdateDGV();
			updateCB();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			/*לחיצה על מחיקה*/
			db.Employees_Tbl.Remove((Employees_Tbl)emp_tbl.SelectedItem);
			db.SaveChanges();
			UpdateDGV();
			updateCB();
		}
		private void updateCB()
		{
			/*עדכון קומבובוקס*/
			 
			CB.ItemsSource = null;
			CB.Text = "";

			List<Employees_Tbl> lst = (from s in db.Employees_Tbl select s).ToList();
			CB.ItemsSource = lst;
			CB.DisplayMemberPath = "EmpName";
			CB.SelectedValuePath = "EmpId";

			

			



		}

		private void CB_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			/* combobox change*/
			Employees_Tbl a1 = (Employees_Tbl)CB.SelectedItem;
			if (a1 == null)
			{
				EmpN.Text = "";
				EmpE.Text = "";
				EmpP.Text = "";
				EmpF.Text = "";
				EmpA.Text = "";
				return;

			}
			EmpN.Text =a1.EmpName;
			EmpE.Text =a1.EmpMail;
			EmpP.Text =a1.EmpPhone;
			EmpF.Text =a1.EmpFunction;
			EmpA.Text = a1.EmpAddress;
		}
		
	}	
}
