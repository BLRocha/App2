using App2.Context;

namespace App2.Models.Repositores.Repository
{
    abstract public class ARepository
    {
        protected readonly ContextDb _context;

        public ARepository(ContextDb context)
        {
            _context = context;
        }
    }
}
