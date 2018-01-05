using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController
{
    BaseSceneState m_State;

    bool isLoad=false;
    private bool runBegin=false;

    public void SetState(BaseSceneState _state,string loadSceneName)
    {


        //载入场景
        LoadScene(loadSceneName);
        //通知前一个State结束
        if (m_State != null)
            m_State.StateEnd();

        //设置新的状态
        m_State = _state;

    }

    //载入场景的方法
    private void LoadScene(string sceneName)
    {
        if (sceneName == null || sceneName.Length == 0)
            return;
        SceneManager.LoadScene(sceneName);
        ////异步加载
        AsyncOperation asyncOperation= SceneManager.LoadSceneAsync(sceneName);
    }

    /// <summary>
    /// 更新状态
    /// </summary>
    public void StateUpdate()
    {
        //判断是否还在加载
        if (isLoad)
            return;
        //通知新的State开始
        if(m_State!=null&&runBegin==false)
        {
            m_State.StateBegin();
            runBegin = true;
        }

        if (m_State != null)
            m_State.StateUpdate();
    }
}

