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
using _point = Tekla.Structures.Geometry3d.Point;
using System.Collections;

namespace ALesson1
{
    public partial class Form1 : Form
    {
        Tekla.Structures.Model.Model model = new Tekla.Structures.Model.Model();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tekla.Structures.Model.UI.Picker pick = new tsm.UI.Picker();
            _point start = pick.PickPoint("Pick the starting point");
            _point end = pick.PickPoint("Pick the starting point");
            create_beam(start, end);
            model.CommitChanges();
            MessageBox.Show("Done");
        }
        private void create_beam(_point start, _point end)
        {
            tsm.Beam b1 = new tsm.Beam(start, end);
            b1.Profile.ProfileString = "WI300-15-20*300";
            //b1.StartPoint = start;
            //b1.EndPoint = end;

            b1.Insert();
            model.CommitChanges();
        }

        private void create_polybeam(string profile)
        {
            tsm.UI.Picker _pick = new tsm.UI.Picker();
            ArrayList points = _pick.PickPoints(tsm.UI.Picker.PickPointEnum.PICK_POLYGON, "Please Pick PolyPoint");
            ArrayList contourpoints = new ArrayList();
            foreach (_point xx in points)
            {
                tsm.ContourPoint cp = new tsm.ContourPoint(xx, new tsm.Chamfer());
                contourpoints.Add(cp);
            }

            tsm.ContourPlate cpplate = new tsm.ContourPlate();
            cpplate.Contour.ContourPoints = contourpoints;
            cpplate.Profile.ProfileString = profile;
            cpplate.Material.MaterialString = "S275JR";
            cpplate.Class = "99";
            cpplate.Insert();
            model.CommitChanges();
            MessageBox.Show("Done");
        }

        private void create_polybeam_click_Click(object sender, EventArgs e)
        {
            create_polybeam(profile_text.Text);
        }
    }
}
