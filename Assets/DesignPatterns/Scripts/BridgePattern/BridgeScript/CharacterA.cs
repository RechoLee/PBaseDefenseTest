using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterA : ICharacter
{
    public CharacterA(string _name) : base(_name)
    {
    }

    public override void Attack()
    {
        base.Attack();
    }
}
