using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateGameLoop : MonoBehaviour
{

    SceneStateController sceneStateController = new SceneStateController();

    public Rect myRect1;
    public Rect myRect2;
    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
        
    }

    // Use this for initialization
    void Start ()
    {
        //设置初始场景
        sceneStateController.SetState(new StartSceneState(sceneStateController),"StartScene");   	
	}
	
	// Update is called once per frame
	void Update ()
    {
        sceneStateController.StateUpdate();
	}

    private void OnGUI()
    {
        if (GUI.Button(myRect1,"进入主菜单"))
        {
            sceneStateController.SetState(new MainMenuSceneState(sceneStateController), "StartScene");

        }
        if(GUI.Button(myRect2,"进入战斗场景"))
        {
            sceneStateController.SetState(new BattleSceneState(sceneStateController), "StartScene");

        }
    }
}
