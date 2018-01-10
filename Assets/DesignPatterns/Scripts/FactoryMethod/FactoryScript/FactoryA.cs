using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryA : IFactory
{
    public override IProduct FactoryMethod()
    {
        Debug.Log("生产产品A");
        ProductA productA = new ProductA();
        //TODO...
        return productA;
    }
}
