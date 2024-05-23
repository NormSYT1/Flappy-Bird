using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump_power;
    public float bend_speed;
    public GameObject panel;
    public void OnCollisionEnter2D(Collision2D collision)//�arp��ma olursa
    {
        Time.timeScale = 0f;
        panel.SetActive(true);
        bend_speed = 0f;
    }
    void Start()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
        rb=GetComponent<Rigidbody2D>();//Rigidbody komutu i�in gerekli
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//Space tu�una bas�l�rsa
        {
            rb.velocity = Vector2.zero;
            rb.velocity = Vector2.up * jump_power * Time.deltaTime;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60.0f);//Nesne 60 derece a��yla bakar
        }
        else
        {
            transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, bend_speed);//Nesnenin e�ilme a��s� azal�r
        }
    }
}
