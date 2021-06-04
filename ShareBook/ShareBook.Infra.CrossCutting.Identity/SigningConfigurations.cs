using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ShareBook.Infra.CrossCutting.Identity
{
    public class SigningConfigurations
    {
        public SecurityKey Key { get; }
        public SigningCredentials SigningCredentials { get; }

        public SigningConfigurations(IConfiguration configuration)
        {
            // Token persistente a server reset. Bom para clusterização.
            // fonte: https://balta.io/artigos/aspnet-5-autenticacao-autorizacao-bearer-jwt

            var keyString = configuration["TokenConfigurations:Key"];
            Key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(keyString));
            SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
