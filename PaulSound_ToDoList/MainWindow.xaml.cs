using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PaulSound_ToDoList.MODEL;
using System.ComponentModel;
namespace PaulSound_ToDoList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<DataModel> dataJob=new BindingList<DataModel>()
        { 
          new DataModel(){ Job="Wash hair",Done=false,Desc="You should wash your hair"},
          new DataModel(){Job="Wipe your ass",Done=true,Desc="Ass should be wiped"}
        
        };
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
      
            dataGridToDo.ItemsSource = dataJob; // привязал коллекцию к свойству ItemSource именнованной сетке DateGrid(dataGridToDo)
            dataJob.ListChanged += AddNewJob;
        }

        private void AddNewJob(object sender, ListChangedEventArgs e)
        {
            MessageBox.Show(e.ListChangedType.ToString());
        }
    }
}
