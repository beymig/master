using UnityEngine;
using System.Collections;

public class SpawnMisille : MonoBehaviour {

    public Transform[] misilleSpawns;
    public GameObject misille;

    // Use this for initialization
    void Start()
    {

        Spawn();
    }

    void Spawn()
    {
        for (int i = 0; i < misilleSpawns.Length; i++)
        {
            int misilleFlip = Random.Range(0, 10);
            if (misilleFlip > 0)
                Instantiate(misille, misilleSpawns[i].position, Quaternion.identity);
        }
    }
}
