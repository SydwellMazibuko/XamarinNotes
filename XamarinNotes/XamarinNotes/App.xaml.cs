using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinNotes.Data;

namespace XamarinNotes
{
    public partial class App : Application
    {

        static NoteDatabase database;

        // Create the database connection (as a singleton?)
        public static NoteDatabase Database
        {
            get
            {
                if (database == null)
                {
                    // passing in the filename of the database as the argument to the NoteDatabase constructor
                    database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NotesPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
