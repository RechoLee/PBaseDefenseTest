using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMediator
{
    protected List<Panel> uiPanelList=new List<Panel>();

    public virtual void SendUIMessage() { }

    public virtual void AddUIPanel(Panel panel)
    {
        uiPanelList.Add(panel);
    }
    
    public virtual void RemoveUIPanel(Panel panel)
    {
        uiPanelList.Remove(panel);

    }
}
