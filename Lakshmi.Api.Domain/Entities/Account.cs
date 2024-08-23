using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lakshmi.Api.Domain.Entities;
public class Account
{
    [Key]
    public Guid Id { get; init; }

    public string Name { get; init; } = default!;

    public float Balance { get; init; }

    public ICollection<string> UserIds { get; init; } = default!;

    [ForeignKey(nameof(UserIds))]
    public IdentityUser Users { get; init; } = default!;
}
 