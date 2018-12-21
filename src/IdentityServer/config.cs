using System;
using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace auth
{
    public class Config{
        public static List<ApiResource> GetApiResources(){
            return new List<ApiResource>(){
                new ApiResource("api1","API 1")
            };
        }

        public static List<Client> GetClients(){
            return new List<Client>(){
                new Client(){
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = {"api1"}
                },
                new Client(){
                    ClientId = "pwdClient",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    ClientSecrets = {new Secret("secret".Sha256())},
                    AllowedScopes = {"api1"}
                }
            };
        }

        public static List<TestUser> GetUsers(){
            return new List<TestUser>(){
                new TestUser(){
                    SubjectId ="1",
                    Username = "chenqi",
                    Password="123456"
                }
            };
        }
    }
}