using System;
using System.ComponentModel.DataAnnotations;

namespace SavingSQLData.Models
{
    public class Idea
    {
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Business { get; set; }
        [Required]
        public string Office { get; set; }
        [Required]
        public string IdeaDescription { get; set; }
        [Required]
        public string Scope { get; set; }
    }
}