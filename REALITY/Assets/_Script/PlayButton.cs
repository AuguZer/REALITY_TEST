using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayButton : MonoBehaviour
{
    [SerializeField] GameObject videoDisplayer;
    [SerializeField] GameObject pauseUI;
    VideoPlayer videoPlayer;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        videoDisplayer.SetActive(false);
        pauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PauseVideo();
    }

    public void ContinueVideo()
    {
        pauseUI.SetActive(false);
        videoPlayer.Play();
    }
    public void BackToMenu()
    {
        pauseUI.SetActive(false);
        videoPlayer.Stop();
    }
    public void PauseVideo()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseUI.SetActive(true);
            videoPlayer.Pause();
        }
    }

    public void PlayVideo()
    {
        videoDisplayer.SetActive(true);
        videoPlayer.Play();
    }
}
