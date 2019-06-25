using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenecontroller : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (SceneManager.GetActiveScene().name == "TitleScene")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                FadeController.isFade = true;
                FadeController.isFadeOut = true;
                Invoke("gamescene", 1.5f);
            }
        }
	}

    void gamescene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
