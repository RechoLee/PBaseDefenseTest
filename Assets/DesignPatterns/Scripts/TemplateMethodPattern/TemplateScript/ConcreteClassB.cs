using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteClassB : AbstractClass
{
    public ConcreteClassB(string _name) : base(_name)
    {
    }

    protected override void MethodA()
    {
        Debug.Log(myName+":MethodA");
    }

    protected override void MethodB()
    {
        Debug.Log(myName + ":MethodB");
    }

    protected override void MethodC()
    {
        Debug.Log(myName + ":MethodC");
    }
}
