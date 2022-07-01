using UnityEngine;
using UnityEngine.UI

public class IntData : ScriptableObject
{
    public int health;

    public void AddHealth(int num);
    {
        health += num;
    } 

    public void SubHealth(int num);
    {
        health -= num;
    }

    public void ChangeHealth(int player);
    {
        health = player;

        switch 
        {
            case player:
            playerOne >= playerTwo;
            WriteLine ("Player one has switched health with Player two");
            break;
        }
    }
}
