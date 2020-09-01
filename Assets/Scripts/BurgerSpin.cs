using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerSpin : MonoBehaviour
    
{
    
    public float rotationsPerMinute = 20f;
    public Transform burger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        burger.Rotate(0, 6 * rotationsPerMinute * Time.deltaTime, 0);

        
    }
    

}
