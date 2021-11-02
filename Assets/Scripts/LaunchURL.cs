
using UnityEngine;

public class LaunchURL : MonoBehaviour
{
    [SerializeField] private string url;

    public void URLLauncher()
    {
        Application.OpenURL(url);
    }
}
