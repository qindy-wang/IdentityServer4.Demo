using IdentityModel;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IdentityModel.OidcConstants;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("api1","My API")
            };
        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    AllowedGrantTypes= { OidcConstants.GrantTypes.ClientCredentials },
                    ClientId="client",
                    ClientSecrets =
                    {
                        new Secret("secret".ToSha256())
                    },
                    AllowedScopes  ={"api1"}
                }
            };
    }
}
