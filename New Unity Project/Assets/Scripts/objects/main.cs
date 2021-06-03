using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class main : MonoBehaviour
{
    public GameObject obj;
    public float moveSpeeds = 1f;
    public float rotation = 100f;
    public GameObject TailPrefab;
    public int score = 0;
    public List<GameObject> tailObjects = new List<GameObject>();
    public float z_offset = 0.5f;
    public GameObject light;
    public scorefile scrfl;

    private bool IsLightActive = true;
    public void Start()
    {
        tailObjects.Add(gameObject);
        scrfl.Getter();
    }
    public void FixedUpdate()
    {
        obj.transform.Translate(Vector3.forward * moveSpeeds * Time.deltaTime * 3);
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            obj.transform.Rotate(Vector3.down, rotation * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            obj.transform.Rotate(Vector3.up, rotation * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            Destroy(GameObject.Find("objj(Clone)"));
        }
        if (score > 0)
        {
            if (lightchange() == true)
            {                
                light.gameObject.SetActive(true);
            };
            if(lightchange() == false)
            {
                light.gameObject.SetActive(false);
            }
        }
    }
    public void AddTale()
    {
        Vector3 newTailPos = tailObjects[tailObjects.Count - 1].transform.position;
        newTailPos.z -= z_offset;
        tailObjects.Add(GameObject.Instantiate(TailPrefab, newTailPos, Quaternion.identity) as GameObject);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("apple"))
        {
            moveSpeeds += 0.2f;
            Destroy(other.gameObject);
            AddTale();
            score++;
            print(score);
        }
    }

    public bool lightchange()
    {
        bool IsLightActive = true;
        if (score > 0)
        {
            if (score % 3 == 0 && score % 4 == 0 && score % 5 == 0 && score % 6 != 0)
            {
                IsLightActive = false;
                //     light.gameObject.SetActive(IsLightActive);
            } ;
            if (score % 6 == 0 && score % 7 == 0 && score % 8 == 0 && score % 3 != 0 && score % 4 != 0 &&
                score % 5 != 0)
            {
                IsLightActive = true;
                //     light.gameObject.SetActive(IsLightActive);
            };
        }
        return IsLightActive;
    }
}


