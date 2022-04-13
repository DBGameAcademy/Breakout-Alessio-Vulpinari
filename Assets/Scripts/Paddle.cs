using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float MoveSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left Arrow Pressed!");
            transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right Arrow Pressed!");
            transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
        }
    }
}
