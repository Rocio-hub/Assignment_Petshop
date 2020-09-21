using CompulsoryPetshop.Core.DomainService;
using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class PetTypeRepository : IPetTypeRepository
    {
        private static List<PetType> _petTypeList = new List<PetType>();
        private static bool dataInitialized;

        public void InitData()
        {
            if (!dataInitialized)
            {
                _petTypeList.Add(new PetType()
                {
                    PetTypeID = '1',
                    PetTypeName = "Dog"
                });

                _petTypeList.Add(new PetType()
                {
                    PetTypeID = '2',
                    PetTypeName = "Cat"
                });

                _petTypeList.Add(new PetType()
                {
                    PetTypeID = '3',
                    PetTypeName = "Horse"
                });
            }
        }
        public PetType CreatePetType(PetType newPetType)
        {
            InitData();

            newPetType.PetTypeID = _petTypeList.Count;
            _petTypeList.Add(newPetType);
            return newPetType;
        }

        public PetType DeleteByID(int id)
        {
            InitData();

            foreach (var petType in _petTypeList)
            {
                if (petType.PetTypeID == id)
                {
                    _petTypeList.Remove(petType);
                    return petType;
                }
            }
            return null;
        }

        public List<PetType> ReadAllPetTypes()
        {
            {
                InitData();
                return _petTypeList;
            }
        }
        public PetType UploadPetTypeByID(int id, PetType petType)
        {
            InitData();

            foreach (var PetType in _petTypeList)
            {
                if (PetType.PetTypeID == id)
                {
                    PetType.PetTypeID = petType.PetTypeID;
                    PetType.PetTypeName = petType.PetTypeName;         
                }
            }
            return petType;
        }

        public PetType ReadPetTypeByID(int id)
        {
            InitData();

            foreach (var petType in _petTypeList)
            {
                if (petType.PetTypeID == id)
                {
                    return petType;
                }
            }
            return null;
        }
    }
}
