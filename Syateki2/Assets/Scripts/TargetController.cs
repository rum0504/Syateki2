using UnityEngine;public class TargetController : MonoBehaviour{    public ScoreManager scoreManager; // InspectorからScoreManagerを割り当てる
    public int scoreValue = 10; // このオブジェクトを倒した時に加算するスコアの量（Inspectorから変更可能）
    private bool hasFallen = false; // 的が倒れたかを示すフラグ

    void Update()    {        if (!hasFallen)        {            float tiltAngle = Vector3.Angle(transform.up, Vector3.up);            if (tiltAngle >= 45f)            {                hasFallen = true;                Debug.Log("的が倒れました");
                // ScoreManagerのスコアを加算するメソッドを呼び出し、加算するスコアの量を指定
                scoreManager.AddScore(scoreValue);            }        }    }}