using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_task_desktop.Classes;

namespace test_task_desktop.State
{
    class StateMainWindow :IState, IToStateWaitingForResponse, IToStateEditingNote, IToStateDeletingNote, IToStateCreatingNote
    {
        public StateMainWindow(Session session)
        {
            session.action = new GetAllNotes();
        }

        public void ToStateWaitingForResponse (Session session)
        {
            session.state = new StateWaitingForResponse();
        }

        public void ToStateEditingNote(Session session)
        {
            session.state = new StateEdiningNote(session);
        }

        public void ToStateDeletingNote(Session session)
        {
            session.state = new StateDeletingNote(session);
        }

        public void ToStateCreatingNote(Session session)
        {
            session.state = new StateCreatingNote(session);
        }

    }
}
