using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicFullScreen : MonoBehaviour
{
    public Toggle toggle;

    private void Start()
    {
        toggle.isOn = Screen.fullScreen;
    }

    public void ActivarPantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
        toggle.isOn = pantallaCompleta;
    }
}