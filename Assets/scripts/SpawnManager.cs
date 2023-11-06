using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class SpawnManager : MonoBehaviour
{

    //variables


    [SerializeField] private GameObject[] animalsPrefabsArray;
    private int animalIndex;
    private float spawnRangex = 15f;
    private float spawnPosZ = 20f;
    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;




    

    //funciones

     private void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, animalsPrefabsArray.Length);
        
        Instantiate(animalsPrefabsArray[animalIndex], RandomSpawnPos(), Quaternion.Euler(0, 180, 0));

       
    }

    private Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-spawnRangex, spawnRangex);

        return new Vector3(randomX, 0, spawnPosZ);

        
            
    }


    //start/update



    private void Start()
    {

        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); 

    }




}
