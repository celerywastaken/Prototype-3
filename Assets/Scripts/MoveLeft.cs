using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30.0f;
    public float leftBOund = -5;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.right * -1 * Time.deltaTime * speed); 
        if (transform.position.x  < leftBOund && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        if (playerControllerScript.GameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed); // putting the movement into an if statement, so if we're game iver it doesnt move
        }
    }

}
