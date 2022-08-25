using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBall : MonoBehaviour
{
    public static PoolBall instance = null;

    [SerializeField] private Ball _prefab;

    private Queue<Ball> _poolBals;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        _poolBals = new Queue<Ball>();
    }

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
