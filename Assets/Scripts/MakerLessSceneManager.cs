using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakerLessSceneManager : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject podcast;
    [SerializeField] private GameObject multimedia;
    [SerializeField] private GameObject sotialNetwork;
    [SerializeField] private GameObject xrExperience;
    [SerializeField] private float volume;
    bool isMuted = false;
    private AudioSource audioSource;

    private int currentChapter = 0;

    private float currentVolumne = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        ResetEverything();
        MenuChapter();
        SetVolume(0.2f);
    }

    public void MenuChapter()
    {
        ResetEverything();
        menu.gameObject.SetActive(true);
    }

    public void PodcastChapter()
    {
        ResetEverything();
        podcast.gameObject.SetActive(true);
        SetVolume(currentVolumne);

    }
    public void MultimediaChapter()
    {
        ResetEverything();
        multimedia.gameObject.SetActive(true);
        SetVolume(currentVolumne);
    }
    public void SotialChapter()
    {
        ResetEverything();
        sotialNetwork.gameObject.SetActive(true);
        SetVolume(currentVolumne);
    }
    public void XRChapter()
    {
        ResetEverything();
        xrExperience.gameObject.SetActive(true);
        currentVolumne = volume;
        SetVolume(currentVolumne);
    }

    void ResetEverything()
    {
        currentChapter = 0;
        HideEverything();
        currentVolumne = 0.2f;
        SetVolume(currentVolumne);
    }
    void HideEverything()
    {
        menu.gameObject.SetActive(false);
        podcast.gameObject.SetActive(false);
        multimedia.gameObject.SetActive(false);
        sotialNetwork.gameObject.SetActive(false);
        xrExperience.gameObject.SetActive(false);
    }

    void SetVolume(float v)
    {
        audioSource.volume = v;
    }
    public void MuteVolume()
    {
        isMuted = !isMuted;
        if (isMuted) SetVolume(0);
        if (!isMuted) SetVolume(currentVolumne);
    }
}
