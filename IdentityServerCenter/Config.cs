
using System.Collections.Generic;
using IdentityServer4.Models;

namespace IdentityServerCenter{
    public class Config{
        public static IEnumerable<ApiResource> GetResources()
        {
           return new List<ApiResource>{new ApiResource("api","MyAPI")};           
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>{
            new Client{ClientId="client",AllowedGrantTypes=GrantTypes.ClientCredentials,
            ClientSecrets={new Secret("secret".Sha256())},
            AllowedScopes={"api"}
            }};
        }
    }
}