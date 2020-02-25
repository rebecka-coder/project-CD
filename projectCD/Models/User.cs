using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projectCD.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Välj namn på användare!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Välj datum!")]
        public int DateTime { get; set; }

        public int AlbumId { get; set; }
        public Album Album { get; set; }


    }
}