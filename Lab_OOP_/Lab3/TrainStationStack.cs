using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_.Lab3
{
    public enum StackAction
    {
        Push,
        Pop
    }

    public class StackChangedEventArgs<T> : EventArgs
    {
        public StackChangedEventArgs(StackAction action, T item)
        {
            Action = action;
            Item = item;
        }

        public StackAction Action { get; }
        public T Item { get; }
    }

    public delegate void StackChangedEventHandler<T>(object sender, StackChangedEventArgs<T> e);

    public class TrainStationStack<T> : Stack<T>
    {
        public event StackChangedEventHandler<T> StackChanged;

        public new void Push(T item)
        {
            base.Push(item);
            OnStackChanged(StackAction.Push, item);
        }

        public new T Pop()
        {
            T item = base.Pop();
            OnStackChanged(StackAction.Pop, item);
            return item;
        }

        protected virtual void OnStackChanged(StackAction action, T item)
        {
            StackChanged?.Invoke(this, new StackChangedEventArgs<T>(action, item));
        }
    }

    public class StackListener<T>
    {
        private TrainStationStack<T> _stack;

        public StackListener(TrainStationStack<T> stack)
        {
            _stack = stack;
            _stack.StackChanged += OnStackChanged;
        }

        private void OnStackChanged(object sender, StackChangedEventArgs<T> e)
        {
            MessageBox.Show($"Действие: {e.Action}, " +
                $"Станция:\n{e.Item}");
        }
    }

}
