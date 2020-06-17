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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Swim4Life
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		dbEntities db = new dbEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Employee_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Employees employees = new Employees();
            employees.ShowDialog();
            this.Show();
			

        }
		
		

        private void Expense_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Expense expense = new Expense();
            expense.ShowDialog();
            this.Show();
        }

        private void Product_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.ShowDialog();
            this.Show();
        }

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			
		}

		private void schedule(object sender, RoutedEventArgs e)
		{
			this.Hide();
			Schedule schedule = new Schedule();
			schedule.ShowDialog();
			this.Show();
		}

		private void student_Click(object sender, RoutedEventArgs e)
		{
			this.Hide();
			Student student = new Student();
			student.ShowDialog();
			this.Show();
		}

		private void Team_Click(object sender, RoutedEventArgs e)
		{
			this.Hide();
			Teams teams = new Teams();
			teams.ShowDialog();
			this.Show();
		}

		private void WorkShop_Click(object sender, RoutedEventArgs e)
		{
			this.Hide();
			WorkShop work = new WorkShop();
			work.ShowDialog();
			this.Show();
		}

		private void pool_Click_3(object sender, RoutedEventArgs e)
		{
			this.Hide();
			Pool pool = new Pool();
			pool.ShowDialog();
			this.Show();
		}
	}
}
