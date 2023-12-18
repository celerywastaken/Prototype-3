using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewArrays : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        FizzBuzz();
    }

    private static void FizzBuzz()
    {
        for (int i = 0; i <= 100; i++)
        {

            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("fizzbuzz");
            }

            else if (i % 3 == 0)
            {
                Debug.Log("fizz");
            }

            else if (i % 5 == 0)
            {
                Debug.Log("buzz");
            }
            else
            {
                Debug.Log(i);
            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
