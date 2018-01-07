using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteMediator : IMediator
{
    public override void AddUIPanel(Panel panel)
    {
        base.AddUIPanel(panel);
    }

    public override void RemoveUIPanel(Panel panel)
    {
        base.RemoveUIPanel(panel);
    }

    public override void SendUIMessage()
    {
        base.SendUIMessage();
    }

    /// <summary>
    /// 负责panel之间的交互活动
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="reciver"></param>
    public void NotifyShow(string name)
    {
        foreach (Panel item in uiPanelList)
        {
            if (name.Equals(item.myName))
            {
                item.Show();
            }
        }
    }


    public void NotifyHide(string name)
    {
        foreach (Panel item in uiPanelList)
        {
            if (item.myName.Equals(name))
            {
                item.Hide();
            }
        }
    }
}

