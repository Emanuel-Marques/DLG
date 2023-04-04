using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLG_Project
{
    public partial class Frm_Menu : Form
    {
        Form splash;
        public Frm_Menu(Form f)
        {
             splash = f;
            InitializeComponent();
        }

        private void btn_youtube_Click(object sender, EventArgs e)
        {
            string canalYoutube = "https://www.youtube.com/@dctechangola1781";

            System.Diagnostics.Process.Start(canalYoutube);
        }

        private void btn_instagram_Click(object sender, EventArgs e)
        {
            string perfilInstagram = "https://www.instagram.com/dctechangola585";

            System.Diagnostics.Process.Start(perfilInstagram);        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
            splash.Close();
        }
    }
}
