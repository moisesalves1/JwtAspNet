using System.IdentityModel.Tokens.Jwt;

namespace JwtAspNet.Services
{
    public class TokenService
    {
        public string Create()
        {
            var handler = new JwtSecurityTokenHandler();

            var token = handler.CreateToken();

            return handler.WriteToken(token);
        }
    }
}
