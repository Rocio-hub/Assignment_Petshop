using CompulsoryPetshop.Core.DomainService;
using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class OwnerRepository : IOwnerRepository
    {
        private static List<Owner> _ownerList = new List<Owner>();
        private static bool dataInitialized;

        public void InitData()
        {
            if (!dataInitialized)
            {
                _ownerList.Add(new Owner()
                {
                    OwnerID = 1,
                    OwnerFirstName = "NameOwner1",
                    OwnerLastName = "LNameOwner1",
                    OwnerPhoneNo = 1111111
                });

                _ownerList.Add(new Owner()
                {
                    OwnerID = 2,
                    OwnerFirstName = "NameOwner2",
                    OwnerLastName = "LNameOwner2",
                    OwnerPhoneNo = 222222
                });

                _ownerList.Add(new Owner()
                {
                    OwnerID = 3,
                    OwnerFirstName = "NameOwner3",
                    OwnerLastName = "LNameOwner3",
                    OwnerPhoneNo = 3333333
                });
            }
            dataInitialized = true;
        }


        public Owner CreateOwner(Owner newOwner)
        {
            InitData();

            newOwner.OwnerID = _ownerList.Count;
            _ownerList.Add(newOwner);
            return newOwner;
        }

        public Owner DeleteOwner(int id)
        {
            InitData();

            foreach (var owner in _ownerList)
            {
                if(owner.OwnerID == id)
                {
                    _ownerList.Remove(owner);
                    return owner;
                }
            }
            return null;
        }

        public Owner FindOwnerByID(int id)
        {
            InitData();

            foreach (var owner in _ownerList)
            {
                if(owner.OwnerID == id)
                {
                    return owner;
                }
            }
            return null;
        }

        public List<Owner> GetAllOwners()
        {
            InitData();

            return _ownerList;
        }

        public Owner UpdateOwner(int id, Owner ownerUpdate)
        {
            InitData();

            foreach (var Owner in _ownerList)
            {
                if(Owner.OwnerID == id)
                {
                    Owner.OwnerFirstName = ownerUpdate.OwnerFirstName;
                    Owner.OwnerLastName = ownerUpdate.OwnerLastName;
                    Owner.OwnerPhoneNo = ownerUpdate.OwnerPhoneNo;
                }
            }
            return ownerUpdate;
        }
    }
}
