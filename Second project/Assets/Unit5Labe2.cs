using UnityEngine;
using UnityEngine.Events

public class Unit5Labe2 : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEvent(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
