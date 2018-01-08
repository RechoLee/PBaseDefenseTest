using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StrategyContext strategyContext = new StrategyContext();

        StrategyA strategyA = new StrategyA("strategyA");
        StrategyB strategyB = new StrategyB("strategyB");


        strategyContext.SetStrategy(strategyA);
        strategyContext.RequestStrategy();

        //需求变化时候
        strategyContext.SetStrategy(strategyB);
        strategyContext.RequestStrategy();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
