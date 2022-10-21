using System.Globalization;

namespace Tanda2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_EjecutarOnClick(object sender, EventArgs e)
        {
      
            textBox1.Text = DateTime.Now.ToString();
            textBox2.Text = DateTime.Now.Day.ToString()+ "/" + DateTime.Now.Month.ToString()+"/"+DateTime.Now.Year.ToString();
            textBox3.Text = DateTime.Now.Hour.ToString()+":"+ DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            
            try
            {
                string FehcaEntrada = Microsoft.VisualBasic.Interaction.InputBox(
                     "Ingrese una fecha con el siguiente formato dd/mm/aaaa",
                     "Función sumar fechas",
                     "");
                
                DateTime date1 = DateTime.ParseExact(FehcaEntrada, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                string meses = Microsoft.VisualBasic.Interaction.InputBox(
                         "Ingrese el número de meses que se agregan a la fecha",
                         "Meses",
                         "");

                textBox4.Text = "Fecha Inicio: " + FehcaEntrada + ", Meses a sumar: " + meses + ",Nueva Fecha: " + date1.AddMonths(Int32.Parse(meses)).ToString();

            }
            catch (Exception)
            {
                Microsoft.VisualBasic.Interaction.MsgBox(
                    "Introduzca los datos correctamente o pulse salir");
            }
            try
            {
                string textoFechaInicioDiff = Microsoft.VisualBasic.Interaction.InputBox(
                                "Ingrese la fecha inicial de la forma dd/mm/aaaa",
                                "Funcion DiferenciaFechas",
                                "");
                DateTime fechaInDiff = DateTime.ParseExact(textoFechaInicioDiff, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                string textoFechaFinDiff = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingrese la fecha final de la forma dd/mm/aaaa",
                    "Funcion DiferenciaFechas",
                    "");
                DateTime fechaFinDiff = DateTime.ParseExact(textoFechaFinDiff, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                TimeSpan ts = fechaFinDiff - fechaInDiff;


                textBox5.Text = "Desde " + textoFechaInicioDiff + " hasta " + textoFechaFinDiff + " hay " + ts.Days + " dias";

            }
            catch (Exception)
            {
                Microsoft.VisualBasic.Interaction.MsgBox(
                    "Introduzca los datos correctamente o pulse salir");
            }
        }

        private void btn_Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Limpiar(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}