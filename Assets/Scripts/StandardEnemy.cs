using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardEnemy : Bounce
{
    bool isDebuffed = false;
    void Start()
    {
        PoweUp.PowerUp += ReduceSize;
        PoweUp.StopPowerUp += NormalSize;
    }
    private void OnDestroy()
    {
        PoweUp.PowerUp -= ReduceSize;
        PoweUp.StopPowerUp -= NormalSize;
    }
    private void ReduceSize()
    {
        if (!isDebuffed)
        {
            transform.localScale *= 0.5f;
            isDebuffed = true;
        }
    }
    private void NormalSize()
    {
        if (isDebuffed)
        {
            transform.localScale *= 2f;
            isDebuffed = false;
        }
    }
}
