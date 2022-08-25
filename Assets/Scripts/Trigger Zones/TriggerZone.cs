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


    protected void AddBall(Ball ball)
    {
        var newball = PoolBall.instance.GiveBall();
        newball.transform.position = RandomPosition();
        newball.gameObject.SetActive(true);
        newball.SetCheckingZones(ball.CheckingZones);
    }


    protected void DestroyBall(Ball ball)
    {
        PoolBall.instance.ReturnInPool(ball);
    }

    protected Vector3 RandomPosition()
    {
        Vector3 randomVector = new Vector3(
            Random.Range(-transform.localScale.x / 2, transform.localScale.x / 2),
            Random.Range(-transform.localScale.y / 2, transform.localScale.y / 2),
            Random.Range(-transform.localScale.z / 2, transform.localScale.z / 2));
        return transform.position + randomVector;
    }
}
