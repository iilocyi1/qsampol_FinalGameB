using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "qsampol_FinalProjectB";


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
