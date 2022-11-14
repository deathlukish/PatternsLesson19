using System;

namespace PatternsLesson19.Commands
{
    internal class RelayCommand : BaseComamd
    {
        private readonly Action<object> _Action;
        private readonly Func<object, bool> _CanExucute;
        public RelayCommand(Action<object> action, Func<object, bool> canExecute)
        {
            _Action = action ?? throw new ArgumentNullException(nameof(action));
            _CanExucute = canExecute;
        }
        public override bool CanExecute(object? parameter) => _CanExucute?.Invoke(parameter) ?? true;
        public override void Execute(object? parameter) => _Action(parameter);
    }
}
