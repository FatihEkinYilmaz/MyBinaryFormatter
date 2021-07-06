using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadUI : MonoBehaviour
{
    public Text playerName;
    public Text playerScore;
    public Text playerID;
    

    PlayerData playerData = new PlayerData();
    // Update is called once per frame
    private void Start()
    {
        playerName.text = "Name:"+SaveLoadSystem.Instance.inputPlayerName.text;
        playerID.text = "ID:"+SaveLoadSystem.Instance.inputPlayerID.text;
        playerScore.text = "Score:" + SaveLoadSystem.Instance.inputPlayerScore.text;
    }
    



}
