using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace introduccionCsharp.Models
{
    public class MultiplicacionSuma
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }
        public string ProcesoTexto { get; set; }

        public void CalcularMultiplicacion()
        {
            this.Res = 0;
            this.ProcesoTexto = "";
            int veces = Math.Abs(this.Num2);

            for (int i = 1; i <= veces; i++)
            {
                this.Res += this.Num1;
                this.ProcesoTexto += this.Num1;

                if (i < veces)
                {
                    this.ProcesoTexto += " + ";
                }
            }

            if (this.Num2 < 0) { this.Res = -this.Res; }
        }
    }
}