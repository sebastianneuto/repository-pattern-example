using System.Collections.Generic;
using UnityEngine;
using Interfaces;
using Entities;

namespace Infrastructure
{
    [CreateAssetMenu(fileName = "Book Repository", menuName = "Repositories/Book Repository")]
    public class BookRepository : ScriptableObject, IRepository<Book>
    {
        [SerializeField] private List<Book> _books;
        public void Add (Book entity)
        {
            _books.Add(entity);
        }

        public void Delete (int id)
        {
            _books.Remove(Get(id));
        }

        public Book Get (int id)
        {
            Book outBook = _books.Find(b => b.Id == id);
            return outBook;
        }

        public void UpdateData (Book entity)
        {
            Debug.Log("Book Updated xd.");
        }
    }
}