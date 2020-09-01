using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public JoeStats joe;
    public CheckpointMaster cp;
    public Animator animator;
    public GameObject deathScreen;
    public void ReturnToMainMenu()
    {

        SceneManager.LoadScene(0);
        FindObjectOfType<AudioManager>().Play("FatJoeMainTheme");
        FindObjectOfType<AudioManager>().ChangePitch("FatJoeMainTheme", 1f);
    }
    public void LoadCurrentLevel()
    {
        StartCoroutine(LoadCurrent());
    }
    public void GetStartPos()
    {
        joe.startOfLevel = cp.lastCheckpointPos;
    }
    IEnumerator LoadCurrent()
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        FindObjectOfType<AudioManager>().Play("FatJoeMainTheme");
        FindObjectOfType<AudioManager>().ChangePitch("FatJoeMainTheme", 1f);
        deathScreen.SetActive(false);
    }

}
