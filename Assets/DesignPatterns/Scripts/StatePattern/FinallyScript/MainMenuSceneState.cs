using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSceneState : BaseSceneState
{
    public MainMenuSceneState(SceneStateController _controler) : base(_controler)
    {
        StateName = "MainMenuScene";

    }

    public override void StateBegin()
    {
        base.StateBegin();
    }

    public override void StateEnd()
    {
        base.StateEnd();
    }

    public override void StateUpdate()
    {
        base.StateUpdate();
        //逻辑更新
    }
}

