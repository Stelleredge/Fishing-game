using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Main : MonoBehaviour
{
    public void Exitbutton()
    {
        Application.Quit();
        Debug.Log("Quitted sucessfully");
    }
    public void Startbutton()
    {
        SceneManager.LoadScene("LVL_Stage1");
        Debug.Log("switched to other level");
    }
}
