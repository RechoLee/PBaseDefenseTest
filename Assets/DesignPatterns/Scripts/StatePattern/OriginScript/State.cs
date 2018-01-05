using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.DesignPatterns.Scripts.StatePattern
{
    public abstract class State
    {
        protected Context m_Context = null;
        public State(Context _context)
        {
            m_Context = _context;
        }
        public abstract void Handle(int num);


    }
}
