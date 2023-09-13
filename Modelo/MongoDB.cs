using MongoDB.Driver;


namespace Modelo.MongoDBs
{
    public class MongoDBs
    {


        private static string cadena = "mongodb+srv://nic-angel-admin:X89F2N8x4qCJlfyE@cluster0.so9bo28.mongodb.net/?retryWrites=true&w=majority";

        public static MongoClient GetConnection()
        {
            MongoClient _client = new MongoClient(cadena);
            try
            {
                List<string> Check = _client.ListDatabaseNames().ToList();
                foreach (string check in Check)
                {
                    MessageBox.Show("Conexión Exitosa en el Server, Bases de Datos Disponibles" + check);
                }
            }
            catch (MongoClientException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return _client;
        }

        public static IMongoDatabase GetDatabase(string Database = "")
        {
            if (string.IsNullOrEmpty(Database))
            {
                MessageBox.Show("Escriba el nombre de la base de datos a usar");
                return null;
            }
            else
            {
                return GetConnection().GetDatabase(Database);
            }

        }
    }
}