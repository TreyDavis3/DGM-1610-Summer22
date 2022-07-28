using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchBehavoir : MonoBehaviour
{
   public ID idObj;
   
   private void OnTriggerEnter(Collider other)
   {
    Debug.Log(idObj);
   }
}
