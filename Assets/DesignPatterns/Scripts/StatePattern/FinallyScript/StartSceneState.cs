using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneState : BaseSceneState
{
    public StartSceneState(SceneStateController _controler) : base(_controler)
    {
        this.StateName = "StartScene";

    }

    public override void StateBegin()
    {
        base.StateBegin();
        //进行游戏的初始化
    }

    public override void StateEnd()
    {
        base.StateEnd();

    }

    public override void StateUpdate()
    {
        base.StateUpdate();
    }
}

