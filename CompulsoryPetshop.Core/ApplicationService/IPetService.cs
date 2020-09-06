using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryPetshop.Core.ApplicationService
{
    public interface IPetService
    {
        public List<Pet> GetSortedList();
        public List<Pet> GetSortedFiveList();
        public void CreatePet(Pet newPet);
        public Pet FindPetbyID(int id);
        public void DeleteByID(int id);
        public void UpdateByID(int id, Pet pet);
        public List<Pet> GetPetsByType(string type);

    }
}
