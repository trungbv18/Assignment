using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoviePraci.Models
{
    public class Movie
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long MovieId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Name must be more than 6 and less than 50 characters")]
        public string MovieTitle { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Range(60, 180, ErrorMessage = "RunningTime from 60 to 180 minutes")]
        public int RunningTime { get; set; }
        [Required]
        public long GenreId { get; set; }
        public virtual Genre Genre { get; set; } 
    }
}