using MySql.Data.MySqlClient;

namespace anidex
{
    public partial class Form1 : Form
    {
        private miniQuizz frmQuizz;
        private recherche frmrecherche;
        public Form1()
        {
            InitializeComponent();
            frmQuizz = new miniQuizz();
            frmrecherche = new recherche();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            rechercher();
        }

        private void btnQuizz_Click(object sender, EventArgs e)
        {
            pageMiniquizz();
        }
        private void pageMiniquizz()
        {
            DialogResult resultat = frmQuizz.ShowDialog();
            if (resultat == DialogResult.OK)
            {

            }
        }

        private void rechercher()
        {
            DialogResult resultat = frmrecherche.ShowDialog();
            if (resultat == DialogResult.OK)
            {

            }
        }
        private static void ReadOrderData()
        {
            string queryString = "SELECT * FROM anidex;";

        }
    }
}
