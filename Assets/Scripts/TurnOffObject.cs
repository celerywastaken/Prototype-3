using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffObject : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        //Invoke(("DestroyGameObject"), 2.0f);
        Destroy((this.gameObject), 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
