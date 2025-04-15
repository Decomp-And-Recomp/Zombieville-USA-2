using System.Text;
using UnityEngine;

public class Listener : MonoBehaviour
{
	public TextMesh message1;

	public TextMesh message2;

	public TextMesh message3;

	public TextMesh message4;

	public TextMesh message5;

	public TextMesh message6;

	public TextMesh message7;

	public TextMesh message8;

	public TextMesh message9;

	public TextMesh message10;

	public TextMesh message11;

	public TextMesh message12;

	public TextMesh message13;

	public TextMesh message14;

	public TextMesh message15;

	public TextMesh message16;

	public TextMesh message17;

	public TextMesh message18;

	public TextMesh message19;

	public TextMesh message20;

	public TextMesh message21;

	public TextMesh message22;

	public TextMesh message23;

	public TextMesh message24;

	public TextMesh message25;

	public TextMesh message26;

	public TextMesh message27;

	public TextMesh message28;

	public TextMesh message29;

	public TextMesh message30;

	public TextMesh message31;

	public TextMesh message32;

	public TextMesh message33;

	public TextMesh message34;

	public TextMesh message35;

	public TextMesh message36;

	public TextMesh message37;

	public TextMesh message38;

	public TextMesh message39;

	public TextMesh message40;

	public TextMesh message41;

	public TextMesh message42;

	public TextMesh message43;

	public TextMesh message44;

	public TextMesh message45;

	public TextMesh message46;

	public TextMesh message47;

	public TextMesh message48;

	public TextMesh message49;

	public TextMesh message50;

	public TextMesh message51;

	public TextMesh message52;

	public TextMesh message53;

	public TextMesh message54;

	public TextMesh message55;

	public TextMesh message56;

	private static Listener _instance;

	private void Awake()
	{
		base.gameObject.name = GetType().ToString();
		_instance = this;
	}

	public static void syncShotReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message1.text == string.Empty)
		{
			_instance.message1.text = @string;
		}
		else if (_instance.message2.text == string.Empty)
		{
			_instance.message2.text = @string;
		}
		else if (_instance.message3.text == string.Empty)
		{
			_instance.message3.text = @string;
		}
	}

	public static void syncReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message4.text == string.Empty)
		{
			_instance.message4.text = @string;
		}
		else if (_instance.message5.text == string.Empty)
		{
			_instance.message5.text = @string;
		}
	}

	public static void syncSimpleShotReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message6.text == string.Empty)
		{
			_instance.message6.text = @string;
		}
		else if (_instance.message7.text == string.Empty)
		{
			_instance.message7.text = @string;
		}
		else if (_instance.message8.text == string.Empty)
		{
			_instance.message8.text = @string;
		}
	}

	public static void zombieSyncReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message9.text == string.Empty)
		{
			_instance.message9.text = @string;
		}
		else if (_instance.message10.text == string.Empty)
		{
			_instance.message10.text = @string;
		}
		else if (_instance.message11.text == string.Empty)
		{
			_instance.message11.text = @string;
		}
	}

	public static void syncExplosionReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message12.text == string.Empty)
		{
			_instance.message12.text = @string;
		}
		else if (_instance.message13.text == string.Empty)
		{
			_instance.message13.text = @string;
		}
	}

	public static void syncZombieAttackReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message14.text == string.Empty)
		{
			_instance.message14.text = @string;
		}
		else if (_instance.message15.text == string.Empty)
		{
			_instance.message15.text = @string;
		}
		else if (_instance.message16.text == string.Empty)
		{
			_instance.message16.text = @string;
		}
		else if (_instance.message17.text == string.Empty)
		{
			_instance.message17.text = @string;
		}
		else if (_instance.message18.text == string.Empty)
		{
			_instance.message18.text = @string;
		}
		else if (_instance.message19.text == string.Empty)
		{
			_instance.message19.text = @string;
		}
		else if (_instance.message20.text == string.Empty)
		{
			_instance.message20.text = @string;
		}
	}

	public static void spawnSyncReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message21.text == string.Empty)
		{
			_instance.message21.text = @string;
		}
		else if (_instance.message22.text == string.Empty)
		{
			_instance.message22.text = @string;
		}
		else if (_instance.message23.text == string.Empty)
		{
			_instance.message23.text = @string;
		}
	}

	public static void syncBuildingsReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		_instance.message24.text = @string;
	}

	public static void syncAlleysReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		_instance.message25.text = @string;
	}

	public static void syncClutterReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		_instance.message26.text = @string;
	}

	public static void syncDestructiblesReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		_instance.message27.text = @string;
	}

	public static void syncPickupReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message28.text == string.Empty)
		{
			_instance.message28.text = @string;
		}
		else if (_instance.message29.text == string.Empty)
		{
			_instance.message29.text = @string;
		}
		else if (_instance.message30.text == string.Empty)
		{
			_instance.message30.text = @string;
		}
		else if (_instance.message31.text == string.Empty)
		{
			_instance.message31.text = @string;
		}
	}

	public static void despawnPickupReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message32.text == string.Empty)
		{
			_instance.message32.text = @string;
		}
		else if (_instance.message33.text == string.Empty)
		{
			_instance.message33.text = @string;
		}
		else if (_instance.message34.text == string.Empty)
		{
			_instance.message34.text = @string;
		}
	}

	public static void killWeaponLoopReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message35.text == string.Empty)
		{
			_instance.message35.text = @string;
		}
		else if (_instance.message36.text == string.Empty)
		{
			_instance.message36.text = @string;
		}
	}

	public static void syncSpitReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message37.text == string.Empty)
		{
			_instance.message37.text = @string;
		}
		else if (_instance.message38.text == string.Empty)
		{
			_instance.message38.text = @string;
		}
		else if (_instance.message39.text == string.Empty)
		{
			_instance.message39.text = @string;
		}
	}

	public static void syncDetonateReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message40.text == string.Empty)
		{
			_instance.message40.text = @string;
		}
		else if (_instance.message41.text == string.Empty)
		{
			_instance.message41.text = @string;
		}
	}

	public static void changeOwnershipReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message42.text == string.Empty)
		{
			_instance.message42.text = @string;
		}
		else if (_instance.message43.text == string.Empty)
		{
			_instance.message43.text = @string;
		}
		else if (_instance.message44.text == string.Empty)
		{
			_instance.message44.text = @string;
		}
		else if (_instance.message45.text == string.Empty)
		{
			_instance.message45.text = @string;
		}
	}

	public static void dieReciever(byte[] bytes)
	{
		_instance.message46.text = "dienow";
	}

	public static void spawnHelicopterReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		_instance.message47.text = @string;
	}

	public static void grabHelicopterReciever(byte[] bytes)
	{
		_instance.message48.text = "grabnow";
	}

	public static void learnAllyScoreReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		_instance.message49.text = @string;
	}

	public static void enterVehicleReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		_instance.message50.text = @string;
	}

	public static void syncVehicularManslaughterReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		if (_instance.message51.text == string.Empty)
		{
			_instance.message51.text = @string;
		}
		else if (_instance.message52.text == string.Empty)
		{
			_instance.message52.text = @string;
		}
		else if (_instance.message53.text == string.Empty)
		{
			_instance.message53.text = @string;
		}
		else if (_instance.message54.text == string.Empty)
		{
			_instance.message54.text = @string;
		}
	}

	public static void explodeVehicleReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		_instance.message55.text = @string;
	}

	public static void placeVehiclesReciever(byte[] bytes)
	{
		string @string = Encoding.UTF8.GetString(bytes);
		_instance.message56.text = @string;
	}
}
