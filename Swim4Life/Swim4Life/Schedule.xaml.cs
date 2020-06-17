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
    /// Interaction logic for Schedule.xaml
    /// </summary>
    public partial class Schedule : Window
    {
		dbEntities db = new dbEntities();
		public Schedule()
        {
            InitializeComponent();
        }

		private void CB_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Schedule_Tbl a1 = (Schedule_Tbl)CB.SelectedItem;
			if (a1 == null)
			{
				Pcombo.Text = "";
				SchD.Text = "";
				Tcombo.Text = "";

				return;

			}
			Pcombo.Text = a1.Pool;
			SchD.Text = a1.ScheduleDate;
			Tcombo.Text = a1.Team;
		}

		private void ADD(object sender, RoutedEventArgs e)
		{
			int Pid,Tid;
			String Pname = (Pcombo.SelectedItem as Pool_Tbl).PoolName;
			String Date = SchD.Text;
			String Tname = (Tcombo.SelectedItem as Teams_Tbl).TeamName;

			try { Pid = (Pcombo.SelectedItem as Pool_Tbl).PoolId;  Tid = (Tcombo.SelectedItem as Teams_Tbl).TeamId; }
			catch
			{
				this.Title = "Erorr";
				return;
			}

			/*בודק שהוכנסו כל הנתונים שהם חובה
			   EmpN name of textBox*/
			if (SchD.Text == "" )
			{
				this.Title = "Erorr";
				return;
			}
			/*   שומר את הנתונים שהוקלדו והוכנסו אל המשתנים המתאימים בטבלה
		 EmpName השם של העמודה בטבלה*/
			Schedule_Tbl a1 = new Schedule_Tbl();
			a1.ScheduleDate = Date;
			a1.Team = Tname;
			a1.ScheduleTeamId = Tid;
			a1.Pool = Pname;
			a1.SchedulePoolId = Pid;




			db.Schedule_Tbl.Add(a1);
			db.SaveChanges();
			this.Title = "schedule Add";

			SchD.Text = "";
			Pcombo.Text = "";
			Tcombo.Text = "";


			this.Title = "sucsses";
			UpdateDGV();
			updateCB();
		}

		private void Delete(object sender, RoutedEventArgs e)
		{
			db.Schedule_Tbl.Remove((Schedule_Tbl)sch_tbl.SelectedItem);
			db.SaveChanges();
			UpdateDGV();
			updateCB();
		}

		private void Update(object sender, RoutedEventArgs e)
		{
			Schedule_Tbl a1 = (Schedule_Tbl)CB.SelectedItem;
			Schedule_Tbl a2 = (from s in db.Schedule_Tbl where s.ScheduleId == a1.ScheduleId select s).FirstOrDefault();
			a2.ScheduleDate = SchD.Text;
			a2.Team = (Tcombo.SelectedItem as Teams_Tbl).TeamName;
			a2.ScheduleTeamId = (Tcombo.SelectedItem as Teams_Tbl).TeamId;
			a2.Pool = (Pcombo.SelectedItem as Pool_Tbl).PoolName;
			a2.SchedulePoolId = (Pcombo.SelectedItem as Pool_Tbl).PoolId;


			db.SaveChanges();
			updateCB();
			UpdateDGV();
		}
		private void UpdateDGV()
		{
			dbEntities db1 = new dbEntities();
			db = db1;
			List<Schedule_Tbl> lst = (from s in db.Schedule_Tbl select s).ToList();
			sch_tbl.ItemsSource = lst;
		    sch_tbl.Columns[0].Visibility = Visibility.Hidden;
			/* פעולה לעדכון הטבלה*/

		}
		private void OnLoad(object sender, RoutedEventArgs e)
		{
			UpdateDGV();
			updateCB();
		}
		private void updateCB()
		{
			/*עדכון קומבובוקס*/

			CB.ItemsSource = null;
			CB.Text = "";

			List<Schedule_Tbl> lst = (from s in db.Schedule_Tbl select s).ToList();
			CB.ItemsSource = lst;
			CB.DisplayMemberPath = "ScheduleDate";
			CB.SelectedValuePath = "ScheduleId";

			Tcombo.ItemsSource = null;
			Tcombo.Text = "";
			Tcombo.ItemsSource = GetTeams_s();
			Tcombo.DisplayMemberPath = "TeamName";
			
			Pcombo.ItemsSource = GetPool();
			Pcombo.DisplayMemberPath = "PoolName";


		}
		public List<Pool_Tbl> GetPool()
		{
			return db.Pool_Tbl.ToList();
		}

		public List<Teams_Tbl> GetTeams_s()
		{
			return db.Teams_Tbl.ToList();
		}

		
	}
}
