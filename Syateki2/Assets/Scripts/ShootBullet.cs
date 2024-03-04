using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI要素を使用するために必要

public class ShootBullet : MonoBehaviour
{
    public List<GameObject> bulletPrefabs; // 弾のプレハブ
    public List<float> initialSpeeds; // 各弾の初速
    public List<GameObject> hitEffects; // 各弾が当たった時のエフェクト
    public Transform spawnPoint; // 発射位置
    public Text bulletTypeText; // 現在の球の種類を表示するテキスト

    private int currentBulletIndex = 0; // 現在選択されている弾のインデックス

    void Start()
    {
        UpdateBulletTypeText(); // スタート時にテキストを更新
    }

    void Update()
    {
        // Aキーで前の球に、Dキーで次の球に切り替え
        if (Input.GetKeyDown(KeyCode.Z))
        {
            currentBulletIndex = Mathf.Max(currentBulletIndex - 1, 0);
            UpdateBulletTypeText();
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            currentBulletIndex = Mathf.Min(currentBulletIndex + 1, bulletPrefabs.Count - 1);
            UpdateBulletTypeText();
        }

        // Spaceキーで球を撃つ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(currentBulletIndex);
        }
    }

    void Shoot(int index)
    {
        GameObject bullet = Instantiate(bulletPrefabs[index], spawnPoint.position, spawnPoint.rotation);
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = spawnPoint.forward * initialSpeeds[index];

        Bullet bulletComponent = bullet.GetComponent<Bullet>();
        if (bulletComponent != null)
        {
            bulletComponent.hitEffect = hitEffects[index];
        }
    }

    void UpdateBulletTypeText()
    {
        if (bulletTypeText != null && bulletPrefabs.Count > 0)
        {
            // プレハブ名から現在の球の種類をテキストに表示
            bulletTypeText.text = "弾丸の種類: " + bulletPrefabs[currentBulletIndex].name;
        }
    }
}
