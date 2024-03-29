using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerLv2 : MonoBehaviour
{
    //variables 
    [SerializeField] private float speed = 10f;
    private float xRange = 15f;
    [SerializeField] private GameObject FoodPrefab;
    private float horizontalImput;

    //funciones

    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;

        if (pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }
        if (pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }

    }

    private void ShootFood()
    {
        Instantiate(FoodPrefab, transform.position + new Vector3(1,0,0), Quaternion.Euler(0, 30, 0));
        Instantiate(FoodPrefab, transform.position + new Vector3(-1, 0, 0), Quaternion.Euler(0, -30, 0));

    }

    //update_start

    private void Update()
    {
        horizontalImput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalImput);

        PlayerInBounds();
        //disparar

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootFood();
        }
    }
    private void Start()
    {
        Time.timeScale = 1;
    }
}
