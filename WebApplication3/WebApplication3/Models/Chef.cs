namespace WebApplication3.Models
{
    public class Chef
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Info { get; set; } = null!;
        public ChefProfession profession { get; set; } = null!;

        public int ChefProfessionId { get; set; }

        public ChefSocialMedia Media { get; set; } = null!;

        public int ChefSocialMediaId { get; set; }

    }
}
