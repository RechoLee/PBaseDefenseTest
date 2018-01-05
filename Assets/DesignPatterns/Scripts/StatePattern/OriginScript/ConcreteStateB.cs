using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.DesignPatterns.Scripts.StatePattern
{
    public class ConcreteStateB : State
    {
        public ConcreteStateB(Context _context) : base(_context)
        {
        }

        public override void Handle(int num)
        {
            Debug.Log("ConcreteStateB.Handle");
            if (num > 20)
                m_Context.SetState(new ConcreteStateC(m_Context));
        }
    }
}
