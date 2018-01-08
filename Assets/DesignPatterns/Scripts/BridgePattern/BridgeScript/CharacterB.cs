using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterB : ICharacter
{
    public CharacterB(string _name) : base(_name)
    {
    }

    public override void Attack()
    {
        base.Attack();
    }
}
