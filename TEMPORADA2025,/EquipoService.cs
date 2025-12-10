using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEMPORADA2025_.Models;

namespace TEMPORADA2025_
{
    public class EquipoService
    {
        private readonly EquipoRepository _equipoRepository;
        private readonly EquipoRepository _repository = new EquipoRepository();

        public EquipoService()
        {
            _equipoRepository = new EquipoRepository();
        }

        public List<ListaEquipos> LoadTeams()
        {
            // Simple pass-through method
            return _repository.GetTeamListForComboBox();
        }
    }
}
