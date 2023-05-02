using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> Clients =>
         new Client[]
             {
             new Client
            {
                ClientId = "demosession",
                ClientName = "Example client application using client credentials",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = new List<Secret> {new Secret("training".Sha256())}, // change me!
                AllowedScopes = new List<string> { "userapi" },
                Claims = new List<ClientClaim>{
                new ClientClaim(ClaimTypes.Role,"admin")
                }
            },
             new Client
            {
                ClientId = "demosession2",
                ClientName = "Example client application using client credentials",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = new List<Secret> {new Secret("training".Sha256())}, // change me!
                AllowedScopes = new List<string> { "movieapi" },
                Claims = new List<ClientClaim>{
                new ClientClaim(ClaimTypes.Role,"admin")
                }
            }

        };
        public static IEnumerable<ApiScope> ApiScopes =>
                 new ApiScope[]
                 {
             new ApiScope("userapi", "User API"),
             new ApiScope("movieapi", "Movie API")
                 };
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new[]
            {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
            new IdentityResource
            {
                Name = "role",
                UserClaims = new List<string> {"role"}
            }
        };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
            new ApiResource
            {
              
            }
        };
        }

        public static List<TestUser> TestUsers()
        {
            return new List<TestUser> {
            new TestUser {
                
            }
        };
        }
    }
}
