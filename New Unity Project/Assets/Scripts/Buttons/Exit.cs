using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Exit : MonoBehaviour
{
    public Button buttonToHide;


    void Start()
    {
        buttonToHide = GetComponent<Button>();

        buttonToHide.onClick.AddListener(() => Exet());
    }

    void Exet()
    {
        Application.Quit();
    }
}
