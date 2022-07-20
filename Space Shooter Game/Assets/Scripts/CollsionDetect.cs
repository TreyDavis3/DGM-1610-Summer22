using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollsionDetect : MonoBehaviour
{
    public ScoreManger ScoreManger;

    public int scoreToGive;

    void Start()
    {
        scoreManger = GameObject.Find("ScoreManger").GetComponent<ScoreManger>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        scoreManger.IncreaseScore(scoreToGive);
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
