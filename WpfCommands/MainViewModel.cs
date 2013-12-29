using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCommands
{
    public class MainViewModel: ViewModel
    {
        private Command simpleCommand;

        public MainViewModel()
        {
            //simpleCommand = new Command(DoSimpleCommand);
           // simpleCommand = new Command(
           //     () =>
           //     {
           //         SetupMsg("Calling the lamda command - no explicit function necessary.");
           //     }
           //);
            simpleCommand = new Command(
                (parameter) =>
                {
                    SetupMsg("Calling a parameterized command - the parameter is '" +
                        parameter.ToString() + "'.");
                }, CanExecute
                );
        }


        private void SetupMsg(string msg)
        {
            var str = new StringHelper();
            str.Text = msg;
            Messages.Add(str);
        }

        private void DoSimpleCommand()
        {
           SetupMsg("Calling 'DoSimpleCommand'.");
        }

        public Command SimpleCommand
        {
            get { return simpleCommand; }
        }

        private ObservableCollection<StringHelper> messages = new ObservableCollection<StringHelper>();

        public ObservableCollection<StringHelper> Messages
        {
            get { return messages; }
        }

        bool CanExecute
        {
            get { return 1 == 1; }
        }
    }
}
