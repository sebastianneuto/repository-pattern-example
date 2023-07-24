using Entities;
using Interfaces;

namespace Services
{
    public class BookService
    {
        private readonly IRepository<Book> _bookRepository;

        public BookService(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(string id, string name, string description)
        {
            _bookRepository.Add(new Book(int.Parse(id),name,description));
        }

        public void RemoveBook(string id)
        {
            _bookRepository.Delete(int.Parse(id));
        }

        public void UpdateBook (string id, string name, string description)
        {
            _bookRepository.UpdateData(new Book(int.Parse(id), name, description));
        }

        public string GetBook(string id)
        {
            var book = _bookRepository.Get(int.Parse(id));
            if (book != null)
                return $"FOUND BOOK:\nID: {book.Id}\nNAME: {book.Name}\nDESCRIPTION: {book.Description}";
            return "NO BOOK FOUND!";
        }
    }
}