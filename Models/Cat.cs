using System.ComponentModel.DataAnnotations;
using System;

namespace testbuild2.Models
{

    public class Cat
    {

        public int Id { get; set; }

        [Required]
        [MinLength(6)]

        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        public Cat() { }
        public Cat(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}