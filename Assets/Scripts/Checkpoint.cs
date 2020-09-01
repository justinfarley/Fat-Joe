using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private CheckpointMaster cp;
    public JoeStats joe;
    public bool checkpointUsed = false;
    public bool inRangeOfTreadmill = false;
    public MainMenu mainMenu;
    void Start()
    { 
        cp = GameObject.FindGameObjectWithTag("cp").GetComponent<CheckpointMaster>();
    }


    void LateUpdate()
    {
        if (inRangeOfTreadmill == true && Input.GetKeyDown(KeyCode.E) && checkpointUsed == false)
        {

            if (joe.semifat == true)
            {
                
                mainMenu.SemiFatTreadmillStart();
                checkpointUsed = true;

            }
            else if (joe.halffat == true)
            {
                mainMenu.HalfFatTreadmillStart();
                checkpointUsed = true;

            }
            else if (joe.fat == true)
            {
                mainMenu.FatTreadmillStart();
                checkpointUsed = true;

            }
            else
            {
                //add "you cannot use this" set to active if none of the above
            }

        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inRangeOfTreadmill = true;
            cp.lastCheckpointPos = transform.position;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        inRangeOfTreadmill = false;
    }
}
