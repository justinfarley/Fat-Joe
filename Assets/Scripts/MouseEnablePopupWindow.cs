using UnityEngine;
using UnityEngine.EventSystems;

public class MouseEnablePopupWindow : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject obj;



    private void Start()
    {
        obj.SetActive(false);
    }

    void Update()
    {
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        FindObjectOfType<AudioManager>().Play("blip select");
        obj.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        obj.SetActive(false);
    }

}
