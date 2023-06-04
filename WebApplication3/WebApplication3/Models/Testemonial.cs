namespace WebApplication3.Models
{
    public class Testemonial
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; }= null!;
        public string About { get; set; } = null!;
        public string Image { get; set; } = null!;

        public TestemonialProfession Profession { get; set; } = null!;
        public int TestemonialProfessionId { get; set; }



    }
}
