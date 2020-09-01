using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[SerializeField]
public class BurgerFunctions : MonoBehaviour
    
{
    public float rotationsPerMinute = 20f;
    public bool collected;
    public Transform burger;
    public JoeStats joe;
    // Start is called before the first frame update
    void Awake()
    {

    }
    void Start()
    {

        
        
    }

    // Update is called once per frame
    void Update()
    {
        burger.Rotate(0, 6 * rotationsPerMinute * Time.deltaTime, 0);
    }

    public void SaveData()
    {

    }
}
