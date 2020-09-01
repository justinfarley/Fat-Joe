using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Counter : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI text;
    public JoeStats joe;
    public GameObject check;
    public GameObject X;
    public int levelBurgerRequirement = 20;
    public int level;
    void Start()
    {
        level = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        switch (level)
        {
            case 1:
                levelBurgerRequirement = 30;
                break;
            case 2:
                levelBurgerRequirement = 30;
                break;
            case 3:
                levelBurgerRequirement = 40;
                break;
            default:
                levelBurgerRequirement = 20;
                break;

        }

        /*if(joe.amountOfCollected != levelBurgerRequirement)
        {
            X.SetActive(true);
            check.SetActive(false);
        }
        */
            text.SetText(joe.amountOfCollected.ToString() + " / " + levelBurgerRequirement);
        if(joe.amountOfCollected == levelBurgerRequirement)
        {
            X.SetActive(false);
            check.SetActive(true);
        }
        
    }
}
