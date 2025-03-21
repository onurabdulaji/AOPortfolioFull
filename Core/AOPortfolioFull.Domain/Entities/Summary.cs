namespace AOPortfolioFull.Domain.Entities;

public class Summary : BaseEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public Summary()
    {

    }
    public Summary(string name, string description, string address, string phone, string email)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Address = address;
        Phone = phone;
        Email = email;
    }
}
