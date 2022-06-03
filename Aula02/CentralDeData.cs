using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    public class CentralDeData
    {
        public int TotalDeDias(string dataInicial, string dataFinal)
        {
            return (Convert.ToDateTime(dataFinal) - Convert.ToDateTime(dataInicial)).Days;
        }
    }
}
