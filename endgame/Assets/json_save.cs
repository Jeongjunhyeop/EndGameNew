using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class json_save : MonoBehaviour
{
    public GameObject stage2_bt;
    public GameObject stage3_bt;
    public GameObject stage4_bt;

    public PlayerData playerData;

    [ContextMenu("To json Data")]
    public void savePlayerData_Json()
    {
        string jsonData = JsonUtility.ToJson(playerData, true);
        string path = Path.Combine(Application.dataPath, "playerData.json");
        File.WriteAllText(path, jsonData);
    }

    [ContextMenu("From Json Data")]
    public  void LoadPlayerDataToJson()
    {
        string path = Path.Combine(Application.dataPath, "playerData.json");
        string jsonData = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<PlayerData>(jsonData);
        check_stage();
    }

    public void check_stage()
    {
        if (playerData.clear_stage >= 2)
        {
            stage2_bt.GetComponent<Button>().interactable = true;
        }

        if (playerData.clear_stage >= 3)
        {
            stage3_bt.GetComponent<Button>().interactable = true;
        }

        if (playerData.clear_stage >= 4)
        {
            stage4_bt.GetComponent<Button>().interactable = true;
        }
    }

}


[System.Serializable]
public class PlayerData
{
    public int clear_stage;
}

