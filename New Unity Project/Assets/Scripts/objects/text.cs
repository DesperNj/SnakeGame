using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public int score;
    public main source;
    public GameObject cont;
    public string test;

    void Update()
    {
        cont.GetComponent<Text>().text = source.score.ToString();
    }


}
