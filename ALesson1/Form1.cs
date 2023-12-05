using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tsm = Tekla.Structures.Model;

namespace ALesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("yoyoyo this is moog");
            Tekla.Structures.Model.Model model = new Tekla.Structures.Model.Model();
            tsm.Beam b1 = new tsm.Beam();
            b1.Profile.ProfileString = "WI300-15-20*300";
            b1.StartPoint = new Tekla.Structures.Geometry3d.Point(0, 0, 0);
            b1.EndPoint = new Tekla.Structures.Geometry3d.Point(6000, 0, 0);
            b1.Insert();
            model.CommitChanges();
        }
    }
}
