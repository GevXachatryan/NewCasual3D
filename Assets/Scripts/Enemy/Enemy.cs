using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    // Код привязан на Enemy

    [Header("Player")]
    [SerializeField] Transform myPlayer;
    private NavMeshAgent myshAgent;

    private void Start()
    {
        myshAgent = GetComponent<NavMeshAgent>();

    }
    private void Update()    // Преследование игрока
    {
        if (PlayGame.playGame == true)
        {
            myshAgent.destination = myPlayer.position;
        }

    }
}
