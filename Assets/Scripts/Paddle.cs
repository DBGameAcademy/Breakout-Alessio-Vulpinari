using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float MoveSpeed;
    Ball ball;
    GameController gameController;

    private void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    public void Move(Vector2 _direction)
    {
        transform.Translate(_direction  * MoveSpeed * Time.deltaTime);
    }
}
