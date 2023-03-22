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

            string name = this.tbName.Text;
            string brithYear = this.tbBirthyear.Text;
            string GPA = tbGpa.Text;
            int iYear = Int32.Parse(brithYear);
            double G = Double.Parse(GPA);

            Bona bona = new Bona(name,iYear,G);
            this.classroom.addBona2Class(bona);

            this.tbName.Text = this.classroom.showAllBonainClass();
            this.tbTotal.Text = this.classroom.TotalAge().ToString();
            this.tbAvg.Text = this.classroom.AvgGPA().ToString();
            this.tbMax.Text = this.classroom.MaxGPA().ToString();
            this.tbMin.Text = this.classroom.MinGPA().ToString();
            this.tbNameHigh.Text = this.classroom.MaxHigh().ToString();
            //this.tbNameLow.Text = this.classroom.LowHigh().ToString();

            this.tbName.Text = "";
            this.tbBirthyear.Text = "";
            this.tbGpa.Text = "";
        }
    }
}