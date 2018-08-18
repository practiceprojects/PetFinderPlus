using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetFinderPlus.Models
{
    public class AnimalType
    {
        [Key]
        public int AnimalTypeID { get; set; }
        public string Dog { get; set; }
        public string Cat { get; set; }
        public string Snake { get; set; }
    }
}