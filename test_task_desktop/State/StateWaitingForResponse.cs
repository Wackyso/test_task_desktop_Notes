﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_task_desktop.Classes;

namespace test_task_desktop.State
{
    class StateWaitingForResponse :IState, IToStateMainWindow
    {
        public void ToStateMainWindow(Session session)
        {
            session.state = new StateMainWindow(session);
        }
    }
}
