using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect; // 当たった時のエフェクト
    public float effectDuration = 2f; // エフェクトの表示時間

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            // エフェクトを生成
            GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
            
            // エフェクトを一定時間後に破棄する
            Destroy(effect, effectDuration);
            
            // 弾丸を破棄
            Destroy(gameObject);
        }
    }
}