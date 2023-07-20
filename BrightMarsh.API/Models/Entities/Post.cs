namespace BrightMarsh.API.Models.Entities
{
    public class Post
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Summary { get; set; }

        public string UrlHandle { get; set; }

        public string FeaturedImage { get; set; }

        public bool Visible { get; set; }

        public string Author { get; set; }

        public string PublishDate { get; set; }

        public string UpdateDate { get; set; }

       
    }
}
