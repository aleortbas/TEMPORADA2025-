using TEMPORADA2025_.Models;

namespace TEMPORADA2025_
{
    public class FutbolistService
    {
        private readonly FutbolistaRepository _futbolistaRepository;
        public FutbolistService()
        {
            _futbolistaRepository = new FutbolistaRepository();
        }
        public List<Futbolista> GetAllFutbolistas()
        {
            return _futbolistaRepository.GetAllFutbolistas();
        }
    }
}
