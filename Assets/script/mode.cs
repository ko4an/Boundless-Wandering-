using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mode : MonoBehaviour
{
    public Transform hero;
    float current_mode_time;
    void Update()
    {
        current_mode_time = 0.5f + hero.position.y/1000;
        Time.timeScale = current_mode_time;
    }
}
