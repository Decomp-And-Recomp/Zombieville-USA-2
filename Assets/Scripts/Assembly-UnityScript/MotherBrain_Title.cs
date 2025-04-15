using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Prime31;
using UnityEngine;
using UnityScript.Lang;

[Serializable]
public class MotherBrain_Title : MonoBehaviour
{
	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024titleInput_00241850 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Vector3 _0024tempVector_00241851;

			internal bool _0024inputDetected_00241852;

			internal Vector2 _0024touchPosition_00241853;

			internal Ray _0024tempRay_00241854;

			internal RaycastHit _0024tempHit_00241855;

			internal int _0024i_00241856;

			internal bool _0024didSync_00241857;

			internal float _0024_00241256_00241858;

			internal Color _0024_00241257_00241859;

			internal float _0024_00241258_00241860;

			internal Color _0024_00241259_00241861;

			internal int _0024_00241260_00241862;

			internal Color _0024_00241261_00241863;

			internal float _0024_00241262_00241864;

			internal Color _0024_00241263_00241865;

			internal float _0024_00241264_00241866;

			internal Color _0024_00241265_00241867;

			internal float _0024_00241266_00241868;

			internal Color _0024_00241267_00241869;

			internal float _0024_00241268_00241870;

			internal Color _0024_00241269_00241871;

			internal float _0024_00241270_00241872;

			internal Vector3 _0024_00241271_00241873;

			internal float _0024_00241272_00241874;

			internal Vector3 _0024_00241273_00241875;

			internal float _0024_00241274_00241876;

			internal Vector3 _0024_00241275_00241877;

			internal float _0024_00241276_00241878;

			internal Color _0024_00241277_00241879;

			internal float _0024_00241278_00241880;

			internal Color _0024_00241279_00241881;

			internal float _0024_00241280_00241882;

			internal Color _0024_00241281_00241883;

			internal int _0024_00241282_00241884;

			internal Vector3 _0024_00241283_00241885;

			internal int _0024_00241284_00241886;

			internal Vector3 _0024_00241285_00241887;

			internal float _0024_00241286_00241888;

			internal Color _0024_00241287_00241889;

			internal float _0024_00241288_00241890;

			internal Color _0024_00241289_00241891;

			internal float _0024_00241290_00241892;

			internal Color _0024_00241291_00241893;

			internal float _0024_00241292_00241894;

			internal Color _0024_00241293_00241895;

			internal float _0024_00241294_00241896;

			internal Color _0024_00241295_00241897;

			internal float _0024_00241296_00241898;

			internal Color _0024_00241297_00241899;

			internal MotherBrain_Title _0024self__00241900;

			public _0024(MotherBrain_Title self_)
			{
				_0024self__00241900 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					if (_0024self__00241900.menuBacker.activeSelf)
					{
						_0024self__00241900.menuBacker.SetActive(false);
						_0024self__00241900.connecting.SetActive(false);
						_0024self__00241900.StartCoroutine(_0024self__00241900.menuTransition(_0024self__00241900.back2Light, _0024self__00241900.back2Renderer, "back2", "reveal2ndPage"));
					}
					_0024tempVector_00241851 = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
					_0024self__00241900.cursor.position = _0024self__00241900.cursor.position + _0024tempVector_00241851 * Time.deltaTime * 2f;
					if (Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f)
					{
						_0024self__00241900.cursorTimer = 2f;
					}
					else
					{
						_0024self__00241900.cursorTimer -= Time.deltaTime;
					}
					if (!(_0024self__00241900.cursorTimer <= 0f))
					{
						_0024self__00241900.cursorRenderer.enabled = true;
						if (!(_0024self__00241900.cursorRenderer.material.color.a >= 1f))
						{
							float num5 = (_0024_00241256_00241858 = _0024self__00241900.cursorRenderer.material.color.a + 3f * Time.deltaTime);
							Color color = (_0024_00241257_00241859 = _0024self__00241900.cursorRenderer.material.color);
							float num6 = (_0024_00241257_00241859.a = _0024_00241256_00241858);
							Color color3 = (_0024self__00241900.cursorRenderer.material.color = _0024_00241257_00241859);
						}
					}
					if (!(_0024self__00241900.cursorTimer > 0f) && !(_0024self__00241900.cursorRenderer.material.color.a <= 0f))
					{
						float num7 = (_0024_00241258_00241860 = _0024self__00241900.cursorRenderer.material.color.a - 2f * Time.deltaTime);
						Color color4 = (_0024_00241259_00241861 = _0024self__00241900.cursorRenderer.material.color);
						float num8 = (_0024_00241259_00241861.a = _0024_00241258_00241860);
						Color color6 = (_0024self__00241900.cursorRenderer.material.color = _0024_00241259_00241861);
						if (!(_0024self__00241900.cursorRenderer.material.color.a > 0f))
						{
							int num9 = (_0024_00241260_00241862 = 0);
							Color color7 = (_0024_00241261_00241863 = _0024self__00241900.cursorRenderer.material.color);
							float num10 = (_0024_00241261_00241863.a = _0024_00241260_00241862);
							Color color9 = (_0024self__00241900.cursorRenderer.material.color = _0024_00241261_00241863);
							_0024self__00241900.cursorRenderer.enabled = false;
						}
					}
					if (!(_0024self__00241900.cursorRenderer.material.color.r <= 0.25f))
					{
						float num11 = (_0024_00241262_00241864 = _0024self__00241900.cursorRenderer.material.color.r - Time.deltaTime * 3f);
						Color color10 = (_0024_00241263_00241865 = _0024self__00241900.cursorRenderer.material.color);
						float num12 = (_0024_00241263_00241865.r = _0024_00241262_00241864);
						Color color12 = (_0024self__00241900.cursorRenderer.material.color = _0024_00241263_00241865);
						if (!(_0024self__00241900.cursorRenderer.material.color.r >= 0.25f))
						{
							float num13 = (_0024_00241264_00241866 = 0.25f);
							Color color13 = (_0024_00241265_00241867 = _0024self__00241900.cursorRenderer.material.color);
							float num14 = (_0024_00241265_00241867.r = _0024_00241264_00241866);
							Color color15 = (_0024self__00241900.cursorRenderer.material.color = _0024_00241265_00241867);
						}
						float num15 = (_0024_00241266_00241868 = _0024self__00241900.cursorRenderer.material.color.r);
						Color color16 = (_0024_00241267_00241869 = _0024self__00241900.cursorRenderer.material.color);
						float num16 = (_0024_00241267_00241869.g = _0024_00241266_00241868);
						Color color18 = (_0024self__00241900.cursorRenderer.material.color = _0024_00241267_00241869);
						float num17 = (_0024_00241268_00241870 = _0024self__00241900.cursorRenderer.material.color.r);
						Color color19 = (_0024_00241269_00241871 = _0024self__00241900.cursorRenderer.material.color);
						float num18 = (_0024_00241269_00241871.b = _0024_00241268_00241870);
						Color color21 = (_0024self__00241900.cursorRenderer.material.color = _0024_00241269_00241871);
					}
					if (_0024self__00241900.cursor.localScale.x != 0.33f)
					{
						float num19 = (_0024_00241270_00241872 = Mathf.Lerp(_0024self__00241900.cursor.localScale.x, 0.33f, 5f * Time.deltaTime));
						Vector3 vector7 = (_0024_00241271_00241873 = _0024self__00241900.cursor.localScale);
						float num20 = (_0024_00241271_00241873.x = _0024_00241270_00241872);
						Vector3 vector9 = (_0024self__00241900.cursor.localScale = _0024_00241271_00241873);
						float num21 = (_0024_00241272_00241874 = _0024self__00241900.cursor.localScale.x);
						Vector3 vector10 = (_0024_00241273_00241875 = _0024self__00241900.cursor.localScale);
						float num22 = (_0024_00241273_00241875.y = _0024_00241272_00241874);
						Vector3 vector12 = (_0024self__00241900.cursor.localScale = _0024_00241273_00241875);
						float num23 = (_0024_00241274_00241876 = _0024self__00241900.cursor.localScale.x);
						Vector3 vector13 = (_0024_00241275_00241877 = _0024self__00241900.cursor.localScale);
						float num24 = (_0024_00241275_00241877.z = _0024_00241274_00241876);
						Vector3 vector15 = (_0024self__00241900.cursor.localScale = _0024_00241275_00241877);
					}
					_0024inputDetected_00241852 = false;
					_0024touchPosition_00241853 = default(Vector2);
					if ((Input.GetButtonDown("Fire1") && !_0024self__00241900.lockInput && _0024self__00241900.cursorTimer > 0f) || (Input.GetButtonDown("Fire2") && !_0024self__00241900.lockInput && _0024self__00241900.cursorTimer > 0f) || (Input.GetButtonDown("Fire3") && !_0024self__00241900.lockInput && !(_0024self__00241900.cursorTimer <= 0f)))
					{
						_0024inputDetected_00241852 = true;
						_0024touchPosition_00241853 = _0024self__00241900.cameraLens.WorldToScreenPoint(_0024self__00241900.cursor.position);
						float num25 = (_0024_00241276_00241878 = 0.5f);
						Color color22 = (_0024_00241277_00241879 = _0024self__00241900.cursorRenderer.material.color);
						float num26 = (_0024_00241277_00241879.r = _0024_00241276_00241878);
						Color color24 = (_0024self__00241900.cursorRenderer.material.color = _0024_00241277_00241879);
						float num27 = (_0024_00241278_00241880 = 0.5f);
						Color color25 = (_0024_00241279_00241881 = _0024self__00241900.cursorRenderer.material.color);
						float num28 = (_0024_00241279_00241881.g = _0024_00241278_00241880);
						Color color27 = (_0024self__00241900.cursorRenderer.material.color = _0024_00241279_00241881);
						float num29 = (_0024_00241280_00241882 = 0.5f);
						Color color28 = (_0024_00241281_00241883 = _0024self__00241900.cursorRenderer.material.color);
						float num30 = (_0024_00241281_00241883.b = _0024_00241280_00241882);
						Color color30 = (_0024self__00241900.cursorRenderer.material.color = _0024_00241281_00241883);
						_0024self__00241900.cursor.localScale = new Vector3(0.4f, 0.4f, 0.4f);
					}
					if (Input.GetMouseButtonDown(0) && !_0024self__00241900.lockInput)
					{
						_0024inputDetected_00241852 = true;
						_0024touchPosition_00241853 = Input.mousePosition;
					}
					else if (Input.touchCount > 0 && !_0024self__00241900.lockInput)
					{
						_0024inputDetected_00241852 = true;
						_0024touchPosition_00241853 = Input.GetTouch(0).position;
					}
					else
					{
						_0024self__00241900.holdingFingerDown = false;
					}
					if (_0024inputDetected_00241852)
					{
						_0024tempRay_00241854 = _0024self__00241900.cameraLens.ScreenPointToRay(_0024touchPosition_00241853);
						_0024tempHit_00241855 = default(RaycastHit);
						if (Physics.Raycast(_0024tempRay_00241854, out _0024tempHit_00241855, 100f, _0024self__00241900.HUDmask))
						{
							_0024self__00241900.tempTransform = _0024tempHit_00241855.transform;
							if (_0024self__00241900.tempTransform.name == "Button_Play")
							{
								if (_0024self__00241900.DB.tutorial)
								{
									_0024self__00241900.playLight.enabled = true;
									_0024self__00241900.playRenderer.enabled = false;
									_0024self__00241900.lockInput = true;
									_0024self__00241900.fade = true;
									_0024self__00241900.menuSound.Play();
									result = (Yield(2, new WaitForSeconds(1.6f)) ? 1 : 0);
									break;
								}
								_0024self__00241900.StartCoroutine(_0024self__00241900.menuTransition(_0024self__00241900.playLight, _0024self__00241900.playRenderer, "hitPlay", "reveal2ndPage"));
							}
							else if (_0024self__00241900.tempTransform.name == "tellmemore")
							{
								for (_0024i_00241856 = 0; _0024i_00241856 < Extensions.get_length(_0024self__00241900.adRenderers); _0024i_00241856++)
								{
									_0024self__00241900.adRenderers[_0024i_00241856].enabled = false;
								}
								for (_0024i_00241856 = 0; _0024i_00241856 < Extensions.get_length(_0024self__00241900.adColliders); _0024i_00241856++)
								{
									_0024self__00241900.adColliders[_0024i_00241856].enabled = false;
								}
								Application.OpenURL("https://play.google.com/store/apps/details?id=com.MikaMobile.LostFrontier");
							}
							else if (_0024self__00241900.tempTransform.name == "notinterested")
							{
								_0024self__00241900.menuSound.Play();
								for (_0024i_00241856 = 0; _0024i_00241856 < Extensions.get_length(_0024self__00241900.adRenderers); _0024i_00241856++)
								{
									_0024self__00241900.adRenderers[_0024i_00241856].enabled = false;
								}
								for (_0024i_00241856 = 0; _0024i_00241856 < Extensions.get_length(_0024self__00241900.adColliders); _0024i_00241856++)
								{
									_0024self__00241900.adColliders[_0024i_00241856].enabled = false;
								}
							}
							else if (_0024self__00241900.tempTransform.name == "newgamebutton")
							{
								_0024self__00241900.menuSound.Play();
								for (_0024i_00241856 = 0; _0024i_00241856 < Extensions.get_length(_0024self__00241900.adRenderers); _0024i_00241856++)
								{
									_0024self__00241900.adRenderers[_0024i_00241856].enabled = true;
								}
								for (_0024i_00241856 = 0; _0024i_00241856 < Extensions.get_length(_0024self__00241900.adColliders); _0024i_00241856++)
								{
									_0024self__00241900.adColliders[_0024i_00241856].enabled = true;
								}
							}
							else if (_0024self__00241900.tempTransform.name == "Button_Options")
							{
								_0024self__00241900.StartCoroutine(_0024self__00241900.menuTransition(_0024self__00241900.optionLight, _0024self__00241900.optionRenderer, "hitOptions", "revealOptions"));
								_0024self__00241900.DB.save();
								_0024self__00241900.cloudString.text = _0024self__00241900.DB.megaString;
							}
							else if (_0024self__00241900.tempTransform.name == "Button_GC")
							{
								_0024self__00241900.StartCoroutine(_0024self__00241900.menuTransition(_0024self__00241900.GCpageLight, _0024self__00241900.GCpageRenderer, "hitGC", "revealGCPage"));
							}
							else if (_0024self__00241900.tempTransform.name == "Button_SFX" && !_0024self__00241900.holdingFingerDown)
							{
								_0024self__00241900.holdingFingerDown = true;
								if (_0024self__00241900.DB.soundEnabled)
								{
									_0024self__00241900.DB.soundEnabled = false;
									_0024self__00241900.menuSound.volume = 0f;
								}
								else
								{
									_0024self__00241900.menuSound.Play();
									_0024self__00241900.DB.soundEnabled = true;
									_0024self__00241900.menuSound.volume = 1f;
								}
							}
							else if (_0024self__00241900.tempTransform.name == "Button_Upload" && !_0024self__00241900.holdingFingerDown && _0024self__00241900.cloudUpload.enabled)
							{
								_0024self__00241900.holdingFingerDown = true;
								_0024self__00241900.menuSound.Play();
								_0024self__00241900.cloudUpload.enabled = false;
								_0024self__00241900.cloudUploadLight.enabled = true;
								_0024self__00241900.StartCoroutine(_0024self__00241900.turnOffLights());
							}
							else if (_0024self__00241900.tempTransform.name == "Button_Download" && !_0024self__00241900.holdingFingerDown && _0024self__00241900.cloudDownload.enabled)
							{
								_0024self__00241900.holdingFingerDown = true;
								_0024self__00241900.menuSound.Play();
								_0024self__00241900.cloudDownload.enabled = false;
								_0024self__00241900.cloudDownloadLight.enabled = true;
								_0024self__00241900.StartCoroutine(_0024self__00241900.turnOffLights());
							}
							else if (_0024self__00241900.tempTransform.name == "Button_Music" && !_0024self__00241900.holdingFingerDown)
							{
								_0024self__00241900.holdingFingerDown = true;
								_0024self__00241900.menuSound.Play();
								if (_0024self__00241900.DB.musicEnabled)
								{
									_0024self__00241900.DB.musicEnabled = false;
								}
								else
								{
									_0024self__00241900.DB.musicEnabled = true;
								}
							}
							else if (_0024self__00241900.tempTransform.name == "Button_iCloud" && !_0024self__00241900.holdingFingerDown)
							{
								_0024self__00241900.holdingFingerDown = true;
								_0024self__00241900.menuSound.Play();
								if (_0024self__00241900.DB.iCloud)
								{
									_0024self__00241900.DB.iCloud = false;
								}
								else
								{
									_0024self__00241900.DB.iCloud = true;
									_0024didSync_00241857 = P31Prefs.synchronize();
									Debug.Log("did synchronize: " + _0024didSync_00241857);
								}
							}
							else if (_0024self__00241900.tempTransform.name == "Button_GamecenterOption" && !_0024self__00241900.holdingFingerDown)
							{
								_0024self__00241900.holdingFingerDown = true;
								_0024self__00241900.menuSound.Play();
								if (_0024self__00241900.DB.GCactive)
								{
									_0024self__00241900.DB.GCactive = false;
								}
							}
							else
							{
								if (_0024self__00241900.tempTransform.name == "Button_HighScores")
								{
									_0024self__00241900.highscoresLight.enabled = true;
									_0024self__00241900.highscoresRenderer.enabled = false;
									_0024self__00241900.lockInput = true;
									_0024self__00241900.menuSound.Play();
									result = (Yield(3, new WaitForSeconds(0.5f)) ? 1 : 0);
									break;
								}
								if (_0024self__00241900.tempTransform.name == "Button_Achievements")
								{
									_0024self__00241900.StartCoroutine(_0024self__00241900.DB.forceUploadAchievementData());
									_0024self__00241900.achieveLight.enabled = true;
									_0024self__00241900.achieveRenderer.enabled = false;
									_0024self__00241900.lockInput = true;
									_0024self__00241900.menuSound.Play();
									result = (Yield(5, new WaitForSeconds(0.5f)) ? 1 : 0);
									break;
								}
								if (_0024self__00241900.tempTransform.name == "Button_Back")
								{
									_0024self__00241900.StartCoroutine(_0024self__00241900.menuTransition(_0024self__00241900.backLight, _0024self__00241900.backRenderer, "back1", "revealButtons"));
								}
								else if (_0024self__00241900.tempTransform.name == "Button_Back2")
								{
									_0024self__00241900.connecting.SetActive(false);
									float num31 = (_0024_00241286_00241888 = 0.5f);
									Color color31 = (_0024_00241287_00241889 = _0024self__00241900.privateText.material.color);
									float num32 = (_0024_00241287_00241889.a = _0024_00241286_00241888);
									Color color33 = (_0024self__00241900.privateText.material.color = _0024_00241287_00241889);
									float num33 = (_0024_00241288_00241890 = 0.5f);
									Color color34 = (_0024_00241289_00241891 = _0024self__00241900.publicText.material.color);
									float num34 = (_0024_00241289_00241891.a = _0024_00241288_00241890);
									Color color36 = (_0024self__00241900.publicText.material.color = _0024_00241289_00241891);
									_0024self__00241900.StartCoroutine(_0024self__00241900.menuTransition(_0024self__00241900.back2Light, _0024self__00241900.back2Renderer, "back2", "reveal2ndPage"));
								}
								else if (_0024self__00241900.tempTransform.name == "Button_Back3")
								{
									_0024self__00241900.StartCoroutine(_0024self__00241900.menuTransition(_0024self__00241900.back3Light, _0024self__00241900.back3Renderer, "back3", "revealButtons"));
								}
								else if (_0024self__00241900.tempTransform.name == "Button_Back4")
								{
									_0024self__00241900.StartCoroutine(_0024self__00241900.menuTransition(_0024self__00241900.back4Light, _0024self__00241900.back4Renderer, "back4", "revealButtons"));
								}
								else
								{
									if (_0024self__00241900.tempTransform.name == "Button_Solo")
									{
										_0024self__00241900.soloLight.enabled = true;
										_0024self__00241900.soloRenderer.enabled = false;
										_0024self__00241900.lockInput = true;
										_0024self__00241900.fade = true;
										_0024self__00241900.menuSound.Play();
										result = (Yield(7, new WaitForSeconds(1.6f)) ? 1 : 0);
										break;
									}
									if (_0024self__00241900.tempTransform.name == "Button_Coop")
									{
										_0024self__00241900.StartCoroutine(_0024self__00241900.menuTransition(_0024self__00241900.coopLight, _0024self__00241900.coopRenderer, "hitCoop", "reveal3rdPage"));
										_0024self__00241900.connecting.SetActive(true);
									}
									else
									{
										if (_0024self__00241900.tempTransform.name == "Button_Bluetooth" && !(_0024self__00241900.privateText.material.color.a <= 0.9f))
										{
											float num35 = (_0024_00241290_00241892 = 0.5f);
											Color color37 = (_0024_00241291_00241893 = _0024self__00241900.publicText.material.color);
											float num36 = (_0024_00241291_00241893.a = _0024_00241290_00241892);
											Color color39 = (_0024self__00241900.publicText.material.color = _0024_00241291_00241893);
											float num37 = (_0024_00241292_00241894 = 0.5f);
											Color color40 = (_0024_00241293_00241895 = _0024self__00241900.privateText.material.color);
											float num38 = (_0024_00241293_00241895.a = _0024_00241292_00241894);
											Color color42 = (_0024self__00241900.privateText.material.color = _0024_00241293_00241895);
											_0024self__00241900.BTLight.enabled = true;
											_0024self__00241900.BTRenderer.enabled = false;
											_0024self__00241900.lockInput = true;
											_0024self__00241900.menuSound.Play();
											result = (Yield(8, new WaitForSeconds(0.1f)) ? 1 : 0);
											break;
										}
										if (_0024self__00241900.tempTransform.name == "Button_Gamecenter" && !(_0024self__00241900.publicText.material.color.a <= 0.9f))
										{
											float num39 = (_0024_00241294_00241896 = 0.5f);
											Color color43 = (_0024_00241295_00241897 = _0024self__00241900.publicText.material.color);
											float num40 = (_0024_00241295_00241897.a = _0024_00241294_00241896);
											Color color45 = (_0024self__00241900.publicText.material.color = _0024_00241295_00241897);
											float num41 = (_0024_00241296_00241898 = 0.5f);
											Color color46 = (_0024_00241297_00241899 = _0024self__00241900.privateText.material.color);
											float num42 = (_0024_00241297_00241899.a = _0024_00241296_00241898);
											Color color48 = (_0024self__00241900.privateText.material.color = _0024_00241297_00241899);
											_0024self__00241900.GCLight.enabled = true;
											_0024self__00241900.GCRenderer.enabled = false;
											_0024self__00241900.lockInput = true;
											_0024self__00241900.menuSound.Play();
											result = (Yield(10, new WaitForSeconds(0.1f)) ? 1 : 0);
											break;
										}
									}
								}
							}
						}
					}
					goto IL_1bd2;
				case 2:
					_0024self__00241900.DB.levelToLoad = "sandbox";
					Application.LoadLevel("sandbox");
					goto IL_1bd2;
				case 3:
				{
					int num3 = (_0024_00241282_00241884 = 1);
					Vector3 vector4 = (_0024_00241283_00241885 = _0024self__00241900.showLeaderboard.position);
					float num4 = (_0024_00241283_00241885.x = _0024_00241282_00241884);
					Vector3 vector6 = (_0024self__00241900.showLeaderboard.position = _0024_00241283_00241885);
					result = (Yield(4, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				}
				case 4:
					_0024self__00241900.lockInput = false;
					_0024self__00241900.highscoresLight.enabled = false;
					_0024self__00241900.highscoresRenderer.enabled = true;
					goto IL_1bd2;
				case 5:
				{
					int num = (_0024_00241284_00241886 = 1);
					Vector3 vector = (_0024_00241285_00241887 = _0024self__00241900.showAchieve.position);
					float num2 = (_0024_00241285_00241887.x = _0024_00241284_00241886);
					Vector3 vector3 = (_0024self__00241900.showAchieve.position = _0024_00241285_00241887);
					result = (Yield(6, new WaitForSeconds(0.1f)) ? 1 : 0);
					break;
				}
				case 6:
					_0024self__00241900.lockInput = false;
					_0024self__00241900.achieveLight.enabled = false;
					_0024self__00241900.achieveRenderer.enabled = true;
					goto IL_1bd2;
				case 7:
					_0024self__00241900.DB.whichPlayerAmI = 1;
					_0024self__00241900.DB.levelToLoad = "mainMenu";
					Application.LoadLevel("middleman");
					goto IL_1bd2;
				case 8:
					_0024self__00241900.connectPrivate.SetActive(true);
					result = (Yield(9, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 9:
					_0024self__00241900.lockInput = false;
					_0024self__00241900.BTLight.enabled = false;
					_0024self__00241900.BTRenderer.enabled = true;
					goto IL_1bd2;
				case 10:
					_0024self__00241900.connectPublic.SetActive(true);
					result = (Yield(11, new WaitForSeconds(0.2f)) ? 1 : 0);
					break;
				case 11:
					_0024self__00241900.lockInput = false;
					_0024self__00241900.GCLight.enabled = false;
					_0024self__00241900.GCRenderer.enabled = true;
					goto IL_1bd2;
				case 1:
					{
						result = 0;
						break;
					}
					IL_1bd2:
					YieldDefault(1);
					goto case 1;
				}
				return (byte)result != 0;
			}
		}

		internal MotherBrain_Title _0024self__00241901;

		public _0024titleInput_00241850(MotherBrain_Title self_)
		{
			_0024self__00241901 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241901);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024menuTransition_00241902 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal Renderer _0024whichLight_00241903;

			internal Renderer _0024whichButton_00241904;

			internal string _0024firstAnim_00241905;

			internal string _0024secondAnim_00241906;

			internal MotherBrain_Title _0024self__00241907;

			public _0024(Renderer whichLight, Renderer whichButton, string firstAnim, string secondAnim, MotherBrain_Title self_)
			{
				_0024whichLight_00241903 = whichLight;
				_0024whichButton_00241904 = whichButton;
				_0024firstAnim_00241905 = firstAnim;
				_0024secondAnim_00241906 = secondAnim;
				_0024self__00241907 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241907.lockInput = true;
					_0024whichLight_00241903.enabled = true;
					_0024whichButton_00241904.enabled = false;
					_0024self__00241907.menuSound.Play();
					_0024self__00241907.menuAnimation.Play(_0024firstAnim_00241905);
					if (_0024firstAnim_00241905 == "back4" && _0024secondAnim_00241906 == "revealButtons")
					{
						_0024self__00241907.deleteDataAnim.Play("hide");
					}
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241907.lockInput = false;
					_0024whichLight_00241903.enabled = false;
					_0024whichButton_00241904.enabled = true;
					_0024self__00241907.menuAnimation.Play(_0024secondAnim_00241906);
					if (_0024secondAnim_00241906 == "revealOptions")
					{
						_0024self__00241907.deleteDataAnim.Play("show");
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

		internal Renderer _0024whichLight_00241908;

		internal Renderer _0024whichButton_00241909;

		internal string _0024firstAnim_00241910;

		internal string _0024secondAnim_00241911;

		internal MotherBrain_Title _0024self__00241912;

		public _0024menuTransition_00241902(Renderer whichLight, Renderer whichButton, string firstAnim, string secondAnim, MotherBrain_Title self_)
		{
			_0024whichLight_00241908 = whichLight;
			_0024whichButton_00241909 = whichButton;
			_0024firstAnim_00241910 = firstAnim;
			_0024secondAnim_00241911 = secondAnim;
			_0024self__00241912 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024whichLight_00241908, _0024whichButton_00241909, _0024firstAnim_00241910, _0024secondAnim_00241911, _0024self__00241912);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024ConnectionMade_00241913 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MotherBrain_Title _0024self__00241914;

			public _0024(MotherBrain_Title self_)
			{
				_0024self__00241914 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					_0024self__00241914.DB.multiplayer = true;
					_0024self__00241914.DB.whichPlayerAmI = (int)_0024self__00241914.whichPlayer.position.x;
					_0024self__00241914.fade = true;
					_0024self__00241914.DB.levelToLoad = "mainMenu";
					result = (Yield(2, new WaitForSeconds(1.6f)) ? 1 : 0);
					break;
				case 2:
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

		internal MotherBrain_Title _0024self__00241915;

		public _0024ConnectionMade_00241913(MotherBrain_Title self_)
		{
			_0024self__00241915 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241915);
		}
	}

	[Serializable]
	[CompilerGenerated]
	internal sealed class _0024turnOffLights_00241916 : GenericGenerator<WaitForSeconds>
	{
		[Serializable]
		[CompilerGenerated]
		internal sealed class _0024 : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			internal MotherBrain_Title _0024self__00241917;

			public _0024(MotherBrain_Title self_)
			{
				_0024self__00241917 = self_;
			}

			public override bool MoveNext()
			{
				int result;
				switch (_state)
				{
				default:
					result = (Yield(2, new WaitForSeconds(0.5f)) ? 1 : 0);
					break;
				case 2:
					_0024self__00241917.cloudUpload.enabled = true;
					_0024self__00241917.cloudUploadLight.enabled = false;
					_0024self__00241917.cloudDownload.enabled = true;
					_0024self__00241917.cloudDownloadLight.enabled = false;
					YieldDefault(1);
					goto case 1;
				case 1:
					result = 0;
					break;
				}
				return (byte)result != 0;
			}
		}

		internal MotherBrain_Title _0024self__00241918;

		public _0024turnOffLights_00241916(MotherBrain_Title self_)
		{
			_0024self__00241918 = self_;
		}

		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new _0024(_0024self__00241918);
		}
	}

	public Renderer[] moreAndroidStuffToHide;

	public Renderer privateText;

	public Renderer publicText;

	public Transform showLeaderboard;

	public Transform showAchieve;

	public TextMesh cloudString;

	public TextMesh cloudString_Load;

	public TextMesh gamecenterText;

	public Renderer deleteDataText;

	public Renderer cloudUploadText;

	public Renderer cloudDownloadText;

	public Renderer cloudUpload;

	public Renderer cloudUploadLight;

	public Renderer cloudDownload;

	public Renderer cloudDownloadLight;

	public Renderer iCloudText;

	public Renderer gamecenterOptionText;

	public GameObject[] androidHUDon;

	public GameObject[] androidHUDoff;

	public GameObject connectPrivate;

	public GameObject connectPublic;

	public GameObject connecting;

	public GameObject menuBacker;

	public Transform whichPlayer;

	public Renderer fader;

	public Transform deleteData;

	public Renderer deleteDataRenderer;

	public Renderer deleteDataLight;

	public Animation deleteDataAnim;

	public Renderer[] adRenderers;

	public Collider[] adColliders;

	public Transform newGameButton;

	public Animation newGameButtonAnim;

	public Database DB;

	public AudioSource menuSound;

	public Renderer optionLight;

	public Renderer optionRenderer;

	public Renderer BTLight;

	public Renderer BTRenderer;

	public Renderer GCpageLight;

	public Renderer GCpageRenderer;

	public Renderer GCLight;

	public Renderer GCRenderer;

	public Renderer coopLight;

	public Renderer coopRenderer;

	public Renderer highscoresLight;

	public Renderer highscoresRenderer;

	public Renderer achieveLight;

	public Renderer achieveRenderer;

	public Renderer soloLight;

	public Renderer soloRenderer;

	public Renderer playLight;

	public Renderer playRenderer;

	public Renderer backLight;

	public Renderer backRenderer;

	public Renderer back2Light;

	public Renderer back2Renderer;

	public Renderer back3Light;

	public Renderer back3Renderer;

	public Renderer back4Light;

	public Renderer back4Renderer;

	public Renderer SFXLight;

	public Renderer SFXRenderer;

	public Renderer musicLight;

	public Renderer musicRenderer;

	public Camera cameraLens;

	public LayerMask HUDmask;

	public Transform cameraTransform;

	public Transform chopperMix;

	public Transform menuMix;

	public bool fade;

	public Transform[] buildings;

	public Transform[] buildingsBG;

	public Transform[] clouds;

	public fadeElement[] fadeArray;

	public Animation menuAnimation;

	private float buttonDelay;

	private float GCTimer;

	public AudioSource titleMusic;

	public float initialDelay;

	private Transform tempTransform;

	private bool lockInput;

	public Transform cursor;

	public Renderer cursorRenderer;

	public float cursorTimer;

	private bool holdingFingerDown;

	public float mainFadeSpeed;

	public Renderer VoiceRenderer;

	public Renderer VoiceLight;

	public Renderer GCoptionRenderer;

	public Renderer GCoptionLight;

	public Renderer iCloudLight;

	public Renderer iCloudRenderer;

	public MotherBrain_Title()
	{
		fade = true;
		buttonDelay = 4.2f;
		GCTimer = 3.6f;
		initialDelay = 0.7f;
		mainFadeSpeed = 1f;
	}

	public virtual void Awake()
	{
		float a = 0.5f;
		Color color = privateText.material.color;
		float num = (color.a = a);
		Color color3 = (privateText.material.color = color);
		float a2 = 0.5f;
		Color color4 = publicText.material.color;
		float num2 = (color4.a = a2);
		Color color6 = (publicText.material.color = color4);
		cloudUploadText.enabled = true;
		cloudDownloadText.enabled = true;
		cloudUpload.enabled = true;
		cloudDownload.enabled = true;
		for (int i = 0; i < Extensions.get_length(androidHUDon); i++)
		{
			androidHUDon[i].layer = 10;
		}
		for (int i = 0; i < Extensions.get_length(androidHUDoff); i++)
		{
			androidHUDoff[i].layer = 0;
		}
		for (int i = 0; i < Extensions.get_length(moreAndroidStuffToHide); i++)
		{
			moreAndroidStuffToHide[i].enabled = false;
		}
		iCloudText.enabled = false;
		gamecenterOptionText.enabled = false;
		gamecenterText.text = "Google Play";
		deleteDataText.enabled = false;
		deleteDataRenderer.enabled = false;
		fade = false;
		newGameButton.position = cameraLens.ViewportToWorldPoint(new Vector3(0f, 1f, 5f));
		deleteData.position = cameraLens.ViewportToWorldPoint(new Vector3(0f, 0f, 8f));
		menuAnimation["revealButtons"].AddMixingTransform(menuMix);
		menuAnimation["chopperIdle"].AddMixingTransform(chopperMix);
		menuAnimation["chopperIdle"].layer = 1;
		float y = -2.5f;
		Vector3 position = cameraTransform.position;
		float num3 = (position.y = y);
		Vector3 vector2 = (cameraTransform.position = position);
		if ((bool)GameObject.Find("**DATABASE"))
		{
			DB = (Database)GameObject.Find("**DATABASE").GetComponent(typeof(Database));
		}
		if (!DB.soundEnabled)
		{
			menuSound.volume = 0f;
		}
		if (DB.musicEnabled)
		{
			titleMusic.Play();
		}
	}

	public virtual void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
		if (!(initialDelay > 0f))
		{
			if (whichPlayer.position.x != 0f)
			{
				StartCoroutine(ConnectionMade());
			}
			StartCoroutine(titleInput());
			titleAnimation();
			fadeAnimation();
			scrollingAnimation();
			updateOptionLights();
		}
		else
		{
			initialDelay -= Time.deltaTime;
		}
		if (cloudString_Load.text != string.Empty)
		{
			DB.forceGoogleCloudLoad(cloudString_Load.text);
			cloudString_Load.text = string.Empty;
		}
	}

	public virtual IEnumerator titleInput()
	{
		return new _0024titleInput_00241850(this).GetEnumerator();
	}

	public virtual IEnumerator menuTransition(Renderer whichLight, Renderer whichButton, string firstAnim, string secondAnim)
	{
		return new _0024menuTransition_00241902(whichLight, whichButton, firstAnim, secondAnim, this).GetEnumerator();
	}

	public virtual void titleAnimation()
	{
		if (!(GCTimer <= 0f))
		{
			GCTimer -= Time.deltaTime;
			if (!(GCTimer >= 0f) && !DB.GCactive)
			{
			}
		}
		float y = Mathf.Lerp(cameraTransform.position.y, 0f, 2f * Time.deltaTime);
		Vector3 position = cameraTransform.position;
		float num = (position.y = y);
		Vector3 vector2 = (cameraTransform.position = position);
		for (int i = 0; i < Extensions.get_length(fadeArray); i++)
		{
			if (!(fadeArray[i].timeBeforeReveal <= 0f))
			{
				fadeArray[i].timeBeforeReveal = fadeArray[i].timeBeforeReveal - Time.deltaTime;
				if (fadeArray[i].myRenderer.material.color.a != 0f)
				{
					int num2 = 0;
					Color color = fadeArray[i].myRenderer.material.color;
					float num3 = (color.a = num2);
					Color color3 = (fadeArray[i].myRenderer.material.color = color);
				}
				continue;
			}
			if (!fadeArray[i].myRenderer.enabled)
			{
				fadeArray[i].myRenderer.enabled = true;
			}
			float a = fadeArray[i].myRenderer.material.color.a + fadeArray[i].fadeSpeed * Time.deltaTime;
			Color color4 = fadeArray[i].myRenderer.material.color;
			float num4 = (color4.a = a);
			Color color6 = (fadeArray[i].myRenderer.material.color = color4);
			if (!(fadeArray[i].myRenderer.material.color.a < 1f))
			{
				int num5 = 1;
				Color color7 = fadeArray[i].myRenderer.material.color;
				float num6 = (color7.a = num5);
				Color color9 = (fadeArray[i].myRenderer.material.color = color7);
			}
		}
		if (!(buttonDelay <= 0f))
		{
			buttonDelay -= Time.deltaTime;
			if (!(buttonDelay > 0f))
			{
				newGameButtonAnim.Play();
				menuAnimation.Play("revealButtons");
			}
		}
		menuAnimation.Play("chopperIdle");
	}

	public virtual void fadeAnimation()
	{
		if (fade)
		{
			if (!fader.enabled)
			{
				fader.enabled = true;
			}
			if (fader.material.color.a != 1f)
			{
				float a = fader.material.color.a + 0.8f * Time.deltaTime * mainFadeSpeed;
				Color color = fader.material.color;
				float num = (color.a = a);
				Color color3 = (fader.material.color = color);
				if (!(fader.material.color.a < 1f))
				{
					int num2 = 1;
					Color color4 = fader.material.color;
					float num3 = (color4.a = num2);
					Color color6 = (fader.material.color = color4);
				}
			}
		}
		else
		{
			if (fade)
			{
				return;
			}
			if (!fader.enabled && fader.material.color.a != 0f)
			{
				fader.enabled = true;
			}
			if (fader.material.color.a != 0f)
			{
				float a2 = fader.material.color.a - 0.8f * Time.deltaTime;
				Color color7 = fader.material.color;
				float num4 = (color7.a = a2);
				Color color9 = (fader.material.color = color7);
				if (!(fader.material.color.a > 0f))
				{
					int num5 = 0;
					Color color10 = fader.material.color;
					float num6 = (color10.a = num5);
					Color color12 = (fader.material.color = color10);
					fader.enabled = false;
				}
			}
		}
	}

	public virtual void scrollingAnimation()
	{
		for (int i = 0; i < 3; i++)
		{
			float x = buildings[i].position.x - 1.4f * Time.deltaTime;
			Vector3 position = buildings[i].position;
			float num = (position.x = x);
			Vector3 vector2 = (buildings[i].position = position);
			if (!(buildings[i].position.x >= -5.1f))
			{
				float x2 = buildings[i].position.x + 10.2f;
				Vector3 position2 = buildings[i].position;
				float num2 = (position2.x = x2);
				Vector3 vector4 = (buildings[i].position = position2);
			}
		}
		for (int i = 0; i < 3; i++)
		{
			float x3 = buildingsBG[i].position.x - 0.6f * Time.deltaTime;
			Vector3 position3 = buildingsBG[i].position;
			float num3 = (position3.x = x3);
			Vector3 vector6 = (buildingsBG[i].position = position3);
			if (!(buildingsBG[i].position.x >= -5.1f))
			{
				float x4 = buildingsBG[i].position.x + 10.2f;
				Vector3 position4 = buildingsBG[i].position;
				float num4 = (position4.x = x4);
				Vector3 vector8 = (buildingsBG[i].position = position4);
			}
		}
		for (int i = 0; i < 3; i++)
		{
			float x5 = clouds[i].position.x - 0.1f * Time.deltaTime;
			Vector3 position5 = clouds[i].position;
			float num5 = (position5.x = x5);
			Vector3 vector10 = (clouds[i].position = position5);
			if (!(clouds[i].position.x >= -4.4f))
			{
				float x6 = clouds[i].position.x + 8.8f;
				Vector3 position6 = clouds[i].position;
				float num6 = (position6.x = x6);
				Vector3 vector12 = (clouds[i].position = position6);
			}
		}
	}

	public virtual IEnumerator ConnectionMade()
	{
		return new _0024ConnectionMade_00241913(this).GetEnumerator();
	}

	public virtual void GCmatchmade()
	{
	}

	public virtual void updateOptionLights()
	{
		if ((bool)DB)
		{
			if (DB.musicEnabled && !musicLight.enabled)
			{
				musicLight.enabled = true;
				musicRenderer.enabled = false;
			}
			else if (!DB.musicEnabled && !musicRenderer.enabled)
			{
				musicLight.enabled = false;
				musicRenderer.enabled = true;
			}
			if (DB.soundEnabled && !SFXLight.enabled)
			{
				SFXLight.enabled = true;
				SFXRenderer.enabled = false;
			}
			else if (!DB.soundEnabled && !SFXRenderer.enabled)
			{
				SFXLight.enabled = false;
				SFXRenderer.enabled = true;
			}
			if (iCloudLight.enabled)
			{
				iCloudLight.enabled = false;
			}
			if (iCloudRenderer.enabled)
			{
				iCloudRenderer.enabled = false;
			}
			if (GCoptionLight.enabled)
			{
				GCoptionLight.enabled = false;
			}
			if (GCoptionRenderer.enabled)
			{
				GCoptionRenderer.enabled = false;
			}
		}
	}

	public virtual IEnumerator turnOffLights()
	{
		return new _0024turnOffLights_00241916(this).GetEnumerator();
	}

	public virtual void Main()
	{
	}
}
