using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    ConcreteMediator mediator;
    PanelA panelA;
    PanelB panelB;


    private void Start()
    {
        Debug.Log("start");
        mediator = new ConcreteMediator();

        panelA = new PanelA(mediator,"PanelA");
        panelB = new PanelB(mediator,"PanelB");

        mediator.AddUIPanel(panelA);
        mediator.AddUIPanel(panelB);

        mediator.NotifyHide("PanelB");

        mediator.NotifyShow("PanelA");
        Debug.Log("end");
    }

}
