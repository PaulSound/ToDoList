using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PaulSound_ToDoList.MODEL
{
    public class DataModel:INotifyPropertyChanged // Все свойсва прикрепляются через свйоства  Binding ="{inding Path = }" также реализую интерфейс
    {
        private string _job;
        private bool _done;
        private string _desc;
        private readonly DateTime _date=DateTime.Now;
        public string Job
        {

            get { return _job; }
            set
            {
                if (_job == value)
                    return;
                _job = value;
                PropChanged("Job");
            }
        }
        public string Desc
        {
            get { return _desc; }
            set
            {
                if (_desc == value)
                    return;
                _desc = value;
                PropChanged("Description");
            }
        }
        public bool Done
        {
            get { return _done; }
            set
            {
                if (_done == value)
                    return;
                _done= value;
                PropChanged("Done");
            }
        }
        public DateTime DateCreation { get=>_date; }

        public event PropertyChangedEventHandler PropertyChanged;

       protected virtual void PropChanged(string name="")
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(name));
        }
    }
}
