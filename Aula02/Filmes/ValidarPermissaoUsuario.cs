using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Filmes
{
    public class ValidarPermissaoUsuario
    {
        public bool Validar(Usuario usuario, Filme filme)
        {
            if (usuario.Idade < filme.IdadeIndicativa)
                return false;
            return true;
        }

    }
}
