namespace NotesApp.Repos
{
    public interface INoteRepository
    {
        //Returning all existing items in the database
        IEnumerable<Note> DisplayAllNotes();
        //Searching for a certain item and returning it based on its id
        Note FindById(Guid id);
        //Taking a note obj , populating it from the form , and pushing it to the database.
        void AddNewNote(Note note);
        //Accessing a note and updating its current values
        void UpdateNote(Note note);
        //Remove a note from the db
        void DeleteNote(Guid id);



    }
}


