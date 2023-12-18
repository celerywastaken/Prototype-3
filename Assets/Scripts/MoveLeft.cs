using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30.0f;
    public float leftBOund = -5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * -1 * Time.deltaTime * speed); 
        if (transform.position.x  < leftBOund)
        {
            Destroy(gameObject);
        }
    }
}
