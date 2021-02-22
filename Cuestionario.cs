using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop1JuanJoseAranzales_JuanDiegoGil_EmanuelRico
{
    // Definimos la estructura de la encuesta por concepto de Depto, respuestai, valori,
    // de acuerdo a como vayan votanto los representantes de los departamentos
    class Cuestionario
    {
        public string departamento { get; set; }
        public string respuesta1 { get; set; }
        public string valor1 { get; set; }

        public string respuesta2 { get; set; }
        public string valor2 { get; set; }

        public string respuesta3 { get; set; }
        public string valor3 { get; set; }

        public string respuesta4 { get; set; }
        public string valor4 { get; set; }

        public string respuesta5 { get; set; }
        public string valor5 { get; set; }
    }
}
