using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IStrategy
{
    protected string strategyName;

    public IStrategy(string _name)
    {
        strategyName = _name;
    }

    public virtual void  Calculate()
    {
        Debug.Log(strategyName+" method");
    }
}
