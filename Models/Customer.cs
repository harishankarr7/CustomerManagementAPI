namespace CustomerManagementApi.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public required string FirstName { get; set; } // Add the 'required' modifier
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
    }
}
