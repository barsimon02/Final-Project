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
    /// Interaction logic for Teams.xaml
    /// </summary>
    public partial class Teams : Window
    {
		dbEntities db = new dbEntities();
		public Teams()
        {
            InitializeComponent();
        }

		private void Add_click(object sender, RoutedEventArgs e)
		{
			String Name = TeamN.Text;
			String Date = TeamS.Text;
			String Level  = TeamL.Text;
			String Ename = (Ecombo.SelectedItem as Employees_Tbl).EmpName;
			int Emp = (Ecombo.SelectedItem as Employees_Tbl).EmpId;
			

			/*בודק שהוכנסו כל הנתונים שהם חובה
			   EmpN name of textBox*/
			if (TeamL.Text == "" || TeamN.Text == ""||Ecombo.Text=="")
			{
				this.Title = "Erorr";
				return;
			}
			/*   שומר את הנתונים שהוקלדו והוכנסו אל המשתנים המתאימים בטבלה
		 EmpName השם של העמודה בטבלה*/
			Teams_Tbl a1 = new Teams_Tbl();
			a1.TeamStartDate = Date;
			a1.TeamName = Name;
			a1.TeamEmployee =Emp ;
			a1.TeamLevel = Level;
			a1.TeamEmployeeName = Ename;


			db.Teams_Tbl.Add(a1);
			db.SaveChanges();
			this.Title = "Employee Add";

			TeamS.Text = "";
			TeamN.Text = "";
			Ecombo.Text = "";
			TeamL.Text = "";

			this.Title = "sucsses";
			UpdateDGV();
			updateCB();
		}

		private void Delete_Click(object sender, RoutedEventArgs e)
		{
			db.Teams_Tbl.Remove((Teams_Tbl)team_tbl.SelectedItem);
			db.SaveChanges();
			UpdateDGV();
			updateCB();
		}

		private void Update_Click(object sender, RoutedEventArgs e)
		{
			Teams_Tbl a1 = (Teams_Tbl)CB.SelectedItem;
			Teams_Tbl a2 = (from s in db.Teams_Tbl where s.TeamId == a1.TeamId select s).FirstOrDefault();
			a2.TeamStartDate = TeamS.Text;
			a2.TeamName = TeamN.Text;
			a2.TeamLevel = TeamL.Text;
			a2.TeamEmployee = (Ecombo.SelectedItem as Employees_Tbl).EmpId;
			a2.TeamEmployeeName = (Ecombo.SelectedItem as Employees_Tbl).EmpName;

			db.SaveChanges();
			updateCB();
			UpdateDGV();
		}

		private void CB_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Teams_Tbl a1 = (Teams_Tbl)CB.SelectedItem;
			if (a1 == null)
			{
				TeamS.Text = "";
				TeamN.Text = "";
				Ecombo.Text = "";
				TeamL.Text = "";

				return;

			}
			TeamN.Text = a1.TeamName;
			TeamS.Text = a1.TeamStartDate;
			if(a1.TeamEmployee==null)
			{
				Ecombo.Text = "";
			}
			else
			{
				Ecombo.Text = a1.Employees_Tbl.EmpName;
			}
			
			
			TeamL.Text = a1.TeamLevel;
		}
		private void UpdateDGV()
		{
			dbEntities db1 = new dbEntities();
			db = db1;
			List<Teams_Tbl> lst = (from s in db.Teams_Tbl select s).ToList();
			team_tbl.ItemsSource = lst;
			team_tbl.Columns[0].Visibility = Visibility.Hidden;
			/* פעולה לעדכון הטבלה*/

		}
		private void updateCB()
		{
			/*עדכון קומבובוקס*/

			CB.ItemsSource = null;
			CB.Text = "";

			List<Teams_Tbl> lst = (from s in db.Teams_Tbl select s).ToList();
			CB.ItemsSource = lst;
			CB.DisplayMemberPath = "TeamName";
			CB.SelectedValuePath = "TeamId";

			Ecombo.ItemsSource = GetEmployees();
			Ecombo.DisplayMemberPath = "EmpName";
		}
		public List<Employees_Tbl> GetEmployees()
		{
			return db.Employees_Tbl.ToList();
		}

		private void OnLoad(object sender, RoutedEventArgs e)
		{
			UpdateDGV();
			updateCB();
		}
	}
}
