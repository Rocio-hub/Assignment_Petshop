using System.Collections.Generic;

namespace CompulsoryPetshop.UI
{
    public class Owner
    {
        public int OwnerID { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public int OwnerPhoneNo { get; set; }

        public List<Pet> PetList { get; set; }
    }
}
