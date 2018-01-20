using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForFridgeChange : MonoBehaviour
{
    public GameObject fridgeOpen;
    public GameObject fridgeClose;
    public GameObject fridgeOpen_bkg;
    public GameObject fridgeClose_bkg;

    public void OnMouseDown()
    {
        fridgeClose.SetActive(!fridgeClose.activeSelf);
        fridgeOpen.SetActive(!fridgeOpen.activeSelf);
        if (fridgeOpen.activeSelf)
        {
            Debug.Log("generate food");
            FoodControl.FoodGenerate_kill_me_please();
        }
        fridgeClose_bkg.SetActive(!fridgeClose_bkg.activeSelf);
        fridgeOpen_bkg.SetActive(!fridgeOpen_bkg.activeSelf);
    }
}
