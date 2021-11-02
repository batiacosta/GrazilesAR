using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMarkerlessManager : MonoBehaviour
{
    [SerializeField] GameObject[] buttonGroup;
    [SerializeField] float segundos;

    MakerLessSceneManager manager;

    private void OnEnable()
    {
        manager = GameObject.Find("Manager").GetComponent<MakerLessSceneManager>();
        HideAllButtons();
        StartCoroutine(WaitSeconds(segundos));
    }

    IEnumerator WaitSeconds(float s)
    {
        foreach(GameObject b in buttonGroup)
        {
            yield return new WaitForSeconds(s);
            b.gameObject.SetActive(true);
            yield return new WaitForSeconds(s);
        }
    }
    void HideAllButtons()
    {
        foreach (GameObject b in buttonGroup)
        {
            b.gameObject.SetActive(false);
        }
    }

    public void GoToPodcast() {
        manager.PodcastChapter();
    }
    public void GoToMultimedia() {
        manager.MultimediaChapter();
    }
    public void GoToSotialNetwork() {
        manager.SotialChapter();
    }
    public void GoToXRExperiences() {
        manager.XRChapter();
    }
}
