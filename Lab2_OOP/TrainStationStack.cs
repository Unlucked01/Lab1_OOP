using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP
{
    public class TrainStationStack : Stack<TrainStation>
    {
        public delegate void StackEventHandler(object sender, StackEventArgs e);
        public event StackEventHandler? StackChanged;

        public new void Push(TrainStation item)
        {
            base.Push(item);
            OnStackChanged(StackAction.Push, item);
        }

        public new TrainStation Pop()
        {
            TrainStation item = base.Pop();
            OnStackChanged(StackAction.Pop, item);
            return item;
        }

        protected virtual void OnStackChanged(StackAction action, TrainStation item)
        {
            if (StackChanged != null)
            {
                if (action == StackAction.Push)
                {
                    StackEventArgs args = new StackEventArgs(action, item);
                    StackChanged(this, args);
                }
                else if (action == StackAction.Pop)
                {
                    StackEventArgs args = new StackEventArgs(action, item);
                    StackChanged(this, args);
                }
            }
        }
    }

    public enum StackAction
    {
        Push,
        Pop
    }
    public class StackEventArgs : EventArgs
    {
        public StackAction Action { get; private set; }
        public TrainStation Item { get; private set; }

        public StackEventArgs(StackAction action, TrainStation item)
        {
            Action = action;
            Item = item;
        }
    }
    public class TrainStationListener
    {
        private TrainStationStack _stack;
        int fl = 0;

        public TrainStationListener(TrainStationStack stack)
        {
            _stack = stack;
            _stack.StackChanged += OnStackChanged;
        }

        private void OnStackChanged(object sender, StackEventArgs e)
        {
            string message = $"Stack changed: {e.Action.ToString()},\n{e.Item.ToString()}";
            if (fl < 1)
            {
                MessageBox.Show(message, "Stack Changed");
                fl++;
            }
        }
    }
}
