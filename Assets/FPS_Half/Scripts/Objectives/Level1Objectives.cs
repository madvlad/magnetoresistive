using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Objectives : MonoBehaviour {
    public int KillCount = 0;
    public int Target;

	void Progress()
    {
        KillCount++;

        if (KillCount >= Target)
        {
            Win();
        }
        else
        {
            Debug.Log(Target - KillCount + " Enemies Left");
        }
    }

    void Win()
    {
        Debug.Log("You win");
    }
}
