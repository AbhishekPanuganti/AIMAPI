using Microsoft.IdentityModel.Tokens;
using NLLCOMMONAPI.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NLLCOMMONAPI.Data.Services
{
    public class JwtService
    {
        private readonly IConfiguration _configuration;
        public JwtService(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<LoginResponse> ValidateUser(LoginRequest loginRequest)
        {
            if (loginRequest == null)
                throw new ArgumentNullException(nameof(loginRequest));

            var loginResponse = new LoginResponse();

            var issuer = _configuration["JwtConfig:Issuer"];
            var audience = _configuration["JwtConfig:Audience"];
            var key = _configuration["JwtConfig:Key"];
            var tokenExpiry = _configuration.GetValue<int>("JwtConfig:TokenExpiry");

            if (string.IsNullOrEmpty(issuer) || string.IsNullOrEmpty(audience) || string.IsNullOrEmpty(key))
                throw new InvalidOperationException("JWT configuration is missing.");

            var tokenExpiryTimeStamp = DateTime.UtcNow.AddMinutes(tokenExpiry);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim(JwtRegisteredClaimNames.Name, loginRequest.Username),
                        new Claim("globalid", "00015078")
                }),
                Expires = tokenExpiryTimeStamp,
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var accessToken = tokenHandler.WriteToken(securityToken);

            loginResponse.Username = loginRequest.Username;
            loginResponse.Token = accessToken;

            // Simulate async operation
            await Task.CompletedTask;

            return loginResponse;
        }
    }
}
