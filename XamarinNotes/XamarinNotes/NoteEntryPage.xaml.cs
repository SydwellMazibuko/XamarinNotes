using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinNotes.Models;

namespace XamarinNotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteEntryPage : ContentPage
    {
        public NoteEntryPage()
        {
            InitializeComponent();
        }

        // When the OnSaveButtonClicked event handler is executed, the Note is saved to the database.
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            note.Date = DateTime.Now;
            await App.Database.SaveNoteAsync(note);
            await Navigation.PopAsync(); // Navigate backwards
        }

        // When the OnDeleteButtonClicked event handler is executed, the Note is deleted from the database.
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (Note)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync(); // Navigate backwards
        }

    }
}