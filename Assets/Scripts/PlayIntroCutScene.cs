using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PlayIntroCutScene : MonoBehaviour
{
    VideoPlayer videoPlayer = null;

    private void Start()
    {
        // Searching objects in Video Player object, then storing
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.Play();
        // When video is done playing, call the load level function
        videoPlayer.loopPointReached += LoadNextLevel;
    }

    void LoadNextLevel(VideoPlayer videoPlayer)
    {
        int currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentBuildIndex + 1);
    }
}
