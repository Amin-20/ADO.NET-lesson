using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp3.Commands;

namespace WpfApp3.ViewModels
{
    public class MainWindowViewModels : BaseViewModel
    {
        RelayCommand InsertCommand { get; set; }
        RelayCommand DeleteRelayCommand { get; set; }
        RelayCommand UpdateRelayCommand { get; set; }
        RelayCommand ShowAllRelayCommand { get; set; }

        private TextBox id;

        public TextBox Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }

        private TextBox firstName;

        public TextBox FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged(); }
        }

        private TextBox lastName;

        public TextBox LastName
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
            AuthorsList= new ListBox();

            InsertCommand = new RelayCommand(obj =>
            {
                AuthorsList.Items.Add(firstName.Text);


            });


            DeleteRelayCommand = new RelayCommand(obj =>
            {



            });


            UpdateRelayCommand = new RelayCommand(obj =>
            {


            });

            ShowAllRelayCommand = new RelayCommand(obj =>
            {



            });



        
        }
    }
}
