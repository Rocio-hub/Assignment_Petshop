using System;

namespace CompulsoryPetshop.UI
{
    public class Pet
    {
        public int PetID  { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }
        public DateTime PetBirthDate { get; set; }
        public DateTime PetSoldDate { get; set; }
        public string PetColor { get; set; }
        public Owner PetPrevOwner { get; set; }
        public double PetPrice { get; set; }
    }
}
