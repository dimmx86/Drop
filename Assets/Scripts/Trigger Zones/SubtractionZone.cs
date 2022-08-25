using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubtractionZone : TriggerZone
{
    [SerializeField] [Min(1)] private int _subtraction = 5;


    private int _countBall = 0;

    protected override void TriggerBall(Ball ball)
    {
        _countBall++;
        if (_countBall <= _subtraction)
        {
            DestroyBall(ball);
        }        
    }

}
