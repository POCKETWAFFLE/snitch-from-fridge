using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgress : MonoBehaviour
{
    public static bool isGameOn;

    public static float BestScore;
    public static float CurrentScore;

    void Start()
    {
        BestScore = PlayerPrefs.GetFloat("BestScore", 0);
        CurrentScore = 0;
    }

    void Update()
    {
        if (CurrentScore > BestScore)
        {
            BestScore = CurrentScore;
            PlayerPrefs.SetFloat("BestScore", BestScore);
        }
    }
}
