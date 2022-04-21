using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hits = 1;
    public int ScoreValue = 100;

    public bool Moving = false;
    public List<Transform> Position = new List<Transform>();
    int posIndex = 0;
    public float MoveSpeed = 3;

    GameController gameController;

    public AudioClip OnBreakAudio;

    private void Start()
    {
        if (Moving)
        {
            transform.position = Position[0].position;
        }
    }

    private void Update()
    {
        if (Moving)
        {
           transform.position = Vector3.Lerp(transform.position, Position[posIndex].position, Time.deltaTime * MoveSpeed);

            if (Vector3.Distance(transform.position, Position[posIndex].position) < 0.5f)
            {
                posIndex++;
                if (posIndex >= Position.Count)
                {
                    posIndex = 0;
                }

            }
        }
    }

    private void Awake()
    {
        gameController = FindObjectOfType<GameController>();
    }

    public void OnHit()
    {
        hits--;

        if (hits <= 0)
        {
            gameController.AddScore(ScoreValue);
            gameController.AudioController.PlayClip(OnBreakAudio);
            Instantiate(gameController.ExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }    

}
