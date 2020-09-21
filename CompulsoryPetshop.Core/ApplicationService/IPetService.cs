using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryPetshop.Core.ApplicationService
{
    public interface IPetService
    {
        //C-R-U-D

        //Create - POST
        public Pet CreatePet(Pet newPet);

        //Read - GET
        public List<Pet> ReadAllPets();
        public List<Pet> GetSortedList();
        public List<Pet> GetSortedFiveList();
        public Pet FindPetbyID(int id);
        public List<Pet> GetPetsByType(string type);

        //Update - PUT       
        public Pet UpdatePetByID(int id, Pet pet);

        //Delete - DELETE
        public Pet DeleteByID(int id);

    }
}
