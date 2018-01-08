using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyA : IStrategy
{
    public StrategyA(string _name) : base(_name)
    {
    }

    public override void Calculate()
    {
        base.Calculate();
        Method();
    }

    public void Method()
    {
        Debug.Log("...dependency method");
    }
}


