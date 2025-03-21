namespace AOPortfolioFull.Domain.Entities;

public class Form : BaseEntity
{
    public Guid Id { get; set; }
    public string? FormName { get; set; }
    public string? FormEmail { get; set; }
    public string? FormSubject { get; set; }
    public string? FormMessage { get; set; }
    public DateTime? FormSendDate { get; set; }
    public Form() { }
    public Form(string? formName, string? formEmail, string? formSubject, string? formMessage, DateTime? formSendDate)
    {
        Id = Guid.NewGuid();
        FormName = formName;
        FormEmail = formEmail;
        FormSubject = formSubject;
        FormMessage = formMessage;
        FormSendDate = formSendDate;
    }
}
