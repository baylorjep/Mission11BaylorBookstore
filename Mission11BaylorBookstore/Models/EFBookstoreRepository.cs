
namespace Mission11BaylorBookstore.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext _context;
        public EFBookstoreRepository(BookstoreContext temp)
        {
            _context = temp;
        }
        public List<Book> Books => _context.Books.ToList();
    }
}
