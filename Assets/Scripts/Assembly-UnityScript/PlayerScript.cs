using Boo.Lang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class PlayerScript : MonoBehaviour
{
    [Serializable]
    [CompilerGenerated]
    internal sealed class _0024quitToMenu_00241919 : GenericGenerator<WaitForSeconds>
    {
        [Serializable]
        [CompilerGenerated]
        internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
        {
            internal PlayerScript _0024self__00241920;

            public _0024(PlayerScript self_)
            {
                _0024self__00241920 = self_;
            }

            public override bool MoveNext()
            {
                int result;
                switch (_state)
                {
                    default:
                        Time.timeScale = 1f;
                        if (_0024self__00241920.DB.multiplayer)
                        {
                            _0024self__00241920.motherBrain.disconnect();
                        }
                        _0024self__00241920.motherBrain.fade = true;
                        result = (Yield(2, new WaitForSeconds(1f)) ? 1 : 0);
                        break;
                    case 2:
                        _0024self__00241920.DB.levelToLoad = "mainMenu";
                        Application.LoadLevel("middleman");
                        YieldDefault(1);
                        goto case 1;
                    case 1:
                        result = 0;
                        break;
                }
                return (byte)result != 0;
            }
        }

        internal PlayerScript _0024self__00241921;

        public _0024quitToMenu_00241919(PlayerScript self_)
        {
            _0024self__00241921 = self_;
        }

        public override IEnumerator<WaitForSeconds> GetEnumerator()
        {
            return new _0024(_0024self__00241921);
        }
    }

    [Serializable]
    [CompilerGenerated]
    internal sealed class _0024delayedDamage_00241922 : GenericGenerator<WaitForSeconds>
    {
        [Serializable]
        [CompilerGenerated]
        internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
        {
            internal int _0024i_00241923;

            internal int _0024i2_00241924;

            internal int _0024f_00241925;

            internal PlayerScript _0024self__00241926;

            public _0024(PlayerScript self_)
            {
                _0024self__00241926 = self_;
            }

            public override bool MoveNext()
            {
                int result;
                switch (_state)
                {
                    default:
                        result = (Yield(2, new WaitForSeconds(_0024self__00241926.hitDelay)) ? 1 : 0);
                        break;
                    case 2:
                        _0024self__00241926.hitDelay = 0f;
                        _0024self__00241926.textMessage = string.Empty;
                        if (_0024self__00241926.DB.weapons[_0024self__00241926.weapons[_0024self__00241926.equippedSlot]].hitStyle == "melee")
                        {
                            _0024self__00241926.hitList = Physics.RaycastAll(_0024self__00241926.myTransform.position - new Vector3(0.8f * _0024self__00241926.myTransform.localScale.x, 0f, 0f), new Vector3(_0024self__00241926.myTransform.localScale.x, 0f, 0f), 3f, _0024self__00241926.motherBrain.zombieMask);
                            if (Extensions.get_length(_0024self__00241926.hitList) != 0)
                            {
                                _0024self__00241926.motherBrain.hits = _0024self__00241926.motherBrain.hits + 1;
                                for (_0024i_00241923 = 0; _0024i_00241923 < Extensions.get_length(_0024self__00241926.hitList); _0024i_00241923++)
                                {
                                    _0024self__00241926.tempTransform = _0024self__00241926.hitList[_0024i_00241923].transform;
                                    _0024self__00241926.tempFloat = _0024self__00241926.weaponDamage(_0024self__00241926.tempTransform);
                                    _0024self__00241926.tempZombieScript = (ZombieScript)_0024self__00241926.tempTransform.GetComponent(typeof(ZombieScript));
                                    _0024self__00241926.tempZombieScript.takeDamage(_0024self__00241926.tempFloat, _0024self__00241926.DB.weapons[_0024self__00241926.weapons[_0024self__00241926.equippedSlot]].damageType, (_0024self__00241926.tempZombieScript.myTransform.position - _0024self__00241926.myTransform.position).normalized * _0024self__00241926.weaponForce(_0024self__00241926.equippedSlot, _0024self__00241926.myTransform.position, _0024self__00241926.tempTransform), _0024self__00241926.motherBrain.playerScript);
                                    if (_0024self__00241926.tempZombieScript.health <= 0 && _0024self__00241926.tempZombieScript.zombieType != EnemyType.Container)
                                    {
                                        if (!(_0024self__00241926.DB.achievements[9].counter >= (float)_0024self__00241926.DB.achievements[9].threshold))
                                        {
                                            _0024self__00241926.DB.achievements[9].counter = _0024self__00241926.DB.achievements[9].counter + 1f;
                                            if (_0024self__00241926.DB.achievements[9].counter == (float)_0024self__00241926.DB.achievements[9].threshold)
                                            {
                                                _0024self__00241926.DB.announceAchievement(9);
                                            }
                                        }
                                        for (_0024i2_00241924 = 0; _0024i2_00241924 < 3; _0024i2_00241924++)
                                        {
                                            if (_0024self__00241926.perks[_0024i2_00241924] == 20)
                                            {
                                                _0024self__00241926.health += _0024self__00241926.DB.perks[20].rankBonuses[_0024self__00241926.perkRanks[_0024i2_00241924]];
                                                for (_0024f_00241925 = 0; _0024f_00241925 < Extensions.get_length(_0024self__00241926.myRenderers); _0024f_00241925++)
                                                {
                                                    _0024self__00241926.myRenderers[_0024f_00241925].material.color = new Color(1f, 1f, 1f);
                                                }
                                                _0024self__00241926.colorSpeed = 1f;
                                                _0024self__00241926.activateColors();
                                                _0024self__00241926.berzerkerSpeed = 4f;
                                                _0024self__00241926.berzerkerSpeedMod = 1.3f + (float)_0024self__00241926.perkRanks[_0024i2_00241924] * 0.1f;
                                            }
                                        }
                                    }
                                    _0024self__00241926.myEffects[_0024self__00241926.equippedSlot].hitEffect(_0024self__00241926.tempZombieScript);
                                    if (_0024self__00241926.tempZombieScript.zombieType != EnemyType.Container)
                                    {
                                        _0024self__00241926.motherBrain.spawnBloodSpurt(_0024self__00241926.tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (_0024self__00241926.tempZombieScript.myTransform.position - _0024self__00241926.myTransform.position).normalized * 3f, UnityEngine.Random.Range(1, 3));
                                    }
                                    _0024self__00241926.mySounds[_0024self__00241926.equippedSlot].hit();
                                    if (_0024self__00241926.DB.multiplayer)
                                    {
                                        if (_0024self__00241926.textMessage == string.Empty)
                                        {
                                            _0024self__00241926.textMessage = _0024self__00241926.tempFloat + " " + _0024self__00241926.tempTransform.name;
                                        }
                                        else
                                        {
                                            _0024self__00241926.textMessage = _0024self__00241926.textMessage + " " + _0024self__00241926.tempFloat + " " + _0024self__00241926.tempTransform.name;
                                        }
                                    }
                                }
                            }
                        }
                        if (_0024self__00241926.textMessage != string.Empty)
                        {
                            _0024self__00241926.broadcast("Ally", "syncSimpleShot", _0024self__00241926.textMessage, true);
                        }
                        YieldDefault(1);
                        goto case 1;
                    case 1:
                        result = 0;
                        break;
                }
                return (byte)result != 0;
            }
        }

        internal PlayerScript _0024self__00241927;

        public _0024delayedDamage_00241922(PlayerScript self_)
        {
            _0024self__00241927 = self_;
        }

        public override IEnumerator<WaitForSeconds> GetEnumerator()
        {
            return new _0024(_0024self__00241927);
        }
    }

    [Serializable]
    [CompilerGenerated]
    internal sealed class _0024die_00241928 : GenericGenerator<WaitForSeconds>
    {
        [Serializable]
        [CompilerGenerated]
        internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
        {
            internal PlayerScript _0024self__00241929;

            public _0024(PlayerScript self_)
            {
                _0024self__00241929 = self_;
            }

            public override bool MoveNext()
            {
                int result;
                switch (_state)
                {
                    default:
                        if (_0024self__00241929.DB.multiplayer && !_0024self__00241929.ally)
                        {
                            _0024self__00241929.broadcast("Ally", "die", "dienow", true);
                        }
                        _0024self__00241929.health = 0f;
                        _0024self__00241929.alive = false;
                        _0024self__00241929.myAnimation.Stop();
                        _0024self__00241929.myAnimation.Play("death");
                        _0024self__00241929.killWeaponLoop(string.Empty);
                        _0024self__00241929.myEffects[_0024self__00241929.equippedSlot].laserSight(false);
                        _0024self__00241929.mySounds[_0024self__00241929.equippedSlot].idleLoop(false);
                        _0024self__00241929.motherBrain.spawnHeadExplosion(_0024self__00241929.myTransform.position + new Vector3(0f, 1f, 0f), new Vector3(0f, 0f, 0f));
                        _0024self__00241929.motherBrain.sounds[1].Play();
                        if (!_0024self__00241929.ally)
                        {
                            _0024self__00241929.motherBrain.explodedHead.parent = _0024self__00241929.myTorso;
                            _0024self__00241929.motherBrain.explodedHead.localPosition = new Vector3(0f, 0f, 0f);
                            _0024self__00241929.motherBrain.explodedHead.localEulerAngles = new Vector3(0f, 0f, 0f);
                        }
                        else if (_0024self__00241929.ally)
                        {
                            _0024self__00241929.motherBrain.explodedHeadAlly.parent = _0024self__00241929.myTorso;
                            _0024self__00241929.motherBrain.explodedHeadAlly.localPosition = new Vector3(0f, 0f, 0f);
                            _0024self__00241929.motherBrain.explodedHeadAlly.localEulerAngles = new Vector3(0f, 0f, 0f);
                        }
                        result = (Yield(2, new WaitForSeconds(0.55f)) ? 1 : 0);
                        break;
                    case 2:
                        _0024self__00241929.motherBrain.sounds[2].Play();
                        YieldDefault(1);
                        goto case 1;
                    case 1:
                        result = 0;
                        break;
                }
                return (byte)result != 0;
            }
        }

        internal PlayerScript _0024self__00241930;

        public _0024die_00241928(PlayerScript self_)
        {
            _0024self__00241930 = self_;
        }

        public override IEnumerator<WaitForSeconds> GetEnumerator()
        {
            return new _0024(_0024self__00241930);
        }
    }

    [Serializable]
    [CompilerGenerated]
    internal sealed class _0024gainPickup_00241931 : GenericGenerator<WaitForSeconds>
    {
        [Serializable]
        [CompilerGenerated]
        internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
        {
            internal int _0024f_00241932;

            internal int _0024i_00241933;

            internal int _0024whichPickup_00241934;

            internal PlayerScript _0024self__00241935;

            public _0024(int whichPickup, PlayerScript self_)
            {
                _0024whichPickup_00241934 = whichPickup;
                _0024self__00241935 = self_;
            }

            public override bool MoveNext()
            {
                int result;
                switch (_state)
                {
                    default:
                        if (_0024self__00241935.ammo[_0024self__00241935.equippedSlot] == 0 && _0024self__00241935.DB.weapons[_0024self__00241935.weapons[_0024self__00241935.equippedSlot]].hitStyle == "rocket" && (_0024self__00241935.motherBrain.pickups[_0024whichPickup_00241934].pickupValue == PickupValue.ammo1 || _0024self__00241935.motherBrain.pickups[_0024whichPickup_00241934].pickupValue == PickupValue.ammo2 || _0024self__00241935.motherBrain.pickups[_0024whichPickup_00241934].pickupValue == PickupValue.ammo3))
                        {
                            _0024self__00241935.reloadTimer = 0.3f;
                        }
                        if (!(_0024self__00241935.DB.achievements[29].counter >= (float)_0024self__00241935.DB.achievements[29].threshold))
                        {
                            _0024self__00241935.DB.achievements[29].counter = _0024self__00241935.DB.achievements[29].counter + 1f;
                            if (_0024self__00241935.DB.achievements[29].counter == (float)_0024self__00241935.DB.achievements[29].threshold)
                            {
                                _0024self__00241935.DB.announceAchievement(29);
                            }
                        }
                        for (_0024f_00241932 = 0; _0024f_00241932 < Extensions.get_length(_0024self__00241935.myRenderers); _0024f_00241932++)
                        {
                            _0024self__00241935.myRenderers[_0024f_00241932].material.color = new Color(0.7f, 0.7f, 0.5f);
                        }
                        _0024self__00241935.colorSpeed = 3f;
                        _0024self__00241935.activateColors();
                        if (!_0024self__00241935.ally)
                        {
                            if (_0024self__00241935.motherBrain.pickups[_0024whichPickup_00241934].pickupValue == PickupValue.cash1)
                            {
                                _0024self__00241935.motherBrain.cashThisRound = _0024self__00241935.motherBrain.cashThisRound + 1f;
                            }
                            else if (_0024self__00241935.motherBrain.pickups[_0024whichPickup_00241934].pickupValue == PickupValue.cash2)
                            {
                                _0024self__00241935.motherBrain.cashThisRound = _0024self__00241935.motherBrain.cashThisRound + 2f;
                            }
                            else if (_0024self__00241935.motherBrain.pickups[_0024whichPickup_00241934].pickupValue == PickupValue.cash3)
                            {
                                _0024self__00241935.motherBrain.cashThisRound = _0024self__00241935.motherBrain.cashThisRound + 3f;
                            }
                            else if (_0024self__00241935.motherBrain.pickups[_0024whichPickup_00241934].pickupValue == PickupValue.ammo1)
                            {
                                for (_0024i_00241933 = 0; _0024i_00241933 < 3; _0024i_00241933++)
                                {
                                    _0024self__00241935.ammo[_0024i_00241933] = (int)((float)_0024self__00241935.ammo[_0024i_00241933] + (float)_0024self__00241935.maxAmmo[_0024i_00241933] * 0.2f);
                                    if (_0024self__00241935.ammo[_0024i_00241933] > _0024self__00241935.maxAmmo[_0024i_00241933])
                                    {
                                        _0024self__00241935.ammo[_0024i_00241933] = _0024self__00241935.maxAmmo[_0024i_00241933];
                                    }
                                }
                                _0024self__00241935.motherBrain.updateCurrentAmmo(_0024self__00241935.ammo[_0024self__00241935.equippedSlot]);
                            }
                            else if (_0024self__00241935.motherBrain.pickups[_0024whichPickup_00241934].pickupValue == PickupValue.ammo2)
                            {
                                for (_0024i_00241933 = 0; _0024i_00241933 < 3; _0024i_00241933++)
                                {
                                    _0024self__00241935.ammo[_0024i_00241933] = (int)((float)_0024self__00241935.ammo[_0024i_00241933] + (float)_0024self__00241935.maxAmmo[_0024i_00241933] * 0.4f);
                                    if (_0024self__00241935.ammo[_0024i_00241933] > _0024self__00241935.maxAmmo[_0024i_00241933])
                                    {
                                        _0024self__00241935.ammo[_0024i_00241933] = _0024self__00241935.maxAmmo[_0024i_00241933];
                                    }
                                }
                                _0024self__00241935.motherBrain.updateCurrentAmmo(_0024self__00241935.ammo[_0024self__00241935.equippedSlot]);
                            }
                            else if (_0024self__00241935.motherBrain.pickups[_0024whichPickup_00241934].pickupValue == PickupValue.ammo3)
                            {
                                for (_0024i_00241933 = 0; _0024i_00241933 < 3; _0024i_00241933++)
                                {
                                    _0024self__00241935.ammo[_0024i_00241933] = (int)((float)_0024self__00241935.ammo[_0024i_00241933] + (float)_0024self__00241935.maxAmmo[_0024i_00241933] * 0.6f);
                                    if (_0024self__00241935.ammo[_0024i_00241933] > _0024self__00241935.maxAmmo[_0024i_00241933])
                                    {
                                        _0024self__00241935.ammo[_0024i_00241933] = _0024self__00241935.maxAmmo[_0024i_00241933];
                                    }
                                }
                                _0024self__00241935.motherBrain.updateCurrentAmmo(_0024self__00241935.ammo[_0024self__00241935.equippedSlot]);
                            }
                        }
                        result = (Yield(2, new WaitForSeconds(0.13f)) ? 1 : 0);
                        break;
                    case 2:
                        for (_0024f_00241932 = 0; _0024f_00241932 < Extensions.get_length(_0024self__00241935.myRenderers); _0024f_00241932++)
                        {
                            _0024self__00241935.myRenderers[_0024f_00241932].material.color = new Color(0.7f, 0.7f, 0.5f);
                        }
                        _0024self__00241935.colorSpeed = 3f;
                        _0024self__00241935.activateColors();
                        YieldDefault(1);
                        goto case 1;
                    case 1:
                        result = 0;
                        break;
                }
                return (byte)result != 0;
            }
        }

        internal int _0024whichPickup_00241936;

        internal PlayerScript _0024self__00241937;

        public _0024gainPickup_00241931(int whichPickup, PlayerScript self_)
        {
            _0024whichPickup_00241936 = whichPickup;
            _0024self__00241937 = self_;
        }

        public override IEnumerator<WaitForSeconds> GetEnumerator()
        {
            return new _0024(_0024whichPickup_00241936, _0024self__00241937);
        }
    }

    [Serializable]
    [CompilerGenerated]
    internal sealed class _0024grabHelicopter_00241938 : GenericGenerator<WaitForSeconds>
    {
        [Serializable]
        [CompilerGenerated]
        internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
        {
            internal PlayerScript _0024self__00241939;

            public _0024(PlayerScript self_)
            {
                _0024self__00241939 = self_;
            }

            public override bool MoveNext()
            {
                int result;
                switch (_state)
                {
                    default:
                        if (_0024self__00241939.DB.multiplayer && !_0024self__00241939.ally)
                        {
                            _0024self__00241939.broadcast("Ally", "grabHelicopter", "n", true);
                        }
                        if (_0024self__00241939.DB.tutorial)
                        {
                            _0024self__00241939.motherBrain.showBubble(-1);
                        }
                        _0024self__00241939.lerpTowardsLadder = true;
                        _0024self__00241939.mySounds[_0024self__00241939.equippedSlot].endLoop();
                        _0024self__00241939.StartCoroutine(_0024self__00241939.myEffects[_0024self__00241939.equippedSlot].endLoop());
                        _0024self__00241939.myEffects[_0024self__00241939.equippedSlot].laserSight(false);
                        _0024self__00241939.mySounds[_0024self__00241939.equippedSlot].idleLoop(false);
                        _0024self__00241939.invincible = true;
                        _0024self__00241939.alive = false;
                        _0024self__00241939.myAnimation.Play("escape");
                        result = (Yield(2, new WaitForSeconds(0.6f)) ? 1 : 0);
                        break;
                    case 2:
                        _0024self__00241939.lerpTowardsLadder = false;
                        _0024self__00241939.myTransform.parent = _0024self__00241939.motherBrain.heliAttachPoint;
                        YieldDefault(1);
                        goto case 1;
                    case 1:
                        result = 0;
                        break;
                }
                return (byte)result != 0;
            }
        }

        internal PlayerScript _0024self__00241940;

        public _0024grabHelicopter_00241938(PlayerScript self_)
        {
            _0024self__00241940 = self_;
        }

        public override IEnumerator<WaitForSeconds> GetEnumerator()
        {
            return new _0024(_0024self__00241940);
        }
    }

    public bool alive;

    public bool invincible;

    public Transform myTorso;

    public bool female;

    public bool foregroundAlwaysVisible;

    public MotherBrain motherBrain;

    public Database DB;

    public LayerMask HUDmask;

    public Renderer[] weaponIcons;

    public int[] weapons;

    public int[] maxAmmo;

    public int[] ammo;

    public int[] perks;

    public int[] perkRanks;

    public int ammoInfo;

    public float maxHealth;

    public float health;

    public float moveSpeed;

    public Transform myTransform;

    public Renderer[] myRenderers;

    public Renderer[] weaponRenderers;

    public Transform[] weaponRockets;

    public explosive[] myExplosives;

    public SoundMachine[] mySounds;

    public EffectMachine[] myEffects;

    public Animation myAnimation;

    public Transform pistolSocket;

    public Transform meleeSocket;

    public Transform shotgunSocket;

    public Transform dualSocket;

    public Transform torsoSocket;

    public string idleAnim;

    public string runAnim;

    public string fireAnim;

    public string runningFireAnim;

    public string equipAnim;

    public string aimLoopAnim;

    public AnimationState fireState;

    public AnimationState altFireState;

    public AnimationState runningFireState;

    public AnimationState equipState;

    public AnimationState runState;

    public AnimationState aimState;

    public AnimationState dropState;

    public bool ally;

    public int playerState;

    public int animSet;

    public int equippedSlot;

    public float movementLockout;

    private float rateOfFire;

    private float shotCooldown;

    private GameObject tempGO;

    private Transform tempTransform;

    private Vector3 tempVector;

    private string textMessage;

    private float stateSyncDelay;

    public Vector3 positionMagnet;

    private float timeSinceLastSync;

    private float speedMod;

    private float speedModTimer;

    private float weaponSpeedMod;

    private float defaultRunSpeed;

    private bool dualWieldToggle;

    private bool aimingLockout;

    private float laserDelay;

    private float reloadTimer;

    private float minigunSpin;

    private float minigunSpinTimer;

    public Vector3 movementTarget;

    private float berzerkerSpeed;

    private float berzerkerSpeedMod;

    public string[] weaponNames;

    public string[] weaponModels;

    public int[] animSets;

    public bool[] DWstatus;

    public string[] explosiveModels;

    public float[] movementPenalties;

    public float[] impactForces;

    public float[] impactFalloffs;

    public int[] shellTypes;

    public bool paused;

    private Touch touch;

    private Ray tempRay;

    private RaycastHit tempHit;

    private Vector3 movementVector;

    private int fireButton1;

    private bool fireReset1;

    private int fireButton2;

    private bool fireReset2;

    private int fireButton3;

    private bool fireReset3;

    private bool stickReset;

    private float equipDelay;

    private bool pauseScreenReleased;

    private float proximityPulse;

    public Vector3 slideVector;

    private int flipCommand;

    private ZombieScript tempZombieScript;

    private string hitMessage;

    private float tempFloat;

    private RaycastHit[] hitList;

    private float hitDelay;

    public bool[] singleMinded;

    public bool redAnim;

    public bool greenAnim;

    public bool blueAnim;

    private float colorSpeed;

    private bool lerpTowardsLadder;

    public int myVehicle;

    public bool inVehicle;

    public PlayerScript()
    {
        alive = true;
        weaponIcons = new Renderer[3];
        weapons = new int[3];
        maxAmmo = new int[3];
        ammo = new int[3];
        perks = new int[3];
        perkRanks = new int[3];
        speedMod = 1f;
        weaponSpeedMod = 1f;
        defaultRunSpeed = 2.5f;
        dualWieldToggle = true;
        berzerkerSpeedMod = 1f;
        weaponNames = new string[3];
        weaponModels = new string[3];
        animSets = new int[3];
        DWstatus = new bool[3];
        explosiveModels = new string[3];
        movementPenalties = new float[3];
        impactForces = new float[3];
        impactFalloffs = new float[3];
        shellTypes = new int[3];
        fireReset1 = true;
        fireReset2 = true;
        fireReset3 = true;
        stickReset = true;
        pauseScreenReleased = true;
        proximityPulse = 0.5f;
        singleMinded = new bool[3];
        colorSpeed = 5f;
        myVehicle = -1;
    }

    public virtual void Initialize()
    {
        motherBrain = (MotherBrain)GameObject.Find("**MOTHERBRAIN").GetComponent(typeof(MotherBrain));
        if ((bool)GameObject.Find("**DATABASE"))
        {
            DB = (Database)GameObject.Find("**DATABASE").GetComponent(typeof(Database));
        }
        else
        {
            DB = (Database)GameObject.Find("**DATABASE_Sandbox").GetComponent(typeof(Database));
        }
        for (int i = 0; i < 3; i++)
        {
            weapons[i] = (int)DB.PCs[DB.myPC].weapons[i];
            if (weapons[i] != 99)
            {
                maxAmmo[i] = DB.weapons[weapons[i]].maxAmmo;
                ammo[i] = maxAmmo[i];
            }
            perks[i] = (int)DB.PCs[DB.myPC].perks[i];
            if (perks[i] != 99)
            {
                perkRanks[i] = (int)DB.perks[perks[i]].rank;
            }
        }
        maxHealth = DB.PCs[DB.myPC].maxHealth;
        if (perks[0] == 12 || perks[1] == 12 || perks[2] == 12)
        {
            for (int i = 0; i < 3; i++)
            {
                if (maxAmmo[i] != -1)
                {
                    maxAmmo[i] = (int)((float)maxAmmo[i] * ((DB.perks[12].rankBonuses[(int)DB.perks[12].rank] + 100f) / 100f));
                    ammo[i] = maxAmmo[i];
                }
            }
        }
        if (perks[0] == 11 || perks[1] == 11 || perks[2] == 11)
        {
            maxHealth += DB.perks[11].rankBonuses[(int)DB.perks[11].rank];
        }
        health = maxHealth;
        moveSpeed = DB.PCs[DB.myPC].moveSpeed;
        if (perks[0] == 9 || perks[1] == 9 || perks[2] == 9)
        {
            moveSpeed += DB.perks[9].rankBonuses[(int)DB.perks[9].rank];
        }
        myTransform = transform;
        myTorso = myTransform.Find("MayaFile/torso");
        myAnimation = (Animation)myTransform.Find("MayaFile").GetComponent(typeof(Animation));
        myRenderers[0] = (Renderer)myTransform.Find("MayaFile/primaryGeo").GetComponent(typeof(Renderer));
        myRenderers[1] = (Renderer)myTransform.Find("MayaFile/rightArmGeo").GetComponent(typeof(Renderer));
        myRenderers[2] = (Renderer)myTransform.Find("MayaFile/leftArmGeo").GetComponent(typeof(Renderer));
        pistolSocket = myTransform.Find("MayaFile/leftArm/leftHand_gun");
        meleeSocket = myTransform.Find("MayaFile/leftArm/leftHand_melee");
        shotgunSocket = myTransform.Find("MayaFile/rightArm_shotty");
        dualSocket = myTransform.Find("MayaFile/rightArm_dual/dualWieldGrip");
        torsoSocket = myTransform.Find("MayaFile/torso");
        instantiateWeaponry();
        animLayerSetup();
        if (DB.multiplayer && DB.whichPlayerAmI == 1)
        {
            float x = -4.5f;
            Vector3 position = myTransform.position;
            float num = (position.x = x);
            Vector3 vector2 = (myTransform.position = position);
            float z = 0.4f;
            Vector3 position2 = myTransform.position;
            float num2 = (position2.z = z);
            Vector3 vector4 = (myTransform.position = position2);
        }
        else if (DB.multiplayer && DB.whichPlayerAmI == 2)
        {
            float x2 = -5.5f;
            Vector3 position3 = myTransform.position;
            float num3 = (position3.x = x2);
            Vector3 vector6 = (myTransform.position = position3);
            float z2 = -0.4f;
            Vector3 position4 = myTransform.position;
            float num4 = (position4.z = z2);
            Vector3 vector8 = (myTransform.position = position4);
        }
        else if (!DB.multiplayer)
        {
            int num5 = -5;
            Vector3 position5 = myTransform.position;
            float num6 = (position5.x = num5);
            Vector3 vector10 = (myTransform.position = position5);
        }
        movementTarget = myTransform.position + new Vector3(4f, 0f, 0f);
        equip(0, true);
        myTransform.name = "LocalPlayer";
        int num7 = 0;
        int num8 = 0;
        int num9 = 0;
        if (DWstatus[0])
        {
            num7 = 1;
        }
        if (DWstatus[1])
        {
            num8 = 1;
        }
        if (DWstatus[2])
        {
            num9 = 1;
        }
        if (!DB.soundEnabled)
        {
            if ((bool)mySounds[0])
            {
                mySounds[0].muted = true;
            }
            if ((bool)mySounds[1])
            {
                mySounds[1].muted = true;
            }
            if ((bool)mySounds[2])
            {
                mySounds[2].muted = true;
            }
        }
        if (DB.multiplayer)
        {
            textMessage = DB.myPC + " " + weapons[0] + " " + weapons[1] + " " + weapons[2] + " " + maxHealth + " " + moveSpeed + " " + perks[0] + " " + perks[1] + " " + perks[2] + " " + perkRanks[0] + " " + perkRanks[1] + " " + perkRanks[2] + " " + myTransform.position.x + " " + myTransform.position.z + " " + weaponNames[0] + " " + weaponNames[1] + " " + weaponNames[2] + " " + weaponModels[0] + " " + weaponModels[1] + " " + weaponModels[2] + " " + animSets[0] + " " + animSets[1] + " " + animSets[2] + " " + explosiveModels[0] + " " + explosiveModels[1] + " " + explosiveModels[2] + " " + num7 + " " + num8 + " " + num9 + " " + movementPenalties[0] + " " + movementPenalties[1] + " " + movementPenalties[2] + " " + impactForces[0] + " " + impactForces[1] + " " + impactForces[2] + " " + impactFalloffs[0] + " " + impactFalloffs[1] + " " + impactFalloffs[2] + " " + shellTypes[0] + " " + shellTypes[1] + " " + shellTypes[2];
            broadcast("**MOTHERBRAIN", "spawnOtherPlayer", textMessage, true);
        }
    }

    public virtual void AllyInitialize()
    {
        ally = true;
        motherBrain = (MotherBrain)GameObject.Find("**MOTHERBRAIN").GetComponent(typeof(MotherBrain));
        if ((bool)GameObject.Find("**DATABASE"))
        {
            DB = (Database)GameObject.Find("**DATABASE").GetComponent(typeof(Database));
        }
        else
        {
            DB = (Database)GameObject.Find("**DATABASE_Sandbox").GetComponent(typeof(Database));
        }
        myTransform = transform;
        myAnimation = (Animation)myTransform.Find("MayaFile").GetComponent(typeof(Animation));
        myRenderers[0] = (Renderer)myTransform.Find("MayaFile/primaryGeo").GetComponent(typeof(Renderer));
        myRenderers[1] = (Renderer)myTransform.Find("MayaFile/rightArmGeo").GetComponent(typeof(Renderer));
        myRenderers[2] = (Renderer)myTransform.Find("MayaFile/leftArmGeo").GetComponent(typeof(Renderer));
        pistolSocket = myTransform.Find("MayaFile/leftArm/leftHand_gun");
        meleeSocket = myTransform.Find("MayaFile/leftArm/leftHand_melee");
        shotgunSocket = myTransform.Find("MayaFile/rightArm_shotty");
        dualSocket = myTransform.Find("MayaFile/rightArm_dual/dualWieldGrip");
        torsoSocket = myTransform.Find("MayaFile/torso");
        instantiateWeaponry();
        if (!DB.soundEnabled)
        {
            if ((bool)mySounds[0])
            {
                mySounds[0].muted = true;
            }
            if ((bool)mySounds[1])
            {
                mySounds[1].muted = true;
            }
            if ((bool)mySounds[2])
            {
                mySounds[2].muted = true;
            }
        }
        animLayerSetup();
        equip(0, true);
        myTransform.name = "Ally";
    }

    public virtual void animLayerSetup()
    {
        myAnimation["pistol_runningFire"].layer = 1;
        myAnimation["pistol_runningFire"].blendMode = AnimationBlendMode.Additive;
        myAnimation["magnum_runningFire"].layer = 1;
        myAnimation["magnum_runningFire"].blendMode = AnimationBlendMode.Additive;
        myAnimation["magnum_fire"].layer = 1;
        myAnimation["magnum_fire"].blendMode = AnimationBlendMode.Additive;
        myAnimation["dual_runningFire"].layer = 1;
        myAnimation["dual_runningFire"].blendMode = AnimationBlendMode.Additive;
        myAnimation["dual_runningFire_alt"].layer = 1;
        myAnimation["dual_runningFire_alt"].blendMode = AnimationBlendMode.Additive;
        myAnimation["shotty_runningFire"].layer = 1;
        myAnimation["shotty_runningFire"].blendMode = AnimationBlendMode.Additive;
        myAnimation["shotty_fire"].layer = 1;
        myAnimation["shotty_fire"].blendMode = AnimationBlendMode.Additive;
        myAnimation["rifle_runningFire"].layer = 1;
        myAnimation["rifle_runningFire"].blendMode = AnimationBlendMode.Additive;
        myAnimation["flamer_runningFire"].layer = 1;
        myAnimation["flamer_runningFire"].blendMode = AnimationBlendMode.Additive;
        myAnimation["minigun_runningFire"].layer = 1;
        myAnimation["minigun_runningFire"].blendMode = AnimationBlendMode.Additive;
        myAnimation["grenade_runningFire"].layer = 1;
        myAnimation["grenade_runningFire"].blendMode = AnimationBlendMode.Additive;
        myAnimation["grenade_fire"].layer = 1;
        myAnimation["grenade_fire"].blendMode = AnimationBlendMode.Additive;
        myAnimation["rpg_reload"].layer = 1;
        myAnimation["rpg_reload"].blendMode = AnimationBlendMode.Additive;
        myAnimation["pistol_equip"].layer = 1;
        myAnimation["pistol_equip"].blendMode = AnimationBlendMode.Additive;
        myAnimation["dual_equip"].layer = 1;
        myAnimation["dual_equip"].blendMode = AnimationBlendMode.Additive;
        myAnimation["bat_equip"].layer = 1;
        myAnimation["bat_equip"].blendMode = AnimationBlendMode.Additive;
        myAnimation["shotty_equip"].layer = 1;
        myAnimation["shotty_equip"].blendMode = AnimationBlendMode.Additive;
        myAnimation["sniper_equip"].layer = 1;
        myAnimation["sniper_equip"].blendMode = AnimationBlendMode.Additive;
        myAnimation["sniper_drop"].layer = 1;
        myAnimation["sniper_drop"].blendMode = AnimationBlendMode.Additive;
        myAnimation["rifle_equip"].layer = 1;
        myAnimation["rifle_equip"].blendMode = AnimationBlendMode.Additive;
        myAnimation["flamer_equip"].layer = 1;
        myAnimation["flamer_equip"].blendMode = AnimationBlendMode.Additive;
        myAnimation["grenade_equip"].layer = 1;
        myAnimation["grenade_equip"].blendMode = AnimationBlendMode.Additive;
        myAnimation["minigun_equip"].layer = 1;
        myAnimation["minigun_equip"].blendMode = AnimationBlendMode.Additive;
        myAnimation["chainsaw_equip"].layer = 1;
        myAnimation["chainsaw_equip"].blendMode = AnimationBlendMode.Additive;
        myAnimation["chainsaw_lower"].layer = 1;
        myAnimation["chainsaw_lower"].blendMode = AnimationBlendMode.Additive;
        myAnimation["hitReact"].layer = 4;
        myAnimation["hitReact"].blendMode = AnimationBlendMode.Additive;
        if (female)
        {
            myAnimation["female_overlay"].layer = 3;
            myAnimation["female_overlay"].blendMode = AnimationBlendMode.Additive;
            myAnimation.Play("female_overlay");
        }
    }

    public virtual void instantiateWeaponry()
    {
        if (!ally)
        {
            for (int i = 0; i < 3; i++)
            {
                if (weapons[i] != 99)
                {
                    weaponNames[i] = DB.weapons[weapons[i]].weaponName;
                    weaponModels[i] = DB.weapons[weapons[i]].weaponModel;
                    animSets[i] = DB.weapons[weapons[i]].animSet;
                    DWstatus[i] = DB.weapons[weapons[i]].dualWield;
                    explosiveModels[i] = DB.weapons[weapons[i]].explosiveModel;
                    movementPenalties[i] = DB.weapons[weapons[i]].movementPenalty;
                    impactForces[i] = DB.weapons[weapons[i]].impactForce;
                    impactFalloffs[i] = DB.weapons[weapons[i]].impactFalloff;
                    shellTypes[i] = DB.weapons[weapons[i]].shellType;
                }
            }
        }
        for (int i = 0; i < Extensions.get_length(weapons); i++)
        {
            if (weapons[i] == 99)
            {
                continue;
            }
            tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(weaponModels[i]));
            tempTransform = tempGO.transform;
            if (animSets[i] == 0 || animSets[i] == 3 || animSets[i] == 8 || animSets[i] == 11)
            {
                tempTransform.parent = pistolSocket;
                tempTransform.localScale = new Vector3(1f, 1f, 1f);
                tempTransform.localPosition = new Vector3(0f, 0f, 0f);
            }
            else if (animSets[i] == 1 || animSets[i] == 4 || animSets[i] == 5 || animSets[i] == 6 || animSets[i] == 9 || animSets[i] == 10 || animSets[i] == 12 || animSets[i] == 13)
            {
                tempTransform.parent = shotgunSocket;
                tempTransform.localScale = new Vector3(1f, 1f, 1f);
                tempTransform.localPosition = new Vector3(0f, 0f, 0f);
            }
            else if (animSets[i] == 2 || animSets[i] == 7)
            {
                tempTransform.parent = meleeSocket;
                tempTransform.localScale = new Vector3(1f, 1f, 1f);
                tempTransform.localPosition = new Vector3(0f, 0f, 0f);
            }
            weaponRenderers[i] = (Renderer)tempGO.GetComponent(typeof(Renderer));
            if (weaponRenderers[i] == null)
            {
                weaponRenderers[i] = (Renderer)tempGO.transform.Find("geometry").GetComponent(typeof(Renderer));
                weaponRockets[i] = tempGO.transform.Find("handle/rocket");
            }
            if (DWstatus[i] || animSets[i] == 4 || animSets[i] == 10 || animSets[i] == 13)
            {
                tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(weaponModels[i]));
                tempTransform = tempGO.transform;
                tempTransform.parent = dualSocket;
                tempTransform.localScale = new Vector3(1f, 1f, 1f);
                tempTransform.localPosition = new Vector3(0f, 0f, 0f);
                weaponRenderers[i + 3] = (Renderer)tempGO.GetComponent(typeof(Renderer));
            }
            if (DB.weapons[weapons[i]].backpack)
            {
                tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(weaponModels[i] + "BP"));
                tempTransform = tempGO.transform;
                tempTransform.parent = torsoSocket;
                tempTransform.localScale = new Vector3(1f, 1f, 1f);
                tempTransform.localPosition = new Vector3(0f, 0f, 0f);
                weaponRenderers[i + 6] = (Renderer)tempGO.GetComponent(typeof(Renderer));
            }
            tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Sounds/" + weaponNames[i]));
            mySounds[i] = (SoundMachine)tempGO.GetComponent(typeof(SoundMachine));
            tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Effects/" + weaponNames[i]));
            myEffects[i] = (EffectMachine)tempGO.GetComponent(typeof(EffectMachine));
            myEffects[i].myOwner = myTransform;
            if (explosiveModels[i] != string.Empty)
            {
                for (int j = 0; j < Extensions.get_length(myExplosives[i].tran); j++)
                {
                    tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(explosiveModels[i]));
                    myExplosives[i].tran[j] = tempGO.transform;
                    myExplosives[i].anim[j] = tempGO.GetComponent<Animation>();
                }
            }
            if (!ally)
            {
                tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Weapons_CornerIcons/" + weaponNames[i]));
                tempGO.transform.parent = motherBrain.weaponIconSlot;
                tempGO.transform.localPosition = new Vector3(0f, 0f, 0f);
                tempGO.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
                tempGO.transform.localScale = new Vector3(1f, 1f, 1f);
                weaponIcons[i] = tempGO.GetComponent<Renderer>();
            }
        }
    }

    public virtual void RemoteUpdate()
    {
        if (motherBrain.introSequence)
        {
            introSequence();
            CharacterAnimation();
            return;
        }
        if (paused)
        {
            pauseScreen();
        }
        else if (!ally && alive && !paused)
        {
            PlayerInput();
        }
        else if (ally && flipCommand != 0)
        {
            int num = flipCommand;
            Vector3 localScale = myTransform.localScale;
            float num2 = (localScale.x = num);
            Vector3 vector2 = (myTransform.localScale = localScale);
            flipCommand = 0;
        }
        if (alive)
        {
            CharacterAnimation();
        }
        if (lerpTowardsLadder)
        {
            ladderAnimation();
        }
        slidingAnimation();
        shaderAnimation();
        if (DB.multiplayer && !ally && !aimingLockout && alive)
        {
            stateSyncDelay -= Time.deltaTime;
            if (!(stateSyncDelay > 0f))
            {
                stateSyncDelay = motherBrain.stateSyncDelay;
                sendSync();
            }
        }
    }

    public virtual void pauseScreen()
    {
        if (Input.touchCount == 0 && !Input.GetButton("Pause"))
        {
            pauseScreenReleased = true;
        }
        else if (Input.touchCount != 0 && pauseScreenReleased && !motherBrain.fade)
        {
            touch = Input.GetTouch(0);
            tempRay = motherBrain.cameraLens.ScreenPointToRay(touch.position);
            if (Physics.Raycast(tempRay, out tempHit, 100f, motherBrain.pauseScreenMask))
            {
                tempTransform = tempHit.transform;
                if (tempTransform.name == "resume")
                {
                    motherBrain.sounds[5].Play();
                    if (!DB.multiplayer)
                    {
                        Time.timeScale = 1f;
                    }
                    paused = false;
                    int num = -20;
                    Vector3 localPosition = motherBrain.pauseScreenTran.localPosition;
                    float num2 = (localPosition.y = num);
                    Vector3 vector2 = (motherBrain.pauseScreenTran.localPosition = localPosition);
                }
                else if (tempTransform.name == "quit")
                {
                    motherBrain.sounds[5].Play();
                    StartCoroutine(quitToMenu());
                }
            }
        }
        if ((Input.GetButtonDown("Pause") && pauseScreenReleased && !motherBrain.fade) || (Input.GetButtonDown("Fire2") && pauseScreenReleased && !motherBrain.fade))
        {
            motherBrain.sounds[5].Play();
            if (!DB.multiplayer)
            {
                Time.timeScale = 1f;
            }
            paused = false;
            int num3 = -20;
            Vector3 localPosition2 = motherBrain.pauseScreenTran.localPosition;
            float num4 = (localPosition2.y = num3);
            Vector3 vector4 = (motherBrain.pauseScreenTran.localPosition = localPosition2);
        }
        else if (Input.GetButtonDown("Fire3") && pauseScreenReleased && !motherBrain.fade)
        {
            motherBrain.sounds[5].Play();
            StartCoroutine(quitToMenu());
        }
    }

    public virtual IEnumerator quitToMenu()
    {
        return new _0024quitToMenu_00241919(this).GetEnumerator();
    }

    public virtual void PlayerInput()
    {
        if (!(berzerkerSpeed <= 0f))
        {
            berzerkerSpeed -= Time.deltaTime;
            if (!(berzerkerSpeed > 0f))
            {
                berzerkerSpeedMod = 1f;
            }
        }
        if (!(DB.achievements[13].counter >= (float)DB.achievements[13].threshold))
        {
            DB.achievements[13].counter = DB.achievements[13].counter + Time.deltaTime;
            if (!(DB.achievements[13].counter < (float)DB.achievements[13].threshold))
            {
                DB.achievements[13].counter = DB.achievements[13].threshold;
                if (!DB.achievements[13].reported)
                {
                    DB.announceAchievement(13);
                }
            }
        }
        if (!(equipDelay <= 0f))
        {
            equipDelay -= Time.deltaTime;
            if (!(equipDelay > 0f))
            {
                if (fireButton1 == 2 && DB.weapons[weapons[equippedSlot]].automatic)
                {
                    fireButton1 = 0;
                }
                else if (fireButton2 == 2 && DB.weapons[weapons[equippedSlot]].automatic)
                {
                    fireButton2 = 0;
                }
                else if (fireButton3 == 2 && DB.weapons[weapons[equippedSlot]].automatic)
                {
                    fireButton3 = 0;
                }
            }
        }
        if (!(movementLockout <= 0f))
        {
            movementLockout -= Time.deltaTime;
        }
        fireReset1 = true;
        fireReset2 = true;
        fireReset3 = true;
        stickReset = true;
        motherBrain.buttonLights[0].enabled = false;
        motherBrain.buttonLights[1].enabled = false;
        motherBrain.buttonLights[2].enabled = false;
        motherBrain.buttonLights[3].enabled = false;
        shotCooldown -= Time.deltaTime;
        if (inVehicle && !(movementLockout > 0f))
        {
            movementVector = new Vector3(1f, 0f, 0f);
        }
        if (Input.touchCount != 0)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                touch = Input.GetTouch(i);
                tempRay = motherBrain.cameraLens.ScreenPointToRay(touch.position);
                if (!Physics.Raycast(tempRay, out tempHit, 100f, HUDmask))
                {
                    continue;
                }
                tempTransform = tempHit.transform;
                if (tempTransform.name == "joystick" && !(movementLockout > 0f) && !aimingLockout)
                {
                    if (DB.tutorial && motherBrain.currentBubble == 1 && !motherBrain.joyStickTouched)
                    {
                        motherBrain.joyStickTouched = true;
                        motherBrain.tutorialTimer = 0f;
                    }
                    stickReset = false;
                    Vector3 vector = new Vector3(touch.position.x, touch.position.y, 0f) - motherBrain.cameraLens.WorldToScreenPoint(motherBrain.joystickCenter.position);
                    if (inVehicle)
                    {
                        movementVector = new Vector3(1f, 0f, vector.y).normalized;
                    }
                    else
                    {
                        movementVector = new Vector3(vector.x, 0f, vector.y).normalized;
                    }
                }
                else if (tempTransform.name == "fire1" && !inVehicle)
                {
                    if (DB.tutorial && motherBrain.currentBubble == 2 && !motherBrain.fireButtonsTouched)
                    {
                        motherBrain.fireButtonsTouched = true;
                        motherBrain.tutorialTimer = 0f;
                    }
                    motherBrain.buttonLights[1].enabled = true;
                    fireReset1 = false;
                    if (!aimingLockout && !(movementLockout > 0f) && fireButton2 == 0 && fireButton3 == 0)
                    {
                        if (equippedSlot != 0)
                        {
                            fireButton1 = 2;
                            equip(0, false);
                        }
                        else if (fireButton1 == 0 || (DB.weapons[weapons[equippedSlot]].automatic && fireButton1 != 2))
                        {
                            fireButton1 = 1;
                            attack(true);
                        }
                    }
                }
                else if (tempTransform.name == "fire2" && !inVehicle)
                {
                    motherBrain.buttonLights[2].enabled = true;
                    if (DB.tutorial && motherBrain.currentBubble == 2 && !motherBrain.fireButtonsTouched)
                    {
                        motherBrain.fireButtonsTouched = true;
                        motherBrain.tutorialTimer = 0f;
                    }
                    fireReset2 = false;
                    if (!aimingLockout && !(movementLockout > 0f) && fireButton1 == 0 && fireButton3 == 0)
                    {
                        if (equippedSlot != 1)
                        {
                            fireButton2 = 2;
                            equip(1, false);
                        }
                        else if (fireButton2 == 0 || (DB.weapons[weapons[equippedSlot]].automatic && fireButton2 != 2))
                        {
                            fireButton2 = 1;
                            attack(true);
                        }
                    }
                }
                else if (tempTransform.name == "fire3" && !inVehicle)
                {
                    motherBrain.buttonLights[3].enabled = true;
                    if (DB.tutorial && motherBrain.currentBubble == 2 && !motherBrain.fireButtonsTouched)
                    {
                        motherBrain.fireButtonsTouched = true;
                        motherBrain.tutorialTimer = 0f;
                    }
                    fireReset3 = false;
                    if (!aimingLockout && !(movementLockout > 0f) && fireButton1 == 0 && fireButton2 == 0)
                    {
                        if (equippedSlot != 2)
                        {
                            fireButton3 = 2;
                            equip(2, false);
                        }
                        else if (fireButton3 == 0 || (DB.weapons[weapons[equippedSlot]].automatic && fireButton3 != 2))
                        {
                            fireButton3 = 1;
                            attack(true);
                        }
                    }
                }
                else if (tempTransform.name == "Clock" && !paused)
                {
                    paused = true;
                    motherBrain.sounds[5].Play();
                    pauseScreenReleased = false;
                    int num = 0;
                    Vector3 localPosition = motherBrain.pauseScreenTran.localPosition;
                    float num2 = (localPosition.y = num);
                    Vector3 vector3 = (motherBrain.pauseScreenTran.localPosition = localPosition);
                    if (!DB.multiplayer)
                    {
                        Time.timeScale = 0f;
                    }
                }
                if (tempTransform.name == "joystick")
                {
                    motherBrain.buttonLights[0].enabled = true;
                    Vector3 vector = new Vector3(touch.position.x, touch.position.y, 0f) - motherBrain.cameraLens.WorldToScreenPoint(motherBrain.joystickCenter.position);
                    Vector3 normalized = new Vector3(vector.x, 0f, vector.y).normalized;
                    motherBrain.joystickHelper.rotation = Quaternion.FromToRotation(Vector3.forward, normalized);
                }
            }
        }
        if ((Input.GetAxis("Horizontal") != 0f && !(movementLockout > 0f) && !aimingLockout) || (Input.GetAxis("Vertical") != 0f && !(movementLockout > 0f) && !aimingLockout))
        {
            stickReset = false;
            if (inVehicle)
            {
                movementVector = new Vector3(1f, 0f, Input.GetAxis("Vertical")).normalized;
            }
            else
            {
                movementVector = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")).normalized;
            }
            motherBrain.joystickHelper.rotation = Quaternion.FromToRotation(Vector3.forward, movementVector);
            motherBrain.buttonLights[0].enabled = true;
            if (DB.tutorial && motherBrain.currentBubble == 1 && !motherBrain.joyStickTouched)
            {
                motherBrain.joyStickTouched = true;
                motherBrain.tutorialTimer = 0f;
            }
        }
        if (Input.GetButton("Fire1") && !inVehicle)
        {
            if (DB.tutorial && motherBrain.currentBubble == 2 && !motherBrain.fireButtonsTouched)
            {
                motherBrain.fireButtonsTouched = true;
                motherBrain.tutorialTimer = 0f;
            }
            motherBrain.buttonLights[1].enabled = true;
            fireReset1 = false;
            if (!aimingLockout && !(movementLockout > 0f) && fireButton2 == 0 && fireButton3 == 0)
            {
                if (equippedSlot != 0)
                {
                    fireButton1 = 2;
                    equip(0, false);
                }
                else if (fireButton1 == 0 || (DB.weapons[weapons[equippedSlot]].automatic && fireButton1 != 2))
                {
                    fireButton1 = 1;
                    attack(true);
                }
            }
        }
        if (Input.GetButton("Fire2") && !inVehicle)
        {
            if (DB.tutorial && motherBrain.currentBubble == 2 && !motherBrain.fireButtonsTouched)
            {
                motherBrain.fireButtonsTouched = true;
                motherBrain.tutorialTimer = 0f;
            }
            motherBrain.buttonLights[2].enabled = true;
            fireReset2 = false;
            if (!aimingLockout && !(movementLockout > 0f) && fireButton1 == 0 && fireButton3 == 0)
            {
                if (equippedSlot != 1)
                {
                    fireButton2 = 2;
                    equip(1, false);
                }
                else if (fireButton2 == 0 || (DB.weapons[weapons[equippedSlot]].automatic && fireButton2 != 2))
                {
                    fireButton2 = 1;
                    attack(true);
                }
            }
        }
        if (Input.GetButton("Fire3") && !inVehicle)
        {
            if (DB.tutorial && motherBrain.currentBubble == 2 && !motherBrain.fireButtonsTouched)
            {
                motherBrain.fireButtonsTouched = true;
                motherBrain.tutorialTimer = 0f;
            }
            motherBrain.buttonLights[3].enabled = true;
            fireReset3 = false;
            if (!aimingLockout && !(movementLockout > 0f) && fireButton1 == 0 && fireButton2 == 0)
            {
                if (equippedSlot != 2)
                {
                    fireButton3 = 2;
                    equip(2, false);
                }
                else if (fireButton3 == 0 || (DB.weapons[weapons[equippedSlot]].automatic && fireButton3 != 2))
                {
                    fireButton3 = 1;
                    attack(true);
                }
            }
        }
        if (Input.GetButtonDown("Pause") && !paused)
        {
            paused = true;
            motherBrain.sounds[5].Play();
            pauseScreenReleased = false;
            int num3 = 0;
            Vector3 localPosition2 = motherBrain.pauseScreenTran.localPosition;
            float num4 = (localPosition2.y = num3);
            Vector3 vector5 = (motherBrain.pauseScreenTran.localPosition = localPosition2);
            if (!DB.multiplayer)
            {
                Time.timeScale = 0f;
            }
        }
        if (fireReset1)
        {
            if (fireButton1 != 0 && aimingLockout)
            {
                aimRelease(false);
            }
            if (fireButton1 == 1 && equippedSlot == 0)
            {
                killWeaponLoop(string.Empty);
            }
            fireButton1 = 0;
        }
        if (fireReset2)
        {
            if (fireButton2 != 0 && aimingLockout)
            {
                aimRelease(false);
            }
            if (fireButton2 == 1 && equippedSlot == 1)
            {
                killWeaponLoop(string.Empty);
            }
            fireButton2 = 0;
        }
        if (fireReset3)
        {
            if (fireButton3 != 0 && aimingLockout)
            {
                aimRelease(false);
            }
            if (fireButton3 == 1 && equippedSlot == 2)
            {
                killWeaponLoop(string.Empty);
            }
            fireButton3 = 0;
        }
        if (stickReset)
        {
            movementVector = new Vector3(0f, 0f, 0f);
        }
        int num5 = 0;
        Vector3 localEulerAngles = motherBrain.joystickHelper.localEulerAngles;
        float num6 = (localEulerAngles.x = num5);
        Vector3 vector7 = (motherBrain.joystickHelper.localEulerAngles = localEulerAngles);
        int num7 = 0;
        Vector3 localEulerAngles2 = motherBrain.joystickHelper.localEulerAngles;
        float num8 = (localEulerAngles2.z = num7);
        Vector3 vector9 = (motherBrain.joystickHelper.localEulerAngles = localEulerAngles2);
        motherBrain.joystickLerp.rotation = Quaternion.Lerp(motherBrain.joystickLerp.rotation, motherBrain.joystickHelper.rotation, 14f * Time.deltaTime);
        float y = motherBrain.joystickLerp.localEulerAngles.y;
        Vector3 localEulerAngles3 = motherBrain.joystickRotator.localEulerAngles;
        float num9 = (localEulerAngles3.z = y);
        Vector3 vector11 = (motherBrain.joystickRotator.localEulerAngles = localEulerAngles3);
        if (inVehicle && !(movementLockout > 0f))
        {
            movementVector.x = 3.5f;
            movementVector.z *= 4f;
        }
        else
        {
            movementVector *= speedMod;
            movementVector *= weaponSpeedMod;
            if (!(berzerkerSpeed <= 0f))
            {
                movementVector *= berzerkerSpeedMod;
            }
        }
        float num10 = 0f;
        int num11 = 0;
        int num12 = 0;
        int num13 = 0;
        bool flag = false;
        if (!(proximityPulse <= 0f))
        {
            proximityPulse -= Time.deltaTime;
        }
        for (int i = 0; i < Extensions.get_length(myExplosives); i++)
        {
            for (int j = 0; j < Extensions.get_length(myExplosives[i].life); j++)
            {
                if (weapons[i] < 0 || myExplosives[i].life[j] <= 0f)
                {
                    continue;
                }
                if (!(myExplosives[i].life[j] >= 100f))
                {
                    myExplosives[i].life[j] = myExplosives[i].life[j] - Time.deltaTime;
                    if (DB.weapons[weapons[i]].explosiveMotion != 0f)
                    {
                        float x = myExplosives[i].tran[j].position.x + DB.weapons[weapons[i]].explosiveMotion * Time.deltaTime * myExplosives[i].tran[j].localScale.x;
                        Vector3 position = myExplosives[i].tran[j].position;
                        float num14 = (position.x = x);
                        Vector3 vector13 = (myExplosives[i].tran[j].position = position);
                        if ((!(myExplosives[i].tran[j].position.x < myExplosives[i].explosionPoint[j]) && myExplosives[i].tran[j].localScale.x == 1f) || (!(myExplosives[i].tran[j].position.x > myExplosives[i].explosionPoint[j]) && myExplosives[i].tran[j].localScale.x == -1f))
                        {
                            float x2 = myExplosives[i].explosionPoint[j];
                            Vector3 position2 = myExplosives[i].tran[j].position;
                            float num15 = (position2.x = x2);
                            Vector3 vector15 = (myExplosives[i].tran[j].position = position2);
                            myExplosives[i].life[j] = 0f;
                        }
                    }
                    if (myExplosives[i].life[j] > 0f)
                    {
                        continue;
                    }
                    myEffects[i].explode(myExplosives[i].tran[j].position);
                    if (DB.weapons[weapons[i]].damageType == 3)
                    {
                        motherBrain.spawnExplosiveAsh(myExplosives[i].tran[j].position + new Vector3(0f, 0.2f, -0.2f));
                        motherBrain.cameraShaker.Stop();
                        motherBrain.cameraShaker.Play("shake");
                    }
                    mySounds[i].hit();
                    if (DB.multiplayer)
                    {
                        textMessage = i + " " + j + " " + Mathf.Round(myExplosives[i].tran[j].position.x * 100f) / 100f + " " + Mathf.Round(myExplosives[i].tran[j].position.z * 100f) / 100f;
                    }
                    num10 = 0f;
                    num11 = 0;
                    int num16 = 0;
                    int num17 = 0;
                    for (num12 = 0; num12 < Extensions.get_length(motherBrain.zombies); num12++)
                    {
                        if (!motherBrain.zombies[num12] || motherBrain.zombies[num12].health <= 0 || Vector3.Distance(motherBrain.zombies[num12].myTransform.position, myExplosives[i].tran[j].position) >= DB.weapons[weapons[i]].explosiveRadius)
                        {
                            continue;
                        }
                        num10 = Mathf.Clamp(DB.weapons[weapons[i]].damage - Vector3.Distance(motherBrain.zombies[num12].myTransform.position, myExplosives[i].tran[j].position) * DB.weapons[weapons[i]].damageFalloff, 0f, 10000f);
                        num11 = ((DB.weapons[weapons[i]].damageType == 4) ? 4 : ((DB.weapons[weapons[i]].damageType == 5) ? 5 : ((!(Vector3.Distance(motherBrain.zombies[num12].myTransform.position, myExplosives[i].tran[j].position) >= DB.weapons[weapons[i]].explosiveRadius * 0.5f)) ? 3 : 0)));
                        motherBrain.zombies[num12].takeDamage(num10, num11, (motherBrain.zombies[num12].myTransform.position - myExplosives[i].tran[j].position).normalized * weaponForce(i, myExplosives[i].tran[j].position, motherBrain.zombies[num12].myTransform), motherBrain.playerScript);
                        flag = true;
                        if (motherBrain.zombies[num12].health <= 0 && DB.weapons[weapons[i]].weaponName == "RPG" && motherBrain.zombies[num12].zombieType != EnemyType.Container)
                        {
                            num16++;
                            if (num16 == 5 && DB.achievements[4].counter != (float)DB.achievements[4].threshold)
                            {
                                DB.achievements[4].counter = DB.achievements[4].threshold;
                                DB.announceAchievement(4);
                            }
                        }
                        if (DB.weapons[weapons[i]].weaponName == "Cryogun")
                        {
                            num17++;
                            if (num17 == 5 && DB.achievements[22].counter != (float)DB.achievements[22].threshold)
                            {
                                DB.achievements[22].counter = DB.achievements[22].threshold;
                                DB.announceAchievement(22);
                            }
                        }
                        if (motherBrain.zombies[num12].health <= 0 && motherBrain.zombies[num12].zombieType != EnemyType.Container && !(DB.achievements[19].counter >= (float)DB.achievements[19].threshold) && (DB.weapons[weapons[i]].weaponName == "RPG" || DB.weapons[weapons[i]].weaponName == "Grenade"))
                        {
                            DB.achievements[19].counter = DB.achievements[19].counter + 1f;
                            if (DB.achievements[19].counter == (float)DB.achievements[19].threshold)
                            {
                                DB.announceAchievement(19);
                            }
                        }
                        if (DB.multiplayer)
                        {
                            textMessage = textMessage + " " + num10 + " " + motherBrain.zombies[num12].myTransform.name;
                        }
                    }
                    if (DB.multiplayer)
                    {
                        broadcast("Ally", "syncExplosion", textMessage, true);
                    }
                    int num18 = 100;
                    Vector3 position3 = myExplosives[i].tran[j].position;
                    float num19 = (position3.y = num18);
                    Vector3 vector17 = (myExplosives[i].tran[j].position = position3);
                }
                else if (!(myExplosives[i].life[j] <= 100f) && !(myExplosives[i].life[j] >= 200f))
                {
                    myExplosives[i].life[j] = myExplosives[i].life[j] - Time.deltaTime;
                    if (!(myExplosives[i].life[j] > 100f))
                    {
                        myExplosives[i].life[j] = 100f;
                    }
                }
                else if (myExplosives[i].life[j] == 100f && !(proximityPulse > 0f))
                {
                    bool flag2 = false;
                    for (int k = 0; k < Extensions.get_length(motherBrain.zombies); k++)
                    {
                        if ((bool)motherBrain.zombies[k] && !(Vector3.Distance(motherBrain.zombies[k].myTransform.position, myExplosives[i].tran[j].position) >= 1.2f) && motherBrain.zombies[k].health > 0)
                        {
                            flag2 = true;
                        }
                    }
                    if (!(myExplosives[i].tran[j].position.x > motherBrain.characterHorizontalBounds.x - 1f))
                    {
                        int num20 = 100;
                        Vector3 position4 = myExplosives[i].tran[j].position;
                        float num21 = (position4.y = num20);
                        Vector3 vector19 = (myExplosives[i].tran[j].position = position4);
                        myExplosives[i].life[j] = 0f;
                    }
                    if (!flag2)
                    {
                        continue;
                    }
                    myEffects[i].explode(myExplosives[i].tran[j].position);
                    motherBrain.spawnExplosiveAsh(myExplosives[i].tran[j].position + new Vector3(0f, 0.2f, -0.2f));
                    mySounds[i].hit();
                    motherBrain.cameraShaker.Stop();
                    motherBrain.cameraShaker.Play("shake");
                    if (DB.multiplayer)
                    {
                        textMessage = i + " " + j + " " + Mathf.Round(myExplosives[i].tran[j].position.x * 100f) / 100f + " " + Mathf.Round(myExplosives[i].tran[j].position.z * 100f) / 100f;
                    }
                    num10 = 0f;
                    num11 = 0;
                    for (num12 = 0; num12 < Extensions.get_length(motherBrain.zombies); num12++)
                    {
                        if (!motherBrain.zombies[num12] || motherBrain.zombies[num12].health <= 0 || Vector3.Distance(motherBrain.zombies[num12].myTransform.position, myExplosives[i].tran[j].position) >= DB.weapons[weapons[i]].explosiveRadius)
                        {
                            continue;
                        }
                        num10 = Mathf.Clamp(DB.weapons[weapons[i]].damage - Vector3.Distance(motherBrain.zombies[num12].myTransform.position, myExplosives[i].tran[j].position) * DB.weapons[weapons[i]].damageFalloff, 0f, 10000f);
                        num11 = 0;
                        if (!(Vector3.Distance(motherBrain.zombies[num12].myTransform.position, myExplosives[i].tran[j].position) >= DB.weapons[weapons[i]].explosiveRadius * 0.5f))
                        {
                            num11 = 3;
                        }
                        motherBrain.zombies[num12].takeDamage(num10, num11, (motherBrain.zombies[num12].myTransform.position - myExplosives[i].tran[j].position).normalized * weaponForce(i, myExplosives[i].tran[j].position, motherBrain.zombies[num12].myTransform), motherBrain.playerScript);
                        if (motherBrain.zombies[num12].health <= 0 && motherBrain.zombies[num12].zombieType != EnemyType.Container && !(DB.achievements[19].counter >= (float)DB.achievements[19].threshold) && DB.weapons[weapons[i]].weaponName == "Landmine")
                        {
                            DB.achievements[19].counter = DB.achievements[19].counter + 1f;
                            if (DB.achievements[19].counter == (float)DB.achievements[19].threshold)
                            {
                                DB.announceAchievement(19);
                            }
                        }
                        flag = true;
                        if (DB.multiplayer)
                        {
                            textMessage = textMessage + " " + num10 + " " + motherBrain.zombies[num12].myTransform.name;
                        }
                    }
                    if (DB.multiplayer)
                    {
                        broadcast("Ally", "syncExplosion", textMessage, true);
                    }
                    int num22 = 100;
                    Vector3 position5 = myExplosives[i].tran[j].position;
                    float num23 = (position5.y = num22);
                    Vector3 vector21 = (myExplosives[i].tran[j].position = position5);
                    myExplosives[i].life[j] = 0f;
                }
                else if (!(myExplosives[i].life[j] <= 200f))
                {
                    myExplosives[i].life[j] = myExplosives[i].life[j] - Time.deltaTime;
                    if (!(myExplosives[i].life[j] > 200f))
                    {
                        myExplosives[i].life[j] = 200f;
                    }
                }
                else
                {
                    if (myExplosives[i].life[j] != 200f || proximityPulse > 0f)
                    {
                        continue;
                    }
                    if (!(myExplosives[i].tran[j].position.x > motherBrain.characterHorizontalBounds.x - 1f))
                    {
                        int num24 = 100;
                        Vector3 position6 = myExplosives[i].tran[j].position;
                        float num25 = (position6.y = num24);
                        Vector3 vector23 = (myExplosives[i].tran[j].position = position6);
                        myExplosives[i].life[j] = 0f;
                    }
                    if (!(Vector3.Distance(myTransform.position, myExplosives[i].tran[j].position) >= 1f))
                    {
                        myEffects[i].heal(myExplosives[i].tran[j].position);
                        mySounds[i].hit();
                        myExplosives[i].life[j] = 0f;
                        health += DB.weapons[weapons[i]].damage;
                        for (num13 = 0; num13 < Extensions.get_length(myRenderers); num13++)
                        {
                            myRenderers[num13].material.color = new Color(1f, 1f, 1f);
                        }
                        flag = true;
                        colorSpeed = 1f;
                        activateColors();
                        if (DB.multiplayer)
                        {
                            textMessage = i + " " + j + " " + Mathf.Round(myExplosives[i].tran[j].position.x * 100f) / 100f + " " + Mathf.Round(myExplosives[i].tran[j].position.z * 100f) / 100f + " self";
                            broadcast("Ally", "syncHeal", textMessage, true);
                        }
                        int num26 = 100;
                        Vector3 position7 = myExplosives[i].tran[j].position;
                        float num27 = (position7.y = num26);
                        Vector3 vector25 = (myExplosives[i].tran[j].position = position7);
                    }
                    else if ((bool)motherBrain.allyScript && !(Vector3.Distance(motherBrain.allyScript.myTransform.position, myExplosives[i].tran[j].position) >= 1f))
                    {
                        if (DB.achievements[20].counter != (float)DB.achievements[20].threshold && !(motherBrain.allyScript.health / motherBrain.allyScript.maxHealth > 0.2f))
                        {
                            DB.achievements[20].counter = DB.achievements[20].threshold;
                            DB.announceAchievement(20);
                        }
                        myEffects[i].heal(myExplosives[i].tran[j].position);
                        mySounds[i].hit();
                        myExplosives[i].life[j] = 0f;
                        motherBrain.allyScript.health = motherBrain.allyScript.health + DB.weapons[weapons[i]].damage;
                        for (num13 = 0; num13 < Extensions.get_length(motherBrain.allyScript.myRenderers); num13++)
                        {
                            motherBrain.allyScript.myRenderers[num13].material.color = new Color(1f, 1f, 1f);
                        }
                        flag = true;
                        motherBrain.allyScript.colorSpeed = 1f;
                        motherBrain.allyScript.activateColors();
                        if (DB.multiplayer)
                        {
                            textMessage = i + " " + j + " " + Mathf.Round(myExplosives[i].tran[j].position.x * 100f) / 100f + " " + Mathf.Round(myExplosives[i].tran[j].position.z * 100f) / 100f + " ally";
                            broadcast("Ally", "syncHeal", textMessage, true);
                        }
                        int num28 = 100;
                        Vector3 position8 = myExplosives[i].tran[j].position;
                        float num29 = (position8.y = num28);
                        Vector3 vector27 = (myExplosives[i].tran[j].position = position8);
                    }
                }
            }
        }
        if (!(proximityPulse > 0f))
        {
            proximityPulse = 0.2f;
        }
        textMessage = string.Empty;
        if (inVehicle && !(movementLockout > 0f))
        {
            for (num12 = 0; num12 < Extensions.get_length(motherBrain.zombies); num12++)
            {
                if (!motherBrain.zombies[num12] || motherBrain.zombies[num12].health <= 0 || Vector3.Distance(motherBrain.zombies[num12].myTransform.position, myTransform.position) >= 2f)
                {
                    continue;
                }
                num10 = 10000f;
                num11 = 3;
                motherBrain.zombies[num12].takeDamage(num10, num11, (motherBrain.zombies[num12].myTransform.position - myTransform.position).normalized * 40f, motherBrain.playerScript);
                if (DB.multiplayer)
                {
                    if (textMessage == string.Empty)
                    {
                        textMessage = motherBrain.zombies[num12].myTransform.name;
                    }
                    else
                    {
                        textMessage = textMessage + " " + motherBrain.zombies[num12].myTransform.name;
                    }
                }
            }
            if (DB.multiplayer && textMessage != string.Empty)
            {
                broadcast("Ally", "syncVehicularManslaughter", textMessage, true);
            }
        }
        if (flag)
        {
            motherBrain.hits++;
        }
#if UNITY_STANDALONE || UNITY_EDITOR
        if (inVehicle) return;

        // Mouse button fire
        if (Input.GetMouseButton(0) && DB.weapons[weapons[equippedSlot]].automatic)
        {
            motherBrain.fireButtonsTouched = true;
            attack(true);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            motherBrain.fireButtonsTouched = true;
            attack(true);
        }

        // PC controls for weapon switching
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        // Handle mouse scroll input for weapon switching
        if (scroll != 0)
        {
            if (scroll <= -0.1f)
            {
                equippedSlot--;
                if (equippedSlot < 0) equippedSlot = 2;
                equip(equippedSlot, false);
            }
            else if (scroll >= 0.1f)
            {
                equippedSlot++;
                if (equippedSlot > 2) equippedSlot = 0;
                equip(equippedSlot, false);
            }
        }

        // Handle number keys for weapon switching (1, 2, 3)
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            equippedSlot = 0;
            equip(equippedSlot, false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            equippedSlot = 1;
            equip(equippedSlot, false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            equippedSlot = 2;
            equip(equippedSlot, false);
        }
    }
#endif


    public virtual void syncHeal(string incomingData)
    {
        string[] array = incomingData.Split(" "[0]);
        int num = UnityBuiltins.parseInt(array[0]);
        int num2 = UnityBuiltins.parseInt(array[1]);
        Vector3 where = new Vector3(UnityBuiltins.parseFloat(array[2]), 0f, UnityBuiltins.parseFloat(array[3]));
        myEffects[num].heal(where);
        mySounds[num].hit();
        int num3 = 100;
        Vector3 position = myExplosives[num].tran[num2].position;
        float num4 = (position.y = num3);
        Vector3 vector2 = (myExplosives[num].tran[num2].position = position);
        myExplosives[num].life[num2] = 0f;
        int num5 = 0;
        if (array[4] == "self")
        {
            health += DB.weapons[weapons[num]].damage;
            for (num5 = 0; num5 < Extensions.get_length(myRenderers); num5++)
            {
                myRenderers[num5].material.color = new Color(1f, 1f, 1f);
            }
            colorSpeed = 1f;
            activateColors();
        }
        else if (array[4] == "ally")
        {
            motherBrain.playerScript.health = motherBrain.playerScript.health + DB.weapons[weapons[num]].damage;
            for (num5 = 0; num5 < Extensions.get_length(motherBrain.playerScript.myRenderers); num5++)
            {
                motherBrain.playerScript.myRenderers[num5].material.color = new Color(1f, 1f, 1f);
            }
            motherBrain.playerScript.colorSpeed = 1f;
            motherBrain.playerScript.activateColors();
        }
    }

    public virtual void syncExplosion(string incomingData)
    {
        string[] array = incomingData.Split(" "[0]);
        int num = UnityBuiltins.parseInt(array[0]);
        int num2 = UnityBuiltins.parseInt(array[1]);
        Vector3 vector = new Vector3(UnityBuiltins.parseFloat(array[2]), 0f, UnityBuiltins.parseFloat(array[3]));
        myEffects[num].explode(vector);
        if (DB.weapons[weapons[num]].damageType == 3)
        {
            motherBrain.spawnExplosiveAsh(vector + new Vector3(0f, 0.2f, -0.2f));
            motherBrain.cameraShaker.Stop();
            motherBrain.cameraShaker.Play("shake");
        }
        mySounds[num].hit();
        if (num2 != -1)
        {
            int num3 = 100;
            Vector3 position = myExplosives[num].tran[num2].position;
            float num4 = (position.y = num3);
            Vector3 vector3 = (myExplosives[num].tran[num2].position = position);
            myExplosives[num].life[num2] = 0f;
        }
        if (Extensions.get_length(array) > 4)
        {
            int num5 = 0;
            for (int i = 4; i < Extensions.get_length(array); i += 2)
            {
                num5 = ((DB.weapons[weapons[num]].damageType != 4) ? ((DB.weapons[weapons[num]].damageType != 5) ? ((!(Vector3.Distance(motherBrain.zombies[UnityBuiltins.parseInt(array[i + 1])].myTransform.position, vector) >= DB.weapons[weapons[num]].explosiveRadius * 0.5f)) ? 3 : 0) : 5) : 4);
                motherBrain.zombies[UnityBuiltins.parseInt(array[i + 1])].takeDamage(UnityBuiltins.parseFloat(array[i]), num5, (motherBrain.zombies[UnityBuiltins.parseInt(array[i + 1])].myTransform.position - vector).normalized * weaponForce(num, vector, motherBrain.zombies[UnityBuiltins.parseInt(array[i + 1])].myTransform), motherBrain.allyScript);
            }
        }
    }

    public virtual void syncVehicularManslaughter(string incomingData)
    {
        string[] array = incomingData.Split(" "[0]);
        if (Extensions.get_length(array) != 0)
        {
            for (int i = 0; i < Extensions.get_length(array); i++)
            {
                motherBrain.zombies[UnityBuiltins.parseInt(array[i])].takeDamage(100000f, 3, (motherBrain.zombies[UnityBuiltins.parseInt(array[i])].myTransform.position - motherBrain.allyScript.myTransform.position).normalized * 40f, motherBrain.allyScript);
            }
        }
    }

    public virtual void CharacterAnimation()
    {
        int num = 0;
        int num2 = 0;
        if (!(berzerkerSpeed <= 0f))
        {
            berzerkerSpeed -= Time.deltaTime;
            if (!(berzerkerSpeed > 0f))
            {
                berzerkerSpeedMod = 1f;
            }
        }
        if (!(speedModTimer <= 0f))
        {
            speedModTimer -= Time.deltaTime;
        }
        else if (!(speedMod >= 1f))
        {
            speedMod += Time.deltaTime * 4f;
            if (!(speedMod <= 1f))
            {
                speedMod = 1f;
            }
        }
        if (perks[0] == 16)
        {
            health += Time.deltaTime * DB.perks[16].rankBonuses[perkRanks[0]];
        }
        else if (perks[1] == 16)
        {
            health += Time.deltaTime * DB.perks[16].rankBonuses[perkRanks[1]];
        }
        else if (perks[2] == 16)
        {
            health += Time.deltaTime * DB.perks[16].rankBonuses[perkRanks[2]];
        }
        if (!(health <= maxHealth))
        {
            health = maxHealth;
        }
        if (!(laserDelay <= 0f))
        {
            laserDelay -= Time.deltaTime;
            if (!(laserDelay > 0f))
            {
                myEffects[equippedSlot].laserSight(true);
                mySounds[equippedSlot].laser();
                mySounds[equippedSlot].aimLoop(true);
            }
        }
        if (!(minigunSpin <= 0f))
        {
            minigunSpinTimer += Time.deltaTime;
            minigunSpin -= Time.deltaTime;
            if (!(minigunSpinTimer < 0.04f))
            {
                minigunSpinTimer = 0f;
                if (weaponRenderers[equippedSlot].material.mainTextureOffset.x == 0f)
                {
                    float x = 0.5f;
                    Vector2 mainTextureOffset = weaponRenderers[equippedSlot].material.mainTextureOffset;
                    float num3 = (mainTextureOffset.x = x);
                    Vector2 vector2 = (weaponRenderers[equippedSlot].material.mainTextureOffset = mainTextureOffset);
                }
                else if (weaponRenderers[equippedSlot].material.mainTextureOffset.x == 0.5f)
                {
                    int num4 = 0;
                    Vector2 mainTextureOffset2 = weaponRenderers[equippedSlot].material.mainTextureOffset;
                    float num5 = (mainTextureOffset2.x = num4);
                    Vector2 vector4 = (weaponRenderers[equippedSlot].material.mainTextureOffset = mainTextureOffset2);
                }
                if ((bool)weaponRenderers[equippedSlot + 3])
                {
                    float x2 = weaponRenderers[equippedSlot].material.mainTextureOffset.x;
                    Vector2 mainTextureOffset3 = weaponRenderers[equippedSlot + 3].material.mainTextureOffset;
                    float num6 = (mainTextureOffset3.x = x2);
                    Vector2 vector6 = (weaponRenderers[equippedSlot + 3].material.mainTextureOffset = mainTextureOffset3);
                }
            }
            if (!(minigunSpin > 0f) && weaponRenderers[equippedSlot].material.mainTextureOffset.x == 0.5f)
            {
                int num7 = 0;
                Vector2 mainTextureOffset4 = weaponRenderers[equippedSlot].material.mainTextureOffset;
                float num8 = (mainTextureOffset4.x = num7);
                Vector2 vector8 = (weaponRenderers[equippedSlot].material.mainTextureOffset = mainTextureOffset4);
            }
        }
        if (!(reloadTimer <= 0f))
        {
            reloadTimer -= Time.deltaTime;
            if (!(reloadTimer > 0.2f) && ammo[equippedSlot] > 0)
            {
                myAnimation.Play("rpg_reload");
                mySounds[equippedSlot].reload();
            }
            if (!(reloadTimer > 0f) && ammo[equippedSlot] > 0)
            {
                reloadTimer = 0f;
                int num9 = 1;
                Vector3 localScale = weaponRockets[equippedSlot].localScale;
                float num10 = (localScale.x = num9);
                Vector3 vector10 = (weaponRockets[equippedSlot].localScale = localScale);
            }
        }
        if (aimingLockout)
        {
            if (!(aimState.normalizedTime < 0.9f))
            {
                myAnimation.CrossFade(aimLoopAnim, 0.1f);
            }
        }
        else if (playerState == 0 && movementVector == new Vector3(0f, 0f, 0f))
        {
            if (DB.weapons[weapons[equippedSlot]].animSet == 11 && runningFireState.weight == 1f)
            {
                myAnimation.CrossFade("magnum_fireunderlay", 0.1f);
            }
            if (fireState.weight <= 0f || !(DB.weapons[weapons[equippedSlot]].hitStyle == "chainsaw"))
            {
                if (DB.weapons[weapons[equippedSlot]].hitStyle == "chainsaw" && !(runningFireState.weight <= 0f))
                {
                    myAnimation.CrossFade(fireAnim, 0.1f);
                    fireState.weight = 0.1f;
                }
                else if ((fireState.normalizedTime > 0.65f || fireState.weight != 1f) && (altFireState.normalizedTime > 0.65f || altFireState.weight != 1f) && (DB.weapons[weapons[equippedSlot]].animSet != 11 || runningFireState.weight != 1f || runningFireState.normalizedTime > 0.65f))
                {
                    myAnimation.CrossFade(idleAnim, 0.12f);
                }
            }
        }
        else if (playerState == 0 && movementVector != new Vector3(0f, 0f, 0f))
        {
            playerState = 1;
            if (DB.weapons[weapons[equippedSlot]].animSet == 11 && !(fireState.weight <= 0f))
            {
                myAnimation.CrossFade(runningFireAnim, 0.15f);
                runningFireState.normalizedTime = fireState.normalizedTime;
            }
            if (DB.weapons[weapons[equippedSlot]].hitStyle == "chainsaw" && !(fireState.weight <= 0f))
            {
                myAnimation.CrossFade(runningFireAnim, 0.15f);
                runningFireState.weight = 0.1f;
            }
            else
            {
                if (speedMod != 1f && runState.speed != 2.5f)
                {
                    runState.speed = 2.5f;
                }
                else if (runState.speed != normalRunSpeed())
                {
                    runState.speed = normalRunSpeed();
                }
                myAnimation.CrossFade(runAnim, 0.15f);
            }
        }
        else if (playerState == 1 && movementVector == new Vector3(0f, 0f, 0f))
        {
            playerState = 0;
        }
        if (playerState == 1 && movementVector != new Vector3(0f, 0f, 0f))
        {
            if (!(DB.weapons[weapons[equippedSlot]].hitStyle == "chainsaw") || runningFireState.weight <= 0f)
            {
                if (speedMod != 1f && runState.speed == normalRunSpeed())
                {
                    runState.speed *= 3f;
                }
                else if (runState.speed != normalRunSpeed())
                {
                    runState.speed = normalRunSpeed();
                }
                myAnimation.CrossFade(runAnim, 0.15f);
            }
            if (inVehicle)
            {
                myTransform.position += movementVector * Time.deltaTime * 2.5f;
            }
            else
            {
                myTransform.position += movementVector * Time.deltaTime * moveSpeed;
            }
            if (!(movementVector.x <= 0f) && myTransform.localScale.x != 1f)
            {
                int num11 = 1;
                Vector3 localScale2 = myTransform.localScale;
                float num12 = (localScale2.x = num11);
                Vector3 vector12 = (myTransform.localScale = localScale2);
            }
            else if (!(movementVector.x >= 0f) && myTransform.localScale.x != -1f)
            {
                int num13 = -1;
                Vector3 localScale3 = myTransform.localScale;
                float num14 = (localScale3.x = num13);
                Vector3 vector14 = (myTransform.localScale = localScale3);
            }
        }
        if (ally && !motherBrain.introSequence)
        {
            timeSinceLastSync += Time.deltaTime;
            if (movementVector == new Vector3(0f, 0f, 0f))
            {
                myTransform.position = Vector3.Lerp(myTransform.position, positionMagnet, Time.deltaTime * 12f);
            }
            else
            {
                myTransform.position = Vector3.Lerp(myTransform.position, positionMagnet + movementVector * moveSpeed * timeSinceLastSync, Time.deltaTime * 5f);
            }
            for (num = 0; num < Extensions.get_length(myExplosives); num++)
            {
                for (num2 = 0; num2 < Extensions.get_length(myExplosives[num].life); num2++)
                {
                    if (weapons[num] >= 0 && !(myExplosives[num].life[num2] <= 0f) && DB.weapons[weapons[num]].explosiveMotion != 0f)
                    {
                        float x3 = myExplosives[num].tran[num2].position.x + DB.weapons[weapons[num]].explosiveMotion * Time.deltaTime * myExplosives[num].tran[num2].localScale.x;
                        Vector3 position = myExplosives[num].tran[num2].position;
                        float num15 = (position.x = x3);
                        Vector3 vector16 = (myExplosives[num].tran[num2].position = position);
                    }
                }
            }
        }
        if (DB.weapons[weapons[equippedSlot]].hitStyle == "chainsaw")
        {
            runningFireState.speed = runState.speed;
        }
        if (!motherBrain.introSequence)
        {
            if (!(myTransform.position.z <= motherBrain.characterVerticalBounds.x))
            {
                float x4 = motherBrain.characterVerticalBounds.x;
                Vector3 position2 = myTransform.position;
                float num16 = (position2.z = x4);
                Vector3 vector18 = (myTransform.position = position2);
            }
            else if (!(myTransform.position.z >= motherBrain.characterVerticalBounds.y))
            {
                float y = motherBrain.characterVerticalBounds.y;
                Vector3 position3 = myTransform.position;
                float num17 = (position3.z = y);
                Vector3 vector20 = (myTransform.position = position3);
            }
            if (!(myTransform.position.x >= motherBrain.characterHorizontalBounds.x))
            {
                float x5 = motherBrain.characterHorizontalBounds.x;
                Vector3 position4 = myTransform.position;
                float num18 = (position4.x = x5);
                Vector3 vector22 = (myTransform.position = position4);
            }
            else if (!(myTransform.position.x <= motherBrain.worldEnd))
            {
                float worldEnd = motherBrain.worldEnd;
                Vector3 position5 = myTransform.position;
                float num19 = (position5.x = worldEnd);
                Vector3 vector24 = (myTransform.position = position5);
            }
        }
    }

    public virtual void ladderAnimation()
    {
        if ((!ally && DB.whichPlayerAmI == 1) || (ally && DB.whichPlayerAmI == 2))
        {
            myTransform.position = Vector3.Lerp(myTransform.position, motherBrain.helicopterGroup.position + new Vector3(-0.75f, 0f, 0.3f), 5f * Time.deltaTime);
            if (myTransform.localScale.x != 1f && myTransform.parent != motherBrain.heliAttachPoint)
            {
                int num = 1;
                Vector3 localScale = myTransform.localScale;
                float num2 = (localScale.x = num);
                Vector3 vector2 = (myTransform.localScale = localScale);
            }
            return;
        }
        myTransform.position = Vector3.Lerp(myTransform.position, motherBrain.helicopterGroup.position + new Vector3(0.47f, 0f, 0.3f), 5f * Time.deltaTime);
        float z = Mathf.Lerp(myTransform.localEulerAngles.z, 18f, 6f * Time.deltaTime);
        Vector3 localEulerAngles = myTransform.localEulerAngles;
        float num3 = (localEulerAngles.z = z);
        Vector3 vector4 = (myTransform.localEulerAngles = localEulerAngles);
        if (myTransform.localScale.x != -1f && myTransform.parent != motherBrain.heliAttachPoint)
        {
            int num4 = -1;
            Vector3 localScale2 = myTransform.localScale;
            float num5 = (localScale2.x = num4);
            Vector3 vector6 = (myTransform.localScale = localScale2);
        }
    }

    public virtual void slidingAnimation()
    {
        if (!invincible && slideVector != new Vector3(0f, 0f, 0f))
        {
            if (slideVector.y != 0f)
            {
                slideVector.y = 0f;
            }
            myTransform.position += slideVector * Time.deltaTime;
            slideVector = Vector3.Lerp(slideVector, new Vector3(0f, 0f, 0f), Time.deltaTime * 25f);
            if (!(slideVector.x >= 0.005f) && !(slideVector.x <= -0.005f))
            {
                slideVector.x = 0f;
            }
            if (!(slideVector.z >= 0.005f) && !(slideVector.z <= -0.005f))
            {
                slideVector.z = 0f;
            }
            if (!(myTransform.position.z <= motherBrain.characterVerticalBounds.x))
            {
                float x = motherBrain.characterVerticalBounds.x;
                Vector3 position = myTransform.position;
                float num = (position.z = x);
                Vector3 vector2 = (myTransform.position = position);
            }
            else if (!(myTransform.position.z >= motherBrain.characterVerticalBounds.y))
            {
                float y = motherBrain.characterVerticalBounds.y;
                Vector3 position2 = myTransform.position;
                float num2 = (position2.z = y);
                Vector3 vector4 = (myTransform.position = position2);
            }
        }
    }

    public virtual void equip(int whichSlot, bool silent)
    {
        if (weapons[whichSlot] == 99)
        {
            return;
        }
        mySounds[equippedSlot].idleLoop(false);
        equipDelay = 0.24f;
        equippedSlot = whichSlot;
        for (int i = 0; i < Extensions.get_length(weaponRenderers); i++)
        {
            if ((bool)weaponRenderers[i])
            {
                weaponRenderers[i].enabled = false;
                if (weaponRenderers[i].material.mainTextureOffset.x != 0f)
                {
                    int num = 0;
                    Vector2 mainTextureOffset = weaponRenderers[i].material.mainTextureOffset;
                    float num2 = (mainTextureOffset.x = num);
                    Vector2 vector2 = (weaponRenderers[i].material.mainTextureOffset = mainTextureOffset);
                }
            }
        }
        if (!ally)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((bool)weaponIcons[i])
                {
                    weaponIcons[i].enabled = false;
                }
                int num3 = 5;
                Vector3 localPosition = motherBrain.ammoDisplays[i].localPosition;
                float num4 = (localPosition.x = num3);
                Vector3 vector4 = (motherBrain.ammoDisplays[i].localPosition = localPosition);
            }
            weaponIcons[whichSlot].enabled = true;
            if (maxAmmo[whichSlot] >= 100)
            {
                motherBrain.activeAmmoDisplay = 2;
                float x = 1.5f;
                Vector3 localPosition2 = motherBrain.ammoDisplays[2].localPosition;
                float num5 = (localPosition2.x = x);
                Vector3 vector6 = (motherBrain.ammoDisplays[2].localPosition = localPosition2);
            }
            else if (maxAmmo[whichSlot] >= 10)
            {
                motherBrain.activeAmmoDisplay = 1;
                float x2 = 1.5f;
                Vector3 localPosition3 = motherBrain.ammoDisplays[1].localPosition;
                float num6 = (localPosition3.x = x2);
                Vector3 vector8 = (motherBrain.ammoDisplays[1].localPosition = localPosition3);
            }
            else if (maxAmmo[whichSlot] >= 1)
            {
                motherBrain.activeAmmoDisplay = 0;
                float x3 = 1.5f;
                Vector3 localPosition4 = motherBrain.ammoDisplays[0].localPosition;
                float num7 = (localPosition4.x = x3);
                Vector3 vector10 = (motherBrain.ammoDisplays[0].localPosition = localPosition4);
            }
            else if (maxAmmo[whichSlot] == -1)
            {
                motherBrain.activeAmmoDisplay = -1;
            }
            if (maxAmmo[whichSlot] != -1)
            {
                motherBrain.updateMaxAmmo(maxAmmo[equippedSlot]);
                motherBrain.updateCurrentAmmo(ammo[equippedSlot]);
            }
            else
            {
                motherBrain.updateCurrentAmmo(-1);
            }
        }
        weaponRenderers[whichSlot].enabled = true;
        if (weaponRenderers[whichSlot + 3] != null)
        {
            weaponRenderers[whichSlot + 3].enabled = true;
        }
        if (weaponRenderers[whichSlot + 6] != null)
        {
            weaponRenderers[whichSlot + 6].enabled = true;
        }
        weaponSpeedMod = movementPenalties[whichSlot];
        if (!(weaponSpeedMod >= 1f))
        {
            if (perks[0] == 10)
            {
                weaponSpeedMod += DB.perks[10].rankBonuses[perkRanks[0]] * 0.5f;
            }
            else if (perks[1] == 10)
            {
                weaponSpeedMod += DB.perks[10].rankBonuses[perkRanks[1]] * 0.5f;
            }
            else if (perks[2] == 10)
            {
                weaponSpeedMod += DB.perks[10].rankBonuses[perkRanks[2]] * 0.5f;
            }
        }
        animSet = animSets[whichSlot];
        loadAnimSet(animSet);
        myAnimation.Play(idleAnim);
        rateOfFire = DB.weapons[weapons[equippedSlot]].rateOfFire;
        if (!silent)
        {
            myAnimation.Play(equipAnim);
            equipState.normalizedTime = 0.1f;
            motherBrain.sounds[0].Play();
        }
        reloadTimer = 0f;
        minigunSpin = 0f;
        minigunSpinTimer = 0f;
        if ((bool)weaponRockets[equippedSlot] && ammo[equippedSlot] > 0)
        {
            int num8 = 1;
            Vector3 localScale = weaponRockets[equippedSlot].localScale;
            float num9 = (localScale.x = num8);
            Vector3 vector12 = (weaponRockets[equippedSlot].localScale = localScale);
        }
        else if ((bool)weaponRockets[equippedSlot] && ammo[equippedSlot] <= 0)
        {
            int num10 = 0;
            Vector3 localScale2 = weaponRockets[equippedSlot].localScale;
            float num11 = (localScale2.x = num10);
            Vector3 vector14 = (weaponRockets[equippedSlot].localScale = localScale2);
        }
        if (DB.multiplayer && !ally)
        {
            broadcast("Ally", "syncEquip", equippedSlot.ToString(), false);
        }
        mySounds[equippedSlot].idleLoop(true);
    }

    public virtual void syncEquip(string whichSlotString)
    {
        if (motherBrain.introSequence)
        {
            equip(UnityBuiltins.parseInt(whichSlotString), true);
        }
        else
        {
            equip(UnityBuiltins.parseInt(whichSlotString), false);
        }
    }

    public virtual void loadAnimSet(int whichSet)
    {
        switch (whichSet)
        {
            case 0:
                myRenderers[1].enabled = false;
                myRenderers[2].enabled = true;
                idleAnim = "pistol_idle";
                runAnim = "pistol_run";
                fireAnim = "pistol_fire";
                runningFireAnim = "pistol_runningFire";
                equipAnim = "pistol_equip";
                defaultRunSpeed = 2.5f;
                break;
            case 1:
                myRenderers[1].enabled = true;
                myRenderers[2].enabled = true;
                idleAnim = "shotty_idle";
                runAnim = "shotty_run";
                fireAnim = "shotty_fire";
                runningFireAnim = "shotty_runningFire";
                equipAnim = "shotty_equip";
                defaultRunSpeed = 2.5f;
                break;
            case 2:
                myRenderers[1].enabled = false;
                myRenderers[2].enabled = true;
                idleAnim = "bat_idle";
                runAnim = "bat_run";
                fireAnim = "bat_fire";
                runningFireAnim = "bat_fire";
                equipAnim = "bat_equip";
                defaultRunSpeed = 2.5f;
                break;
            case 3:
                myRenderers[1].enabled = true;
                myRenderers[2].enabled = true;
                idleAnim = "dual_idle";
                runAnim = "dual_run";
                fireAnim = "dual_fire";
                runningFireAnim = "dual_runningFire";
                equipAnim = "dual_equip";
                defaultRunSpeed = 2.5f;
                break;
            case 4:
                myRenderers[1].enabled = true;
                myRenderers[2].enabled = true;
                idleAnim = "sniper_idle";
                runAnim = "sniper_run";
                fireAnim = "sniper_fire";
                runningFireAnim = "shotty_runningFire";
                equipAnim = "sniper_equip";
                aimLoopAnim = "sniper_aim_loop";
                defaultRunSpeed = 2.5f;
                aimState = myAnimation["sniper_aim"];
                dropState = myAnimation["sniper_drop"];
                break;
            case 5:
                myRenderers[1].enabled = true;
                myRenderers[2].enabled = true;
                idleAnim = "rifle_idle";
                runAnim = "rifle_run";
                fireAnim = "rifle_fire";
                runningFireAnim = "rifle_runningFire";
                equipAnim = "rifle_equip";
                defaultRunSpeed = 2.5f;
                break;
            case 6:
                myRenderers[1].enabled = true;
                myRenderers[2].enabled = true;
                idleAnim = "flamer_idle";
                runAnim = "flamer_run";
                fireAnim = "flamer_fire";
                runningFireAnim = "flamer_runningFire";
                equipAnim = "flamer_equip";
                defaultRunSpeed = 1f;
                break;
            case 7:
                myRenderers[1].enabled = false;
                myRenderers[2].enabled = true;
                idleAnim = "grenade_idle";
                runAnim = "grenade_run";
                fireAnim = "grenade_fire";
                runningFireAnim = "grenade_runningFire";
                equipAnim = "grenade_equip";
                defaultRunSpeed = 2.5f;
                break;
            case 8:
                myRenderers[1].enabled = false;
                myRenderers[2].enabled = true;
                idleAnim = "rpg_idle";
                runAnim = "pistol_run";
                fireAnim = "rpg_fire";
                runningFireAnim = "rpg_runningFire";
                equipAnim = "pistol_equip";
                defaultRunSpeed = 2.5f;
                break;
            case 9:
                myRenderers[1].enabled = true;
                myRenderers[2].enabled = true;
                idleAnim = "minigun_idle";
                runAnim = "minigun_run";
                fireAnim = "minigun_fire";
                runningFireAnim = "minigun_runningFire";
                equipAnim = "minigun_equip";
                defaultRunSpeed = 1f;
                break;
            case 10:
                myRenderers[1].enabled = true;
                myRenderers[2].enabled = true;
                idleAnim = "chainsaw_idle";
                runAnim = "chainsaw_run";
                fireAnim = "chainsaw_fire";
                runningFireAnim = "chainsaw_runningFire";
                equipAnim = "chainsaw_equip";
                dropState = myAnimation["chainsaw_lower"];
                defaultRunSpeed = 2.5f;
                break;
            case 11:
                myRenderers[1].enabled = false;
                myRenderers[2].enabled = true;
                idleAnim = "pistol_idle";
                runAnim = "pistol_run";
                fireAnim = "magnum_fire";
                runningFireAnim = "magnum_runningFire";
                equipAnim = "pistol_equip";
                dropState = myAnimation["magnum_fireunderlay"];
                defaultRunSpeed = 2.5f;
                break;
            case 12:
                myRenderers[1].enabled = true;
                myRenderers[2].enabled = true;
                idleAnim = "rifle_idle";
                runAnim = "rifle_run";
                fireAnim = "shotty_fire";
                runningFireAnim = "shotty_runningFire";
                equipAnim = "rifle_equip";
                defaultRunSpeed = 2.5f;
                break;
            case 13:
                myRenderers[1].enabled = true;
                myRenderers[2].enabled = true;
                idleAnim = "sniper_idle";
                runAnim = "sniper_run";
                fireAnim = "sniper_fire";
                runningFireAnim = "shotty_runningFire";
                equipAnim = "sniper_equip";
                aimLoopAnim = "tesla_aim_loop";
                defaultRunSpeed = 2.5f;
                aimState = myAnimation["sniper_aim"];
                dropState = myAnimation["sniper_drop"];
                break;
        }
        fireState = myAnimation[fireAnim];
        altFireState = myAnimation["dual_fire_alt"];
        runningFireState = myAnimation[runningFireAnim];
        equipState = myAnimation[equipAnim];
        runState = myAnimation[runAnim];
        if (foregroundAlwaysVisible)
        {
            myRenderers[1].enabled = true;
        }
    }

    public virtual void sendSync()
    {
        textMessage = Mathf.Round(movementVector.x * 1000f) / 1000f + " " + Mathf.Round(movementVector.z * 1000f) / 1000f + " " + Mathf.Round(myTransform.position.x * 100f) / 100f + " " + Mathf.Round(myTransform.position.z * 100f) / 100f;
        broadcast("Ally", "sync", textMessage, false);
    }

    public virtual void sync(string incomingData)
    {
        string[] array = incomingData.Split(" "[0]);
        movementVector = new Vector3(UnityBuiltins.parseFloat(array[0]), 0f, UnityBuiltins.parseFloat(array[1]));
        positionMagnet = new Vector3(UnityBuiltins.parseFloat(array[2]), 0f, UnityBuiltins.parseFloat(array[3]));
        timeSinceLastSync = 0f;
    }

    public virtual void syncShot(string incomingData)
    {
        timeSinceLastSync = 0f;
        string[] array = incomingData.Split(" "[0]);
        movementVector = new Vector3(UnityBuiltins.parseFloat(array[0]), 0f, UnityBuiltins.parseFloat(array[1]));
        positionMagnet = new Vector3(UnityBuiltins.parseFloat(array[2]), 0f, UnityBuiltins.parseFloat(array[3]));
        int num = UnityBuiltins.parseInt(array[4]);
        if (myTransform.localScale.x != (float)num)
        {
            flipCommand = num;
            int num2 = num;
            Vector3 localScale = myTransform.localScale;
            float num3 = (localScale.x = num2);
            Vector3 vector2 = (myTransform.localScale = localScale);
        }
        int num4 = UnityBuiltins.parseInt(array[5]);
        if (equippedSlot != num4)
        {
            equip(num4, true);
        }
        if (movementVector != new Vector3(0f, 0f, 0f))
        {
            myTransform.position = Vector3.Lerp(myTransform.position, positionMagnet, Time.deltaTime * 2f);
        }
        attack(false);
        tempZombieScript = null;
        if (Extensions.get_length(array) <= 6)
        {
            return;
        }
        for (int i = 6; i < Extensions.get_length(array); i += 2)
        {
            tempFloat = UnityBuiltins.parseFloat(array[i]);
            tempZombieScript = motherBrain.zombies[UnityBuiltins.parseInt(array[i + 1])];
            tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempZombieScript.myTransform), motherBrain.allyScript);
            myEffects[equippedSlot].hitEffect(tempZombieScript);
            if (DB.weapons[weapons[equippedSlot]].hitStyle == "pistol" && tempZombieScript.zombieType != EnemyType.Container)
            {
                motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 3f, UnityEngine.Random.Range(0, 2));
            }
            else if (DB.weapons[weapons[equippedSlot]].hitStyle == "shotgun" && tempZombieScript.zombieType != EnemyType.Container)
            {
                motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 3f, UnityEngine.Random.Range(2, 4));
            }
            else if (DB.weapons[weapons[equippedSlot]].hitStyle == "chainsaw" && tempZombieScript.zombieType != EnemyType.Container)
            {
                motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 7f, UnityEngine.Random.Range(2, 4));
            }
            myEffects[equippedSlot].tracerTermination = tempZombieScript.myTransform.position.x;
            myEffects[equippedSlot].cropTracer();
        }
    }

    public virtual void broadcast(string whichObject, string whichFunction, string message, bool reliable)
    {
        if (!DB.multiplayer)
        {
            return;
        }
        for (int i = 0; i < Extensions.get_length(motherBrain.messageSlots); i++)
        {
            if (motherBrain.messageSlots[i].whichObject.text == string.Empty)
            {
                motherBrain.messageSlots[i].whichObject.text = whichObject;
                motherBrain.messageSlots[i].whichFunction.text = whichFunction;
                motherBrain.messageSlots[i].message.text = message;
                i = Extensions.get_length(motherBrain.messageSlots);
            }
        }
    }

    public virtual void attack(bool local)
    {
        int num = 0;
        int num2 = 0;
        singleMinded[equippedSlot] = true;
        if (ammo[equippedSlot] == 0 && !ally)
        {
            if (DB.weapons[weapons[equippedSlot]].hitStyle == "chainsaw")
            {
                if (runningFireState.weight == 1f || fireState.weight == 1f)
                {
                    killWeaponLoop(string.Empty);
                }
            }
            else if (DB.weapons[weapons[equippedSlot]].hitStyle == "flamer" && (runningFireState.weight == 1f || fireState.weight == 1f))
            {
                killWeaponLoop(string.Empty);
            }
        }
        if ((!(shotCooldown > 0f) && explosiveAvailable() && ammo[equippedSlot] != 0) || ally)
        {
            bool flag = false;
            if (!ally && DB.weapons[weapons[equippedSlot]].hitStyle != "sniper" && DB.weapons[weapons[equippedSlot]].hitStyle != "tesla")
            {
                motherBrain.shotsFired++;
                if (ammo[equippedSlot] > 0)
                {
                    ammoInfo = ammo[equippedSlot];
                    ammo[equippedSlot]--;
                    if (ammoInfo == ammo[equippedSlot] && !ally)
                    {
                        motherBrain = null;
                    }
                    motherBrain.updateCurrentAmmo(ammo[equippedSlot]);
                }
            }
            if (!ally && !(DB.achievements[26].counter >= (float)DB.achievements[26].threshold) && DB.weapons[weapons[equippedSlot]].automatic)
            {
                DB.achievements[26].counter = DB.achievements[26].counter + 1f;
                if (DB.achievements[26].counter == (float)DB.achievements[26].threshold)
                {
                    DB.announceAchievement(26);
                }
            }
            shotCooldown = rateOfFire;
            movementLockout = DB.weapons[weapons[equippedSlot]].movementLockout;
            if (DB.weapons[weapons[equippedSlot]].hitStyle != "chainsaw")
            {
                myAnimation.Stop(fireAnim);
                myAnimation.Stop(runningFireAnim);
            }
            if (!(movementLockout <= 0f))
            {
                if (DWstatus[equippedSlot] && !dualWieldToggle)
                {
                    myAnimation.Play("dual_fire_alt");
                }
                else
                {
                    myAnimation.Play(fireAnim);
                }
                movementVector = new Vector3(0f, 0f, 0f);
                playerState = 0;
            }
            else if (DB.weapons[weapons[equippedSlot]].hitStyle == "sniper" || DB.weapons[weapons[equippedSlot]].hitStyle == "tesla")
            {
                movementVector = new Vector3(0f, 0f, 0f);
                playerState = 0;
                laserDelay = DB.weapons[weapons[equippedSlot]].aimDelay;
                myAnimation.Play("sniper_aim");
                aimingLockout = true;
            }
            else if (playerState == 0)
            {
                if (DWstatus[equippedSlot] && !dualWieldToggle)
                {
                    myAnimation.Play("dual_fire_alt");
                }
                else
                {
                    if (DB.weapons[weapons[equippedSlot]].animSet == 11)
                    {
                        myAnimation.Play("magnum_fireunderlay");
                    }
                    myAnimation.Play(fireAnim);
                }
            }
            else if (DWstatus[equippedSlot] && !dualWieldToggle)
            {
                myAnimation.Play("dual_runningFire_alt");
            }
            else if (DB.weapons[weapons[equippedSlot]].hitStyle == "chainsaw" && runningFireState.weight == 0f)
            {
                float normalizedTime = runState.normalizedTime;
                myAnimation.Play(runningFireAnim);
                runningFireState.normalizedTime = normalizedTime;
            }
            else
            {
                myAnimation.Play(runningFireAnim);
            }
            if (shellTypes[equippedSlot] == 1)
            {
                if (DWstatus[equippedSlot] && !dualWieldToggle)
                {
                    motherBrain.spawnBasicShell(myTransform.position, DB.weapons[weapons[equippedSlot]].shellOffset + new Vector3(-0.4f, 0f, -0.5f), (int)myTransform.localScale.x);
                }
                else
                {
                    motherBrain.spawnBasicShell(myTransform.position, DB.weapons[weapons[equippedSlot]].shellOffset, (int)myTransform.localScale.x);
                }
            }
            else if (shellTypes[equippedSlot] == 2)
            {
                motherBrain.spawnShottyShell(myTransform.position, DB.weapons[weapons[equippedSlot]].shellOffset, (int)myTransform.localScale.x);
            }
            else if (shellTypes[equippedSlot] == 4)
            {
                motherBrain.spawnPin(myTransform.position, DB.weapons[weapons[equippedSlot]].shellOffset, (int)myTransform.localScale.x);
            }
            if (((bool)mySounds[equippedSlot] && DB.weapons[weapons[equippedSlot]].hitStyle == "sniper") || ((bool)mySounds[equippedSlot] && DB.weapons[weapons[equippedSlot]].hitStyle == "tesla"))
            {
                mySounds[equippedSlot].aim();
            }
            else if ((bool)mySounds[equippedSlot] && DB.weapons[weapons[equippedSlot]].hitStyle == "flamer")
            {
                mySounds[equippedSlot].triggerLoop();
            }
            else if ((bool)mySounds[equippedSlot])
            {
                mySounds[equippedSlot].fire();
            }
            int num3 = default(int);
            if ((bool)myEffects[equippedSlot] && DB.weapons[weapons[equippedSlot]].hitStyle != "sniper" && DB.weapons[weapons[equippedSlot]].hitStyle != "tesla")
            {
                if (DB.weapons[weapons[equippedSlot]].hitStyle == "melee")
                {
                    myEffects[equippedSlot].swing(myTransform.position + new Vector3(0f, 0f, 0.3f), (int)myTransform.localScale.x);
                }
                else if (DB.weapons[weapons[equippedSlot]].hitStyle == "grenade")
                {
                    throwGrenade();
                }
                else if (DB.weapons[weapons[equippedSlot]].hitStyle == "rocket")
                {
                    num3 = throwGrenade();
                    myEffects[equippedSlot].fire(myTransform.position, (int)myTransform.localScale.x);
                }
                else if (DB.weapons[weapons[equippedSlot]].hitStyle == "flamer")
                {
                    myEffects[equippedSlot].muzzleParent = myTransform;
                    StartCoroutine(myEffects[equippedSlot].loopActivate(myTransform.position + new Vector3(0f, 0f, 0.3f), (int)myTransform.localScale.x));
                }
                else if (DWstatus[equippedSlot])
                {
                    myEffects[equippedSlot].dualFire(myTransform.position, (int)myTransform.localScale.x, dualWieldToggle);
                    myEffects[equippedSlot].muzzleParent = myTransform;
                    if (dualWieldToggle)
                    {
                        dualWieldToggle = false;
                    }
                    else
                    {
                        dualWieldToggle = true;
                    }
                }
                else
                {
                    myEffects[equippedSlot].fire(myTransform.position, (int)myTransform.localScale.x);
                    myEffects[equippedSlot].muzzleParent = myTransform;
                }
            }
            if (DB.weapons[weapons[equippedSlot]].UVanimation)
            {
                if (DB.weapons[weapons[equippedSlot]].hitStyle == "chainsaw")
                {
                    minigunSpin = 0.6f;
                }
                else
                {
                    minigunSpin = 3.5f;
                }
            }
            if ((bool)weaponRockets[equippedSlot])
            {
                int num4 = 0;
                Vector3 localScale = weaponRockets[equippedSlot].localScale;
                float num5 = (localScale.x = num4);
                Vector3 vector2 = (weaponRockets[equippedSlot].localScale = localScale);
                reloadTimer = DB.weapons[weapons[equippedSlot]].rateOfFire - 0.25f;
            }
            if (local)
            {
                hitMessage = string.Empty;
                Vector3 vector3 = new Vector3(0f, 0f, 0f);
                hitDelay = 0f;
                if (DB.weapons[weapons[equippedSlot]].hitStyle == "pistol")
                {
                    vector3 = new Vector3(myTransform.localScale.x, 0f, UnityEngine.Random.Range(0f - DB.weapons[weapons[equippedSlot]].spray, DB.weapons[weapons[equippedSlot]].spray));
                    if (Physics.Raycast(myTransform.position - new Vector3(0.8f * myTransform.localScale.x, 0f, 0f), vector3, out tempHit, 11f, motherBrain.zombieMask))
                    {
                        tempTransform = tempHit.transform;
                        if (hitChance(tempTransform))
                        {
                            tempZombieScript = (ZombieScript)tempTransform.GetComponent(typeof(ZombieScript));
                            tempFloat = weaponDamage(tempTransform);
                            tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempTransform), motherBrain.playerScript);
                            flag = true;
                            myEffects[equippedSlot].hitEffect(tempZombieScript);
                            if (tempZombieScript.zombieType != EnemyType.Container)
                            {
                                motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 3f, UnityEngine.Random.Range(0, 2));
                            }
                            myEffects[equippedSlot].tracerTermination = tempTransform.position.x;
                            myEffects[equippedSlot].cropTracer();
                            if (DB.multiplayer)
                            {
                                hitMessage = " " + tempFloat + " " + tempTransform.name;
                            }
                        }
                        else if (Physics.Raycast(tempTransform.position, vector3, out tempHit, 11f, motherBrain.zombieMask))
                        {
                            tempTransform = tempHit.transform;
                            if (hitChance(tempTransform))
                            {
                                tempZombieScript = (ZombieScript)tempTransform.GetComponent(typeof(ZombieScript));
                                tempFloat = weaponDamage(tempTransform);
                                tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempTransform), motherBrain.playerScript);
                                flag = true;
                                myEffects[equippedSlot].hitEffect(tempZombieScript);
                                if (tempZombieScript.zombieType != EnemyType.Container)
                                {
                                    motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 3f, UnityEngine.Random.Range(0, 2));
                                }
                                myEffects[equippedSlot].tracerTermination = tempTransform.position.x;
                                myEffects[equippedSlot].cropTracer();
                                if (DB.multiplayer)
                                {
                                    hitMessage = " " + tempFloat + " " + tempTransform.name;
                                }
                            }
                            else if (Physics.Raycast(tempTransform.position, vector3, out tempHit, 11f, motherBrain.zombieMask))
                            {
                                tempTransform = tempHit.transform;
                                if (hitChance(tempTransform))
                                {
                                    tempZombieScript = (ZombieScript)tempTransform.GetComponent(typeof(ZombieScript));
                                    tempFloat = weaponDamage(tempTransform);
                                    tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempTransform), motherBrain.playerScript);
                                    flag = true;
                                    myEffects[equippedSlot].hitEffect(tempZombieScript);
                                    if (tempZombieScript.zombieType != EnemyType.Container)
                                    {
                                        motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 3f, UnityEngine.Random.Range(0, 2));
                                    }
                                    myEffects[equippedSlot].tracerTermination = tempTransform.position.x;
                                    myEffects[equippedSlot].cropTracer();
                                    if (DB.multiplayer)
                                    {
                                        hitMessage = " " + tempFloat + " " + tempTransform.name;
                                    }
                                }
                                else if (Physics.Raycast(tempTransform.position, vector3, out tempHit, 11f, motherBrain.zombieMask))
                                {
                                    tempTransform = tempHit.transform;
                                    if (hitChance(tempTransform))
                                    {
                                        tempZombieScript = (ZombieScript)tempTransform.GetComponent(typeof(ZombieScript));
                                        tempFloat = weaponDamage(tempTransform);
                                        tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempTransform), motherBrain.playerScript);
                                        flag = true;
                                        myEffects[equippedSlot].hitEffect(tempZombieScript);
                                        if (tempZombieScript.zombieType != EnemyType.Container)
                                        {
                                            motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 3f, UnityEngine.Random.Range(0, 2));
                                        }
                                        myEffects[equippedSlot].tracerTermination = tempTransform.position.x;
                                        myEffects[equippedSlot].cropTracer();
                                        if (DB.multiplayer)
                                        {
                                            hitMessage = " " + tempFloat + " " + tempTransform.name;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else if (DB.weapons[weapons[equippedSlot]].hitStyle == "melee")
                {
                    hitDelay = 0.1f;
                }
                else if (DB.weapons[weapons[equippedSlot]].hitStyle == "shotgun")
                {
                    vector3 = new Vector3(myTransform.localScale.x, 0f, UnityEngine.Random.Range(0f - DB.weapons[weapons[equippedSlot]].spray, DB.weapons[weapons[equippedSlot]].spray));
                    if (Physics.Raycast(myTransform.position - new Vector3(0.8f * myTransform.localScale.x, 0f, 0f), vector3, out tempHit, 11f, motherBrain.zombieMask))
                    {
                        tempTransform = tempHit.transform;
                        tempZombieScript = (ZombieScript)tempTransform.GetComponent(typeof(ZombieScript));
                        tempFloat = weaponDamage(tempTransform);
                        tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempTransform), motherBrain.playerScript);
                        if (!(DB.achievements[25].counter >= (float)DB.achievements[25].threshold) && tempZombieScript.health <= 0 && tempZombieScript.zombieType != EnemyType.Container)
                        {
                            DB.achievements[25].counter = DB.achievements[25].counter + 1f;
                            if (DB.achievements[25].counter == (float)DB.achievements[25].threshold)
                            {
                                DB.announceAchievement(25);
                            }
                        }
                        flag = true;
                        myEffects[equippedSlot].hitEffect(tempZombieScript);
                        if (tempZombieScript.zombieType != EnemyType.Container)
                        {
                            motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 3f, UnityEngine.Random.Range(2, 4));
                        }
                        myEffects[equippedSlot].tracerTermination = tempTransform.position.x;
                        myEffects[equippedSlot].cropTracer();
                        if (DB.multiplayer)
                        {
                            hitMessage = " " + tempFloat + " " + tempTransform.name;
                        }
                        hitList = Physics.RaycastAll(tempTransform.position, vector3, DB.weapons[weapons[equippedSlot]].piercingRange, motherBrain.zombieMask);
                        for (num = 0; num < Extensions.get_length(hitList); num++)
                        {
                            tempTransform = hitList[num].transform;
                            tempZombieScript = (ZombieScript)tempTransform.GetComponent(typeof(ZombieScript));
                            tempFloat = weaponDamage(tempTransform);
                            tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempTransform), motherBrain.playerScript);
                            flag = true;
                            if (!(DB.achievements[25].counter >= (float)DB.achievements[25].threshold) && tempZombieScript.health <= 0 && tempZombieScript.zombieType != EnemyType.Container)
                            {
                                DB.achievements[25].counter = DB.achievements[25].counter + 1f;
                                if (DB.achievements[25].counter == (float)DB.achievements[25].threshold)
                                {
                                    DB.announceAchievement(25);
                                }
                            }
                            myEffects[equippedSlot].hitEffect(tempZombieScript);
                            if (tempZombieScript.zombieType != EnemyType.Container)
                            {
                                motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 3f, UnityEngine.Random.Range(2, 4));
                            }
                            if (DB.multiplayer)
                            {
                                hitMessage = hitMessage + " " + tempFloat + " " + tempTransform.name;
                            }
                        }
                    }
                }
                else if (DB.weapons[weapons[equippedSlot]].hitStyle == "flamer")
                {
                    vector3 = new Vector3(myTransform.localScale.x, 0f, UnityEngine.Random.Range(0f - DB.weapons[weapons[equippedSlot]].spray, DB.weapons[weapons[equippedSlot]].spray));
                    hitList = Physics.RaycastAll(myTransform.position - new Vector3(0.8f * myTransform.localScale.x, 0f, 0f), vector3, 4.4f, motherBrain.zombieMask);
                    for (num = 0; num < Extensions.get_length(hitList); num++)
                    {
                        tempTransform = hitList[num].transform;
                        tempZombieScript = (ZombieScript)tempTransform.GetComponent(typeof(ZombieScript));
                        tempFloat = weaponDamage(tempTransform);
                        tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempTransform), motherBrain.playerScript);
                        flag = true;
                        myEffects[equippedSlot].hitEffect(tempZombieScript);
                        if (DB.multiplayer)
                        {
                            hitMessage = hitMessage + " " + tempFloat + " " + tempTransform.name;
                        }
                    }
                }
                else if (DB.weapons[weapons[equippedSlot]].hitStyle == "chainsaw")
                {
                    vector3 = new Vector3(myTransform.localScale.x, 0f, UnityEngine.Random.Range(0f - DB.weapons[weapons[equippedSlot]].spray, DB.weapons[weapons[equippedSlot]].spray));
                    hitList = Physics.RaycastAll(myTransform.position - new Vector3(0.8f * myTransform.localScale.x, 0f, 0f), vector3, 2.6f, motherBrain.zombieMask);
                    for (num = 0; num < Extensions.get_length(hitList); num++)
                    {
                        tempTransform = hitList[num].transform;
                        tempZombieScript = (ZombieScript)tempTransform.GetComponent(typeof(ZombieScript));
                        tempFloat = weaponDamage(tempTransform);
                        tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempTransform), motherBrain.playerScript);
                        flag = true;
                        myEffects[equippedSlot].hitEffect(tempZombieScript);
                        if (tempZombieScript.zombieType != EnemyType.Container)
                        {
                            motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 5f, UnityEngine.Random.Range(2, 4));
                        }
                        if (!(speedModTimer >= 0.15f))
                        {
                            speedMod = 0.25f;
                            speedModTimer = 0.05f;
                        }
                        if (DB.multiplayer)
                        {
                            hitMessage = hitMessage + " " + tempFloat + " " + tempTransform.name;
                        }
                    }
                }
                else if (DB.weapons[weapons[equippedSlot]].hitStyle == "rocket")
                {
                    myExplosives[equippedSlot].explosionPoint[num3] = myTransform.position.x + 100f * myTransform.localScale.x;
                    vector3 = new Vector3(myTransform.localScale.x, 0f, UnityEngine.Random.Range(0f - DB.weapons[weapons[equippedSlot]].spray, DB.weapons[weapons[equippedSlot]].spray));
                    if (Physics.Raycast(myTransform.position - new Vector3(0.8f * myTransform.localScale.x, 0f, 0f), vector3, out tempHit, 11f, motherBrain.zombieMask))
                    {
                        tempTransform = tempHit.transform;
                        myExplosives[equippedSlot].explosionPoint[num3] = tempTransform.position.x - 0.2f * myTransform.localScale.x;
                    }
                }
                if (flag)
                {
                    motherBrain.hits++;
                }
                if (DB.multiplayer)
                {
                    textMessage = Mathf.Round(movementVector.x * 1000f) / 1000f + " " + Mathf.Round(movementVector.z * 1000f) / 1000f + " " + Mathf.Round(myTransform.position.x * 100f) / 100f + " " + Mathf.Round(myTransform.position.z * 100f) / 100f + " " + myTransform.localScale.x + " " + equippedSlot + hitMessage;
                    if (hitMessage == string.Empty && !aimingLockout)
                    {
                        broadcast("Ally", "syncShot", textMessage, false);
                    }
                    else
                    {
                        broadcast("Ally", "syncShot", textMessage, true);
                    }
                    stateSyncDelay = motherBrain.stateSyncDelay * 2f;
                }
            }
            if (flipCommand != 0)
            {
                float x = myTransform.localScale.x * -1f;
                Vector3 localScale2 = myTransform.localScale;
                float num6 = (localScale2.x = x);
                Vector3 vector5 = (myTransform.localScale = localScale2);
            }
            if (!(hitDelay <= 0f) && local)
            {
                StartCoroutine(delayedDamage());
            }
        }
        else if (!(shotCooldown > 0f) && ammo[equippedSlot] == 0 && !ally)
        {
            motherBrain.sounds[5].Play();
            shotCooldown = 0.2f;
        }
    }

    public virtual IEnumerator delayedDamage()
    {
        return new _0024delayedDamage_00241922(this).GetEnumerator();
    }

    public virtual void syncSimpleShot(string incomingData)
    {
        string[] array = incomingData.Split(" "[0]);
        tempZombieScript = null;
        for (int i = 0; i < Extensions.get_length(array); i += 2)
        {
            tempFloat = UnityBuiltins.parseFloat(array[i]);
            tempZombieScript = motherBrain.zombies[UnityBuiltins.parseInt(array[i + 1])];
            tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempZombieScript.myTransform), motherBrain.allyScript);
            myEffects[equippedSlot].hitEffect(tempZombieScript);
            if (DB.weapons[weapons[equippedSlot]].hitStyle == "melee" && tempZombieScript.zombieType != EnemyType.Container)
            {
                motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 3f, UnityEngine.Random.Range(1, 3));
                if (tempZombieScript.health <= 0 && tempZombieScript.zombieType != EnemyType.Container)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (perks[j] == 20)
                        {
                            for (int k = 0; k < Extensions.get_length(myRenderers); k++)
                            {
                                myRenderers[k].material.color = new Color(1f, 1f, 1f);
                            }
                            colorSpeed = 1f;
                            activateColors();
                            berzerkerSpeed = 4f;
                            berzerkerSpeedMod = 1.3f + (float)perkRanks[j] * 0.1f;
                        }
                    }
                }
            }
            mySounds[equippedSlot].hit();
        }
    }

    public virtual float weaponDamage(Transform victim)
    {
        float num = DB.weapons[weapons[equippedSlot]].damage;
        if (victim != null && DB.weapons[weapons[equippedSlot]].damageFalloff != 0f)
        {
            num -= DB.weapons[weapons[equippedSlot]].damageFalloff * Vector3.Distance(myTransform.position, victim.position);
            if (!(num >= 0f))
            {
                num = 1f;
            }
        }
        if ((DB.weapons[weapons[equippedSlot]].damagePerk == perks[0] || DB.weapons[weapons[equippedSlot]].damagePerk == perks[1] || DB.weapons[weapons[equippedSlot]].damagePerk == perks[2]) && DB.weapons[weapons[equippedSlot]].damagePerk != -1)
        {
            num *= (DB.perks[DB.weapons[weapons[equippedSlot]].damagePerk].rankBonuses[(int)DB.perks[DB.weapons[weapons[equippedSlot]].damagePerk].rank] + 100f) / 100f;
        }
        float num2 = DB.weapons[weapons[equippedSlot]].critChance;
        if (perks[0] == 13 || perks[1] == 13 || perks[2] == 13)
        {
            num2 += DB.perks[13].rankBonuses[(int)DB.perks[13].rank];
        }
        if ((perks[0] == 18 || perks[1] == 18 || perks[2] == 18) && !(health / maxHealth >= 0.2f))
        {
            num2 += DB.perks[18].rankBonuses[(int)DB.perks[18].rank];
        }
        if (!((float)UnityEngine.Random.Range(0, 101) >= num2))
        {
            num *= 2f;
        }
        return num;
    }

    public virtual bool hitChance(Transform victim)
    {
        float num = DB.weapons[weapons[equippedSlot]].hitChance;
        if (victim != null && DB.weapons[weapons[equippedSlot]].hitChanceFalloff != 0f)
        {
            num -= DB.weapons[weapons[equippedSlot]].hitChanceFalloff * Vector3.Distance(myTransform.position, victim.position);
        }
        if (perks[0] == 8 || perks[1] == 8 || perks[2] == 8)
        {
            num += DB.perks[8].rankBonuses[(int)DB.perks[8].rank];
        }
        return ((float)UnityEngine.Random.Range(0, 101) <= num) ? true : false;
    }

    public virtual float weaponForce(int whichWeapon, Vector3 source, Transform victim)
    {
        float num = impactForces[whichWeapon];
        if (victim != null && impactFalloffs[whichWeapon] != 0f)
        {
            num -= impactFalloffs[whichWeapon] * Vector3.Distance(source, victim.position);
            if (!(num >= 0f))
            {
                num = 1f;
            }
        }
        if (perks[0] == 14)
        {
            num *= DB.perks[14].rankBonuses[perkRanks[0]];
        }
        else if (perks[1] == 14)
        {
            num *= DB.perks[14].rankBonuses[perkRanks[1]];
        }
        else if (perks[2] == 14)
        {
            num *= DB.perks[14].rankBonuses[perkRanks[2]];
        }
        return num;
    }

    public virtual void takeDamage(int howMuchDamage, float speedModDuration)
    {
        if (!invincible)
        {
            if (!(health <= 0f))
            {
                health -= howMuchDamage;
            }
            if (!ally)
            {
                motherBrain.multiplierTimer = 0f;
                motherBrain.lifeBarFlash = 1f;
            }
            if (!(health > 0f) && alive && !ally)
            {
                StartCoroutine(die(string.Empty));
            }
            colorSpeed = 5f;
            activateColors();
            for (int i = 0; i < Extensions.get_length(myRenderers); i++)
            {
                myRenderers[i].material.color = new Color(0.8f, 0f, 0f);
            }
            if (alive)
            {
                myAnimation.Stop("hitReact");
                myAnimation.Play("hitReact");
            }
            speedMod = 0.25f;
            if (perks[0] == 10 || perks[1] == 10 || perks[2] == 10)
            {
                speedMod += DB.perks[10].rankBonuses[(int)DB.perks[10].rank];
            }
            speedModTimer = speedModDuration;
            if (DB.tutorial && !(health >= 15f))
            {
                invincible = true;
            }
        }
    }

    public virtual IEnumerator die(string noargument)
    {
        return new _0024die_00241928(this).GetEnumerator();
    }

    public virtual void shaderAnimation()
    {
        if (redAnim)
        {
            if (!(myRenderers[0].material.color.r <= 0.25f))
            {
                float r = myRenderers[0].material.color.r - Time.deltaTime * colorSpeed * (1f / Time.timeScale);
                Color color = myRenderers[0].material.color;
                float num = (color.r = r);
                Color color3 = (myRenderers[0].material.color = color);
                if (!(myRenderers[0].material.color.r >= 0.25f))
                {
                    float r2 = 0.25f;
                    Color color4 = myRenderers[0].material.color;
                    float num2 = (color4.r = r2);
                    Color color6 = (myRenderers[0].material.color = color4);
                    redAnim = false;
                }
            }
            else if (!(myRenderers[0].material.color.r >= 0.25f))
            {
                float r3 = myRenderers[0].material.color.r + Time.deltaTime * colorSpeed * (1f / Time.timeScale);
                Color color7 = myRenderers[0].material.color;
                float num3 = (color7.r = r3);
                Color color9 = (myRenderers[0].material.color = color7);
                if (!(myRenderers[0].material.color.r <= 0.25f))
                {
                    float r4 = 0.25f;
                    Color color10 = myRenderers[0].material.color;
                    float num4 = (color10.r = r4);
                    Color color12 = (myRenderers[0].material.color = color10);
                    redAnim = false;
                }
            }
            else
            {
                redAnim = false;
            }
            float r5 = myRenderers[0].material.color.r;
            Color color13 = myRenderers[1].material.color;
            float num5 = (color13.r = r5);
            Color color15 = (myRenderers[1].material.color = color13);
            float r6 = myRenderers[0].material.color.r;
            Color color16 = myRenderers[2].material.color;
            float num6 = (color16.r = r6);
            Color color18 = (myRenderers[2].material.color = color16);
        }
        if (greenAnim)
        {
            if (!(myRenderers[0].material.color.g <= 0.25f))
            {
                float g = myRenderers[0].material.color.g - Time.deltaTime * colorSpeed * (1f / Time.timeScale);
                Color color19 = myRenderers[0].material.color;
                float num7 = (color19.g = g);
                Color color21 = (myRenderers[0].material.color = color19);
                if (!(myRenderers[0].material.color.g >= 0.25f))
                {
                    float g2 = 0.25f;
                    Color color22 = myRenderers[0].material.color;
                    float num8 = (color22.g = g2);
                    Color color24 = (myRenderers[0].material.color = color22);
                    greenAnim = false;
                }
            }
            else if (!(myRenderers[0].material.color.g >= 0.25f))
            {
                float g3 = myRenderers[0].material.color.g + Time.deltaTime * colorSpeed * (1f / Time.timeScale);
                Color color25 = myRenderers[0].material.color;
                float num9 = (color25.g = g3);
                Color color27 = (myRenderers[0].material.color = color25);
                if (!(myRenderers[0].material.color.g <= 0.25f))
                {
                    float g4 = 0.25f;
                    Color color28 = myRenderers[0].material.color;
                    float num10 = (color28.g = g4);
                    Color color30 = (myRenderers[0].material.color = color28);
                    greenAnim = false;
                }
            }
            else
            {
                greenAnim = false;
            }
            float g5 = myRenderers[0].material.color.g;
            Color color31 = myRenderers[1].material.color;
            float num11 = (color31.g = g5);
            Color color33 = (myRenderers[1].material.color = color31);
            float g6 = myRenderers[0].material.color.g;
            Color color34 = myRenderers[2].material.color;
            float num12 = (color34.g = g6);
            Color color36 = (myRenderers[2].material.color = color34);
        }
        if (!blueAnim)
        {
            return;
        }
        if (!(myRenderers[0].material.color.b <= 0.25f))
        {
            float b = myRenderers[0].material.color.b - Time.deltaTime * colorSpeed * (1f / Time.timeScale);
            Color color37 = myRenderers[0].material.color;
            float num13 = (color37.b = b);
            Color color39 = (myRenderers[0].material.color = color37);
            if (!(myRenderers[0].material.color.b >= 0.25f))
            {
                float b2 = 0.25f;
                Color color40 = myRenderers[0].material.color;
                float num14 = (color40.b = b2);
                Color color42 = (myRenderers[0].material.color = color40);
                blueAnim = false;
            }
        }
        else if (!(myRenderers[0].material.color.b >= 0.25f))
        {
            float b3 = myRenderers[0].material.color.b + Time.deltaTime * colorSpeed * (1f / Time.timeScale);
            Color color43 = myRenderers[0].material.color;
            float num15 = (color43.b = b3);
            Color color45 = (myRenderers[0].material.color = color43);
            if (!(myRenderers[0].material.color.b <= 0.25f))
            {
                float b4 = 0.25f;
                Color color46 = myRenderers[0].material.color;
                float num16 = (color46.b = b4);
                Color color48 = (myRenderers[0].material.color = color46);
                blueAnim = false;
            }
        }
        else
        {
            blueAnim = false;
        }
        float b5 = myRenderers[0].material.color.b;
        Color color49 = myRenderers[1].material.color;
        float num17 = (color49.b = b5);
        Color color51 = (myRenderers[1].material.color = color49);
        float b6 = myRenderers[0].material.color.b;
        Color color52 = myRenderers[2].material.color;
        float num18 = (color52.b = b6);
        Color color54 = (myRenderers[2].material.color = color52);
    }

    public virtual void activateColors()
    {
        redAnim = true;
        blueAnim = true;
        greenAnim = true;
    }

    public virtual float normalRunSpeed()
    {
        return moveSpeed / defaultRunSpeed * weaponSpeedMod * berzerkerSpeedMod;
    }

    public virtual void aimRelease(bool fireAnyway)
    {
        aimingLockout = false;
        mySounds[equippedSlot].stopAim();
        if (DB.multiplayer && !ally)
        {
            textMessage = movementVector.x + " " + movementVector.z + " " + myTransform.position.x + " " + myTransform.position.z + " " + myTransform.localScale.x + " " + equippedSlot;
        }
        if ((!(laserDelay > 0f) && !ally) || fireAnyway)
        {
            bool flag = false;
            if (DB.multiplayer && !ally)
            {
                textMessage += " 1";
            }
            if (!ally)
            {
                motherBrain.shotsFired++;
                ammoInfo = ammo[equippedSlot];
                ammo[equippedSlot]--;
                if (ammoInfo == ammo[equippedSlot] && !ally)
                {
                    motherBrain = null;
                }
                motherBrain.updateCurrentAmmo(ammo[equippedSlot]);
            }
            myAnimation.Play(fireAnim);
            if (DB.weapons[weapons[equippedSlot]].hitStyle == "tesla")
            {
                myEffects[equippedSlot].teslaArc(myTransform.position, (int)myTransform.localScale.x);
            }
            else
            {
                myEffects[equippedSlot].fire(myTransform.position, (int)myTransform.localScale.x);
            }
            mySounds[equippedSlot].fire();
            if (shellTypes[equippedSlot] == 3)
            {
                motherBrain.spawnSniperShell(myTransform.position, DB.weapons[weapons[equippedSlot]].shellOffset, (int)myTransform.localScale.x);
            }
            if (DB.weapons[weapons[equippedSlot]].hitStyle == "tesla")
            {
                motherBrain.cameraShaker.Stop();
                motherBrain.cameraShaker.Play("shake");
            }
            movementLockout = 0.3f;
            if (!ally && DB.weapons[weapons[equippedSlot]].hitStyle == "sniper")
            {
                hitList = Physics.RaycastAll(myTransform.position - new Vector3(0.8f * myTransform.localScale.x, 0f, 0f), new Vector3(myTransform.localScale.x, 0f, 0f), 11f, motherBrain.zombieMask);
                int num = 0;
                if (Extensions.get_length(hitList) != 0)
                {
                    for (int i = 0; i < Extensions.get_length(hitList); i++)
                    {
                        tempTransform = hitList[i].transform;
                        tempZombieScript = (ZombieScript)tempTransform.GetComponent(typeof(ZombieScript));
                        tempFloat = weaponDamage(tempTransform);
                        tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempTransform), motherBrain.playerScript);
                        if (tempZombieScript.health <= 0 && tempZombieScript.zombieType != EnemyType.Container)
                        {
                            num++;
                            if (num == 4 && DB.achievements[14].counter == 0f)
                            {
                                DB.achievements[14].counter = DB.achievements[14].threshold;
                                DB.announceAchievement(14);
                            }
                        }
                        flag = true;
                        myEffects[equippedSlot].hitEffect(tempZombieScript);
                        if (tempZombieScript.zombieType != EnemyType.Container)
                        {
                            motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 3f, UnityEngine.Random.Range(1, 3));
                        }
                        mySounds[equippedSlot].hit();
                        if (DB.multiplayer)
                        {
                            textMessage = textMessage + " " + tempFloat + " " + tempTransform.name;
                        }
                    }
                }
                if (DB.multiplayer)
                {
                    broadcast("Ally", "syncAimRelease", textMessage, true);
                }
            }
            else if (!ally && DB.weapons[weapons[equippedSlot]].hitStyle == "tesla")
            {
                if (Physics.Raycast(myTransform.position - new Vector3(0.8f * myTransform.localScale.x, 0f, 0f), new Vector3(myTransform.localScale.x, 0f, 0f), out tempHit, 11f, motherBrain.zombieMask))
                {
                    tempTransform = tempHit.transform;
                    tempZombieScript = (ZombieScript)tempTransform.GetComponent(typeof(ZombieScript));
                    tempFloat = weaponDamage(tempTransform);
                    tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempTransform), motherBrain.playerScript);
                    flag = true;
                    if (tempZombieScript.health <= 0 && tempZombieScript.zombieType != EnemyType.Container && !(DB.achievements[8].counter >= (float)DB.achievements[8].threshold))
                    {
                        DB.achievements[8].counter = DB.achievements[8].counter + 1f;
                        if (DB.achievements[8].counter == (float)DB.achievements[8].threshold)
                        {
                            DB.announceAchievement(8);
                        }
                    }
                    myEffects[equippedSlot].hitEffect(tempZombieScript);
                    myEffects[equippedSlot].tracerTermination = tempTransform.position.x;
                    myEffects[equippedSlot].cropArc();
                    if (DB.multiplayer)
                    {
                        textMessage = textMessage + " " + tempFloat + " " + tempTransform.name;
                    }
                    Vector3 position = tempTransform.position;
                    for (int j = 0; j < Extensions.get_length(motherBrain.zombies); j++)
                    {
                        if ((bool)motherBrain.zombies[j] && motherBrain.zombies[j].health > 0 && !(Vector3.Distance(motherBrain.zombies[j].myTransform.position, position) >= 2.2f))
                        {
                            motherBrain.zombies[j].takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (motherBrain.zombies[j].myTransform.position - position).normalized * weaponForce(equippedSlot, myTransform.position, tempTransform), motherBrain.playerScript);
                            if (DB.multiplayer)
                            {
                                textMessage = textMessage + " " + tempFloat + " " + motherBrain.zombies[j].myTransform.name;
                            }
                        }
                    }
                }
                if (DB.multiplayer)
                {
                    broadcast("Ally", "syncAimRelease", textMessage, true);
                }
            }
            if (!ally && flag)
            {
                motherBrain.hits++;
            }
        }
        else
        {
            if (DB.multiplayer && !ally)
            {
                textMessage += " 0";
            }
            myAnimation.Play(idleAnim);
            myAnimation.Play("sniper_drop");
            dropState.normalizedTime = 0.1f;
            if (DB.multiplayer && !ally)
            {
                broadcast("Ally", "syncAimRelease", textMessage, true);
            }
        }
        laserDelay = 0f;
        myEffects[equippedSlot].laserSight(false);
        mySounds[equippedSlot].aimLoop(false);
        if (flipCommand != 0)
        {
            float x = myTransform.localScale.x * -1f;
            Vector3 localScale = myTransform.localScale;
            float num2 = (localScale.x = x);
            Vector3 vector2 = (myTransform.localScale = localScale);
        }
    }

    public virtual void syncAimRelease(string incomingData)
    {
        timeSinceLastSync = 0f;
        string[] array = incomingData.Split(" "[0]);
        movementVector = new Vector3(UnityBuiltins.parseFloat(array[0]), 0f, UnityBuiltins.parseFloat(array[1]));
        positionMagnet = new Vector3(UnityBuiltins.parseFloat(array[2]), 0f, UnityBuiltins.parseFloat(array[3]));
        int num = UnityBuiltins.parseInt(array[4]);
        if (myTransform.localScale.x != (float)num)
        {
            flipCommand = num;
            int num2 = num;
            Vector3 localScale = myTransform.localScale;
            float num3 = (localScale.x = num2);
            Vector3 vector2 = (myTransform.localScale = localScale);
        }
        int num4 = UnityBuiltins.parseInt(array[5]);
        if (equippedSlot != num4)
        {
            equip(num4, true);
        }
        if (movementVector != new Vector3(0f, 0f, 0f))
        {
            myTransform.position = Vector3.Lerp(myTransform.position, positionMagnet, Time.deltaTime * 2f);
        }
        tempZombieScript = null;
        if (array[6] == "1")
        {
            aimRelease(true);
        }
        else
        {
            aimRelease(false);
        }
        if (Extensions.get_length(array) <= 7)
        {
            return;
        }
        for (int i = 7; i < Extensions.get_length(array); i += 2)
        {
            tempFloat = UnityBuiltins.parseFloat(array[i]);
            tempZombieScript = motherBrain.zombies[UnityBuiltins.parseInt(array[i + 1])];
            tempZombieScript.takeDamage(tempFloat, DB.weapons[weapons[equippedSlot]].damageType, (tempZombieScript.myTransform.position - myTransform.position).normalized * weaponForce(equippedSlot, myTransform.position, tempZombieScript.myTransform), motherBrain.allyScript);
            myEffects[equippedSlot].hitEffect(tempZombieScript);
            if (DB.weapons[weapons[equippedSlot]].hitStyle == "sniper" && tempZombieScript.zombieType != EnemyType.Container)
            {
                motherBrain.spawnBloodSpurt(tempZombieScript.myTransform.position + new Vector3(0f, 0.6f, 0.25f), (tempZombieScript.myTransform.position - myTransform.position).normalized * 3f, UnityEngine.Random.Range(1, 3));
            }
            myEffects[equippedSlot].tracerTermination = tempZombieScript.myTransform.position.x;
            myEffects[equippedSlot].cropTracer();
            if (DB.weapons[weapons[equippedSlot]].hitStyle == "tesla")
            {
                myEffects[equippedSlot].cropArc();
            }
        }
    }

    public virtual void killWeaponLoop(string noArgument)
    {
        mySounds[equippedSlot].endLoop();
        StartCoroutine(myEffects[equippedSlot].endLoop());
        if (DB.weapons[weapons[equippedSlot]].hitStyle == "chainsaw" && (fireState.weight > 0f || !(runningFireState.weight <= 0f)))
        {
            myAnimation.Stop("chainsaw_fire");
            if (!(runningFireState.weight <= 0f))
            {
                float normalizedTime = runningFireState.normalizedTime;
                myAnimation.Stop("chainsaw_runningFire");
                myAnimation.Play(runAnim);
                runState.normalizedTime = normalizedTime;
            }
            myAnimation.Play("chainsaw_lower");
            dropState.normalizedTime = 0.1f;
            if (playerState == 0)
            {
                myAnimation.Play(idleAnim);
            }
        }
        if (!ally && DB.multiplayer)
        {
            broadcast("Ally", "killWeaponLoop", "1", true);
        }
    }

    public virtual bool explosiveAvailable()
    {
        int result;
        if (DB.weapons[weapons[equippedSlot]].hitStyle == "grenade")
        {
            bool flag = false;
            for (int i = 0; i < Extensions.get_length(myExplosives[equippedSlot].life); i++)
            {
                if (!(myExplosives[equippedSlot].life[i] > 0f))
                {
                    flag = true;
                }
            }
            result = (flag ? 1 : 0);
        }
        else
        {
            result = 1;
        }
        return (byte)result != 0;
    }

    public virtual int throwGrenade()
    {
        int num = 0;
        if (!(myExplosives[equippedSlot].life[0] <= 0f))
        {
            num = 1;
            if (!(myExplosives[equippedSlot].life[1] <= 0f))
            {
                num = 2;
            }
        }
        myExplosives[equippedSlot].life[num] = DB.weapons[weapons[equippedSlot]].explosiveFuse;
        myExplosives[equippedSlot].tran[num].position = myTransform.position + new Vector3(DB.weapons[weapons[equippedSlot]].explosiveRange * myTransform.localScale.x, 0f, 0f);
        if (myExplosives[equippedSlot].tran[num].localScale.x != myTransform.localScale.x)
        {
            float x = myTransform.localScale.x;
            Vector3 localScale = myExplosives[equippedSlot].tran[num].localScale;
            float num2 = (localScale.x = x);
            Vector3 vector2 = (myExplosives[equippedSlot].tran[num].localScale = localScale);
        }
        myExplosives[equippedSlot].anim[num].Stop();
        myExplosives[equippedSlot].anim[num].Play();
        if (DB.weapons[weapons[equippedSlot]].flipExplosion)
        {
            myEffects[equippedSlot].flipExplosionCommand = (int)myTransform.localScale.x;
        }
        return num;
    }

    public virtual float bonusControl()
    {
        float result = 0f;
        if (perks[0] == 15)
        {
            result = DB.perks[15].rankBonuses[perkRanks[0]];
        }
        else if (perks[1] == 15)
        {
            result = DB.perks[15].rankBonuses[perkRanks[1]];
        }
        else if (perks[2] == 15)
        {
            result = DB.perks[15].rankBonuses[perkRanks[2]];
        }
        return result;
    }

    public virtual float victimizer()
    {
        float result = 1f;
        if (perks[0] == 22)
        {
            result = DB.perks[22].rankBonuses[perkRanks[0]];
            result = (result + 100f) / 100f;
        }
        else if (perks[1] == 22)
        {
            result = DB.perks[22].rankBonuses[perkRanks[1]];
            result = (result + 100f) / 100f;
        }
        else if (perks[2] == 22)
        {
            result = DB.perks[22].rankBonuses[perkRanks[2]];
            result = (result + 100f) / 100f;
        }
        return result;
    }

    public virtual void introSequence()
    {
        if (!(myTransform.position.x >= movementTarget.x))
        {
            movementVector = new Vector3(1f, 0f, 0f) * weaponSpeedMod;
        }
        else
        {
            movementVector = new Vector3(0f, 0f, 0f);
        }
    }

    public virtual void MenuInitialize()
    {
        if ((bool)GameObject.Find("**DATABASE"))
        {
            DB = (Database)GameObject.Find("**DATABASE").GetComponent(typeof(Database));
        }
        else
        {
            DB = (Database)GameObject.Find("**DATABASE_Sandbox").GetComponent(typeof(Database));
        }
        for (int i = 0; i < 3; i++)
        {
            weapons[i] = (int)DB.PCs[DB.myPC].weapons[i];
            perks[i] = (int)DB.PCs[DB.myPC].perks[i];
            if (perks[i] != 99)
            {
                perkRanks[i] = (int)DB.perks[perks[i]].rank;
            }
        }
        myTransform = transform;
        myAnimation = (Animation)myTransform.Find("MayaFile").GetComponent(typeof(Animation));
        myRenderers[0] = (Renderer)myTransform.Find("MayaFile/primaryGeo").GetComponent(typeof(Renderer));
        myRenderers[1] = (Renderer)myTransform.Find("MayaFile/rightArmGeo").GetComponent(typeof(Renderer));
        myRenderers[2] = (Renderer)myTransform.Find("MayaFile/leftArmGeo").GetComponent(typeof(Renderer));
        myTransform.Find("MayaFile/primaryGeo").gameObject.layer = 14;
        myTransform.Find("MayaFile/rightArmGeo").gameObject.layer = 14;
        myTransform.Find("MayaFile/leftArmGeo").gameObject.layer = 14;
        pistolSocket = myTransform.Find("MayaFile/leftArm/leftHand_gun");
        meleeSocket = myTransform.Find("MayaFile/leftArm/leftHand_melee");
        shotgunSocket = myTransform.Find("MayaFile/rightArm_shotty");
        dualSocket = myTransform.Find("MayaFile/rightArm_dual/dualWieldGrip");
        torsoSocket = myTransform.Find("MayaFile/torso");
        instantiateMenuWeaponry();
        animLayerSetup();
        menuEquip(0, true);
        myTransform.name = "LocalPlayer";
    }

    public virtual void instantiateMenuWeaponry()
    {
        if (!ally)
        {
            for (int i = 0; i < 3; i++)
            {
                if (weapons[i] != 99)
                {
                    weaponNames[i] = DB.weapons[weapons[i]].weaponName;
                    weaponModels[i] = DB.weapons[weapons[i]].weaponModel;
                    animSets[i] = DB.weapons[weapons[i]].animSet;
                    DWstatus[i] = DB.weapons[weapons[i]].dualWield;
                    explosiveModels[i] = DB.weapons[weapons[i]].explosiveModel;
                    movementPenalties[i] = DB.weapons[weapons[i]].movementPenalty;
                    impactForces[i] = DB.weapons[weapons[i]].impactForce;
                    impactFalloffs[i] = DB.weapons[weapons[i]].impactFalloff;
                    shellTypes[i] = DB.weapons[weapons[i]].shellType;
                }
            }
        }
        for (int i = 0; i < Extensions.get_length(weapons); i++)
        {
            if (weapons[i] != 99)
            {
                tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(weaponModels[i]));
                tempGO.gameObject.layer = 14;
                tempTransform = tempGO.transform;
                if (animSets[i] == 0 || animSets[i] == 3 || animSets[i] == 8 || animSets[i] == 11)
                {
                    tempTransform.parent = pistolSocket;
                    tempTransform.localScale = new Vector3(1f, 1f, 1f);
                    tempTransform.localPosition = new Vector3(0f, 0f, 0f);
                }
                else if (animSets[i] == 1 || animSets[i] == 4 || animSets[i] == 5 || animSets[i] == 6 || animSets[i] == 9 || animSets[i] == 10 || animSets[i] == 12 || animSets[i] == 13)
                {
                    tempTransform.parent = shotgunSocket;
                    tempTransform.localScale = new Vector3(1f, 1f, 1f);
                    tempTransform.localPosition = new Vector3(0f, 0f, 0f);
                }
                else if (animSets[i] == 2 || animSets[i] == 7)
                {
                    tempTransform.parent = meleeSocket;
                    tempTransform.localScale = new Vector3(1f, 1f, 1f);
                    tempTransform.localPosition = new Vector3(0f, 0f, 0f);
                }
                weaponRenderers[i] = (Renderer)tempGO.GetComponent(typeof(Renderer));
                if (weaponRenderers[i] == null)
                {
                    weaponRenderers[i] = (Renderer)tempGO.transform.Find("geometry").GetComponent(typeof(Renderer));
                    weaponRockets[i] = tempGO.transform.Find("handle/rocket");
                    tempGO.transform.Find("geometry").gameObject.layer = 14;
                }
                if (DWstatus[i] || animSets[i] == 4 || animSets[i] == 10 || animSets[i] == 13)
                {
                    tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(weaponModels[i]));
                    tempGO.gameObject.layer = 14;
                    tempTransform = tempGO.transform;
                    tempTransform.parent = dualSocket;
                    tempTransform.localScale = new Vector3(1f, 1f, 1f);
                    tempTransform.localPosition = new Vector3(0f, 0f, 0f);
                    weaponRenderers[i + 3] = (Renderer)tempGO.GetComponent(typeof(Renderer));
                }
                if (DB.weapons[weapons[i]].backpack)
                {
                    tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load(weaponModels[i] + "BP"));
                    tempGO.gameObject.layer = 14;
                    tempTransform = tempGO.transform;
                    tempTransform.parent = torsoSocket;
                    tempTransform.localScale = new Vector3(1f, 1f, 1f);
                    tempTransform.localPosition = new Vector3(0f, 0f, 0f);
                    weaponRenderers[i + 6] = (Renderer)tempGO.GetComponent(typeof(Renderer));
                }
                tempGO = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Sounds/" + weaponNames[i]));
                mySounds[i] = (SoundMachine)tempGO.GetComponent(typeof(SoundMachine));
            }
        }
    }

    public virtual void menuEquip(int whichSlot, bool silent)
    {
        if (weapons[whichSlot] == 99)
        {
            return;
        }
        equipDelay = 0.24f;
        equippedSlot = whichSlot;
        for (int i = 0; i < Extensions.get_length(weaponRenderers); i++)
        {
            if ((bool)weaponRenderers[i])
            {
                weaponRenderers[i].enabled = false;
                if (weaponRenderers[i].material.mainTextureOffset.x != 0f)
                {
                    int num = 0;
                    Vector2 mainTextureOffset = weaponRenderers[i].material.mainTextureOffset;
                    float num2 = (mainTextureOffset.x = num);
                    Vector2 vector2 = (weaponRenderers[i].material.mainTextureOffset = mainTextureOffset);
                }
            }
        }
        weaponRenderers[whichSlot].enabled = true;
        if (weaponRenderers[whichSlot + 3] != null)
        {
            weaponRenderers[whichSlot + 3].enabled = true;
        }
        if (weaponRenderers[whichSlot + 6] != null)
        {
            weaponRenderers[whichSlot + 6].enabled = true;
        }
        animSet = animSets[whichSlot];
        loadAnimSet(animSet);
        myAnimation.Play(idleAnim);
        rateOfFire = DB.weapons[weapons[equippedSlot]].rateOfFire;
        if (!silent)
        {
            myAnimation.Play(equipAnim);
            equipState.normalizedTime = 0.1f;
        }
        if ((bool)weaponRockets[equippedSlot])
        {
            int num3 = 1;
            Vector3 localScale = weaponRockets[equippedSlot].localScale;
            float num4 = (localScale.x = num3);
            Vector3 vector4 = (weaponRockets[equippedSlot].localScale = localScale);
        }
    }

    public virtual void changeLayer(int whichLayer)
    {
        for (int i = 0; i < Extensions.get_length(weaponRenderers); i++)
        {
            if ((bool)weaponRenderers[i])
            {
                weaponRenderers[i].gameObject.layer = whichLayer;
            }
        }
        for (int i = 0; i < Extensions.get_length(myRenderers); i++)
        {
            if ((bool)myRenderers[i])
            {
                myRenderers[i].gameObject.layer = whichLayer;
            }
        }
    }

    public virtual IEnumerator gainPickup(int whichPickup, float percentage)
    {
        return new _0024gainPickup_00241931(whichPickup, this).GetEnumerator();
    }

    public virtual IEnumerator grabHelicopter(string noArgument)
    {
        return new _0024grabHelicopter_00241938(this).GetEnumerator();
    }

    public virtual void enterVehicle(string whichVehicleString)
    {
        if (DB.multiplayer && !ally)
        {
            broadcast("Ally", "enterVehicle", whichVehicleString, true);
        }
        int num = UnityBuiltins.parseInt(whichVehicleString);
        inVehicle = true;
        myVehicle = num;
        myTransform.position = motherBrain.vehicles[num].myTransform.position;
        movementLockout = 1f;
        motherBrain.vehicles[num].myParent = myTransform;
        motherBrain.vehicles[num].occupied = true;
        invincible = true;
        for (int i = 0; i < Extensions.get_length(myRenderers); i++)
        {
            if ((bool)myRenderers[i])
            {
                myRenderers[i].enabled = false;
            }
        }
        for (int i = 0; i < Extensions.get_length(weaponRenderers); i++)
        {
            if ((bool)weaponRenderers[i])
            {
                weaponRenderers[i].enabled = false;
            }
        }
        motherBrain.sounds[9].Play();
    }

    public virtual void explodeVehicle(string whichVehicleString)
    {
        myVehicle = -1;
        if (DB.multiplayer && !ally)
        {
            broadcast("Ally", "explodeVehicle", whichVehicleString, true);
        }
        int num = UnityBuiltins.parseInt(whichVehicleString);
        inVehicle = false;
        motherBrain.vehicles[num].myParent = null;
        motherBrain.vehicles[num].remainingGas = 0f;
        invincible = false;
        float y = motherBrain.vehicles[num].myTransform.position.y + 10000f;
        Vector3 position = motherBrain.vehicles[num].myTransform.position;
        float num2 = (position.y = y);
        Vector3 vector2 = (motherBrain.vehicles[num].myTransform.position = position);
        for (int i = 0; i < Extensions.get_length(myRenderers); i++)
        {
            if ((bool)myRenderers[i])
            {
                myRenderers[i].enabled = true;
            }
        }
        equip(equippedSlot, true);
        motherBrain.sounds[12].Play();
        motherBrain.vehicleExplosions[motherBrain.whichVehicleExplosion].explode(myTransform.position);
        motherBrain.whichVehicleExplosion++;
        if (motherBrain.whichVehicleExplosion > 1)
        {
            motherBrain.whichVehicleExplosion = 0;
        }
        motherBrain.cameraShaker.Stop();
        motherBrain.cameraShaker.Play("shake");
    }

    public virtual void eject(PlayerScript theScriptWhoGetsTheVehicle)
    {
        movementLockout = 0f;
        inVehicle = false;
        motherBrain.vehicles[myVehicle].myParent = theScriptWhoGetsTheVehicle.myTransform;
        myVehicle = -1;
        invincible = false;
        for (int i = 0; i < Extensions.get_length(myRenderers); i++)
        {
            if ((bool)myRenderers[i])
            {
                myRenderers[i].enabled = true;
            }
        }
        equip(equippedSlot, true);
    }

    public virtual void Main()
    {
    }
}
