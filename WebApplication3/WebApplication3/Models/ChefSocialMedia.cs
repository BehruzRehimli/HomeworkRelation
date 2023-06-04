namespace WebApplication3.Models
{
    public class ChefSocialMedia
    {
        public int Id { get; set; }
        public string FbUrl { get; set; }=null!;
        public string IgUrl { get; set; } = null!;
        public string TwitterUrl { get; set; } = null!;
        public string InUrl { get; set; } = null!;

        public Chef Chef { get; set; } = null!;
    }
}
