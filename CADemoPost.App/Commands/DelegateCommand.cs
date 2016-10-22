using System;
using System.Windows.Input;

namespace RamboTweets.App.Commands
{
    /// <summary>
    /// Class DelegateCommand.
    /// </summary>
    /// <seealso cref="System.Windows.Input.ICommand" />
    public class DelegateCommand : ICommand
    {
        /// <summary>
        /// The command
        /// </summary>
        private readonly Action _command;
        /// <summary>
        /// The command object
        /// </summary>
        private readonly Action<object> _commandObj;
        /// <summary>
        /// The can execute
        /// </summary>
        private readonly Func<bool> _canExecute;
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="canExecute">The can execute.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public DelegateCommand(Action<object> command, Func<bool> canExecute = null)
        {
            if (command == null)
                throw new ArgumentNullException();
            _canExecute = canExecute;
            _commandObj = command;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="canExecute">The can execute.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public DelegateCommand(Action command, Func<bool> canExecute = null)
        {
            if (command == null)
                throw new ArgumentNullException();
            _canExecute = canExecute;
            _command = command;
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            _command();
        }

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>true if this command can be executed; otherwise, false.</returns>
        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;
            return _canExecute();
        }

        /// <summary>
        /// Rasies the can execute changed.
        /// </summary>
        public void RasieCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

    }
}
