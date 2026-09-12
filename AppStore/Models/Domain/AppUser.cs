using Microsoft.AspNetCore.Identity;

namespace AppStore.Models.Domain;

public class AppUser : IdentityUser
{
    public string? Nickname { get; set; }
}