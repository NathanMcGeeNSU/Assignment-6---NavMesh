using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCube : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore += 10;
        Destroy(gameObject);
    }
}
