namespace TechnicalRadiation.Models.Entities
{
    public class NewsCategoryRelation
    {
        public int Id { get; set; }
        public int newsId { get; set; }
        public int categoryId { get; set; }
    }
}