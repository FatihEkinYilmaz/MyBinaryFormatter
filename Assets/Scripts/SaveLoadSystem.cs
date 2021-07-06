using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadSystem : MonoBehaviour
{
    public static SaveLoadSystem Instance;

    public InputField inputPlayerName;
    public InputField inputPlayerScore;
    public InputField inputPlayerID;

   
    

    string filePath;
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        filePath = Path.Combine(Application.dataPath, "playerdata.save");

        
    }

    public void SavePlayerData()
    {
        PlayerData playerData = new PlayerData();
        playerData.playerName = inputPlayerName.text;
        playerData.playerID = inputPlayerID.text;
        playerData.playerScore = inputPlayerScore.text;

        Stream stream = new FileStream(filePath, FileMode.Create);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(stream, playerData);
        
        stream.Close();
        

    }

    public void LoadPlayerData()
    {
        if (File.Exists(filePath))
        {
            Stream stream = new FileStream(filePath, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            PlayerData data = (PlayerData)binaryFormatter.Deserialize(stream);
            stream.Close();

            inputPlayerName.text = data.playerName;
            inputPlayerID.text = data.playerID;
            inputPlayerScore.text = data.playerScore;

            SceneManager.LoadScene(1);
            
        }
    }

}
