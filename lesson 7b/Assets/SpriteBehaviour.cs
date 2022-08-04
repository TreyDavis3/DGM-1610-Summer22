using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBehaviour : MonoBehaviour
{
    priavte SpriteRenderer rendererObj;

    priavte void Awake()
    {
        rendererObj = GetComponet<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }

    pulblic void ChangeRendererColor(colorIDList obj)
    {
        rendererObj.color = obj.currentColor.value;
    }
}
