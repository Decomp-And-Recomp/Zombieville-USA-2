using System;
using System.Text;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine;

public class GoogleCloudSave : MonoBehaviour
{
	private int TouchCount;

	private int previousFrameTouchCount;

	private Vector2 TouchPosition;

	private Ray ray;

	private RaycastHit hit;

	public LayerMask layerMask;

	public Camera cameraLens;

	public Transform saveSpinTran;

	public Renderer saveSpinRend;

	public Transform loadSpinTran;

	public Renderer loadSpinRend;

	private float errorTimer;

	public TextMesh debugPrintout;

	public Renderer debugBackground;

	public TextMesh cloudString;

	public TextMesh cloudString_Load;

	public Texture2D savedImage;

	private void Update()
	{
		playerInput();
		if (errorTimer > 0f)
		{
			errorTimer -= Time.deltaTime;
			if (errorTimer <= 0f)
			{
				debugPrintout.text = string.Empty;
				debugBackground.enabled = false;
			}
		}
		saveSpinTran.Rotate(0f, 0f, -360f * Time.deltaTime);
		loadSpinTran.Rotate(0f, 0f, -360f * Time.deltaTime);
	}

	private void playerInput()
	{
		bool flag = false;
		if (TouchCount > 0)
		{
			flag = true;
		}
		previousFrameTouchCount = TouchCount;
		TouchCount = 0;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			if (Input.GetMouseButton(0))
			{
				TouchCount = 1;
			}
			TouchPosition = Input.mousePosition;
		}
		else
		{
			TouchCount = Input.touchCount;
		}
		bool flag2 = false;
		if (flag && TouchCount == 0)
		{
			flag2 = true;
		}
		if (TouchCount > 0)
		{
			if (Application.platform != 0)
			{
				TouchPosition = Input.GetTouch(0).position;
			}
			if (previousFrameTouchCount != 0)
			{
			}
		}
		else
		{
			if (TouchCount != 0 || !flag2)
			{
				return;
			}
			ray = cameraLens.ScreenPointToRay(TouchPosition);
			if (Physics.Raycast(ray, out hit, 10f, layerMask))
			{
				if (hit.transform.name == "Button_Upload")
				{
					MonoBehaviour.print("cloud save");
					ShowSelectUI();
					saveSpinRend.enabled = true;
				}
				else if (hit.transform.name == "Button_Download")
				{
					MonoBehaviour.print("cloud load");
					ShowSelectUI_Load();
					loadSpinRend.enabled = true;
				}
			}
		}
	}

	private void ShowSelectUI()
	{
		uint maxDisplayedSavedGames = 5u;
		bool showCreateSaveUI = true;
		bool showDeleteSaveUI = true;
		ISavedGameClient savedGame = PlayGamesPlatform.Instance.SavedGame;
		savedGame.ShowSelectSavedGameUI("Create or Overwrite File", maxDisplayedSavedGames, showCreateSaveUI, showDeleteSaveUI, OnSavedGameSelected);
	}

	private void ShowSelectUI_Load()
	{
		uint maxDisplayedSavedGames = 5u;
		bool showCreateSaveUI = false;
		bool showDeleteSaveUI = true;
		ISavedGameClient savedGame = PlayGamesPlatform.Instance.SavedGame;
		savedGame.ShowSelectSavedGameUI("Choose Data to Load", maxDisplayedSavedGames, showCreateSaveUI, showDeleteSaveUI, OnLoadGameSelected);
	}

	public void OnSavedGameSelected(SelectUIStatus status, ISavedGameMetadata game)
	{
		if (status == SelectUIStatus.SavedGameSelected)
		{
			string filename = game.Filename;
			if (game.Filename == string.Empty)
			{
				filename = "Save" + UnityEngine.Random.Range(1000000, 9999999);
			}
			OpenSavedGame(filename);
		}
		else
		{
			saveSpinRend.enabled = false;
			debugPrintout.text = "OnSavedGameSelected Error - " + status;
			debugBackground.enabled = true;
			errorTimer = 2f;
		}
	}

	public void OnLoadGameSelected(SelectUIStatus status, ISavedGameMetadata game)
	{
		if (status == SelectUIStatus.SavedGameSelected)
		{
			OpenSavedGame_Load(game.Filename);
			return;
		}
		loadSpinRend.enabled = false;
		debugPrintout.text = "OnLoadGameSelected Error - " + status;
		debugBackground.enabled = true;
		errorTimer = 2f;
	}

	private void OpenSavedGame(string filename)
	{
		ISavedGameClient savedGame = PlayGamesPlatform.Instance.SavedGame;
		savedGame.OpenWithAutomaticConflictResolution(filename, DataSource.ReadCacheOrNetwork, ConflictResolutionStrategy.UseUnmerged, OnSavedGameOpened);
	}

	private void OpenSavedGame_Load(string filename)
	{
		ISavedGameClient savedGame = PlayGamesPlatform.Instance.SavedGame;
		savedGame.OpenWithAutomaticConflictResolution(filename, DataSource.ReadCacheOrNetwork, ConflictResolutionStrategy.UseUnmerged, OnSavedGameOpened_Load);
	}

	public void OnSavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata game)
	{
		if (status == SavedGameRequestStatus.Success)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(cloudString.text);
			TimeSpan totalPlaytime = new TimeSpan(0, 0, 0);
			SaveGame(game, bytes, totalPlaytime);
		}
		else
		{
			saveSpinRend.enabled = false;
			debugPrintout.text = "OnSavedGameOpened Error - " + status;
			debugBackground.enabled = true;
			errorTimer = 2f;
		}
	}

	public void OnSavedGameOpened_Load(SavedGameRequestStatus status, ISavedGameMetadata game)
	{
		if (status == SavedGameRequestStatus.Success)
		{
			LoadGameData(game);
			return;
		}
		loadSpinRend.enabled = false;
		debugPrintout.text = "Load Error - " + status;
		debugBackground.enabled = true;
		errorTimer = 2f;
	}

	private void LoadGameData(ISavedGameMetadata game)
	{
		ISavedGameClient savedGame = PlayGamesPlatform.Instance.SavedGame;
		savedGame.ReadBinaryData(game, OnSavedGameDataRead);
	}

	public void OnSavedGameDataRead(SavedGameRequestStatus status, byte[] data)
	{
		if (status == SavedGameRequestStatus.Success)
		{
			string @string = Encoding.UTF8.GetString(data);
			cloudString_Load.text = @string;
			loadSpinRend.enabled = false;
		}
		else
		{
			loadSpinRend.enabled = false;
			debugPrintout.text = "Read Error - " + status;
			debugBackground.enabled = true;
			errorTimer = 2f;
		}
	}

	private void SaveGame(ISavedGameMetadata game, byte[] savedData, TimeSpan totalPlaytime)
	{
		ISavedGameClient savedGame = PlayGamesPlatform.Instance.SavedGame;
		SavedGameMetadataUpdate.Builder builder = default(SavedGameMetadataUpdate.Builder);
		DateTime now = DateTime.Now;
		builder = builder.WithUpdatedPlayedTime(totalPlaytime).WithUpdatedDescription("Saved game at " + now);
		if (savedImage != null)
		{
			byte[] newPngCoverImage = savedImage.EncodeToPNG();
			builder = builder.WithUpdatedPngCoverImage(newPngCoverImage);
		}
		SavedGameMetadataUpdate updateForMetadata = builder.Build();
		savedGame.CommitUpdate(game, updateForMetadata, savedData, OnSavedGameWritten);
	}

	public void OnSavedGameWritten(SavedGameRequestStatus status, ISavedGameMetadata game)
	{
		if (status == SavedGameRequestStatus.Success)
		{
			saveSpinRend.enabled = false;
			return;
		}
		saveSpinRend.enabled = false;
		debugPrintout.text = "Write Error - " + status;
		debugBackground.enabled = true;
		errorTimer = 2f;
	}

	public Texture2D getScreenshot()
	{
		Texture2D texture2D = new Texture2D(1024, 700);
		texture2D.ReadPixels(new Rect(0f, 0f, Screen.width, Screen.width / 1024 * 700), 0, 0);
		return texture2D;
	}
}
