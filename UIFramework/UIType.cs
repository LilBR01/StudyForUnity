using UnityEngine;

public class UIType : MonoBehaviour
{
    public string Name{get; private set;}
    public string Path{get; private set;}
    public UIType(string path)
    {
        Path = path;
        Name = path.Substring(path.LastIndexOf('/') + 1);
    }
}
