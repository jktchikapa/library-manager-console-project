using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_manager_console_project.Models
{
    internal class Livre
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
        public string Categorie { get; set; }
        public int NumberOfAvailableCopies { get; set; }
        public int NumberOfCopies { get; set; }
        public int NumberOfLoans { get; set; }

        public Livre(string title, string author, string isbn, int publicationYear, string categorie, int numberOfAvalaibleCopie, int numberOfCopies)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            Categorie = categorie;
            NumberOfAvailableCopies = numberOfCopies;
            NumberOfCopies = numberOfCopies;
            NumberOfLoans = 0;
        }

        public void Display()
        {
            Console.WriteLine($"{Title} - {ISBN}");
            Console.WriteLine($"Auteur : {Author}");
            Console.WriteLine($"Année de publication {PublicationYear} | Catégorie {Categorie}");
            Console.WriteLine($"Nombre d'exemplaires disponibls : {NumberOfAvailableCopies}/{NumberOfCopies}");
            Console.WriteLine($"Nombres d'emprunts : {NumberOfLoans}");
        }
    }
}
