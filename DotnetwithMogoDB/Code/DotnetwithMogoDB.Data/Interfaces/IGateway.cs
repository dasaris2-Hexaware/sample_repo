using MongoDB.Driver;

namespace DotnetwithMogoDB.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
