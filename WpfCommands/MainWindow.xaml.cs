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

namespace WpfCommands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //viewModel.SimpleCommand.Executing += new CancelCommandEventHandler(EventsCommand_Executing);
            myviewModel.SimpleCommand.Executed += new CommandEventHandler(EventsCommand_Executed);

            //viewModel.SimpleCommand.Executing += new CancelCommandEventHandler(CancellableAsyncCommand_Executing);
            //viewModel.SimpleCommand.Executed += new CommandEventHandler(CancellableAsyncCommand_Executed);
            //viewModel.SimpleCommand.Cancelled += new CommandEventHandler(CancellableAsyncCommand_Cancelled);
        }

        void CancellableAsyncCommand_Cancelled(object sender, CommandEventArgs args)
        {
            //viewModel.Messages.Add("View: Cancellable Async Command Cancelled.");
        }

        void CancellableAsyncCommand_Executed(object sender, CommandEventArgs args)
        {
            //viewModel.Messages.Add("View: Cancellable Async Command Executed.");
        }

        void CancellableAsyncCommand_Executing(object sender, CancelCommandEventArgs args)
        {
            //viewModel.Messages.Add("View: Cancellable Async Command Executing.");
        }

        void EventsCommand_Executed(object sender, CommandEventArgs args)
        {
            //viewModel.Messages.Add("The command has finished - this is the View speaking!");
        }

        void EventsCommand_Executing(object sender, CancelCommandEventArgs args)
        {
            if (MessageBox.Show("Cancel the command?", "Cancel?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                args.Cancel = true;
        }
    }
}
