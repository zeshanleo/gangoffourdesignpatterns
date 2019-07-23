using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Receiver Action Method invoked!");
        }
    }

    public abstract class Command
    {
        protected Receiver _receiver;

        public Command(Receiver receiver)
        {
            this._receiver = receiver;
        }

        public abstract void ExecuteCommand();

    }

    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver) { }

        public override void ExecuteCommand()
        {
            _receiver.Action();
        }
    }

    public class Invoke
    {
        protected Command _command;

        public void SetCommand(Command command)
        {
            this._command = command;
        }

        public void Execute()
        {
            _command.ExecuteCommand();
        }
    }


}
