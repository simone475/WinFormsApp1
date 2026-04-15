namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //creo ina lista di studenti per memorizzare gli oggetti Studenti aggiunti  
        private List<Studente> studenti = new List<Studente>();

        public Form1()
        {
            InitializeComponent();
        }




        private void btnGeneraCoppie_Click(object sender, EventArgs e)
        {

        }

        private void btnAggiungiStudente_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cognome = txtCognome.Text;
            int annoNascita = int.Parse(txtAnnoNascita.Text);
            string abilita = txtAbilita.Text;
            Studente studente = new Studente(nome, cognome, annoNascita, abilita);
            MessageBox.Show($"Studente aggiunto: {studente.Info()}");
            studenti.Add(studente);

            resetCampi();
            //Metto nella casella di testo il numero di studenti presenti nella lista
            //devo convertire il numero di studenti in stringa
            //per poterlo visualizzare nella casella di testo

            txtStudentiPresenti.Text = $"{studenti.Count}";

        }

        private void resetCampi()
        {
            txtNome.Text = "";
            txtCognome.Text = "";
            txtAnnoNascita.Text = "";
            txtAbilita.Text = "";
        }


        private void CambiaSfondoForm(object sender, EventArgs e)
        {
            //Con sender ricevo il riferimento al controllo che ha generato l'evento
            //facio un cast a button per accedere alla proprietà Text del pulsante che ha generato l'evento

            Button btn = (Button)sender;
            string testo = btn.Text;

            if (testo == "Rosso")
                BackColor = Color.Red;
            else if (testo == "Verde")
                BackColor = Color.Green;
            else if (testo == "Giallo")
                BackColor = Color.Yellow;

            // MessageBox.Show(testo);
        }


        private void btnGiallo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void btnRosso_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnCerca_1_Click(object sender, EventArgs e)
        {
            //Leggo quello che è stato scritto nella textbox
            string nome = txtNome.Text;
            string msg = "Hai cercato: " + nome;
            //variabile che uso per sapere se trovo almeno uno studente con quel nome
            bool trovato = false;
            //recupero la lista di studenti dal repositoryStatic
            List<Studente> studenti = StaticRepository.Studenti;

            // cerco nella lista di studenti quelli che hanno il nome scritto nella textbox
            for (int i = 0; i < studenti.Count; i++)
            {
                if (studenti[i].Nome.ToUpper() == nome.ToUpper())
                {
                    msg += "\nTrovato Studente: " + studenti[i].Nome + " " + studenti[i].Cognome;
                    trovato = true;
                }
            }
            if (!trovato)
            {
                msg += "\nNessuno studente trovato con quel nome ";
            }

            //Visualizzo
            MessageBox.Show(msg, "ricerca allievi");

        }
        private void btnCerca_2_Click(object sender, EventArgs e)
        {
            //LEggo quello che è stato scritto nella textbox
            string cognome = txtCognome.Text;
            //Visualizzo
            MessageBox.Show("Hai cercato:" + cognome, "ricerca allievi");
        }

        private void btnCerca_3_Click(object sender, EventArgs e)
        {
            //Leggo quello che è stato scritto nella textbox
            int anno = int.Parse(txtAnnoNascita.Text);
            string msg = "Hai cercato: " + anno;
            //variabile che uso per sapere se trovo almeno uno studente con quel nome
            bool trovato = false;
            //recupero la lista di studenti dal repositoryStatic
            List<Studente> studenti = StaticRepository.Studenti;

            // cerco nella lista di studenti quelli che hanno il nome scritto nella textbox
            for (int i = 0; i < studenti.Count; i++)
            {
                if (studenti[i].AnnoNascita == anno)
                {
                    msg += "\nTrovato Studente: " + studenti[i].Nome + " " + studenti[i].Cognome;
                    trovato = true;
                }
            }
            if (!trovato)
            {
                msg += "\nNessuno studente trovato del " + anno;
            }

            //Visualizzo
            MessageBox.Show(msg, "ricerca allievi");
        }
    }
}
