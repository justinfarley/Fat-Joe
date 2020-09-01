using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private static CameraFollow Instance;

    public CheckpointMaster cp;

    public Transform target;

    public float smoothSpeed = 0.125f;

    public Vector3 offset;

    public JoeStats joe;

    public Transform semiFatCanvas;

    public MainMenu mainMenu;

    void Start()
    {
        cp = GameObject.FindGameObjectWithTag("cp").GetComponent<CheckpointMaster>();
        transform.position = cp.lastCheckpointPos;
    }
    private void FixedUpdate()
    {


        if (joe.inRangeOfTreadmill && Input.GetKeyDown(KeyCode.E))
        {
            target = semiFatCanvas;
            StartCoroutine(wait5Seconds());
            target = joe.transform;
        }
        //add other fat types
            if (target == null)
            {
                return;
            }
            else if(!mainMenu.stopCamFollow)
            {

                Vector3 desiredPosition = target.position + offset;
                Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
                transform.position = smoothPosition;
                //transform.LookAt(target);
            }

    }
    IEnumerator wait5Seconds()
    {
        yield return new WaitForSeconds(5f);
    }
}





