using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carro
{
    public partial class GifLuces : Form
    {

        public GifLuces()
        {
            InitializeComponent();
            luces.Visible = true;
              
        }

        private void GifLuces_Load(object sender, EventArgs e)
        {
            luces.Visible = true;
        }

    
    }
}
