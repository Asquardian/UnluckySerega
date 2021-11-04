using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public static class JsonHelper
{
    public static T[] FromJson<T>(string json)
    {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
        return wrapper.Items;
    }

    public static string ToJson<T>(T[] array)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper);
    }

    public static string ToJson<T>(T[] array, bool prettyPrint)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper, prettyPrint);
    }

    [System.Serializable]
    private class Wrapper<T>
    {
        public T[] Items;
    }
}

[System.Serializable]
public class Dialog
{
    public string Name;
    public string DialogText;
}
public class DialogView : MonoBehaviour
{
    private string path;
    public Text DialogOption, NameOption;
    // Start is called before the first frame update
    void Start()
    {
        path = Application.streamingAssetsPath + "/DialogLevel1.json";
        Dialog[] json = JsonHelper.FromJson<Dialog>(File.ReadAllText(path));
        NameOption.text = json[0].Name;
        DialogOption.text = json[0].DialogText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
