using CompulsoryPetshop.Core.DomainService;
using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryPetshop.Core.ApplicationService.Service
{
    public class PetService : IPetService
    {
        readonly IPetRepository _petRepo;

        public PetService(IPetRepository petRepository)
        {
            _petRepo = petRepository;
        }

        public void CreatePet(Pet newPet)
        {
            _petRepo.CreatePet(newPet);
        }

        public void DeleteByID(int id)
        {
            _petRepo.DeleteByID(id);
        }

        public Pet FindPetbyID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pet> GetPetsByType(string type)
        {
            return _petRepo.GetPetsByType(type);
        }

        public List<Pet> GetSortedFiveList()
        {
            return _petRepo.GetSortedFiveList();
        }

        public List<Pet> GetSortedList()
        {
            return _petRepo.GetSortedList();
        }



        public void UpdateByID(int id, Pet pet)
        {
            _petRepo.UpdateByID(id, pet);
        }
    }
}
