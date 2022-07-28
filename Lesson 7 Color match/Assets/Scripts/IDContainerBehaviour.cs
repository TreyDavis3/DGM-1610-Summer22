using UnityEngine;

public class IDContainerBehaviour : MonoBehaviour
{
   public ID idObj;
    public UnityEvent startEvent;

   public void Start()
   {
        startEvent.Invoke();
   }
}
