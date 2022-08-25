using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivisorZone : TriggerZone
{
    [SerializeField][Min(2)] private int _divisor = 2;

    private int _countBall = 0;

    protected override void TriggerBall(Ball ball)
    {
        _countBall++;
        if (_countBall % _divisor == 0)
        {
            return;
        }
        else
        {
            DestroyBall(ball);
        }
    }

}
