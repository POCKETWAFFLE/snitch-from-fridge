using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseCaseController : MonoBehaviour {

    public GameObject losePanel;
    public Text currentScore;
    public Text bestScore;

    // Use this for initialization
    void Start () {
        losePanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameProgress.isGameOn)
        {
            losePanel.SetActive(true);
            currentScore.text = "Current score: " + string.Format("{0:N2}", GameProgress.CurrentScore);
            bestScore.text = "Best score: " + string.Format("{0:N2}", GameProgress.BestScore);
        }
	}

    public void OnRetry()
    {
        Application.LoadLevel("main");
    }
}
