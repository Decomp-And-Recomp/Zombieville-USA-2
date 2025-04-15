using Photon;
using UnityEngine;

public class Connection : Photon.MonoBehaviour
{
	public Renderer privateText;

	public Renderer publicText;

	public Transform whichPlayer;

	private float timer;

	private bool showNotice;

	public Transform notice;

	public TextMesh noticeText;

	public string password;

	public GameObject enabler;

	public GameObject menuBacker;

	public GameObject connectPrivate;

	public GameObject connectPublic;

	private bool startConnection;

	private bool connectedToMaster;

	private bool waitingForPassword;

	private bool resetSwitch;

	private bool hitPrivate;

	private bool hitPublic;

	private TouchScreenKeyboard myKeyboard;

	private bool joinedRoom;

	private bool roomWasRandom;

	private int TouchCount;

	private int previousFrameTouchCount;

	private Vector2 TouchPosition;

	private Ray ray;

	private RaycastHit hit;

	public LayerMask layerMask;

	public Camera cameraLens;

	public Renderer[] uploadRend;

	public Renderer[] downloadRend;

	public AudioSource menuSound;

	public TextMesh cloudString;

	public TextMesh cloudString_Load;

	private float hideNotice = 100f;

	private float lightFlicker;

	private bool hitForceDownload;

	private void Start()
	{
		if (PlayerPrefs.HasKey("lastPW"))
		{
			password = PlayerPrefs.GetString("lastPW");
		}
		else
		{
			password = string.Empty;
		}
	}

	private void Update()
	{
		if (!enabler.activeSelf && resetSwitch)
		{
			resetSwitch = false;
			showNotice = false;
			startConnection = false;
			waitingForPassword = false;
			connectedToMaster = false;
			joinedRoom = false;
			hitPrivate = false;
			hitPublic = false;
			PhotonNetwork.Disconnect();
			connectPrivate.SetActive(false);
			connectPublic.SetActive(false);
		}
		if (joinedRoom && PhotonNetwork.playerList.Length < 2)
		{
			if (roomWasRandom)
			{
				noticeText.text = "Created Public Game.  Waiting for Partner...";
			}
			else
			{
				noticeText.text = "Joined Room: " + password + "   Waiting for Partner...";
			}
		}
		else if (joinedRoom && PhotonNetwork.playerList.Length == 2)
		{
			noticeText.text = "Partner Connected!  Starting Game.";
			PhotonNetwork.room.open = false;
			if (PhotonNetwork.isMasterClient)
			{
				whichPlayer.position = new Vector3(1f, 0f, 0f);
			}
			else
			{
				whichPlayer.position = new Vector3(2f, 0f, 0f);
			}
		}
		else if (waitingForPassword && myKeyboard != null && myKeyboard.wasCanceled)
		{
			resetSwitch = false;
			showNotice = false;
			startConnection = false;
			waitingForPassword = false;
			connectedToMaster = false;
			joinedRoom = false;
			hitPrivate = false;
			hitPublic = false;
			PhotonNetwork.Disconnect();
			menuBacker.SetActive(true);
			connectPrivate.SetActive(false);
			connectPublic.SetActive(false);
		}
		else if (waitingForPassword && myKeyboard != null && myKeyboard.done)
		{
			waitingForPassword = false;
			password = myKeyboard.text;
			PlayerPrefs.SetString("lastPW", password);
			joinRoom();
		}
		else if (!hitPublic && connectPublic.activeSelf && PhotonNetwork.connected)
		{
			hitPublic = true;
			roomWasRandom = true;
			noticeText.text = "Looking for Public Game...";
			PhotonNetwork.JoinRandomRoom();
		}
		else if (!hitPrivate && connectPrivate.activeSelf && PhotonNetwork.connected)
		{
			hitPrivate = true;
			promptForPassword();
		}
		else if (enabler.activeSelf && !startConnection)
		{
			startConnection = true;
			resetSwitch = true;
			if (!PhotonNetwork.connected)
			{
				noticeText.text = "Connecting to Master Server...";
				showNotice = true;
				PhotonNetwork.ConnectUsingSettings("1.0");
			}
			else if (!connectedToMaster)
			{
			}
		}
		if (showNotice)
		{
			float y = notice.localPosition.y;
			y = Mathf.Lerp(y, 1.3f, Time.deltaTime * 8f);
			notice.position = new Vector3(0f, y, notice.position.z);
		}
		else if (!showNotice)
		{
			float y2 = notice.localPosition.y;
			y2 = Mathf.Lerp(y2, 1.8f, Time.deltaTime * 8f);
			notice.position = new Vector3(0f, y2, notice.position.z);
		}
	}

	public virtual void OnConnectedToMaster()
	{
		connectedToMaster = true;
		publicText.material.color = new Color(1f, 1f, 1f, 1f);
		privateText.material.color = new Color(1f, 1f, 1f, 1f);
		noticeText.text = "Connected to Master Server";
	}

	public void promptForPassword()
	{
		if (Application.platform != 0)
		{
			waitingForPassword = true;
			noticeText.text = "Choose a Room to Create/Join";
			myKeyboard = TouchScreenKeyboard.Open(password, TouchScreenKeyboardType.Default, false, false, false, false, "Room Name to Create/Join");
		}
		else
		{
			password = "pass";
			joinRoom();
		}
	}

	public void joinRoom()
	{
		roomWasRandom = false;
		noticeText.text = "Joining Room: " + password;
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.isVisible = false;
		roomOptions.maxPlayers = 2;
		PhotonNetwork.JoinOrCreateRoom(password, roomOptions, PhotonNetwork.lobby);
	}

	public void OnJoinedRoom()
	{
		joinedRoom = true;
	}

	public void OnPhotonJoinRoomFailed()
	{
		noticeText.text = "Joining Room Failed!";
	}

	public void OnPhotonRandomJoinFailed()
	{
		noticeText.text = "No Open Games Found, Creating New Game...";
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.isVisible = true;
		roomOptions.maxPlayers = 2;
		string roomName = "Room" + Random.Range(100000, 999999);
		PhotonNetwork.CreateRoom(roomName, roomOptions, PhotonNetwork.lobby);
	}
}
