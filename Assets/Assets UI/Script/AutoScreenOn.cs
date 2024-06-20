using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScreenOn : MonoBehaviour
{
    public GameObject nextScreen;
    public GameObject prevScreen;
    void Start()
    {
        nextScreen.SetActive(false);
        prevScreen.SetActive(true);
        Invoke("TurnOnScreen", 2.0f);
    }

    public void TurnOnScreen(){
        nextScreen.SetActive(true);
        prevScreen.SetActive(false);
    }

}
