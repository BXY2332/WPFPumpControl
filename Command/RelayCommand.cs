using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Windows.Input;

namespace Motor.Command
{
    public class RelayCommand : ICommand
    {
        public readonly Action<object> _execute;
        public readonly Func<object, bool>? _canExecute;

        public RelayCommand(Action<object> execute,Func<object,bool>? canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;

        public void Execute(object? parameter) => _execute.Invoke(parameter!);

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
