using System;
using System.ComponentModel.DataAnnotations;

namespace Notes.DB
{
    public class NoteArray
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
