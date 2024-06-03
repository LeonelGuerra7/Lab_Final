using LaboratorioFinalDB.Data;
using LaboratorioFinalDB.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LaboratorioFinalDB
{
    public partial class Form1 : Form
    {

        ConexionJugadores conexionJugadoresFut = new ConexionJugadores();
        List<Futbol> todos_losRegistros;
        CursorLista cursor1 = new CursorLista();

        // Lista de compañias
        private string[] companiasConsolas = {
            "Delantero",
            "Centrocampista",
            "Defensa",
            "Portero",
          
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (conexionJugadoresFut.ProbarConexion())
            {
                MessageBox.Show("La conexion con la base de datos fue exitosa.");
            }
            else
            {
                MessageBox.Show("Algo fallo al intentar hacer la conexion con la base de datos.");
            }

            comboBoxPosicion.Items.AddRange(companiasConsolas);
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            Consola consCrear = new Consola();

            consCrear.Id = Int32.Parse(textBoxID.Text);
            consCrear.Nombre = textBoxNombre.Text;
            consCrear.Apellido = textApellido.Text;
            consCrear.Edad = Int32.Parse(textBoxEdad.Text);
            consCrear.Dorsal = Int32.Parse(textDorsal.Text);
            consCrear.Posicion = comboBoxPosicion.Text;
            consCrear.Sigue = textSigue.Text;

            if (conexionJugadoresFut.CrearJugador(consCrear))
            {
                MessageBox.Show("El registro fue creado exitosamente.");
                dataGridViewConsolas.DataSource = conexionJugadoresFut.ObtenerTodosLosRegistros();
                ActualizarTotalRegistros();
            }
            else
            {
                MessageBox.Show("El registro no fue creado dentro de la base de datos.");
            }
        }


        private void buttonCargarRegistros_Click(object sender, EventArgs e)
        {
            todos_losRegistros = conexionJugadoresFut.ObtenerTodosLosRegistros();
            dataGridViewConsolas.DataSource = todos_losRegistros;

            if (todos_losRegistros.Count > 0)
            {
                cursor1.totalRegistros = todos_losRegistros.Count;
            }
        }

        private void buttonBuscarPorID_Click(object sender, EventArgs e)
        {
            int id_buscar = Int32.Parse(textBoxID.Text);
            DataRow registro_encontrado = conexionJugadoresFut.BuscarRegistroporID(id_buscar);

            if (registro_encontrado != null)
            {
                textBoxID.Text = registro_encontrado["id"].ToString();
                textBoxNombre.Text = registro_encontrado["nombre"].ToString();
                textApellido.Text = registro_encontrado["apellido"].ToString();
                textBoxEdad.Text = registro_encontrado["edad"].ToString();
                textDorsal.Text = registro_encontrado["dorsal"].ToString();
                textSigue.Text = registro_encontrado["sigue"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontro registro con este id.");
            }

            cursor1.actual = id_buscar - 1;
        }


        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Consola consActualizar = new Consola();
            
            consActualizar.Id = Convert.ToInt32(textBoxID.Text);
            consActualizar.Nombre = textBoxNombre.Text;
            consActualizar.Apellido = textApellido.Text;
            consActualizar.Edad = Int32.Parse(textBoxEdad.Text);
            consActualizar.Dorsal = Int32.Parse(textDorsal.Text);
            consActualizar.Posicion = comboBoxPosicion.Text;
            consActualizar.Sigue = textSigue.Text;

            DialogResult resultado = MessageBox.Show("Estas seguro de que deseas actualizar este registro en la base de datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                if (conexionJugadoresFut.Actualizar(consActualizar))
                {
                    MessageBox.Show("El registro fue actualizado exitosamente.");
                    dataGridViewConsolas.DataSource = conexionJugadoresFut.ObtenerTodosLosRegistros();
                    ActualizarTotalRegistros();
                }
                else
                {
                    MessageBox.Show("El registro no fue actualizado dentro de la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Modificaciones no realizadas.");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxID.Text);
            
            DialogResult resultado = MessageBox.Show("Estas seguro de que deseas eliminar permanentemente este registro en la base de datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                if (conexionJugadoresFut.Eliminar(id))
                {
                    MessageBox.Show("El registro fue eliminado exitosamente.");
                    dataGridViewConsolas.DataSource = conexionJugadoresFut.ObtenerTodosLosRegistros();
                    ActualizarTotalRegistros();
                }
                else
                {
                    MessageBox.Show("El registro no fue eliminado dentro de la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Modificaciones no realizadas.");
            }
        }


        //NAVEGACION DE REGISTROS
        private void MostrarRegistroActual()
        {
            if (cursor1.actual >= 0 && cursor1.actual < cursor1.totalRegistros)
            {
                Consola c = todos_losRegistros[cursor1.actual];
                textBoxID.Text = c.Id.ToString();
                textBoxNombre.Text = c.Nombre;
                comboBoxPosicion.Text = c.Posicion;
                textApellido.Text = c.Apellido.ToString();
                textBoxEdad.Text = c.Edad.ToString();
            }
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
          
            if (cursor1.actual < cursor1.totalRegistros - 1) // Verificar antes de incrementar
            {
                cursor1.actual++;
                MostrarRegistroActual();
            }
            else
            {
                MessageBox.Show("Fin de los registros.");
            }
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (cursor1.actual > 0) // Verificar antes de decrementar
            {
                cursor1.actual--;
                MostrarRegistroActual();
            }
            else
            {
                MessageBox.Show("Fin de los registros.");
            }
        }
        
        public void ActualizarTotalRegistros()
        {
            todos_losRegistros = conexionJugadoresFut.ObtenerTodosLosRegistros();

            if (todos_losRegistros.Count > 0)
            {
                cursor1.totalRegistros = todos_losRegistros.Count;
            }
        }

        private void buttonFiltrar_porNintendo_Click(object sender, EventArgs e)
        {
            List<Futbol> registrosDelantero;

            registrosDelantero = conexionJugadoresFut.ObtenerRegistrosDelantero();
            dataGridViewConsolas.DataSource = registrosDelantero;
        }

        private void buttonFiltrar_porSega_Click(object sender, EventArgs e)
        {
            List<Futbol> registrosDefensa;

            registrosDefensa = conexionJugadoresFut.ObtenerRegistrosCentrocampista();
            dataGridViewConsolas.DataSource = registrosDefensa;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Futbol> registrosCentrocampista;

            registrosCentrocampista = conexionJugadoresFut.ObtenerRegistrosCentrocampista();
            dataGridViewConsolas.DataSource = registrosCentrocampista;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonPor_Click(object sender, EventArgs e)
        {
            List<Consola> registrosPortero;

            registrosPortero = conexionJugadoresFut.ObtenerRegistrosPortero();
            dataGridViewConsolas.DataSource = registrosPortero;
        }

        private void comboBoxPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
