using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void OnCollisionStay(Collision col)
    {
     if(col.gameObject.name == "Sphere")
     {
         Debug.Log("boom");
         
         Destroy(gameObject);
     }

    }    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(-1.0f,0.0f,0.0f);
        }
    
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(1.0f,0.0f,0.0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(0.0f,0.0f,-1.0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(0.0f,0.0f,1.0f);
        }
    }
}
