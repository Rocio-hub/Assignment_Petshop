using CompulsoryPetshop.Core.DomainService;
using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryPetshop.Core.ApplicationService.Service
{
    public class PetTypeService : IPetTypeService
    {
        readonly IPetTypeRepository _petTypeRepo;

        public PetTypeService(IPetTypeRepository petTypeRepository)
        {
            _petTypeRepo = petTypeRepository;
        }

        public PetType CreatePetType(PetType newPetType)
        {
            return _petTypeRepo.CreatePetType(newPetType);
        }

        public List<PetType> ReadAllPetTypes()
        {
            return _petTypeRepo.ReadAllPetTypes();
        }

        public PetType ReadPetTypeByID(int id)
        {
            if (id < 0)
            {
                throw new Exception("Please, enter a valid value for the ID");
            }
            return _petTypeRepo.ReadPetTypeByID(id);
        }

        public PetType UploadPetTypeByID(int id, PetType petType)
        {
            if (id < 0)
            {
                throw new Exception("Please, enter a valid value for the ID");
            }
            else if (petType == null)
            {
                throw new Exception("Please, include the new Pet Type");
            }
            return _petTypeRepo.UploadPetTypeByID(id, petType);
        }

        public PetType DeleteByID(int id)
        {
            if (id < 0)
            {
                throw new Exception("Please, enter a valid value for the ID");
            }

            return _petTypeRepo.DeleteByID(id);
        }




    }
}
