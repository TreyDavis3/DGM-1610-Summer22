
using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchtEvent, noMatchEvent, noMatchDelayedEvent;
   
   private IEnumerator OnTriggerEnter(Collider other)
   {
    var tempObj = other.GetComponent<IDContainerBehaviour>();
    if(tempObj == null)
        yield break;

    var otherID = tempObj.idObj;
    if(otherID == idObj)
    {
        matchtEvent.Invoke();
    }
    else
    {
        noMatchEvent.Invoke();
        yield return new WaitForSeconds(0.5f);
        noMatchDelayedEvent.Invoke();
    }
   }
}

