using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{   
    private int score = 0;
    private GameObject scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text> ().text = score.ToString();
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag" || tag == "SmallCloudTag")
            {
                this.score += 10;
            }
        else if (other.gameObject.tag == "LargeStarTag" || tag == "LargeCloudTag")
            {
                this.score += 20;
            }
    }
}
