using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
	public static void OpenSceneStartGame()
	{
		SceneManager.LoadScene("StartScene");
	}
}
