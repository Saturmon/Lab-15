using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ataque jugador") == true || collision.CompareTag("Destructor") == true)
        {
            Destroy(this.gameObject);
            Instantiate(explosion, transform.position,transform.rotation);
        }
    }
}
