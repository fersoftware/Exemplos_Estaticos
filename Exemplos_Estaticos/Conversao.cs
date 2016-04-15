using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Estaticos
{
    static class Conversao
    {
        public static string ConverteMoeda(float dinheiro)
        {
            return "R$ " + dinheiro;
        }

        public static string DiaDaSemana(DateTime d)
        {
            //return d.DayOfWeek.ToString();

            string diadasemana = "";
            /*
            diadasemana = d.DayOfWeek.ToString() == "Sunday"    ? "Domingo" : "";
            diadasemana = d.DayOfWeek.ToString() == "Monday"    ? "Segunda" : "";
            diadasemana = d.DayOfWeek.ToString() == "Tuesday"   ? "Terça"   : "";
            diadasemana = d.DayOfWeek.ToString() == "Wednesday" ? "Quarta"  : "";
            diadasemana = d.DayOfWeek.ToString() == "Thursday"  ? "Quinta"  : "";
            diadasemana = d.DayOfWeek.ToString() == "Friday"    ?  "Sexta"  : "";
            diadasemana = d.DayOfWeek.ToString() == "Saturday"  ? "Sábado"  : "";*/

            return diadasemana;

            switch (d.DayOfWeek.ToString())
            {
                case "Sunday":
                    diadasemana = "Domingo";
                    break;
                case "Monday":
                    diadasemana = "Segunda";
                    break;
                case "Tuesday":
                    diadasemana = "Terça";
                    break;
                case "Wednesday":
                    diadasemana = "Quarta";
                    break;
                case "Thursday":
                    diadasemana = "Quinta";
                    break;
                case "Friday":
                    diadasemana = "Sexta";
                    break;
                case "Saturday":
                    diadasemana = "Sábado";
                    break;                
            }
            return diadasemana;
        }
    }
}
