﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Combustiveis
{
    public class Diesel : Combustivel
    {

        public override string Nome { get; protected set; } = "Diesel";

        public override decimal Preco { get; protected set; } = 6.12m;

    }
}
