using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{

    public scorefile source;
    public GameObject textcanv;
    public string bugf;

    void Start()
    {
        source.Getter();
    }

    void Update()
    {
        textcanv.GetComponent<Text>().text = bugf;


    }


}