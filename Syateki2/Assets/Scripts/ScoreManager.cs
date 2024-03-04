using UnityEngine;
using UnityEngine.UI; // 追加

public class ScoreManager : MonoBehaviour
{
    private int score = 0; // 現在のスコア
    public Text scoreText; // ScoreTextを参照するための変数

    void Start()
    {
        // インスペクターでScoreTextを設定する
        // ※ScoreTextを持つオブジェクトにアタッチしている必要があります
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        // ゲーム開始時にスコアを0にリセット
        UpdateScoreDisplay();
    }

    public void AddScore(int amount)
    {
        score += amount; // スコアを加算
        Debug.Log("Current Score: " + score); // 現在のスコアをログに出力
        UpdateScoreDisplay(); // スコア表示を更新
    }

    void UpdateScoreDisplay()
    {
        // スコア表示を更新
        scoreText.text = "Score: " + score.ToString();
    }
}