using LaboratorioFinalDB.Data.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LaboratorioFinalDB.Data
{
    internal class ConexionJugadores
    {
        string connectionString = "server=localhost;database=final_examen;user=root;password=Leonel/2005";

        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }



        //CREATE: Insertar un registro con una clase model
        public bool CrearJugador(Futbol cons)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                try
                {
                    string consulta = "INSERT INTO Jugadores (id, nombre, apellido, edad, dorsal, posicion, sigue) VALUES (@id, @nombre, @apellido, @edad, @dorsal, @posicion, @sigue)";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", cons.Id);
                        cmd.Parameters.AddWithValue("@nombre", cons.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", cons.Apellido);
                        cmd.Parameters.AddWithValue("@edad", cons.Edad);
                        cmd.Parameters.AddWithValue("@dorsal", cons.Dorsal);
                        cmd.Parameters.AddWithValue("@posicion", cons.Posicion);
                        cmd.Parameters.AddWithValue("@sigue", cons.Sigue);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    return true; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        //READ: Seleccionar todos los registros usando List
        public List<Futbol> ObtenerTodosLosRegistros()
        {
            List<Futbol> Futboleros = new List<Futbol>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM Jugadores";
                MySqlCommand cmd = new MySqlCommand(consulta, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Futbol consola = new Futbol
                        (
                            id: reader.GetInt32("id"),
                            nombre: reader.GetString("nombre"),
                            apellido: reader.GetString("apellido"),
                            edad: reader.GetInt32("edad"),
                            dorsal: reader.GetInt32("dorsal"),
                            posicion: reader.GetString("posicion"),
                            sigue: reader.GetString("sigue")
                        );

                        Futboleros.Add(consola);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer los registros: " + ex.Message);
                }
            }

            return Futboleros;
        }


        //Buscar un registro por ID
        public DataRow BuscarRegistroporID(int id)
        {
            DataTable data = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string consulta = "SELECT * FROM Jugadores WHERE id = @ID";
                    MySqlCommand cmd = new MySqlCommand(consulta, connection);
                    cmd.Parameters.AddWithValue("@ID", id);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    connection.Open();
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return data.Rows[0];
        }



        //UPDATE: Actualizar un registro
        public bool Actualizar(Futbol cons)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString)){
                try
                {
                    string consulta = "UPDATE Jugadores SET nombre = @nombre= @Nombre, apellido = @Apellido, edad = @Edad, dorsal = Dorsal, posicion = Posicion, sigue = Sigue WHERE id = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", cons.Id);
                        cmd.Parameters.AddWithValue("@Nombre", cons.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", cons.Apellido);
                        cmd.Parameters.AddWithValue("@Edad", cons.Edad);
                        cmd.Parameters.AddWithValue("@Doral", cons.Dorsal);
                        cmd.Parameters.AddWithValue("@Posicion", cons.Posicion);
                        cmd.Parameters.AddWithValue("@Sigue", cons.Sigue);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        //DELETE: Eliminar un registro
        public bool Eliminar(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string consulta = "DELETE FROM Jugadores WHERE id = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



        //FILTRAR REGISTROS

        //Por delantero
        public List<Futbol> ObtenerRegistrosDelantero()
        {
            List<Futbol> Futboleros = new List<Futbol>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM Jugadores WHERE posicion='delantero'";
                MySqlCommand cmd = new MySqlCommand(consulta, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Futbol fut = new Futbol
                        (
                               id: reader.GetInt32("id"),
                            nombre: reader.GetString("nombre"),
                            apellido: reader.GetString("apellido"),
                            edad: reader.GetInt32("edad"),
                            dorsal: reader.GetInt32("dorsal"),
                            posicion: reader.GetString("posicion"),
                            sigue: reader.GetString("sigue")

                        );

                        Futboleros.Add(fut);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer los registros: " + ex.Message);
                }
            }

            return Futboleros;
        }



        //Por centrocampista
        public List<Futbol> ObtenerRegistrosCentrocampista()
        {
            List<Futbol> consolas = new List<Futbol>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM Jugadores WHERE posicion='Centrocampista'";
                MySqlCommand cmd = new MySqlCommand(consulta, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Futbol consola = new Futbol
                        (
                               id: reader.GetInt32("id"),
                            nombre: reader.GetString("nombre"),
                            apellido: reader.GetString("apellido"),
                            edad: reader.GetInt32("edad"),
                            dorsal: reader.GetInt32("dorsal"),
                            posicion: reader.GetString("posicion"),
                            sigue: reader.GetString("sigue")
                        );

                        consolas.Add(consola);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer los registros: " + ex.Message);
                }
            }

            return consolas;
        }



        //Por Defensa
        public List<Futbol> ObtenerRegistrosDefensa()
        {
            List<Futbol> Futboleros = new List<Futbol>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM Jugadores WHERE posicion='Defensa'";
                MySqlCommand cmd = new MySqlCommand(consulta, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Futbol consola = new Futbol
                        (
                                id: reader.GetInt32("id"),
                            nombre: reader.GetString("nombre"),
                            apellido: reader.GetString("apellido"),
                            edad: reader.GetInt32("edad"),
                            dorsal: reader.GetInt32("dorsal"),
                            posicion: reader.GetString("posicion"),
                            sigue: reader.GetString("sigue")
                        );

                        Futboleros.Add(consola);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer los registros: " + ex.Message);
                }
            }

            return Futboleros;
        }

        //Por Portero
        public List<Futbol> ObtenerRegistrosPortero()
        {
            List<Futbol> consolas = new List<Futbol>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM Jugadores WHERE posicion='Portero'";
                MySqlCommand cmd = new MySqlCommand(consulta, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Futbol consola = new Futbol
                        (
                                id: reader.GetInt32("id"),
                            nombre: reader.GetString("nombre"),
                            apellido: reader.GetString("apellido"),
                            edad: reader.GetInt32("edad"),
                            dorsal: reader.GetInt32("dorsal"),
                            posicion: reader.GetString("posicion"),
                            sigue: reader.GetString("sigue")
                        );

                        consolas.Add(consola);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer los registros: " + ex.Message);
                }
            }

            return consolas;
        }










    }
}
