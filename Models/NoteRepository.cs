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
            note.CalcLength();
            _context.Notes.Add(note);
            _context.SaveChanges();
        }

        public IEnumerable<Note> DisplayAllNotes()
        {
            return _context.Notes;
        }

        public Note FindById(Guid id)
        {
            Note returnedNote = _context.Notes.Find(id);
            return returnedNote;
        }
    }
}

