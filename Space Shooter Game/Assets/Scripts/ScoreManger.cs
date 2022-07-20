using System.Collections;
using System.Collections.Generic;
using UnityEngine;
usingTMPro:

public class ScoreManger : MonoBehaviour
{
   public int score;

   public TextMeshPrioUGUI scoreText;

   public void IncreaseScore(int amount)
   {
    score += amount;
    UpdateScoreText();
   }

   public void DecreaseScore(int amount)
   {
    score -= amount;
    UpdateScoreText();
   }

   public void UpdateScoreText()
   {
    scoreText.text = "Score: "+ score;
   }
}
