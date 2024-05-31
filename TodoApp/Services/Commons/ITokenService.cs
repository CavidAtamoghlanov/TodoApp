using TodoApp.Models.Entities.Concretes;

namespace TodoApp.Services.Commons;

public interface ITokenService
{
    string GenerateToken(User user);
}
