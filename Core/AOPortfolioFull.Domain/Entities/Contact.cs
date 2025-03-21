namespace AOPortfolioFull.Domain.Entities;

public class Contact : BaseEntity
{
    public Guid Id { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Map { get; set; }
    public Contact() { }
    public Contact(string? address, string? phone, string? email, string? map)
    {
        Id = Guid.NewGuid();
        Address = address;
        Phone = phone;
        Email = email;
        Map = map;
    }
}
