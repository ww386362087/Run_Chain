﻿using UnityEngine;
using System.Collections;
using PureMVC.Patterns;  

public class MonsterProxy :Proxy{
	public new const string NAME = "MonsterProxy";  
	public PlayerInfo Data { get; set; }  
	
	public MonsterProxy() : base(NAME)  
	{  
		Data = new PlayerInfo(0);  
	} 
	
	public void ChangeLevel(int changelevel)  
	{  
		Data.Level += changelevel;  
		SendNotification(NotificationConstant.LevelChange, Data);  
		
	}  
	public void movecube(){
		
	}
	
	
}
