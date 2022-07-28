using UnityEngine;

[CreateAssetMenu]
public class InData : ScriptableObject
{
    public int value;
    

    public void SetValue(int num)
    {
        value = num;
    }

    public void CompareValue(InData obj)
    {
        if(value >= obj.value)
        {

        }
        else
        {
            value = obj.value;
        }
    }

    public void SetValue(InData obj)
    {
        value = obj.value;
    }

    public void UpdateValue(int num)
    {
        value += num;
    }
}
