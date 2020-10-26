using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using test_task_desktop.Interfaces;

namespace test_task_desktop.Models
{
    class Note
    {
        public int id {  get; private set; }
        public string text {  get; private set; }

        public Note(int id, string text)
        {
            this.id = id;
            this.text = text;
        }
    }
}
