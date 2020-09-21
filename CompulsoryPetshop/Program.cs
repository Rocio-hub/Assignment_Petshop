using CompulsoryPetshop.Core.ApplicationService;
using CompulsoryPetshop.Core.ApplicationService.Service;
using CompulsoryPetshop.Core.DomainService;
using Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace CompulsoryPetshop.UI
{
    public class Program
    {
       // static Printer printer;
        static List<Pet> petList;
        public static int id = 1;
        public static void Main(string[] args)
        {
            var petRepo = new PetRepository();
            petRepo.InitData();
            PetService _petService = new PetService(petRepo);
            petList = petRepo.ReadPets();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetRepository, PetRepository>();
            serviceCollection.AddScoped<IPetService, PetService>();
            serviceCollection.AddScoped<IPrinter, Printer>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var printer = serviceProvider.GetRequiredService<IPrinter>();
            var selection = printer.PrintMenuItems();
               
            //int selection = printer.PrintMenuItems();

            while (selection != 8)
            {
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        printer.PrintListOfPets(petList);
                        break;
                    case 2:
                        Console.Clear();
                        printer.PrintListOfPets(_petService.GetPetsByType(printer.GetTypeFromUser()));

                        break;
                    case 3:
                        Console.Clear();
                        Pet newPet = printer.CreatePet();
                        newPet.PetID = petList.Count + 1;
                        _petService.CreatePet(newPet);
                        break;
                    case 4:
                        Console.Clear();
                        _petService.DeleteByID(printer.GetIDFromUser());
                        break;
                    case 5:
                        Console.Clear();                       
                        _petService.UpdateByID(printer.GetIDFromUser(), printer.PrintUpdatePet());
                        break;
                    case 6:
                        Console.Clear();
                        printer.PrintByPrice(_petService.GetSortedList()); //DONE
                        break;
                    case 7:
                        Console.Clear();
                        printer.PrintFiveCheapest(_petService.GetSortedFiveList()); //DONE
                        break;
                    default:
                        Console.Clear();
                        break;
                }
                selection = printer.PrintMenuItems();
            }
            printer.UserLeaving();
        }
    }
}
