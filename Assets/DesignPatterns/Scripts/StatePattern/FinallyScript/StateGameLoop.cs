using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateGameLoop : MonoBehaviour
{

    SceneStateController sceneStateController = new SceneStateController();

    private void Awake()
    {
        GameObject.DontDestroyOnLoad(this.gameObject);
        
    }

    // Use this for initialization
    void Start ()
    {
        //设置初始场景
        sceneStateController.SetState(new StartSceneState(sceneStateController),"");   	
	}
	
	// Update is called once per frame
	void Update () {
        sceneStateController.StateUpdate();
	}
}
