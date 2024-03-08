using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class AutomationLoader : MonoBehaviour
{
    public SceneLoader sceneLoader;
    public string sceneName;
    public float DurationtoLoad;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("AutoLoad", DurationtoLoad);
    }

    void AutoLoad() 
    {
        sceneLoader.ChangeScene(sceneName);
    }
}
