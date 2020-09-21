using CompulsoryPetshop.Core.DomainService;
using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompulsoryPetshop.Core.ApplicationService.Service
{
    public class PetService : IPetService
    {
        readonly IPetRepository _petRepo;
        readonly IPetTypeRepository _petTypeRepo;

        public PetService(IPetRepository petRepository, IPetTypeRepository petTypeRepository)
        {
            _petRepo = petRepository;
            _petTypeRepo = petTypeRepository;
        }

        public Pet CreatePet(Pet newPet)
        {
            if(newPet.PetName.Equals(null))
            {
                throw new Exception("Please, enter a valid value for the name of the Pet");
            }
            return _petRepo.CreatePet(newPet);
        }

        public Pet FindPetbyID(int id)
        {
            if (id < 0)
            {
                throw new Exception("Please, enter a valid value for the ID");
            }
            return _petRepo.FindPetbyID(id);
        }

        public List<Pet> GetPetsByType(string type)
        {
            foreach (var petType in _petTypeRepo.ReadAllPetTypes())
            {

                if (!type.Equals(petType.GetType()))
                {
                    throw new Exception("Please, enter a valid value for the Type");
                }
            }
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

        public List<Pet> ReadAllPets()
        {
            return _petRepo.ReadAllPets();
        }

        public Pet UpdatePetByID(int id, Pet petUpdate)
        {
            if (id < 0)
            {
                throw new Exception("Please, enter a valid value for the ID");
            }
            if (petUpdate.Equals(null))
            {
                throw new Exception("Please, include the updated Pet");
            }
            return _petRepo.UpdateByID(id, petUpdate);
        }

        public Pet DeleteByID(int id)
        {
            if (id < 0)
            {
                throw new Exception("Please, enter a valid value for the ID");
            }

            return _petRepo.DeleteByID(id);
        }
    }
}
