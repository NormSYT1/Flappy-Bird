using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        if (transform.position.x <= -9.0f) 
        {
            float y1 = Random.Range(0.5f, 4.2f);//Yükseklik deðerlerini rastgele belirle
            transform.position = new Vector3(9.0f, y1, transform.position.z);
        }
        transform.Translate(-0.6f * Time.deltaTime, 0, 0);
    }
}
