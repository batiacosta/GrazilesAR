using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuarMarkerless : MonoBehaviour
{
    GameObject manager;
    private void OnEnable()
    {
        manager = GameObject.Find("Manager");
    }

    public void Continuar()
    {
        manager.GetComponent<MakerLessSceneManager>().MenuChapter();
    }
}
