﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaturationBarController : MonoBehaviour {

    public Slider saturationBar;
    public Text score;

    private float maxValue = 100;
    public static float currValue;
    private int TOTAL_TIME = 6;
    private float coef_help = 0;
    private float delta = 0.00001f;

    // Use this for initialization
    void Start () {
        score.gameObject.SetActive(true);
        currValue = maxValue;
        saturationBar.value = currValue;
        GameProgress.isGameOn = true;
        coef_help = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (GameProgress.isGameOn)
        {
            GameProgress.CurrentScore += Time.deltaTime;
            score.text = "Score " + string.Format("{0:N2}", GameProgress.CurrentScore);
            if (currValue > 0)
            {
                BarUpdate();
            }
            else
            {
                GameProgress.isGameOn = false;
                score.gameObject.SetActive(false);
            }
        }
	}

    private void BarUpdate()
    {
        currValue -= ((Time.deltaTime + coef_help) * maxValue) / TOTAL_TIME;
        saturationBar.value = currValue;
        coef_help += delta;
    }
}