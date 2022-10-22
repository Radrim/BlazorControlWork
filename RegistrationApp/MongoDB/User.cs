using MongoDB.Bson.Serialization.Attributes;
using System.Xml.Linq;

namespace RegistrationApp.MongoDB
{
    public class User
    {

        [BsonIgnoreIfDefault]
        public Object _id;

        private string fullName;

        private string email;

        private string login;

        private string password;

        [BsonIgnoreIfDefault]
        public string Name
        {
            get
            {
                return fullName;    // возвращаем значение свойства
            }
            set
            {
                fullName = value;   // устанавливаем новое значение свойства
            }
        }

        [BsonIgnoreIfDefault]
        public string Login
        {
            get
            {
                return login;    // возвращаем значение свойства
            }
            set
            {
                login = value;   // устанавливаем новое значение свойства
            }
        }

        [BsonIgnoreIfDefault]
        public string Password
        {
            get
            {
                return password;    // возвращаем значение свойства
            }
            set
            {
                password = value;   // устанавливаем новое значение свойства
            }
        }

        [BsonIgnoreIfDefault]
        public string Email
        {
            get
            {
                return email;    // возвращаем значение свойства
            }
            set
            {
                email = value;   // устанавливаем новое значение свойства
            }
        }
    }
}
