using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton  : MonoBehaviour  
{
    public Player player;
    public void Save()
    {
       PlayerData dataToSave = new PlayerData(player);
        SaveSystem<PlayerData>.SavePlayer( dataToSave , "/player.fun");
    }

}
