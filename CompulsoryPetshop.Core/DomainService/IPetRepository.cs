using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryPetshop.Core.DomainService
{
    public interface IPetRepository
    {
        public List<Pet> GetSortedList();

        public List<Pet> GetSortedFiveList();

        public void CreatePet(Pet newPet);

        public List<Pet> GetPetsByType(string type);

        public void DeleteByID(int id);
        public void UpdateByID(int id, Pet pet);
    }
}


