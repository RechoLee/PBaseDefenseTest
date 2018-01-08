using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyContext
{
    public IStrategy m_Strategy;

    public void SetStrategy(IStrategy strategy)
    {
        m_Strategy = strategy;
    }

    public void RequestStrategy()
    {
        m_Strategy.Calculate();
    }
}