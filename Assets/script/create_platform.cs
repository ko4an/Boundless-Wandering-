using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_platform : MonoBehaviour
{
    public Transform player;
    public GameObject prefab;

    private float last_height=0f;
    private float this_height;


    void OnCollisionEnter2D(Collision2D other)
    {
        this_height = Mathf.Floor(player.position.y);
        if (other.gameObject.tag == "type_start")
        {
            Create_Platform();
        }
        else if (other.gameObject.tag == "type_default")
        {
            Create_Platform();
        }
    }

    void Create_Platform()
    {
        this_height = Mathf.Floor(player.position.y);
        if (this_height>last_height-3)
        {
            for (float i = 0; i < 7; i=i+1f)
            {   
                Instantiate(prefab, new Vector3((Random.Range(-0.65f, 0.66f)), last_height + 7f, 0), Quaternion.identity);
                last_height = last_height + 1;
            }
        }
    }
}

