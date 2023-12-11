using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public int velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y+velocidad*Time.deltaTime,0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pared") == true || collision.CompareTag("Enemy") == true)
        {          
            Destroy(this.gameObject);
        }
    }
}
