using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform[] spawnTransforms;
    public Rigidbody ballRb;
    public Rigidbody tempRb;
    public GameObject tempObject;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomNum = GetRandomNumber();
            tempObject = Instantiate(objectToSpawn, spawnTransforms[randomNum].position, Quaternion.identity, spawnTransforms[randomNum]);
           // tempObject.AddComponent<Rigidbody>(); // adds a RigidbodyComponent 

            //Invoke("SetParentTransform", 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            tempRb = Instantiate(ballRb);
            tempRb.AddForce(transform.forward * 5.0f);
        }
    }


    //public void TurnOffObject()
    //{
    //    tempObject.SetActive(false);
    //}

    public void SetParentTransform()
    {
        tempObject.transform.SetParent(parent);
    }

    public int GetRandomNumber()
    {
        int randomNumber = Random.Range(0,spawnTransforms.Length);
        return randomNumber;
    }
}
