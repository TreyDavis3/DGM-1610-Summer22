using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OntriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
