using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_manager_console_project
{
    internal class Controller
    {
        public static void ProcessInput()
        {
            bool stayInMenu = true;

            while(stayInMenu)
            {
                View.DisplayPrincipalMenu();
                ConsoleKeyInfo key = Console.ReadKey();

                switch(key.Key)
                {
                    case ConsoleKey.D1:
                        View.DisplayManageBookMenu();
                        break;
                    case ConsoleKey.D2:
                        View.DisplayManageMember();
                        break;
                    case ConsoleKey.D3:
                        View.DisplayManageLoans();
                        break;
                    case ConsoleKey.D4:
                        View.DisplayManageFine();
                        break;
                    case ConsoleKey.D5:
                        View.DisplayStatistiquesMenu();
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
    }
}
