using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text textTime;
    private int time = 90;

    void Start()
    {
        StartCoroutine("CountDown");
    }

    
    void Update()
    {
        
    }

    IEnumerator CountDown()
    {
        while (true)
        {
            time--;
            textTime.text = time.ToString();

            if (time == 0)
            {
                StopCoroutine("CountDown");
            }
            yield return new WaitForSeconds(1);
        }
    }
}
