using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultimediaManager : MonoBehaviour
{
    [SerializeField] private GameObject[] elements;
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
        audioSource.Stop();
    }

    IEnumerator FirstAudio()
    {
        PLayAudio(0);
        yield return new WaitForSeconds(1f);
        PLayAudio(1);
        yield return new WaitForSeconds(5f);
        ShowElement(0);
        yield return new WaitForSeconds(1f);
        ShowElement(1);
        yield return new WaitForSeconds(1f);
        ShowElement(2);
        yield return new WaitForSeconds(1f);
        ShowElement(3);
        yield return new WaitForSeconds(2f);
        ShowElement(4);
        yield return new WaitForSeconds(1f);
        ShowElement(5);
        //  yield return new WaitForSeconds(11f);
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
    private void ShowElement(int index)
    {
        elements[index].gameObject.SetActive(true);
        elements[index].GetComponent<Animator>().Play("popUpAnim");
    }
    private void HideEverything()
    {
        foreach (GameObject p in elements)
        {
            p.gameObject.SetActive(false);
        }
    }
}
