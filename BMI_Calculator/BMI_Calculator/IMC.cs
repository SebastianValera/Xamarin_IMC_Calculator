using System;
using System.Collections.Generic;
using System.Text;

namespace BMI_Calculator
{
    /// <summary>
    /// Dedicado a tener los diferentes tipos de peso
    /// </summary>
    public enum IMCListado
    {
        NINGUNO,UNDER_WEIGHT, NORMAL, OVER_WEIGHT, OBESE, MODERATELY_OBESE, SEVERELY_OBESE, VERY_SEVERELY_OBESE
    }

    /// <summary>
    /// Clase dedicada a mostrar la categoria de peso en la que corresponde el usuario
    /// </summary>
    public class IMC
    {
        private static IMCListado imcLista;
        public IMC(IMCListado imc) {
            imcLista = imc;
        }
        public static String getValue(IMCListado imc)
        {
            String imcStr = "Sin valor";
            switch (imc)
            {
                case IMCListado.UNDER_WEIGHT:
                    imcStr = "RIESGO DE DESNUTRICIÓN";
                    break;
                case IMCListado.NORMAL:
                    imcStr = "PESO NORMAL";
                    break;
                case IMCListado.OVER_WEIGHT:
                    imcStr = "SOBREPESO";
                    break;
                case IMCListado.OBESE:
                    imcStr = "OBESIDAD";
                    break;
                case IMCListado.MODERATELY_OBESE:
                    imcStr = "GRADO DE OBESIDAD l";
                    break;
                case IMCListado.SEVERELY_OBESE:
                    imcStr = "GRADO DE OBESIDAD ll";
                    break;
                case IMCListado.VERY_SEVERELY_OBESE:
                    imcStr = "GRADO DE OBESIDAD lll";
                    break;
            }
            return imcStr;
        }
    }
}
