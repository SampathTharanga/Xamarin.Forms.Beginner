using SQLite;
using SQLite_DataBase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLite_DataBase
{
	public partial class MainPage : ContentPage
	{
        private SQLiteConnection conn;
        public Student student;
		public MainPage()
		{
			InitializeComponent();

            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Student>();
		}

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            student = new Student();
            student.Name = EntryName.Text;
            student.Address = EntryAddress.Text;
            conn.Insert(student);
            EntryName.Text = "";
            EntryAddress.Text = "";
        }

        private void btnShow_Clicked(object sender, EventArgs e)
        {
            var data = (from stu in conn.Table<Student>() select stu);
            DataList.ItemsSource = data;
        }

    }
}
