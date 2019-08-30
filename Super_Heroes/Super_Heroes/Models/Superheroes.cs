using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Super_Heroes.Models
{
    public class Superheroes
    {
        [Key]
        public int superheroId { get; set; }
        [Display(Name = "Superhero Name")]
        public string superheroName { get; set; }
        [Display(Name = "Alter Ego")]
        public string alterEgo { get; set; }
        [Display(Name = "Primary Ability")]
        public string primaryAbility { get; set; }
        [Display(Name = "Secondary Ability")]
        public string secondaryAbility { get; set; }
        [Display(Name = "Catchphrase")]
        public string catchphrase { get; set; }
    }
}