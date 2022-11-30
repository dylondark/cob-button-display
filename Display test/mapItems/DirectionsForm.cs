using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Display_test
{
    public partial class DirectionsForm : Form
    {
        MapPrototype1 map;
        /// <summary>
        /// These properties determine the images shown for each map. Add a new map image with the suffix names( eg. classRoomsMap) to resources and then update the variables here
        /// </summary>
        static Image classroomMap = global::Display_test.Properties.Resources.afc75c31b7b923e88ce28b34d4a25c20__rpg_map_dungeon_maps;
        static Image goodYearRoomMap = global::Display_test.Properties.Resources.good_year_map;
        static  Image advisingRoomMap = global::Display_test.Properties.Resources.good_year_map1;

        public DirectionsForm( )
        {
            InitializeComponent();
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           showMap(classroomMap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showMap(goodYearRoomMap);

        }

        private void button3_Click(object sender, EventArgs e)
        {
           showMap(advisingRoomMap);
        }

        private void button4_Click(object sender, EventArgs e)
        {
          closeMap();  
        }

        void showMap(Image image)
        {
            if(image == null)
            {
                Debug.WriteLine("empty image");
                return;
            }

            if (image != null)
            {
                //lazy loading
                if(map == null || map.IsDisposed)
                {
                    map = new MapPrototype1(image);

                } else
                {
                    map.setImage(image);
                }


                map.Show();
            }
        }

        void closeMap()
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
