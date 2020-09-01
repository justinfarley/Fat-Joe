using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBarrier : MonoBehaviour
{
    // Start is called before the first frame update
    public JoeStats joe;
    public CheckpointMaster cp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cp.lastCheckpointPos = joe.startOfLevel;
        }
    }
}
