using System.ComponentModel.DataAnnotations;

namespace TechnicalRadiation.Models
{
    public class CategoryInputModel
    {
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        //defaults to 0
        public int ParentCategoryId { get; set; }
        /*
        Should be generated by making the Name above
        lowercase and join the words together with (-)
        Example:
        Science Fiction == science-fiction
        */
        public string Slug { get; set; }
    }
}