
using System.Windows;
using NEW_CV19.Infrastructure.Commands.Base;

namespace NEW_CV19.Infrastructure.Commands
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
