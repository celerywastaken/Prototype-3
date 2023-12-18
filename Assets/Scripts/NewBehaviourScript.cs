using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class NewBehaviourScript : MonoBehaviour
{
    public bool isGameRunning;
    public bool checkValue;
    public int score;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Guard Clause
        //if (isGameRunning)
        //{
        //    int grade = score / 10;

        //    if (score >= 70 && score <= 100)
        //    {
        //        Debug.Log("Your Grade is: A");
        //        return;
        //    }
        //    if (score >= 60 && score < 70)
        //    {
        //        Debug.Log("Your Grade is: B");
        //        return;
        //    }

        //    if (score >= 50)
        //    {
        //        Debug.Log("Your Grade is: C");
        //        return;
        //    }
        //    if (score >= 40 && score < 60)
        //    {
        //        Debug.Log("Your Grade is: D");
        //        return;
        //    }
        //    if (score >= 0 && score < 40)
        //    {
        //        Debug.Log("Your Grade is: F");
        //        return;
        //    }
        //    if (score < 0 || score > 100)
        //    {
        //        Debug.Log("No Grade");
        //        return;
        //    }
        //}
        switch (score)
        {
            case 10:
            case 9:
            case 8:
            case 7:
                Debug.Log("Value is " + score + " you get an A");
                break;

            case 6:
                Debug.Log("Value is " + score + " you get an A");
                break;

            case 5:
                Debug.Log("Value is " + score + " you get an A");
                break;
            case 4:
                Debug.Log("Value is " + score + " you get an A");
                break;
            case 3:
                Debug.Log("Value is " + score + " you get an A");
                break;
            case 2:
                Debug.Log("Value is " + score + " you get an A");
                break;
            case 1:
                Debug.Log("Value is " + score + " you get an A");
                break;


            default:
                break;
        }


        //if (!checkValue)
        //{
        //    Debug.Log("checked Value is false");
        //}
        //if (playerName == "Moby")
        //{
        //    Debug.Log("Printing Player Name");
        //}
    }
}
