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
        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string name = this.tbName.Text;
            string brithYear = this.tbBirthyear.Text;
            string GPA = tbGpa.Text;
            int iYear = Int32.Parse(brithYear);
            double G = Double.Parse(GPA);

            Bona bona = new Bona(name,iYear,G);
            this.classroom.addBona2Class(bona);
=======
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
>>>>>>> 31fc71cd702b345d4dd4929e6db332336a46b75c

            this.tbName.Text = this.classroom.showAllBonainClass();
            this.tbTotal.Text = this.classroom.TotalAge().ToString();
            this.tbAvg.Text = this.classroom.AvgGPA().ToString();
            this.tbMax.Text = this.classroom.MaxGPA().ToString();
            this.tbMin.Text = this.classroom.MinGPA().ToString();
            this.tbNameHigh.Text = this.classroom.MaxB().ToString();


            this.tbName.Text = "";
            this.tbBirthyear.Text = "";
            this.tbGpa.Text = "";
        }
    }
}