using Newtonsoft.Json;
using Practica1Agenda.Clases;
using System;
using System.IO;
using System.Windows.Forms;

namespace Practica1Agenda
{
    public partial class Agenda : Form
    {
        public String ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "informacion.json");
        public Agenda()
        {
            InitializeComponent();
            try
            {
                String json = File.ReadAllText(ruta);
                var registros = JsonConvert.DeserializeObject<BaseDatosJson>(json);
                Cargar(registros);
                Etiqueta.Text = "Fecha de guardado: " + registros.UltimaActualizacion.ToString() + "\n  Registros: " + registros.persona.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guardar(BaseDatosJson lista)
        {
            var Caracteristicas = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                NullValueHandling = NullValueHandling.Ignore,
            };
            String json = JsonConvert.SerializeObject(lista, Caracteristicas);
            File.WriteAllText(ruta, json);
        }

        private BaseDatosJson Abrir()
        {
            var registros = new BaseDatosJson();
            foreach (DataGridViewRow fila in dgvAgenda.Rows)
            {
                if (fila.IsNewRow) continue;
                var persona = new Persona();
                {
                    persona.nombre = fila.Cells[0].Value?.ToString() ?? "";
                    persona.apellido_pat = fila.Cells[1].Value?.ToString() ?? "";
                    persona.apellido_mat = fila.Cells[2].Value?.ToString() ?? "";
                    persona.direccion = fila.Cells[3].Value?.ToString() ?? "";
                    persona.telefono = fila.Cells[4].Value?.ToString() ?? "";
                    persona.correo = fila.Cells[5].Value?.ToString() ?? "";
                }
                registros.persona.Add(persona);
            }
            registros.totalRegistros = registros.persona.Count;
            return registros;
        }

        private void Cargar(BaseDatosJson registros)
        {
            dgvAgenda.Rows.Clear();
            foreach (var registro in registros.persona)
            {
                dgvAgenda.Rows.Add(new object[] { registro.nombre, registro.apellido_pat, registro.apellido_mat,
            registro.direccion, registro.telefono, registro.correo});
            }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void limpiarTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Seguro de Generar un archivo nuevo?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
                dgvAgenda.Rows.Clear();

            else
                return;
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            try
            {
                var BaseDatos = Abrir();
                guardar(BaseDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ssInfo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
