using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp3.Commands;

namespace WpfApp3.ViewModels
{
    public class MainWindowViewModels : BaseViewModel
    {
        public RelayCommand InsertCommand { get; set; }
        public RelayCommand DeleteRelayCommand { get; set; }
        public RelayCommand UpdateRelayCommand { get; set; }
        public RelayCommand ShowAllRelayCommand { get; set; }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged(); }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged(); }
        }

        private ListBox authorsList;

        public ListBox AuthorsList
        {
            get { return authorsList; }
            set { authorsList = value; OnPropertyChanged(); }
        }


        public MainWindowViewModels()
        {
            AuthorsList = new ListBox();

            InsertCommand = new RelayCommand((obj) =>
            {
                authorsList.Items.Add(FirstName);


            });
            
          

            DeleteRelayCommand = new RelayCommand((obj) =>
            {



            });


            UpdateRelayCommand = new RelayCommand((obj) => { 
            
            });

            ShowAllRelayCommand = new RelayCommand((obj) => {
            
            
            });



        
        }
    }
}
