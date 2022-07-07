using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public Stopwatch sw;
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            sw.StopStopwatch();
            gameManager.CompleteLevel();
        }

    }
}
