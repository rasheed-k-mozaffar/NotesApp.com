namespace NotesApp;

public interface INoteRepository
{


    IEnumerable<Note> DisplayAllNotes();
    void AddNewNote(Note note);

}
