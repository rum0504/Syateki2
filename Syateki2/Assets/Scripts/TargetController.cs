using UnityEngine;
    public int scoreValue = 10; // このオブジェクトを倒した時に加算するスコアの量（Inspectorから変更可能）
    private bool hasFallen = false; // 的が倒れたかを示すフラグ

    void Update()
                // ScoreManagerのスコアを加算するメソッドを呼び出し、加算するスコアの量を指定
                scoreManager.AddScore(scoreValue);