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

        public void UpdateNote(Note note)
        {
            _context.Notes.Update(note);
            _context.SaveChanges();

        }

        public void DeleteNote(Note note)
        {
            var returnedFromDb = _context.Notes.Find(note.Id);
            _context.Notes.Remove(returnedFromDb);
            _context.SaveChanges();
        }
    }
}

