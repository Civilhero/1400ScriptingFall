using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonBehave : MonoBehaviour
{
    public void ButtonStarts()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonQuits()
    {
        Application.Quit();
    }
}
