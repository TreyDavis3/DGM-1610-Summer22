using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour
{
   void Start ()
   {
       //This is a dope comment 
       /*I
       *can
       *do
       *comments
       **/
       Debug.Log(transform.position.x);

       if(transform.position.y < = 5f)
       {
           Debug.Log ("I'm about to hit the ground");
       }
   }
}
