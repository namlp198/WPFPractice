using ICommandDemo.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ICommandDemo.ViewModel
{
    public class DemoCommandViewModel : INotifyPropertyChanged
    {
        private ICommand showCmd;
        public ICommand ShowCommand
        {
            get
            {
                if (showCmd == null)
                    showCmd = new DemoCommand(p => OnShow());
                return showCmd;
            }
        }

        private string messageText;
        public string MessageText
        {
            get { return messageText; }
            set
            {
                messageText = value;
                OnPropertyChanged("MessageText");
            }
        }
        private void OnShow()
        {
            MessageBox.Show("Hi... " + MessageText, "Message", MessageBoxButton.OK);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
