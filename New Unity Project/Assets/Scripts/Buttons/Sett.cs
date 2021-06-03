using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sett : MonoBehaviour
{
    public Button buttonToSet;
    public GameObject panel;

    void Start()
    {
        buttonToSet = GetComponent<Button>();
       // buttonToSet.onClick.AddListener(() => ssvv.Stert());
    //   buttonToSet.onClick.AddListener(() => ssvv.ypdate());
        buttonToSet.onClick.AddListener(() => Settings());
 
     
    }

    void Settings()
    {
        panel.gameObject.SetActive(false);
    }
}
