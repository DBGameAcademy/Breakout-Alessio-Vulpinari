using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hits = 1;
    public int ScoreValue = 100;

    GameController gameController;

    public AudioClip OnBreakAudio;

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
