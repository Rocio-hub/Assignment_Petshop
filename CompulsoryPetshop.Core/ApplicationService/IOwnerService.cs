using CompulsoryPetshop.UI;
using System.Collections.Generic;

namespace CompulsoryPetshop.Core.ApplicationService.Service
{
    public interface IOwnerService
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
