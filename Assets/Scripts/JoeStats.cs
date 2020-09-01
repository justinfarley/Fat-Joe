using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JoeStats : MonoBehaviour
{
    public static JoeStats Instance;
    public int weight = 0;
    public int amountOfCalories;
    public int min = 7;
    public int max = 13;
    public int maxWeight = 200;
    public WeightBar weightbar;
    public Animator animator;
    public bool semifat = false;
    public bool halffat = false;
    public bool fat = false;
    public bool inRangeOfTreadmill = false;
    public PlayerMovement player;
    public GameObject deathScreen;
    public GameObject eToUse;
    public MainMenu mainMenu;
    public Vector2 startOfLevel;
    public float TransitionTime = 1f;
    private CheckpointMaster cp;
    public GameObject playerStart;
    public GameObject easterEgg1;
    public GameObject easterEgg2;
    public GameObject weightHere;
    public GameObject theMoreYouEat;
    public BurgerFunctions burger;
    public bool dead = false;
    public bool collected;
    public int burgerCount;
    public bool collectBurger = false;
    public GameObject martina;
    public int amountOfCollected = 0;
    // Start is called before the first frame update

    void Start()
    {
        weight = 0;
        cp = GameObject.FindGameObjectWithTag("cp").GetComponent<CheckpointMaster>();
        weightbar.SetMaxWeight();
        weightbar.SetWeight(0);
        weightbar.fill.color = weightbar.gradient.Evaluate(0f);
            
    }
    void Update()
    {
        if(weight < 0)
        {
            weight = 0;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
            
        
        if(weight < 50)
        {
            animator.SetBool("semifat", false);
            animator.SetBool("halfFat", false);
            animator.SetBool("fat", false);
            semifat = false;
            halffat = false;
            fat = false;
            player.speed = 0.6f;
            player.maxSpeed = 0.6f;
            player.jumpStrength = 5f;
            FindObjectOfType<AudioManager>().ChangePitch("FatJoeMainTheme", 1f);
        }
        if (weight >= 50 && weight <= 100)
        {
            animator.SetBool("semifat", true);
            animator.SetBool("halfFat", false);
            animator.SetBool("fat", false);
            semifat = true;
            halffat = false;
            fat = false;
            player.speed = 0.5f;
            player.maxSpeed = 0.5f;
            player.jumpStrength = 4f;
            FindObjectOfType<AudioManager>().ChangePitch("FatJoeMainTheme", 0.85f);
        }
        if(weight > 100 && weight <= 150)
        {
            fat = false;
            semifat = false;
            animator.SetBool("semifat", false);
            animator.SetBool("halfFat", true);
            animator.SetBool("fat", false);
            halffat = true;
            player.speed = 0.4f;
            player.maxSpeed = 0.4f;
            player.jumpStrength = 3.5f;
            FindObjectOfType<AudioManager>().ChangePitch("FatJoeMainTheme", 0.7f);
        }
        if(weight > 150 && weight <= 200)
        {
            halffat = false;
            fat = true;
            semifat = false;
            animator.SetBool("semifat", false);
            animator.SetBool("halfFat", false);
            animator.SetBool("Fat", true);
            player.speed = 0.3f;
            player.maxSpeed = 0.3f;
            player.jumpStrength = 3f;
            FindObjectOfType<AudioManager>().ChangePitch("FatJoeMainTheme", 0.4f);

        }
        if(weight >= 200)
        {
            player.speed = 0f;
            player.maxSpeed = 0f;
            player.jumpStrength = 0f;
            StartCoroutine(passOut());
            
        }
        if (animator.GetBool("semifat") == true && Input.GetAxisRaw("Horizontal") == 0f)
        {
            //joe semi fat idle anim
            animator.SetBool("semifatIdle", true);
            animator.SetBool("semifatRunningRight", false);
            animator.SetBool("semifatRunningLeft", false);
        }
        else if (animator.GetBool("semifat") == true && Input.GetAxisRaw("Horizontal") > 0f)
        {
            //joe semi fat run right anim
            animator.SetBool("semifatRunningRight", true);
            animator.SetBool("semifatIdle", false);
            animator.SetBool("semifatRunningLeft", false);
        }
        else if (animator.GetBool("semifat") == true && Input.GetAxisRaw("Horizontal") < 0f)
        {
            //joe semi fat run left anim
            animator.SetBool("semifatRunningLeft", true);
            animator.SetBool("semifatRunningRight", false);
            animator.SetBool("semifatIdle", false);
        }
        if (animator.GetBool("halfFat") == true && Input.GetAxisRaw("Horizontal") == 0f)
        {
            animator.SetBool("halfFatIdle", true);
            animator.SetBool("halfFatRunningRight", false);
            animator.SetBool("halfFatRunningLeft", false);
        }
        else if (animator.GetBool("halfFat") == true && Input.GetAxisRaw("Horizontal") > 0f)
        {
            animator.SetBool("halfFatRunningRight", true);
            animator.SetBool("halfFatIdle", false);
            animator.SetBool("halfFatRunningLeft", false);
        }
        else if (animator.GetBool("halfFat") == true && Input.GetAxisRaw("Horizontal") < 0f)
        {
            animator.SetBool("halfFatRunningLeft", true);
            animator.SetBool("halfFatRunningRight", false);
            animator.SetBool("halfFatIdle", false);
        }
        if (animator.GetBool("Fat") == true && Input.GetAxisRaw("Horizontal") == 0f)
        {
            animator.SetBool("FatIdle", true);
            animator.SetBool("FatRunningRight", false);
            animator.SetBool("FatRunningLeft", false);
        }
        else if (animator.GetBool("Fat") == true && Input.GetAxisRaw("Horizontal") > 0f)
        {
            animator.SetBool("FatRunningRight", true);
            animator.SetBool("FatIdle", false);
            animator.SetBool("FatRunningLeft", false);
        }
        else if (animator.GetBool("Fat") == true && Input.GetAxisRaw("Horizontal") < 0f)
        {
            animator.SetBool("FatRunningLeft", true);
            animator.SetBool("FatRunningRight", false);
            animator.SetBool("FatIdle", false);
        }

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Burger")
        {
            FindObjectOfType<AudioManager>().Play("BurgerEatenSound");
            amountOfCalories = Random.Range(min, max);
            amountOfCollected += 1;
            gainWeight(amountOfCalories);
            weightbar.SetWeight(weight);
            burger.SaveData();
        
            
        }

        if(other.gameObject.tag == "DeathBarrier")
        {
            cp.lastCheckpointPos = startOfLevel;
            FindObjectOfType<AudioManager>().Play("DeathSound");
            FindObjectOfType<AudioManager>().Stop("FatJoeMainTheme");
            dead = true;
            deathScreen.SetActive(true);
            gameObject.SetActive(false);
            
        }

        if(other.gameObject.tag == "GoldenBurger")
        {
            FindObjectOfType<AudioManager>().Play("GoldenBurger");
            amountOfCollected += 5;
            weight -= 10;
        }

        if(other.gameObject.tag == "Treadmill" && weight >= 50)
        {
            eToUse.SetActive(true);
            inRangeOfTreadmill = true;
        }
        if(other.gameObject.tag == "playerStart")
        {
            startOfLevel = transform.position;
            
        }
        if(other.gameObject.tag == "startHolder")
        {
            startOfLevel = playerStart.transform.position;
        }
        if(other.gameObject.tag == "EasterEgg1")
        {
            easterEgg1.SetActive(true);
        }
        if(other.gameObject.tag == "EasterEgg2")
        {
            martina.SetActive(true);
            easterEgg2.SetActive(true);
            StartCoroutine(KillInFive());
        }
        if (other.gameObject.name == "WeightDisplayedHereTrigger")
        {
            weightHere.SetActive(true);
        }
        if(other.gameObject.name == "WeightDisplayedHereTrigger2")
        {
            theMoreYouEat.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Treadmill")
        {
            eToUse.SetActive(false);
            inRangeOfTreadmill = false;
            
        }
        if(other.gameObject.tag == "EasterEgg1")
        {
            easterEgg1.SetActive(false);
        }
        if(other.gameObject.tag == "EasterEgg2")
        {
            martina.SetActive(false);
            easterEgg2.SetActive(false);
        }
        if (other.gameObject.name == "WeightDisplayedHereTrigger")
        {
            weightHere.SetActive(false);
        }
        if (other.gameObject.name == "WeightDisplayedHereTrigger2")
        {
            theMoreYouEat.SetActive(false);
        }
    }

    void gainWeight(int calories)
    {
        weight += calories;
        weightbar.SetWeight(weight);
        weightbar.fill.color = weightbar.gradient.Evaluate(weightbar.slider.normalizedValue);
        Debug.Log(weight);
        
    }

    IEnumerator passOut()
    {
        animator.SetBool("AboutToPassOut", true);
        yield return new WaitForSeconds(1.5f);
        animator.SetBool("PassingOut", true);
        yield return new WaitForSeconds(3f);
        FindObjectOfType<AudioManager>().Play("DeathSound");
        FindObjectOfType<AudioManager>().Stop("FatJoeMainTheme");
        yield return new WaitForSeconds(0.15f);
        dead = true;
        gameObject.SetActive(false);
        deathScreen.SetActive(true);
        FindObjectOfType<AudioManager>().ChangePitch("FatJoeMainTheme", 1f);
        cp.lastCheckpointPos = startOfLevel;

    }
    IEnumerator KillInFive()
    {
        yield return new WaitForSeconds(5f);
        FindObjectOfType<AudioManager>().Play("DeathSound");
        FindObjectOfType<AudioManager>().Stop("FatJoeMainTheme");
        yield return new WaitForSeconds(0.15f);
        dead = true;
        gameObject.SetActive(false);
        deathScreen.SetActive(true);
    }



}
