using CompulsoryPetshop.Core.ApplicationService;
using CompulsoryPetshop.Core.ApplicationService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompulsoryPetshop.UI
{
    public class Printer : IPrinter
    {
        private IPetService _petService;

        public Printer(IPetService petService)
        {
            _petService = petService;
           
        }

        #region Show Menu
        public int PrintMenuItems()
        {
            string[] menuItems =    {
                "Show list of pets",
                "Search pets by type",
                "Create a new pet",
                "Delete a pet",
                "Update a pet",
                "Show a list of all pets sorted by price",
                "Show the 5 cheapest pets",
                "Exit"
            };

            Console.WriteLine("Insert a number to select what you want to do: \n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {menuItems[i]}");
            }
            Console.WriteLine("");

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1 || selection > 8)
            {
                Console.WriteLine("Please, select a valid number (1-8)");
            }
            Console.WriteLine($"You selected: {menuItems[selection - 1]}");

            return selection;
        }
        #endregion

        #region Print by price
        public void PrintByPrice(List<Pet> sortedList)
        {
            Console.WriteLine("ID\tNAME\t\tTYPE\t\tPRICE\tBIRTH DATE\tSOLD DATE\tCOLOR\tPREVIOUS OWNER");

            foreach (var pet in sortedList)
            {
                Console.WriteLine($"{pet.PetID}\t{pet.PetName}\t{pet.PetType}\t{pet.PetPrice}\t{pet.PetBirthDate.ToShortDateString()}\t{pet.PetSoldDate.ToShortDateString()}" +
                    $"\t{pet.PetColor}\t{pet.PetPrevOwner}");
            }
            Console.WriteLine(" ");
        }
        #endregion

        #region User selects exit
        public void UserLeaving()
        {
            Console.WriteLine("-----THANK YOU. HAVE A NICE DAY-----");
        }
        #endregion

        #region Print five cheapest
        public void PrintFiveCheapest(List<Pet> cheapPetList)
        {           

            Console.WriteLine("ID\tNAME\t\tTYPE\t\tPRICE\tBIRTH DATE\tSOLD DATE\tCOLOR\tPREVIOUS OWNER");
            foreach (var pet in cheapPetList)
            {
                Console.WriteLine($"{pet.PetID}\t{pet.PetName}\t\t{pet.PetType}\t\t{pet.PetPrice}\t{pet.PetBirthDate.ToShortDateString()}\t{pet.PetSoldDate.ToShortDateString()}" +
                   $"\t{pet.PetColor}\t{pet.PetPrevOwner}");
            }
            Console.WriteLine(" ");
        }
        #endregion

        #region List of pets
        public void PrintListOfPets(List<Pet> petList)
        {

            Console.WriteLine("ID\tNAME\t\tTYPE\t\tPRICE\tBIRTH DATE\tSOLD DATE\tCOLOR\tPREVIOUS OWNER");

            foreach (var pet in petList)
            {
                Console.WriteLine($"{pet.PetID}\t{pet.PetName}\t\t{pet.PetType}\t\t{pet.PetPrice}\t{pet.PetBirthDate.ToShortDateString()}\t{pet.PetSoldDate.ToShortDateString()}" +
                    $"\t{pet.PetColor}\t{pet.PetPrevOwner}");
            }
            Console.WriteLine(" ");
        }
        #endregion

        #region Create pet
        public Pet CreatePet()
        {
            Pet newPet = new Pet();
            Console.WriteLine("Insert name: ");
            newPet.PetName = Console.ReadLine();
            Console.WriteLine("Insert type: ");
            newPet.PetType = Console.ReadLine();
            Console.WriteLine("Insert birth date: Format YYYY/MM/DD");
            newPet.PetBirthDate = checkDateTime(Console.ReadLine());
            Console.WriteLine("Insert sold date: ");
            newPet.PetSoldDate = checkDateTime(Console.ReadLine());
            Console.WriteLine("Insert color: ");
            newPet.PetColor = Console.ReadLine();
            Console.WriteLine("Insert previous owner: ");
            newPet.PetPrevOwner = Console.ReadLine();
            Console.WriteLine("Insert price: ");
            newPet.PetPrice = checkDouble(Console.ReadLine());

            return newPet;
        }
        #endregion

        #region checking part
        public DateTime checkDateTime(string date)
        {
            DateTime checkDT;
            while (!DateTime.TryParse(date, out checkDT))
            {
                Console.WriteLine("Insert a valid value: Format YYYY/MM/DD");
                date = Console.ReadLine();
            }
            return checkDT;
        }

        public double checkDouble(string price)
        {
            double checkPrice;
            while (!double.TryParse(price, out checkPrice))
            {
                Console.WriteLine("Insert a valid value");
                price = Console.ReadLine();
            }
            return checkPrice;
        }
        #endregion

        #region Update pet
        public Pet PrintUpdatePet()
        {

            Pet update = new Pet();
            Console.WriteLine("Insert name: ");
            update.PetName = Console.ReadLine();
            Console.WriteLine("Insert type: ");
            update.PetType = Console.ReadLine();
            Console.WriteLine("Insert birth date: Format YYYY/MM/DD");
            update.PetBirthDate = checkDateTime(Console.ReadLine());
            Console.WriteLine("Insert sold date: Format YYYY/MM/DD");
            update.PetSoldDate = checkDateTime(Console.ReadLine());
            Console.WriteLine("Insert color: ");
            update.PetColor = Console.ReadLine();
            Console.WriteLine("Insert previous owner: ");
            update.PetPrevOwner = Console.ReadLine();
            Console.WriteLine("Insert price: ");
            update.PetPrice = checkDouble(Console.ReadLine());

            return update;
        }
        #endregion

        #region Get ID from user
        public int GetIDFromUser()
        {
            Console.WriteLine("Insert the ID of the pet");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please, insert a valid value");
            }
            return id;            
        }
        #endregion

        #region Find pet by type
        public string GetTypeFromUser()
        {
            Console.WriteLine("Insert the type of the pet: cat/dog/horse");
            int notALetter;
            var typeInserted = Console.ReadLine();
            while (int.TryParse(typeInserted, out notALetter))
            {
                Console.WriteLine("Please, insert a valid type");
                typeInserted = Console.ReadLine();
            }            
            Console.WriteLine(" ");
            return typeInserted;
        }
        #endregion


        
    }
}
