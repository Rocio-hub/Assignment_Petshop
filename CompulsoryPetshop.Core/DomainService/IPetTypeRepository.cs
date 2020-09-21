using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryPetshop.Core.DomainService
{
    public interface IPetTypeRepository
    {
        //C
        public PetType CreatePetType(PetType newPetType);

        //R
        public List<PetType> ReadAllPetTypes();
        public PetType ReadPetTypeByID(int id);

        //U
        public PetType UploadPetTypeByID(int id, PetType petType);

        //D
        public PetType DeleteByID(int id);

    }
}
