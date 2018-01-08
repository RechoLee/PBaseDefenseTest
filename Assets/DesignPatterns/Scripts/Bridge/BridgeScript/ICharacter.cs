using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICharacter
{
    protected string m_Name;

    protected IWeapon m_Weapon;

    public ICharacter(string _name)
    {
        m_Name = _name;
    }

    public void SetWeapon(IWeapon weapon)
    {
        m_Weapon = weapon;
    }

    public virtual void Attack()
    {
        Debug.Log(m_Name + " Attack");
        if (m_Weapon != null)
            m_Weapon.Fire();
    }
}

