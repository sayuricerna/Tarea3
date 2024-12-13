using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3.Datos;

namespace Tarea3.Logica
{
    internal class cls_autores
    {
        private readonly conexion cn = new conexion();

  
            public List<dto_autores> todos() {
            var listaautores = new List<dto_autores>();
            using (var conexion = cn.obtenerConexion())//1 llamo a la conexion con la base
            {
                string cadena = "SELECT au_id, au_name, au_fname, phone, adress, city, state, zip, contract FROM authors";
                 //2 creo la sentencia sql
                using (var comando = new SqlCommand(cadena, conexion)) //3 ejecuto el comando 
                {
                    conexion.Open(); //4 abrir la conexion
                    using (var lector = comando.ExecuteReader())//5 cargar el lector la informacion
                    {
                        while (lector.Read())  //6 recorrer el lector para obtener la iformacion
                        {
                            var autor = new dto_autores //7  creo un objeto dto_personal para asiganr lo que trae de la base de datos
                            {
                                au_id = lector["au_id"].ToString(),
                                au_lname = lector["au_lname"].ToString(),
                                au_fname = lector["au_fname"].ToString(),
                                phone = lector["phone"].ToString(),
                                address = lector["address"].ToString(),
                                city = lector["city"].ToString(),
                                state = lector["state"].ToString(),
                                zip = lector["zip"].ToString(),
                                contract = (bool)lector["contract"]

                            };
                            listaautores.Add(autor); //8 agregar a la lista el objeto
                        }
                    }
                }
            }

            return listaautores;
        }



    }
}
