using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
/*

namespace JWTAuthTest.Controllers;

[ApiController, Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly DbContext _db;
    private readonly IConfiguration _config;

    private readonly SymmetricSecurityKey _securityKey;

    public UsersController (DbContext db, IConfiguration config)
    {
        _db = db;
        _config = config;

        _securityKey = new(Encoding.UTF8.GetBytes(_config["JWT:Key"]));
    }

    [HttpGet, Authorize]
    public IEnumerable<User> Get ()
    {
        return _db.Users;
    }

    //[HttpPost("Test")]
    //public ActionResult PostTest([FromBody] User user)
    //{
    //    return Forbid();
    //}

    [HttpPost]
    public string Post ([FromBody] User user)
    {
        _db.Users.Add(user);

        // Набор данных о юзере
        List<Claim> claims = new List<Claim>() {
            new(ClaimTypes.Name, user.Username),
            new(ClaimTypes.UserData, user.Pass)
        };

        // Процесс создания токена:

        var token = new JwtSecurityToken(
            issuer: _config["JWT:Issuer"],
            audience: _config["JWT:Audience"],
            claims: claims,
            // время истечения токена
            expires: DateTime.UtcNow.AddMinutes(10),
            // подпись
            signingCredentials: new(_securityKey, SecurityAlgorithms.HmacSha256));

        // Создаём токен и возращаем на клиент
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}*/