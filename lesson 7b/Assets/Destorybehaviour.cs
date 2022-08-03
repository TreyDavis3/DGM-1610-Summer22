using System.Collections;
using UnityEngine;

public class Destorybehaviour : MonoBehaviour
{
    
    public float seconds = 1;
    private WaitForSeconds wfsObj;

    priavte IEnumerator Start()
    {
        wfsObj = ne WaitForSeconds(seconds);
        yield return wfsObj;
        destroy(gameObject);
    }
}
