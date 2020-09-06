using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryPetshop.UI
{
    public interface IPrinter
    {
        int PrintMenuItems();
        void PrintByPrice(List<Pet> petList);
        void UserLeaving();
        void PrintFiveCheapest(List<Pet> petList);
        void PrintListOfPets(List<Pet> petList);
        Pet CreatePet();
        Pet PrintUpdatePet();
        string GetTypeFromUser();
        int GetIDFromUser();


    }
}
