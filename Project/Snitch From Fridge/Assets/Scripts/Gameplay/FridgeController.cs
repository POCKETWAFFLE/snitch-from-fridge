using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FridgeController : MonoBehaviour {

    public GameObject fridgeOpen;
    public GameObject fridgeClose;
    public GameObject fridgeOpen_bkg;
    public GameObject fridgeClose_bkg;

    // Use this for initialization
    void Start () {
        fridgeClose.SetActive(true);
        fridgeOpen.SetActive(false);
        fridgeClose_bkg.SetActive(true);
        fridgeOpen_bkg.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (GameProgress.isGameOn)
        {
            //if (Input.GetMouseButtonUp(0))
            {
               // fridgeClose.SetActive(!fridgeClose.activeSelf);
               // fridgeOpen.SetActive(!fridgeOpen.activeSelf);
                //fridgeClose_bkg.SetActive(!fridgeClose_bkg.activeSelf);
                //fridgeOpen_bkg.SetActive(!fridgeOpen_bkg.activeSelf);
            }
        }
        else
        {
            fridgeClose.SetActive(true);
            fridgeOpen.SetActive(false);
            fridgeClose_bkg.SetActive(true);
            fridgeOpen_bkg.SetActive(false);
        }
    }
}
