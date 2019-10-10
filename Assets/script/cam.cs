using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    float boostime = 10;
    public Transform who;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = who.position;
    }

    // Update is called once per frame
    void Update()
    {
        boostime = 10;
        position = who.position;
        position.z = -10f;
        position.x = 0f;
        transform.position = Vector3.Lerp(transform.position, position, boostime * Time.deltaTime);
    }
}
 

