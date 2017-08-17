using DevExpress.XtraBars;
using DevExpress.XtraMap;
using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Map;

namespace LojicFloorboard_FormsApp
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CoordPoint initCenter;
        public double initZoom;
        public bool addingPoints = false;
        public string fileName = @"Data\Points.xml";
        public Points pts = new Points();
        protected override void OnLoad(EventArgs e)
        {
            initCenter = mapControl1.CenterPoint;
            initZoom = mapControl1.ZoomLevel;
            XMLWriter xmlwr = new XMLWriter();
            Points data = xmlwr.LoadPoints(fileName);
            if(data != null){
                VectorItemsLayer pointsLayer = vectorItemsLayer4;
                MapItemStorage storage = new MapItemStorage();
                foreach (Point pt in data._Points)
                {
                    AddPoint(pt);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        void bbiInitialView_ItemClick(object sender, ItemClickEventArgs e)
        {
            mapControl1.ZoomLevel = initZoom;
            mapControl1.CenterPoint = initCenter;
        }
        void bbiZoomOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            mapControl1.ZoomOut();
        }
        void bbiZoomIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            mapControl1.ZoomIn();
        }
        void chkLockNavigation_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            mapControl1.EnableScrolling = !mapControl1.EnableScrolling;
            mapControl1.EnableZooming = !mapControl1.EnableZooming;
            bbiZoomIn.Enabled = mapControl1.EnableZooming;
            bbiZoomOut.Enabled = mapControl1.EnableZooming;
        }
        void chkShowNavPanel_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            mapControl1.NavigationPanelOptions.Visible = !mapControl1.NavigationPanelOptions.Visible;
        }
        void chkShowMiniMap_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            mapControl1.MiniMap.Visible = !mapControl1.MiniMap.Visible;
        }
        void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (mapControl1.Legends.Count > 0)
            {
                if (mapControl1.Legends[0].Visibility == VisibilityMode.Auto)
                    mapControl1.Legends[0].Visibility = VisibilityMode.Hidden;
                else
                    mapControl1.Legends[0].Visibility = VisibilityMode.Auto;
            }
        }
        static string GetRelativePath(string name)
        {
            name = "Data\\" + name;
            string path = Application.StartupPath;
            string s = "\\";
            for (int i = 0; i <= 10; i++)
            {
                if (System.IO.File.Exists(path + s + name))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            return "";
        }
        private void mapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (addingPoints)
            {
                CoordPoint pt = this.mapControl1.ScreenPointToCoordPoint(new MapPoint(e.X, e.Y));
                PointsPrompt prompt = new PointsPrompt();
                prompt.longi = pt.GetX();
                prompt.lati = pt.GetY();
                prompt.ParentForm = this;
                prompt.Show();
                prompt.Location = e.Location;
            }
        }
        private void mapControl1_ItemClicked(object sender,MapItemClickEventArgs e)
        {
            if(e.MouseArgs.Button == MouseButtons.Right)
            {
                MessageBox.Show("Right Clicked Marker");
            }
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            addingPoints = !addingPoints;
            barButtonItem1.Down = addingPoints;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            //Write all points that were created to an XML file
            XMLWriter xmlwr = new XMLWriter();
            xmlwr.SavePoints(pts);
        }
        public void AddPoint(Point newPoint) {
            MapItemStorage storage = new MapItemStorage();
            pts.Add(newPoint);
            CoordPoint point = this.mapControl1.CoordinateSystem.CreatePoint(newPoint.Longitude, newPoint.Latitude);
            VectorItemsLayer pointsLayer = vectorItemsLayer4;
            if (pointsLayer.Data == null)
            {
                pointsLayer.Data = storage;
            }
            else
            {
                storage = pointsLayer.Data as MapItemStorage;
            }
            storage.Items.Add(new MapPushpin() { Location = point, ToolTipPattern = newPoint.Type.ToString()+": "+newPoint.name});
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Add Floor Button
            //When this is pressed make sure to turn off the data update function on the final version, else the program would be doing unnecessary actions 
            ribbonPage2.Visible = true;
            ribbonPage1.Visible = false;
            mapControl1.Visible = false;
            splitContainerControl1.Visible = true;
            ribbonControl1.SelectedPage = ribbonPage2;
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Save and export floor, add the floor and all pertinent info to the program
            //Each floor as a new Mapcontrol???? or just new layers in mapControl1? <---
            ribbonPage1.Visible = true;
            mapControl1.Visible = true;
            ribbonControl1.SelectedPage = ribbonPage1;
            splitContainerControl1.Visible = false;
            ribbonPage2.Visible = false;
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Cancel Adding a new floor, simple dispose and close
            ribbonPage1.Visible = true;
            mapControl1.Visible = true;
            ribbonControl1.SelectedPage = ribbonPage1;
            splitContainerControl1.Visible = false;
            ribbonPage2.Visible = false;
        }
        private void Form1_OnResize(object sender, System.EventArgs e) {
            Control control = (Control)sender;
            splitContainerControl1.SplitterPosition = control.Width/2;
        }
    }
}
