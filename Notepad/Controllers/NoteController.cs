using Notepad.Data;
using Notepad.Models;
using Notepad.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Controllers
{
    class NoteController
    {
        private readonly AppDbContext _context;
        private NoteView view;

        public NoteController(NoteView view, AppDbContext context)
        {
            this.view = view;
            _context = context;
        }

        public void Start()
        {
            while (true)
            {
                int choice = view.ShowMenu();
                switch (choice)
                {
                    case 1:
                        AddNote();
                        break;
                    case 2:
                        ListNotes();
                        break;
                    case 3:
                        DeleteNote();
                        break;
                    case 4:
                        return;
                    default:
                        view.ShowMessage("Geçersiz seçim! Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        private void AddNote()
        {
            string content = view.GetNoteContent();
            var note = new Note { Content = content };
            _context.Notes.Add(note);
            _context.SaveChanges();
            view.ShowMessage("Not eklendi!");
        }

        private void ListNotes()
        {
            var notes = _context.Notes.ToList();
            view.ShowNotes(notes);
        }

        private void DeleteNote()
        {
            int id = view.GetNoteId();
            var note = _context.Notes.Find(id);
            if (note != null)
            {
                _context.Notes.Remove(note);
                _context.SaveChanges();
                view.ShowMessage("Not silindi!");
            }
            else
            {
                view.ShowMessage("Belirtilen ID'ye sahip not bulunamadı!");
            }
        }
    }

}
