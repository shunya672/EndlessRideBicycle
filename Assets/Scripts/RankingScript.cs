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

        [SerializeField, Header("���l")]
        int point;


        string[] ranking = { "1��", "2��", "3��" };
        int[] rankingValue = new int[3];

        [SerializeField, Header("�����L���OTOP3�X�R�A�ɕ\��������e�L�X�g")]
        public Text[] rankingText = new Text[3];

        public GameObject guardPanel;
        //public string[] text = { "text1", "text2", "text3" };

        public bool rankingScene;

        // Start is called before the first frame update
        void Start()
        {
            //naichilab.RankingLoader.Instance.SendScoreAndShowRanking(100);

            //Start�����ɏ�������Ǝ����̋L�^���e�L�X�g�ɔ��f����Ȃ�
            //naichilab.RankingLoader.Instance.SendScoreAndShowRanking(ScoreManagerScript.real_score);
            //�����L���O�̏����̓j�t�N���̃T�C�g����s��
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

            //PlayerPrefs.DeleteKey("1��");
            //PlayerPrefs.DeleteKey("2��");
            //PlayerPrefs.DeleteKey("3��");


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
            // C#�X�N���v�g�̖`���� `using unityroom.Api;` ��ǉ����Ă��������B

            // �{�[�hNo1�ɃX�R�A123.45f�𑗐M����B
            UnityroomApiClient.Instance.SendScore(1, ScoreManagerScript.real_score, ScoreboardWriteMode.HighScoreDesc);

            //naichilab.RankingLoader.Instance.SendScoreAndShowRanking(100);
            naichilab.RankingLoader.Instance.SendScoreAndShowRanking(ScoreManagerScript.real_score);
            //�����L���O�̏����̓j�t�N���̃T�C�g����s��

            if (guardPanel.activeInHierarchy == true)
            {
                guardPanel.SetActive(false);
            }
        }
    }
//}
