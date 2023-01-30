using System.IO.Pipes;

namespace Lab4
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void m1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void n_Click(object sender, EventArgs e)
        {
            string input_name = this.m1.Text;
            string input_year = this.m2.Text;
            int iYear = Int32.Parse(input_year);

            Bona bona = new Bona(input_name, iYear);
            this.classroom.addBona2Class(bona);
            this.m4.Text = this.classroom.showAllBonainClass();
            this.m3.Text = this.classroom.showAllBonainClass();
        }
    }
}