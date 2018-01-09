using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateTest : MonoBehaviour
{

	// Use this for initialization
	void Start () {

        ConcreteClassA concreteClassA = new ConcreteClassA("A");
        ConcreteClassB concreteClassB = new ConcreteClassB("B");

        concreteClassA.TemplateMethod();
        concreteClassB.TemplateMethod();

    }

    // Update is called once per frame
    void Update () {
		
	}
}
