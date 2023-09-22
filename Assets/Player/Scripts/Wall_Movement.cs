using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Movement: MonoBehaviour
{
    [SerializeField] Transform Destination;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Collider)
    {
        GameObject Player = GameObject.Find("Player");
        Player_Movement Player_Movement_Script = Player.GetComponent<Player_Movement>();

        Debug.Log("Player has entered the Wall");
        Player_Movement_Script.Life -= 1;
        gameObject.SetActive(false);
    }
}
