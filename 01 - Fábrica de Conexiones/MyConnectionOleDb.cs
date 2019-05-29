using System;
//Namespaces necesarion para realizar la conexion a OleDb
using System.Data;
using System.Data.OleDb;
namespace _01___Fábrica_de_Conexiones
{
     class MyConnectionOleDb:MyConnection
    {
        //Constructor
        public MyConnectionOleDb(DataProvider theDataProvider):base(theDataProvider)
        {
            //crear la cadena de conexion
            OleDbConnection connectionString = new OleDbConnection(@"provider=");
            try
            {
                //Establecer la conexion
                connectionString.Open();
                Console.WriteLine("Conexion establecida");

                //Detales de la conexion
                this.DetalleConexion(connectionString);
            }
            catch(OleDbException e)
            {
                //Desplegar el error de la conexion
                Console.WriteLine("Error { 0} { 1}",e.Message,e.StackTrace);
            }
            finally
            {

            }
           


        }

      protected void DetalleConexion(OleDbConnection connectionString)
        {
            Console.WriteLine("Conexion establecida");
            Console.WriteLine("\tConnection string: {0}", connectionString.ConnectionString);
            Console.WriteLine("\tBase de datos: {0}", connectionString.Database);
            Console.WriteLine("\tFuente de datos: {0}", connectionString.DataSource);
            Console.WriteLine("\tVersion del servidor: {0}", connectionString.ServerVersion);
            Console.WriteLine("\tEstado_ {0}", connectionString.State);

        }
    }
}