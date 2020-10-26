using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_task_desktop.Classes;

namespace test_task_desktop.State
{
    class StateDeletingNote :IState, IToStateWaitingForResponse
    {
        public StateDeletingNote(Session session)
        {
            session.action = new DeleteNote();
        }


        public void ToStateWaitingForResponse(Session session)
        {
            session.state = new StateWaitingForResponse();
        }
    }
}
