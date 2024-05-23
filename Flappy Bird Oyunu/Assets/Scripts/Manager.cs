using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject Pipe;
    private int score = 0;
    public Text text1;
    public Text lastText;
    void Start()
    {
        InvokeRepeating("Add_Pipe", 0.0f, 4.5f);//6 saniye aral�klarla boru olu�tur
        text1.text = score.ToString();
        lastText.text = score.ToString();
    }
    void Update()
    {
        
    }
    void Add_Pipe()
    {
        GameObject new_pipe = Instantiate(Pipe);
    }
    public void Increase_Score(int value)
    {
        score += value;//Puan� artt�r
        text1.text = score.ToString();//Puan� yazd�r
        lastText.text = "Your Score: " + score.ToString();
    }
}
