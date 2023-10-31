using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //variables

    [SerializeField] private float FoodSpeed;


    //funciones



    // start_update

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * FoodSpeed);
    }


}
