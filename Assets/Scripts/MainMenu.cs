using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject joe;
    public GameObject popupWindow;
    public JoeStats joeStats;
    public Animator animator;
    public float TransitionTime = 1f;
    public bool stopCamFollow = false;
    public WeightBar weightbar;

    
    
    public void PlayGame()
    {
        StartCoroutine(StartGame());
    }
    public void loadScene(int s)
    {
        StartCoroutine(LoadScene(s));
    }
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
        
    }
    public void SemiFatTreadmillStart()
    {
        StartCoroutine(SemiFatTreadmill());
    }
    public void HalfFatTreadmillStart()
    {
        StartCoroutine(HalfFatTreadmill());
    }
    public void FatTreadmillStart()
    {
        StartCoroutine(FatTreadmill());
    }
    IEnumerator SemiFatTreadmill()
    {
        stopCamFollow = true;
        animator.SetTrigger("Start");
        joeStats.eToUse.SetActive(false);
        yield return new WaitForSeconds(TransitionTime);
        mainCamera.orthographicSize = 0.5f;
        mainCamera.transform.position = new Vector3(-50.783f, 17.223f, 0f);
        animator.SetTrigger("End");
        yield return new WaitForSeconds(3f);
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(TransitionTime);
        joeStats.weight -= 50;
        mainCamera.orthographicSize = 1.1f;
        weightbar.SetWeight(joeStats.weight);
        weightbar.fill.color = weightbar.gradient.Evaluate(weightbar.slider.normalizedValue);
        stopCamFollow = false;
        mainCamera.transform.position = joe.transform.position;
        animator.SetTrigger("End");
    }
    IEnumerator HalfFatTreadmill()
    {
        stopCamFollow = true;
        animator.SetTrigger("Start");
        joeStats.eToUse.SetActive(false);
        yield return new WaitForSeconds(TransitionTime);
        mainCamera.orthographicSize = 0.5f;
        mainCamera.transform.position = new Vector3(-47.83f, 17.223f, 0f);
        animator.SetTrigger("End");
        yield return new WaitForSeconds(3f);
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(TransitionTime);
        joeStats.weight -= 100;
        mainCamera.orthographicSize = 1.1f;
        weightbar.SetWeight(joeStats.weight);
        weightbar.fill.color = weightbar.gradient.Evaluate(weightbar.slider.normalizedValue);
        stopCamFollow = false;
        mainCamera.transform.position = joe.transform.position;
        animator.SetTrigger("End");
    }
    IEnumerator FatTreadmill()
    {
        stopCamFollow = true;
        animator.SetTrigger("Start");
        joeStats.eToUse.SetActive(false);
        yield return new WaitForSeconds(TransitionTime);
        mainCamera.orthographicSize = 0.5f;
        mainCamera.transform.position = new Vector3(-44.949f, 17.223f, 0f);
        animator.SetTrigger("End");
        yield return new WaitForSeconds(3f);
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(TransitionTime);
        joeStats.weight -= 150;
        mainCamera.orthographicSize = 1.1f;
        weightbar.SetWeight(joeStats.weight);
        weightbar.fill.color = weightbar.gradient.Evaluate(weightbar.slider.normalizedValue);
        stopCamFollow = false;
        mainCamera.transform.position = joe.transform.position;
        animator.SetTrigger("End");
    }


    IEnumerator LoadScene (int LevelIndex)
    {
        yield return new WaitForSeconds(3f);
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(TransitionTime);
        SceneManager.LoadScene(LevelIndex);

    }
    IEnumerator StartGame()
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(TransitionTime);
        SceneManager.LoadScene(1);
    }
}
