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
        private void n_Click(object sender, EventArgs e)
        {
            string name = this.m1.Text;
            string brithYear = this.m2.Text;
            string GPA = gpa.Text;
            int iYear = Int32.Parse(brithYear);
            double g = Double.Parse(GPA);

            Bona bona = new Bona(name, iYear, g);
            this.classroom.addBona2Class(bona);
            this.m3.Text = this.classroom.m3Age().ToString();
            this.m4.Text = this.classroom.showAllBonainClass();
            int A = Int32.Parse(this.m3.Text);
            int T = A + bona.getAge();
            

            this.m1.Text = "";
            this.m2.Text = "";
            this.gpa.Text = "";
        }
    }
}