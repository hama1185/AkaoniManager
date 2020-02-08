using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityOSC;
using System.Text;
using System.Threading.Tasks;

public class VillagerRealSenseClient : MonoBehaviour
{
    #region Network Settings //----------追記
    public string ip;
    public int port;
	#endregion //----------追記
    // Start is called before the first frame update
    public Dropdown charDropDown;
    bool flag = false;
    public Canvas canvas;
    public void InitClient(){
        if(charDropDown.value == 1){
            ip = HostList.phone2.ip_raspberrypi;
            port = HostList.phone2.port_raspberrypi;
        }
        if(charDropDown.value == 2){
            ip = HostList.phone1.ip_raspberrypi;
            port = HostList.phone1.port_raspberrypi;
        }
        if(charDropDown.value == 0){
            flag = false;
        }
        // Debug.Log("client IP : " + ip + "   port : " + port);
        try{
            OSCHandler.Instance.clientInit("RealSenseVillager", ip,port);//ipには接続先のipアドレスの文字列を入れる。
            flag = true; 
        }
        catch (System.FormatException){
        }
    }
    static public void RealSenseStartSend(){
        OSCHandler.Instance.SendMessageToClient("RealSenseVillager", "/start", "");
    }
    static public void RealSenseStopSend(){
        OSCHandler.Instance.SendMessageToClient("RealSenseVillager", "/stop", "");
    }
    // Start is called before the first frame update
}
