using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenBurgerSpin : MonoBehaviour

{

    public float rotationsPerMinute = 20f;
    public Transform burger;
    public bool allow = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (allow == true)
        {
            StartCoroutine(increaseSlowly());
        }

        burger.Rotate(0, 6 * rotationsPerMinute * Time.deltaTime, 0);


    }

    IEnumerator increaseSlowly()
    {
        allow = false;
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute++;
        rotationsPerMinute++;
        yield return new WaitForSeconds(0.1f);
        yield return new WaitForSeconds(1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        yield return new WaitForSeconds(0.1f);
        rotationsPerMinute--;
        rotationsPerMinute--;
        allow = true;

    }

}
