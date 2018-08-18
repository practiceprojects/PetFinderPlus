using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PetFinderPlus.Models
{
    public class Breed
    {
        [Key]
        public int BreedId { get; set; }
        public string PitBull { get; set; }
        public string GermanShephard { get; set; }
        public string Siamese { get; set; }
        public string BlackCat { get; set; }
        public string BlackMamba { get; set; }
        public string Python { get; set; }

        [ForeignKey("AnimalTypeId")]
        public int AnimalTypeId { get; set; }
        public virtual AnimalType AnimalType { get; set; }
    }
}