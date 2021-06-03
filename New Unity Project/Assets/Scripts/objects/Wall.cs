using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    public main mainSnake;
    public scorefile srr;


    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("123"))
        {
            srr.Setter(mainSnake.score);    
            Application.LoadLevel(Application.loadedLevel);
            
        }

    }

}
