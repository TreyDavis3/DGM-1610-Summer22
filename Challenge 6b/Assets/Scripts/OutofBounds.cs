using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    public float toBounds = 30.0f;

    public float lowerBounds = -10.0f;


   void Awake()
   {
    Time.timeScale = 1;
   }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > toBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Debug.log("Game Over");
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
