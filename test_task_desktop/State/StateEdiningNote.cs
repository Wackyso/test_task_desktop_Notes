using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_task_desktop.Classes;
using test_task_desktop.Interfaces;

namespace test_task_desktop.State
{
    class StateEdiningNote :IState, IToStateWaitingForResponse, IToStateMainWindow
    {
        public StateEdiningNote(Session session)
        {
            session.action = new EditNote();
        }


        public void ToStateWaitingForResponse(Session session)
        {
            session.state = new StateWaitingForResponse();
        }

        public void ToStateMainWindow(Session session)
        {
            session.state = new StateMainWindow(session);
        }
    }
}
