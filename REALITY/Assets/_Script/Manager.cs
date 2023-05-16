using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Manager : MonoBehaviour
{
    [SerializeField] GameObject videoDisplayer;
    [SerializeField] GameObject pauseUI;
    [SerializeField] GameObject formUI;
    [SerializeField] VideoPlayer videoPlayer;

    float videoLenght = 31.67f;

    // Start is called before the first frame update
    void Start()
    {
        videoDisplayer.SetActive(false);
        pauseUI.SetActive(false);
        formUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PauseVideo();
        DisplayForm();
    }


    public void SubmitForm()
    {
        formUI.SetActive(false);
    }
    public void DisplayForm()
    {
        if (videoPlayer.time >= videoLenght)
        {
            formUI.SetActive(true);
            videoDisplayer.SetActive(false);
            videoPlayer.Stop();
        }
    }
    public void ContinueVideo()
    {
        pauseUI.SetActive(false);
        videoPlayer.Play();
    }
    public void BackToMenu()
    {
        videoDisplayer.SetActive(false);
        pauseUI.SetActive(false);
        videoPlayer.Stop();
    }
    public void PauseVideo()
    {
        if (videoPlayer.isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                pauseUI.SetActive(true);
                videoPlayer.Pause();
            }
        }
    }
    public void PlayVideo()
    {
        videoDisplayer.SetActive(true);
        videoPlayer.Play();
    }
}
