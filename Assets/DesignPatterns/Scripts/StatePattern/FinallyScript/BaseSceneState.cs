using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 场景控制的基类
/// </summary>
public class BaseSceneState
{

    private string stateName;
    
    /// <summary>
    /// 控制者名称
    /// </summary>
    public string StateName
    {
        get { return stateName; }
        set { stateName = value; }
    }

    protected SceneStateController m_Controller = null;
    
    public BaseSceneState()
    { }

    public BaseSceneState(SceneStateController _controler)
    {
        m_Controller = _controler;
    }

    //开始
    public virtual void StateBegin()
    {
        Debug.Log(StateName+":Begin");
    }
    //更新
    public virtual void StateUpdate()
    {
        Debug.Log(StateName + ":Update");
    }
    //结束
    public virtual void StateEnd()
    {
        Debug.Log(StateName + ":End");
    }

    public override string ToString()
    {
        return string.Format("[SceneState:StateName={0}]",StateName);
    }

}

