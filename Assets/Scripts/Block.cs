using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int hits = 1;

    public void OnHit()
    {
        hits--;

        if (hits <= 0)
        {
            Destroy(gameObject);
        }
    }    

}
