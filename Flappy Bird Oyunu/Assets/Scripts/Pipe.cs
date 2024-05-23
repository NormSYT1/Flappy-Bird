using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    Manager manage; // Nesne kullan�m�
    void Start()
    {
        float random1 = Random.Range(-0.3f, 1.3f); // Y�kseklik de�erlerini rastgele belirle
        transform.position = new Vector3(8.0f, random1, transform.position.z); // Y�kseklik de�eri
        manage = GameObject.Find("Manager").GetComponent<Manager>(); // Ba�ka yerden fonksiyon �a��rmak i�in gerekli
    }
    void Update()
    {
        if (transform.position.x <= -9f)
        {
            manage.Increase_Score(10); // Puan� 10 artt�r            
            Destroy(gameObject); // Nesneyi yok et
        }
        transform.Translate(-2.5f * Time.deltaTime, 0, 0); // Nesnenin h�z�
    }
}