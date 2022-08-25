using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationZone : TriggerZone
{
    [SerializeField][Min(2)] private int _mult = 2;
    [SerializeField] [Range(0f, 0.2f)] private float _deltaTimeSpawn = 0.1f;


    protected override void TriggerBall(Ball ball)
    {
        
        StartCoroutine(Spawn(ball));
    }

    private IEnumerator Spawn(Ball ball)
    {
        var delay = new WaitForSeconds(_deltaTimeSpawn);
        for (int i = 1; i < _mult; i++)
        {
            AddBall(ball);
            yield return delay;
        }
    }

   
}
