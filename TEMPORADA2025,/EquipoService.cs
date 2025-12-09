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

        public EquipoService(string connectionString)
        {
            _equipoRepository = new EquipoRepository();
        }

        public void SaveNewEquipo(Futbolista newEquipo)
        {
            // 1. BUSINESS RULE VALIDATION
            if (string.IsNullOrWhiteSpace(newEquipo.Equipo))
            {
                throw new ArgumentException("The footballer's name cannot be empty.");
            }
            if (newEquipo.Edad < 16)
            {
                throw new ArgumentException("The footballer must be at least 16 years old.");
            }
        }
    }
}
