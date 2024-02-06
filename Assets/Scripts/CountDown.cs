using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text countDownText;
    float oneSecondTimer = 0;


    // Start is called before the first frame update
    void Start()
    {
        countDownText = countDownText.GetComponent<Text>();

        countDownText.fontSize = 130;
        countDownText.text = "壁にぶつからずに走り抜け！！\n操作:マウスクリックorタップでジャンプ\nもう一度クリックすると2段ジャンプ！";

        oneSecondTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(oneSecondTimer < 7.0f)
        {
            oneSecondTimer += Time.deltaTime;
        }

        

        
        if (oneSecondTimer > 4.0f && oneSecondTimer < 4.5f)
        {
            countDownText.fontSize = 300;
            countDownText.text = "3";
        }

        
        if (oneSecondTimer > 4.5f && oneSecondTimer < 5.0f)
        {
            countDownText.text = "2";
        }

        
        if (oneSecondTimer > 5.0f && oneSecondTimer < 5.5f)
        {
            countDownText.text = "1";
        }

        
        if (oneSecondTimer > 5.5f && oneSecondTimer < 6.75f)
        {
            countDownText.text = "GO!";
        }

        
        if (oneSecondTimer > 6.75f)
        {
            countDownText.text = "";
        }
    }
}
