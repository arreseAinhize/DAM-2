namespace Ariketa_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnEsaldi1.Enabled = true;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnGarbitu.Enabled = false;
            btnLotu.Enabled = false;
        }
        //public string esaldiOsoa ="";
        Esaldia esaldia = new Esaldia();

        private void btnEsaldi1_Click(object sender, EventArgs e)
        {
            esaldia.SetEsaldiaBatuta(tbEsaldia.Text.ToString());
            /*Esaldia esaldia = new Esaldia(tbEsaldia.Text);
            EsaldiOsoa(esaldia);*/
            btnEsaldi1.Enabled = false;
            btnEsaldi2.Enabled = true;
            tbEsaldia.Clear();
        }

        /*private void EsaldiOsoa(Esaldia esaldia)
        {
            esaldiOsoa += esaldia.EsaldiaBatuta;
        }
        */
        private void btnEsaldi2_Click(object sender, EventArgs e)
        {
            esaldia.SetEsaldiaBatuta(tbEsaldia.Text.ToString());

            //Esaldia esaldia = new Esaldia(tbEsaldia.Text);
            //EsaldiOsoa(esaldia);
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = true;
            tbEsaldia.Clear();
        }

        private void btnEsaldi3_Click(object sender, EventArgs e)
        {
            //Esaldia esaldia = new Esaldia(tbEsaldia.Text);
            //EsaldiOsoa(esaldia);
            esaldia.SetEsaldiaBatuta(tbEsaldia.Text.ToString());

            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = true;
            tbEsaldia.Clear();
        }

        private void btnEsaldi4_Click(object sender, EventArgs e)
        {
            //Esaldia esaldia = new Esaldia(tbEsaldia.Text);
            //EsaldiOsoa(esaldia);
            esaldia.SetEsaldiaBatuta(tbEsaldia.Text.ToString());

            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = true;
            tbEsaldia.Clear();
        }

        private void btnEsaldi5_Click(object sender, EventArgs e)
        {
            //Esaldia esaldia = new Esaldia(tbEsaldia.Text);
            //EsaldiOsoa(esaldia);
            esaldia.SetEsaldiaBatuta(tbEsaldia.Text.ToString());

            btnEsaldi5.Enabled = false;
            btnLotu.Enabled = true;
            btnGarbitu.Enabled = true;
            tbEsaldia.Clear();
        }

        private void btnLotu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(esaldia.esaldiaBatuta);
        }

        private void btnGarbitu_Click(object sender, EventArgs e)
        {
            esaldiOsoa = "";
            tbEsaldia.Clear();
            btnEsaldi1.Enabled = true;
            btnEsaldi2.Enabled = false;
            btnEsaldi3.Enabled = false;
            btnEsaldi4.Enabled = false;
            btnEsaldi5.Enabled = false;
            btnGarbitu.Enabled = false;
            btnLotu.Enabled = false;
        }
    
        /*
         * 
         */
    }
}
