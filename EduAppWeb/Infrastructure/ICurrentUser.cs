using EduAppWeb.Domain;

namespace EduAppWeb.Infrastructure
{
    public interface ICurrentUser
    {
        ApplicationUser User { get; }
    }
}