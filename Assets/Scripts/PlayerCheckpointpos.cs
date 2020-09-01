using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckpointpos : MonoBehaviour
{
    private CheckpointMaster cp;
    // Start is called before the first frame update
    void Start()
    {
        cp = GameObject.FindGameObjectWithTag("cp").GetComponent<CheckpointMaster>();
        transform.position = cp.lastCheckpointPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
