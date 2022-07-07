using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    public Stopwatch sw;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            sw.StartStopwatch();
        }

    }

}
