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
    class EditNote :IAction
    {
        
        public void DoSomethingWithNote(Session session, Note note)
        {
            Network net = new Network();
            IDeserialize des = new JsConvert();
            net.Update(note.id, des.SerializeObj(note));
            session.state = new StateMainWindow(session);
        }

        
    }
}
