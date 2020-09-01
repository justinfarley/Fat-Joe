using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class text : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public JoeStats joe;
    public Image fill;

    // Start is called before the first frame update
    void Start()
    {
        text1.color = Color.white;
        text1.SetText("WEIGHT -   " + joe.weight);
    }

    // Update is called once per frame
    void Update()
    {
        if(joe.weight >= 1)
        {
        text1.color = fill.color;
        }
        text1.SetText("WEIGHT -   " + joe.weight);
    }
}
