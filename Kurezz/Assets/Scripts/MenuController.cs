using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    //Audio
    [Header("Audio Setts")]

    [SerializeField] private Text volumeValue = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private GameObject confiramtionPrompt1 = null;
    [SerializeField] private float defaultVolume = 60f;

    //audio control in different scenes
    public GameObject ObjectMusic;
    private AudioSource AudioSource;
    

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        volumeValue.text = volume.ToString("0");

        ObjectMusic = GameObject.FindWithTag("GameMusic");
        AudioSource = ObjectMusic.GetComponent<AudioSource>();
    }
    public void ApplyVolume()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        StartCoroutine(ConfirmationBoxApply());
    }

    public void ResetVolume(string tipo)
    {
        if (tipo == "audio")
        {
            AudioListener.volume = defaultVolume;
            volumeSlider.value = defaultVolume;
            volumeValue.text = defaultVolume.ToString("0");
            PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);

        }
    }

    public IEnumerator ConfirmationBoxApply()
    {

        confiramtionPrompt1.SetActive(true);
        yield return new WaitForSeconds(1);
        confiramtionPrompt1.SetActive(false);

    }
    
    //Scene
    [Header("Scene Manager")]

    public string _playGame;
    public string _exitGame;

    public void SceneManagerr()
    {
        SceneManager.LoadScene(_playGame);
    }

    public void SceneMngr()
    {
        SceneManager.LoadScene(_exitGame);
    }


    
}
