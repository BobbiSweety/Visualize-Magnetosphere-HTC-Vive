using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCon : MonoBehaviour
{

    //the ButtonPauseMenu
    public GameObject imageMenu;
    public GameObject ButtonPause;

    public void OnPause()//点击“暂停”时执行此方法
    {
        Time.timeScale = 0;
        imageMenu.SetActive(true);
        ButtonPause.SetActive(false);
    }

    public void OnResume()//点击“回到游戏”时执行此方法
    {
        Time.timeScale = 0.01f;
        imageMenu.SetActive(false);
        ButtonPause.SetActive(true);
    }

    public void OnRestart()//点击“重新开始”时执行此方法
    {
        Time.timeScale = 0.01f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        
    }

    public void CustOnRestart()//点击“重新开始”时执行此方法
    {
        Time.timeScale = 0.01f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);

    }

    public void NormalSpeed()
    {
        Time.timeScale = 0.01f;
    }

    public void SlowSpeed()
    {
        Time.timeScale = 0.002f;
      
    }

    public void FastSpeed()
    {
        Time.timeScale = 0.05f;
        
    }
}
