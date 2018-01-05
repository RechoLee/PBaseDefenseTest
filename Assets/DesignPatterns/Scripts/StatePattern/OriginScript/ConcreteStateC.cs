using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.DesignPatterns.Scripts.StatePattern
{
    public class ConcreteStateC : State
    {
        public ConcreteStateC(Context _context) : base(_context)
        {
        }

        public override void Handle(int num)
        {
            Debug.Log("ConcreteStateC.Handle");
            if (num > 30)
                m_Context.SetState(new ConcreteStateA(m_Context));
        }
    }
}
