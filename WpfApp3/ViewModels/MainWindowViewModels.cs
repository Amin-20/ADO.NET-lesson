using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp3.Commands;
using WpfApp3.Models;
using WpfApp3.Repository;

namespace WpfApp3.ViewModels
{
    public class MainWindowViewModels : BaseViewModel
    {

        public ObservableCollection<Author> authors;
        public Repo AuthorsRepo { get; set; }
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

       


        public MainWindowViewModels()
        {
            AuthorsRepo = new Repo();
            authors=new ObservableCollection<Author>(AuthorsRepo.GetAll());
            

            InsertCommand = new RelayCommand((obj) =>
            {
                


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
