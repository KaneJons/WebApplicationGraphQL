using GraphQL;
using GraphQL.Client.Abstractions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationGraphQL.DataAccess;
using WebApplicationGraphQL.ResponseTypes;

namespace WebApplicationGraphQL
{
    public class QueryCharacter
    {
        private readonly IGraphQLClient _client;

        public QueryCharacter(IGraphQLClient client)
        {
            _client = client;
        }

        public async Task<List<Page>>GetAllQuers()
        {
            var query = new GraphQLRequest
            {
                Query = @"query Nice{
                            Page{
                              characters(isBirthday:false){
                                 name {
                                    full
                                    native
                                       }
                                 gender
                                 description
                                 media{
                                   nodes{
                                    title {
                                      english
                                      native
                                          }
                                         }
                                        }
                                       }
                                      }
                                     }"
            };
            var response = await _client.SendQueryAsync<ResponseOwnerCollectionType>(query);
            
            return response.Data.Pages;
            
        }
    }
}
