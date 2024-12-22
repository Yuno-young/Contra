using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ESCButton : MonoBehaviour
{
    public static void ESC()
    {
        SceneManager.LoadScene("StartScene");
    }
}
