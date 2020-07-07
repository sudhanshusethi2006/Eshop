using System;
using System.ComponentModel.DataAnnotations;

namespace EshopApp.ViewModels
{
    public class ContactViewModel
    {

        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(250)]
        public string Message { get; set; }

    }

}

