namespace Wealth.Domain;

public sealed class Portfolio
{
    public Guid Id { get; private set; }

    public string ReferenceNo { get; private set; } = null!;

    public Guid TenantId { get; private set; }

    public string Name { get; private set; } = null!;

    public Guid BaseCurrencyId { get; private set; }

    public string? Description { get; private set; }

    public short Status { get; private set; }

    public DateTime CreatedOn { get; private set; }

    public DateTime UpdatedOn { get; private set; }
}