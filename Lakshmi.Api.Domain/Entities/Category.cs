using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lakshmi.Api.Domain.Entities;
public class Category
{
    [Key]
    public Guid Id { get; init; }

    public string Name { get; init; } = default!;

    public Guid? ParentId {  get; init; }

    [ForeignKey(nameof(ParentId))]
    public Category? Parent { get; init; }
}
