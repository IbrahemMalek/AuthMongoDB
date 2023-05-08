using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace AuthMongoDB.Models
{
    [CollectionName("Roles")]
    public class ApplicationRole:MongoIdentityRole<Guid>
    {
    }
}
