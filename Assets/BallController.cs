using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    ScoreCounter sc = new ScoreCounter();

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            sc.Score = 10;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            sc.Score = 20;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            sc.Score = 30;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            sc.Score = 50;
        }
    }
}
