using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VendingMachineProject.Program;

namespace VendingMachineProject
{
    class Menu
    {
        public VendingMachine VM = new VendingMachine();
        public SubMenu SubMenu;



        public void Display()
        {
            VendingMachine vm = new VendingMachine();

            PrintHeader();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Main Menu");
                Console.WriteLine("1] Display Vending Machine Items");
                Console.WriteLine("2] Purchase");
                Console.WriteLine("Q] Quit");
                Console.Write("What option do you want to select? ");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Displaying Items");
                    VM.DisplayAllItems();
                    vm.DisplayAllItems();
                }
                else if (input == "2")
                {
                    this.SubMenu = new SubMenu(VM);
                    this.SubMenu.Display();
                    SubMenu subMenu = new SubMenu(vm);
                    subMenu.Display();
                }
                else if (input.ToUpper() == "Q")
                {
                    Console.WriteLine("Quitting");
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        private static void PrintHeader()
        {
            Console.WriteLine("WELCOME TO THE BEST VENDING MACHINE EVER!!!! (Distant crowd roar)");
        }
    }
}
    

