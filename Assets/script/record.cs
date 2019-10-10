using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class record : MonoBehaviour
{
    public Text text;

    void Start()
    {
        if(PlayerPrefs.GetFloat("score") != 0)
        {
            text.text = "Record : " + PlayerPrefs.GetFloat("score");
        }
        else
        {
            text.text = " ";
        }
    }
}
