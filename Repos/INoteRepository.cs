namespace NotesApp.Repos
{
    public interface INoteRepository
    {

        IEnumerable<Note> DisplayAllNotes();
        Note FindById(Guid id);

        void AddNewNote(Note note);



    }
}


