namespace Tienda_Api.Conexion
{
    public class ConexionBD
    {
        private string connectionString = string.Empty;
        public ConexionBD()
        {
            var Builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile
                ("appsettings.json").Build();
            connectionString = Builder.GetSection("ConnectionStrings:conexionmaestra").Value;
        }
        public string cadenaSQL()
        {
            return connectionString;
        }
    }
}
