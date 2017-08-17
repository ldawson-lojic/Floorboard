using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojicFloorboard_FormsApp
{
    public partial class PointsPrompt : Form
    {
        public Point point;
        public string Nom = null;
        public string Type = null;
        public double longi = 0;
        public double lati = 0;
        public Form1 ParentForm;
        public PointsPrompt()
        {
            InitializeComponent();
        }

        private void PointsPrompt_Load(object sender, EventArgs e)
        {
            LongValue.Text = longi.ToString();
            LatValue.Text = lati.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Nom = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Name != null && Type != null) {
                //Build a point and send it to the parent form
                Point newPoint = new Point(LO: longi, LA: lati, _name: Nom, _type: Type);
                ParentForm.AddPoint(newPoint);
                Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type = comboBox1.Text;
        }
    }
}
