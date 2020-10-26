using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using test_task_desktop.Classes;
using test_task_desktop.Interfaces;
using test_task_desktop.Models;

namespace test_task_desktop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Session session;
        IAction action;
        int id=0;
        

        public MainWindow()
        {
            InitializeComponent();
            EditNoteButton.Visibility = Visibility.Hidden;

            

            session = new Session(this);

            session.ShowNotes();
        }

        private void Notes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((Notes.SelectedItem as Note) != null)
            {
                id = (Notes.SelectedItem as Note).id;
                test.Content = id;

                NoteEditBox.Text = (e.AddedItems[0] as Note).text;
            }
        }

        private void Button_Click_For_action(object sender, RoutedEventArgs e)
        {
            test.Content = "action";
            session.Do_Something_With_Note(id, NoteEditBox.Text);
                                                                                                
        }

        private void Show_notes_Button_Click(object sender, RoutedEventArgs e)
        {
            session.ShowNotes();
        }

        private void Create_Note_Button_Click(object sender, RoutedEventArgs e)
        {
            id = 0;
            session.Create_Note();
            /*var v = Notes.ItemsSource;
            foreach (var s in v)
                id++;*/
            test.Content = id+ " id of new note";
        }
        private void Update_Note_Button_Click(object sender, RoutedEventArgs e)
        {
            session.Update_Note();
        }

        private void Delete_Note_Button_Click(object sender, RoutedEventArgs e)
        {
            session.Delete_Note();
        }
    }
}
