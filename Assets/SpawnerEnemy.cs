using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    public GameObject enemigo;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("CreateEnemy",4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateEnemy()
    {
        print("Hola");
        Invoke("CreateEnemy", 4);
        Instantiate(enemigo, transform.position, transform.rotation);
    }
}
