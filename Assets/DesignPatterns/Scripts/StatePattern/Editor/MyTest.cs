using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using Assets.DesignPatterns.Scripts.StatePattern;

public class MyTest {

	[Test]
	public void MyTestSimplePasses() {
        // Use the Assert class to test conditions.
        Context context = new Context();

        context.SetState(new ConcreteStateA(context));

        context.Request(50);
	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator MyTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
