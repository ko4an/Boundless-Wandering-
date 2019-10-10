using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_platform : MonoBehaviour
{
        void OnBecameInvisible()
        {
            Destroy(this.gameObject, 3);
        }
}
