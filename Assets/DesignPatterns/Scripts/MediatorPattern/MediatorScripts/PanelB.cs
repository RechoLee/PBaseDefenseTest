using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelB :Panel
{
    public PanelB(IMediator _mediator, string _myName) : base(_mediator, _myName)
    {
    }

    public override void Hide()
    {
        base.Hide();
    }

    public override void Show()
    {
        base.Show();
    }
}
