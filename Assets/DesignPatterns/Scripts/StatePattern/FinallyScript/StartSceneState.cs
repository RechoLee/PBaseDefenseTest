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
        //进行游戏的初始化工作，数据资源等的加载
    }

    public override void StateEnd()
    {
        base.StateEnd();
        //资源场景等的保存操作
    }

    public override void StateUpdate()
    {
        base.StateUpdate();
        //可以设置载入动画等的播放
        
    }
}

