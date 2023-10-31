using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFood : MonoBehaviour
{
    [SerializeField] private float toopBound = 30f;
    [SerializeField] private float botoomBound = -10f;

    private void Update()
    {
        if (transform.position.z > toopBound) 
        {
            Destroy(gameObject);
        }

        if (transform.position.z < botoomBound) 
        {
            Destroy(gameObject);
        }
    }
}
