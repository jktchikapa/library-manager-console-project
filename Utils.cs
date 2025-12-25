using library_manager_console_project.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_manager_console_project
{
    internal class Utils
    {
        public static void SearchABookByTitle(List<Livre> books)
        {
            string title = ReadANonEmptyInput("Titre : ");
            bool found = false;

            foreach (Livre book in books)
            {
                if (book.Title.ToLower().Contains(title.ToLower()))
                {
                    Console.WriteLine($"Titre : {book.Title} - Auteur {book.Author} - ISBN : {book.ISBN} - Categorie : {book.Categorie}");
                    found = true;
                }
            }
            if (!found)
            {
                NoBookFounds($"le titre : {title}");
            }
            View.WaitForKeyPress();
        }
        public static void DeleteBookByTitle(List<Livre> books)
        {
            string title = ReadANonEmptyInput("Titre du livre à supprimer : ");

            SearchABookByTitle(books);

            for (int i = books.Count - 1; i >= 0; i--)
            {
                if (books[i].Title.ToLower().Contains(title.ToLower()))
                {
                    books.RemoveAt(i);
                    Console.WriteLine("Livre supprimé !");
                }
            }

            View.WaitForKeyPress();
        }
        public static void DeleteBookByISBN(List<Livre> books)
        {
            string isbn = ReadANonEmptyInput("ISBN du livre à supprimer : ");
            SearchABookByISBN(books);

            for (int i = books.Count - 1; i >= 0; i--)
            {
                if (books[i].ISBN.Contains(isbn))
                {
                    books.RemoveAt(i);
                    Console.WriteLine("Livre supprimé !");
                }
            }
        }
        public static void SearchABookByAuthor(List<Livre> books)
        {
            string author = ReadANonEmptyInput("Auteur : ");
            bool found = false;

            foreach (Livre book in books)
            {
                if (book.Author.ToLower().Contains(author.ToLower()))
                {
                    Console.WriteLine($"Titre : {book.Title} - Auteur {book.Author} - ISBN : {book.ISBN} - Categorie : {book.Categorie}");
                    found = true;
                }

            }
            if (!found)
            {
                NoBookFounds($"l'auteur : {author}");
            }
            View.WaitForKeyPress();
        }

        public static void SearchABookByISBN(List<Livre> books)
        {
            string isbn = ReadANonEmptyInput("ISBN : ");
            bool found = false;

            foreach (Livre book in books)
            {
                if (book.ISBN.ToLower().Contains(isbn.ToLower()))
                {
                    Console.WriteLine($"Titre : {book.Title} - Auteur {book.Author} - ISBN : {book.ISBN} - Categorie : {book.Categorie}");
                    found = true;
                }

            }
            if (!found)
            {
                NoBookFounds($"l'ISBN : {isbn}");
                View.WaitForKeyPress();
            }
            View.WaitForKeyPress();
        }

        public static void SearchABookByCategorie(List<Livre> books)
        {
            string categorie = ReadANonEmptyInput("Categorie : ");
            bool found = false;

            foreach (Livre book in books)
            {
                if (book.Categorie.ToLower().Contains(categorie.ToLower()))
                {
                    Console.WriteLine($"Titre : {book.Title} - Auteur {book.Author} - ISBN : {book.ISBN} - Categorie : {book.Categorie}");
                    found = true;
                }
            }
            if (!found)
            {
                NoBookFounds($"la catégorie {categorie}");
            }
            View.WaitForKeyPress();
        }

        public static void NoBookFounds(string reason)
        {
            Console.WriteLine($"Aucun livre trouvé pour {reason}");
        }

        public static string ReadANonEmptyInput(string input)
        {
            while (true)
            {
                Console.Clear();
                Console.Write(input);
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ce champ ne peut pas être vide!");
                    View.WaitForKeyPress();
                }
                else
                {
                    return input;
                }
            }
        }

        public static string IsValidEmail(string email)
        {
            while (true)
            {
                Console.Clear();
                Console.Write(email);
                email = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(email))
                {
                    Console.WriteLine("Ce champ ne peut pas être vide!");
                    View.WaitForKeyPress();
                }
                else
                {
                    if (!email.Contains("@"))
                    {
                        Console.WriteLine("L'email doit contenir un arobase");
                    }
                    return email;
                }
            }
        }

        public static bool IsNotEmptyList<T>(string listName, List<T> list)
        {
            if (list == null || list.Count == 0)
            {
                return false;
            }
            return true;
        }

        public static bool IsActiveMember(Membre member)
        {
            return member.AccountStatus ? true : false;
        }

        public static bool IsAvailableBook(Livre book)
        {
            return book.NumberOfAvailableCopies > 0 ? true : false;
        }

        public static int ReadANonEmptyInputAndConvertToInt32(string input)
        {
            while (true)
            {
                Console.Write(input);
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ce champ ne peut pas être vide!");
                }
                else
                {
                    if (int.TryParse(input, out int number))
                    {
                        return number;
                    }
                }
            }
        }
        public static string ReadUniqueISBN()
        {
            string isbn;
            bool exists;
            do
            {
                isbn = ReadANonEmptyInput("ISBN : ");
                exists = Controller.ISBNExists(isbn);
                if (exists)
                {
                    Console.WriteLine("Cette ISBN existe déjà ! Veuillez en saisir une autre.");
                    View.WaitForKeyPress();
                }
            } while (exists);

            return isbn;
        }


    }
}
