using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject levelCompleteUI;

    public void CompleteLevel(){
        levelCompleteUI.SetActive(true);
    }

}
