using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractClass
{

    protected string myName;

    public AbstractClass(string _name)
    {
        myName = _name;
    }

    /// <summary>
    /// 封装执行流程
    /// </summary>
    public void TemplateMethod()
    {
        //执行流程
        MethodA();
        MethodB();
        MethodC();
        MethodD();
    }

    //交由子类去实现
    protected abstract void MethodA();
    protected abstract void MethodB();
    protected abstract void MethodC();
    private void MethodD()
    {
        //私有方法,子类不用实现
        Debug.Log("父类的MethodD");
    }
}
