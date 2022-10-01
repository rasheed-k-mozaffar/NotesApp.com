namespace NotesApp;

public interface INoteRepository
{

    IEnumerable<Note> DisplayAllNotes();
    Note FindById(Guid id);

    void AddNewNote(Note note);



}
