using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public static void PLay()
    {
        SceneManager.LoadScene("Level1");
    }
}
