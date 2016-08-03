using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour {

    int _currentLevel = 0;
    public int CurrentLevel
    {
        get
        {
            return _currentLevel;
        }
        set
        {
            unloadLevel(_currentLevel);
            _currentLevel = value;
            loadLevel(value);
            resetPlayer();
        }
    }
    public string[] LEVELMAP = { "stage01", "stage02", "stage03" };

    public GameObject clear;
    public Text levelText;
    public GameObject player;
    public PlayerFollower playerFollower;


    // Use this for initialization
    void Start () {
        CurrentLevel = 0;
        //loadLevel(0);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void loadLevel(int level)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(LEVELMAP[level], UnityEngine.SceneManagement.LoadSceneMode.Additive);
        levelText.text = "Level " + (_currentLevel + 1) + "/" + LEVELMAP.Length;
    }

    private void unloadLevel(int level)
    {
        UnityEngine.SceneManagement.SceneManager.UnloadScene(LEVELMAP[level]);
    }

    private void resetPlayer()
    {
        clear.SetActive(false);
        player.transform.position = new Vector3(0,5,0);
        playerFollower.ResetCamera();
    }
}
