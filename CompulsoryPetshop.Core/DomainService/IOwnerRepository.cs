using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryPetshop.Core.DomainService
{
    public interface IOwnerRepository
    {

        //POST -- Create
        public Owner CreateOwner(Owner owner);

        //GET - -Read
        public Owner FindOwnerByID(int id);

        public List<Owner> GetAllOwners();

        //PUT -- Update
        public Owner UpdateOwner(int id, Owner ownerUpdate);

        //DELETE -- Delete
        public Owner DeleteOwner(int id);
    }
}
