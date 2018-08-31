using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

    private int point = 0;

    private GameObject PointText;

    public int Score
    {
        get
        {
            return point;
        }

        set
        {
            point += value;
            this.PointText = GameObject.Find("PointText");
            this.PointText.GetComponent<Text>().text = point.ToString();
        }
    }
}

