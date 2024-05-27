using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anidex
{
    public partial class miniQuizz : Form
    {
        int nbIndice = 0;
        public miniQuizz()
        {
            InitializeComponent();
            lblNbYeux.Visible = false;
            lblInfoNbYeux.Visible = false;
        }

        private void btnIndice_Click(object sender, EventArgs e)
        {
            nbIndice++;

            if (nbIndice > 0) 
            {
                lblNbYeux.Visible = true;
                lblInfoNbYeux.Visible = true;

            }
            if (nbIndice > 1)
            {
                lblActiviter.Visible = true;
                lblInfoActiviter.Visible=true;
            }
            if(nbIndice > 2)
            {
                lblRace.Visible = true;
                lblInfoRace.Visible = true;
            }
        }
    }
}
