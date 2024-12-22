using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLive : MonoBehaviour
{
    public int maxLives = 3;
    private int currentLives;

    public Sprite lifeSprite;
    private List<GameObject> lifeImages = new List<GameObject>();

    void Start()
    {
        currentLives = maxLives;
        InitializeLives();
    }

    void InitializeLives()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject); // Xóa các hình cũ
        }
        lifeImages.Clear();

        for (int i = 0; i < maxLives; i++)
        {
            GameObject life = new GameObject("Life" + (i + 1), typeof(Image));
            life.transform.SetParent(this.transform);
            Image img = life.GetComponent<Image>();
            img.sprite = lifeSprite;
            img.rectTransform.sizeDelta = new Vector2(50, 50); // Kích thước
            life.SetActive(true); // Kích hoạt ảnh
            lifeImages.Add(life);
        }
    }

    public void RemoveLife()
    {
        if (currentLives > 0)
        {
            currentLives--;
            Debug.Log("Remaining Lives: " + currentLives);
            lifeImages[currentLives].SetActive(false); // Ẩn trái tim cuối cùng
            if (currentLives <= 0)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over!");
        // Thêm logic cho Game Over tại đây
    }

}
