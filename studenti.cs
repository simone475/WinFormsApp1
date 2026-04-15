using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class Studente
    {
        private string nome;
        private string cognome;
        private int annoNascita;
        private string abilita;

        public Studente(string nome, string cognome, int annoNascita, string abilita)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.annoNascita = annoNascita;
            this.abilita = abilita;
        }

        public Studente() { }

        public int getAnnoNascita()
        {
            return annoNascita;
        }
        
        public void setAnnoNascita(int anno)
        {
            if (anno >= 1950 && anno <= 2026)
            {
                annoNascita = anno;
            }

        }

        public int AnnoNascita
        {
            get { return annoNascita; }
            set
            {
                if (value >= 1950 && value <= 2026)
                {
                    annoNascita = value;
                }
            }
        }
        
        public string Nome
        {
            get
            {
                return nome.ToUpper();
            }
            set
            {
                nome = "";
                if (value != null && value.Length > 0)
                {
                    nome = value;
                }
            }

        }

        public string Cognome
        {
            get
            {
                return cognome.ToUpper();
            }
            set
            {
                cognome = "";
                if (value != null && value.Length > 0)
                {
                    cognome = value;
                }
            }

        }

        public string Abilita
        {
            get
            {
                return abilita;
            }
            set
            {
                abilita = "";
                if (value != null && value.Length > 0)
                {
                    abilita = value;
                }
            }

        }

        public string Info()
        {
            return $"lo studente si chiama {nome} {cognome} nato nel {annoNascita} ed ha {Eta} anni ed è per adesso... {abilita}";
        }

        public int Eta
        {
            get
            {
                const int ANNO_ATTUALE = 2026;
                return ANNO_ATTUALE - annoNascita;
            }
        }
    }
}
