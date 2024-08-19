using Microsoft.EntityFrameworkCore;
using ProjectWithBlazor.Application.Interfaces;
using ProjectWithBlazor.Domain.Entities;
using ProjectWithBlazor.Infrastructure.Context;

namespace ProjectWithBlazor.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ProjectWithBlazorDbContext _context;
        public BookRepository(IDbContextFactory<ProjectWithBlazorDbContext> factory)
        {
            _context = factory.CreateDbContext();
        }

        public async Task AddAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var book = await GetByIdAsync(id);
            if(book is not null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Book>> GetAllAsync()
        {
            var books = await _context.Books.ToListAsync();
            return books;
        }

        public async Task<Book?> GetByIdAsync(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(e => e.Id == id);
            return book;
        }

        public async Task UpdateAsync(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
