using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel
{
    public string myName=default(string);

    public IMediator mediator;

    public Panel() { }
    public Panel(IMediator _mediator,string _myName)
    {
        mediator = _mediator;
        myName = _myName;
    }

    public virtual void Show()
    {
        Debug.Log(myName+":Show");
    }

    public virtual void Hide()
    {
        Debug.Log(myName + ":Hide");
    }
}
