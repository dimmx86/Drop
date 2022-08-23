using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {        
        if (other.TryGetComponent<Ball>(out Ball ball))
        {
            if (ball.ThisZoneChecking(this))
            {
                return;
            }
            else
            {
                ball.AddCheckingZones(this);
                TriggerBall(ball);
            }            
        }
    }

    protected virtual void TriggerBall(Ball ball)
    {

    }
}
