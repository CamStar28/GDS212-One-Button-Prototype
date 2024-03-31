using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileSpawner : MonoBehaviour
{
    public int SpawnPosition;
    public bool CanSpawn;
    private List<int> SpawnTimeList = new List<int>() { 59, 57, 55, 54, 52, 50, 48, 48, 47, 46, 45, 43, 42, 42, 40, 37, 37, 36, 36, 35, 35, 34, 33, 32, 30, 28, 27, 25, 24, 24, 22, 20, 20, 19, 19, 18, 17, 17, 16, 14, 14, 12, 12, 10, 9, 8, 7, 6, 5, 4, 3, 2, 2, 2 };
    public int currentSpawnTimeIndex = 0;
    public GameObject projectilePrefab;
    public float TimeRemaining;
    //all of these values are used for the spawning of projectiles, with the list telling the system when to spawn them relative to a counting down timer 

    // Start is called before the first frame update
    void Start()
    {
        TimeRemaining = 60; //normalises the timer when the scene loads or is reloaded 
    }

    // Update is called once per frame
    void Update()
    {
        TimeRemaining -= Time.deltaTime; //counts down the timer 


        if ((int)TimeRemaining == SpawnTimeList[currentSpawnTimeIndex] && CanSpawn == true) //this if statement rounds the value of time remaining matches the next value in the spawn list
        {
            SpawnProjectile();
            CanSpawn = false; //turning off this value prevents a projectile spawning every frame 
            currentSpawnTimeIndex++; //progresses to the next value in the list 
        }

        if (currentSpawnTimeIndex >= SpawnTimeList.Count) //failsafe for reaching the end of the list 
        {
            currentSpawnTimeIndex = 0;
        }

        if ((int)TimeRemaining == SpawnTimeList[currentSpawnTimeIndex] && CanSpawn == false) //allows projectiles to be spawned again, works in a way to prevent projectiles spawning every frame 
        {
            CanSpawn = true;
        }
    }

    void SpawnProjectile() //generates a random value, then spawns the prefab projectile into a random trigger (which decides their movement) based on said value 
    {
        SpawnPosition = Random.Range(1, 9);

        if (SpawnPosition == 1)
        {
            Instantiate(projectilePrefab, new Vector3(-0.07f, 1.22f, 6.35f), Quaternion.identity); //top
        }

        if (SpawnPosition == 2)
        {
            Instantiate(projectilePrefab, new Vector3(-1.6f, 1.22f, -6.4f), Quaternion.identity); //bottom
        }

        if (SpawnPosition == 3)
        {
            Instantiate(projectilePrefab, new Vector3(-10.5f, 1.22f, -1.05f), Quaternion.identity); //left
        }

        if (SpawnPosition == 4)
        {
            Instantiate(projectilePrefab, new Vector3(10, 1.22f, 0.04f), Quaternion.identity); //right
        }

        if (SpawnPosition == 5)
        {
            Instantiate(projectilePrefab, new Vector3(5.7f, 1.22f, 5.6f), Quaternion.identity); //top right
        }

        if (SpawnPosition == 6)
        {
            Instantiate(projectilePrefab, new Vector3(6.7f, 1.22f, -6.3f), Quaternion.identity); //bottom right
        }

        if (SpawnPosition == 7)
        {
            Instantiate(projectilePrefab, new Vector3(-8.45f, 1.22f, 5.6f), Quaternion.identity); //top left
        }

        if (SpawnPosition == 8)
        {
            Instantiate(projectilePrefab, new Vector3(-6.2f, 1.22f, -8), Quaternion.identity); //bottom left
        }
    }
}
