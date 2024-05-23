using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    Manager manage; // Nesne kullanýmý
    void Start()
    {
        float random1 = Random.Range(-0.3f, 1.3f); // Yükseklik deðerlerini rastgele belirle
        transform.position = new Vector3(8.0f, random1, transform.position.z); // Yükseklik deðeri
        manage = GameObject.Find("Manager").GetComponent<Manager>(); // Baþka yerden fonksiyon çaðýrmak için gerekli
    }
    void Update()
    {
        if (transform.position.x <= -9f)
        {
            manage.Increase_Score(10); // Puaný 10 arttýr            
            Destroy(gameObject); // Nesneyi yok et
        }
        transform.Translate(-2.5f * Time.deltaTime, 0, 0); // Nesnenin hýzý
    }
}