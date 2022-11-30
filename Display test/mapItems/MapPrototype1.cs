using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_test
{
    public partial class MapPrototype1 : Form
    {
 

        public MapPrototype1(Image mapImage)
        {

            InitializeComponent();
            this.panel1.BackgroundImage = mapImage;

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       public void setImage(Image image)
        {
            panel1.BackgroundImage = image;
        }

        private void MapPrototype1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
