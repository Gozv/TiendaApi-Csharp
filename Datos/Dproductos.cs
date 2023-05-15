﻿using System.Data;
using System.Data.SqlClient;
using Tienda_Api.Conexion;
using Tienda_Api.Modelo;
namespace Tienda_Api.Datos
{
    public class Dproductos
    {
        ConexionBD cn = new ConexionBD();
        public async Task <List<Mproductos>> Mostrarproductos()
        {
            var lista = new List<Mproductos>();
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("mostrarProductos", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var item = await cmd.ExecuteReaderAsync()) 
                    {
                    while(await item.ReadAsync()) 
                        {
                            var mproductos = new Mproductos();
                            mproductos.id = (int)item["id"];
                            mproductos.descripcion = (string)item["descripcion"];
                            mproductos.precio = (decimal)item["precio"];
                            lista.Add(mproductos);
                        }
                    }
                }
            }
            return lista;   
        }
    }
}
