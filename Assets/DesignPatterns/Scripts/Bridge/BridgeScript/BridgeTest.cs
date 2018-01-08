using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        CharacterA characterA = new CharacterA("xiaoming");
        CharacterB characterB = new CharacterB("lisi");

        Weapon1 weapon1 = new Weapon1("weapon1");
        Weapon2 weapon2 = new Weapon2("weapon2");

        characterA.SetWeapon(weapon2);
        characterB.SetWeapon(weapon1);

        characterA.Attack();
        characterB.Attack();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
