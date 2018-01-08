using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : IWeapon
{
    public Weapon1(string _name) : base(_name)
    {
    }

    public override void Fire()
    {
        base.Fire();
    }
}
