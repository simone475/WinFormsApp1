
using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1;

namespace WinFormsapp1

{
    internal class StaticRepository
    {

        private static Studente[] studenti =
            {
             new Studente("Geoffrey", "Agwasim", 2006, "non bravo"),//assoicato
            new Studente("Simone","Restivo",2004," non bravo"),
            new Studente("Robert","Benchea",2006, "bravo"),//assoicato
            new Studente("Simone", "Demonte", 1990,"non bravo"),//assoicato
            //new Studente ("Davide","Giolitti",2001,"bravo"),//assoicato
            //new Studente("Luca", "Foglia", 1997, "non bravo"),//assoicato
            new Studente("Tommaso","Martorana",2006,"non bravo"),//assoicato
            new Studente("Gabriele","Bellè",2005,"non bravo"),//assoicato
            new Studente("Fabio","Cerundolo",1994, "bravo"),//assoicato
            new Studente("Elias","Durand",2005, "non bravo"),
            new Studente ("Facundo", "Fanti", 1991, "bravo"),
            new Studente ("Leonida", "Qemeqi", 1999, "non bravo"),//assoicato
            new Studente("Stefano", "Spadaccini",2002,"bravo"),//assoicato
            new Studente("Mattia", "Frison",2002,"bravo"),//assoicato
            new Studente("Diallo ", "Ibrahim",1999, "non bravo"),//assoicato
            new Studente("Mirko","Di Vincenzo",2006,"bravo"),//assoicato
            new Studente("Sara", "Novara", 2005, "non bravo"),
            new Studente("Paul", "Potosi", 2000,"non bravo"),
            new Studente ("Salomé","Mbang",2005,"non bravo"),//assoicato
            new Studente("Alessia","Coppola",2005,"non bravo"),
            new Studente("Antonio", "Duch", 2004, "non bravo"),
            new Studente("Frédéric", "Madzou", 1998, "non bravo"),//assoicato
            new Studente("Stefano", "Vanni", 1998, "non bravo"),
            new Studente("Mouaad", "Boustta", 2003, "bravo"),
            new Studente("Federico", "D'incecco", 2006, "bravo")
            };

        public static List<Studente> Studenti
        {
            get { return studenti.ToList<Studente>(); }
        }
    }
}
internal class StaticRepository
    {

        private static Studente[] studenti =
            {
             new Studente("Geoffrey", "Agwasim", 2006, "non bravo"),//assoicato
            new Studente("Simone","Restivo",2004," non bravo"),
            new Studente("Robert","Benchea",2006, "bravo"),//assoicato
            new Studente("Simone", "Demonte", 1990,"non bravo"),//assoicato
            //new Studente ("Davide","Giolitti",2001,"bravo"),//assoicato
            //new Studente("Luca", "Foglia", 1997, "non bravo"),//assoicato
            new Studente("Tommaso","Martorana",2006,"non bravo"),//assoicato
            new Studente("Gabriele","Bellè",2005,"non bravo"),//assoicato
            new Studente("Fabio","Cerundolo",1994, "bravo"),//assoicato
            new Studente("Elias","Durand",2005, "non bravo"),
            new Studente ("Facundo", "Fanti", 1991, "bravo"),
            new Studente ("Leonida", "Qemeqi", 1999, "non bravo"),//assoicato
            new Studente("Stefano", "Spadaccini",2002,"bravo"),//assoicato
            new Studente("Mattia", "Frison",2002,"bravo"),//assoicato
            new Studente("Diallo ", "Ibrahim",1999, "non bravo"),//assoicato
            new Studente("Mirko","Di Vincenzo",2006,"bravo"),//assoicato
            new Studente("Sara", "Novara", 2005, "non bravo"),
            new Studente("Paul", "Potosi", 2000,"non bravo"),
            new Studente ("Salomé","Mbang",2005,"non bravo"),//assoicato
            new Studente("Alessia","Coppola",2005,"non bravo"),
            new Studente("Antonio", "Duch", 2004, "non bravo"),
            new Studente("Frédéric", "Madzou", 1998, "non bravo"),//assoicato
            new Studente("Stefano", "Vanni", 1998, "non bravo"),
            new Studente("Mouaad", "Boustta", 2003, "bravo"),
            new Studente("Federico", "D'incecco", 2006, "bravo")
            };

        public static List<Studente> Studenti
        {
            get { return studenti.ToList<Studente>(); }
        }
    }

