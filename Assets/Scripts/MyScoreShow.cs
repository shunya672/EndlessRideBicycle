using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyScoreShow : MonoBehaviour
{
    //public Text myScoreShow;
    //public Text[] rankingText = new Text[3];

    //string mss;
    //string[] rt = new string[3];

    //RankingScript rankingScript;


    // Start is called before the first frame update
    void Start()
    {
        //stringからTextへの変換が無理でした
        //mss = PlayerPrefs.GetString("text0");
        //for(int i = 0; i < rt.Length; i++)
        //{
        //    rt[i] = PlayerPrefs.GetString(RankingScript.text[i]);
        //}
        //myScoreShow.text = mss.text;

        //rankingScript.GetComponent<RankingScript>(); 別シーンのため取得できない
        //staticにすると指定できないため無理

        //myScoreShow.text = RankingScript.myScoreShow.text;
        //rankingText[0].text = RankingScript.rankingText[0].text;
        //rankingText[1].text = RankingScript.rankingText[1].text;
        //rankingText[2].text = RankingScript.rankingText[2].text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
