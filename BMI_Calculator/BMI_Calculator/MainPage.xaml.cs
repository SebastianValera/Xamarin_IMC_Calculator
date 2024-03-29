﻿using Xamarin.Forms;

namespace BMI_Calculator
{
    /// <summary>
    /// Creado por Humberto Sebastian Valera Castro el 17.10.19
    /// </summary>
    public partial class MainPage : ContentPage
    {
        string[] arrSexo = new string[2] {"Hombre","Mujer"};
        string[] arrEdad = new string[41] {"Al nacer", "1 mes", "2 meses", "3 meses", "4 meses",
            "5 meses", "6 meses", "7 meses", "8 meses", "9 meses",
            "10 meses", "11 meses", "1 año", "1 año 6 meses",
            "2 años", "2 años 6 meses", "3 años", "3 años 6 meses",
            "4 años", "4 años 6 meses", "5 años", "5 años 6 meses",
            "6 años", "6 años 6 meses", "7 años", "7 años 6 meses",
            "8 años", "8 años 6 meses", "9 años", "9 años 6 meses",
            "10 años", "11 años", "12 años", "13 años", "14 años",
            "15 años", "16 años", "17 años", "18 años", "19 años",
            "20 años o mas"};
        double peso;
        double altura;
        double imc = 0.0;

        public MainPage()
        {
            InitializeComponent();
            foreach (var item in arrSexo)
            {
                comboSexo.Items.Add(item);
            }
            foreach (var item in arrEdad)
            {
                comboEdad.Items.Add(item);
            }
        }

        /// <summary>
        /// Metodo dedicado a hacer instancia al boton dedicado a calcular la masa corporal
        /// y se relaciona con el metodo que detecta "clic" al picarle al boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIMC_Clicked(object sender, System.EventArgs e)
        {
            peso = double.Parse(edtPeso.Text);
            altura = double.Parse(edtAltura.Text);
            if (comboEdad.SelectedIndex >= 0 && comboEdad.SelectedIndex <= 20)
            {
                imc = peso;
            }
            else {
                imc = calcularIMC(peso,altura);
            }
            stcIMC.Text = imc.ToString();
            stcCategoria.Text = obtenerCategoria(imc, comboSexo.SelectedIndex, comboEdad.SelectedIndex);
        }

        /// <summary>
        /// Metodo que calcula el Indice de Masa Corporal
        /// </summary>
        /// <param name="peso">Peso de la persona</param>
        /// <param name="altura">Estatura de la persona</param>
        /// <returns>Indice de masa corporal en formato double</returns>
        public double calcularIMC(double peso,double altura)
        {
            double imc = peso / (altura * altura);
            return imc;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="imc"> Indice de Masa Corporal en formato Double</param>
        /// <param name="sexo">Indice de registro seleccionado en el combo sexo</param>
        /// <param name="edad">Indice de registro seleccionado en el combo edad</param>
        /// <returns>categoria calculada en formato de cadena de Texto (string)</returns>
        public string obtenerCategoria(double imc, int sexo, int edad)
        {
            IMCListado categoria = IMCListado.NINGUNO;
            switch (sexo)
            {
                case 0: //Hombre
                    switch (edad)
                    {
                        case 0: //Al nacer
                            if (imc < 2.9)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 2.9 && imc <= 3.9)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 3.9 && imc <= 4.4)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 4.4)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 1: //1 mes
                            if (imc < 3.9)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 3.9 && imc <= 5.1)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 5.1 && imc <= 5.8)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                                //OBESIDAD
                            }
                            else if (imc > 5.8)
                            {
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 2: //2 meses
                            if (imc < 4.9)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 4.9 && imc <= 6.3)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 6.3 && imc <= 7.1)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 7.1)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 3: //3 meses
                            if (imc < 5.7)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 5.7 && imc <= 7.2)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 7.2 && imc <= 8.0)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 8.0)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 4: //4 meses
                            if (imc < 6.2)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 6.2 && imc <= 7.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 7.8 && imc <= 8.7)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 8.7)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 5: //5 meses
                            if (imc < 6.7)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 6.7 && imc <= 8.4)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 8.4 && imc <= 9.3)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 9.3)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 6: // 6 meses
                            if (imc < 7.1)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 7.1 && imc <= 8.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 8.8 && imc <= 9.8)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 9.8)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 7: //7 meses
                            if (imc < 7.4)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 7.4 && imc <= 9.2)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 9.2 && imc <= 10.3)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 10.3)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 8: //8 meses
                            if (imc < 7.7)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 7.7 && imc <= 9.6)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 9.6 && imc <= 10.7)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 10.7)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 9: //9 meses
                            if (imc < 8.0)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 8.0 && imc <= 9.9)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 9.9 && imc <= 11.0)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 11.0)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 10: //10 meses
                            if (imc < 8.2)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 8.2 && imc <= 10.2)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 10.2 && imc <= 11.4)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 11.4)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 11: //11 meses
                            if (imc < 8.4)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 8.4 && imc <= 10.5)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 10.5 && imc <= 11.7)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 11.7)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 12: //1 año
                            if (imc < 8.6)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 8.6 && imc <= 10.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 10.8 && imc <= 12.0)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 12.0)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 13: //1 año 6 meses
                            if (imc < 9.8)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 9.8 && imc <= 12.2)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 12.2 && imc <= 13.7)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 13.7)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 14: //2 años
                            if (imc < 10.8)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 10.8 && imc <= 13.6)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 13.6 && imc <= 15.3)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 15.3)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 15: //2 años y 6 meses
                            if (imc < 11.8)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 11.8 && imc <= 15.0)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 15.0 && imc <= 16.9)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 16.9)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 16: //3 años
                            if (imc < 12.7)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 12.7 && imc <= 16.2)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 16.2 && imc <= 18.3)
                            {
                                //SOPREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 18.3)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 17: //3 años 6 meses
                            if (imc < 13.6)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 13.6 && imc <= 17.4)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 17.4 && imc <= 19.7)
                            {
                                //SOPREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 19.7)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 18: //4 años
                            if (imc < 14.4)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 14.4 && imc <= 18.6)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 18.6 && imc <= 21.2)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 21.2)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 19: //4 años y 6 meses
                            if (imc < 15.2)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 15.2 && imc <= 19.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 19.8 && imc <= 22.7)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 22.7)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 20: //5 años
                            if (imc < 16.0)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 16.0 && imc <= 21.0)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 21.0 && imc <= 24.2)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 24.2)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 21: //5 años 6 meses
                            if (imc <= 13.0)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.0 && imc < 16.7)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 16.7 && imc < 18.4)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 18.4)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 22: //6 años
                            if (imc <= 13.0)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.0 && imc < 16.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 16.8 && imc < 18.5)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 18.5)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 23: //6 años 6 meses
                            if (imc <= 13.1)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.1 && imc < 16.9)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 16.9 && imc < 18.7)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 18.7)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 24: //7 años
                            if (imc <= 13.1)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.1 && imc < 17.0)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 17.0 && imc < 19.0)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 19.0)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 25: //7 años 6 meses
                            if (imc <= 13.2)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.2 && imc < 17.2)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 17.2 && imc < 19.3)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 19.3)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 26: //8 años
                            if (imc <= 13.3)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.3 && imc < 17.4)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 17.4 && imc < 19.7)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 19.7)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 27: //8 años 6 meses
                            if (imc <= 13.4)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.4 && imc < 17.7)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 17.7 && imc < 20.1)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 20.1)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 28: //9 años
                            if (imc <= 13.5)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.5 && imc < 17.9)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 17.9 && imc < 20.5)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 20.5)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 29: //9 años 6 meses
                            if (imc <= 13.6)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.6 && imc < 18.2)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 18.2 && imc < 20.9)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 20.9)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 30: //10 años
                            if (imc <= 13.7)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.7 && imc < 18.5)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 18.5 && imc < 21.4)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 21.4)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 31: //11 años
                            if (imc <= 14.1)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 14.1 && imc < 19.2)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 19.2 && imc < 22.5)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 22.5)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 32: //12 años
                            if (imc <= 14.5)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 14.5 && imc < 19.9)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 19.9 && imc < 23.6)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 23.6)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 33: //13 años
                            if (imc <= 14.9)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 14.9 && imc < 20.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 20.8 && imc < 24.8)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 24.8)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 34: //14 años
                            if (imc <= 15.5)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 15.5 && imc < 21.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 21.8 && imc < 25.9)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 25.9)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 35: //15 años
                            if (imc <= 16.0)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 16.0 && imc < 22.7)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 22.7 && imc < 27.0)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 27.0)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 36: //16 años
                            if (imc <= 16.5)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 16.5 && imc < 23.5)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 23.5 && imc < 27.9)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 27.9)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 37: //17 años
                            if (imc <= 16.9)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 16.9 && imc < 24.3)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 24.3 && imc < 28.6)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 28.6)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 38: //18 años
                            if (imc <= 17.3)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 17.3 && imc < 24.9)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 24.9 && imc < 29.2)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 29.2)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 39: //19 años
                            if (imc <= 17.6)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 17.6 && imc < 25.4)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 25.4 && imc < 29.7)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 29.7)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 40: //20 años o mas
                            if (imc < 18.5)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 18.5 && imc <= 24.9)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 25.0 && imc <= 29.9)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 30.0 && imc <= 34.9)
                            {
                                //OBESIDAD l
                                categoria = IMCListado.MODERATELY_OBESE;
                            }
                            else if (imc >= 35.0 && imc <= 39.9)
                            {
                                //OBESIDAD ll
                                categoria = IMCListado.SEVERELY_OBESE;
                            }
                            else if (imc >= 40.0)
                            {
                                //OBESIDAD lll
                                categoria = IMCListado.VERY_SEVERELY_OBESE;
                            }
                            break;
                    }
                    break;
                case 1: //Mujer
                    switch (edad)
                    {
                        case 0: //Al nacer
                            if (imc < 2.8)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 2.8 && imc <= 3.7)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 3.7 && imc <= 4.2)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 4.2)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 1: //1 mes
                            if (imc < 3.6)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 3.6 && imc <= 4.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 4.8 && imc <= 5.5)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                                //OBESIDAD
                            }
                            else if (imc > 5.5)
                            {
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 2: //2 meses
                            if (imc < 4.5)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 4.5 && imc <= 5.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 5.8 && imc <= 6.6)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 6.6)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 3: //3 meses
                            if (imc < 5.2)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 5.2 && imc <= 6.6)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 6.6 && imc <= 7.5)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 7.5)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 4: //4 meses
                            if (imc < 5.7)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 5.7 && imc <= 7.3)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 7.3 && imc <= 8.2)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 8.2)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 5: //5 meses
                            if (imc < 6.1)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 6.1 && imc <= 7.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 7.8 && imc <= 8.8)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 8.8)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 6: // 6 meses
                            if (imc < 6.5)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 6.5 && imc <= 8.2)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 8.2 && imc <= 9.3)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 9.3)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 7: //7 meses
                            if (imc < 6.8)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 6.8 && imc <= 8.6)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 8.6 && imc <= 9.8)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 9.8)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 8: //8 meses
                            if (imc < 7.0)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 7.0 && imc <= 9.0)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 9.0 && imc <= 10.2)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 10.2)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 9: //9 meses
                            if (imc < 7.3)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 7.3 && imc <= 9.3)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 9.3 && imc <= 10.5)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 10.5)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 10: //10 meses
                            if (imc < 7.5)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 7.5 && imc <= 9.6)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 9.6 && imc <= 10.9)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 10.9)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 11: //11 meses
                            if (imc < 7.7)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 7.7 && imc <= 9.9)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 9.9 && imc <= 11.2)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 11.2)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 12: //1 año
                            if (imc < 7.9)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 7.9 && imc <= 10.1)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 10.1 && imc <= 11.5)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 11.5)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 13: //1 año 6 meses
                            if (imc < 9.1)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 9.1 && imc <= 11.6)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 11.6 && imc <= 13.2)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 13.2)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 14: //2 años
                            if (imc < 10.2)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 10.2 && imc <= 13.0)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 13.0 && imc <= 14.8)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 14.8)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 15: //2 años y 6 meses
                            if (imc < 11.2)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 11.2 && imc <= 14.4)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 14.4 && imc <= 16.5)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 16.5)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 16: //3 años
                            if (imc < 12.2)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 12.2 && imc <= 15.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 15.8 && imc <= 18.1)
                            {
                                //SOPREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 18.1)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 17: //3 años 6 meses
                            if (imc < 13.1)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 13.1 && imc <= 17.2)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 17.2 && imc <= 19.8)
                            {
                                //SOPREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 19.8)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 18: //4 años
                            if (imc < 14.0)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 14.0 && imc <= 18.5)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 18.5 && imc <= 21.5)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 21.5)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 19: //4 años y 6 meses
                            if (imc < 14.9)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 14.9 && imc <= 19.9)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 19.9 && imc <= 23.2)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 23.2)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 20: //5 años
                            if (imc < 15.8)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 15.8 && imc <= 21.2)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc > 21.2 && imc <= 24.9)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc > 24.9)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 21: //5 años 6 meses
                            if (imc <= 12.7)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 12.7 && imc < 16.9)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 16.9 && imc < 19.0)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 19.0)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 22: //6 años
                            if (imc <= 12.7)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 12.7 && imc < 17.0)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 17.0 && imc < 19.2)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 19.2)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 23: //6 años 6 meses
                            if (imc <= 12.7)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 12.7 && imc < 17.1)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 17.1 && imc < 19.5)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 19.5)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 24: //7 años
                            if (imc <= 12.7)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 12.7 && imc < 17.3)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 17.3 && imc < 19.8)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 19.8)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 25: //7 años 6 meses
                            if (imc <= 12.8)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 12.8 && imc < 17.5)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 17.5 && imc < 20.1)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 20.1)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 26: //8 años
                            if (imc <= 12.9)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 12.9 && imc < 17.7)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 17.7 && imc < 20.6)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 20.6)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 27: //8 años 6 meses
                            if (imc <= 13.0)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.0 && imc < 18.0)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 18.0 && imc < 21.0)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 21.0)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 28: //9 años
                            if (imc <= 13.1)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.1 && imc < 18.3)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 18.3 && imc < 21.5)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 21.5)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 29: //9 años 6 meses
                            if (imc <= 13.3)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.3 && imc < 18.7)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 18.7 && imc < 22.0)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 22.0)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 30: //10 años
                            if (imc <= 13.5)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.5 && imc < 19.0)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 19.0 && imc < 22.6)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 22.6)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 31: //11 años
                            if (imc <= 13.9)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 13.9 && imc < 19.9)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 19.9 && imc < 23.7)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 23.7)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 32: //12 años
                            if (imc <= 14.4)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 14.4 && imc < 20.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 20.8 && imc < 25.0)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 25.0)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 33: //13 años
                            if (imc <= 14.9)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 14.9 && imc < 21.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 21.8 && imc < 26.2)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 26.2)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 34: //14 años
                            if (imc <= 15.4)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 15.4 && imc < 22.7)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 22.7 && imc < 27.3)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 27.3)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 35: //15 años
                            if (imc <= 15.9)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 15.9 && imc < 23.5)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 23.5 && imc < 28.2)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 28.2)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 36: //16 años
                            if (imc <= 16.2)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 16.2 && imc < 24.1)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 24.1 && imc < 28.9)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 28.9)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 37: //17 años
                            if (imc <= 16.4)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 16.4 && imc < 24.5)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 24.5 && imc < 29.3)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 29.3)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 38: //18 años
                            if (imc <= 16.4)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 16.4 && imc < 24.8)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 24.8 && imc < 29.5)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 29.5)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 39: //19 años
                            if (imc <= 16.5)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc > 16.5 && imc < 25.0)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 25.0 && imc < 29.7)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 29.7)
                            {
                                //OBESIDAD
                                categoria = IMCListado.OBESE;
                            }
                            break;
                        case 40: //20 años o mas
                            if (imc < 18.5)
                            {
                                //RIESGO DE DESNUTRICIÓN
                                categoria = IMCListado.UNDER_WEIGHT;
                            }
                            else if (imc >= 18.5 && imc <= 24.9)
                            {
                                //PESO NORMAL
                                categoria = IMCListado.NORMAL;
                            }
                            else if (imc >= 25.0 && imc <= 29.9)
                            {
                                //SOBREPESO
                                categoria = IMCListado.OVER_WEIGHT;
                            }
                            else if (imc >= 30.0 && imc <= 34.9)
                            {
                                //OBESIDAD l
                                categoria = IMCListado.MODERATELY_OBESE;
                            }
                            else if (imc >= 35.0 && imc <= 39.9)
                            {
                                //OBESIDAD ll
                                categoria = IMCListado.SEVERELY_OBESE;
                            }
                            else if (imc >= 40.0)
                            {
                                //OBESIDAD lll
                                categoria = IMCListado.VERY_SEVERELY_OBESE;
                            }
                            break;
                    }
                    break;
            }
            return IMC.getValue(categoria);
        }
    }
}
