using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBall : MonoBehaviour
{
    [SerializeField] private Ball _prefab;

    private Queue<Ball> _poolBals;

    public Ball GiveBall()
    {
        if (_poolBals.Count < 1)
        {
            return Instantiate(_prefab, transform);
        }
        else
        {
            return _poolBals.Dequeue();
        }
    }

    public void ReturnInPool (Ball ball)
    {
        ball.gameObject.SetActive(false);
        _poolBals.Enqueue(ball);
    }
}
