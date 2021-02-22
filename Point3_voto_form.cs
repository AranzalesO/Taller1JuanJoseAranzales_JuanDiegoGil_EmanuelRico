using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop1JuanJoseAranzales_JuanDiegoGil_EmanuelRico
{
    public partial class Point3_voto_form : Form
    {
        // Encuesta departamental:
        // Definimos la encuesta

        private List<Cuestionario> encuesta = new List<Cuestionario>(); //Guardamos los departamentos en la encuesta
        private int value = 20;
        private int numeroVoto = 0;

        // Definimos las variables a utilizar en el resultado estadísitico final de las elecciones
        private int estadisticaAntioquia = 0;
        private int estadisticaAtlantico = 0;
        private int estadisticaCundinamarca = 0;
        private int estadisticaTolima = 0;
        private int estadisticaCauca = 0;

        // Cantidad total de votos
        private int totalVotosAntioquia = 0;
        private int totalVotosAtlantico = 0;
        private int totalVotosCundinamarca = 0;
        private int totalVotosTolima = 0;
        private int totalVotosCauca = 0;

        // Resultado por mensaje para el departamento ganador y el menor votado
        private int menorVotado = 0;
        private int departamentoGanador = 0;

        public Point3_voto_form()
        {
            // Inicialización del formulario de windows Forms y llamado de métodos y variables locales
            InitializeComponent();
            añadirRepresentante();
            numeroVoto = 0;
            estadisticaAntioquia = 0;
            estadisticaAtlantico = 0;
            estadisticaCundinamarca = 0;
            estadisticaTolima = 0;
            estadisticaCauca = 0;
            totalVotosAntioquia = 0;
            totalVotosAtlantico = 0;
            totalVotosCundinamarca = 0;
            totalVotosTolima = 0;
            totalVotosCauca = 0;
            menorVotado = 0;
            departamentoGanador = 0;
            lbl_resultado.Visible = false;
            progressBarAntioquia.Visible = false;
            progressBarAtlantico.Visible = false;
            progressBarCundinamarca.Visible = false;
            progressBarTolima.Visible = false;
            progressBarCauca.Visible = false;
            obtenerRepresentante(); // Pasamos de representante en representante para que vaya votando
        }

        private void btn_return_home_Click(object sender, EventArgs e)
        {
            this.Close();
            Point3_form homePoint3 = new Point3_form();
            homePoint3.Show();
        }

        // Escribimos lo que los representantes de los deptos pueden responder probablemente y sus valores
        private void añadirRepresentante()
        {
            // Añadimos a los representantes de cada departamento
            encuesta.Add(new Cuestionario
            {
                departamento = "Representante de Antioquia"
            });

            encuesta.Add(new Cuestionario
            {
                departamento = "Representante del Atlántico"
            });

            encuesta.Add(new Cuestionario
            {
                departamento = "Representante de Cundinamarca"
            });

            encuesta.Add(new Cuestionario
            {
                departamento = "Representante del Tolima"
            });

            encuesta.Add(new Cuestionario
            {
                departamento = "Representante del Valle del Cauca"
            });
        }

        private void obtenerRepresentante()
        {
            Cuestionario representante = new Cuestionario();
            representante = encuesta[numeroVoto];
            lbl_representante.Text = representante.departamento;
            radio_btn_antioquia.Checked = false;
            radio_btn_atlantico.Checked = false;
            radio_btn_cundinamarca.Checked = false;
            radio_btn_tolima.Checked = false;
            radio_btn_cauca.Checked = false;
            btn_next_question.Visible = true;
        }

        private void btn_next_question_Click(object sender, EventArgs e)
        {
            Cuestionario representante = new Cuestionario();
            representante = encuesta[numeroVoto];

            if (radio_btn_antioquia.Checked == true) 
            {
                estadisticaAntioquia += value;
                totalVotosAntioquia++;
            }

            if (radio_btn_atlantico.Checked == true) 
            {
                estadisticaAtlantico += value;
                totalVotosAtlantico+=1;
            }

            if (radio_btn_cundinamarca.Checked == true) 
            {
                estadisticaCundinamarca += value;
                totalVotosCundinamarca++;
            }

            if (radio_btn_tolima.Checked == true) 
            {
                estadisticaTolima += value;
                totalVotosTolima++;
            }

            if (radio_btn_cauca.Checked == true) 
            {
                estadisticaCauca += value;
                totalVotosCauca++;
            }

            // Involucro los votos de los representantes en un arreglo para determinar el ganador 
            // y el departamento con menos votos
            int[] votosDepartamentales = new int[5] { totalVotosAntioquia, totalVotosAtlantico, totalVotosCundinamarca, totalVotosTolima, totalVotosCauca };
            menorVotado = votosDepartamentales.Min();
            departamentoGanador = votosDepartamentales.Max();
            
            // Por si pide más votos:
            if (numeroVoto < encuesta.Count() - 1)
            {
                numeroVoto++;
                obtenerRepresentante();
            } else
            {
                presentarResultado();
            }

        }

        private void presentarResultado()
        {
            lbl_AntioquiaVoto.Text = totalVotosAntioquia.ToString();
            lbl_AntioquiaVoto.Visible = true;

            lbl_AtlanticoVoto.Text = totalVotosAtlantico.ToString();
            lbl_AtlanticoVoto.Visible = true;

            lbl_CundinamarcaVoto.Text = totalVotosCundinamarca.ToString();
            lbl_CundinamarcaVoto.Visible = true;

            lbl_TolimaVoto.Text = totalVotosTolima.ToString();
            lbl_TolimaVoto.Visible = true;

            lbl_CaucaVoto.Text = totalVotosCauca.ToString();
            lbl_CaucaVoto.Visible = true;

            // Determinamos a través de la cantidad de votos, el departamento ganador y el
            // departamento con menos votos 
            
            if (totalVotosAntioquia == departamentoGanador)
            {
                lbl_resultado.Text = "Felicitaciones Antioquia, eres el ganador!";
                departamentoGanador++;
            } else if(totalVotosAntioquia == menorVotado)
            {
                lbl_ResultadoPerdedor.Text = "El puntaje más bajo fue Antioquia";
            }

            if (totalVotosAtlantico == departamentoGanador)
            {
                lbl_resultado.Text = "Felicitaciones Cundinamarca, eres el ganador!";
                departamentoGanador++;
            }
            else if (totalVotosAtlantico == menorVotado)
            {
                lbl_ResultadoPerdedor.Text = "El puntaje más bajo fue Cundinamarca";
            }

            if (totalVotosCundinamarca == departamentoGanador)
            {
                lbl_resultado.Text = "Felicitaciones Cundinamarca, eres el ganador!";
                departamentoGanador++;
            }
            else if (totalVotosCundinamarca == menorVotado)
            {
                lbl_ResultadoPerdedor.Text = "El puntaje más bajo fue Cundinamarca";
            }

            if (totalVotosTolima == departamentoGanador)
            {
                lbl_resultado.Text = "Felicitaciones Tolima, eres el ganador!";
                departamentoGanador++;
            }
            else if (totalVotosTolima == menorVotado)
            {
                lbl_ResultadoPerdedor.Text = "El puntaje más bajo fue Tolima";
            }

            if (totalVotosCauca == departamentoGanador)
            {
                lbl_resultado.Text = "Felicitaciones Cauca, eres el ganador!";
                departamentoGanador++;
            }
            else if (totalVotosCauca == menorVotado)
            {
                lbl_ResultadoPerdedor.Text = "El puntaje más bajo fue Cauca.";

            }

            if (departamentoGanador >= 2)
            {
                lbl_resultado.Text = "¡Empate!";
            }

            // Llenamos las barras del Windows Forms, resultantes de las votaciones
            progressBarAntioquia.Value = estadisticaAntioquia;
            progressBarAntioquia.Visible = true;

            progressBarAtlantico.Value = estadisticaAtlantico;
            progressBarAtlantico.Visible = true;

            progressBarCundinamarca.Value = estadisticaCundinamarca;
            progressBarCundinamarca.Visible = true;

            progressBarTolima.Value = estadisticaTolima;
            progressBarTolima.Visible = true;

            progressBarCauca.Value = estadisticaCauca;
            progressBarCauca.Visible = true;

            btn_next_question.Visible = false;
        }
    }
}
