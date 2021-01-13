using System;
using System.Collections.Generic;
using System.Text;
using Notes.DB;

namespace Notes.Core
{
    public interface INotesServices
    {
        NoteArray CreateNote(NoteArray note);
        NoteArray GetNote(int id);
        List<NoteArray> GetNotes();
        void DeleteNote(int id);

        void EditNote(NoteArray note);
    }
}
