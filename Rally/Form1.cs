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
        private void btnAgregarComp_Click(object sender, EventArgs e)
        {
            FAgregar agregar = new FAgregar();


            if (agregar.ShowDialog() == DialogResult.OK)
            {
                carrera.AgregarCompetidor(agregar.tbAgregarC.Text);
                competidor++;
            }
        }

        private void btnCargarTiempos_Click(object sender, EventArgs e)
        {
            FCargaTiempos tiempos = new FCargaTiempos();
            
            
            if (tiempos.ShowDialog() == DialogResult.OK)
            {
                int horas = Convert.ToInt32(tiempos.tbHora.Text);
                int minutos = Convert.ToInt32(tiempos.tbMinutos.Text);
                carrera.CargarTiempo(competidor, horas, minutos);

            }
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            FListar lista = new FListar();
            carrera.OrdenListadoPorTiempo();
            
            for (int i = 0; i < competidor; i++)
            {
                string posicion = Convert.ToString(i + 1);

                lista.lbResultados.Items.Add(posicion + " - " + carrera.nombres[i] + " - " + carrera.minutos[i].ToString());    
            
            }
            lista.ShowDialog();
        }
    }
}
