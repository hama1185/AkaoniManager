using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonSend : MonoBehaviour
{
    public bool spawnFlag;
    public bool fieldFlag;
    public Canvas canvas;
    Toggle ogreSpawnToggle;
    Toggle villagerSpawnToggle;
    // Start is called before the first frame update
    void Start(){
        ogreSpawnToggle = canvas.transform.GetChild(2).GetChild(0).gameObject.GetComponent<Toggle>();
        villagerSpawnToggle = canvas.transform.GetChild(2).GetChild(1).gameObject.GetComponent<Toggle>();
        spawnFlag = true;
        fieldFlag = true;
    }

    // Update is called once per frame
    public void SpwanSend(){
        if(spawnFlag){
            if(ogreSpawnToggle.isOn){
                OgreClient.SpawnSend();
            }
            if(villagerSpawnToggle.isOn){
                VillagerClient.SpawnSend();
            }
            spawnFlag = false;
        }
    }
    public void PlayareaSizeSend(){
        if(fieldFlag){
            OgreClient.PlayareaSend();
            VillagerClient.PlayareaSend();
            fieldFlag = false;
        }
    }
    public void RealSenseMove(){
        
    }
    public void resetSpwanFlag(){
        spawnFlag = true;
        Debug.Log("up");
    }
    public void resetFieldFlag(){
        fieldFlag = true;
        Debug.Log("up");
    }
}
