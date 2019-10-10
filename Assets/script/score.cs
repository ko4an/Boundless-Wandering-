using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text text;

    private float this_score;
    private float max_score;

    void Update()
    {
        this_score = Mathf.Round(player.position.y);
        out_score();
    }

    public float out_score()
    {
        if (this_score > max_score)
        {
            max_score = this_score;
            text.text = "Score : " + max_score;
        }
        return max_score;
    }
}
