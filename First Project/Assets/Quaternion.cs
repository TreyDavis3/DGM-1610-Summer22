using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quaternion : MonoBehaviour
{
    var rot = transform.rotation;
    rot.x += Time.deltaTime * 10;
    transform.rotation = rot;
}

void Update () 
{
    var angles = transform.rotation.eulerAngles;
    angles.x += Time.deltaTime * 10;
    transform.rotation = Quaternion.Euler(angles);
}

float x;
void Update () 
{
    x += Time.deltaTime * 10;
    transform.rotation = Quaternion.Euler(x,0,0);
}