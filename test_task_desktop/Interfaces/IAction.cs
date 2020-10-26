using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_task_desktop.Classes;
using test_task_desktop.Models;

namespace test_task_desktop.Interfaces
{
    interface IAction
    {
        void DoSomethingWithNote(Session session, Note note);
    }
}
