using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Burger")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "GoldenBurger")
        {
            Destroy(other.gameObject);
        }
        
    }

}
