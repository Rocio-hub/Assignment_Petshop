using CompulsoryPetshop.Core.DomainService;
using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data
{
    public class PetRepository : IPetRepository
    {
        private static List<Pet> _petList = new List<Pet>();
        private static bool dataInitialized;


        public void InitData()
        {
            if (!dataInitialized)
            {
                _petList.Add(new Pet()
                {
                    PetID = 1,
                    PetName = "Charlie",
                    PetType = "cat",
                    PetPrice = 1,
                    PetBirthDate = new DateTime(2016, 04, 23),
                    PetPrevOwner = new Owner()
                    {
                        OwnerID = 1,
                        OwnerFirstName = "NameOwner1",
                        OwnerLastName = "LNameOwner1",
                        OwnerPhoneNo = 1111111
                    },
                    PetColor = "black"
                });

                _petList.Add(new Pet()
                {
                    PetID = 2,
                    PetName = "Max",
                    PetType = "cat",
                    PetPrice = 109,
                    PetBirthDate = new DateTime(2018, 07, 05),
                    PetPrevOwner = new Owner()
                    {
                        OwnerID = 2,
                        OwnerFirstName = "NameOwner2",
                        OwnerLastName = "LNameOwner2",
                        OwnerPhoneNo = 222222
                    },
                    PetColor = "brown"
                });

                _petList.Add(new Pet()
                {
                    PetID = 3,
                    PetName = "Buddy",
                    PetType = "dog",
                    PetPrice = 56,
                    PetBirthDate = new DateTime(2017, 01, 29),
                    PetPrevOwner = new Owner()
                    {
                        OwnerID = 3,
                        OwnerFirstName = "NameOwner3",
                        OwnerLastName = "LNameOwner3",
                        OwnerPhoneNo = 3333333
                    },
                    PetColor = "grey"
                });

                _petList.Add(new Pet()
                {
                    PetID = 4,
                    PetName = "Coco",
                    PetType = "bird",
                    PetPrice = 200,
                    PetBirthDate = new DateTime(2019, 08, 16),
                    PetPrevOwner = null,
                    PetColor = "white"
                });

                _petList.Add(new Pet()
                {
                    PetID = 5,
                    PetName = "Lucy",
                    PetType = "dog",
                    PetPrice = 8000,
                    PetBirthDate = new DateTime(2016, 02, 07),
                    PetPrevOwner = null,
                    PetColor = "black"
                });

                _petList.Add(new Pet()
                {
                    PetID = 6,
                    PetName = "Chloe",
                    PetType = "horse",
                    PetPrice = 790,
                    PetBirthDate = new DateTime(2015, 04, 02),
                    PetPrevOwner = null,
                    PetColor = "grey"
                });
            }
            dataInitialized = true;
        }

        public Pet CreatePet(Pet newPet)
        {
            InitData();

            newPet.PetID = _petList.Count + 1;
            _petList.Add(newPet);
            return newPet;
        }


        public List<Pet> ReadAllPets()
        {
            InitData();
            return _petList;
        }

        public List<Pet> GetSortedList()
        {
            InitData();
            return _petList.OrderBy(o => o.PetPrice).ToList();
        }

        public List<Pet> GetSortedFiveList()
        {
            InitData();

            List<Pet> SortedList = _petList.OrderBy(o => o.PetPrice).ToList();

            var TakeFive = SortedList.Take(5);

            return TakeFive.ToList();
        }

        public List<Pet> GetPetsByType(string type)
        {
            InitData();

            List<Pet> petByType = new List<Pet>();
            foreach (var Pet in _petList)
            {
                if (Pet.PetType.Equals(type))
                {
                    petByType.Add(Pet);
                }
            }
            return petByType;
        }

        public Pet FindPetbyID(int id)
        {
            InitData();

            foreach (var pet in _petList)
            {
                if (pet.PetID == id)
                {
                    return pet;
                }
            }
            return null;
        }


        public Pet UpdateByID(int id, Pet pet)
        {
            InitData();

            foreach (var Pet in _petList)
            {
                if (Pet.PetID == id)
                {
                    Pet.PetName = pet.PetName;
                    Pet.PetType = pet.PetType;
                    Pet.PetBirthDate = pet.PetBirthDate;
                    Pet.PetSoldDate = pet.PetSoldDate;
                    Pet.PetColor = pet.PetColor;
                    Pet.PetPrevOwner = pet.PetPrevOwner;
                    Pet.PetPrice = pet.PetPrice;
                }
            }
            return pet;
        }



        public Pet DeleteByID(int id)
        {
            InitData();

            foreach (var pet in _petList)
            {
                if (pet.PetID == id)
                {
                    _petList.Remove(pet);
                    return pet;
                }
            }
            return null;
        }

        



        
    }
}
