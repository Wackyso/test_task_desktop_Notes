using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_task_desktop.Interfaces;
using test_task_desktop.Models;
using test_task_desktop.Networking;
using test_task_desktop.State;

namespace test_task_desktop.Classes
{
    class GetAllNotes :IAction
    {
         public async void DoSomethingWithNote(Session session, Note note)
        {
            IDeserialize des = new JsConvert();
            Network net = new Network();
            //var answ = await net.GetAll();
            IEnumerable<Note> aa = await net.GetAll();
            session.mainwindow.Notes.ItemsSource = aa;
            session.mainwindow.test.Content = "get notes";
        }
    }
}
