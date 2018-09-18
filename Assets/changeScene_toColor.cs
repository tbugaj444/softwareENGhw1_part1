using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene_toColor : MonoBehaviour
{


	public void OnMouseClick()
	{
		SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
	}
}