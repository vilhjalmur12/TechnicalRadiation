namespace TechnicalRadiation.Models.Entities
{
    public class NewsAuthorRelation
    {
        public int Id { get; set; }
        public int newsId { get; set; }
        public int authorId { get; set; }
    }
}