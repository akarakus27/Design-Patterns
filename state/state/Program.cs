using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            ModifedState modified = new ModifedState();
            modified.DoAction(context);

            DeletedState deleted = new DeletedState();
            deleted.DoAction(context);

           Console.WriteLine( context.GetState().ToString());

            Console.ReadLine();

        }
    }
    interface IState
    {
        void DoAction(Context context);
    }
    class ModifedState:IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State:Modified");
            context.SetState(this);
        }
        public override string ToString()
        {
            return "Modified" ;
        }
    }
    class DeletedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State:Deleted");
            context.SetState(this);
        }
        public override string ToString()
        {
            return "Deleted";
        }

    }
    class AddedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State:Added");
            context.SetState(this);
        }

        public override string ToString()
        {
            return "Added";
        }

    }
    class Context
    {
        private IState _state;
        public void SetState(IState state)
        {
            _state = state;
        }
        public  IState GetState()
        {
            return _state;
        }
    }

}
