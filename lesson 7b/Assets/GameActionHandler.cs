using UnityEngine;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent onRaiseEvent;

    private void Start()
    {
        gameActionObj.raise += Rasie;
    }


    private void Raise()
    {
        onRaiseEvent.Invoke();
    }
}
