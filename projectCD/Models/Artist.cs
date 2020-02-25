using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projectCD.Models
{
    public class Artist
    {
        //Properties
        [Key]
        public int ArtistId { get; set; }

        [Required(ErrorMessage = "Välj namn på artist!")]
        public string Name { get; set; }

        public ICollection<Album> Albums { get; set; }

    }

}