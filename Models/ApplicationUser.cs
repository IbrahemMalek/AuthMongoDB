using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace AuthMongoDB.Models
{
    [CollectionName("Users")]
    public class ApplicationUser:MongoIdentityUser<Guid>
    {
    }
}
