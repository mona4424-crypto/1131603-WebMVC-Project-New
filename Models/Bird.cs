using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models
{
    [Table("TableBirds1131603")]
    public class Bird
    {
        [Key]
        public int BirdID { get; set; }

        public string BirdName { get; set; } = "";

        public string EnglishName { get; set; } = "";

        public string Category { get; set; } = "";

        public string Description { get; set; } = "";

        public string ImagePath { get; set; } = "";

        public string FoundLocation { get; set; } = "";
    }
}