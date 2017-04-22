using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuController : MonoBehaviour {

    public GameObject AudioOnIcon;
    public GameObject AudiOffIcon;
    // Use this for initialization
    public Text txtBestScore;
	void Start () {

        SetSoundState();
        txtBestScore.text = PlayerPrefs.GetFloat("BestScore",0).ToString("0.0");

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();

        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        //Application.LoadLevel("Game");
    }

    public void ToggleSound()
    {
        if(PlayerPrefs.GetInt("Muted",0) == 0)
        {
            PlayerPrefs.SetInt("Muted", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Muted", 0);
        }
        SetSoundState();
    }

    private void SetSoundState()
    {
        if(PlayerPrefs.GetInt("Muted",0)==0)
        {
            AudioListener.volume = 1;
            AudioOnIcon.SetActive(true);
            AudiOffIcon.SetActive(false);
        }
        else
        {
            AudioListener.volume = 0;
            AudioOnIcon.SetActive(false);
            AudiOffIcon.SetActive(true);

        }
    }
}
