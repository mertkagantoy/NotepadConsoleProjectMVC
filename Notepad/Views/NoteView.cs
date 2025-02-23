using Notepad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad.Views
{
    class NoteView
    {
        public int ShowMenu()
        {
            Console.WriteLine("\n1. Yeni not ekle");
            Console.WriteLine("2. Notları listele");
            Console.WriteLine("3. Not sil");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminiz: ");
            return int.Parse(Console.ReadLine());
        }

        public string GetNoteContent()
        {
            Console.Write("Notunuzu girin: ");
            return Console.ReadLine();
        }

        public int GetNoteId()
        {
            Console.Write("Silmek istediğiniz notun ID'sini girin: ");
            return int.Parse(Console.ReadLine());
        }

        public void ShowNotes(List<Note> notes)
        {
            if (notes.Count == 0)
            {
                Console.WriteLine("Henüz eklenmiş bir not yok.");
            }
            else
            {
                Console.WriteLine("Mevcut Notlar:");
                foreach (var note in notes)
                {
                    Console.WriteLine($"ID: {note.Id} - {note.Content}");
                }
            }
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
