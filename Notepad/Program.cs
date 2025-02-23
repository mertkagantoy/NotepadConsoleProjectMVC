// See https://aka.ms/new-console-template for more information
using Notepad.Controllers;
using Notepad.Data;
using Notepad.Views;

using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            context.Database.Migrate(); // Veritabanını oluşturur ve günceller.
        }

        NoteView view = new NoteView();
        NoteController controller = new NoteController(view, new AppDbContext());
        controller.Start();
    }
}
