using System.IO.Pipes;

namespace Lab4
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        Bona b;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }
        private void n_Click(object sender, EventArgs e)
        {
            string name = this.m1.Text;
            string brithYear = this.m2.Text;
            string GPA = this.gpa.Text;
            int iYear = Int32.Parse(brithYear);
            double g = Double.Parse(GPA);
            //
            Bona bona = new Bona(name,iYear, g);
            this.classroom.addBona2Class(bona);


            this.m1.Text = this.classroom.showAllBonainClass();
            this.m2.Text = this.classroom.m3Age().ToString();
            //this.Max.Text = this.classroom.maxgpa().ToString();
            //  double a = this.classroom.avggpa();
            // double b = Convert.To(this.classroom.avggpa());
            this.avg.Text = this.classroom.avggpa().ToString();
            this.max.Text = this.classroom.maxGPA().ToString();
            this.min.Text = this.classroom.minGPA().ToString();
            this.Nmax.Text = this.classroom.max().ToString();
            //this.NMin.Text = this.classroom.minGPA().ToString();

            this.m1.Text = "";
            this.m2.Text = "";
            this.gpa.Text = "";
        }
    }
}