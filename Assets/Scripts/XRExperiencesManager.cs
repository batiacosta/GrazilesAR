using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRExperiencesManager : MonoBehaviour
{
    [SerializeField] private GameObject microphone;
    [SerializeField] private GameObject musicalNote;
    [SerializeField] private GameObject[] platforms;
    [SerializeField] private AudioClip[] audios;

    private AudioSource audioSource;

    private void OnEnable()
    {
        audioSource = GetComponent<AudioSource>();
        HideEverything();
    }

    IEnumerator FirstAudio()
    {
        PLayAudio(0);
        yield return new WaitForSeconds(1f);
        PLayAudio(1);
        //  yield return new WaitForSeconds(7f);
    }

    private void StopAudio()
    {
        audioSource.Stop();
    }
    private void PLayAudio(int index)
    {
        audioSource.clip = audios[index];
        audioSource.PlayOneShot(audioSource.clip);
        audioSource.Play();
    }
    private void HideEverything()
    {
        microphone.gameObject.SetActive(false);
        musicalNote.gameObject.SetActive(false);
        foreach (GameObject p in platforms)
        {
            p.gameObject.SetActive(false);
        }
    }
}
