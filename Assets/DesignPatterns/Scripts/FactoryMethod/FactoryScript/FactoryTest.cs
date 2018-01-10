using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        IProduct product;
        FactoryA factoryA = new FactoryA();
        FactoryB factoryB = new FactoryB();

        //返回产品A
        product = factoryA.FactoryMethod();
        //返回产品B
        product = factoryB.FactoryMethod();
	}
	
}
