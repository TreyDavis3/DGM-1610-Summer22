using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;

    public ColorId currentColor;

    priavte in num;

    public void SetCurrentColorRandomly()
    {
        num=colorIDList.Count-1;
        currentColor = colorIDList[num];
    }
}
