using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkManagerMotorMurder : NetworkManager
{
	public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId, NetworkReader extraMessageReader)
	{
		base.OnServerAddPlayer(conn, playerControllerId, extraMessageReader);


	}
}
