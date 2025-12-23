using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library_manager_console_project.Models;

namespace library_manager_console_project
{
    internal class Controller
    {
        private static List<Livre> books = new List<Livre>();
        private static List<Membre> members = new List<Membre>();
        private static List<Emprunt> loans = new List<Emprunt>();
        private static List<Amende> fines = new List<Amende>();

        private static int nextMemberNumber = 1;
        private static int nextLoanNumber = 1;
        private static int nextFineNumber = 1;

        private static string GenerateNextMemberNumber()
        {
            string memberNumber = $"M-{nextMemberNumber:D4}";
            nextMemberNumber++;
            return memberNumber;
        }

        private static string GenerateNextLoanNumber()
        {
            string loanNumber = $"E-{nextLoanNumber:D4}";
            nextLoanNumber++;
            return loanNumber;
        }

        private static string GenerateNextFineNumber()
        {
            string fineNumber = $"A-{nextFineNumber:D4}";
            nextFineNumber++;
            return fineNumber;
        }
        public static void ProcessInput()
        {
            bool stayInMenu = true;

            while (stayInMenu)
            {
                View.DisplayPrincipalMenu();
                ConsoleKeyInfo key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        ProcessManageBookMenuInput();
                        break;
                    case ConsoleKey.D2:
                        ProcessManageMemberInput();
                        break;
                    case ConsoleKey.D3:
                        ProcessManageLoansMenuInput();
                        break;
                    case ConsoleKey.D4:
                        ProcessManageFineMenuInput();
                        break;
                    case ConsoleKey.D5:
                        ProcessStatistiquesMenuInput();
                        break;
                    case ConsoleKey.D6:
                        break;
                    case ConsoleKey.D7:
                        View.DisplayLeaveMessage();
                        stayInMenu = false;
                        break;
                    default:
                        View.DisplayErrorMessage();
                        break;
                }
            }
        }

        public static void ProcessManageBookMenuInput()
        {
            bool stayInMenu = true;
            while (stayInMenu)
            {
                View.DisplayManageBookMenu();
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        ProcessSearchABookMenu();
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        break;
                    case ConsoleKey.D7:
                        stayInMenu = false;
                        break;
                    default:
                        View.DisplayErrorMessage();
                        break;
                }
            }
        }

        public static void ProcessSearchABookMenu()
        {
            bool stayInMenu = true;
            while (stayInMenu)
            {
                View.DisplaySearchABookMenu();
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        stayInMenu = false;
                        break;
                    default:
                        View.DisplayErrorMessage();
                        break;
                }
            }
        }

        public static void ProcessManageMemberInput()
        {
            bool stayInMenu = true;
            while (stayInMenu)
            {
                View.DisplayManageMember();
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        break;
                    case ConsoleKey.D7:
                        stayInMenu = false;
                        break;
                    default:
                        View.DisplayErrorMessage();
                        break;
                }
            }
        }

        public static void ProcessSearchMemberMenuInput()
        {
            bool stayInMenu = true;
            while (stayInMenu)
            {
                View.DisplaySearchMemberMenu();
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        stayInMenu = false;
                        break;
                    default:
                        View.DisplayErrorMessage();
                        break;
                }
            }
        }
        public static void ProcessManageLoansMenuInput()
        {
            bool stayInMenu = true;
            while (stayInMenu)
            {
                View.DisplayManageLoans();
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        break;
                    case ConsoleKey.D7:
                        stayInMenu = false;
                        break;
                    default:
                        View.DisplayErrorMessage();
                        break;
                }
            }
        }

        public static void ProcessManageFineMenuInput()
        {
            bool stayInMenu = true;
            while (stayInMenu)
            {
                View.DisplayManageFine();
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        stayInMenu = false;
                        break;
                    default:
                        View.DisplayErrorMessage();
                        break;
                }
            }
        }
        public static void ProcessStatistiquesMenuInput()
        {

            bool stayInMenu = true;
            while (stayInMenu)
            {
                View.DisplayStatistiquesMenu();
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        break;
                    case ConsoleKey.D4:
                        break;
                    case ConsoleKey.D5:
                        break;
                    case ConsoleKey.D6:
                        break;
                    case ConsoleKey.D7:
                        break;
                    case ConsoleKey.D8:
                        stayInMenu = false;
                        break;
                    default:
                        View.DisplayErrorMessage();
                        break;
                }
            }
        }

    }
}
