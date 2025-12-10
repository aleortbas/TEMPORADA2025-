using TEMPORADA2025_.Models;

namespace TEMPORADA2025_
{
    public class FutbolistService
    {
        private readonly FutbolistaRepository _futbolistaRepository;

        public FutbolistService(string connectionString)
        {
            _futbolistaRepository = new FutbolistaRepository();
        }

        public void SaveNewPlayer(Futbolista newPlayer)
        {
            // 1. BUSINESS RULE VALIDATION
            if (string.IsNullOrWhiteSpace(newPlayer.NombreFutbolista))
            {
                throw new ArgumentException("The footballer's name cannot be empty.");
            }
            if (newPlayer.Edad < 16)
            {
                throw new ArgumentException("The footballer must be at least 16 years old.");
            }

            // 2. Delegate the save action to the repository
            _futbolistaRepository.InsertaFutbolista(newPlayer);
        }
    }
}