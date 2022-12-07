using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Deathplane : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawn;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player has spawned");
        player.transform.position = spawn.transform.position;
    }
}
