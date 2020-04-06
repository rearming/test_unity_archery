﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace GUI.Scripts
{
	public class SceneLoader : MonoBehaviour
	{
		public void LoadScene(string sceneName)
		{
			SceneManager.LoadScene(sceneName);
		}
	}
}
