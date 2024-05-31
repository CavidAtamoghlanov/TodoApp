using Microsoft.AspNetCore.Identity;
using TodoApp.Contexts;
using TodoApp.Models.Dtos;
using TodoApp.Models.Entities.Concretes;
using TodoApp.Services.Commons;

namespace TodoApp.Services.Concretes;

public class AuthService : IAuthService
{
    private readonly ITokenService _tokenService;
    private  readonly AppDbContext _context;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public AuthService(ITokenService tokenService, AppDbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _tokenService = tokenService;
        _context = context;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public Task<LoginResponseDto> Login(LoginRequestDto dto)
    {

    }
}
