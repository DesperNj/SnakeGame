

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tale : MonoBehaviour
{

    public float Speed;
    public Vector3 tailTarget;
    public int indx;
    public GameObject tailTargetObj;
    public main mainSnake;
    public GameObject lastt;

    void Start()
    { 
        mainSnake = GameObject.FindGameObjectWithTag("123").GetComponent<main>();
        Speed = mainSnake.moveSpeeds + 2.5f;
        tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        indx = mainSnake.tailObjects.IndexOf(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * Speed*0.3f);
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("123"))
        {
            if (indx > 2)
            {
                mainSnake.scrfl.Setter(mainSnake.score);
                Application.LoadLevel(Application.loadedLevel);
            }
        }

    }

}


