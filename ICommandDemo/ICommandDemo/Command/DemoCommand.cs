﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ICommandDemo.Command
{
    public class DemoCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public DemoCommand(Action<object> execute)
        {
            this.execute = execute;
            this.canExecute = null;
        }
        public DemoCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.CanExecute(parameter);
        }
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
