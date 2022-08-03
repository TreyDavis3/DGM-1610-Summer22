using UnityEngine;

[CreateAssetMenu]
public class Instencer : ScriptableObject
{
    
    public GameObject prefab;
    private int num;
    
    pulblic void createInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
    Instantiate(prefab, t.value, Quaternion.identity);
    }

    
    
    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
        if(num = 0)
        num++;
        if(num == obj.vector3DList.Count)
        {
            num = 0;
        }
    }

     public void CreateInstanceListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3DList.Count - 1);
        Instantiate(prefab, obj.vector3DList[num].value, Quaternion.identity);
    }

}
