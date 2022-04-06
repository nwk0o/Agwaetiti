using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomIsland : MonoBehaviour
{
    public List<GameObject> GoSpawn = new List<GameObject>();

    void Start()
    {
        GameObject goToSpawn = GoSpawn[Random.Range(0, GoSpawn.Count)];
        Instantiate(goToSpawn, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
