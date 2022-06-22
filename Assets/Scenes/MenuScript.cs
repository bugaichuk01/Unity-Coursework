using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public void StartScene()
    {
        Application.LoadLevel("SampleScene");

    }

    public void Quit()
    {

        Application.Quit();
    }
}