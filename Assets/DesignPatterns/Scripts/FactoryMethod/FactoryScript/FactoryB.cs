using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryB : IFactory
{
    public override IProduct FactoryMethod()
    {
        Debug.Log("生产产品B");
        ProductB productB = new ProductB();
        //TODO...
        return productB;
    }
}
