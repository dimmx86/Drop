using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddZone : TriggerZone
{
    [SerializeField] [Min(1)] private int _addCount = 5;
    [SerializeField] [Range(0f, 0.2f)] private float _deltaTimeSpawn = 0.1f;

    private bool _isCompleted = false;

    protected override void TriggerBall(Ball ball)
    {
        if (!_isCompleted)
        {
            StartCoroutine(Spawn(ball));
            _isCompleted = true;
        }
    }

    private IEnumerator Spawn(Ball ball)
    {
        var delay = new WaitForSeconds(_deltaTimeSpawn);
        for (int i = 0; i < _addCount; i++)
        {
            AddBall(ball);
            yield return delay;
        }
    }


    private static void AddBall(Ball ball)
    {
        //var newball = Instantiate(ball,,, ball.transform.parent);
        var newball = Instantiate(ball);
        newball.SetCheckingZones(ball.CheckingZones);
    }
}
