using System.Runtime.InteropServices;
using Contoso.Abstractions.Entities;

namespace Contoso.Entities;

public class UsersVideo : IEntity
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public int VideoId { get; set; }
    public DateTime DateRegister { get; set; }
    public User User { get; set; } = null!;
    public Video Video { get; set; } = null!;
}