using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
    }

    void OnTiggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameControlScript.health -= 1;
        }
    }
}
