using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentManagerImageTrackingScene : MonoBehaviour
{

    [SerializeField] AudioBiblioteca audioLibrary;
    [SerializeField] GameObject baseSreen;
    private AudioSource audioSource;
    private List<AudioClip> voiceOnOff;

    private void OnEnable()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
        audiosAssignment();
        audiosAssignment();
        FirstScreen();
    }

    private void OnDisable()
    {
        baseSreen.GetComponent<Animator>().SetBool("openPaper", true);
    }
    void audiosAssignment()
    {
        foreach(AudioClip a in audioLibrary.audioList)
        {
            voiceOnOff.Add(a);
        }
    }


    void FirstScreen()
    {
        baseSreen.GetComponent<Animator>().SetBool("openPaper", true);
        audioSource.PlayOneShot(voiceOnOff[0]);
    }
}
