using System.Drawing;

namespace Abstract_classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle(Convert.ToDouble(txtlongitud.Text), Convert.ToDouble(txtancho.Text));

            MessageBox.Show("Area of rectangle: " + rectangle.Calculatearea() + "\n" +
               "Perimeter of the rectangle: " + rectangle.Calculateperimeter());


        }

       
    }
}
