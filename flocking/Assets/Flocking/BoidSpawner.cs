using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoidSpawner : MonoBehaviour
{
    public BoidUnit boidUnit;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < WorldSettings.Instance.flockSize; i++)
        {
            float x = Random.Range(WorldSettings.Instance.GetMinPosition(Dimension.X),
                WorldSettings.Instance.GetMaxPosition(Dimension.X));

            float y = Random.Range(WorldSettings.Instance.GetMinPosition(Dimension.Y),
                WorldSettings.Instance.GetMaxPosition(Dimension.Y));

            float z = Random.Range(WorldSettings.Instance.GetMinPosition(Dimension.Z),
                WorldSettings.Instance.GetMaxPosition(Dimension.Z));

            Vector3 spawnPos = new Vector3(x, y, z);

            BoidUnit newBoid = Instantiate(boidUnit, spawnPos, boidUnit.transform.rotation);
            newBoid.transform.SetParent(transform);
            newBoid.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(0.1f, 1f), 0f,
                Random.Range(0.1f, 1f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
