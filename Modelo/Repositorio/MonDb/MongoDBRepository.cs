using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Modelo.Repositorio.MonDb
{
    public class MongoDBRepository
    {
        private readonly string CadenaConexion;

        public MongoDBRepository()
        {
            CadenaConexion = Properties.Settings.Default.Connection;
        }
        private MongoClient GetConnection()
        {
            return new MongoClient(CadenaConexion);
        }

        private MongoDatabaseBase GetDatabase(string database = "")
        {
            MongoDatabaseBase myDB;
            if (string.IsNullOrEmpty(database))
            {
                myDB = null;
            }
            else
            {
                myDB = (MongoDatabaseBase)GetConnection().GetDatabase(database);
            }
            return myDB;
        }

        public IMongoCollection<T> GetCollections<T>(string database = "", string nameCollection = "")
        {
            IMongoCollection<T> collection;


            if (string.IsNullOrEmpty(nameCollection) || string.IsNullOrEmpty(database))
            {
                collection = null;
            }
            else
            {
                collection = GetDatabase(database).GetCollection<T>(nameCollection);
            }
            return collection;
        }


    }
}