using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.DesignPatterns.Scripts.StatePattern
{
    public class ConcreteStateA : State
    {
        public ConcreteStateA(Context _context) : base(_context)
        {
        }

        public override void Handle(int num)
        {
            Debug.Log("ConcreteStateA.Handle");
            if (num > 10)
                m_Context.SetState(new ConcreteStateB(m_Context));
        }
    }
}
