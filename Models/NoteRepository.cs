using System;

namespace NotesApp.Models
{
    public class NoteRepository : INoteRepository
    {
        private readonly ApplicationDbContext _context;

        public NoteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddNewNote(Note note)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Note> DisplayAllNotes()
        {
            throw new NotImplementedException();
        }

        public Note FindById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

