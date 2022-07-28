using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(text))]
public class TextLabelBehaviour : MonoBehaviour
{
    private Text label;
    public UnityEvent startEvent

    private void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(InData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
}
