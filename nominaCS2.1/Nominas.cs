using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nominaCS2._1
{
    class Nominas
    {
        //LISTA
        static public List<String> myNomina = new List<string>();

        //VARIABLES
        static public double salarioD;
        static public int diasP;
        static public double pagohrsEx;
        static public int hrsEx;
        static public int diasV = 6;
        static public double salarioM;

        //VARIABLES ISR
        static public double difLI;
        static public double excedente;
        static public double equivalente;

        //PERCEPCIONES
        static public double salarioN;
        static public double septimoD;
        static public int vacaciones;
        static public double primaV;
        static public double primaVF;
        static public double bonoAs = 200;
        static public double bonoPT = 200;
        static public double totalPE;
        //DEDUCCIONES
        static public double isr;
        static public double riesgoTrabajo;
        static public double seguroEnf;
        static public double seguroVida;
        static public double seguroRetiro;
        static public double ims;
        static public double totalDE;

        static public double neto;


    }
}
