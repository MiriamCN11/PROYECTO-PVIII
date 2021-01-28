using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nominaCS2._1
{
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
            btnRecibo.Enabled = false;
        }

        private void btnMENU_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar la ventana 
            Menu menuInicial = new Menu();
            //mandarla a llamar y que se muestre
            menuInicial.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar la ventana 
            Buscar b = new Buscar();
            //mandarla a llamar y que se muestre
            b.Show();
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            this.Hide();//ocultar la ventana 
            ReciboPago recibo = new ReciboPago();
            //mandarla a llamar y que se muestre
            recibo.Show();
        }

        private void Nomina_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarN_Click(object sender, EventArgs e)
        {
            nominaE();
        }

        private void nominaE()
        {
            Nominas.diasP = Convert.ToInt32(txtDiasT.Text);
            Nominas.hrsEx = Convert.ToInt32(txtHrsE.Text);

            if (string.IsNullOrEmpty(txtDiasT.Text))
            {
                MessageBox.Show("Favor de llenar el espacio...");
            }
            else if (string.IsNullOrEmpty(txtHrsE.Text))
            {
                MessageBox.Show("Favor de llenar el espacio...");
            }
            else
            {
                if(Empleados.tPago == "Semanal")
                {
                    //PERCEPCIONES
                    Nominas.salarioD = (Empleados.sueldoB / 7);
                    Nominas.salarioN = (Nominas.salarioD * Nominas.diasP);
                    Nominas.septimoD = Nominas.salarioD;
                    Nominas.pagohrsEx = (Nominas.salarioD / Empleados.hrsT) * Nominas.hrsEx;
                    Nominas.primaV = (Nominas.salarioD * Nominas.diasV);
                    Nominas.primaVF = (Nominas.primaV * .25);
                    Nominas.totalPE = (Nominas.salarioN + Nominas.septimoD + Nominas.pagohrsEx + Nominas.bonoAs + Nominas.bonoPT);

                    //DEDUCCIONES
                                //IMSS
                    Nominas.riesgoTrabajo = (Nominas.totalPE / 100 * 0.54355);
                    Nominas.seguroEnf = (Nominas.totalPE / 100 * 0.250);
                    Nominas.seguroVida = (Nominas.totalPE / 100 * 0.625);
                    Nominas.seguroRetiro = (Nominas.totalPE / 100 * 6.150);
                    Nominas.ims = (Nominas.riesgoTrabajo + Nominas.seguroEnf + Nominas.seguroVida + Nominas.seguroRetiro);
                                //ISR
                    Nominas.salarioM = Nominas.salarioD * 30;

                    if (Nominas.salarioM>0.01 && Nominas.salarioM<578.52)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 0.01;
                        //Por cierto sobr eel excedente del limite inferior 1.92%
                        Nominas.excedente = (Nominas.difLI / 100) * 1.92;
                        //CUOTA FIJA: 0.00
                        Nominas.equivalente = ((Nominas.excedente + 0.00) / 30) * 7;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 578.53 && Nominas.salarioM < 4910.18)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 578.53;
                        //Por cierto sobr eel excedente del limite inferior 6.40%
                        Nominas.excedente = (Nominas.difLI / 100) * 6.40;
                        //CUOTA FIJA: 11.11
                        Nominas.equivalente = ((Nominas.excedente + 11.11) / 30) * 7;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 4910.19 && Nominas.salarioM < 8629.20)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 4910.19;
                        //Por cierto sobr eel excedente del limite inferior 10.88%
                        Nominas.excedente = (Nominas.difLI / 100) * 10.88;
                        //CUOTA FIJA: 288.33
                        Nominas.equivalente = ((Nominas.excedente + 288.33)/30)*7;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 8629.21 && Nominas.salarioM < 10031.07)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 8629.21;
                        //Por cierto sobr eel excedente del limite inferior 16.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 16.00;
                        //CUOTA FIJA: 692.96
                        Nominas.equivalente = ((Nominas.excedente + 692.96) / 30) * 7;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 10031.08 && Nominas.salarioM < 12009.94)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 10031.08;
                        //Por cierto sobr eel excedente del limite inferior 17.92%
                        Nominas.excedente = (Nominas.difLI / 100) * 17.92;
                        //CUOTA FIJA: 917.26
                        Nominas.equivalente = ((Nominas.excedente + 917.26) / 30) * 7;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 12009.95 && Nominas.salarioM < 24222.31)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 12009.95;
                        //Por cierto sobr eel excedente del limite inferior 21.36%
                        Nominas.excedente = (Nominas.difLI / 100) * 21.36;
                        //CUOTA FIJA: 1271.87
                        Nominas.equivalente = ((Nominas.excedente + 1271.87) / 30) * 7;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 24222.32 && Nominas.salarioM < 38177.69)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 24222.32;
                        //Por cierto sobr eel excedente del limite inferior 23.52%
                        Nominas.excedente = (Nominas.difLI / 100) * 23.52;
                        //CUOTA FIJA: 3880.44
                        Nominas.equivalente = ((Nominas.excedente + 3880.44) / 30) * 7;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 38177.70 && Nominas.salarioM < 72887.50)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 38177.70;
                        //Por cierto sobr eel excedente del limite inferior 30.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 30.00;
                        //CUOTA FIJA: 7162.74
                        Nominas.equivalente = ((Nominas.excedente + 7162.74) / 30) * 7;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 72887.51 && Nominas.salarioM < 97183.33)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 72887.51;
                        //Por cierto sobr eel excedente del limite inferior 32.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 32.00;
                        //CUOTA FIJA: 17575.69
                        Nominas.equivalente = ((Nominas.excedente + 17575.69) / 30) * 7;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 97183.34 && Nominas.salarioM < 291550.00)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 97183.34;
                        //Por cierto sobr eel excedente del limite inferior 34.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 34.00;
                        //CUOTA FIJA: 25350.35
                        Nominas.equivalente = ((Nominas.excedente + 25350.35) / 30) * 7;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 291550.01)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 291550.01;
                        //Por cierto sobr eel excedente del limite inferior 35.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 35.00;
                        //CUOTA FIJA: 91435.02
                        Nominas.equivalente = ((Nominas.excedente + 91435.02) / 30) * 7;
                        Nominas.isr = Nominas.equivalente;
                    }
                    Nominas.totalDE = Nominas.ims + Nominas.isr;

                    //TOTAL NETO A PAGAR
                    Nominas.neto = Nominas.totalPE - Nominas.totalDE;

                    lstNomina.Items.Add("*****************************************");
                    lstNomina.Items.Add("PERCEPCIONES");
                    lstNomina.Items.Add("Salario diario: $" + Nominas.salarioD);
                    lstNomina.Items.Add("Dias pagados: " + Nominas.diasP);
                    lstNomina.Items.Add("Horas extra: " + Nominas.hrsEx);
                    lstNomina.Items.Add("Salario normal: $" + Nominas.salarioN);
                    lstNomina.Items.Add("Séptimo dia: $" + Nominas.salarioD);
                    lstNomina.Items.Add("Pago por Horas extra: $" + Nominas.pagohrsEx);
                    lstNomina.Items.Add("Bono de puntualidad: $" + Nominas.bonoPT);
                    lstNomina.Items.Add("Salario de asistencia: $" + Nominas.bonoAs);
                    lstNomina.Items.Add("Total Percepciones: $" + Nominas.totalPE);
                    lstNomina.Items.Add("*****************************************");
                    lstNomina.Items.Add("DEDUCCIONES");
                    lstNomina.Items.Add("IMSS $" + Nominas.ims);
                    lstNomina.Items.Add("ISR $" + Nominas.isr);
                    lstNomina.Items.Add("Total Deducciones: $" + Nominas.totalDE);
                    lstNomina.Items.Add("*****************************************");
                    lstNomina.Items.Add("Total NETO: $" + Nominas.neto);

                    btnGenerarN.Enabled = false;
                    btnRecibo.Enabled = true;
                }
                else if(Empleados.tPago == "Catorcenal")
                {
                    //PERCEPCIONES
                    Nominas.salarioD = (Empleados.sueldoB / 14);
                    Nominas.salarioN = (Nominas.salarioD * Nominas.diasP);
                    Nominas.septimoD = Nominas.salarioD;
                    Nominas.pagohrsEx = (Nominas.salarioD / Empleados.hrsT) * Nominas.hrsEx;
                    Nominas.primaV = (Nominas.salarioD * Nominas.diasV);
                    Nominas.primaVF = (Nominas.primaV * .25);
                    Nominas.totalPE = (Nominas.salarioN + Nominas.septimoD + Nominas.pagohrsEx + Nominas.bonoAs + Nominas.bonoPT);

                    //DEDUCCIONES
                                //IMSS
                    Nominas.riesgoTrabajo = (Nominas.totalPE / 100 * 0.54355);
                    Nominas.seguroEnf = (Nominas.totalPE / 100 * 0.250);
                    Nominas.seguroVida = (Nominas.totalPE / 100 * 0.625);
                    Nominas.seguroRetiro = (Nominas.totalPE / 100 * 6.150);
                    Nominas.ims = (Nominas.riesgoTrabajo + Nominas.seguroEnf + Nominas.seguroVida + Nominas.seguroRetiro);
                                //ISR
                    Nominas.salarioM = Nominas.salarioD * 30;

                    if (Nominas.salarioM > 0.01 && Nominas.salarioM < 578.52)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 0.01;
                        //Por cierto sobr eel excedente del limite inferior 1.92%
                        Nominas.excedente = (Nominas.difLI / 100) * 1.92;
                        //CUOTA FIJA: 0.00
                        Nominas.equivalente = ((Nominas.excedente + 0.00) / 30) * 14;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 578.53 && Nominas.salarioM < 4910.18)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 578.53;
                        //Por cierto sobr eel excedente del limite inferior 6.40%
                        Nominas.excedente = (Nominas.difLI / 100) * 6.40;
                        //CUOTA FIJA: 11.11
                        Nominas.equivalente = ((Nominas.excedente + 11.11) / 30) * 14;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 4910.19 && Nominas.salarioM < 8629.20)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 4910.19;
                        //Por cierto sobr eel excedente del limite inferior 10.88%
                        Nominas.excedente = (Nominas.difLI / 100) * 10.88;
                        //CUOTA FIJA: 288.33
                        Nominas.equivalente = ((Nominas.excedente + 288.33) / 30) * 14;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 8629.21 && Nominas.salarioM < 10031.07)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 8629.21;
                        //Por cierto sobr eel excedente del limite inferior 16.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 16.00;
                        //CUOTA FIJA: 692.96
                        Nominas.equivalente = ((Nominas.excedente + 692.96) / 30) * 14;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 10031.08 && Nominas.salarioM < 12009.94)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 10031.08;
                        //Por cierto sobr eel excedente del limite inferior 17.92%
                        Nominas.excedente = (Nominas.difLI / 100) * 17.92;
                        //CUOTA FIJA: 917.26
                        Nominas.equivalente = ((Nominas.excedente + 917.26) / 30) * 14;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 12009.95 && Nominas.salarioM < 24222.31)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 12009.95;
                        //Por cierto sobr eel excedente del limite inferior 21.36%
                        Nominas.excedente = (Nominas.difLI / 100) * 21.36;
                        //CUOTA FIJA: 1271.87
                        Nominas.equivalente = ((Nominas.excedente + 1271.87) / 30) * 14;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 24222.32 && Nominas.salarioM < 38177.69)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 24222.32;
                        //Por cierto sobr eel excedente del limite inferior 23.52%
                        Nominas.excedente = (Nominas.difLI / 100) * 23.52;
                        //CUOTA FIJA: 3880.44
                        Nominas.equivalente = ((Nominas.excedente + 3880.44) / 30) * 14;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 38177.70 && Nominas.salarioM < 72887.50)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 38177.70;
                        //Por cierto sobr eel excedente del limite inferior 30.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 30.00;
                        //CUOTA FIJA: 7162.74
                        Nominas.equivalente = ((Nominas.excedente + 7162.74) / 30) * 14;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 72887.51 && Nominas.salarioM < 97183.33)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 72887.51;
                        //Por cierto sobr eel excedente del limite inferior 32.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 32.00;
                        //CUOTA FIJA: 17575.69
                        Nominas.equivalente = ((Nominas.excedente + 17575.69) / 30) * 14;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 97183.34 && Nominas.salarioM < 291550.00)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 97183.34;
                        //Por cierto sobr eel excedente del limite inferior 34.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 34.00;
                        //CUOTA FIJA: 25350.35
                        Nominas.equivalente = ((Nominas.excedente + 25350.35) / 30) * 14;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 291550.01)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 291550.01;
                        //Por cierto sobr eel excedente del limite inferior 35.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 35.00;
                        //CUOTA FIJA: 91435.02
                        Nominas.equivalente = ((Nominas.excedente + 91435.02) / 30) * 14;
                        Nominas.isr = Nominas.equivalente;
                    }
                    Nominas.totalDE = Nominas.ims + Nominas.isr;

                    //TOTAL NETO A PAGAR
                    Nominas.neto = Nominas.totalPE - Nominas.totalDE;

                    lstNomina.Items.Add("*****************************************");
                    lstNomina.Items.Add("PERCEPCIONES");
                    lstNomina.Items.Add("Salario diario: $" + Nominas.salarioD);
                    lstNomina.Items.Add("Dias pagados: " + Nominas.diasP);
                    lstNomina.Items.Add("Horas extra: " + Nominas.hrsEx);
                    lstNomina.Items.Add("Salario normal: $" + Nominas.salarioN);
                    lstNomina.Items.Add("Séptimo dia: $" + Nominas.salarioD);
                    lstNomina.Items.Add("Pago por Horas extra: $" + Nominas.pagohrsEx);
                    lstNomina.Items.Add("Bono de puntualidad: $" + Nominas.bonoPT);
                    lstNomina.Items.Add("Salario de asistencia: $" + Nominas.bonoAs);
                    lstNomina.Items.Add("Total Percepciones: $" + Nominas.totalPE);
                    lstNomina.Items.Add("*****************************************");
                    lstNomina.Items.Add("DEDUCCIONES");
                    lstNomina.Items.Add("IMSS $" + Nominas.ims);
                    lstNomina.Items.Add("ISR $" + Nominas.isr);
                    lstNomina.Items.Add("Total Deducciones: $" + Nominas.totalDE);
                    lstNomina.Items.Add("*****************************************");
                    lstNomina.Items.Add("Total NETO: $" + Nominas.neto);

                    btnGenerarN.Enabled = false;
                    btnRecibo.Enabled = true;
                }
                else if (Empleados.tPago == "Quincenal")
                {
                    //PERCEPCIONES
                    Nominas.salarioD = (Empleados.sueldoB / 15);
                    Nominas.salarioN = (Nominas.salarioD * Nominas.diasP);
                    Nominas.septimoD = Nominas.salarioD;
                    Nominas.pagohrsEx = (Nominas.salarioD / Empleados.hrsT) * Nominas.hrsEx;
                    Nominas.primaV = (Nominas.salarioD * Nominas.diasV);
                    Nominas.primaVF = (Nominas.primaV * .25);
                    Nominas.totalPE = (Nominas.salarioN + Nominas.septimoD + Nominas.pagohrsEx + Nominas.bonoAs + Nominas.bonoPT);

                    //DEDUCCIONES
                                //IMSS
                    Nominas.riesgoTrabajo = (Nominas.totalPE / 100 * 0.54355);
                    Nominas.seguroEnf = (Nominas.totalPE / 100 * 0.250);
                    Nominas.seguroVida = (Nominas.totalPE / 100 * 0.625);
                    Nominas.seguroRetiro = (Nominas.totalPE / 100 * 6.150);
                    Nominas.ims = (Nominas.riesgoTrabajo + Nominas.seguroEnf + Nominas.seguroVida + Nominas.seguroRetiro);
                                //ISR
                    Nominas.salarioM = Nominas.salarioD * 30;

                    if (Nominas.salarioM > 0.01 && Nominas.salarioM < 578.52)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 0.01;
                        //Por cierto sobr eel excedente del limite inferior 1.92%
                        Nominas.excedente = (Nominas.difLI / 100) * 1.92;
                        //CUOTA FIJA: 0.00
                        Nominas.equivalente = ((Nominas.excedente + 0.00) / 30) * 15;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 578.53 && Nominas.salarioM < 4910.18)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 578.53;
                        //Por cierto sobr eel excedente del limite inferior 6.40%
                        Nominas.excedente = (Nominas.difLI / 100) * 6.40;
                        //CUOTA FIJA: 11.11
                        Nominas.equivalente = ((Nominas.excedente + 11.11) / 30) * 15;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 4910.19 && Nominas.salarioM < 8629.20)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 4910.19;
                        //Por cierto sobr eel excedente del limite inferior 10.88%
                        Nominas.excedente = (Nominas.difLI / 100) * 10.88;
                        //CUOTA FIJA: 288.33
                        Nominas.equivalente = ((Nominas.excedente + 288.33) / 30) * 15;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 8629.21 && Nominas.salarioM < 10031.07)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 8629.21;
                        //Por cierto sobr eel excedente del limite inferior 16.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 16.00;
                        //CUOTA FIJA: 692.96
                        Nominas.equivalente = ((Nominas.excedente + 692.96) / 30) * 15;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 10031.08 && Nominas.salarioM < 12009.94)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 10031.08;
                        //Por cierto sobr eel excedente del limite inferior 17.92%
                        Nominas.excedente = (Nominas.difLI / 100) * 17.92;
                        //CUOTA FIJA: 917.26
                        Nominas.equivalente = ((Nominas.excedente + 917.26) / 30) * 15;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 12009.95 && Nominas.salarioM < 24222.31)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 12009.95;
                        //Por cierto sobr eel excedente del limite inferior 21.36%
                        Nominas.excedente = (Nominas.difLI / 100) * 21.36;
                        //CUOTA FIJA: 1271.87
                        Nominas.equivalente = ((Nominas.excedente + 1271.87) / 30) * 15;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 24222.32 && Nominas.salarioM < 38177.69)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 24222.32;
                        //Por cierto sobr eel excedente del limite inferior 23.52%
                        Nominas.excedente = (Nominas.difLI / 100) * 23.52;
                        //CUOTA FIJA: 3880.44
                        Nominas.equivalente = ((Nominas.excedente + 3880.44) / 30) * 15;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 38177.70 && Nominas.salarioM < 72887.50)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 38177.70;
                        //Por cierto sobr eel excedente del limite inferior 30.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 30.00;
                        //CUOTA FIJA: 7162.74
                        Nominas.equivalente = ((Nominas.excedente + 7162.74) / 30) * 15;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 72887.51 && Nominas.salarioM < 97183.33)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 72887.51;
                        //Por cierto sobr eel excedente del limite inferior 32.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 32.00;
                        //CUOTA FIJA: 17575.69
                        Nominas.equivalente = ((Nominas.excedente + 17575.69) / 30) * 15;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 97183.34 && Nominas.salarioM < 291550.00)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 97183.34;
                        //Por cierto sobr eel excedente del limite inferior 34.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 34.00;
                        //CUOTA FIJA: 25350.35
                        Nominas.equivalente = ((Nominas.excedente + 25350.35) / 30) * 15;
                        Nominas.isr = Nominas.equivalente;
                    }
                    else if (Nominas.salarioM > 291550.01)
                    {
                        //DIFERENCIA ENTRE EL SALARIO MENSUAL Y EL LIMITE INFERIOR
                        Nominas.difLI = Nominas.salarioM - 291550.01;
                        //Por cierto sobr eel excedente del limite inferior 35.00%
                        Nominas.excedente = (Nominas.difLI / 100) * 35.00;
                        //CUOTA FIJA: 91435.02
                        Nominas.equivalente = ((Nominas.excedente + 91435.02) / 30) * 15;
                        Nominas.isr = Nominas.equivalente;
                    }
                    Nominas.totalDE = Nominas.ims + Nominas.isr;

                    //TOTAL NETO A PAGAR
                    Nominas.neto = Nominas.totalPE - Nominas.totalDE;

                    lstNomina.Items.Add("*****************************************");
                    lstNomina.Items.Add("PERCEPCIONES");
                    lstNomina.Items.Add("Salario diario: $" + Nominas.salarioD);
                    lstNomina.Items.Add("Dias pagados: " + Nominas.diasP);
                    lstNomina.Items.Add("Horas extra: " + Nominas.hrsEx);
                    lstNomina.Items.Add("Salario normal: $" + Nominas.salarioN);
                    lstNomina.Items.Add("Séptimo dia: $" + Nominas.salarioD);
                    lstNomina.Items.Add("Pago por Horas extra: $" + Nominas.pagohrsEx);
                    lstNomina.Items.Add("Bono de puntualidad: $" + Nominas.bonoPT);
                    lstNomina.Items.Add("Salario de asistencia: $" + Nominas.bonoAs);
                    lstNomina.Items.Add("Total Percepciones: $" + Nominas.totalPE);
                    lstNomina.Items.Add("*****************************************");
                    lstNomina.Items.Add("DEDUCCIONES");
                    lstNomina.Items.Add("IMSS $" + Nominas.ims);
                    lstNomina.Items.Add("ISR $" + Nominas.isr);
                    lstNomina.Items.Add("Total Deducciones: $" + Nominas.totalDE);
                    lstNomina.Items.Add("*****************************************");
                    lstNomina.Items.Add("Total NETO: $" + Nominas.neto);

                    btnGenerarN.Enabled = false;
                    btnRecibo.Enabled = true;
                }
            }
        }

    }
}
