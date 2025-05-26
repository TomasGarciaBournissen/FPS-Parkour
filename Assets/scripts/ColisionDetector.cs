using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionDetector : MonoBehaviour
{
    int Puntos = 0;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
      
      
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
            Puntos++;
            Debug.Log(Puntos);
        }
            
    }
}
