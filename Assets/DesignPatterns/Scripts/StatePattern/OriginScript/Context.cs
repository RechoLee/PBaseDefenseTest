using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.DesignPatterns.Scripts.StatePattern
{
    public class Context
    {
        State m_State = null;

        public void Request(int num)
        {
            m_State.Handle(num);

        }
        
        public void SetState(State _state)
        {
            Debug.Log("Context.SetState.."+_state);
            m_State = _state;
        }

    }
}
