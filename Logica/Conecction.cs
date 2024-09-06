using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;



using ExelSolar.Classes;
using ExelSolar.Logica;

namespace ExelSolar.Logica

{
    //clase conexión para realizar las consultas
    public class Conecction
    {   
        //nombre de la base de datos
        private string DataBase;
        //objeto de la clase conecction para hacerlo nulo
        private static Conecction con = null;

        //Constructor de la clase para crearlo
        private Conecction() { 
            this.DataBase = "./bd_Clients.db";        
        }


        //creamos un método que devuelve un objeto de tipo SQLiteconexión para crear una conexión
        public SQLiteConnection CreateConnection()
        {
            //Creación de la instancia SQLiteConnection
            SQLiteConnection Cadena = new SQLiteConnection();
            //prueba si la conexion ha sido exitosa del tipo de obte
            try
            {
                //concatenamo la instancia con el nombre de la base. 
                Cadena.ConnectionString = "Data source="+this.DataBase;
            }
            catch
            {
                //si ya existe la hacemos nulo y realizamos una exception
                Cadena = null;
                throw;
            }

            //devolvemos el objeto tipo cadena
            return Cadena;
        }

        //creamos un método estático que devuelve un objeto de tipo conexión que crea una única instancia.
        public static Conecction getInstance()
        {
            if (con == null)
            {
                con = new Conecction();
            }
            return con;     
        }


    }
}
