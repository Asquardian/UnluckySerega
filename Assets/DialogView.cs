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

[System.Serializable] //DO NOT TOUCH
public class Dialog
{
    public string Name;
    public string DialogText;
}
public class DialogView : MonoBehaviour
{
    private string path;
    public Text DialogOption, NameOption;
    public string FilePath;
    // Start is called before the first frame update
    void Start()
    {
        path = Application.streamingAssetsPath + "/" + FilePath;//Path to StramingAssets in folder
        Dialog[] json = JsonHelper.FromJson<Dialog>(File.ReadAllText(path));
        int value = Random.Range(0, 7);
        NameOption.text = json[value].Name;
        DialogOption.text = json[value].DialogText;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
