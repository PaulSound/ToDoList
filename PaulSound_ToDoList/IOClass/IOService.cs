using PaulSound_ToDoList.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PaulSound_ToDoList.IOClass
{
    public class IOService
    {
        private string _path;
        public IOService(string PATH)
        {
            _path = PATH;
        }
        public BindingList<DataModel> LoadData()
        {
            bool exists=File.Exists(_path);
            if(!exists)
            {
                File.OpenText(_path).Dispose();
                return new BindingList<DataModel>();
            }
            using (StreamReader reader=File.OpenText(_path))
            {
                string output = reader.ReadToEnd();
                if(output=="") return new BindingList<DataModel>();
                return JsonConvert.DeserializeObject<BindingList<DataModel>>(output);
            }
        }
        public void SaveData(BindingList<DataModel>list)
        {
            using (StreamWriter writer=File.CreateText(_path))
            {
                string input=JsonConvert.SerializeObject(list);
                writer.WriteLine(input);
            }
        }
    }
}
