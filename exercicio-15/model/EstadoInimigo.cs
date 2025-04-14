using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_15.model
{
    public interface EstadoInimigo
    {
        void EntrarNoEstado(Inimigo inimigo);
        void Atualizar(Inimigo inimigo);
    }
}