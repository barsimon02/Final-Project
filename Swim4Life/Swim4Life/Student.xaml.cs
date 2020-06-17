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
	/// Interaction logic for Student.xaml
	/// </summary>
	public partial class Student : Window
	{
		dbEntities db = new dbEntities();
		public Student()
		{
			InitializeComponent();
		}

		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Students_Tbl a1 = (Students_Tbl)CB.SelectedItem;
			if (a1 == null)
			{
				StuN.Text = "";
				StuM.Text = "";
				StuP.Text = "";
				StuAdd.Text = "";
				StuAge.Text = "";
				return;

			}
			StuN.Text = a1.StudentName;
			StuM.Text = a1.StudentMail;
			StuP.Text = a1.StudentPhone;
			StuAdd.Text = a1.StudentAddress;
			StuAge.Text = a1.StudentAge;
		}

			private void Add_Click(object sender, RoutedEventArgs e)
			{
				String Name = StuN.Text;
				String Email = StuM.Text;
				String Phone = StuP.Text;
				String Age = StuAge.Text;
				String Address = StuAdd.Text;





				/*בודק שהוכנסו כל הנתונים שהם חובה
				   EmpN name of textBox*/
				if (StuN.Text == "" || StuAge.Text == "" || StuP.Text == "" || StuAdd.Text == "")
				{
					this.Title = "Erorr";
					return;
				}
				/*   שומר את הנתונים שהוקלדו והוכנסו אל המשתנים המתאימים בטבלה
			 EmpName השם של העמודה בטבלה*/
				Students_Tbl a1 = new Students_Tbl();
				a1.StudentName = Name;
				a1.StudentMail = Email;
				a1.StudentPhone = Phone;
				a1.StudentAge = Age;
				a1.StudentAddress = Address;



				db.Students_Tbl.Add(a1);
				db.SaveChanges();
				this.Title = "Employe Add";

				StuN.Text = "";
				StuM.Text = "";
				StuP.Text = "";
				StuAdd.Text = "";
				StuAge.Text = "";

				this.Title = "sucsses";
				UpdateDGV();
				updateCB();

			}

			private void Delete_Click(object sender, RoutedEventArgs e)
			{
				db.Students_Tbl.Remove((Students_Tbl)stu_tbl.SelectedItem);
				db.SaveChanges();
				UpdateDGV();
				updateCB();
			}

			private void Update_Click(object sender, RoutedEventArgs e)
			{
				Students_Tbl a1 = (Students_Tbl)CB.SelectedItem;
				Students_Tbl a2 = (from s in db.Students_Tbl where s.StudentId == a1.StudentId select s).FirstOrDefault();
				a2.StudentName = StuN.Text;
				a2.StudentMail = StuM.Text;
				a2.StudentAddress = StuAdd.Text;
				a2.StudentAge = StuAge.Text;
				a2.StudentPhone = StuP.Text;

				db.SaveChanges();
				updateCB();
				UpdateDGV();

			}
			private void UpdateDGV()
			{
				dbEntities db1 = new dbEntities();
				db = db1;
				List<Students_Tbl> lst = (from s in db.Students_Tbl select s).ToList();
				stu_tbl.ItemsSource = lst;
				stu_tbl.Columns[0].Visibility = Visibility.Hidden;
				/* פעולה לעדכון הטבלה*/

			}
			private void updateCB()
			{
				/*עדכון קומבובוקס*/

				CB.ItemsSource = null;
				CB.Text = "";

				List<Students_Tbl> lst = (from s in db.Students_Tbl select s).ToList();
				CB.ItemsSource = lst;
				CB.DisplayMemberPath = "StudentName";
				CB.SelectedValuePath = "StudentId";
			}

			private void OnLoad(object sender, RoutedEventArgs e)
			{
				UpdateDGV();
				updateCB();
			}
		}
	} 
