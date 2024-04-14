using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [Header("Spawn Asteroid Objects")]
    public GameObject[] spawnAsteroids;

    [Header("Default Difficulty")]
    public float difficulty = 40f;

    float spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.z);
        if (transform.position.z>2500 && transform.position.z<7500)
        {
            spawn = difficulty * Time.deltaTime;

            difficulty = Time.deltaTime * 4f;

            while (spawn > 0)
            {
                spawn -= 1;

                Vector3 v3Pos = transform.position + new Vector3(Random.value * 80f - 40f, -40, Random.value * 80f - 40f);

                Quaternion qRotation = Quaternion.Euler(0, Random.value * 360f, Random.value * 30f);

                GameObject createObject = Instantiate(spawnAsteroids[Random.Range(0, 3)], v3Pos, qRotation);
            }
        }
    }
}
