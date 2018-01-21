using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuntimeData : MonoBehaviour {

    public static float GAME_TIME;

	// Use this for initialization
	void Start () {
        GAME_TIME = 0;
	}
	
	// Update is called once per frame
	void Update () {
        GAME_TIME += Time.deltaTime;

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
