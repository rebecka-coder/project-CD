using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectCD.Models
{
    public class Album
    {
        //Properties
        [Key]
        public int AlbumId { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        [Required(ErrorMessage = "Välj namn på album!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Välj genre på album!")]
        public string Genre { get; set; }

        public ICollection<User> Users { get; set; }
    
    }
}
