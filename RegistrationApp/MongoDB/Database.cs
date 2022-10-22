using global::MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Xml.Linq;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace RegistrationApp.MongoDB
{
    static public class Database
    {
        public static void AddToDatabase(User user)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);
        }

        public static User FindByName(string login, string password)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Users");
            var collection = database.GetCollection<User>("Users");
            var user = collection.Find(x => x.Login == login).FirstOrDefault();

            if (user != null)
            {
                return null;
            }
            if (user.Password == password)
            {
                return user;
            }

            return null;
        }
    }
}
