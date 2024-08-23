using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lakshmi.Api.Domain.Entities;
public class Transaction
{
    [Key]
    public Guid Id { get; init; }

    public DateOnly Date { get; init; }

    public decimal Amount { get; init; }

    public string Description { get; init; } = string.Empty;

    public Guid AccountId { get; init; }

    public Guid CategoryId { get; init; }

    [ForeignKey(nameof(AccountId))]
    public Account Account { get; init; } = default!;

    [ForeignKey(nameof(CategoryId))]
    public Category Category { get; init; } = default!;
}
