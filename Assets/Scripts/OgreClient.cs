using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityOSC;
using System.Text;
using System.Threading.Tasks;

public class OgreClient : MonoBehaviour {
    // Start is called before the first frame update
    #region Network Settings //----------追記
    public string ip;
    public int port;
	#endregion //----------追記
    // Start is called before the first frame update
    public Dropdown dropdown;
    bool flag = false;
    public Canvas canvas;
    public void InitClient(){
        if(dropdown.value == 1){
            ip = HostList.phone1.ip;
            port = HostList.phone1.port_umpireReceive;
        }
        if(dropdown.value == 2){
            ip = HostList.phone2.ip;
            port = HostList.phone2.port_umpireReceive;
        }
        if(dropdown.value == 0){
            flag = false;
        }
        // Debug.Log("client IP : " + ip + "   port : " + port);
        try{
            OSCHandler.Instance.clientInit("ManagerOgre", ip,port);//ipには接続先のipアドレスの文字列を入れる。
            flag = true; 
        }
        catch (System.FormatException){
        }
    }
    static public void SpawnSend(){
        List<float> spawnList = new List<float>();
        spawnList.Add(UIvalue.spawnXvalue);
        spawnList.Add(UIvalue.spawnYvalue);
        OSCHandler.Instance.SendMessageToClient("ManagerOgre", "/ManageSpawn", spawnList);
    }
    static public void PlayareaSend(){
        List<float> sizeList = new List<float>();
        sizeList.Add(UIvalue.PlayareaSizeX);
        sizeList.Add(UIvalue.PlayareaSizeY);
        OSCHandler.Instance.SendMessageToClient("ManagerOgre", "/PlayareaSize", sizeList);
        Debug.Log("down");
    }
    private void FixedUpdate(){
        if(flag){
            if(canvas.transform.GetChild(5).gameObject.activeSelf){ 
                List<float> statusList = new List<float>();
                statusList.Add(UIvalue.ogreRelaxValue);
                statusList.Add(UIvalue.ogreMindValue);
                OSCHandler.Instance.SendMessageToClient("ManagerOgre", "/Mindstatus", statusList);
                // Debug.Log("ogre relax" + scrollbar.ogreRelaxStatus);
                // Debug.Log("ogre mind" + scrollbar.ogreMindStatus);
            }
        }
    }
}