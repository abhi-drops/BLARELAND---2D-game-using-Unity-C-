using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
 
public class ButtonLongPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    [SerializeField]
    [Tooltip("How long must pointer be down on this object to trigger a long press")]
    private float holdTime = 1f;
 
    // Remove all comment tags (except this one) to handle the onClick event!
    //private bool held = false;
    //public UnityEvent onClick = new UnityEvent();
 
    public UnityEvent onLongPress = new UnityEvent();
 
    public void OnPointerDown(PointerEventData eventData)
    {
        //held = false;
        Invoke("OnLongPress", holdTime);
    }
 
    public void OnPointerUp(PointerEventData eventData)
    {
        CancelInvoke("OnLongPress");
 
        //if (!held)
        //    onClick.Invoke();
    }
 
    public void OnPointerExit(PointerEventData eventData)
    {
        CancelInvoke("OnLongPress");
    }
 
    private void OnLongPress()
    {
        //held = true;
        onLongPress.Invoke();
    }
}