using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    protected GameStates GameStates;
    string desiredPath;
    // Start is called before the first frame update
    void Start()
    {
        GameStates = GameObject.FindObjectOfType<GameStates>(); 
    }

    private void Awake()
    {
        desiredPath = Path.Combine(Application.persistentDataPath, "Pinball_Highscore.txt");
    }

    public void LoadFromDisk()
    {
        if (File.Exists(desiredPath))
        {
            using (StreamReader streamReader = File.OpenText(desiredPath))
            {
                string jsonString = streamReader.ReadToEnd();
                JsonUtility.FromJsonOverwrite(jsonString, GameStates);
            }
        }
    }
    public void SaveToDisk()
    {
        string jsonString = JsonUtility.ToJson(GameStates);
        using (StreamWriter streamWriter = File.CreateText(desiredPath))
        {
            streamWriter.Write(jsonString);
        }Debug.Log(desiredPath);
    }

}
