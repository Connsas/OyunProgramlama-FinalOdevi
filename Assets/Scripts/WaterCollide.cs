using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCollide : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Flame"))
        {
            GameObject.Destroy(other.gameObject);
            ScoreSystem.Score++;

        }
    }

    
}
