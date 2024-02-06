using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using NCMB;
using unityroom.Api;

//namespace unityroom.Api
//{
public class RankingScript : MonoBehaviour
    {
        public Text myScoreShow;

        [SerializeField, Header("数値")]
        int point;


        string[] ranking = { "1位", "2位", "3位" };
        int[] rankingValue = new int[3];

        [SerializeField, Header("ランキングTOP3スコアに表示させるテキスト")]
        public Text[] rankingText = new Text[3];

        public GameObject guardPanel;
        //public string[] text = { "text1", "text2", "text3" };

        public bool rankingScene;

        // Start is called before the first frame update
        void Start()
        {
            //naichilab.RankingLoader.Instance.SendScoreAndShowRanking(100);

            //Startすぐに処理すると自分の記録がテキストに反映されない
            //naichilab.RankingLoader.Instance.SendScoreAndShowRanking(ScoreManagerScript.real_score);
            //ランキングの消去はニフクラのサイトから行う
            guardPanel.SetActive(true);

            if (rankingScene)
            {
                Invoke("OnlineRankingButton", 1.25f);
            }

            //Scene scene = SceneManager.GetSceneByName("Ranking");
            //if(SceneManager.GetActiveScene() != SceneManager.GetSceneByName("Ranking"))
            //{
            //    naichilab.RankingLoader.Instance.SendScoreAndShowRanking(ScoreManagerScript.real_score);
            //}


            //PlayerPrefs.DeleteAll();

            //PlayerPrefs.DeleteKey("1位");
            //PlayerPrefs.DeleteKey("2位");
            //PlayerPrefs.DeleteKey("3位");


            myScoreShow.text = ScoreManagerScript.real_score.ToString() + "m";
            //PlayerPrefs.SetString("text0", myScoreShow.ToString());

            GetRanking();

            if (rankingScene)
            {
                SetRanking(point);
            }


            for (int i = 0; i < ranking.Length; i++)
            {
                rankingText[i].text = rankingValue[i].ToString() + "m";
                //PlayerPrefs.SetString(text[i], rankingText[i].ToString());
            }
        }

        void GetRanking()
        {

            for (int i = 0; i < ranking.Length; i++)
            {
                rankingValue[i] = PlayerPrefs.GetInt(ranking[i]);
            }
        }

        void SetRanking(int _value)
        {

            _value = Mathf.FloorToInt(ScoreManagerScript.real_score);


            for (int i = 0; i < ranking.Length; i++)
            {

                if (_value > rankingValue[i])
                {
                    var change = rankingValue[i];
                    rankingValue[i] = _value;
                    _value = change;
                }
            }


            for (int i = 0; i < ranking.Length; i++)
            {
                PlayerPrefs.SetInt(ranking[i], rankingValue[i]);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnlineRankingButton()
        {
            // C#スクリプトの冒頭に `using unityroom.Api;` を追加してください。

            // ボードNo1にスコア123.45fを送信する。
            UnityroomApiClient.Instance.SendScore(1, ScoreManagerScript.real_score, ScoreboardWriteMode.HighScoreDesc);

            //naichilab.RankingLoader.Instance.SendScoreAndShowRanking(100);
            naichilab.RankingLoader.Instance.SendScoreAndShowRanking(ScoreManagerScript.real_score);
            //ランキングの消去はニフクラのサイトから行う

            if (guardPanel.activeInHierarchy == true)
            {
                guardPanel.SetActive(false);
            }
        }
    }
//}
