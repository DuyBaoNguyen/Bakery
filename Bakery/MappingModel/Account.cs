namespace Bakery.MappingModel
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }
        public Employee Employee { get; set; }
    }
}
