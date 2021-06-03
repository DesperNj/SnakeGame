using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class button : MonoBehaviour
{

    public Button buttonToHide;
    public GameObject panel;
    public GameObject head;

    void Start()
    {
        buttonToHide = GetComponent<Button>();

        buttonToHide.onClick.AddListener(() => HideButton());
    }

    void HideButton()
    {
        panel.gameObject.SetActive(false);
        head.gameObject.SetActive(true);
    }
}
