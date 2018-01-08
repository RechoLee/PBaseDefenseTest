using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IWeapon
{
    protected string m_Name;

    public IWeapon(string _name)
    {
        m_Name=_name;
    }

    public virtual void Fire() {
        Debug.Log("use "+m_Name+" fire");
    }
}

