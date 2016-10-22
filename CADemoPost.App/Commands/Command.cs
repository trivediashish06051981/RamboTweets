using System;
using System.Windows.Input;

namespace RamboTweets.App.Commands
{
    /// <summary>
    /// Class Command.
    /// </summary>
    /// <seealso cref="System.Windows.Input.ICommand" />
    public class Command : ICommand
    {
        /// <summary>
        /// The action
        /// </summary>
        protected Action action;
        /// <summary>
        /// The parameterized action
        /// </summary>
        protected Action<object> parameterizedAction;

        /// <summary>
        /// Gets or sets a value indicating whether this instance can execute.
        /// </summary>
        /// <value><c>true</c> if this instance can execute; otherwise, <c>false</c>.</value>
        public bool CanExecute { get; set; }

        public event EventHandler CanExecuteChanged;

        //public void SampleCommand(Action action, bool canExecute = true);

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>true if this command can be executed; otherwise, false.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        bool ICommand.CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}