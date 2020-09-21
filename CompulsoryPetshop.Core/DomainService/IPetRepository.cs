using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryPetshop.Core.DomainService
{
    public interface IPetRepository
    {

        public Pet CreatePet(Pet newPet);


        public List<Pet> ReadAllPets();

        public List<Pet> GetSortedList();

        public List<Pet> GetSortedFiveList();        

        public List<Pet> GetPetsByType(string typename);

        public Pet FindPetbyID(int id);


        public Pet UpdateByID(int id, Pet pet);



        public Pet DeleteByID(int id);
       

        
    }
}


