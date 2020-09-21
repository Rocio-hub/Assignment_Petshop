using CompulsoryPetshop.Core.DomainService;
using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryPetshop.Core.ApplicationService.Service
{
    public class OwnerService : IOwnerService
    {
        readonly IOwnerRepository _ownerRepo;
        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepo = ownerRepository;
        }
        public Owner CreateOwner(Owner owner)
        {
            return _ownerRepo.CreateOwner(owner);
        }

        public Owner DeleteOwner(int id)
        {
            if (id < 0)
            {
                throw new Exception("Please, enter a valid value for the ID");
            }
            return _ownerRepo.DeleteOwner(id);
        }

        public Owner FindOwnerByID(int id)
        {
            if (id < 0)
            {
                throw new Exception("Please, enter a valid value for the ID");
            }
            return _ownerRepo.FindOwnerByID(id);
        }

        public List<Owner> GetAllOwners()
        {
            return _ownerRepo.GetAllOwners();
        }

        public Owner UpdateOwner(int id, Owner ownerUpdate)
        {
            if (id < 0)
            {
                throw new Exception("Please, enter a valid value for the ID");
            }
            if (ownerUpdate == null)
            {
                throw new Exception("Please, include the updated Pet");
            }
            return _ownerRepo.UpdateOwner(id, ownerUpdate);
        }        
    }
}
