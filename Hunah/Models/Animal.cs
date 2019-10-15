using System.Collections.Generic;

namespace Hunah.Models
{
    public class Animal
    {
        // animal object properties
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Breed { get; set; }
        public int AnimalId { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
        public int SpeciesId { get; set; }
        public virtual Species Species { get; set; }
    }
}