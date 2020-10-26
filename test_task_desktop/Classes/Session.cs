using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using test_task_desktop.Interfaces;
using test_task_desktop.Models;
using test_task_desktop.State;

namespace test_task_desktop.Classes
{
    class Session
    {
        public IState state { private get; set; }
        public MainWindow mainwindow;
        Note note;
        public IAction action { get; set; }
        public Session(MainWindow Mainwindow)
        {

            state = new StateMainWindow(this);
            mainwindow = Mainwindow;
            //(state as StateMainWindow).ToStateWaitingForResponse(this); самая гениальная строка(костыль) который я придумал
        }

        public void ShowNotes()
        {
            if (state is StateMainWindow)
            {
                Do_Something_With_Note(0,"");
                

                List<Note> notes = new List<Note> { new Note(0, "edited"), new Note(1, "lol edited") };
                mainwindow.Notes.ItemsSource = notes;
            }

        }

        public void Create_Note()
        {
            if (state is StateMainWindow)
            {
                (state as StateMainWindow).ToStateCreatingNote(this);



                mainwindow.EditNoteButton.Visibility = Visibility.Visible;
            }
        }
        public void Update_Note()
        {
            if (state is StateMainWindow)
            {
                (state as StateMainWindow).ToStateEditingNote(this);
                mainwindow.EditNoteButton.Visibility = Visibility.Visible;
            }
        }

        public void Delete_Note()
        {
            if (state is StateMainWindow)
            {
                (state as StateMainWindow).ToStateDeletingNote(this);
                mainwindow.EditNoteButton.Visibility = Visibility.Visible;
            }
        }

        public void Take_Note_For_Update()
        {
            if (state is StateMainWindow)
            {

            }
        }

        public void Do_Something_With_Note(int id, string text)
        {
            Note note = new Note(id, text);
            action.DoSomethingWithNote(this, note);
        }

        public int Get_id_for_create()
        {
            int id=0;

            var v = mainwindow.Notes.ItemsSource;
            foreach (var s in v)
            {
                if ((s as Note).id >= id) id = (s as Note).id+1;
            }

            return id;
        }
    }
}
