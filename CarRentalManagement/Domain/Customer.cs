namespace CarRentalManagement.Domain
{
    public class Customer  : BaseDomainModel
    {
        public String? DrivingLicense { get; set; }
        public String? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? EmailAddress { get; set; }
    }
}
