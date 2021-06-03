using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExitScore : MonoBehaviour
{

    public Button buttonToHide;
    public GameObject panel;

    void Start()
    {
        buttonToHide = GetComponent<Button>();

        buttonToHide.onClick.AddListener(() => HideButton());
    }

    void HideButton()
    {
        panel.gameObject.SetActive(false);
    }
}
