using UnityEngine;
using UnityEngine.Events;

public class Unit5Lab : MonoBehaviour
{
    public UnityEngine startEvents, awakeEvents, disableEvents;

    private void Awake()
    {
        awakeEvents.Invoke();
    }

    private void Start()
    {
        startEvents.Invoke();
    }

    private void OnDisable()
    {
        disableEvents.Invoke();
    }
}
