namespace TechnicalRadiation.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProfileImgSource { get; set; }
        public string Bio { get; set; }
        /* 
        These should be code generated commented out for now
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        */
    }
}