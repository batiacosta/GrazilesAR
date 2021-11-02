using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodcastManager : MonoBehaviour
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
        StartCoroutine(FirstAudio());
    }

    private void OnDisable()
    {
        StopAudio();
    }

    IEnumerator FirstAudio()
    {
        PLayAudio(0);
        microphone.gameObject.SetActive(true);
        microphone.GetComponent<Animator>().Play("popUpAnim");
        yield return new WaitForSeconds(0.5f);
        musicalNote.gameObject.SetActive(true);
        musicalNote.GetComponent<Animator>().Play("popUpAnim");
        yield return new WaitForSeconds(0.5f);
        musicalNote.GetComponent<Animator>().Play("Spinning");
        PLayAudio(1);
        yield return new WaitForSeconds(3f);
        platforms[0].gameObject.SetActive(true);
        platforms[0].GetComponent<Animator>().Play("popUpAnim");
        yield return new WaitForSeconds(0.5f);
        platforms[1].gameObject.SetActive(true);
        platforms[1].GetComponent<Animator>().Play("popUpAnim");
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
        foreach(GameObject p in platforms)
        {
            p.gameObject.SetActive(false);
        }
    }
}
