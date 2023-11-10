using ExerciciosRefatoracao.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.UI
{
    public class CadastroPJ
    {
        ClienteRepository _repository;
        public CadastroPJ(ClienteRepository repository) { this._repository = repository; }
        public void Load()
        {

        }
    }
}
