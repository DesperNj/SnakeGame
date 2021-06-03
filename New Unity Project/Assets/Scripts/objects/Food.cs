using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject head;
    public GameObject apple;
    public float Xsize = 50f;
    public float Zsize = 50f;
    public GameObject current;
    public Vector3 pos;
    main mclas = new main();

   /* public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("123"))
        {
            Destroy(apple);
            other.GetComponent<main>().AddTale();


        }
    }
   */

    void Start()
    {
        AddNewFood();
    }

    void AddNewFood()
    {
        RandomPos();
        current = GameObject.Instantiate(apple, pos, Quaternion.identity) as GameObject;
    }
 
    
    
    
    
    void RandomPos()
    {
        pos = new Vector3(Random.Range(Xsize * -1, Xsize), 1.7f, Random.Range(Zsize * -1, Zsize));
    }

    void Update()
    {
        
        if (!current)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
}
