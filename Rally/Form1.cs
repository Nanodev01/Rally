using System.ComponentModel;

namespace Rally
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Competencia carrera = new Competencia();
        int competidor = 0;
        int contTiempo = 0;
        private void btnAgregarComp_Click(object sender, EventArgs e)
        {
            FAgregar agregar = new FAgregar();

            if (competidor == 0)
            { 
                btnCargarTiempos.Enabled = true;
            
            }
            if (agregar.ShowDialog() == DialogResult.OK)
            {
                carrera.AgregarCompetidor(agregar.tbAgregarC.Text);
                competidor++;
                
            }
        }

        private void btnCargarTiempos_Click(object sender, EventArgs e)
        {
            FCargaTiempos tiempos = new FCargaTiempos();
            
            string nombre = carrera.Minutos[contTiempo].ToString();
            tiempos.lbNombreC.Text = nombre;
            

            if (tiempos.ShowDialog() == DialogResult.OK)
            { 
                int horas = Convert.ToInt32(tiempos.tbHora.Text);
                int minutos = Convert.ToInt32(tiempos.tbMinutos.Text);
                carrera.CargarTiempo(contTiempo, horas, minutos);
                contTiempo++;

            }
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            FListar lista = new FListar();
            carrera.OrdenListadoPorTiempo();
            string hora, minuto;       
            for (int i = 0; i < competidor; i++)
            {
                int min = carrera.Minutos[i];
                string posicion = Convert.ToString(i + 1);
                hora = Convert.ToString(min / 60);
                minuto = Convert.ToString(min % 60);
                string tiempo = hora + ":" + minuto;
                lista.lbResultados.Items.Add(posicion + " - " + carrera.Nombres[i] + " - " + tiempo);

            }
             if(lista.ShowDialog() == DialogResult.OK) lista.Close();
 
        }
    }
}
