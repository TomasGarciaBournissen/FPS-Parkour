using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("contacto");
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
            
    }
}
