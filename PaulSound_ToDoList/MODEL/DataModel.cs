using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaulSound_ToDoList.MODEL
{
    public class DataModel // Все свойсва прикрепляются через свйоства  Binding ="{inding Path = }"
    {
        private string _job;
        private bool _done;
        private string _desc;

        public string Job { get=>_job; set=>_job=value; }
        public string Desc { get=>_desc; set=>_desc=value; }
        public bool Done { get=>_done; set=>_done=value; }
    }
}
