using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCon2 : MonoBehaviour {

    public GameObject imageMenu;
    public GameObject ButtonPause;

    public void OnPause()
    {
        
        imageMenu.SetActive(true);
        ButtonPause.SetActive(false);
    }
}
    