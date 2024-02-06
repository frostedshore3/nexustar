using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using dark.efijiPOIWikjek;
using ExitGames.Client.Photon;
using GorillaExtensions;
using GorillaLocomotion;
using GorillaLocomotion.Gameplay;
using GorillaNetworking;
using GorillaTag;
using GTAG_NotificationLib;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using PlayFab;
using PlayFab.ClientModels;
using ShibaGTTemplate.UI;
using ShibaGTTemplate.Utilities;
using UnityEngine;
using UnityEngine.UI;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000019 RID: 25
	internal class Mods : MonoBehaviour
	{
		// Token: 0x0600033B RID: 827 RVA: 0x0001B07C File Offset: 0x0001927C
		private static void GetMethodSigHelperLegacyEvidenceList(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_17 = A_30;
			int num = ((!A_17) ? 1 : 0) * 1 + 406;
			A_0 = num;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0001B0D8 File Offset: 0x000192D8
		private static void IgnoreKanaTypeSetPublicKeyToken(ref int A_0, ref int A_1, ref int A_2)
		{
			Application.Quit();
			A_1 = 0;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001B0F8 File Offset: 0x000192F8
		private static void ResourceSetIEnumMoniker(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			int num = ((!A_3) ? 1 : 0) * 7 + 479;
			A_0 = num;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001B15C File Offset: 0x0001935C
		private static void AsReadOnlyByRef(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GorillaRopeSwing[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			PhotonView photonView = A_4[A_5].photonView;
			A_6 = photonView;
			string text = "SetVelocity";
			A_7 = text;
			RpcTarget rpcTarget = 0;
			A_8 = rpcTarget;
			object[] array = new object[4];
			A_9 = array;
			A_9[0] = 1;
			A_9[1] = new Vector3((float)Random.Range(0, 300), 0f, (float)Random.Range(0, 300));
			A_9[2] = true;
			A_6.RPC(A_7, A_8, A_9);
			int num = A_5 + 1;
			A_5 = num;
			bool flag = A_5 < A_4.Length;
			A_10 = flag;
			int num2 = (A_10 ? 1 : 0) * -2 + 329;
			A_0 = num2;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001B2F4 File Offset: 0x000194F4
		public static void CoalSpam()
		{
			int num = 613;
			int num2 = 613;
			num2 = 613;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 613;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0001B338 File Offset: 0x00019538
		private static void TokenAccessLevelsgetNextActivator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref string A_4)
		{
			bool flag = !Mods.OEIFJWEF;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 864;
			A_0 = num;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0001B39C File Offset: 0x0001959C
		private static void SingleArraySerializedStore(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			Text component = A_12.Find("Player Name").GetComponent<Text>();
			A_15 = component;
			Transform transform = A_12.Find("ReportButton");
			A_16 = transform;
			bool flag = !A_16.gameObject.activeSelf;
			A_17 = flag;
			bool flag2 = A_17;
			A_18 = flag2;
			int num = ((!A_18) ? 1 : 0) * 15 + 709;
			A_0 = num;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0001B474 File Offset: 0x00019674
		private static string DesktopDirectoryPrefixref(ref int A_0, ref int A_1, ref int A_2, ref string A_3, ref int A_4, ref bool A_5, ref bool A_6, ref string A_7)
		{
			string result = A_7;
			A_1 = 0;
			return result;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0001B494 File Offset: 0x00019694
		private static void BuiltInPermissionFlagReturnXmlElementName(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref bool A_6, ref float A_7, ref bool A_8, ref bool A_9)
		{
			float num = Vector3.Distance(RigShit.GetOwnVRRig().transform.position, GorillaGameManager.instance.FindPlayerVRRig(A_5).transform.position);
			A_7 = num;
			bool flag = A_7 < GorillaGameManager.instance.tagDistanceThreshold;
			A_8 = flag;
			int num2 = ((!A_8) ? 1 : 0) * 3 + 821;
			A_0 = num2;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0001B544 File Offset: 0x00019744
		private static void GetDigitValueISecurityEncodable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref MeshCollider[] A_5, ref int A_6, ref MeshCollider A_7, ref MeshCollider[] A_8, ref int A_9, ref MeshCollider A_10)
		{
			MeshCollider[] array = Resources.FindObjectsOfTypeAll<MeshCollider>();
			A_8 = array;
			int num = 0;
			A_9 = num;
			A_0 = 741;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001B58C File Offset: 0x0001978C
		private static void LoaderSelectNewObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			Mods.pointer.transform.position = A_5.point;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_8 = flag;
			bool flag2 = A_8;
			A_9 = flag2;
			int num = ((!A_9) ? 1 : 0) * 4 + 801;
			A_0 = num;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001B628 File Offset: 0x00019828
		public static void TpToStump()
		{
			int num = 733;
			int num2 = 733;
			num2 = 733;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				MeshCollider[] array;
				int num4;
				MeshCollider meshCollider;
				MeshCollider[] array2;
				int num5;
				MeshCollider meshCollider2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,UnityEngine.MeshCollider[]&,System.Int32&,UnityEngine.MeshCollider&,UnityEngine.MeshCollider[]&,System.Int32&,UnityEngine.MeshCollider&), ref num, ref num2, ref num3, ref flag, ref flag2, ref array, ref num4, ref meshCollider, ref array2, ref num5, ref meshCollider2, Mods.ControlThreadBadData[num]);
			}
			num2 = 733;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0001B67C File Offset: 0x0001987C
		private static void EnableEventCdfIdentity(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			float num = Vector3.Distance(A_17.rightHandTransform.position, A_13.position);
			A_19 = num;
			float num2 = Vector3.Distance(A_17.leftHandTransform.position, A_13.position);
			A_20 = num2;
			int num3 = ((((double)A_19 < 0.35) * true) ? 1 : 0) + 758;
			A_0 = num3;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0001B728 File Offset: 0x00019928
		private static void getFileNameAsymmetricKeyExchangeFormatter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref MeshCollider[] A_4, ref int A_5, ref MeshCollider A_6, ref MeshCollider[] A_7, ref int A_8, ref MeshCollider A_9)
		{
			A_1 = 0;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0001B740 File Offset: 0x00019940
		private static void getPayloadMethodCodeType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 9;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 150;
			A_0 = num;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0001B7A8 File Offset: 0x000199A8
		private static void WeekEtwSelfDescribingEventFormat(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			int num = ((!Physics.Raycast(Player.Instance.rightControllerTransform.position - Player.Instance.rightControllerTransform.up, -Player.Instance.rightControllerTransform.up, ref A_4)) ? 1 : 0) * 1 + 480;
			A_0 = num;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0001B828 File Offset: 0x00019A28
		private static void IsWriterLockHeldBindableVectorToCollectionAdapter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool flag = ControllerInputPoller.instance.leftControllerIndexFloat > 0f;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 315;
			A_0 = num;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0001B894 File Offset: 0x00019A94
		private static void WorkItemgetCharUnknown(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 84;
			A_0 = num;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0001B8FC File Offset: 0x00019AFC
		private static void SharedStaticsPrefixref(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_9 = gripDownR;
			int num = ((!A_9) ? 1 : 0) * 1 + 560;
			A_0 = num;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0001B958 File Offset: 0x00019B58
		private static void InitialQuotePunctuationIsAllocated(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			GorillaFriendCollider[] array = Object.FindObjectsOfType<GorillaFriendCollider>();
			A_8 = array;
			int num = 0;
			A_9 = num;
			A_0 = 436;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0001B9A0 File Offset: 0x00019BA0
		private static void getIsFlowSuppressedNumDatesep(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5)
		{
			int num = ((A_4 < A_3.Length) ? 1 : 0) * -2 + 930;
			A_0 = num;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0001B9DC File Offset: 0x00019BDC
		public static void Helicopter()
		{
			int num = 34;
			int num2 = 34;
			num2 = 34;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, Mods.ControlThreadBadData[num]);
			}
			num2 = 34;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0001BA18 File Offset: 0x00019C18
		private static void getWrappedExceptionMixed(ref int A_0, ref int A_1, ref int A_2, ref Hashtable A_3)
		{
			Hashtable hashtable = new Hashtable();
			A_3 = hashtable;
			A_3.Add("gameMode", PhotonNetwork.CurrentRoom.CustomProperties["gameMode"].ToString().Replace(Mods.CurrentMap, "citybasementmountaincavecloudscanyonforestbeach"));
			PhotonNetwork.CurrentRoom.SetCustomProperties(A_3, null, null);
			A_1 = 0;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0001BA98 File Offset: 0x00019C98
		private static void CommonMusicHideScheduler(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = (A_8.MoveNext() ? 1 : 0) * -4 + 381;
			A_0 = num;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0001BAE0 File Offset: 0x00019CE0
		private static void GetFieldMarshalHeader(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_16 = gripDownR;
			int num = ((!A_16) ? 1 : 0) * 1 + 541;
			A_0 = num;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0001BB3C File Offset: 0x00019D3C
		private static void getSponsorshipTimeoutMuiResourceTypeIdIntStringIds(ref int A_0, ref int A_1, ref int A_2)
		{
			GorillaNot.instance.rpcCallLimit = int.MaxValue;
			PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
			PhotonNetwork.OpCleanActorRpcBuffer(PhotonNetwork.LocalPlayer.ActorNumber);
			PhotonNetwork.OpCleanRpcBuffer(GorillaTagger.Instance.myVRRig);
			PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
			A_1 = 0;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0001BBA8 File Offset: 0x00019DA8
		private static void TaskNodeAgileAsyncWorkerItem(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			GorillaTagger.Instance.offlineVRRig.transform.position = Vector3.zero;
			Object.Destroy(Mods.pointer);
			A_1 = 0;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0001BBFC File Offset: 0x00019DFC
		public static void MoltenRockSpamSS()
		{
			int num = 658;
			int num2 = 658;
			num2 = 658;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 658;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0001BC40 File Offset: 0x00019E40
		public static void RigGun()
		{
			int num = 246;
			int num2 = 246;
			num2 = 246;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				RaycastHit raycastHit;
				bool flag2;
				bool flag3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.RaycastHit&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref raycastHit, ref flag2, ref flag3, Mods.ControlThreadBadData[num]);
			}
			num2 = 246;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0001BC8C File Offset: 0x00019E8C
		private static void ManualResetgetProviderName(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref bool A_6, ref float A_7, ref bool A_8, ref bool A_9)
		{
			PhotonView.Get(GorillaGameManager.instance.GetComponent<GorillaGameManager>()).RPC("ReportTagRPC", 2, new object[]
			{
				GorillaGameManager.instance.FindVRRigForPlayer(A_5).Owner
			});
			Mods.flushmanually();
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -8 + 827;
			A_0 = num2;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0001BD3C File Offset: 0x00019F3C
		private static void SendManifestPrepareApplicationState(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool oeifjwef = Mods.OEIFJWEF;
			A_3 = oeifjwef;
			int num = ((!A_3) ? 1 : 0) * 1 + 867;
			A_0 = num;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0001BD98 File Offset: 0x00019F98
		public unsafe static void antimoderator()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 192;
			int num4 = 192;
			num4 = 192;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 4)
					{
						num4 = 192;
						if ((int)array[6] != 1)
						{
							num5 = (int)array[5];
							num6 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num5 + 56 + num2);
							for (num7 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + (int)array[1] + 56 + num2) + 56 + num2); num7 != num6; num7 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num7 + 56 + num2))
							{
								num8 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num7 + 8 + num2);
								if (num8 != -1)
								{
									num9 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num8 + 40 + num2);
									array[1] = num8;
									array[4] = 2;
									num3 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num8 + 40 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[0];
							num9 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num5 + 40 + num2);
							ex2 = ex;
							array = (object[])array[2];
							array2 = new object[8];
							array2[6] = 0;
							array2[2] = array;
							array2[0] = ex;
							array2[1] = num5;
							array2[4] = 1;
							array = array2;
							num3 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num5 + 40 + num2);
							continue;
						}
						num10 = (int)array[7];
						array = (object[])array[2];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 3)
						{
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref enumerator, ref vrrig, ref flag, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 192;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 152 + num15 * 48 + 32 + num2);
						num17 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 152 + num15 * 48 + 8 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 152 + num7 * 48 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 152 + num14 * 48 + 32 + num2);
						num6 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 152 + num14 * 48 + 8 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 152 + num7 * 48 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 296 + num15 * 64 + 48 + num2);
						num17 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 296 + num15 * 64 + 16 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 296 + num7 * 64 + 8 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9BE:
						if (array == null || (int)array[6] == 1)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num6 + 56 + num2);
								}
								else
								{
									num10 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num18 + 8 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num18 + 56 + num2);
									goto IL_9BE;
								}
							}
							goto IL_B5A;
						}
						int num19 = (int)array[1];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num18 + 40 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 296 + num15 * 64 + 48 + num2);
								num10 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 296 + num15 * 64 + 16 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 296 + num5 * 64 + 8 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num7 + 56 + num2);
								}
								else
								{
									num5 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num18 + 8 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num18 + 56 + num2);
									goto IL_9BE;
								}
							}
							break;
						}
						if ((int)array[1] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[2];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num5 + 40 + num2);
					array2 = new object[8];
					array2[6] = 1;
					array2[2] = array;
					array2[7] = num11;
					array2[1] = num5;
					array2[4] = 2;
					array = array2;
					num3 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num5 + 40 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B5A:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num10 + 40 + num2);
					array2 = new object[8];
					array2[6] = 1;
					array2[2] = array;
					array2[7] = num11;
					array2[1] = num10;
					array2[4] = 2;
					array = array2;
					num3 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num10 + 40 + num2);
				}
				num4 = 192;
				return;
				IL_1C3:
				if (num6 != -1)
				{
					goto IL_1CE;
				}
				goto IL_3F0;
				IL_1CE:
				num7 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num6 + 16 + num2);
				if (3 == num7)
				{
					goto IL_1ED;
				}
				if (1 == num7)
				{
					goto IL_37D;
				}
				goto IL_3F0;
				IL_1ED:
				num9 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num6 + 8 + num2);
				if (num9 == -1)
				{
					goto IL_23A;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_220;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_220:
				if (type.IsInstanceOfType(array2[0]))
				{
					goto IL_23A;
				}
				num6 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num6 + 24 + num2);
				goto IL_1C3;
				IL_23A:
				num5 = num6;
				num8 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num5 + 56 + num2) + 56 + num2);
				num13 = (int)array2[3];
				IL_25E:
				if (num13 != num8)
				{
					goto IL_2DD;
				}
				int num22 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num5 + 40 + num2);
				ex2 = array2[0];
				array = (object[])array[2];
				object[] array5 = new object[8];
				array5[6] = 0;
				array5[2] = array;
				array5[0] = array2[0];
				array5[3] = (int)array2[3];
				array5[1] = num5;
				array5[4] = 1;
				array = array5;
				num3 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num5 + 40 + num2);
				goto IL_23;
				IL_2DD:
				num18 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num13 + 8 + num2);
				if (num18 == -1)
				{
					goto IL_36B;
				}
				num22 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num18 + 40 + num2);
				array = (object[])array[2];
				array5 = new object[8];
				array5[6] = 0;
				array5[2] = array;
				array5[0] = array2[0];
				array5[3] = (int)array2[3];
				array5[1] = num18;
				array5[5] = num5;
				array5[4] = 2;
				array = array5;
				num3 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num18 + 40 + num2);
				goto IL_23;
				IL_36B:
				num13 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num13 + 56 + num2);
				goto IL_25E;
				IL_37D:
				num22 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num6 + num2);
				ex2 = array2[0];
				array = (object[])array[2];
				array5 = new object[8];
				array5[6] = 0;
				array5[2] = array;
				array5[0] = array2[0];
				array5[3] = (int)array2[3];
				array5[1] = num6;
				array5[4] = 0;
				array = array5;
				num3 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num6 + num2);
				goto IL_23;
				IL_3F0:
				array = (object[])array[2];
				Exception ex3 = array2[0];
				int num23 = (int)array2[3];
				IL_40F:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_41D:
				num14 = (num21 + num10) / 2;
				num15 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 152 + num14 * 48 + 32 + num2);
				num16 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 152 + num14 * 48 + 8 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_462;
				}
				if (num15 > num22)
				{
					goto IL_46A;
				}
				num8 = num14;
				num5 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 152 + num8 * 48 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_48F;
				IL_462:
				num21 = num14 + 1;
				goto IL_41D;
				IL_46A:
				num10 = num14 - 1;
				goto IL_41D;
				IL_48F:
				if (array != null)
				{
					goto IL_49A;
				}
				goto IL_627;
				IL_49A:
				if ((int)array[6] != 1)
				{
					goto IL_559;
				}
				int num24 = (int)array[1];
				if (num9 != -1)
				{
					goto IL_4BE;
				}
				int num25 = -1;
				goto IL_540;
				IL_4BE:
				num17 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num9 + 40 + num2);
				num16 = 0;
				num15 = 2;
				IL_4D1:
				num14 = (num16 + num15) / 2;
				num10 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 296 + num14 * 64 + 48 + num2);
				num21 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 296 + num14 * 64 + 16 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_517;
				}
				if (num10 > num17)
				{
					goto IL_51F;
				}
				num5 = num14;
				num8 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 296 + num5 * 64 + 8 + num2);
				num25 = num8;
				goto IL_540;
				IL_517:
				num16 = num14 + 1;
				goto IL_4D1;
				IL_51F:
				num15 = num14 - 1;
				goto IL_4D1;
				IL_540:
				if (num24 != num25)
				{
					goto IL_548;
				}
				goto IL_627;
				IL_548:
				array = (object[])array[2];
				goto IL_48F;
				IL_559:
				num18 = (int)array[4];
				if (num18 == 1 || num18 == 2)
				{
					goto IL_57A;
				}
				if (num18 != 0)
				{
					goto IL_579;
				}
				array2 = array;
				num6 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + (int)array2[1] + 24 + num2);
				goto IL_1C3;
				IL_579:
				IL_57A:
				int num26 = (int)array[1];
				if (num9 != -1)
				{
					goto IL_58F;
				}
				int num27 = -1;
				goto IL_611;
				IL_58F:
				num22 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num9 + 40 + num2);
				num21 = 0;
				num10 = 2;
				IL_5A2:
				num14 = (num21 + num10) / 2;
				num15 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 296 + num14 * 64 + 48 + num2);
				num16 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 296 + num14 * 64 + 16 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5E8;
				}
				if (num15 > num22)
				{
					goto IL_5F0;
				}
				num8 = num14;
				num5 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + 296 + num8 * 64 + 8 + num2);
				num27 = num5;
				goto IL_611;
				IL_5E8:
				num21 = num14 + 1;
				goto IL_5A2;
				IL_5F0:
				num10 = num14 - 1;
				goto IL_5A2;
				IL_611:
				if (num26 != num27)
				{
					goto IL_616;
				}
				goto IL_627;
				IL_616:
				array = (object[])array[2];
				goto IL_48F;
				IL_627:
				if (-1 != num9)
				{
					goto IL_633;
				}
				int num28 = 1;
				throw ex3;
				IL_633:
				num7 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num9 + 16 + num2);
				num10 = num7;
				IL_644:
				if (num10 != -1)
				{
					goto IL_65B;
				}
				num9 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num9 + 56 + num2);
				goto IL_48F;
				IL_65B:
				num15 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num10 + 16 + num2);
				if (3 == num15)
				{
					goto IL_686;
				}
				if (1 == num15)
				{
					goto IL_7F2;
				}
				num9 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num9 + 56 + num2);
				goto IL_48F;
				IL_686:
				num14 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num10 + 8 + num2);
				if (num14 == -1)
				{
					goto IL_6D4;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6B9;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6B9:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6D4;
				}
				num10 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num10 + 24 + num2);
				goto IL_644;
				IL_6D4:
				num5 = num10;
				num8 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num5 + 56 + num2) + 56 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_6FD:
				if (num17 != num8)
				{
					goto IL_766;
				}
				num21 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num5 + 40 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[6] = 0;
				array2[2] = array;
				array2[0] = ex3;
				array2[3] = num13;
				array2[1] = num5;
				array2[4] = 1;
				array = array2;
				num3 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num5 + 40 + num2);
				goto IL_23;
				IL_766:
				num16 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num17 + 8 + num2);
				if (num16 == -1)
				{
					goto IL_7E0;
				}
				num21 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num16 + 40 + num2);
				array2 = new object[8];
				array2[6] = 0;
				array2[2] = array;
				array2[0] = ex3;
				array2[3] = num13;
				array2[1] = num16;
				array2[5] = num5;
				array2[4] = 2;
				array = array2;
				num3 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num16 + 40 + num2);
				goto IL_23;
				IL_7E0:
				num17 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num17 + 56 + num2);
				goto IL_6FD;
				IL_7F2:
				num21 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num10 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[6] = 0;
				array2[2] = array;
				array2[0] = ex3;
				array2[3] = num13;
				array2[1] = num10;
				array2[4] = 0;
				array = array2;
				num3 = *(ref OnlyOnRanToCompletioncontinuation.setXmlTypeNameParamNames + num10 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_40F;
				}
				throw ex4;
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0001C9B8 File Offset: 0x0001ABB8
		private static void getCompletiongetWindowWidth(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			int num = A_4 + 1;
			A_4 = num;
			Vector3 position = A_6.rightHandTransform.position;
			A_8 = position;
			Vector3 position2 = GorillaTagger.Instance.offlineVRRig.head.rigTarget.position;
			A_9 = position2;
			bool flag = (double)Vector3.Distance(A_8, A_9) < 0.25;
			A_10 = flag;
			int num2 = ((!A_10) ? 1 : 0) * 1 + 786;
			A_0 = num2;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		private static void assemblyNameLdstr(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			bool flag = !A_14;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 504;
			A_0 = num;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0001CB08 File Offset: 0x0001AD08
		private static void RegisteredChannelListDefaultThreadCurrentCulture(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool flag = Mods.back;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 10;
			A_0 = num;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0001CB64 File Offset: 0x0001AD64
		private static void ArraySingleObjectFullControl(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0001CB7C File Offset: 0x0001AD7C
		private static List<VRRig> SoapActionSubOvf(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			VRRig vrrig = A_4.Current;
			A_5 = vrrig;
			int num = (A_5.isOfflineVRRig ? 1 : 0) * 3 + 880;
			A_0 = num;
			List<VRRig> result;
			return result;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0001CBE8 File Offset: 0x0001ADE8
		private static void ZoomIComparable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0001CC00 File Offset: 0x0001AE00
		private static void setResourcesIStore(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			GameObject gameObject = GameObject.Find("Environment Objects/PersistentObjects_Prefab/GorillaUI");
			A_4 = gameObject;
			Transform transform = A_4.transform;
			A_5 = transform;
			int num = 0;
			A_6 = num;
			A_0 = 774;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0001CC68 File Offset: 0x0001AE68
		public unsafe static void SaveOriginal()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 353;
			int num4 = 353;
			num4 = 353;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 3)
					{
						num4 = 353;
						if ((int)array[0] != 0)
						{
							num5 = (int)array[1];
							num6 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num5 + num2);
							for (num7 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + (int)array[5] + num2) + num2); num7 != num6; num7 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num7 + num2))
							{
								num8 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num7 + 32 + num2);
								if (num8 != -1)
								{
									num9 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num8 + 48 + num2);
									array[5] = num8;
									array[3] = 0;
									num3 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num8 + 48 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[6];
							num9 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num5 + 48 + num2);
							ex2 = ex;
							array = (object[])array[7];
							array2 = new object[]
							{
								1,
								null,
								null,
								null,
								null,
								null,
								null,
								array
							};
							array2[6] = ex;
							array2[5] = num5;
							array2[3] = 1;
							array = array2;
							num3 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num5 + 48 + num2);
							continue;
						}
						num10 = (int)array[4];
						array = (object[])array[7];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 4)
						{
							List<string> list;
							List<ButtonInfo>.Enumerator enumerator;
							ButtonInfo buttonInfo;
							bool? flag;
							bool flag2;
							bool flag3;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1<System.String>&,System.Collections.Generic.List`1/Enumerator<ShibaGTTemplate.UI.ButtonInfo>&,ShibaGTTemplate.UI.ButtonInfo&,System.Nullable`1<System.Boolean>&,System.Boolean&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref list, ref enumerator, ref buttonInfo, ref flag, ref flag2, ref flag3, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 353;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 152 + num15 * 72 + num2);
						num17 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 152 + num15 * 72 + 64 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 152 + num7 * 72 + 48 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 152 + num14 * 72 + num2);
						num6 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 152 + num14 * 72 + 64 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 152 + num7 * 72 + 48 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 368 + num15 * 64 + num2);
						num17 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 368 + num15 * 64 + 56 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 368 + num7 * 64 + 40 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9AE:
						if (array == null || (int)array[0] == 0)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num6 + num2);
								}
								else
								{
									num10 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num18 + 32 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num18 + num2);
									goto IL_9AE;
								}
							}
							goto IL_B40;
						}
						int num19 = (int)array[5];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num18 + 16 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 368 + num15 * 64 + num2);
								num10 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 368 + num15 * 64 + 56 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 368 + num5 * 64 + 40 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num7 + num2);
								}
								else
								{
									num5 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num18 + 32 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num18 + num2);
									goto IL_9AE;
								}
							}
							break;
						}
						if ((int)array[5] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[7];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num5 + 48 + num2);
					array2 = new object[]
					{
						0,
						null,
						null,
						null,
						null,
						null,
						null,
						array
					};
					array2[4] = num11;
					array2[5] = num5;
					array2[3] = 0;
					array = array2;
					num3 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num5 + 48 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B40:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num10 + 48 + num2);
					array2 = new object[]
					{
						0,
						null,
						null,
						null,
						null,
						null,
						null,
						array
					};
					array2[4] = num11;
					array2[5] = num10;
					array2[3] = 0;
					array = array2;
					num3 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num10 + 48 + num2);
				}
				num4 = 353;
				return;
				IL_1BE:
				if (num6 != -1)
				{
					goto IL_1C9;
				}
				goto IL_3EA;
				IL_1C9:
				num7 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num6 + 96 + num2);
				if (0 == num7)
				{
					goto IL_1E8;
				}
				if (4 == num7)
				{
					goto IL_371;
				}
				goto IL_3EA;
				IL_1E8:
				num9 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num6 + 72 + num2);
				if (num9 == -1)
				{
					goto IL_236;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_21C;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_21C:
				if (type.IsInstanceOfType(array2[6]))
				{
					goto IL_236;
				}
				num6 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num6 + 40 + num2);
				goto IL_1BE;
				IL_236:
				num5 = num6;
				num8 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num5 + num2) + num2);
				num13 = (int)array2[2];
				IL_254:
				if (num13 != num8)
				{
					goto IL_2D3;
				}
				int num22 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num5 + 48 + num2);
				ex2 = array2[6];
				array = (object[])array[7];
				object[] array5 = new object[]
				{
					1,
					null,
					null,
					null,
					null,
					null,
					null,
					array
				};
				array5[6] = array2[6];
				array5[2] = (int)array2[2];
				array5[5] = num5;
				array5[3] = 1;
				array = array5;
				num3 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num5 + 48 + num2);
				goto IL_23;
				IL_2D3:
				num18 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num13 + 32 + num2);
				if (num18 == -1)
				{
					goto IL_362;
				}
				num22 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num18 + 48 + num2);
				array = (object[])array[7];
				array5 = new object[]
				{
					1,
					null,
					null,
					null,
					null,
					null,
					null,
					array
				};
				array5[6] = array2[6];
				array5[2] = (int)array2[2];
				array5[5] = num18;
				array5[1] = num5;
				array5[3] = 0;
				array = array5;
				num3 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num18 + 48 + num2);
				goto IL_23;
				IL_362:
				num13 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num13 + num2);
				goto IL_254;
				IL_371:
				num22 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num6 + 64 + num2);
				ex2 = array2[6];
				array = (object[])array[7];
				array5 = new object[]
				{
					1,
					null,
					null,
					null,
					null,
					null,
					null,
					array
				};
				array5[6] = array2[6];
				array5[2] = (int)array2[2];
				array5[5] = num6;
				array5[3] = 2;
				array = array5;
				num3 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num6 + 64 + num2);
				goto IL_23;
				IL_3EA:
				array = (object[])array[7];
				Exception ex3 = array2[6];
				int num23 = (int)array2[2];
				IL_409:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_417:
				num14 = (num21 + num10) / 2;
				num15 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 152 + num14 * 72 + num2);
				num16 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 152 + num14 * 72 + 64 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_45A;
				}
				if (num15 > num22)
				{
					goto IL_462;
				}
				num8 = num14;
				num5 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 152 + num8 * 72 + 48 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_48A;
				IL_45A:
				num21 = num14 + 1;
				goto IL_417;
				IL_462:
				num10 = num14 - 1;
				goto IL_417;
				IL_48A:
				if (array != null)
				{
					goto IL_495;
				}
				goto IL_61E;
				IL_495:
				if ((int)array[0] != 0)
				{
					goto IL_552;
				}
				int num24 = (int)array[5];
				if (num9 != -1)
				{
					goto IL_4B9;
				}
				int num25 = -1;
				goto IL_539;
				IL_4B9:
				num17 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num9 + 16 + num2);
				num16 = 0;
				num15 = 2;
				IL_4CC:
				num14 = (num16 + num15) / 2;
				num10 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 368 + num14 * 64 + num2);
				num21 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 368 + num14 * 64 + 56 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_50F;
				}
				if (num10 > num17)
				{
					goto IL_517;
				}
				num5 = num14;
				num8 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 368 + num5 * 64 + 40 + num2);
				num25 = num8;
				goto IL_539;
				IL_50F:
				num16 = num14 + 1;
				goto IL_4CC;
				IL_517:
				num15 = num14 - 1;
				goto IL_4CC;
				IL_539:
				if (num24 != num25)
				{
					goto IL_541;
				}
				goto IL_61E;
				IL_541:
				array = (object[])array[7];
				goto IL_48A;
				IL_552:
				num18 = (int)array[3];
				if (num18 == 1 || num18 == 0)
				{
					goto IL_573;
				}
				if (num18 != 2)
				{
					goto IL_572;
				}
				array2 = array;
				num6 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + (int)array2[5] + 40 + num2);
				goto IL_1BE;
				IL_572:
				IL_573:
				int num26 = (int)array[5];
				if (num9 != -1)
				{
					goto IL_588;
				}
				int num27 = -1;
				goto IL_608;
				IL_588:
				num22 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num9 + 16 + num2);
				num21 = 0;
				num10 = 2;
				IL_59B:
				num14 = (num21 + num10) / 2;
				num15 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 368 + num14 * 64 + num2);
				num16 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 368 + num14 * 64 + 56 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5DE;
				}
				if (num15 > num22)
				{
					goto IL_5E6;
				}
				num8 = num14;
				num5 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + 368 + num8 * 64 + 40 + num2);
				num27 = num5;
				goto IL_608;
				IL_5DE:
				num21 = num14 + 1;
				goto IL_59B;
				IL_5E6:
				num10 = num14 - 1;
				goto IL_59B;
				IL_608:
				if (num26 != num27)
				{
					goto IL_60D;
				}
				goto IL_61E;
				IL_60D:
				array = (object[])array[7];
				goto IL_48A;
				IL_61E:
				if (-1 != num9)
				{
					goto IL_62A;
				}
				int num28 = 1;
				throw ex3;
				IL_62A:
				num7 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num9 + 40 + num2);
				num10 = num7;
				IL_63B:
				if (num10 != -1)
				{
					goto IL_64F;
				}
				num9 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num9 + num2);
				goto IL_48A;
				IL_64F:
				num15 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num10 + 96 + num2);
				if (0 == num15)
				{
					goto IL_677;
				}
				if (4 == num15)
				{
					goto IL_7DC;
				}
				num9 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num9 + num2);
				goto IL_48A;
				IL_677:
				num14 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num10 + 72 + num2);
				if (num14 == -1)
				{
					goto IL_6C6;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6AB;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6AB:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6C6;
				}
				num10 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num10 + 40 + num2);
				goto IL_63B;
				IL_6C6:
				num5 = num10;
				num8 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num5 + num2) + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_6E9:
				if (num17 != num8)
				{
					goto IL_752;
				}
				num21 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num5 + 48 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					1,
					null,
					null,
					null,
					null,
					null,
					null,
					array
				};
				array2[6] = ex3;
				array2[2] = num13;
				array2[5] = num5;
				array2[3] = 1;
				array = array2;
				num3 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num5 + 48 + num2);
				goto IL_23;
				IL_752:
				num16 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num17 + 32 + num2);
				if (num16 == -1)
				{
					goto IL_7CD;
				}
				num21 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num16 + 48 + num2);
				array2 = new object[]
				{
					1,
					null,
					null,
					null,
					null,
					null,
					null,
					array
				};
				array2[6] = ex3;
				array2[2] = num13;
				array2[5] = num16;
				array2[1] = num5;
				array2[3] = 0;
				array = array2;
				num3 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num16 + 48 + num2);
				goto IL_23;
				IL_7CD:
				num17 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num17 + num2);
				goto IL_6E9;
				IL_7DC:
				num21 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num10 + 64 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					1,
					null,
					null,
					null,
					null,
					null,
					null,
					array
				};
				array2[6] = ex3;
				array2[2] = num13;
				array2[5] = num10;
				array2[3] = 2;
				array = array2;
				num3 = *(ref IsFaultedBgeUnS.DefineInitializedDataGetStringConstant + num10 + 64 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_409;
				}
				throw ex4;
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0001D86C File Offset: 0x0001BA6C
		private static void TraceLoggingTypeInfoUseSpacesInMonthNames(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = Mods.balll2 < Time.time;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 23 + 81;
			A_0 = num;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0001D8D0 File Offset: 0x0001BAD0
		private static void DisableComObjectEagerCleanupThreadAbortException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 6;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 119;
			A_0 = num;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0001D938 File Offset: 0x0001BB38
		private static void UseNewMaxArraySizegetHashElements(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			int num = A_5 + 1;
			A_5 = num;
			int num2 = ((A_5 < A_4.Length) ? 1 : 0) * -17 + 910;
			A_0 = num2;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0001D998 File Offset: 0x0001BB98
		public unsafe static void KillAll()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 829;
			int num4 = 829;
			num4 = 829;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 4)
					{
						num4 = 829;
						if ((int)array[1] != 0)
						{
							num5 = (int)array[0];
							num6 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num5 + 16 + num2);
							for (num7 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + (int)array[3] + 16 + num2) + 8 + num2); num7 != num6; num7 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num7 + 8 + num2))
							{
								num8 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num7 + 24 + num2);
								if (num8 != -1)
								{
									num9 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num8 + 48 + num2);
									array[3] = num8;
									array[4] = 0;
									num3 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num8 + 48 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[6];
							num9 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num5 + 48 + num2);
							ex2 = ex;
							array = (object[])array[5];
							array2 = new object[8];
							array2[1] = 1;
							array2[5] = array;
							array2[6] = ex;
							array2[3] = num5;
							array2[4] = 1;
							array = array2;
							num3 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num5 + 48 + num2);
							continue;
						}
						num10 = (int)array[2];
						array = (object[])array[5];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 3)
						{
							bool flag;
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag2;
							SlingshotProjectile slingshotProjectile;
							Color color;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Boolean&,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&,SlingshotProjectile&,UnityEngine.Color&), ref num3, ref num4, ref num12, ex2, ref flag, ref enumerator, ref vrrig, ref flag2, ref slingshotProjectile, ref color, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 829;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 152 + num15 * 56 + 8 + num2);
						num17 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 152 + num15 * 56 + 40 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 152 + num7 * 56 + 24 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 152 + num14 * 56 + 8 + num2);
						num6 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 152 + num14 * 56 + 40 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 152 + num7 * 56 + 24 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 320 + num15 * 56 + 8 + num2);
						num17 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 320 + num15 * 56 + 40 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 320 + num7 * 56 + 24 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9D6:
						if (array == null || (int)array[1] == 0)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num6 + 8 + num2);
								}
								else
								{
									num10 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num18 + 24 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num18 + 8 + num2);
									goto IL_9D6;
								}
							}
							goto IL_B70;
						}
						int num19 = (int)array[3];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num18 + 16 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 320 + num15 * 56 + 8 + num2);
								num10 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 320 + num15 * 56 + 40 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 320 + num5 * 56 + 24 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num7 + 8 + num2);
								}
								else
								{
									num5 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num18 + 24 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num18 + 8 + num2);
									goto IL_9D6;
								}
							}
							break;
						}
						if ((int)array[3] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[5];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num5 + 48 + num2);
					array2 = new object[8];
					array2[1] = 0;
					array2[5] = array;
					array2[2] = num11;
					array2[3] = num5;
					array2[4] = 0;
					array = array2;
					num3 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num5 + 48 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B70:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num10 + 48 + num2);
					array2 = new object[8];
					array2[1] = 0;
					array2[5] = array;
					array2[2] = num11;
					array2[3] = num10;
					array2[4] = 0;
					array = array2;
					num3 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num10 + 48 + num2);
				}
				num4 = 829;
				return;
				IL_1C8:
				if (num6 != -1)
				{
					goto IL_1D3;
				}
				goto IL_3FB;
				IL_1D3:
				num7 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num6 + 64 + num2);
				if (0 == num7)
				{
					goto IL_1F2;
				}
				if (3 == num7)
				{
					goto IL_382;
				}
				goto IL_3FB;
				IL_1F2:
				num9 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num6 + 40 + num2);
				if (num9 == -1)
				{
					goto IL_240;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_226;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_226:
				if (type.IsInstanceOfType(array2[6]))
				{
					goto IL_240;
				}
				num6 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num6 + 56 + num2);
				goto IL_1C8;
				IL_240:
				num5 = num6;
				num8 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num5 + 16 + num2) + 8 + num2);
				num13 = (int)array2[7];
				IL_263:
				if (num13 != num8)
				{
					goto IL_2E2;
				}
				int num22 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num5 + 48 + num2);
				ex2 = array2[6];
				array = (object[])array[5];
				object[] array5 = new object[]
				{
					null,
					1,
					null,
					null,
					null,
					array,
					array2[6],
					(int)array2[7]
				};
				array5[3] = num5;
				array5[4] = 1;
				array = array5;
				num3 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num5 + 48 + num2);
				goto IL_23;
				IL_2E2:
				num18 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num13 + 24 + num2);
				if (num18 == -1)
				{
					goto IL_371;
				}
				num22 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num18 + 48 + num2);
				array = (object[])array[5];
				array5 = new object[]
				{
					null,
					1,
					null,
					null,
					null,
					array,
					array2[6],
					(int)array2[7]
				};
				array5[3] = num18;
				array5[0] = num5;
				array5[4] = 0;
				array = array5;
				num3 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num18 + 48 + num2);
				goto IL_23;
				IL_371:
				num13 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num13 + 8 + num2);
				goto IL_263;
				IL_382:
				num22 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num6 + 72 + num2);
				ex2 = array2[6];
				array = (object[])array[5];
				array5 = new object[]
				{
					null,
					1,
					null,
					null,
					null,
					array,
					array2[6],
					(int)array2[7]
				};
				array5[3] = num6;
				array5[4] = 2;
				array = array5;
				num3 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num6 + 72 + num2);
				goto IL_23;
				IL_3FB:
				array = (object[])array[5];
				Exception ex3 = array2[6];
				int num23 = (int)array2[7];
				IL_41A:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_428:
				num14 = (num21 + num10) / 2;
				num15 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 152 + num14 * 56 + 8 + num2);
				num16 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 152 + num14 * 56 + 40 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_46D;
				}
				if (num15 > num22)
				{
					goto IL_475;
				}
				num8 = num14;
				num5 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 152 + num8 * 56 + 24 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_49D;
				IL_46D:
				num21 = num14 + 1;
				goto IL_428;
				IL_475:
				num10 = num14 - 1;
				goto IL_428;
				IL_49D:
				if (array != null)
				{
					goto IL_4A8;
				}
				goto IL_635;
				IL_4A8:
				if ((int)array[1] != 0)
				{
					goto IL_567;
				}
				int num24 = (int)array[3];
				if (num9 != -1)
				{
					goto IL_4CC;
				}
				int num25 = -1;
				goto IL_54E;
				IL_4CC:
				num17 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num9 + 16 + num2);
				num16 = 0;
				num15 = 2;
				IL_4DF:
				num14 = (num16 + num15) / 2;
				num10 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 320 + num14 * 56 + 8 + num2);
				num21 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 320 + num14 * 56 + 40 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_524;
				}
				if (num10 > num17)
				{
					goto IL_52C;
				}
				num5 = num14;
				num8 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 320 + num5 * 56 + 24 + num2);
				num25 = num8;
				goto IL_54E;
				IL_524:
				num16 = num14 + 1;
				goto IL_4DF;
				IL_52C:
				num15 = num14 - 1;
				goto IL_4DF;
				IL_54E:
				if (num24 != num25)
				{
					goto IL_556;
				}
				goto IL_635;
				IL_556:
				array = (object[])array[5];
				goto IL_49D;
				IL_567:
				num18 = (int)array[4];
				if (num18 == 1 || num18 == 0)
				{
					goto IL_588;
				}
				if (num18 != 2)
				{
					goto IL_587;
				}
				array2 = array;
				num6 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + (int)array2[3] + 56 + num2);
				goto IL_1C8;
				IL_587:
				IL_588:
				int num26 = (int)array[3];
				if (num9 != -1)
				{
					goto IL_59D;
				}
				int num27 = -1;
				goto IL_61F;
				IL_59D:
				num22 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num9 + 16 + num2);
				num21 = 0;
				num10 = 2;
				IL_5B0:
				num14 = (num21 + num10) / 2;
				num15 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 320 + num14 * 56 + 8 + num2);
				num16 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 320 + num14 * 56 + 40 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5F5;
				}
				if (num15 > num22)
				{
					goto IL_5FD;
				}
				num8 = num14;
				num5 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + 320 + num8 * 56 + 24 + num2);
				num27 = num5;
				goto IL_61F;
				IL_5F5:
				num21 = num14 + 1;
				goto IL_5B0;
				IL_5FD:
				num10 = num14 - 1;
				goto IL_5B0;
				IL_61F:
				if (num26 != num27)
				{
					goto IL_624;
				}
				goto IL_635;
				IL_624:
				array = (object[])array[5];
				goto IL_49D;
				IL_635:
				if (-1 != num9)
				{
					goto IL_641;
				}
				int num28 = 1;
				throw ex3;
				IL_641:
				num7 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num9 + 40 + num2);
				num10 = num7;
				IL_652:
				if (num10 != -1)
				{
					goto IL_668;
				}
				num9 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num9 + 8 + num2);
				goto IL_49D;
				IL_668:
				num15 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num10 + 64 + num2);
				if (0 == num15)
				{
					goto IL_692;
				}
				if (3 == num15)
				{
					goto IL_7FE;
				}
				num9 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num9 + 8 + num2);
				goto IL_49D;
				IL_692:
				num14 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num10 + 40 + num2);
				if (num14 == -1)
				{
					goto IL_6E1;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6C6;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6C6:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6E1;
				}
				num10 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num10 + 56 + num2);
				goto IL_652;
				IL_6E1:
				num5 = num10;
				num8 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num5 + 16 + num2) + 8 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_709:
				if (num17 != num8)
				{
					goto IL_772;
				}
				num21 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num5 + 48 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					1,
					null,
					null,
					null,
					array,
					ex3,
					num13
				};
				array2[3] = num5;
				array2[4] = 1;
				array = array2;
				num3 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num5 + 48 + num2);
				goto IL_23;
				IL_772:
				num16 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num17 + 24 + num2);
				if (num16 == -1)
				{
					goto IL_7ED;
				}
				num21 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num16 + 48 + num2);
				array2 = new object[]
				{
					null,
					1,
					null,
					null,
					null,
					array,
					ex3,
					num13
				};
				array2[3] = num16;
				array2[0] = num5;
				array2[4] = 0;
				array = array2;
				num3 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num16 + 48 + num2);
				goto IL_23;
				IL_7ED:
				num17 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num17 + 8 + num2);
				goto IL_709;
				IL_7FE:
				num21 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num10 + 72 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					1,
					null,
					null,
					null,
					array,
					ex3,
					num13
				};
				array2[3] = num10;
				array2[4] = 2;
				array = array2;
				num3 = *(ref GetSafeUninitializedObjectsetFaultActor.GREGORIANUSDescriptionMetadataEntry + num10 + 72 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_41A;
				}
				throw ex4;
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0001E5CC File Offset: 0x0001C7CC
		private static void CanCastTogetStringIds(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref bool A_7, ref PhotonView A_8)
		{
			int num = ((A_5 < A_4.Length) ? 1 : 0) * -4 + 476;
			A_0 = num;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0001E608 File Offset: 0x0001C808
		private static void LogicalCallContextPrivateBinPath(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -4 + 350;
			A_0 = num;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0001E650 File Offset: 0x0001C850
		private static void ConsoleKeyInfoTimeZoneInfoResult(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref MeshCollider[] A_5, ref int A_6, ref MeshCollider A_7, ref MeshCollider[] A_8, ref int A_9, ref MeshCollider A_10)
		{
			A_1 = 0;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0001E668 File Offset: 0x0001C868
		private static void GetCOMIUnknownConcurrentStackFastPushFailed(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			((IDisposable)A_6).Dispose();
			A_1 = 3;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0001E690 File Offset: 0x0001C890
		private static void getAceFlagsgetAsDecimal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			bool flag = A_3;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 10 + 41;
			A_0 = num;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0001E710 File Offset: 0x0001C910
		private static void AlgorithmSubIdGetTypeFromAssembly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("LavaRockProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_12 = gripDownR;
			int num = ((!A_12) ? 1 : 0) * 1 + 533;
			A_0 = num;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0001E798 File Offset: 0x0001C998
		private static void getItemIsPositiveInfinity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1);
			A_0 = 487;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0001E7E4 File Offset: 0x0001C9E4
		private static void GetChildrensetPercentDecimalSeparator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			bool triggerDownL = WristMenu.triggerDownL;
			A_3 = triggerDownL;
			int num = ((!A_3) ? 1 : 0) * 4 + 179;
			A_0 = num;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0001E844 File Offset: 0x0001CA44
		private static void GetRegistrableTypesInAssemblyIsImport(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GorillaRopeSwing[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			A_1 = 0;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0001E85C File Offset: 0x0001CA5C
		private static void LCIDConversionAttributeThrowIfCancellationRequested(ref int A_0, ref int A_1, ref int A_2)
		{
			WristMenu.FirstColor = Color.black;
			WristMenu.SecondColor = Color.black;
			A_1 = 0;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0001E888 File Offset: 0x0001CA88
		private static void CommandLineConvR(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			bool flag = false;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 59;
			A_0 = num;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0001E8E4 File Offset: 0x0001CAE4
		public static void InvisPlatforms()
		{
			int num = 468;
			int num2 = 468;
			num2 = 468;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 468;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0001E928 File Offset: 0x0001CB28
		private static void StringBuilderCachegetTargetScheduler(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			A_0 = 769;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0001E940 File Offset: 0x0001CB40
		private static void getPMDesignatorManifestPath(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0001E958 File Offset: 0x0001CB58
		private static void WindowObjectBindReferenceToAssemblyManifest(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref PhotonView A_7, ref VRRig A_8, ref bool A_9, ref GameObject A_10)
		{
			bool flag = false;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 238;
			A_0 = num;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0001E9B4 File Offset: 0x0001CBB4
		private static void StringToHGlobalAnsitpQuantum(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			Mods.pointer.transform.position = A_5.point;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 4 + 46;
			A_0 = num;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0001EA38 File Offset: 0x0001CC38
		private static void BranchdwHighDateTime(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -6 + 200;
			A_0 = num;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0001EA80 File Offset: 0x0001CC80
		private static void InterfaceFormatPtr(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_right_local = GameObject.CreatePrimitive(3);
			Mods.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 394;
			A_0 = num;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0001EB0C File Offset: 0x0001CD0C
		private static void GetILGeneratorparamdesc(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			Player.Instance.headCollider.transform.position = Player.Instance.rightControllerTransform.transform.position;
			A_1 = 0;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0001EB50 File Offset: 0x0001CD50
		private static void StackFrameHelpergetObjRef(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = new Color32(byte.MaxValue, 0, 0, 1);
			GorillaTagger.Instance.offlineVRRig.headBodyOffset = Mods.pointer.transform.position;
			Mods.pointer.GetComponent<Renderer>().material.color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1);
			A_0 = 255;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
		public static void SnowballSpamSS()
		{
			int num = 640;
			int num2 = 640;
			num2 = 640;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 640;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0001EC34 File Offset: 0x0001CE34
		private static void GetServiceSysUInt(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			A_1 = 0;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0001EC4C File Offset: 0x0001CE4C
		private static void ConsoleResourceManagerStreamNotFound(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 665;
			A_0 = num;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
		private static void GetLastWriteEventErrorNumberDecimalDigits(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("ElfBow_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.magenta, false);
			A_1 = 0;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0001ECEC File Offset: 0x0001CEEC
		private static void WriteToUnderlyingStreamAsyncdBUILDNUMBER(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			PhotonNetwork.Disconnect();
			NotifiLib.SendNotification("<color=grey>[</color><color=yellow>ANTI-REPORT</color><color=grey>]</color> <color=red>Someone attempted to report you, you have been disconnected.</color>");
			int num = (A_19.MoveNext() ? 1 : 0) * -10 + 721;
			A_0 = num;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0001ED48 File Offset: 0x0001CF48
		private static void IsolatedStorageFilePermissionAttributesetUrl(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			Transform child = A_7.GetChild(A_9);
			A_10 = child;
			bool flag = A_10.name.Contains("GorillaPlayerScoreboardLine");
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 18 + 752;
			A_0 = num;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
		private static void getBuildgetConsumptionScope(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("BucketGiftCoal", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_15 = gripDownR;
			int num = ((!A_15) ? 1 : 0) * 1 + 572;
			A_0 = num;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0001EE68 File Offset: 0x0001D068
		private static void TraceOperationBeginTrySetResult(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			A_1 = 4;
			A_2 = 723;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0001EE8C File Offset: 0x0001D08C
		private static void SleepZeroFreeGlobalAllocAnsi(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref MeshCollider[] A_4, ref int A_5, ref MeshCollider A_6, ref MeshCollider[] A_7, ref int A_8, ref MeshCollider A_9)
		{
			int num = ((A_8 < A_7.Length) ? 1 : 0) * -2 + 166;
			A_0 = num;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0001EEC8 File Offset: 0x0001D0C8
		private static void SmuggledObjRefIEnumConnectionPoints(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7)
		{
			int num = ((!Physics.Raycast(Player.Instance.rightControllerTransform.position - Player.Instance.rightControllerTransform.up, -Player.Instance.rightControllerTransform.up, ref A_5)) ? 1 : 0) * 1 + 490;
			A_0 = num;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0001EF48 File Offset: 0x0001D148
		private static void setPathDiscoveryInternalOptionsMask(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_5 = gripDownR;
			int num = ((!A_5) ? 1 : 0) * 1 + 519;
			A_0 = num;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0001EFA4 File Offset: 0x0001D1A4
		private static void GetItemEventRegistrationToken(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 109;
			A_0 = num;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0001F00C File Offset: 0x0001D20C
		private static void LiveActivitiesCMSTIMEUNITTYPEHOURS(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			VRRig vrrig = A_4.Current;
			A_5 = vrrig;
			int num = (A_5.isOfflineVRRig ? 1 : 0) * 1 + 195;
			A_0 = num;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0001F074 File Offset: 0x0001D274
		public static void sizeablewatersplash()
		{
			int num = 72;
			int num2 = 72;
			num2 = 72;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				Vector3 vector;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,UnityEngine.Vector3&), ref num, ref num2, ref num3, ref flag, ref flag2, ref vector, Mods.ControlThreadBadData[num]);
			}
			num2 = 72;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0001F0B0 File Offset: 0x0001D2B0
		private static void AllocateBufferAgedgetResourceTypeResourcesDependency(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			GorillaFriendCollider[] array = Object.FindObjectsOfType<GorillaFriendCollider>();
			A_8 = array;
			int num = 0;
			A_9 = num;
			A_0 = 48;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		private static string UnregisterTrackingHandlerModifyAuditRule(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			string text = "city";
			A_5 = text;
			A_0 = 289;
			string result;
			return result;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0001F12C File Offset: 0x0001D32C
		private static void StsfldNullReferenceExceptionOnAV(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0001F144 File Offset: 0x0001D344
		private static void getOptionalPermissionsResolveEventArgs(ref int A_0, ref int A_1, ref int A_2)
		{
			WristMenu.settingsbuttons[0].enabled = new bool?(false);
			WristMenu.buttons[0].enabled = new bool?(false);
			Mods.inSettings = !Mods.inSettings;
			WristMenu.DestroyMenu();
			WristMenu.instance.Draw();
			A_1 = 0;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0001F1BC File Offset: 0x0001D3BC
		private static void LoaderInformationgetSourceName(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			int num = A_11 + 1;
			A_11 = num;
			bool flag = A_11 < A_7.childCount;
			A_30 = flag;
			int num2 = (A_30 ? 1 : 0) * -20 + 727;
			A_0 = num2;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0001F250 File Offset: 0x0001D450
		private static void SetOutPreserveSigAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("CloudSlingshot_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0001F294 File Offset: 0x0001D494
		public static void WaterBalloonSpamSS()
		{
			int num = 652;
			int num2 = 652;
			num2 = 652;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 652;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0001F2D8 File Offset: 0x0001D4D8
		private static void EndOfStringOnDeserializingAttribute(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			SnowballThrowable[] array = Object.FindObjectsOfType<SnowballThrowable>();
			A_3 = array;
			int num = 0;
			A_4 = num;
			A_0 = 270;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0001F320 File Offset: 0x0001D520
		private static void AddChildLocalSid(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 358;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0001F338 File Offset: 0x0001D538
		private static void SortKeySetWindowSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (Mods.once_left ? 1 : 0) * 1 + 403;
			A_0 = num;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0001F37C File Offset: 0x0001D57C
		private static void LOADFROMCodePageIndex(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 400;
			A_0 = num;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0001F3D8 File Offset: 0x0001D5D8
		public unsafe static void PunchMod()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 782;
			int num4 = 782;
			num4 = 782;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num19;
				int num22;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 4)
					{
						num4 = 782;
						if ((int)array[6] != 1)
						{
							num5 = (int)array[1];
							num6 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num5 + 56 + num2);
							for (num7 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + (int)array[0] + 56 + num2) + 56 + num2); num7 != num6; num7 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num7 + 56 + num2))
							{
								num8 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num7 + num2);
								if (num8 != -1)
								{
									num9 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num8 + 16 + num2);
									array[0] = num8;
									array[2] = 2;
									num3 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num8 + 16 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[5];
							num9 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num5 + 16 + num2);
							ex2 = ex;
							array = (object[])array[3];
							array2 = new object[8];
							array2[6] = 0;
							array2[3] = array;
							array2[5] = ex;
							array2[0] = num5;
							array2[2] = 1;
							array = array2;
							num3 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num5 + 16 + num2);
							continue;
						}
						num10 = (int)array[7];
						array = (object[])array[3];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 5)
						{
							int num13;
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							Vector3 vector;
							Vector3 vector2;
							bool flag2;
							bool flag3;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Int32&,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&,UnityEngine.Vector3&,UnityEngine.Vector3&,System.Boolean&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref num13, ref enumerator, ref vrrig, ref flag, ref vector, ref vector2, ref flag2, ref flag3, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 782;
						num8 = num12;
						num11 = num8;
					}
					num14 = num3;
					num6 = num14;
					num10 = 0;
					num15 = 2;
					for (;;)
					{
						num16 = (num10 + num15) / 2;
						num17 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 160 + num16 * 40 + 24 + num2);
						num18 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 160 + num16 * 40 + 8 + num2);
						if (num6 < num17 + num18)
						{
							if (num17 <= num6)
							{
								break;
							}
							num15 = num16 - 1;
						}
						else
						{
							num10 = num16 + 1;
						}
					}
					num7 = num16;
					num9 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 160 + num7 * 40 + num2);
					num19 = num9;
					num18 = num11;
					num17 = 0;
					num16 = 2;
					for (;;)
					{
						num15 = (num17 + num16) / 2;
						num10 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 160 + num15 * 40 + 24 + num2);
						num6 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 160 + num15 * 40 + 8 + num2);
						if (num18 < num10 + num6)
						{
							if (num10 <= num18)
							{
								break;
							}
							num16 = num15 - 1;
						}
						else
						{
							num17 = num15 + 1;
						}
					}
					num7 = num15;
					num8 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 160 + num7 * 40 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num15 = 2;
					for (;;)
					{
						num16 = (num10 + num15) / 2;
						num17 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 280 + num16 * 48 + 32 + num2);
						num18 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 280 + num16 * 48 + 16 + num2);
						if (num6 < num17 + num18)
						{
							if (num17 <= num6)
							{
								break;
							}
							num15 = num16 - 1;
						}
						else
						{
							num10 = num16 + 1;
						}
					}
					num7 = num16;
					num5 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 280 + num7 * 48 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9C4:
						if (array == null || (int)array[6] == 1)
						{
							num6 = num9;
							while (num6 != num19)
							{
								if (num6 != -1)
								{
									num6 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num6 + 56 + num2);
								}
								else
								{
									num10 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num19 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num19 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num19 + 56 + num2);
									goto IL_9C4;
								}
							}
							goto IL_B5C;
						}
						int num20 = (int)array[0];
						int num21;
						if (num19 == -1)
						{
							num21 = -1;
						}
						else
						{
							num22 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num19 + 16 + num2);
							num18 = 0;
							num17 = 2;
							for (;;)
							{
								num16 = (num18 + num17) / 2;
								num15 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 280 + num16 * 48 + 32 + num2);
								num10 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 280 + num16 * 48 + 16 + num2);
								if (num22 < num15 + num10)
								{
									if (num15 <= num22)
									{
										break;
									}
									num17 = num16 - 1;
								}
								else
								{
									num18 = num16 + 1;
								}
							}
							num5 = num16;
							num7 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 280 + num5 * 48 + num2);
							num21 = num7;
						}
						if (num20 == num21)
						{
							num7 = num9;
							while (num7 != num19)
							{
								if (num7 != -1)
								{
									num7 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num7 + 56 + num2);
								}
								else
								{
									num5 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num19 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num19 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num19 + 56 + num2);
									goto IL_9C4;
								}
							}
							break;
						}
						if ((int)array[0] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[3];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num5 + 16 + num2);
					array2 = new object[8];
					array2[6] = 1;
					array2[3] = array;
					array2[7] = num11;
					array2[0] = num5;
					array2[2] = 2;
					array = array2;
					num3 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num5 + 16 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B5C:
					num3 = num11;
					continue;
					Block_58:
					num15 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num10 + 16 + num2);
					array2 = new object[8];
					array2[6] = 1;
					array2[3] = array;
					array2[7] = num11;
					array2[0] = num10;
					array2[2] = 2;
					array = array2;
					num3 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num10 + 16 + num2);
				}
				num4 = 782;
				return;
				IL_1CB:
				if (num6 != -1)
				{
					goto IL_1D6;
				}
				goto IL_3FA;
				IL_1D6:
				num7 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num6 + 32 + num2);
				if (3 == num7)
				{
					goto IL_1F5;
				}
				if (1 == num7)
				{
					goto IL_381;
				}
				goto IL_3FA;
				IL_1F5:
				num9 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num6 + num2);
				if (num9 == -1)
				{
					goto IL_240;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_226;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_226:
				if (type.IsInstanceOfType(array2[5]))
				{
					goto IL_240;
				}
				num6 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num6 + 40 + num2);
				goto IL_1CB;
				IL_240:
				num5 = num6;
				num8 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num5 + 56 + num2) + 56 + num2);
				num14 = (int)array2[4];
				IL_264:
				if (num14 != num8)
				{
					goto IL_2E3;
				}
				int num23 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num5 + 16 + num2);
				ex2 = array2[5];
				array = (object[])array[3];
				object[] array5 = new object[8];
				array5[6] = 0;
				array5[3] = array;
				array5[5] = array2[5];
				array5[4] = (int)array2[4];
				array5[0] = num5;
				array5[2] = 1;
				array = array5;
				num3 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num5 + 16 + num2);
				goto IL_23;
				IL_2E3:
				num19 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num14 + num2);
				if (num19 == -1)
				{
					goto IL_36F;
				}
				num23 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num19 + 16 + num2);
				array = (object[])array[3];
				array5 = new object[8];
				array5[6] = 0;
				array5[3] = array;
				array5[5] = array2[5];
				array5[4] = (int)array2[4];
				array5[0] = num19;
				array5[1] = num5;
				array5[2] = 2;
				array = array5;
				num3 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num19 + 16 + num2);
				goto IL_23;
				IL_36F:
				num14 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num14 + 56 + num2);
				goto IL_264;
				IL_381:
				num23 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num6 + 64 + num2);
				ex2 = array2[5];
				array = (object[])array[3];
				array5 = new object[8];
				array5[6] = 0;
				array5[3] = array;
				array5[5] = array2[5];
				array5[4] = (int)array2[4];
				array5[0] = num6;
				array5[2] = 0;
				array = array5;
				num3 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num6 + 64 + num2);
				goto IL_23;
				IL_3FA:
				array = (object[])array[3];
				Exception ex3 = array2[5];
				int num24 = (int)array2[4];
				IL_419:
				num6 = num3;
				num23 = num6;
				num22 = 0;
				num10 = 2;
				IL_427:
				num15 = (num22 + num10) / 2;
				num16 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 160 + num15 * 40 + 24 + num2);
				num17 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 160 + num15 * 40 + 8 + num2);
				if (num23 >= num16 + num17)
				{
					goto IL_46C;
				}
				if (num16 > num23)
				{
					goto IL_474;
				}
				num8 = num15;
				num5 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 160 + num8 * 40 + num2);
				num9 = num5;
				num14 = num9;
				goto IL_499;
				IL_46C:
				num22 = num15 + 1;
				goto IL_427;
				IL_474:
				num10 = num15 - 1;
				goto IL_427;
				IL_499:
				if (array != null)
				{
					goto IL_4A4;
				}
				goto IL_62D;
				IL_4A4:
				if ((int)array[6] != 1)
				{
					goto IL_561;
				}
				int num25 = (int)array[0];
				if (num9 != -1)
				{
					goto IL_4C8;
				}
				int num26 = -1;
				goto IL_548;
				IL_4C8:
				num18 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num9 + 16 + num2);
				num17 = 0;
				num16 = 2;
				IL_4DB:
				num15 = (num17 + num16) / 2;
				num10 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 280 + num15 * 48 + 32 + num2);
				num22 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 280 + num15 * 48 + 16 + num2);
				if (num18 >= num10 + num22)
				{
					goto IL_521;
				}
				if (num10 > num18)
				{
					goto IL_529;
				}
				num5 = num15;
				num8 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 280 + num5 * 48 + num2);
				num26 = num8;
				goto IL_548;
				IL_521:
				num17 = num15 + 1;
				goto IL_4DB;
				IL_529:
				num16 = num15 - 1;
				goto IL_4DB;
				IL_548:
				if (num25 != num26)
				{
					goto IL_550;
				}
				goto IL_62D;
				IL_550:
				array = (object[])array[3];
				goto IL_499;
				IL_561:
				num19 = (int)array[2];
				if (num19 == 1 || num19 == 2)
				{
					goto IL_582;
				}
				if (num19 != 0)
				{
					goto IL_581;
				}
				array2 = array;
				num6 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + (int)array2[0] + 40 + num2);
				goto IL_1CB;
				IL_581:
				IL_582:
				int num27 = (int)array[0];
				if (num9 != -1)
				{
					goto IL_597;
				}
				int num28 = -1;
				goto IL_617;
				IL_597:
				num23 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num9 + 16 + num2);
				num22 = 0;
				num10 = 2;
				IL_5AA:
				num15 = (num22 + num10) / 2;
				num16 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 280 + num15 * 48 + 32 + num2);
				num17 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 280 + num15 * 48 + 16 + num2);
				if (num23 >= num16 + num17)
				{
					goto IL_5F0;
				}
				if (num16 > num23)
				{
					goto IL_5F8;
				}
				num8 = num15;
				num5 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + 280 + num8 * 48 + num2);
				num28 = num5;
				goto IL_617;
				IL_5F0:
				num22 = num15 + 1;
				goto IL_5AA;
				IL_5F8:
				num10 = num15 - 1;
				goto IL_5AA;
				IL_617:
				if (num27 != num28)
				{
					goto IL_61C;
				}
				goto IL_62D;
				IL_61C:
				array = (object[])array[3];
				goto IL_499;
				IL_62D:
				if (-1 != num9)
				{
					goto IL_639;
				}
				int num29 = 1;
				throw ex3;
				IL_639:
				num7 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num9 + 32 + num2);
				num10 = num7;
				IL_64A:
				if (num10 != -1)
				{
					goto IL_661;
				}
				num9 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num9 + 56 + num2);
				goto IL_499;
				IL_661:
				num16 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num10 + 32 + num2);
				if (3 == num16)
				{
					goto IL_68C;
				}
				if (1 == num16)
				{
					goto IL_7F4;
				}
				num9 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num9 + 56 + num2);
				goto IL_499;
				IL_68C:
				num15 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num10 + num2);
				if (num15 == -1)
				{
					goto IL_6D8;
				}
				Type type2;
				if ((type2 = array3[num15]) != null)
				{
					goto IL_6BD;
				}
				array3[num15] = Type.GetTypeFromHandle(array4[num15]);
				type2 = array3[num15];
				IL_6BD:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6D8;
				}
				num10 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num10 + 40 + num2);
				goto IL_64A;
				IL_6D8:
				num5 = num10;
				num8 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num5 + 56 + num2) + 56 + num2);
				num18 = (num14 - num24) * ((num24 == -1) ? 1 : 0) + num24;
				IL_701:
				if (num18 != num8)
				{
					goto IL_76A;
				}
				num22 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num5 + 16 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[6] = 0;
				array2[3] = array;
				array2[5] = ex3;
				array2[4] = num14;
				array2[0] = num5;
				array2[2] = 1;
				array = array2;
				num3 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num5 + 16 + num2);
				goto IL_23;
				IL_76A:
				num17 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num18 + num2);
				if (num17 == -1)
				{
					goto IL_7E2;
				}
				num22 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num17 + 16 + num2);
				array2 = new object[8];
				array2[6] = 0;
				array2[3] = array;
				array2[5] = ex3;
				array2[4] = num14;
				array2[0] = num17;
				array2[1] = num5;
				array2[2] = 2;
				array = array2;
				num3 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num17 + 16 + num2);
				goto IL_23;
				IL_7E2:
				num18 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num18 + 56 + num2);
				goto IL_701;
				IL_7F4:
				num22 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num10 + 64 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[6] = 0;
				array2[3] = array;
				array2[5] = ex3;
				array2[4] = num14;
				array2[0] = num10;
				array2[2] = 0;
				array = array2;
				num3 = *(ref DebugMessageOtherLetter.ShadowCopyDirectoriesValueAbbreviatedMonthNames + num10 + 64 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num29;
				if (num29 != 1)
				{
					Exception ex3 = ex4;
					int num24 = -1;
					goto IL_419;
				}
				throw ex4;
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0001FFF8 File Offset: 0x0001E1F8
		private static string ITupleInternalTYPEKIND(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			bool flag = A_3.ToString().Contains("mountain");
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 283;
			A_0 = num;
			string result;
			return result;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0002006C File Offset: 0x0001E26C
		private static void getOutgetMinimumRequiredVersion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("BucketGiftSquare", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_18 = gripDownR;
			int num = ((!A_18) ? 1 : 0) * 1 + 578;
			A_0 = num;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000200F4 File Offset: 0x0001E2F4
		private static void AsyncDelegateReleaseBoundObjects(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			bool flag = Mods.pointer == null;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 250;
			A_0 = num;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0002015C File Offset: 0x0001E35C
		private static List<VRRig> SecurityExceptionImport(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			((IDisposable)A_4).Dispose();
			A_1 = 1;
			List<VRRig> result;
			return result;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00020188 File Offset: 0x0001E388
		private static void setIsReadOnlyATTDef(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			bool flag = false;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 482;
			A_0 = num;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000201E4 File Offset: 0x0001E3E4
		private static void GetFuncIndexOfMemIdTryEnqueue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 6;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 94;
			A_0 = num;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0002024C File Offset: 0x0001E44C
		private static void ProgIdAttributeEVENTACTIVITYCTRLSETID(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			A_5.randomizeColor = true;
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -4 + 265;
			A_0 = num2;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000202C0 File Offset: 0x0001E4C0
		private static void ToByteArrayStrongNameSignatureGenerationEx(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref bool A_6, ref float A_7, ref bool A_8, ref bool A_9)
		{
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -8 + 827;
			A_0 = num2;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00020320 File Offset: 0x0001E520
		private static void SetBufferSizeRightWindows(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_0 = 368;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00020338 File Offset: 0x0001E538
		public static void InvisV2()
		{
			int num = 331;
			int num2 = 331;
			num2 = 331;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				GameObject gameObject;
				GameObject gameObject2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&), ref num, ref num2, ref num3, ref flag, ref flag2, ref gameObject, ref gameObject2, Mods.ControlThreadBadData[num]);
			}
			num2 = 331;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00020384 File Offset: 0x0001E584
		public static void RoundSpamSS()
		{
			int num = 670;
			int num2 = 670;
			num2 = 670;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 670;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000203C8 File Offset: 0x0001E5C8
		private static void UTFBufferMarshalerGetRegisteredActivatedClientTypes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			A_8.gameObject.transform.position = A_4.transform.position;
			Mods.flushmanually();
			int num = A_7 + 1;
			A_7 = num;
			int num2 = ((A_7 < A_6.Length) ? 1 : 0) * -4 + 925;
			A_0 = num2;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0002045C File Offset: 0x0001E65C
		public static void MosaSpeedOff()
		{
			int num = 467;
			int num2 = 467;
			num2 = 467;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 467;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000204A0 File Offset: 0x0001E6A0
		private static void getApplicationNameCompletion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("BucketGiftRoll", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_16 = gripDownR;
			int num = ((!A_16) ? 1 : 0) * 1 + 574;
			A_0 = num;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00020528 File Offset: 0x0001E728
		private static string ConfiguredGuidIdOps(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			bool flag = A_3.ToString().Contains("private");
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 287;
			A_0 = num;
			string result;
			return result;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0002059C File Offset: 0x0001E79C
		private static void getHandledEncodedEnumType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			bool flag = A_10.mainSkin.material.name.Contains("rock");
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 901;
			A_0 = num;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0002061C File Offset: 0x0001E81C
		private static void ObjectIDGeneratorGetEventItfType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00020634 File Offset: 0x0001E834
		private static void getRevisionTaskAwaiter(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Color A_4, ref bool A_5, ref string A_6, ref List<ButtonInfo>.Enumerator A_7, ref ButtonInfo A_8, ref bool A_9)
		{
			A_0 = 851;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0002064C File Offset: 0x0001E84C
		private static void MultiProducerMultiConsumerQueueSetRemoveOnMethod(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_0 = 199;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00020664 File Offset: 0x0001E864
		private static void getHostgetElementIndex(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool flag = Mods.upside;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 16;
			A_0 = num;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000206C0 File Offset: 0x0001E8C0
		private static void PrivateImplementationDetailsGetRefTypeInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color black = Color.black;
			A_4 = black;
			bool flag = A_5 == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 84;
			A_0 = num;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00020740 File Offset: 0x0001E940
		public static void primaryleave()
		{
			int num = 869;
			int num2 = 869;
			num2 = 869;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, Mods.ControlThreadBadData[num]);
			}
			num2 = 869;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00020788 File Offset: 0x0001E988
		private static void WinSMC(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000207A0 File Offset: 0x0001E9A0
		private static void FormatPtrgetKeyContainerName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			A_0 = 497;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000207D4 File Offset: 0x0001E9D4
		private static void getHostFileITypeInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("IceSlingshot_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.magenta, false);
			A_1 = 0;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00020818 File Offset: 0x0001EA18
		public unsafe static void LoadOriginal()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 362;
			int num4 = 362;
			num4 = 362;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num19;
				int num22;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 4)
					{
						num4 = 362;
						if ((int)array[3] != 0)
						{
							num5 = (int)array[0];
							num6 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num5 + 32 + num2);
							for (num7 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + (int)array[7] + 32 + num2) + 24 + num2); num7 != num6; num7 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num7 + 24 + num2))
							{
								num8 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num7 + 56 + num2);
								if (num8 != -1)
								{
									num9 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num8 + 80 + num2);
									array[7] = num8;
									array[6] = 1;
									num3 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num8 + 80 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[4];
							num9 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num5 + 80 + num2);
							ex2 = ex;
							array = (object[])array[5];
							array2 = new object[8];
							array2[3] = 1;
							array2[5] = array;
							array2[4] = ex;
							array2[7] = num5;
							array2[6] = 0;
							array = array2;
							num3 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num5 + 80 + num2);
							continue;
						}
						num10 = (int)array[2];
						array = (object[])array[5];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 5)
						{
							string[] array3;
							string[] array4;
							int num13;
							string text;
							List<ButtonInfo>.Enumerator enumerator;
							ButtonInfo buttonInfo;
							bool flag;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.String[]&,System.String[]&,System.Int32&,System.String&,System.Collections.Generic.List`1/Enumerator<ShibaGTTemplate.UI.ButtonInfo>&,ShibaGTTemplate.UI.ButtonInfo&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref array3, ref array4, ref num13, ref text, ref enumerator, ref buttonInfo, ref flag, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 362;
						num8 = num12;
						num11 = num8;
					}
					num14 = num3;
					num6 = num14;
					num10 = 0;
					num15 = 2;
					for (;;)
					{
						num16 = (num10 + num15) / 2;
						num17 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 160 + num16 * 80 + 24 + num2);
						num18 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 160 + num16 * 80 + 56 + num2);
						if (num6 < num17 + num18)
						{
							if (num17 <= num6)
							{
								break;
							}
							num15 = num16 - 1;
						}
						else
						{
							num10 = num16 + 1;
						}
					}
					num7 = num16;
					num9 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 160 + num7 * 80 + 72 + num2);
					num19 = num9;
					num18 = num11;
					num17 = 0;
					num16 = 2;
					for (;;)
					{
						num15 = (num17 + num16) / 2;
						num10 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 160 + num15 * 80 + 24 + num2);
						num6 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 160 + num15 * 80 + 56 + num2);
						if (num18 < num10 + num6)
						{
							if (num10 <= num18)
							{
								break;
							}
							num16 = num15 - 1;
						}
						else
						{
							num17 = num15 + 1;
						}
					}
					num7 = num15;
					num8 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 160 + num7 * 80 + 72 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num15 = 2;
					for (;;)
					{
						num16 = (num10 + num15) / 2;
						num17 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 400 + num16 * 80 + 24 + num2);
						num18 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 400 + num16 * 80 + 56 + num2);
						if (num6 < num17 + num18)
						{
							if (num17 <= num6)
							{
								break;
							}
							num15 = num16 - 1;
						}
						else
						{
							num10 = num16 + 1;
						}
					}
					num7 = num16;
					num5 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 400 + num7 * 80 + 72 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9E6:
						if (array == null || (int)array[3] == 0)
						{
							num6 = num9;
							while (num6 != num19)
							{
								if (num6 != -1)
								{
									num6 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num6 + 24 + num2);
								}
								else
								{
									num10 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num19 + 56 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num19 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num19 + 24 + num2);
									goto IL_9E6;
								}
							}
							goto IL_B84;
						}
						int num20 = (int)array[7];
						int num21;
						if (num19 == -1)
						{
							num21 = -1;
						}
						else
						{
							num22 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num19 + 48 + num2);
							num18 = 0;
							num17 = 2;
							for (;;)
							{
								num16 = (num18 + num17) / 2;
								num15 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 400 + num16 * 80 + 24 + num2);
								num10 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 400 + num16 * 80 + 56 + num2);
								if (num22 < num15 + num10)
								{
									if (num15 <= num22)
									{
										break;
									}
									num17 = num16 - 1;
								}
								else
								{
									num18 = num16 + 1;
								}
							}
							num5 = num16;
							num7 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 400 + num5 * 80 + 72 + num2);
							num21 = num7;
						}
						if (num20 == num21)
						{
							num7 = num9;
							while (num7 != num19)
							{
								if (num7 != -1)
								{
									num7 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num7 + 24 + num2);
								}
								else
								{
									num5 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num19 + 56 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num19 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num19 + 24 + num2);
									goto IL_9E6;
								}
							}
							break;
						}
						if ((int)array[7] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[5];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num5 + 80 + num2);
					array2 = new object[8];
					array2[3] = 0;
					array2[5] = array;
					array2[2] = num11;
					array2[7] = num5;
					array2[6] = 1;
					array = array2;
					num3 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num5 + 80 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B84:
					num3 = num11;
					continue;
					Block_58:
					num15 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num10 + 80 + num2);
					array2 = new object[8];
					array2[3] = 0;
					array2[5] = array;
					array2[2] = num11;
					array2[7] = num10;
					array2[6] = 1;
					array = array2;
					num3 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num10 + 80 + num2);
				}
				num4 = 362;
				return;
				IL_1CC:
				if (num6 != -1)
				{
					goto IL_1D7;
				}
				goto IL_401;
				IL_1D7:
				num7 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num6 + 64 + num2);
				if (1 == num7)
				{
					goto IL_1F6;
				}
				if (3 == num7)
				{
					goto IL_388;
				}
				goto IL_401;
				IL_1F6:
				num9 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num6 + 88 + num2);
				if (num9 == -1)
				{
					goto IL_244;
				}
				Type[] array5;
				Type type;
				if ((type = array5[num9]) != null)
				{
					goto IL_22A;
				}
				RuntimeTypeHandle[] array6;
				array5[num9] = Type.GetTypeFromHandle(array6[num9]);
				type = array5[num9];
				IL_22A:
				if (type.IsInstanceOfType(array2[4]))
				{
					goto IL_244;
				}
				num6 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num6 + 24 + num2);
				goto IL_1CC;
				IL_244:
				num5 = num6;
				num8 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num5 + 32 + num2) + 24 + num2);
				num14 = (int)array2[1];
				IL_268:
				if (num14 != num8)
				{
					goto IL_2E7;
				}
				int num23 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num5 + 80 + num2);
				ex2 = array2[4];
				array = (object[])array[5];
				object[] array7 = new object[8];
				array7[3] = 1;
				array7[5] = array;
				array7[4] = array2[4];
				array7[1] = (int)array2[1];
				array7[7] = num5;
				array7[6] = 0;
				array = array7;
				num3 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num5 + 80 + num2);
				goto IL_23;
				IL_2E7:
				num19 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num14 + 56 + num2);
				if (num19 == -1)
				{
					goto IL_376;
				}
				num23 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num19 + 80 + num2);
				array = (object[])array[5];
				array7 = new object[8];
				array7[3] = 1;
				array7[5] = array;
				array7[4] = array2[4];
				array7[1] = (int)array2[1];
				array7[7] = num19;
				array7[0] = num5;
				array7[6] = 1;
				array = array7;
				num3 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num19 + 80 + num2);
				goto IL_23;
				IL_376:
				num14 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num14 + 24 + num2);
				goto IL_268;
				IL_388:
				num23 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num6 + 72 + num2);
				ex2 = array2[4];
				array = (object[])array[5];
				array7 = new object[8];
				array7[3] = 1;
				array7[5] = array;
				array7[4] = array2[4];
				array7[1] = (int)array2[1];
				array7[7] = num6;
				array7[6] = 2;
				array = array7;
				num3 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num6 + 72 + num2);
				goto IL_23;
				IL_401:
				array = (object[])array[5];
				Exception ex3 = array2[4];
				int num24 = (int)array2[1];
				IL_420:
				num6 = num3;
				num23 = num6;
				num22 = 0;
				num10 = 2;
				IL_42E:
				num15 = (num22 + num10) / 2;
				num16 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 160 + num15 * 80 + 24 + num2);
				num17 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 160 + num15 * 80 + 56 + num2);
				if (num23 >= num16 + num17)
				{
					goto IL_474;
				}
				if (num16 > num23)
				{
					goto IL_47C;
				}
				num8 = num15;
				num5 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 160 + num8 * 80 + 72 + num2);
				num9 = num5;
				num14 = num9;
				goto IL_4A4;
				IL_474:
				num22 = num15 + 1;
				goto IL_42E;
				IL_47C:
				num10 = num15 - 1;
				goto IL_42E;
				IL_4A4:
				if (array != null)
				{
					goto IL_4AF;
				}
				goto IL_63E;
				IL_4AF:
				if ((int)array[3] != 0)
				{
					goto IL_56F;
				}
				int num25 = (int)array[7];
				if (num9 != -1)
				{
					goto IL_4D3;
				}
				int num26 = -1;
				goto IL_556;
				IL_4D3:
				num18 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num9 + 48 + num2);
				num17 = 0;
				num16 = 2;
				IL_4E6:
				num15 = (num17 + num16) / 2;
				num10 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 400 + num15 * 80 + 24 + num2);
				num22 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 400 + num15 * 80 + 56 + num2);
				if (num18 >= num10 + num22)
				{
					goto IL_52C;
				}
				if (num10 > num18)
				{
					goto IL_534;
				}
				num5 = num15;
				num8 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 400 + num5 * 80 + 72 + num2);
				num26 = num8;
				goto IL_556;
				IL_52C:
				num17 = num15 + 1;
				goto IL_4E6;
				IL_534:
				num16 = num15 - 1;
				goto IL_4E6;
				IL_556:
				if (num25 != num26)
				{
					goto IL_55E;
				}
				goto IL_63E;
				IL_55E:
				array = (object[])array[5];
				goto IL_4A4;
				IL_56F:
				num19 = (int)array[6];
				if (num19 == 0 || num19 == 1)
				{
					goto IL_590;
				}
				if (num19 != 2)
				{
					goto IL_58F;
				}
				array2 = array;
				num6 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + (int)array2[7] + 24 + num2);
				goto IL_1CC;
				IL_58F:
				IL_590:
				int num27 = (int)array[7];
				if (num9 != -1)
				{
					goto IL_5A5;
				}
				int num28 = -1;
				goto IL_628;
				IL_5A5:
				num23 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num9 + 48 + num2);
				num22 = 0;
				num10 = 2;
				IL_5B8:
				num15 = (num22 + num10) / 2;
				num16 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 400 + num15 * 80 + 24 + num2);
				num17 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 400 + num15 * 80 + 56 + num2);
				if (num23 >= num16 + num17)
				{
					goto IL_5FE;
				}
				if (num16 > num23)
				{
					goto IL_606;
				}
				num8 = num15;
				num5 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + 400 + num8 * 80 + 72 + num2);
				num28 = num5;
				goto IL_628;
				IL_5FE:
				num22 = num15 + 1;
				goto IL_5B8;
				IL_606:
				num10 = num15 - 1;
				goto IL_5B8;
				IL_628:
				if (num27 != num28)
				{
					goto IL_62D;
				}
				goto IL_63E;
				IL_62D:
				array = (object[])array[5];
				goto IL_4A4;
				IL_63E:
				if (-1 != num9)
				{
					goto IL_64A;
				}
				int num29 = 1;
				throw ex3;
				IL_64A:
				num7 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num9 + 40 + num2);
				num10 = num7;
				IL_65B:
				if (num10 != -1)
				{
					goto IL_672;
				}
				num9 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num9 + 24 + num2);
				goto IL_4A4;
				IL_672:
				num16 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num10 + 64 + num2);
				if (1 == num16)
				{
					goto IL_69D;
				}
				if (3 == num16)
				{
					goto IL_80B;
				}
				num9 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num9 + 24 + num2);
				goto IL_4A4;
				IL_69D:
				num15 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num10 + 88 + num2);
				if (num15 == -1)
				{
					goto IL_6EC;
				}
				Type type2;
				if ((type2 = array5[num15]) != null)
				{
					goto IL_6D1;
				}
				array5[num15] = Type.GetTypeFromHandle(array6[num15]);
				type2 = array5[num15];
				IL_6D1:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6EC;
				}
				num10 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num10 + 24 + num2);
				goto IL_65B;
				IL_6EC:
				num5 = num10;
				num8 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num5 + 32 + num2) + 24 + num2);
				num18 = (num14 - num24) * ((num24 == -1) ? 1 : 0) + num24;
				IL_715:
				if (num18 != num8)
				{
					goto IL_77E;
				}
				num22 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num5 + 80 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[3] = 1;
				array2[5] = array;
				array2[4] = ex3;
				array2[1] = num14;
				array2[7] = num5;
				array2[6] = 0;
				array = array2;
				num3 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num5 + 80 + num2);
				goto IL_23;
				IL_77E:
				num17 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num18 + 56 + num2);
				if (num17 == -1)
				{
					goto IL_7F9;
				}
				num22 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num17 + 80 + num2);
				array2 = new object[8];
				array2[3] = 1;
				array2[5] = array;
				array2[4] = ex3;
				array2[1] = num14;
				array2[7] = num17;
				array2[0] = num5;
				array2[6] = 1;
				array = array2;
				num3 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num17 + 80 + num2);
				goto IL_23;
				IL_7F9:
				num18 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num18 + 24 + num2);
				goto IL_715;
				IL_80B:
				num22 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num10 + 72 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[3] = 1;
				array2[5] = array;
				array2[4] = ex3;
				array2[1] = num14;
				array2[7] = num10;
				array2[6] = 2;
				array = array2;
				num3 = *(ref oInstAssemblyKeyNameAttribute.EnsureStategetIsPinvokeImpl + num10 + 72 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num29;
				if (num29 != 1)
				{
					Exception ex3 = ex4;
					int num24 = -1;
					goto IL_420;
				}
				throw ex4;
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00021464 File Offset: 0x0001F664
		private static void BigMulsetApplyToMembers(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			bool flag = false;
			A_6 = flag;
			bool flag2 = A_6;
			A_7 = flag2;
			int num = ((!A_7) ? 1 : 0) * 1 + 799;
			A_0 = num;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000214DC File Offset: 0x0001F6DC
		private static void VARFLAGFBINDABLEInternalSerializerTypeE(ref int A_0, ref int A_1, ref int A_2, ref Vector2 A_3, ref Vector2 A_4, ref double A_5)
		{
			Vector2 insideUnitCircle = Random.insideUnitCircle;
			A_3 = insideUnitCircle;
			Vector2 vector = A_3.normalized + new Vector2(0.5f, 2f);
			A_4 = vector;
			int num = (PhotonNetwork.InRoom ? 1 : 0) * 1 + 296;
			A_0 = num;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00021564 File Offset: 0x0001F764
		private static void getNumberLockKerbProxyLogon(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0002157C File Offset: 0x0001F77C
		private static void CreateTokenAssumeLocal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_5 = gripDownR;
			int num = ((!A_5) ? 1 : 0) * 1 + 552;
			A_0 = num;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000215D8 File Offset: 0x0001F7D8
		private static void IsFamilyAndAssemblyGetCommandLineArgs(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("BucketGiftCane", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0002161C File Offset: 0x0001F81C
		private static void DateTimeOffsetTypeInfoStrongNameGetBlob(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			A_1 = 0;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00021634 File Offset: 0x0001F834
		private static void SetCodeAddTicks(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0002164C File Offset: 0x0001F84C
		private static void TokenDeviceGroupsgetMemberInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			Mods.pointer.transform.position = A_5.point;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 4 + 434;
			A_0 = num;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000216D0 File Offset: 0x0001F8D0
		private static string setXmlTypeNamespacegetUnderlyingSystemType(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			bool flag = A_3.ToString().Contains("canyon");
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 277;
			A_0 = num;
			string result;
			return result;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00021744 File Offset: 0x0001F944
		public static void CustomPurpandGreen()
		{
			int num = 682;
			int num2 = 682;
			num2 = 682;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, Mods.ControlThreadBadData[num]);
			}
			num2 = 682;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00021790 File Offset: 0x0001F990
		private static void CreateRangesdWindowsIdentity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 401;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000217A8 File Offset: 0x0001F9A8
		private static void BestFitDisabledgetNewEnum(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref MeshCollider[] A_4, ref int A_5, ref MeshCollider A_6, ref MeshCollider[] A_7, ref int A_8, ref MeshCollider A_9)
		{
			MeshCollider meshCollider = A_7[A_8];
			A_9 = meshCollider;
			A_9.enabled = true;
			int num = A_8 + 1;
			A_8 = num;
			int num2 = ((A_8 < A_7.Length) ? 1 : 0) * -2 + 166;
			A_0 = num2;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00021840 File Offset: 0x0001FA40
		private static void IsImportGetEndComSlot(ref int A_0, ref int A_1, ref int A_2)
		{
			Mods.PlatformsThing(Mods.invisplat, Mods.stickyplatforms);
			A_1 = 0;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00021868 File Offset: 0x0001FA68
		private static List<VRRig> getInheritedCultureTypes(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			A_0 = 886;
			List<VRRig> result;
			return result;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00021884 File Offset: 0x0001FA84
		private static void ExportCastclass(ref int A_0, ref int A_1, ref int A_2, ref ScienceExperimentManager.PlayerGameState[] A_3, ref int A_4, ref bool A_5)
		{
			A_3[A_4].touchedLiquid = true;
			A_3[A_4].playerId = ((PhotonNetwork.PlayerList[A_4] == null) ? 0 : PhotonNetwork.PlayerList[A_4].ActorNumber);
			int num = A_4 + 1;
			A_4 = num;
			bool flag = A_4 < 10;
			A_5 = flag;
			int num2 = (A_5 ? 1 : 0) * -2 + 301;
			A_0 = num2;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0002197C File Offset: 0x0001FB7C
		private static void TaskWaitNIname(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Color A_4, ref bool A_5, ref string A_6, ref List<ButtonInfo>.Enumerator A_7, ref ButtonInfo A_8, ref bool A_9)
		{
			Color color = Random.ColorHSV();
			A_4 = color;
			Mods.namelist.Add("MONKEYMAN");
			Mods.namelist.Add("GOOBER");
			Mods.namelist.Add("REALONE");
			Mods.namelist.Add("LAMPGT");
			Mods.namelist.Add("DISGUISEDMAN");
			Mods.namelist.Add("GOOFYGOOBER");
			Mods.namelist.Add("JIKOMAN");
			Mods.namelist.Add("BAGUETTE");
			Mods.namelist.Add("POOKIE");
			Mods.namelist.Add("HMMM");
			Mods.namelist.Add("WHATIS");
			Mods.namelist.Add("FORTNITE");
			Mods.namelist.Add("MOUSE");
			Mods.namelist.Add("SPESZ");
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(-66.7989f, 12.5422f, -82.6815f);
			bool flag = GorillaComputer.instance.friendJoinCollider.playerIDsCurrentlyTouching.Contains(PhotonNetwork.LocalPlayer.UserId);
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 9 + 846;
			A_0 = num;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00021B28 File Offset: 0x0001FD28
		private static void LastCalledTypeLeftToRight(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("IceSlingshot_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_9 = gripDownR;
			int num = ((!A_9) ? 1 : 0) * 1 + 527;
			A_0 = num;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00021BB0 File Offset: 0x0001FDB0
		public static void Settings()
		{
			int num = 18;
			int num2 = 18;
			num2 = 18;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 18;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00021BE8 File Offset: 0x0001FDE8
		private static void BgeSubstringEquals(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("LavaRockProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00021C2C File Offset: 0x0001FE2C
		private static void ObjectWithMapTypedAssemIdWinBuiltinTerminalServerLicenseServersSid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref Vector3 A_5)
		{
			A_1 = 0;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00021C44 File Offset: 0x0001FE44
		private static void getTaskSchedulergetAllLocalFiles(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			int num = A_11 + 1;
			A_11 = num;
			bool flag = A_11 < A_7.childCount;
			A_30 = flag;
			int num2 = (A_30 ? 1 : 0) * -20 + 727;
			A_0 = num2;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00021CD8 File Offset: 0x0001FED8
		public static void OPAntiBan()
		{
			int num = 307;
			int num2 = 307;
			num2 = 307;
			while (num2 != 0)
			{
				int num3;
				object obj;
				bool flag;
				ExecuteCloudScriptRequest executeCloudScriptRequest;
				string text;
				Hashtable hashtable;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Object&,System.Boolean&,PlayFab.ClientModels.ExecuteCloudScriptRequest&,System.String&,ExitGames.Client.Photon.Hashtable&), ref num, ref num2, ref num3, ref obj, ref flag, ref executeCloudScriptRequest, ref text, ref hashtable, Mods.ControlThreadBadData[num]);
			}
			num2 = 307;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00021D24 File Offset: 0x0001FF24
		private static string ProviderTypegetEndOffset(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			string text = "cave";
			A_5 = text;
			A_0 = 289;
			string result;
			return result;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00021D58 File Offset: 0x0001FF58
		private static void WdiDiagnosticBltUnS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7)
		{
			Mods.pointer = GameObject.CreatePrimitive(0);
			Object.Destroy(Mods.pointer.GetComponent<Rigidbody>());
			Object.Destroy(Mods.pointer.GetComponent<SphereCollider>());
			Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 494;
			A_0 = num;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00021E30 File Offset: 0x00020030
		private static void SetConfigurationBytesEvent(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = A_7.mainSkin.material.name.Contains("fected");
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 224;
			A_0 = num;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00021EAC File Offset: 0x000200AC
		private static void setModeCMSTIMEUNITTYPEDAYS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref Vector3 A_5)
		{
			Vector3 vector = Vector3.Lerp(GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.leftHandTransform.position, 0.5f);
			A_5 = vector;
			GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", 0, new object[]
			{
				A_5,
				Quaternion.identity,
				Vector3.Distance(GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.leftHandTransform.position),
				Vector3.Distance(GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.leftHandTransform.position),
				false,
				true
			});
			Mods.flushmanually();
			A_1 = 0;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00021FD0 File Offset: 0x000201D0
		public static void RollSpamSS()
		{
			int num = 667;
			int num2 = 667;
			num2 = 667;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 667;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00022014 File Offset: 0x00020214
		private static void UseUserProtectedKeyIHashCodeProvider(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = (A_8.MoveNext() ? 1 : 0) * -4 + 369;
			A_0 = num;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0002205C File Offset: 0x0002025C
		private static void IMonikerLessThan(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 8;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 98;
			A_0 = num;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000220C4 File Offset: 0x000202C4
		private static void RightWindowsAuthorizationDecision(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			int num = (A_19.MoveNext() ? 1 : 0) * -10 + 721;
			A_0 = num;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0002210C File Offset: 0x0002030C
		private static void ISectionWithReferenceIdentityKeyAppendLine(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Color A_4, ref bool A_5, ref string A_6, ref List<ButtonInfo>.Enumerator A_7, ref ButtonInfo A_8, ref bool A_9)
		{
			ButtonInfo buttonInfo = A_7.Current;
			A_8 = buttonInfo;
			bool flag = A_8.buttonText.Contains("Disguise");
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 849;
			A_0 = num;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00022198 File Offset: 0x00020398
		private static void TransitionTimeInternalMessageWrapper(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			int num = A_9 + 1;
			A_9 = num;
			bool flag = A_9 < A_7.childCount;
			A_22 = flag;
			int num2 = (A_22 ? 1 : 0) * -21 + 772;
			A_0 = num2;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00022228 File Offset: 0x00020428
		private static void getIsInterfaceNegativeSign(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			PhotonView photonView = ((GorillaRopeSwing)A_4[A_5]).photonView;
			A_6 = photonView;
			string text = "SetVelocity";
			A_7 = text;
			RpcTarget rpcTarget = 0;
			A_8 = rpcTarget;
			object[] array = new object[4];
			A_9 = array;
			A_9[0] = 10;
			A_9[1] = new Vector3((float)Random.Range(0, 999), (float)Random.Range(0, 999), (float)Random.Range(0, 999));
			A_9[2] = true;
			A_6.RPC(A_7, A_8, A_9);
			Mods.flushmanually();
			int num = A_5 + 1;
			A_5 = num;
			bool flag = A_5 < A_4.Length;
			A_10 = flag;
			int num2 = (A_10 ? 1 : 0) * -2 + 174;
			A_0 = num2;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000223D8 File Offset: 0x000205D8
		public unsafe static void Chams()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 218;
			int num4 = 218;
			num4 = 218;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 3)
					{
						num4 = 218;
						if ((int)array[6] != 1)
						{
							num5 = (int)array[3];
							num6 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num5 + 72 + num2);
							for (num7 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + (int)array[2] + 72 + num2) + 64 + num2); num7 != num6; num7 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num7 + 64 + num2))
							{
								num8 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num7 + 16 + num2);
								if (num8 != -1)
								{
									num9 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num8 + 32 + num2);
									array[2] = num8;
									array[1] = 2;
									num3 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num8 + 32 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[7];
							num9 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num5 + 32 + num2);
							ex2 = ex;
							array = (object[])array[5];
							array2 = new object[8];
							array2[6] = 0;
							array2[5] = array;
							array2[7] = ex;
							array2[2] = num5;
							array2[1] = 0;
							array = array2;
							num3 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num5 + 32 + num2);
							continue;
						}
						num10 = (int)array[4];
						array = (object[])array[5];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 5)
						{
							Material material;
							Material material2;
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							bool flag2;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,UnityEngine.Material&,UnityEngine.Material&,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref material, ref material2, ref enumerator, ref vrrig, ref flag, ref flag2, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 218;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 176 + num15 * 56 + 40 + num2);
						num17 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 176 + num15 * 56 + 32 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 176 + num7 * 56 + 8 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 176 + num14 * 56 + 40 + num2);
						num6 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 176 + num14 * 56 + 32 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 176 + num7 * 56 + 8 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 344 + num15 * 56 + 40 + num2);
						num17 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 344 + num15 * 56 + 32 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 344 + num7 * 56 + 8 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9DB:
						if (array == null || (int)array[6] == 1)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num6 + 64 + num2);
								}
								else
								{
									num10 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num18 + 16 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num18 + 64 + num2);
									goto IL_9DB;
								}
							}
							goto IL_B78;
						}
						int num19 = (int)array[2];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num18 + 24 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 344 + num15 * 56 + 40 + num2);
								num10 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 344 + num15 * 56 + 32 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 344 + num5 * 56 + 8 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num7 + 64 + num2);
								}
								else
								{
									num5 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num18 + 16 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num18 + 64 + num2);
									goto IL_9DB;
								}
							}
							break;
						}
						if ((int)array[2] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[5];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num5 + 32 + num2);
					array2 = new object[8];
					array2[6] = 1;
					array2[5] = array;
					array2[4] = num11;
					array2[2] = num5;
					array2[1] = 2;
					array = array2;
					num3 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num5 + 32 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B78:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num10 + 32 + num2);
					array2 = new object[8];
					array2[6] = 1;
					array2[5] = array;
					array2[4] = num11;
					array2[2] = num10;
					array2[1] = 2;
					array = array2;
					num3 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num10 + 32 + num2);
				}
				num4 = 218;
				return;
				IL_1C9:
				if (num6 != -1)
				{
					goto IL_1D4;
				}
				goto IL_3FD;
				IL_1D4:
				num7 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num6 + 80 + num2);
				if (4 == num7)
				{
					goto IL_1F3;
				}
				if (3 == num7)
				{
					goto IL_384;
				}
				goto IL_3FD;
				IL_1F3:
				num9 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num6 + 24 + num2);
				if (num9 == -1)
				{
					goto IL_240;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_227;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_227:
				if (type.IsInstanceOfType(array2[7]))
				{
					goto IL_240;
				}
				num6 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num6 + 8 + num2);
				goto IL_1C9;
				IL_240:
				num5 = num6;
				num8 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num5 + 72 + num2) + 64 + num2);
				num13 = (int)array2[0];
				IL_264:
				if (num13 != num8)
				{
					goto IL_2E3;
				}
				int num22 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num5 + 32 + num2);
				ex2 = array2[7];
				array = (object[])array[5];
				object[] array5 = new object[8];
				array5[6] = 0;
				array5[5] = array;
				array5[7] = array2[7];
				array5[0] = (int)array2[0];
				array5[2] = num5;
				array5[1] = 0;
				array = array5;
				num3 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num5 + 32 + num2);
				goto IL_23;
				IL_2E3:
				num18 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num13 + 16 + num2);
				if (num18 == -1)
				{
					goto IL_372;
				}
				num22 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num18 + 32 + num2);
				array = (object[])array[5];
				array5 = new object[8];
				array5[6] = 0;
				array5[5] = array;
				array5[7] = array2[7];
				array5[0] = (int)array2[0];
				array5[2] = num18;
				array5[3] = num5;
				array5[1] = 2;
				array = array5;
				num3 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num18 + 32 + num2);
				goto IL_23;
				IL_372:
				num13 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num13 + 64 + num2);
				goto IL_264;
				IL_384:
				num22 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num6 + 88 + num2);
				ex2 = array2[7];
				array = (object[])array[5];
				array5 = new object[8];
				array5[6] = 0;
				array5[5] = array;
				array5[7] = array2[7];
				array5[0] = (int)array2[0];
				array5[2] = num6;
				array5[1] = 1;
				array = array5;
				num3 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num6 + 88 + num2);
				goto IL_23;
				IL_3FD:
				array = (object[])array[5];
				Exception ex3 = array2[7];
				int num23 = (int)array2[0];
				IL_41C:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_42A:
				num14 = (num21 + num10) / 2;
				num15 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 176 + num14 * 56 + 40 + num2);
				num16 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 176 + num14 * 56 + 32 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_470;
				}
				if (num15 > num22)
				{
					goto IL_478;
				}
				num8 = num14;
				num5 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 176 + num8 * 56 + 8 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_49F;
				IL_470:
				num21 = num14 + 1;
				goto IL_42A;
				IL_478:
				num10 = num14 - 1;
				goto IL_42A;
				IL_49F:
				if (array != null)
				{
					goto IL_4AA;
				}
				goto IL_637;
				IL_4AA:
				if ((int)array[6] != 1)
				{
					goto IL_569;
				}
				int num24 = (int)array[2];
				if (num9 != -1)
				{
					goto IL_4CE;
				}
				int num25 = -1;
				goto IL_550;
				IL_4CE:
				num17 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num9 + 24 + num2);
				num16 = 0;
				num15 = 2;
				IL_4E1:
				num14 = (num16 + num15) / 2;
				num10 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 344 + num14 * 56 + 40 + num2);
				num21 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 344 + num14 * 56 + 32 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_527;
				}
				if (num10 > num17)
				{
					goto IL_52F;
				}
				num5 = num14;
				num8 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 344 + num5 * 56 + 8 + num2);
				num25 = num8;
				goto IL_550;
				IL_527:
				num16 = num14 + 1;
				goto IL_4E1;
				IL_52F:
				num15 = num14 - 1;
				goto IL_4E1;
				IL_550:
				if (num24 != num25)
				{
					goto IL_558;
				}
				goto IL_637;
				IL_558:
				array = (object[])array[5];
				goto IL_49F;
				IL_569:
				num18 = (int)array[1];
				if (num18 == 0 || num18 == 2)
				{
					goto IL_58A;
				}
				if (num18 != 1)
				{
					goto IL_589;
				}
				array2 = array;
				num6 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + (int)array2[2] + 8 + num2);
				goto IL_1C9;
				IL_589:
				IL_58A:
				int num26 = (int)array[2];
				if (num9 != -1)
				{
					goto IL_59F;
				}
				int num27 = -1;
				goto IL_621;
				IL_59F:
				num22 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num9 + 24 + num2);
				num21 = 0;
				num10 = 2;
				IL_5B2:
				num14 = (num21 + num10) / 2;
				num15 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 344 + num14 * 56 + 40 + num2);
				num16 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 344 + num14 * 56 + 32 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5F8;
				}
				if (num15 > num22)
				{
					goto IL_600;
				}
				num8 = num14;
				num5 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + 344 + num8 * 56 + 8 + num2);
				num27 = num5;
				goto IL_621;
				IL_5F8:
				num21 = num14 + 1;
				goto IL_5B2;
				IL_600:
				num10 = num14 - 1;
				goto IL_5B2;
				IL_621:
				if (num26 != num27)
				{
					goto IL_626;
				}
				goto IL_637;
				IL_626:
				array = (object[])array[5];
				goto IL_49F;
				IL_637:
				if (-1 != num9)
				{
					goto IL_643;
				}
				int num28 = 1;
				throw ex3;
				IL_643:
				num7 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num9 + 56 + num2);
				num10 = num7;
				IL_654:
				if (num10 != -1)
				{
					goto IL_66B;
				}
				num9 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num9 + 64 + num2);
				goto IL_49F;
				IL_66B:
				num15 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num10 + 80 + num2);
				if (4 == num15)
				{
					goto IL_696;
				}
				if (3 == num15)
				{
					goto IL_803;
				}
				num9 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num9 + 64 + num2);
				goto IL_49F;
				IL_696:
				num14 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num10 + 24 + num2);
				if (num14 == -1)
				{
					goto IL_6E4;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6CA;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6CA:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6E4;
				}
				num10 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num10 + 8 + num2);
				goto IL_654;
				IL_6E4:
				num5 = num10;
				num8 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num5 + 72 + num2) + 64 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_70D:
				if (num17 != num8)
				{
					goto IL_776;
				}
				num21 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num5 + 32 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[6] = 0;
				array2[5] = array;
				array2[7] = ex3;
				array2[0] = num13;
				array2[2] = num5;
				array2[1] = 0;
				array = array2;
				num3 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num5 + 32 + num2);
				goto IL_23;
				IL_776:
				num16 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num17 + 16 + num2);
				if (num16 == -1)
				{
					goto IL_7F1;
				}
				num21 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num16 + 32 + num2);
				array2 = new object[8];
				array2[6] = 0;
				array2[5] = array;
				array2[7] = ex3;
				array2[0] = num13;
				array2[2] = num16;
				array2[3] = num5;
				array2[1] = 2;
				array = array2;
				num3 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num16 + 32 + num2);
				goto IL_23;
				IL_7F1:
				num17 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num17 + 64 + num2);
				goto IL_70D;
				IL_803:
				num21 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num10 + 88 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[6] = 0;
				array2[5] = array;
				array2[7] = ex3;
				array2[0] = num13;
				array2[2] = num10;
				array2[1] = 1;
				array = array2;
				num3 = *(ref getAutoFlushgetCurrentSize.ClassInterfaceTypeIsWindowsIdentityFlowSuppressed + num10 + 88 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_41C;
				}
				throw ex4;
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00023018 File Offset: 0x00021218
		private static void getDeploymentProviderCodebaseWindowsCodePage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 44;
			A_0 = num;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00023074 File Offset: 0x00021274
		private static void AppDomainInitializerInlineMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool gripDownL = WristMenu.gripDownL;
			A_6 = gripDownL;
			int num = ((!A_6) ? 1 : 0) * 1 + 689;
			A_0 = num;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000230D0 File Offset: 0x000212D0
		private static void DigitValuesResolveString(ref int A_0, ref int A_1, ref int A_2)
		{
			Mods.PlatformsThing(false, true);
			A_1 = 0;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000230F8 File Offset: 0x000212F8
		private static void ERRORResourceTableMappingEntryFieldId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_7 = gripDownR;
			int num = ((!A_7) ? 1 : 0) * 1 + 556;
			A_0 = num;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00023154 File Offset: 0x00021354
		private static void SetStateMachineexceptionQ(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_7 = gripDownR;
			int num = ((!A_7) ? 1 : 0) * 1 + 523;
			A_0 = num;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000231B0 File Offset: 0x000213B0
		private static void SafeSubWindowsDXNNY(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref GorillaTagManager[] A_7, ref int A_8, ref GorillaTagManager A_9, ref bool A_10)
		{
			GorillaTagManager gorillaTagManager = A_7[A_8];
			A_9 = gorillaTagManager;
			bool flag = !A_9.currentInfected.Contains(A_6);
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 445;
			A_0 = num;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00023250 File Offset: 0x00021450
		private static void TimeSpanTokenizergetHijriAdjustment(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_28 < Mods.jump_left_network.Length;
			A_29 = flag;
			int num = (A_29 ? 1 : 0) * -2 + 423;
			A_0 = num;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000232B8 File Offset: 0x000214B8
		private static void FUNCFLAGFBINDABLEGetFieldFromHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("ElfBow_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000232FC File Offset: 0x000214FC
		private static void BaseBinaryGetSingleArray(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			A_1 = 4;
			A_2 = 732;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00023324 File Offset: 0x00021524
		private static List<VRRig> getResourceSetTypeSecureStringToCoTaskMemAnsi(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			A_1 = 5;
			A_2 = 889;
			List<VRRig> result;
			return result;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0002334C File Offset: 0x0002154C
		private static void StringComparisonIMethodCallMessage(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			Text component = A_10.Find("Player Name").GetComponent<Text>();
			A_12 = component;
			Transform transform = A_10.Find("ReportButton");
			A_13 = transform;
			bool flag = A_12 != null;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 15 + 753;
			A_0 = num;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00023400 File Offset: 0x00021600
		private static void WriteMetadataKeyList(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00023418 File Offset: 0x00021618
		private static void getCertFileNotContentIndexed(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GameObject.Find("RocketShip_Prefab").transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
			GameObject.Find("RocketShip_Prefab").transform.position = new Vector3(0f, -0.0075f, 0f);
			GameObject.Find("RocketShip_Prefab").transform.position = Player.Instance.rightControllerTransform.position;
			A_1 = 0;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000234A8 File Offset: 0x000216A8
		private static void DefaultStringAsUint(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			float num = Vector3.Distance(A_20.rightHandTransform.position, A_16.position);
			A_23 = num;
			float num2 = Vector3.Distance(A_20.leftHandTransform.position, A_16.position);
			A_24 = num2;
			float num3 = 0.35f;
			A_25 = num3;
			bool flag = !A_10.Contains("Forest");
			A_26 = flag;
			bool flag2 = A_26;
			A_27 = flag2;
			int num4 = ((!A_27) ? 1 : 0) * 1 + 713;
			A_0 = num4;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000235B8 File Offset: 0x000217B8
		public static void MuteAllSS()
		{
			int num = 69;
			int num2 = 69;
			num2 = 69;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 69;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000235F0 File Offset: 0x000217F0
		private static void UrlISymbolMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color cyan = Color.cyan;
			A_4 = cyan;
			bool flag = A_5 == 7;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 121;
			A_0 = num;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00023670 File Offset: 0x00021870
		private static void MagentaIsSubclassOf(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			int num = ((!A_3) ? 1 : 0) * 1 + 873;
			A_0 = num;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x000236D4 File Offset: 0x000218D4
		private static void getIsCompatibilityBehaviorDefinedForkJoinOperationType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color blue = Color.blue;
			A_4 = blue;
			bool flag = A_5 == 10;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 1 + 152;
			A_0 = num;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00023754 File Offset: 0x00021954
		private static void getParametersetCompoundAceType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_6 = gripDownR;
			int num = ((!A_6) ? 1 : 0) * 1 + 554;
			A_0 = num;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000237B0 File Offset: 0x000219B0
		private static void getServicePackMemberTypes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("HornsSlingshotProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.magenta, false);
			A_1 = 0;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000237F4 File Offset: 0x000219F4
		private static void IsEqualOrSupersetOfProcessingConcurrentTasks(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0002380C File Offset: 0x00021A0C
		public static void Placeholder()
		{
			int num = 931;
			int num2 = 931;
			num2 = 931;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 931;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00023850 File Offset: 0x00021A50
		private static void AnonymousSidUnsafeValueTypeAttribute(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			((IDisposable)A_16).Dispose();
			A_1 = 4;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00023878 File Offset: 0x00021A78
		public static void customtext()
		{
			int num = 19;
			int num2 = 19;
			num2 = 19;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 19;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000238B0 File Offset: 0x00021AB0
		private static void getCurrencyNegativePatternIRuntimeFieldInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			GhostPatch.Prefix(GorillaTagger.Instance.offlineVRRig);
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position += new Vector3(0f, 0.07f, 0f);
			GorillaTagger.Instance.offlineVRRig.transform.Rotate(0f, 8f, 0f);
			A_0 = 39;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00023948 File Offset: 0x00021B48
		private static void DetachableGetDoubleArray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref MeshCollider[] A_5, ref int A_6, ref MeshCollider A_7, ref MeshCollider[] A_8, ref int A_9, ref MeshCollider A_10)
		{
			A_1 = 0;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00023964 File Offset: 0x00021B64
		private static void getFullTrustAssembliesStringBuilder(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			bool flag = false;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 504;
			A_0 = num;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000239C0 File Offset: 0x00021BC0
		private static void IsInvalidTimeLatencyMode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_4 = gripDownR;
			int num = ((!A_4) ? 1 : 0) * 1 + 517;
			A_0 = num;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00023A1C File Offset: 0x00021C1C
		private static string RecoverIntegerIds(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			string text = "basement";
			A_5 = text;
			A_0 = 289;
			string result;
			return result;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00023A50 File Offset: 0x00021C50
		private static void setDiscretionaryAclAtEntities(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_6 = gripDownR;
			int num = ((!A_6) ? 1 : 0) * 1 + 521;
			A_0 = num;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00023AAC File Offset: 0x00021CAC
		private static void GetRuntimeInterfaceAsIntPtrsetAssemblyName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref MeshCollider[] A_5, ref int A_6, ref MeshCollider A_7, ref MeshCollider[] A_8, ref int A_9, ref MeshCollider A_10)
		{
			bool rightControllerPrimaryButton = ControllerInputPoller.instance.rightControllerPrimaryButton;
			A_4 = rightControllerPrimaryButton;
			int num = ((!A_4) ? 1 : 0) * 4 + 735;
			A_0 = num;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00023B10 File Offset: 0x00021D10
		private static string ArrayTypeInfoDiscardBufferedData(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			PhotonNetwork.CurrentRoom.CustomProperties.TryGetValue("gameMode", out A_3);
			bool flag = A_3.ToString().Contains("forest");
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 273;
			A_0 = num;
			string result;
			return result;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00023B9C File Offset: 0x00021D9C
		private static void SafeArrayUserDefinedSubTypeHasClaims(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			string[] array = File.ReadAllLines("TemplatePrefs\\templateSavedPrefs.txt");
			A_4 = array;
			string[] array2 = A_4;
			A_5 = array2;
			int num = 0;
			A_6 = num;
			A_0 = 372;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00023C00 File Offset: 0x00021E00
		private static void SparseArrayNumDatesuff(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool flag = !Mods.upside;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 13;
			A_0 = num;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00023C64 File Offset: 0x00021E64
		private static void LocalityInternalObjectTypeE(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			A_1 = 1;
			A_2 = 217;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00023C88 File Offset: 0x00021E88
		private static void SortVersionAllFiles(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00023CA0 File Offset: 0x00021EA0
		private static void HiddenTimeSpanStyles(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			bool flag = A_6 < A_5.childCount;
			A_23 = flag;
			int num = (A_23 ? 1 : 0) * -28 + 775;
			A_0 = num;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00023D10 File Offset: 0x00021F10
		private static void getScopeNameEntryPoint(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 492;
			A_0 = num;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00023D6C File Offset: 0x00021F6C
		private static void GetEnumUnderlyingTypeSecurity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("CloudSlingshot_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_4 = gripDownR;
			int num = ((!A_4) ? 1 : 0) * 1 + 550;
			A_0 = num;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00023DF4 File Offset: 0x00021FF4
		private static void ParallelsetCalendarWeekRule(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 683;
			A_0 = num;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00023E50 File Offset: 0x00022050
		public unsafe static void Load()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 374;
			int num4 = 374;
			num4 = 374;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num19;
				int num22;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 3)
					{
						num4 = 374;
						if ((int)array[1] != 0)
						{
							num5 = (int)array[3];
							num6 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num5 + 8 + num2);
							for (num7 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + (int)array[4] + 8 + num2) + 8 + num2); num7 != num6; num7 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num7 + 8 + num2))
							{
								num8 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num7 + 32 + num2);
								if (num8 != -1)
								{
									num9 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num8 + 16 + num2);
									array[4] = num8;
									array[2] = 0;
									num3 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num8 + 16 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[7];
							num9 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num5 + 16 + num2);
							ex2 = ex;
							array = (object[])array[0];
							array2 = new object[8];
							array2[1] = 1;
							array2[0] = array;
							array2[7] = ex;
							array2[4] = num5;
							array2[2] = 2;
							array = array2;
							num3 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num5 + 16 + num2);
							continue;
						}
						num10 = (int)array[6];
						array = (object[])array[0];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 4)
						{
							string[] array3;
							string[] array4;
							int num13;
							string text;
							List<ButtonInfo>.Enumerator enumerator;
							ButtonInfo buttonInfo;
							bool flag;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.String[]&,System.String[]&,System.Int32&,System.String&,System.Collections.Generic.List`1/Enumerator<ShibaGTTemplate.UI.ButtonInfo>&,ShibaGTTemplate.UI.ButtonInfo&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref array3, ref array4, ref num13, ref text, ref enumerator, ref buttonInfo, ref flag, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 374;
						num8 = num12;
						num11 = num8;
					}
					num14 = num3;
					num6 = num14;
					num10 = 0;
					num15 = 2;
					for (;;)
					{
						num16 = (num10 + num15) / 2;
						num17 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 120 + num16 * 56 + 8 + num2);
						num18 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 120 + num16 * 56 + num2);
						if (num6 < num17 + num18)
						{
							if (num17 <= num6)
							{
								break;
							}
							num15 = num16 - 1;
						}
						else
						{
							num10 = num16 + 1;
						}
					}
					num7 = num16;
					num9 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 120 + num7 * 56 + 32 + num2);
					num19 = num9;
					num18 = num11;
					num17 = 0;
					num16 = 2;
					for (;;)
					{
						num15 = (num17 + num16) / 2;
						num10 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 120 + num15 * 56 + 8 + num2);
						num6 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 120 + num15 * 56 + num2);
						if (num18 < num10 + num6)
						{
							if (num10 <= num18)
							{
								break;
							}
							num16 = num15 - 1;
						}
						else
						{
							num17 = num15 + 1;
						}
					}
					num7 = num15;
					num8 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 120 + num7 * 56 + 32 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num15 = 2;
					for (;;)
					{
						num16 = (num10 + num15) / 2;
						num17 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 288 + num16 * 40 + 8 + num2);
						num18 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 288 + num16 * 40 + num2);
						if (num6 < num17 + num18)
						{
							if (num17 <= num6)
							{
								break;
							}
							num15 = num16 - 1;
						}
						else
						{
							num10 = num16 + 1;
						}
					}
					num7 = num16;
					num5 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 288 + num7 * 40 + 24 + num2);
					num8 = num5;
					for (;;)
					{
						IL_99E:
						if (array == null || (int)array[1] == 0)
						{
							num6 = num9;
							while (num6 != num19)
							{
								if (num6 != -1)
								{
									num6 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num6 + 8 + num2);
								}
								else
								{
									num10 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num19 + 32 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num19 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num19 + 8 + num2);
									goto IL_99E;
								}
							}
							goto IL_B35;
						}
						int num20 = (int)array[4];
						int num21;
						if (num19 == -1)
						{
							num21 = -1;
						}
						else
						{
							num22 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num19 + 16 + num2);
							num18 = 0;
							num17 = 2;
							for (;;)
							{
								num16 = (num18 + num17) / 2;
								num15 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 288 + num16 * 40 + 8 + num2);
								num10 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 288 + num16 * 40 + num2);
								if (num22 < num15 + num10)
								{
									if (num15 <= num22)
									{
										break;
									}
									num17 = num16 - 1;
								}
								else
								{
									num18 = num16 + 1;
								}
							}
							num5 = num16;
							num7 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 288 + num5 * 40 + 24 + num2);
							num21 = num7;
						}
						if (num20 == num21)
						{
							num7 = num9;
							while (num7 != num19)
							{
								if (num7 != -1)
								{
									num7 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num7 + 8 + num2);
								}
								else
								{
									num5 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num19 + 32 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num19 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num19 + 8 + num2);
									goto IL_99E;
								}
							}
							break;
						}
						if ((int)array[4] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[0];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num5 + 16 + num2);
					array2 = new object[8];
					array2[1] = 0;
					array2[0] = array;
					array2[6] = num11;
					array2[4] = num5;
					array2[2] = 0;
					array = array2;
					num3 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num5 + 16 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B35:
					num3 = num11;
					continue;
					Block_58:
					num15 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num10 + 16 + num2);
					array2 = new object[8];
					array2[1] = 0;
					array2[0] = array;
					array2[6] = num11;
					array2[4] = num10;
					array2[2] = 0;
					array = array2;
					num3 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num10 + 16 + num2);
				}
				num4 = 374;
				return;
				IL_1C8:
				if (num6 != -1)
				{
					goto IL_1D3;
				}
				goto IL_3F7;
				IL_1D3:
				num7 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num6 + num2);
				if (1 == num7)
				{
					goto IL_1EF;
				}
				if (0 == num7)
				{
					goto IL_37E;
				}
				goto IL_3F7;
				IL_1EF:
				num9 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num6 + 32 + num2);
				if (num9 == -1)
				{
					goto IL_23D;
				}
				Type[] array5;
				Type type;
				if ((type = array5[num9]) != null)
				{
					goto IL_223;
				}
				RuntimeTypeHandle[] array6;
				array5[num9] = Type.GetTypeFromHandle(array6[num9]);
				type = array5[num9];
				IL_223:
				if (type.IsInstanceOfType(array2[7]))
				{
					goto IL_23D;
				}
				num6 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num6 + 40 + num2);
				goto IL_1C8;
				IL_23D:
				num5 = num6;
				num8 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num5 + 8 + num2) + 8 + num2);
				num14 = (int)array2[5];
				IL_25F:
				if (num14 != num8)
				{
					goto IL_2DE;
				}
				int num23 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num5 + 16 + num2);
				ex2 = array2[7];
				array = (object[])array[0];
				object[] array7 = new object[8];
				array7[1] = 1;
				array7[0] = array;
				array7[7] = array2[7];
				array7[5] = (int)array2[5];
				array7[4] = num5;
				array7[2] = 2;
				array = array7;
				num3 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num5 + 16 + num2);
				goto IL_23;
				IL_2DE:
				num19 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num14 + 32 + num2);
				if (num19 == -1)
				{
					goto IL_36D;
				}
				num23 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num19 + 16 + num2);
				array = (object[])array[0];
				array7 = new object[8];
				array7[1] = 1;
				array7[0] = array;
				array7[7] = array2[7];
				array7[5] = (int)array2[5];
				array7[4] = num19;
				array7[3] = num5;
				array7[2] = 0;
				array = array7;
				num3 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num19 + 16 + num2);
				goto IL_23;
				IL_36D:
				num14 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num14 + 8 + num2);
				goto IL_25F;
				IL_37E:
				num23 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num6 + 56 + num2);
				ex2 = array2[7];
				array = (object[])array[0];
				array7 = new object[8];
				array7[1] = 1;
				array7[0] = array;
				array7[7] = array2[7];
				array7[5] = (int)array2[5];
				array7[4] = num6;
				array7[2] = 1;
				array = array7;
				num3 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num6 + 56 + num2);
				goto IL_23;
				IL_3F7:
				array = (object[])array[0];
				Exception ex3 = array2[7];
				int num24 = (int)array2[5];
				IL_416:
				num6 = num3;
				num23 = num6;
				num22 = 0;
				num10 = 2;
				IL_424:
				num15 = (num22 + num10) / 2;
				num16 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 120 + num15 * 56 + 8 + num2);
				num17 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 120 + num15 * 56 + num2);
				if (num23 >= num16 + num17)
				{
					goto IL_460;
				}
				if (num16 > num23)
				{
					goto IL_468;
				}
				num8 = num15;
				num5 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 120 + num8 * 56 + 32 + num2);
				num9 = num5;
				num14 = num9;
				goto IL_48D;
				IL_460:
				num22 = num15 + 1;
				goto IL_424;
				IL_468:
				num10 = num15 - 1;
				goto IL_424;
				IL_48D:
				if (array != null)
				{
					goto IL_498;
				}
				goto IL_61F;
				IL_498:
				if ((int)array[1] != 0)
				{
					goto IL_554;
				}
				int num25 = (int)array[4];
				if (num9 != -1)
				{
					goto IL_4BC;
				}
				int num26 = -1;
				goto IL_53B;
				IL_4BC:
				num18 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num9 + 16 + num2);
				num17 = 0;
				num16 = 2;
				IL_4CF:
				num15 = (num17 + num16) / 2;
				num10 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 288 + num15 * 40 + 8 + num2);
				num22 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 288 + num15 * 40 + num2);
				if (num18 >= num10 + num22)
				{
					goto IL_511;
				}
				if (num10 > num18)
				{
					goto IL_519;
				}
				num5 = num15;
				num8 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 288 + num5 * 40 + 24 + num2);
				num26 = num8;
				goto IL_53B;
				IL_511:
				num17 = num15 + 1;
				goto IL_4CF;
				IL_519:
				num16 = num15 - 1;
				goto IL_4CF;
				IL_53B:
				if (num25 != num26)
				{
					goto IL_543;
				}
				goto IL_61F;
				IL_543:
				array = (object[])array[0];
				goto IL_48D;
				IL_554:
				num19 = (int)array[2];
				if (num19 == 2 || num19 == 0)
				{
					goto IL_575;
				}
				if (num19 != 1)
				{
					goto IL_574;
				}
				array2 = array;
				num6 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + (int)array2[4] + 40 + num2);
				goto IL_1C8;
				IL_574:
				IL_575:
				int num27 = (int)array[4];
				if (num9 != -1)
				{
					goto IL_58A;
				}
				int num28 = -1;
				goto IL_609;
				IL_58A:
				num23 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num9 + 16 + num2);
				num22 = 0;
				num10 = 2;
				IL_59D:
				num15 = (num22 + num10) / 2;
				num16 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 288 + num15 * 40 + 8 + num2);
				num17 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 288 + num15 * 40 + num2);
				if (num23 >= num16 + num17)
				{
					goto IL_5DF;
				}
				if (num16 > num23)
				{
					goto IL_5E7;
				}
				num8 = num15;
				num5 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + 288 + num8 * 40 + 24 + num2);
				num28 = num5;
				goto IL_609;
				IL_5DF:
				num22 = num15 + 1;
				goto IL_59D;
				IL_5E7:
				num10 = num15 - 1;
				goto IL_59D;
				IL_609:
				if (num27 != num28)
				{
					goto IL_60E;
				}
				goto IL_61F;
				IL_60E:
				array = (object[])array[0];
				goto IL_48D;
				IL_61F:
				if (-1 != num9)
				{
					goto IL_62B;
				}
				int num29 = 1;
				throw ex3;
				IL_62B:
				num7 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num9 + num2);
				num10 = num7;
				IL_639:
				if (num10 != -1)
				{
					goto IL_64F;
				}
				num9 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num9 + 8 + num2);
				goto IL_48D;
				IL_64F:
				num16 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num10 + num2);
				if (1 == num16)
				{
					goto IL_676;
				}
				if (0 == num16)
				{
					goto IL_7E1;
				}
				num9 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num9 + 8 + num2);
				goto IL_48D;
				IL_676:
				num15 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num10 + 32 + num2);
				if (num15 == -1)
				{
					goto IL_6C5;
				}
				Type type2;
				if ((type2 = array5[num15]) != null)
				{
					goto IL_6AA;
				}
				array5[num15] = Type.GetTypeFromHandle(array6[num15]);
				type2 = array5[num15];
				IL_6AA:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6C5;
				}
				num10 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num10 + 40 + num2);
				goto IL_639;
				IL_6C5:
				num5 = num10;
				num8 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num5 + 8 + num2) + 8 + num2);
				num18 = (num14 - num24) * ((num24 == -1) ? 1 : 0) + num24;
				IL_6EC:
				if (num18 != num8)
				{
					goto IL_755;
				}
				num22 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num5 + 16 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[1] = 1;
				array2[0] = array;
				array2[7] = ex3;
				array2[5] = num14;
				array2[4] = num5;
				array2[2] = 2;
				array = array2;
				num3 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num5 + 16 + num2);
				goto IL_23;
				IL_755:
				num17 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num18 + 32 + num2);
				if (num17 == -1)
				{
					goto IL_7D0;
				}
				num22 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num17 + 16 + num2);
				array2 = new object[8];
				array2[1] = 1;
				array2[0] = array;
				array2[7] = ex3;
				array2[5] = num14;
				array2[4] = num17;
				array2[3] = num5;
				array2[2] = 0;
				array = array2;
				num3 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num17 + 16 + num2);
				goto IL_23;
				IL_7D0:
				num18 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num18 + 8 + num2);
				goto IL_6EC;
				IL_7E1:
				num22 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num10 + 56 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[1] = 1;
				array2[0] = array;
				array2[7] = ex3;
				array2[5] = num14;
				array2[4] = num10;
				array2[2] = 1;
				array = array2;
				num3 = *(ref TrimFlushCachedData.VARFLAGFNONBROWSABLEgetKeySpec + num10 + 56 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num29;
				if (num29 != 1)
				{
					Exception ex3 = ex4;
					int num24 = -1;
					goto IL_416;
				}
				throw ex4;
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00024A4C File Offset: 0x00022C4C
		private static void IManagedActivationFactoryETW(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_17 = gripDownR;
			int num = ((!A_17) ? 1 : 0) * 1 + 576;
			A_0 = num;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00024AA8 File Offset: 0x00022CA8
		private static List<VRRig> getDisplayNameWriteTo(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			int num = ((!A_5.isOfflineVRRig) ? 1 : 0) * 1 + 882;
			A_0 = num;
			List<VRRig> result;
			return result;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00024AF8 File Offset: 0x00022CF8
		private static void CaptureOffsetNothing(ref int A_0, ref int A_1, ref int A_2)
		{
			PlayerPrefs.SetFloat("redValue", 2.1474836E+09f);
			PlayerPrefs.SetFloat("greenValue", 2.1474836E+09f);
			PlayerPrefs.SetFloat("blueValue", 2.1474836E+09f);
			GorillaTagger.Instance.UpdateColor(-6.991475E+11f, -2.1474836E+09f, -2.1474836E+09f);
			PlayerPrefs.Save();
			GorillaTagger.Instance.myVRRig.RPC("InitializeNoobMaterial", 0, new object[]
			{
				int.MinValue,
				int.MinValue,
				int.MinValue,
				false
			});
			A_1 = 0;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00024BC8 File Offset: 0x00022DC8
		public static void ProcessTagAura()
		{
			int num = 818;
			int num2 = 818;
			num2 = 818;
			while (num2 != 0)
			{
				int num3;
				Player[] array;
				int num4;
				Player player;
				bool flag;
				float num5;
				bool flag2;
				bool flag3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,Photon.Realtime.Player[]&,System.Int32&,Photon.Realtime.Player&,System.Boolean&,System.Single&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref array, ref num4, ref player, ref flag, ref num5, ref flag2, ref flag3, Mods.ControlThreadBadData[num]);
			}
			num2 = 818;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00024C18 File Offset: 0x00022E18
		public static void ElfBowSpam()
		{
			int num = 598;
			int num2 = 598;
			num2 = 598;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 598;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00024C5C File Offset: 0x00022E5C
		private static void XUtilsFoundYMDPatternFlag(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			int num = ((!Physics.Raycast(Player.Instance.rightControllerTransform.position - Player.Instance.rightControllerTransform.up, -Player.Instance.rightControllerTransform.up, ref A_5)) ? 1 : 0) * 1 + 455;
			A_0 = num;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00024CDC File Offset: 0x00022EDC
		private static void TimeZoneInfoComparerIDisposableToIClosableAdapter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Mods.balll2 = Time.time + 1f;
			Color white = Color.white;
			A_4 = white;
			int num = Random.Range(0, 11);
			A_5 = num;
			bool flag = A_5 == 0;
			A_6 = flag;
			int num2 = ((!A_6) ? 1 : 0) * 1 + 107;
			A_0 = num2;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00024D8C File Offset: 0x00022F8C
		private static void RemoveOnLogMessageBias(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref GameObject A_5, ref GameObject A_6)
		{
			GorillaTagger.Instance.offlineVRRig.headBodyOffset = Vector3.zero;
			A_1 = 0;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00024DBC File Offset: 0x00022FBC
		private static void ApplicationNameValueBreak(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 632;
			A_0 = num;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00024E18 File Offset: 0x00023018
		private static void getSortableDateTimePatternDecoderFallbackBuffer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("LavaRockProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.magenta, false);
			A_1 = 0;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00024E5C File Offset: 0x0002305C
		private static void GetDynamicModuleCreateAggregatedObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 599;
			A_0 = num;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00024EB8 File Offset: 0x000230B8
		public static string CurrentMap
		{
			get
			{
				int num = 272;
				int num2 = 272;
				num2 = 272;
				string result;
				while (num2 != 0)
				{
					int num3;
					object obj;
					bool flag;
					string text;
					bool flag2;
					bool flag3;
					bool flag4;
					bool flag5;
					bool flag6;
					bool flag7;
					bool flag8;
					result = calli(System.String(System.Int32&,System.Int32&,System.Int32&,System.Object&,System.Boolean&,System.String&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref obj, ref flag, ref text, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref flag7, ref flag8, Mods.ControlThreadBadData[num]);
				}
				num2 = 272;
				return result;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00024F14 File Offset: 0x00023114
		public static void DrawGun()
		{
			int num = 691;
			int num2 = 691;
			num2 = 691;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				RaycastHit raycastHit;
				bool flag2;
				bool flag3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.RaycastHit&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref raycastHit, ref flag2, ref flag3, Mods.ControlThreadBadData[num]);
			}
			num2 = 691;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00024F60 File Offset: 0x00023160
		private static void IFormattablesetCurrencyGroupSeparator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (Mods.once_right_false ? 1 : 0) * 1 + 398;
			A_0 = num;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00024FA4 File Offset: 0x000231A4
		private static void MessageDictionaryGetSessionIdForMethodMessage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref bool A_7, ref PhotonView A_8)
		{
			A_1 = 0;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00024FBC File Offset: 0x000231BC
		public unsafe static void ModderTracers()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 205;
			int num4 = 205;
			num4 = 205;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 5)
					{
						num4 = 205;
						if ((int)array[7] != 1)
						{
							num5 = (int)array[4];
							num6 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num5 + 72 + num2);
							for (num7 = *(ref RemoveAuditgetCopyright.wCodeFileObject + *(ref RemoveAuditgetCopyright.wCodeFileObject + (int)array[6] + 72 + num2) + 80 + num2); num7 != num6; num7 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num7 + 80 + num2))
							{
								num8 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num7 + 64 + num2);
								if (num8 != -1)
								{
									num9 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num8 + 8 + num2);
									array[6] = num8;
									array[0] = 2;
									num3 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num8 + 8 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[1];
							num9 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num5 + 8 + num2);
							ex2 = ex;
							array = (object[])array[2];
							array2 = new object[]
							{
								null,
								null,
								null,
								null,
								null,
								null,
								null,
								0
							};
							array2[2] = array;
							array2[1] = ex;
							array2[6] = num5;
							array2[0] = 1;
							array = array2;
							num3 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num5 + 8 + num2);
							continue;
						}
						num10 = (int)array[5];
						array = (object[])array[2];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 1)
						{
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							bool flag2;
							bool flag3;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&,System.Boolean&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref enumerator, ref vrrig, ref flag, ref flag2, ref flag3, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 205;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 168 + num15 * 80 + 72 + num2);
						num17 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 168 + num15 * 80 + 24 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 168 + num7 * 80 + 56 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 168 + num14 * 80 + 72 + num2);
						num6 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 168 + num14 * 80 + 24 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 168 + num7 * 80 + 56 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 408 + num15 * 48 + 40 + num2);
						num17 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 408 + num15 * 48 + 16 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 408 + num7 * 48 + 32 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9C8:
						if (array == null || (int)array[7] == 1)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num6 + 80 + num2);
								}
								else
								{
									num10 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num18 + 64 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num18 + 80 + num2);
									goto IL_9C8;
								}
							}
							goto IL_B63;
						}
						int num19 = (int)array[6];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num18 + 8 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 408 + num15 * 48 + 40 + num2);
								num10 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 408 + num15 * 48 + 16 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 408 + num5 * 48 + 32 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num7 + 80 + num2);
								}
								else
								{
									num5 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num18 + 64 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num18 + 80 + num2);
									goto IL_9C8;
								}
							}
							break;
						}
						if ((int)array[6] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[2];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num5 + 8 + num2);
					array2 = new object[]
					{
						null,
						null,
						null,
						null,
						null,
						null,
						null,
						1
					};
					array2[2] = array;
					array2[5] = num11;
					array2[6] = num5;
					array2[0] = 2;
					array = array2;
					num3 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num5 + 8 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B63:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num10 + 8 + num2);
					array2 = new object[]
					{
						null,
						null,
						null,
						null,
						null,
						null,
						null,
						1
					};
					array2[2] = array;
					array2[5] = num11;
					array2[6] = num10;
					array2[0] = 2;
					array = array2;
					num3 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num10 + 8 + num2);
				}
				num4 = 205;
				return;
				IL_1C4:
				if (num6 != -1)
				{
					goto IL_1CF;
				}
				goto IL_3EF;
				IL_1CF:
				num7 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num6 + 24 + num2);
				if (4 == num7)
				{
					goto IL_1EE;
				}
				if (1 == num7)
				{
					goto IL_37C;
				}
				goto IL_3EF;
				IL_1EE:
				num9 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num6 + 56 + num2);
				if (num9 == -1)
				{
					goto IL_23C;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_222;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_222:
				if (type.IsInstanceOfType(array2[1]))
				{
					goto IL_23C;
				}
				num6 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num6 + 16 + num2);
				goto IL_1C4;
				IL_23C:
				num5 = num6;
				num8 = *(ref RemoveAuditgetCopyright.wCodeFileObject + *(ref RemoveAuditgetCopyright.wCodeFileObject + num5 + 72 + num2) + 80 + num2);
				num13 = (int)array2[3];
				IL_260:
				if (num13 != num8)
				{
					goto IL_2DD;
				}
				int num22 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num5 + 8 + num2);
				ex2 = array2[1];
				array = (object[])array[2];
				object[] array5 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array5[2] = array;
				array5[1] = array2[1];
				array5[3] = (int)array2[3];
				array5[6] = num5;
				array5[0] = 1;
				array = array5;
				num3 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num5 + 8 + num2);
				goto IL_23;
				IL_2DD:
				num18 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num13 + 64 + num2);
				if (num18 == -1)
				{
					goto IL_36A;
				}
				num22 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num18 + 8 + num2);
				array = (object[])array[2];
				array5 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array5[2] = array;
				array5[1] = array2[1];
				array5[3] = (int)array2[3];
				array5[6] = num18;
				array5[4] = num5;
				array5[0] = 2;
				array = array5;
				num3 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num18 + 8 + num2);
				goto IL_23;
				IL_36A:
				num13 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num13 + 80 + num2);
				goto IL_260;
				IL_37C:
				num22 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num6 + num2);
				ex2 = array2[1];
				array = (object[])array[2];
				array5 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array5[2] = array;
				array5[1] = array2[1];
				array5[3] = (int)array2[3];
				array5[6] = num6;
				array5[0] = 0;
				array = array5;
				num3 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num6 + num2);
				goto IL_23;
				IL_3EF:
				array = (object[])array[2];
				Exception ex3 = array2[1];
				int num23 = (int)array2[3];
				IL_40E:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_41C:
				num14 = (num21 + num10) / 2;
				num15 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 168 + num14 * 80 + 72 + num2);
				num16 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 168 + num14 * 80 + 24 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_462;
				}
				if (num15 > num22)
				{
					goto IL_46A;
				}
				num8 = num14;
				num5 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 168 + num8 * 80 + 56 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_492;
				IL_462:
				num21 = num14 + 1;
				goto IL_41C;
				IL_46A:
				num10 = num14 - 1;
				goto IL_41C;
				IL_492:
				if (array != null)
				{
					goto IL_49D;
				}
				goto IL_62A;
				IL_49D:
				if ((int)array[7] != 1)
				{
					goto IL_55C;
				}
				int num24 = (int)array[6];
				if (num9 != -1)
				{
					goto IL_4C1;
				}
				int num25 = -1;
				goto IL_543;
				IL_4C1:
				num17 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num9 + 8 + num2);
				num16 = 0;
				num15 = 2;
				IL_4D3:
				num14 = (num16 + num15) / 2;
				num10 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 408 + num14 * 48 + 40 + num2);
				num21 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 408 + num14 * 48 + 16 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_519;
				}
				if (num10 > num17)
				{
					goto IL_521;
				}
				num5 = num14;
				num8 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 408 + num5 * 48 + 32 + num2);
				num25 = num8;
				goto IL_543;
				IL_519:
				num16 = num14 + 1;
				goto IL_4D3;
				IL_521:
				num15 = num14 - 1;
				goto IL_4D3;
				IL_543:
				if (num24 != num25)
				{
					goto IL_54B;
				}
				goto IL_62A;
				IL_54B:
				array = (object[])array[2];
				goto IL_492;
				IL_55C:
				num18 = (int)array[0];
				if (num18 == 1 || num18 == 2)
				{
					goto IL_57D;
				}
				if (num18 != 0)
				{
					goto IL_57C;
				}
				array2 = array;
				num6 = *(ref RemoveAuditgetCopyright.wCodeFileObject + (int)array2[6] + 16 + num2);
				goto IL_1C4;
				IL_57C:
				IL_57D:
				int num26 = (int)array[6];
				if (num9 != -1)
				{
					goto IL_592;
				}
				int num27 = -1;
				goto IL_614;
				IL_592:
				num22 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num9 + 8 + num2);
				num21 = 0;
				num10 = 2;
				IL_5A4:
				num14 = (num21 + num10) / 2;
				num15 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 408 + num14 * 48 + 40 + num2);
				num16 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 408 + num14 * 48 + 16 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5EA;
				}
				if (num15 > num22)
				{
					goto IL_5F2;
				}
				num8 = num14;
				num5 = *(ref RemoveAuditgetCopyright.wCodeFileObject + 408 + num8 * 48 + 32 + num2);
				num27 = num5;
				goto IL_614;
				IL_5EA:
				num21 = num14 + 1;
				goto IL_5A4;
				IL_5F2:
				num10 = num14 - 1;
				goto IL_5A4;
				IL_614:
				if (num26 != num27)
				{
					goto IL_619;
				}
				goto IL_62A;
				IL_619:
				array = (object[])array[2];
				goto IL_492;
				IL_62A:
				if (-1 != num9)
				{
					goto IL_636;
				}
				int num28 = 1;
				throw ex3;
				IL_636:
				num7 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num9 + 32 + num2);
				num10 = num7;
				IL_647:
				if (num10 != -1)
				{
					goto IL_65E;
				}
				num9 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num9 + 80 + num2);
				goto IL_492;
				IL_65E:
				num15 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num10 + 24 + num2);
				if (4 == num15)
				{
					goto IL_689;
				}
				if (1 == num15)
				{
					goto IL_7F3;
				}
				num9 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num9 + 80 + num2);
				goto IL_492;
				IL_689:
				num14 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num10 + 56 + num2);
				if (num14 == -1)
				{
					goto IL_6D8;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6BD;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6BD:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6D8;
				}
				num10 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num10 + 16 + num2);
				goto IL_647;
				IL_6D8:
				num5 = num10;
				num8 = *(ref RemoveAuditgetCopyright.wCodeFileObject + *(ref RemoveAuditgetCopyright.wCodeFileObject + num5 + 72 + num2) + 80 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_701:
				if (num17 != num8)
				{
					goto IL_768;
				}
				num21 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num5 + 8 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array2[2] = array;
				array2[1] = ex3;
				array2[3] = num13;
				array2[6] = num5;
				array2[0] = 1;
				array = array2;
				num3 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num5 + 8 + num2);
				goto IL_23;
				IL_768:
				num16 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num17 + 64 + num2);
				if (num16 == -1)
				{
					goto IL_7E1;
				}
				num21 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num16 + 8 + num2);
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array2[2] = array;
				array2[1] = ex3;
				array2[3] = num13;
				array2[6] = num16;
				array2[4] = num5;
				array2[0] = 2;
				array = array2;
				num3 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num16 + 8 + num2);
				goto IL_23;
				IL_7E1:
				num17 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num17 + 80 + num2);
				goto IL_701;
				IL_7F3:
				num21 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num10 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array2[2] = array;
				array2[1] = ex3;
				array2[3] = num13;
				array2[6] = num10;
				array2[0] = 0;
				array = array2;
				num3 = *(ref RemoveAuditgetCopyright.wCodeFileObject + num10 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_40E;
				}
				throw ex4;
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00025BE4 File Offset: 0x00023DE4
		private static void PermissionSetEnumeratorInternalOidKeyType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			int num = (GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("blue") ? 1 : 0) * 3 + 915;
			A_0 = num;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00025C44 File Offset: 0x00023E44
		private static void GetRangesMuiMapping(ref int A_0, ref int A_1, ref int A_2, ref Vector2 A_3, ref double A_4)
		{
			double time = PhotonNetwork.Time;
			A_4 = time;
			ScienceExperimentManager.instance.photonView.RPC("SpawnSodaBubbleRPC", 0, new object[]
			{
				A_3,
				float.MinValue,
				9999f,
				A_4
			});
			A_1 = 0;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00025CE4 File Offset: 0x00023EE4
		public static void HeadUpside()
		{
			int num = 12;
			int num2 = 12;
			num2 = 12;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 12;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00025D1C File Offset: 0x00023F1C
		private static void MetadataSectionSchemaVersionNoDefineVersionResource(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("SlingshotProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00025D60 File Offset: 0x00023F60
		private static void getIsApplicationTrustedToRunGetMethodBase(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00025D78 File Offset: 0x00023F78
		public static void NotificationTest()
		{
			int num = 700;
			int num2 = 700;
			num2 = 700;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 700;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00025DBC File Offset: 0x00023FBC
		private static void CompareIEnumSTOREASSEMBLYINSTALLATIONREFERENCE(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_4 = gripDownR;
			int num = ((!A_4) ? 1 : 0) * 1 + 685;
			A_0 = num;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00025E18 File Offset: 0x00024018
		private static void getLanguageAssemblyReferenceFlags(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00025E30 File Offset: 0x00024030
		private static void NtlmAuthenticationSidGetDynamicSink(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			((IDisposable)A_5).Dispose();
			A_1 = 3;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00025E58 File Offset: 0x00024058
		private static void FAggregatablegetIsStopped(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref PhotonView A_7, ref VRRig A_8, ref bool A_9, ref GameObject A_10)
		{
			int num = ((A_5 < A_4.Length) ? 1 : 0) * -7 + 241;
			A_0 = num;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00025E94 File Offset: 0x00024094
		private static void getIsGenericTypeDefinitionFaultCode(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref MethodInfo A_6, ref object A_7)
		{
			Player player = A_3[A_4];
			A_5 = player;
			MethodInfo method = typeof(PhotonNetwork).GetMethod("SendDestroyOfPlayer", BindingFlags.Static | BindingFlags.NonPublic);
			A_6 = method;
			object obj = A_6.Invoke(typeof(PhotonNetwork), new object[]
			{
				A_5.ActorNumber
			});
			A_7 = obj;
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -2 + 293;
			A_0 = num2;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00025F90 File Offset: 0x00024190
		private static void getSkipSizeTickCount(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Mods.balll2 = Time.time + 0.08f;
			Color white = Color.white;
			A_4 = white;
			int num = Random.Range(0, 11);
			A_5 = num;
			bool flag = A_5 == 0;
			A_6 = flag;
			int num2 = ((!A_6) ? 1 : 0) * 1 + 132;
			A_0 = num2;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00026040 File Offset: 0x00024240
		private static void setSaltGetFieldToken(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color magenta = Color.magenta;
			A_4 = magenta;
			bool flag = A_5 == 6;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 94;
			A_0 = num;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000260C0 File Offset: 0x000242C0
		private static void HashInProcessHandler(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_9.enabled = new bool?(true);
			int num = (A_8.MoveNext() ? 1 : 0) * -4 + 381;
			A_0 = num;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00026120 File Offset: 0x00024320
		private static void setEventHandleIncludeInstalled(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 656;
			A_0 = num;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0002617C File Offset: 0x0002437C
		public static void anticrash()
		{
			int num = 204;
			int num2 = 204;
			num2 = 204;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 204;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000261C0 File Offset: 0x000243C0
		private static void FromIntPtrUnknownWrapper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_left_local.transform.localScale = Mods.scale;
			Mods.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			Mods.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			Mods.once_left = true;
			Mods.once_left_false = false;
			ColorChanger colorChanger = Mods.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = Mods.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 416;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00026374 File Offset: 0x00024574
		private static void TimeSpanResultSavePolicyLevel(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			A_1 = 0;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0002638C File Offset: 0x0002458C
		private static void AppendPrivatePathWindowObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000263A4 File Offset: 0x000245A4
		private static void setPercentDecimalDigitsEnumAssemblyFilesFlags(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			A_1 = 5;
			A_2 = 794;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000263C8 File Offset: 0x000245C8
		private static void ResolveROAsmEventReflectionOnly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref GorillaTagManager[] A_7, ref int A_8, ref GorillaTagManager A_9, ref bool A_10)
		{
			Player player = A_4[A_5];
			A_6 = player;
			GorillaTagManager[] array = Object.FindObjectsOfType<GorillaTagManager>();
			A_7 = array;
			int num = 0;
			A_8 = num;
			A_0 = 447;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00026434 File Offset: 0x00024634
		private static void getGlobalResourceContextBestFitCultureInfoPublicOnly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_7 = A_30;
			int num = ((!A_7) ? 1 : 0) * 1 + 391;
			A_0 = num;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00026490 File Offset: 0x00024690
		private static string getAssemblyEvidenceArgsInline(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			string text = "forest";
			A_5 = text;
			A_0 = 289;
			string result;
			return result;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000264C4 File Offset: 0x000246C4
		private static void DirectoryExistsAttributeTargets(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			Mods.pointer.transform.position = A_4.point;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 252;
			A_0 = num;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00026548 File Offset: 0x00024748
		private static void TicksPerSecondNS(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref bool A_6, ref float A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = !GorillaGameManager.instance.FindPlayerVRRig(A_5).mainSkin.material.name.Contains("fected");
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 822;
			A_0 = num;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000265D4 File Offset: 0x000247D4
		private static void UIntegerFLicensed(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			GorillaFriendCollider[] array = Object.FindObjectsOfType<GorillaFriendCollider>();
			A_8 = array;
			int num = 0;
			A_9 = num;
			A_0 = 461;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0002661C File Offset: 0x0002481C
		private static void BitConverterNoSet(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("WaterBalloonProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_11 = gripDownR;
			int num = ((!A_11) ? 1 : 0) * 1 + 531;
			A_0 = num;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000266A4 File Offset: 0x000248A4
		public static void RainbowSnowballs()
		{
			int num = 266;
			int num2 = 266;
			num2 = 266;
			while (num2 != 0)
			{
				int num3;
				SnowballThrowable[] array;
				int num4;
				SnowballThrowable snowballThrowable;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,SnowballThrowable[]&,System.Int32&,SnowballThrowable&,System.Boolean&), ref num, ref num2, ref num3, ref array, ref num4, ref snowballThrowable, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 266;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000266F0 File Offset: 0x000248F0
		private static void WrapNonExceptionThrowsSupportsLastError(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00026708 File Offset: 0x00024908
		private static void CCMPWCDECLsetNumberNegativePattern(ref int A_0, ref int A_1, ref int A_2)
		{
			Mods.CleanActorAndRPCBuffers(GorillaTagger.Instance.myVRRig);
			A_1 = 0;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00026730 File Offset: 0x00024930
		private static void IsolatedStoragePermissionMuiMapping(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color blue = Color.blue;
			A_4 = blue;
			bool flag = A_5 == 10;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 1 + 127;
			A_0 = num;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000267B0 File Offset: 0x000249B0
		private static string setEventHandlegetArgumentCount(ref int A_0, ref int A_1, ref int A_2, ref string A_3, ref int A_4, ref bool A_5, ref bool A_6, ref string A_7)
		{
			bool flag = A_4 < 7;
			A_5 = flag;
			int num = (A_5 ? 1 : 0) * -2 + 859;
			A_0 = num;
			string result;
			return result;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0002681C File Offset: 0x00024A1C
		public static void LavaRockSpamSS()
		{
			int num = 655;
			int num2 = 655;
			num2 = 655;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 655;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00026860 File Offset: 0x00024A60
		private static void MobilePhoneUseDllDirectoryForDependencies(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			Material material = new Material(Shader.Find("GUI/Text Shader"));
			A_4 = material;
			Material material2 = new Material(Shader.Find("GUI/Text Shader"));
			A_5 = material2;
			A_4.color = Color.red;
			A_5.color = Color.green;
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_6 = enumerator;
			A_0 = 219;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00026904 File Offset: 0x00024B04
		public static void NoTagOnJoin()
		{
			int num = 79;
			int num2 = 79;
			num2 = 79;
			while (num2 != 0)
			{
				int num3;
				Hashtable hashtable;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ExitGames.Client.Photon.Hashtable&), ref num, ref num2, ref num3, ref hashtable, Mods.ControlThreadBadData[num]);
			}
			num2 = 79;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0002693C File Offset: 0x00024B3C
		private static void TypeNameKindRelaxedSignature(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("LavaRockProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_12 = gripDownR;
			int num = ((!A_12) ? 1 : 0) * 1 + 566;
			A_0 = num;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000269C4 File Offset: 0x00024BC4
		private static void IsolatedStorageSecurityOptionsIClientFormatterSink(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000269DC File Offset: 0x00024BDC
		private static void getRuleSetCaseInsensitiveHashCodeProvider(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			int num = -1;
			A_4 = num;
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_5 = enumerator;
			A_0 = 783;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00026A30 File Offset: 0x00024C30
		private static void AddArgumentsReleaseApplicationPath(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref bool A_7, ref PhotonView A_8)
		{
			A_1 = 0;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00026A48 File Offset: 0x00024C48
		private static void getMDStreamVersionGacIdentityPermission(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00026A60 File Offset: 0x00024C60
		private static void GetLowerBoundBinaryObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			Object.Destroy(GorillaGameManager.instance.FindPlayerVRRig(A_6).mainSkin.gameObject.GetComponent<ColorChanger>());
			int num = A_5 + 1;
			A_5 = num;
			int num2 = ((A_5 < A_4.Length) ? 1 : 0) * -17 + 910;
			A_0 = num2;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00026AE8 File Offset: 0x00024CE8
		private static void GuaranteeSizegetChannelData(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref bool A_6, ref float A_7, ref bool A_8, ref bool A_9)
		{
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -8 + 827;
			A_0 = num2;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00026B48 File Offset: 0x00024D48
		private static void StatusLevelgetExceptionType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Mods.balll2 = Time.time + 10f;
			Color white = Color.white;
			A_4 = white;
			int num = Random.Range(0, 11);
			A_5 = num;
			bool flag = A_5 == 0;
			A_6 = flag;
			int num2 = ((!A_6) ? 1 : 0) * 1 + 82;
			A_0 = num2;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00026BF8 File Offset: 0x00024DF8
		private static void IStoreInteractiveSid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", 0, new object[]
			{
				GorillaTagger.Instance.leftHandTransform.position,
				GorillaTagger.Instance.leftHandTransform.rotation,
				4f,
				100f,
				true,
				false
			});
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 317;
			A_0 = num;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00026D04 File Offset: 0x00024F04
		private static void DefaultDllImportSearchPathsAttributeBatchSid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref string A_4)
		{
			A_1 = 0;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00026D1C File Offset: 0x00024F1C
		private static void MetadataImportProcessorArchitectureIA(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			Object.Destroy(Mods.pointer, Time.deltaTime);
			A_1 = 0;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00026D48 File Offset: 0x00024F48
		private static void CRMDictionaryLPUTFStr(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 9;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 100;
			A_0 = num;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00026DB0 File Offset: 0x00024FB0
		private static void CryptoConfigIReadOnlyDictionary(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 10;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 1 + 127;
			A_0 = num;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00026E18 File Offset: 0x00025018
		private static void SleepThreadAbort(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			Directory.CreateDirectory("TemplatePrefs");
			File.WriteAllLines("TemplatePrefs\\templateSavedPrefs.txt", A_4);
			A_1 = 0;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00026E50 File Offset: 0x00025050
		public static void MoltenRockSpam()
		{
			int num = 607;
			int num2 = 607;
			num2 = 607;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 607;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00026E94 File Offset: 0x00025094
		private static void LdftnUsagePatterns(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("SpiderBow_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.magenta, false);
			A_1 = 0;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00026ED8 File Offset: 0x000250D8
		private static void DefineFieldReferenceMatchesDefinition(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Color A_4, ref bool A_5, ref string A_6, ref List<ButtonInfo>.Enumerator A_7, ref ButtonInfo A_8, ref bool A_9)
		{
			int num = (A_7.MoveNext() ? 1 : 0) * -4 + 852;
			A_0 = num;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00026F20 File Offset: 0x00025120
		public static void TPGun()
		{
			int num = 478;
			int num2 = 478;
			num2 = 478;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				RaycastHit raycastHit;
				bool flag2;
				bool flag3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.RaycastHit&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref raycastHit, ref flag2, ref flag3, Mods.ControlThreadBadData[num]);
			}
			num2 = 478;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00026F6C File Offset: 0x0002516C
		private static void EncoderReplacementFallbackIsStopped(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref GameObject A_5, ref GameObject A_6)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			A_1 = 0;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00026F9C File Offset: 0x0002519C
		private static void getAuditRuleTypegetCurrentState(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5)
		{
			int num = ((A_4 < A_3.Length) ? 1 : 0) * -2 + 813;
			A_0 = num;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00026FD8 File Offset: 0x000251D8
		private static void BinaryTrackInfoRemoveAudit(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			bool flag = Mods.smth496 < Time.time;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 13 + 913;
			A_0 = num;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0002703C File Offset: 0x0002523C
		public static void spawnssbubles()
		{
			int num = 304;
			int num2 = 304;
			num2 = 304;
			while (num2 != 0)
			{
				int num3;
				Vector2 vector;
				double num4;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,UnityEngine.Vector2&,System.Double&), ref num, ref num2, ref num3, ref vector, ref num4, Mods.ControlThreadBadData[num]);
			}
			num2 = 304;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00027084 File Offset: 0x00025284
		private static void BoxedGray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 674;
			A_0 = num;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000270E0 File Offset: 0x000252E0
		private static void getAceTypeGetTypeLibVersionForAssembly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 605;
			A_0 = num;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0002713C File Offset: 0x0002533C
		private static void FUNCFLAGFNONBROWSABLEAnsiCharMarshaler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			A_1 = 0;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00027154 File Offset: 0x00025354
		private static void EraTokenGetHRForException(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = (A_8.MoveNext() ? 1 : 0) * -4 + 369;
			A_0 = num;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0002719C File Offset: 0x0002539C
		private static void CATEGORYSUBCATEGORYAssemblyIsolationByMachine(ref int A_0, ref int A_1, ref int A_2)
		{
			Process.Start("https://discord.gg/nexustar");
			A_1 = 0;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000271C0 File Offset: 0x000253C0
		private static void TokenAccessInformationWebName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("MoltenSlingshot_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_13 = gripDownR;
			int num = ((!A_13) ? 1 : 0) * 1 + 535;
			A_0 = num;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00027248 File Offset: 0x00025448
		private static void getObjectTypeEventWaitHandleSecurity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(Mods.jump_left_network[A_28]);
			int num = A_28 + 1;
			A_28 = num;
			bool flag = A_28 < Mods.jump_left_network.Length;
			A_29 = flag;
			int num2 = (A_29 ? 1 : 0) * -2 + 423;
			A_0 = num2;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000272E8 File Offset: 0x000254E8
		private static void PermitOnlySetInstanceRequestedExecutionLevel(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			bool flag = Mods.pointer == null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 457;
			A_0 = num;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00027350 File Offset: 0x00025550
		private static void UnhandledExceptionEventHandlerProgIdAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00027368 File Offset: 0x00025568
		public static void CustomRgb()
		{
			int num = 105;
			int num2 = 105;
			num2 = 105;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Color color;
				int num4;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				bool flag7;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				bool flag12;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.Color&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref color, ref num4, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref flag7, ref flag8, ref flag9, ref flag10, ref flag11, ref flag12, Mods.ControlThreadBadData[num]);
			}
			num2 = 105;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000273BC File Offset: 0x000255BC
		private static void ServerWellKnownEntrySearchOption(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			int num = A_6 + 1;
			A_6 = num;
			bool flag = A_6 < A_5.childCount;
			A_23 = flag;
			int num2 = (A_23 ? 1 : 0) * -28 + 775;
			A_0 = num2;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0002744C File Offset: 0x0002564C
		private static void ProxyIsPrivate(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			((IDisposable)A_5).Dispose();
			A_1 = 4;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00027474 File Offset: 0x00025674
		private static void CurrentConfigDefineSequencePoints(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = Mods.balll2 < Time.time;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 23 + 131;
			A_0 = num;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000274D8 File Offset: 0x000256D8
		private static void setHostCanGenerateGetStream(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000274F0 File Offset: 0x000256F0
		private static void SignatureTokenCultureName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.colorKeysPlatformMonke[1].color = Color.black;
			Mods.colorKeysPlatformMonke[1].time = 2f;
			Mods.colorKeysPlatformMonke[1].color = Color.magenta;
			Mods.colorKeysPlatformMonke[1].time = 1.1f;
			Mods.colorKeysPlatformMonke[2].color = Color.black;
			Mods.colorKeysPlatformMonke[1].time = 3f;
			Mods.colorKeysPlatformMonke[3].color = Color.magenta;
			Mods.colorKeysPlatformMonke[3].time = 1f;
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			bool gripDownL = WristMenu.gripDownL;
			A_4 = gripDownL;
			bool flag = A_3;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 10 + 387;
			A_0 = num;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00027644 File Offset: 0x00025844
		private static void ElementCountKeyEventRecord(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = Mods.jump_left_local == null;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 405;
			A_0 = num;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000276AC File Offset: 0x000258AC
		private static void EnterprisePolicyLevelPopi(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			Mods.BetaFireProjectileDelay("SnowballProjectile", Player.Instance.leftControllerTransform.position, Vector3.forward, Color.magenta, false);
			A_1 = 0;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000276F0 File Offset: 0x000258F0
		private static void GetThisPtrFOleAutomation(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_19 = enumerator;
			A_0 = 710;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0002772C File Offset: 0x0002592C
		private static void getIsReadOnlyByteArrayTypeInfo(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 228;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00027744 File Offset: 0x00025944
		private static void DeleteFileClaims(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			A_1 = 0;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0002775C File Offset: 0x0002595C
		private static void EnableJITcompileTrackinggetPrimaryIdentitySelector(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.back = false;
			RigShit.GetOwnVRRig().head.trackingRotationOffset.y = 0f;
			A_1 = 0;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00027798 File Offset: 0x00025998
		private static void GetCurrentThreadIdSetRaiseMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 8;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 123;
			A_0 = num;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00027800 File Offset: 0x00025A00
		private static void HostProtectionAttributeIsRightToLeft(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("WaterBalloonProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.magenta, false);
			A_1 = 0;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00027844 File Offset: 0x00025A44
		private static void IUnknownTypeDef(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -6 + 62;
			A_0 = num;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0002788C File Offset: 0x00025A8C
		public static void EnableFallDecorationsCS()
		{
			int num = 498;
			int num2 = 498;
			num2 = 498;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 498;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000278D0 File Offset: 0x00025AD0
		private static void FromTicksXMLSnippet(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (Mods.once_left_false ? 1 : 0) * 1 + 413;
			A_0 = num;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00027914 File Offset: 0x00025B14
		private static void WingetMajorVersion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0002792C File Offset: 0x00025B2C
		private static void BitConvertergetRoot(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_12 = gripDownR;
			int num = ((!A_12) ? 1 : 0) * 1 + 533;
			A_0 = num;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00027988 File Offset: 0x00025B88
		private static void RegisterForFullGCNotificationgetKeyName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref MeshCollider[] A_4, ref int A_5, ref MeshCollider A_6, ref MeshCollider[] A_7, ref int A_8, ref MeshCollider A_9)
		{
			MeshCollider[] array = Resources.FindObjectsOfTypeAll<MeshCollider>();
			A_4 = array;
			int num = 0;
			A_5 = num;
			A_0 = 161;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000279D0 File Offset: 0x00025BD0
		private static void AddAccessRuleDNd(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			A_1 = 0;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000279E8 File Offset: 0x00025BE8
		private static void IMethodCallMessageRemotingConfigHandler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00027A00 File Offset: 0x00025C00
		private static void UnrestrictedIsolatedStorageILease(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref PhotonView A_7, ref VRRig A_8, ref bool A_9, ref GameObject A_10)
		{
			int num = A_5 + 1;
			A_5 = num;
			int num2 = ((A_5 < A_4.Length) ? 1 : 0) * -7 + 241;
			A_0 = num2;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00027A60 File Offset: 0x00025C60
		private static void OnlyReferenceRegisteredSerializableAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			bool flag = Mods.pointer != null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 696;
			A_0 = num;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00027AC4 File Offset: 0x00025CC4
		private static void setAsDateComponentGuaranteesAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			A_0 = 781;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00027AF4 File Offset: 0x00025CF4
		private static void OSXGetGenericParamProps(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = false;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 4 + 223;
			A_0 = num;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00027B50 File Offset: 0x00025D50
		private static void InternalTaskOptionsImplementedInterfaces(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			A_7.mainSkin.material = A_5;
			int num = (A_6.MoveNext() ? 1 : 0) * -9 + 229;
			A_0 = num;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00027BB8 File Offset: 0x00025DB8
		private static void InstanceCountContinueParsing(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color magenta = Color.magenta;
			A_4 = magenta;
			bool flag = A_5 == 6;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 144;
			A_0 = num;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00027C38 File Offset: 0x00025E38
		private static void MscorlibDictionaryDebugViewManifestBuilder(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00027C50 File Offset: 0x00025E50
		private static void EntryPointRemoveEtwSession(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_17 = gripDownR;
			int num = ((!A_17) ? 1 : 0) * 1 + 543;
			A_0 = num;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00027CAC File Offset: 0x00025EAC
		private static void AccessControlSectionsgetExitCode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00027CC4 File Offset: 0x00025EC4
		private static void getCanTimeoutServerCallback(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref MeshCollider[] A_5, ref int A_6, ref MeshCollider A_7, ref MeshCollider[] A_8, ref int A_9, ref MeshCollider A_10)
		{
			A_1 = 0;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00027CDC File Offset: 0x00025EDC
		private static void setPositionStringToBSTR(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00027CF4 File Offset: 0x00025EF4
		private static void AllocateBufferFreeListEmptyMarkAborted(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color cyan = Color.cyan;
			A_4 = cyan;
			bool flag = A_5 == 7;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 96;
			A_0 = num;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00027D74 File Offset: 0x00025F74
		private static void LockParamTypes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			Physics.Raycast(Player.Instance.rightControllerTransform.position, -Player.Instance.rightControllerTransform.up, ref A_4);
			Mods.pointer = GameObject.CreatePrimitive(0);
			Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			Mods.pointer.GetComponent<Renderer>().material.color = new Color32(byte.MaxValue, 0, 0, 1);
			Mods.pointer.transform.position = A_4.point;
			Object.Destroy(Mods.pointer.GetComponent<BoxCollider>());
			Object.Destroy(Mods.pointer.GetComponent<Rigidbody>());
			Object.Destroy(Mods.pointer.GetComponent<Collider>());
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat >= 0.3f;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 693;
			A_0 = num;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00027EC4 File Offset: 0x000260C4
		private static void GetMethodBodyBrowserForward(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			VRRig vrrig = A_16.Current;
			A_17 = vrrig;
			bool flag = A_17 != GorillaTagger.Instance.offlineVRRig;
			A_18 = flag;
			int num = ((!A_18) ? 1 : 0) * 5 + 757;
			A_0 = num;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00027F50 File Offset: 0x00026150
		private static void StelemgetTimeOfDay(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			bool flag = !A_14;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 511;
			A_0 = num;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00027FB8 File Offset: 0x000261B8
		private static void EnumRunninggetLoaderOptimization(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			bool flag = GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("orange");
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 838;
			A_0 = num;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0002803C File Offset: 0x0002623C
		private static void CategoryMembershipDataDescriptionService(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			A_1 = 0;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00028054 File Offset: 0x00026254
		private static void getObjectUriAssemblyIsolationByMachine(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			SlingshotProjectile slingshotProjectile = A_6[A_7];
			A_8 = slingshotProjectile;
			bool flag = A_8.projectileOwner == PhotonNetwork.LocalPlayer;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 922;
			A_0 = num;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000280E4 File Offset: 0x000262E4
		private static void SerializationMissingKeysResourceTypeIdStringSize(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			int num = A_9 + 1;
			A_9 = num;
			bool flag = A_9 < A_7.childCount;
			A_22 = flag;
			int num2 = (A_22 ? 1 : 0) * -21 + 772;
			A_0 = num2;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00028178 File Offset: 0x00026378
		private static void getMillisecondFromSeconds(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_left_local = GameObject.CreatePrimitive(0);
			A_0 = 408;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000281A0 File Offset: 0x000263A0
		private static void TotalSecondsPriority(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 626;
			A_0 = num;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000281FC File Offset: 0x000263FC
		private static void AttributeUsageAttributePermitOnly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool flag = Mods.roll;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 4;
			A_0 = num;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00028258 File Offset: 0x00026458
		private static void setClipboardDeploymentMetadataMinimumRequiredVersion(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_1 = 0;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00028270 File Offset: 0x00026470
		private static void AccountDomainUsersSidgetObjectType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref MeshCollider[] A_5, ref int A_6, ref MeshCollider A_7, ref MeshCollider[] A_8, ref int A_9, ref MeshCollider A_10)
		{
			Player.Instance.transform.position = new Vector3(-66.4848f, 11.8871f, -82.6619f);
			A_0 = 743;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000282AC File Offset: 0x000264AC
		private static void FromStringClientChannelSinkStack(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_4 = enumerator;
			A_0 = 206;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000282E8 File Offset: 0x000264E8
		private static void EnableEditAndContinueDenyOnlySid(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			bool flag = A_12.text == PhotonNetwork.LocalPlayer.NickName.ToUpper();
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 13 + 754;
			A_0 = num;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00028364 File Offset: 0x00026564
		public static void HeadRoll()
		{
			int num = 2;
			int num2 = 2;
			num2 = 2;
			while (num2 != 0)
			{
				int num3;
				VRMap vrmap;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,VRMap&), ref num, ref num2, ref num3, ref vrmap, Mods.ControlThreadBadData[num]);
			}
			num2 = 2;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00028398 File Offset: 0x00026598
		private static void PrefixrefgetCompletedSynchronously(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 136;
			A_0 = num;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00028400 File Offset: 0x00026600
		private static void EndContractBlockAttachedToParent(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("Player Objects/Local VRRig/Local Gorilla Player/rig/body/WinterJan2023 Body/LBACP.").SetActive(true);
			A_1 = 0;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00028430 File Offset: 0x00026630
		private static void PrivilegeNameCreateAggregatedObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			string text = A_10 + "\n====================================\n";
			A_10 = text;
			File.AppendAllText("Nexu_Star_PlayerID.txt", A_10);
			Mods.pointer.GetComponent<Renderer>().material.color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1);
			A_0 = 807;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000284B4 File Offset: 0x000266B4
		private static void JapaneseEraTokenFileSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("CupidBow_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_8 = gripDownR;
			int num = ((!A_8) ? 1 : 0) * 1 + 525;
			A_0 = num;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0002853C File Offset: 0x0002673C
		private static void BgtSGetDisplayName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00028554 File Offset: 0x00026754
		private static void OptionalAttributeTimeSpanToken(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			A_1 = 0;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0002856C File Offset: 0x0002676C
		private static void reservedFullTrustAssemblies(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -4 + 271;
			A_0 = num2;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000285CC File Offset: 0x000267CC
		private static void EndDocumentSchedulerPair(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref bool A_6, ref float A_7, ref bool A_8, ref bool A_9)
		{
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -8 + 827;
			A_0 = num2;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0002862C File Offset: 0x0002682C
		public static void UpRopes()
		{
			int num = 176;
			int num2 = 176;
			num2 = 176;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Object[] array;
				int num4;
				PhotonView photonView;
				string text;
				RpcTarget rpcTarget;
				object[] array2;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.Object[]&,System.Int32&,Photon.Pun.PhotonView&,System.String&,Photon.Pun.RpcTarget&,System.Object[]&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref array, ref num4, ref photonView, ref text, ref rpcTarget, ref array2, ref flag2, Mods.ControlThreadBadData[num]);
			}
			num2 = 176;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00028680 File Offset: 0x00026880
		private static void GetRuntimeTypeHandleFromMetadataTokenS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("BucketGiftCoal", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000286C4 File Offset: 0x000268C4
		private static void ObjectDisposedExceptionIsPunctuation(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref PhotonView A_7, ref VRRig A_8, ref bool A_9, ref GameObject A_10)
		{
			A_1 = 0;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000286DC File Offset: 0x000268DC
		private static void UTFElementCount(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5)
		{
			A_1 = 0;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000286F4 File Offset: 0x000268F4
		private static void getCurrencyEnglishNameCustomAttributeBuilder(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetwork.JoinRandomRoom();
			A_1 = 0;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00028714 File Offset: 0x00026914
		private static void getHeadersUntrusted(ref int A_0, ref int A_1, ref int A_2, ref Material A_3)
		{
			Material material = new Material(Shader.Find("Standard"));
			A_3 = material;
			A_3.color = Color.black;
			GameObject.Find("CodeOfConduct").GetComponent<Text>().text = "<color=red>MODDING INFO</color>";
			GameObject.Find("COC Text").GetComponent<Text>().text = "<color=green>D = DETECTED, D? = MAYBE DETECTED, CS = CLIENT SIDED, SS = SERVER SIDED, M = MASTER, LM = LEGIT MASTER. </color>";
			GameObject.Find("motd").GetComponent<Text>().text = "<color=white>TY FOR USING NEXU STAR</color>";
			GameObject.Find("motdtext").GetComponent<Text>().text = "<color=red>WHEN U USE A MOD IF THE TEXT IS RED IT MEANS THE MOD IS DETECTED IF THE TEXT IS YELLOW IT MEANS ITS A LIT OF BIT DETECTED AND IF ITS JUST NORMAL COLORS ITS UNDETECTED!</color>";
			GameObject.Find("motdscreen").GetComponent<Renderer>().material.color = Color.magenta;
			A_1 = 0;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000287EC File Offset: 0x000269EC
		private static void ChangeAclsetTarget(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position += new Vector3(0f, 0.07f, 0f);
			GorillaTagger.Instance.offlineVRRig.transform.Rotate(0f, 8f, 0f);
			A_0 = 39;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00028874 File Offset: 0x00026A74
		private static string UIPermissionWindowsetPerMilleSymbol(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			string text = "beach";
			A_5 = text;
			A_0 = 289;
			string result;
			return result;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000288A8 File Offset: 0x00026AA8
		private static void EventItfInfoCLRIReferenceImpl(ref int A_0, ref int A_1, ref int A_2, ref ScienceExperimentManager.PlayerGameState[] A_3, ref int A_4, ref bool A_5)
		{
			bool flag = A_4 < 10;
			A_5 = flag;
			int num = (A_5 ? 1 : 0) * -2 + 301;
			A_0 = num;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00028910 File Offset: 0x00026B10
		private static void getThreeLetterISOLanguageNameExit(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("CupidBow_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.magenta, false);
			A_1 = 0;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00028954 File Offset: 0x00026B54
		private static void IsSubclassOfICompatibleFrameworksMetadataEntry(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			bool flag = A_6 < A_5.childCount;
			A_31 = flag;
			int num = (A_31 ? 1 : 0) * -27 + 730;
			A_0 = num;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000289C4 File Offset: 0x00026BC4
		private static void SetSynchronizationContextTYPELIBATTR(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000289DC File Offset: 0x00026BDC
		private static void CustomAttributeCtorParameterCallConvWinapi(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			((IDisposable)A_8).Dispose();
			A_1 = 3;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00028A04 File Offset: 0x00026C04
		private static void InlineTokDuplicate(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			A_1 = 4;
			A_2 = 64;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00028A28 File Offset: 0x00026C28
		private static void BeginStelemI(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			SnowballThrowable snowballThrowable = A_3[A_4];
			A_5 = snowballThrowable;
			bool flag = !A_5.randomizeColor;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 262;
			A_0 = num;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00028AB8 File Offset: 0x00026CB8
		private static void STOREASSEMBLYSTATUSFLAGSStoreOperationStageComponentFile(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			bool flag = false;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 511;
			A_0 = num;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00028B14 File Offset: 0x00026D14
		private static void DeconstructGetTypeInfoType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 4;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 90;
			A_0 = num;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00028B7C File Offset: 0x00026D7C
		private static void IEnumConnectionsDiscardBufferedData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1);
			A_0 = 255;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00028BC8 File Offset: 0x00026DC8
		private static void getApplyToMembersEncodeHexString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			string text = "IDs Of The Player";
			A_10 = text;
			Player[] playerList = PhotonNetwork.PlayerList;
			A_11 = playerList;
			int num = 0;
			A_12 = num;
			A_0 = 803;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00028C24 File Offset: 0x00026E24
		private static void UIPermissionClipboardEuropeanNumberTerminator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("BucketGiftCane", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_14 = gripDownR;
			int num = ((!A_14) ? 1 : 0) * 1 + 537;
			A_0 = num;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00028CAC File Offset: 0x00026EAC
		public static void FuckComputer()
		{
			int num = 875;
			int num2 = 875;
			num2 = 875;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 875;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00028CF0 File Offset: 0x00026EF0
		private static void ReturnsetFilterLevel(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 548;
			A_0 = num;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00028D4C File Offset: 0x00026F4C
		private static void CreateKeyExchangeUtcNow(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00028D64 File Offset: 0x00026F64
		private static void UserPolicyLevelParagraphSeparator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			A_1 = 0;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00028D94 File Offset: 0x00026F94
		public static void OFFHideNameonleaderborde()
		{
			int num = 866;
			int num2 = 866;
			num2 = 866;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 866;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00028DD8 File Offset: 0x00026FD8
		private static void GetEntryAssemblyForceLibrarySemantics(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_1 = 4;
			A_2 = 383;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00028DFC File Offset: 0x00026FFC
		public static void LavaRockSpam()
		{
			int num = 604;
			int num2 = 604;
			num2 = 604;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 604;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00028E40 File Offset: 0x00027040
		private static void GetRuntimePropertiesPeek(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			GorillaTagger.Instance.offlineVRRig.transform.position = Vector3.zero;
			Object.Destroy(Mods.pointer);
			A_1 = 0;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00028E94 File Offset: 0x00027094
		private static void ProcessingConcurrentTasksMaxSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color black = Color.black;
			A_4 = black;
			bool flag = A_5 == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 134;
			A_0 = num;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00028F14 File Offset: 0x00027114
		private static void AceEnumeratorCLAIMSECURITYATTRIBUTEINFORMATIONV(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 138;
			A_0 = num;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00028F7C File Offset: 0x0002717C
		private static void GetFormatRequiredContract(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			ButtonInfo buttonInfo = A_8.Current;
			A_9 = buttonInfo;
			bool flag = A_9.buttonText == A_7;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 366;
			A_0 = num;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0002900C File Offset: 0x0002720C
		public static void JoinDiscord()
		{
			int num = 294;
			int num2 = 294;
			num2 = 294;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 294;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00029050 File Offset: 0x00027250
		public static void Ghostmonke()
		{
			int num = 256;
			int num2 = 256;
			num2 = 256;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				GameObject gameObject;
				GameObject gameObject2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,UnityEngine.GameObject&,UnityEngine.GameObject&), ref num, ref num2, ref num3, ref flag, ref flag2, ref gameObject, ref gameObject2, Mods.ControlThreadBadData[num]);
			}
			num2 = 256;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0002909C File Offset: 0x0002729C
		private static void AddSentinelChannelUris(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("SlingshotProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_5 = gripDownR;
			int num = ((!A_5) ? 1 : 0) * 1 + 552;
			A_0 = num;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00029124 File Offset: 0x00027324
		private static void ContainedInManifestFilecoreNewLine(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			A_1 = 4;
			A_2 = 732;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00029148 File Offset: 0x00027348
		private static void AsSeasongetChannelSinkChain(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			int num = (A_6.MoveNext() ? 1 : 0) * -9 + 229;
			A_0 = num;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00029190 File Offset: 0x00027390
		private static string setAppDomainManagerTypeMuiResourceTypeIdIntIntegerIds(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			string text = "canyon";
			A_5 = text;
			A_0 = 289;
			string result;
			return result;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000291C4 File Offset: 0x000273C4
		private static void RefreshedCreateMessageSink(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			int num = ((!Physics.Raycast(Player.Instance.rightControllerTransform.position - Player.Instance.rightControllerTransform.up, -Player.Instance.rightControllerTransform.up, ref A_5)) ? 1 : 0) * 1 + 430;
			A_0 = num;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00029244 File Offset: 0x00027444
		private static void AssemblyRequestSectionIProgress(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			bool flag = false;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 919;
			A_0 = num;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000292A4 File Offset: 0x000274A4
		private static string getIsMarshalByRefAutoLayout(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			string result = A_5;
			A_1 = 0;
			return result;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000292C4 File Offset: 0x000274C4
		private static void RsaKeyExchangegetConfiguredGuid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref GameObject A_5, ref GameObject A_6)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_5 = gameObject;
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.GetComponent<Renderer>().material.color = new Color32(219, 219, 0, 1);
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_6 = gameObject2;
			Object.Destroy(A_6.GetComponent<Rigidbody>());
			Object.Destroy(A_6.GetComponent<SphereCollider>());
			A_6.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_6.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_6.GetComponent<Renderer>().material.color = new Color32(219, 219, 0, 1);
			Object.Destroy(A_5, Time.deltaTime);
			Object.Destroy(A_6, Time.deltaTime);
			A_0 = 259;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000294A4 File Offset: 0x000276A4
		private static void TextWriterGCHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			int num = ((!A_4.mainSkin.material.name.Contains("bluealive")) ? 1 : 0) * 1 + 916;
			A_0 = num;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00029504 File Offset: 0x00027704
		private static void GetMemberIChannel(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			A_1 = 0;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0002951C File Offset: 0x0002771C
		public static void CupidArrowSpamSS()
		{
			int num = 643;
			int num2 = 643;
			num2 = 643;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 643;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00029560 File Offset: 0x00027760
		private static void AssemblyRequestEntryISerializationSurrogate(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			A_1 = 3;
			A_2 = 843;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00029584 File Offset: 0x00027784
		private static void GetCreationTimeStackCrawlMarkHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			Mods.kowfjwefwjnef = true;
			A_1 = 0;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000295A8 File Offset: 0x000277A8
		private static void ThrowOnUnmappableCharUseAssemMemberAccess(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			A_0 = 440;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000295DC File Offset: 0x000277DC
		private static void BlockSizeValueMachineKeyStore(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GameObject.Find("Floating Bat Holdable").transform.position = Player.Instance.rightControllerTransform.position;
			A_1 = 0;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0002961C File Offset: 0x0002781C
		public static void HideNameonleaderbored()
		{
			int num = 863;
			int num2 = 863;
			num2 = 863;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				string text;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.String&), ref num, ref num2, ref num3, ref flag, ref text, Mods.ControlThreadBadData[num]);
			}
			num2 = 863;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00029664 File Offset: 0x00027864
		private static void BufferedStreamgetIsSingleByte(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			int num = ((!Physics.Raycast(Player.Instance.rightControllerTransform.position - Player.Instance.rightControllerTransform.up, -Player.Instance.rightControllerTransform.up, ref A_5)) ? 1 : 0) * 1 + 797;
			A_0 = num;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000296E4 File Offset: 0x000278E4
		private static void AtEntitiesAddClaim(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			GorillaFriendCollider gorillaFriendCollider = A_8[A_9];
			A_10 = gorillaFriendCollider;
			A_5.collider.GetComponent<GorillaComputer>().OnGroupJoinButtonPress(Random.RandomRange(1, 3), A_10);
			int num = A_9 + 1;
			A_9 = num;
			int num2 = ((A_9 < A_8.Length) ? 1 : 0) * -2 + 462;
			A_0 = num2;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00029794 File Offset: 0x00027994
		private static void ClauseBindToField(ref int A_0, ref int A_1, ref int A_2, ref PhotonView A_3, ref GorillaNot A_4)
		{
			PhotonView photonView = new PhotonView();
			A_3 = photonView;
			GorillaNot gorillaNot = new GorillaNot();
			A_4 = gorillaNot;
			A_4.rpcErrorMax = 940949;
			Object.Destroy(A_3.gameObject);
			Object.Destroy(A_3.gameObject);
			Object.Destroy(A_3.gameObject);
			Object.Destroy(A_3.gameObject);
			Object.Destroy(A_3.gameObject);
			Object.Destroy(A_3.gameObject);
			Object.Destroy(A_3.gameObject);
			Object.Destroy(A_3);
			Object.Destroy(A_3);
			Object.Destroy(A_3);
			Object.Destroy(A_3);
			Object.Destroy(A_3);
			Object.Destroy(A_3);
			A_3.gameObject.SetActive(false);
			A_1 = 0;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000298EC File Offset: 0x00027AEC
		private static void ErrorReportUrlOutOfMemoryException(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			int num = A_6 + 1;
			A_6 = num;
			bool flag = A_6 < A_5.childCount;
			A_31 = flag;
			int num2 = (A_31 ? 1 : 0) * -27 + 730;
			A_0 = num2;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00029980 File Offset: 0x00027B80
		private static void INormalizeForIsolatedStoragegetCallSiteActivationAttributes(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			int num = (A_16.MoveNext() ? 1 : 0) * -8 + 764;
			A_0 = num;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000299C8 File Offset: 0x00027BC8
		private static void OriginalExceptionTokenUser(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			A_1 = 0;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x000299E0 File Offset: 0x00027BE0
		public static void SquareSpamSS()
		{
			int num = 673;
			int num2 = 673;
			num2 = 673;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 673;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00029A24 File Offset: 0x00027C24
		private static void getUnmappedIdentitiesPacket(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5)
		{
			Player[] playerList = PhotonNetwork.PlayerList;
			A_3 = playerList;
			int num = 0;
			A_4 = num;
			A_0 = 812;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00029A6C File Offset: 0x00027C6C
		private static void StateManagerRunningStateNullReferenceExceptionOnAV(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GorillaRopeSwing[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0.4f;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 4 + 326;
			A_0 = num;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00029AD8 File Offset: 0x00027CD8
		private static void opBitwiseAndgetRevisionVersion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref GorillaTagManager[] A_7, ref int A_8, ref GorillaTagManager A_9, ref bool A_10)
		{
			int num = ((A_5 < A_4.Length) ? 1 : 0) * -7 + 450;
			A_0 = num;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00029B14 File Offset: 0x00027D14
		private static void setTypeInfoEndContractBlock(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color yellow = Color.yellow;
			A_4 = yellow;
			bool flag = A_5 == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 88;
			A_0 = num;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00029B94 File Offset: 0x00027D94
		private static void NoteChangeTimeCMSSECTIONIDSTRINGSECTION(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			int num = ((!Physics.Raycast(Player.Instance.rightControllerTransform.position - Player.Instance.rightControllerTransform.up, -Player.Instance.rightControllerTransform.up, ref A_4)) ? 1 : 0) * 1 + 248;
			A_0 = num;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00029C14 File Offset: 0x00027E14
		private static void AttributeCountMaximumSize(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("Player Objects/Local VRRig/Local Gorilla Player/rig/body/WinterJan2023 Body/LBACP.").SetActive(false);
			A_1 = 0;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00029C44 File Offset: 0x00027E44
		public static void ChangeColor3()
		{
			int num = 23;
			int num2 = 23;
			num2 = 23;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 23;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00029C7C File Offset: 0x00027E7C
		private static string HashElementDigestValueGetTypeKind(ref int A_0, ref int A_1, ref int A_2, ref string A_3, ref int A_4, ref bool A_5, ref bool A_6, ref string A_7)
		{
			bool flag = GorillaComputer.instance.CheckAutoBanListForName(A_3);
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 860;
			A_0 = num;
			string result;
			return result;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00029CEC File Offset: 0x00027EEC
		private static void MinusOneCMSUSAGEPATTERNSCOPEMASK(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5)
		{
			Player[] playerListOthers = PhotonNetwork.PlayerListOthers;
			A_3 = playerListOthers;
			int num = 0;
			A_4 = num;
			A_0 = 929;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00029D34 File Offset: 0x00027F34
		private static void getKeyNameRecordFixup(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color clear = Color.clear;
			A_4 = clear;
			bool flag = A_5 == 9;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 100;
			A_0 = num;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00029DB4 File Offset: 0x00027FB4
		private static void SendManifestStat(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = Mods.balll2 < Time.time;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 23 + 106;
			A_0 = num;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00029E18 File Offset: 0x00028018
		private static void EnableEditAndContinueExactBinding(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_1 = 0;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00029E30 File Offset: 0x00028030
		public static void SpazRopes()
		{
			int num = 168;
			int num2 = 168;
			num2 = 168;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Object[] array;
				int num4;
				PhotonView photonView;
				string text;
				RpcTarget rpcTarget;
				object[] array2;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.Object[]&,System.Int32&,Photon.Pun.PhotonView&,System.String&,Photon.Pun.RpcTarget&,System.Object[]&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref array, ref num4, ref photonView, ref text, ref rpcTarget, ref array2, ref flag2, Mods.ControlThreadBadData[num]);
			}
			num2 = 168;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00029E84 File Offset: 0x00028084
		public static void JoinRandomPublic()
		{
			int num = 33;
			int num2 = 33;
			num2 = 33;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 33;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00029EBC File Offset: 0x000280BC
		private static void CheckedOneWayDomainIsolationByMachine(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref GameObject A_5, ref GameObject A_6)
		{
			GorillaTagger.Instance.offlineVRRig.headBodyOffset = new Vector3(999f, 999f, 999f);
			GameObject gameObject = GameObject.CreatePrimitive(0);
			A_5 = gameObject;
			Object.Destroy(A_5.GetComponent<Rigidbody>());
			Object.Destroy(A_5.GetComponent<SphereCollider>());
			A_5.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_5.transform.position = GorillaTagger.Instance.rightHandTransform.position;
			A_5.GetComponent<Renderer>().material.color = new Color32(219, 219, 0, 1);
			GameObject gameObject2 = GameObject.CreatePrimitive(0);
			A_6 = gameObject2;
			Object.Destroy(A_6.GetComponent<Rigidbody>());
			Object.Destroy(A_6.GetComponent<SphereCollider>());
			A_6.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
			A_6.transform.position = GorillaTagger.Instance.leftHandTransform.position;
			A_6.GetComponent<Renderer>().material.color = new Color32(219, 219, 0, 1);
			Object.Destroy(A_5, Time.deltaTime);
			Object.Destroy(A_6, Time.deltaTime);
			A_0 = 334;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0002A0AC File Offset: 0x000282AC
		private static void FailedAssemblyInfoRegister(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref GorillaTagManager[] A_7, ref int A_8, ref GorillaTagManager A_9, ref bool A_10)
		{
			int num = ((A_8 < A_7.Length) ? 1 : 0) * -4 + 448;
			A_0 = num;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0002A0E8 File Offset: 0x000282E8
		private static void PausedSegmentSeparator(ref int A_0, ref int A_1, ref int A_2)
		{
			WristMenu.FirstColor = Color.red;
			WristMenu.SecondColor = Color.blue;
			A_1 = 0;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0002A114 File Offset: 0x00028314
		private static void UnknownTokenRootHidden(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 593;
			A_0 = num;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0002A170 File Offset: 0x00028370
		private static void IsolatedStorageExceptionAutoFlush(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			A_1 = 0;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0002A188 File Offset: 0x00028388
		private static void KeyGenerationFlagsToShortTimeString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref GameObject A_5, ref GameObject A_6)
		{
			A_1 = 0;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0002A1A0 File Offset: 0x000283A0
		public static void StickPlatforms()
		{
			int num = 469;
			int num2 = 469;
			num2 = 469;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 469;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0002A1E4 File Offset: 0x000283E4
		public static void DownRopes()
		{
			int num = 184;
			int num2 = 184;
			num2 = 184;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Object[] array;
				int num4;
				PhotonView photonView;
				string text;
				RpcTarget rpcTarget;
				object[] array2;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.Object[]&,System.Int32&,Photon.Pun.PhotonView&,System.String&,Photon.Pun.RpcTarget&,System.Object[]&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref array, ref num4, ref photonView, ref text, ref rpcTarget, ref array2, ref flag2, Mods.ControlThreadBadData[num]);
			}
			num2 = 184;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0002A238 File Offset: 0x00028438
		private static void OriginalExceptionGetDayOfWeek(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref GorillaTagManager[] A_7, ref int A_8, ref GorillaTagManager A_9, ref bool A_10)
		{
			A_1 = 0;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0002A250 File Offset: 0x00028450
		public static void playeridgun()
		{
			int num = 795;
			int num2 = 795;
			num2 = 795;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				RaycastHit raycastHit;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				string text;
				Player[] array;
				int num4;
				Player player;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,UnityEngine.RaycastHit&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.String&,Photon.Realtime.Player[]&,System.Int32&,Photon.Realtime.Player&), ref num, ref num2, ref num3, ref flag, ref flag2, ref raycastHit, ref flag3, ref flag4, ref flag5, ref flag6, ref text, ref array, ref num4, ref player, Mods.ControlThreadBadData[num]);
			}
			num2 = 795;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0002A2A8 File Offset: 0x000284A8
		private static void YearEndToString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			bool flag = true;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 919;
			A_0 = num;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0002A304 File Offset: 0x00028504
		private static void NestedFamANDAssemREQUIRED(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			bool flag = A_3;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 10 + 454;
			A_0 = num;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0002A384 File Offset: 0x00028584
		private static void EnumConnectionPointssetUI(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool enabled = GorillaTagger.Instance.offlineVRRig.enabled;
			A_4 = enabled;
			int num = ((!A_4) ? 1 : 0) * 1 + 36;
			A_0 = num;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0002A3EC File Offset: 0x000285EC
		private static void getTargetTypeNameGetDynamicILInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 8;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 148;
			A_0 = num;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0002A454 File Offset: 0x00028654
		private static void getManagedThreadIdIsAutoClass(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			WristMenu.settingsbuttons[1].enabled = new bool?(false);
			WristMenu.DestroyMenu();
			WristMenu.instance.Draw();
			List<string> list = new List<string>();
			A_4 = list;
			List<ButtonInfo>.Enumerator enumerator = WristMenu.settingsbuttons.GetEnumerator();
			A_5 = enumerator;
			A_0 = 345;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0002A4D0 File Offset: 0x000286D0
		private static void getProviderTypeMEMBERIDNIL(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			bool flag = A_7 is string;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 11 + 896;
			A_0 = num;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0002A53C File Offset: 0x0002873C
		private static void DispIdAttributeGetTerrestrialBranch(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref GorillaTagManager[] A_7, ref int A_8, ref GorillaTagManager A_9, ref bool A_10)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position = GorillaGameManager.instance.FindPlayerVRRig(A_6).transform.position;
			Player.Instance.rightControllerTransform.position = GorillaGameManager.instance.FindPlayerVRRig(A_6).transform.position;
			int num = A_8 + 1;
			A_8 = num;
			int num2 = ((A_8 < A_7.Length) ? 1 : 0) * -4 + 448;
			A_0 = num2;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0002A610 File Offset: 0x00028810
		public static void CloudSpamSS()
		{
			int num = 631;
			int num2 = 631;
			num2 = 631;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 631;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0002A654 File Offset: 0x00028854
		private static void IsNegativeInfinitySiteIdentityPermissionAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("WaterBalloonProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0002A698 File Offset: 0x00028898
		private static void ToIntPtrCheckLevel(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0002A6B0 File Offset: 0x000288B0
		private static void getAssemblyFullNamesetParamTypes(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			((IDisposable)A_5).Dispose();
			A_1 = 3;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0002A6D8 File Offset: 0x000288D8
		private static void RegionInfoSafeProvHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, Color A_4)
		{
			GorillaTagger.Instance.myVRRig.RPC("InitializeNoobMaterial", 0, new object[]
			{
				A_4.r,
				A_4.g,
				A_4.b,
				false
			});
			A_1 = 0;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0002A768 File Offset: 0x00028968
		private static void SafeLibraryHandleQueue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool flag = !Mods.back;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 7;
			A_0 = num;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0002A7CC File Offset: 0x000289CC
		private static void TSIRemotingFormatter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 617;
			A_0 = num;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0002A828 File Offset: 0x00028A28
		private static void RuntimeConstructorInfoAddPathList(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			float num = 0.2f;
			A_25 = num;
			int num2 = (((A_23 < A_25) * true) ? 1 : 0) + 715;
			A_0 = num2;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0002A87C File Offset: 0x00028A7C
		private static void CreatePartialActivationContextCdecl(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			VRRig vrrig = A_5.Current;
			A_6 = vrrig;
			int num = (((Vector3.Distance(A_6.transform.position, RigShit.GetOwnVRRig().transform.position) > 9f) * true) ? 1 : 0) + 57;
			A_0 = num;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0002A8EC File Offset: 0x00028AEC
		public static void headrolloff()
		{
			int num = 3;
			int num2 = 3;
			num2 = 3;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 3;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0002A920 File Offset: 0x00028B20
		private static void IndexerNameAttributegetMaxCapacity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7)
		{
			A_1 = 0;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0002A938 File Offset: 0x00028B38
		private static void SetOpaqueInstallerReference(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 88;
			A_0 = num;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0002A9A0 File Offset: 0x00028BA0
		private static void DateTimeFormatWinCE(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 644;
			A_0 = num;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0002A9FC File Offset: 0x00028BFC
		private static void FileSystemRightsGetRootSection(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 677;
			A_0 = num;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0002AA58 File Offset: 0x00028C58
		private static void RevertPermitOnlyEnumIntTypeInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.funn.SetActive(true);
			Mods.funn = null;
			A_1 = 0;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0002AA88 File Offset: 0x00028C88
		private static void getLatencyModeGetMethodToken(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			bool flag = A_5 < A_4.Length;
			A_10 = flag;
			int num = (A_10 ? 1 : 0) * -2 + 182;
			A_0 = num;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0002AAF4 File Offset: 0x00028CF4
		private static void IManagedActivationFactoryGetPathRoot(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0002AB0C File Offset: 0x00028D0C
		private static void MoveDateTimeConstantAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("SpiderBow_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.green, false);
			A_1 = 0;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0002AB50 File Offset: 0x00028D50
		private static void CreateSignatureAssemblyNameProxy(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			bool activeSelf = A_7.gameObject.activeSelf;
			A_8 = activeSelf;
			int num = ((!A_8) ? 1 : 0) * 23 + 750;
			A_0 = num;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0002ABC0 File Offset: 0x00028DC0
		private static void IsTypeSpecgetAceQualifier(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			Mods.colorKeysPlatformMonke9[0].color = Color.black;
			Mods.colorKeysPlatformMonke9[0].time = 0f;
			Mods.colorKeysPlatformMonke9[1].color = Color.magenta;
			Mods.colorKeysPlatformMonke9[1].time = 0.5f;
			Mods.colorKeysPlatformMonke9[2].color = Color.black;
			Mods.colorKeysPlatformMonke9[2].time = 1f;
			Mods.colorKeysPlatformMonke2[0].color = Color.magenta;
			Mods.colorKeysPlatformMonke2[0].time = 0f;
			Mods.colorKeysPlatformMonke2[1].color = Color.black;
			Mods.colorKeysPlatformMonke2[1].time = 0.5f;
			Mods.colorKeysPlatformMonke2[2].color = Color.magenta;
			Mods.colorKeysPlatformMonke2[2].time = 1f;
			Player[] playerListOthers = PhotonNetwork.PlayerListOthers;
			A_4 = playerListOthers;
			int num = 0;
			A_5 = num;
			A_0 = 909;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0002AD34 File Offset: 0x00028F34
		private static void UrtSystemgetReturnXmlElementName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", 0, new object[]
			{
				GorillaTagger.Instance.rightHandTransform.position,
				GorillaTagger.Instance.rightHandTransform.rotation,
				4f,
				100f,
				true,
				false
			});
			A_1 = 0;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0002ADEC File Offset: 0x00028FEC
		private static void GetServerContextSinkgetFlags(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_right_local.transform.localScale = Mods.scale;
			Mods.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			Mods.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			Mods.once_right = true;
			Mods.once_right_false = false;
			ColorChanger colorChanger = Mods.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = Mods.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 401;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0002AFA0 File Offset: 0x000291A0
		private static List<VRRig> setViewAndModifygetMode(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			List<VRRig> result = A_7;
			A_1 = 0;
			return result;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0002AFC0 File Offset: 0x000291C0
		private static void GetDaylightChangesToLocalTime(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			VRRig vrrig = A_4.Current;
			A_5 = vrrig;
			bool flag = RigShit.GetPlayerFromRig(A_5).CustomProperties.ContainsKey("mods");
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 5 + 208;
			A_0 = num;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0002B050 File Offset: 0x00029250
		private static void setSelfAffectingProcessMgmtsetOutputEncoding(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			PhotonNetwork.RemoveRPCs(PhotonNetwork.LocalPlayer);
			PhotonNetwork.OpCleanActorRpcBuffer(PhotonNetwork.LocalPlayer.ActorNumber);
			PhotonNetwork.RemoveRPCs(GorillaTagger.Instance.myVRRig);
			PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
			GorillaNot.instance.rpcCallLimit = int.MaxValue;
			bool flag = GorillaTagger.Instance.myVRRig != null;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 244;
			A_0 = num;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0002B10C File Offset: 0x0002930C
		public static void AntiBan()
		{
			int num = 25;
			int num2 = 25;
			num2 = 25;
			while (num2 != 0)
			{
				int num3;
				ExecuteCloudScriptRequest executeCloudScriptRequest;
				Hashtable hashtable;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,PlayFab.ClientModels.ExecuteCloudScriptRequest&,ExitGames.Client.Photon.Hashtable&), ref num, ref num2, ref num3, ref executeCloudScriptRequest, ref hashtable, Mods.ControlThreadBadData[num]);
			}
			num2 = 25;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0002B148 File Offset: 0x00029348
		private static void NullTextWriterDefaultPort(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0002B160 File Offset: 0x00029360
		private static void ICDFIsInitOnly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(Mods.jump_right_local);
			Mods.jump_right_local = null;
			Mods.once_right = false;
			Mods.once_right_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_14 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(72, null, A_14, SendOptions.SendReliable);
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 402;
			A_0 = num;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0002B224 File Offset: 0x00029424
		private static void FreeBSTRNotOnRanToCompletion(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_16 = enumerator;
			A_0 = 755;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0002B260 File Offset: 0x00029460
		public static void quitgame()
		{
			int num = 876;
			int num2 = 876;
			num2 = 876;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 876;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0002B2A4 File Offset: 0x000294A4
		public static void Rgb()
		{
			int num = 80;
			int num2 = 80;
			num2 = 80;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Color color;
				int num4;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				bool flag7;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				bool flag12;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.Color&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref color, ref num4, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref flag7, ref flag8, ref flag9, ref flag10, ref flag11, ref flag12, Mods.ControlThreadBadData[num]);
			}
			num2 = 80;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0002B2F8 File Offset: 0x000294F8
		private static void SynchronizationAttributeUnsafeNativeMethods(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			A_1 = 0;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0002B310 File Offset: 0x00029510
		private static void EvidenceBaseLdindU(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			bool flag = Time.time > Mods.projDebounce;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 5 + 508;
			A_0 = num;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0002B374 File Offset: 0x00029574
		private static void FReplaceableInternetCache(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("BucketGiftCane", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.magenta, false);
			A_1 = 0;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0002B3B8 File Offset: 0x000295B8
		private static void setTitleaddReflectionOnlyNamespaceResolve(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			VRRig vrrig = A_19.Current;
			A_20 = vrrig;
			bool flag = A_20 != GorillaTagger.Instance.offlineVRRig;
			A_21 = flag;
			bool flag2 = A_21;
			A_22 = flag2;
			int num = ((!A_22) ? 1 : 0) * 7 + 712;
			A_0 = num;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0002B45C File Offset: 0x0002965C
		private static void CustomAttributeBuildergetUserMessage(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			int num = (A_16.MoveNext() ? 1 : 0) * -8 + 764;
			A_0 = num;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0002B4A4 File Offset: 0x000296A4
		private static void CheckNameStloc(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0002B4BC File Offset: 0x000296BC
		private static void UriGetStringBuilder(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			int num = ((!A_6.mainSkin.material.name.Contains("bluealive")) ? 1 : 0) * 1 + 835;
			A_0 = num;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0002B51C File Offset: 0x0002971C
		private static void ISoapMessageInterlocked(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7)
		{
			Object.Destroy(Mods.pointer);
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			GorillaTagger.Instance.offlineVRRig.transform.position = Vector3.zero;
			A_1 = 0;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0002B570 File Offset: 0x00029770
		private static void WindowsFqbnVersionBuiltinAdministratorsSid(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			A_1 = 1;
			A_2 = 777;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0002B594 File Offset: 0x00029794
		private static void GetDefaultMembersSemaphoreFullException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			A_1 = 0;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0002B5AC File Offset: 0x000297AC
		private static void PartialTrustVisibilityLevelCommand(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref PhotonView A_7, ref VRRig A_8, ref bool A_9, ref GameObject A_10)
		{
			Player[] playerListOthers = PhotonNetwork.PlayerListOthers;
			A_4 = playerListOthers;
			int num = 0;
			A_5 = num;
			A_0 = 240;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0002B5F4 File Offset: 0x000297F4
		private static void PInvokeAttributesGetMonthName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref GorillaTagManager[] A_7, ref int A_8, ref GorillaTagManager A_9, ref bool A_10)
		{
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 9 + 442;
			A_0 = num;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0002B660 File Offset: 0x00029860
		public static void FlushRPCS()
		{
			int num = 243;
			int num2 = 243;
			num2 = 243;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 243;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0002B6A4 File Offset: 0x000298A4
		private static void WriteIntPtrLowest(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 409;
			A_0 = num;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0002B720 File Offset: 0x00029920
		private static void ToUniversalTimeUnsafeRegisterWaitForSingleObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GorillaRopeSwing[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			bool flag = A_5 < A_4.Length;
			A_10 = flag;
			int num = (A_10 ? 1 : 0) * -2 + 329;
			A_0 = num;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0002B78C File Offset: 0x0002998C
		private static void NDatasetEncoderFallback(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			A_1 = 0;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0002B7A4 File Offset: 0x000299A4
		private static void getIsMethodSpecsetMessageId(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			bool flag = false;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 838;
			A_0 = num;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0002B804 File Offset: 0x00029A04
		private static void TimerCallbackIIdentityAuthority(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			PhotonNetwork.Disconnect();
			A_1 = 0;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0002B824 File Offset: 0x00029A24
		private static void ServicePackMajorChannelPriority(ref int A_0, ref int A_1, ref int A_2)
		{
			WristMenu.FirstColor = Color.blue;
			WristMenu.SecondColor = Color.black;
			A_1 = 0;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0002B850 File Offset: 0x00029A50
		private static void PassesActivityFilterInternalGCCollectionMode(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			A_1 = 1;
			A_2 = 766;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0002B874 File Offset: 0x00029A74
		private static void UnSafeCharBuffergetGetMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 611;
			A_0 = num;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0002B8D0 File Offset: 0x00029AD0
		private static void PentityDeclGetGetMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0002B8E8 File Offset: 0x00029AE8
		private static void TKINDALIASCryptoKeyAuditRule(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref PhotonView A_7, ref VRRig A_8, ref bool A_9, ref GameObject A_10)
		{
			GameObject gameObject = GameObject.CreatePrimitive(2);
			A_10 = gameObject;
			Object.Destroy(A_10.GetComponent<BoxCollider>());
			Object.Destroy(A_10.GetComponent<Rigidbody>());
			Object.Destroy(A_10.GetComponent<Collider>());
			A_10.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
			A_10.transform.rotation = Quaternion.identity;
			A_10.transform.localScale = new Vector3(0.04f, 200f, 0.04f);
			A_10.transform.position = A_8.transform.position;
			A_10.GetComponent<MeshRenderer>().material = A_8.mainSkin.material;
			Object.Destroy(A_10, Time.deltaTime);
			int num = A_5 + 1;
			A_5 = num;
			int num2 = ((A_5 < A_4.Length) ? 1 : 0) * -7 + 241;
			A_0 = num2;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0002BA64 File Offset: 0x00029C64
		public static void flushmanually()
		{
			int num = 828;
			int num2 = 828;
			num2 = 828;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 828;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0002BAA8 File Offset: 0x00029CA8
		private static void setShortestDayNamesgetAccessControlType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color yellow = Color.yellow;
			A_4 = yellow;
			bool flag = A_5 == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 113;
			A_0 = num;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0002BB28 File Offset: 0x00029D28
		private static void getDeclaredConstructorssetCurrencyGroupSeparator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_10 = gripDownR;
			int num = ((!A_10) ? 1 : 0) * 1 + 562;
			A_0 = num;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0002BB84 File Offset: 0x00029D84
		private static void FqbngetStart(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.upside = false;
			RigShit.GetOwnVRRig().head.trackingRotationOffset.x = 0f;
			A_1 = 0;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0002BBC0 File Offset: 0x00029DC0
		private static void getHandlerOffsetgetEventName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			Mods.ropedelay = Time.time + 0.1f;
			Object[] array = Object.FindObjectsOfType(typeof(GorillaRopeSwing));
			A_4 = array;
			int num = 0;
			A_5 = num;
			A_0 = 173;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0002BC20 File Offset: 0x00029E20
		private static void ArrayListDebugViewIdentifierAuthority(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			int num = ((!A_3) ? 1 : 0) * 7 + 247;
			A_0 = num;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0002BC84 File Offset: 0x00029E84
		private static void DeploymentMetadataEntryFieldIdIteratorOfTToIteratorAdapter(ref int A_0, ref int A_1, ref int A_2)
		{
			NotifiLib.SendNotification("<color=yellow>[</color><color=green>TEST</color><color=grey>]</color> <color=white>TY FOR USING NEXU STAR =).</color>");
			A_1 = 0;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0002BCA8 File Offset: 0x00029EA8
		private static string XdrPrimitivegetIsConsoleEnabled(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			string text = "private";
			A_5 = text;
			A_0 = 289;
			string result;
			return result;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0002BCDC File Offset: 0x00029EDC
		private static void IMuiResourceTypeIdStringEntryOpenBaseKey(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Color A_4, ref bool A_5, ref string A_6, ref List<ButtonInfo>.Enumerator A_7, ref ButtonInfo A_8, ref bool A_9)
		{
			A_8.enabled = new bool?(false);
			int num = (A_7.MoveNext() ? 1 : 0) * -4 + 852;
			A_0 = num;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0002BD3C File Offset: 0x00029F3C
		private static void getDeltaCollapsed(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_12 = gripDownR;
			int num = ((!A_12) ? 1 : 0) * 1 + 566;
			A_0 = num;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0002BD98 File Offset: 0x00029F98
		private static void VectorToCollectionAdapterOpenRemoteBaseKey(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0002BDB0 File Offset: 0x00029FB0
		private static void ReflectionContextTrySteal(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			int num = (A_6.MoveNext() ? 1 : 0) * -9 + 229;
			A_0 = num;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0002BDF8 File Offset: 0x00029FF8
		private static void InTypeFixedCountFlaggetBaseName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_16 = gripDownR;
			int num = ((!A_16) ? 1 : 0) * 1 + 574;
			A_0 = num;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0002BE54 File Offset: 0x0002A054
		public static void WaterBalloonSpam()
		{
			int num = 601;
			int num2 = 601;
			num2 = 601;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 601;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0002BE98 File Offset: 0x0002A098
		private static void WindowsRuntimeBufferHelperIsTypeDef(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			int num = ((A_4 < A_3.Length) ? 1 : 0) * -4 + 265;
			A_0 = num;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0002BED4 File Offset: 0x0002A0D4
		private static void TypeISTOREENUMASSEMBLIESFLAGFORCELIBRARYSEMANTICS(ref int A_0, ref int A_1, ref int A_2)
		{
			Mods.PlatformsThing(true, false);
			A_1 = 0;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0002BEFC File Offset: 0x0002A0FC
		private static void StackEnumeratorLatinEncoding(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			bool inRoom = PhotonNetwork.InRoom;
			A_3 = inRoom;
			int num = ((!A_3) ? 1 : 0) * 19 + 892;
			A_0 = num;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0002BF58 File Offset: 0x0002A158
		private static void ParallelJoinArglist(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref PhotonView A_7, ref VRRig A_8, ref bool A_9, ref GameObject A_10)
		{
			int num = (A_8.isMyPlayer ? 1 : 0) * 1 + 236;
			A_0 = num;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0002BFA4 File Offset: 0x0002A1A4
		private static void getActivatorParenthesisFormat(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 113;
			A_0 = num;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0002C00C File Offset: 0x0002A20C
		private static void DeliverClientContextToServerContextsetKeyPassword(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			bool flag = A_5 < A_4.Length;
			A_10 = flag;
			int num = (A_10 ? 1 : 0) * -2 + 190;
			A_0 = num;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0002C078 File Offset: 0x0002A278
		public static void CustomColors()
		{
			int num = 699;
			int num2 = 699;
			num2 = 699;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 699;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0002C0BC File Offset: 0x0002A2BC
		private static void ThreadInterruptedhaveWrittenPreamble(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_14 = gripDownR;
			int num = ((!A_14) ? 1 : 0) * 1 + 570;
			A_0 = num;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0002C118 File Offset: 0x0002A318
		private static void SecurityInfrastructureSystemException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 10;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 1 + 152;
			A_0 = num;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0002C180 File Offset: 0x0002A380
		private static void DateTimeArrayTokenPrimaryGroup(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			bool flag = A_24 < A_25;
			A_28 = flag;
			bool flag2 = A_28;
			A_29 = flag2;
			int num = ((!A_29) ? 1 : 0) * 1 + 717;
			A_0 = num;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0002C20C File Offset: 0x0002A40C
		private static void LeaseSinkExactSpelling(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -8 + 792;
			A_0 = num;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0002C254 File Offset: 0x0002A454
		private static void SymAddressKindFaultActor(ref int A_0, ref int A_1, ref int A_2)
		{
			PlayerPrefs.SetFloat("redValue", -2.1474836E+09f);
			PlayerPrefs.SetFloat("greenValue", -2.1474836E+09f);
			PlayerPrefs.SetFloat("blueValue", -2.1474836E+09f);
			GorillaTagger.Instance.UpdateColor(-2.1474836E+09f, -2.1474836E+09f, -2.1474836E+09f);
			PlayerPrefs.Save();
			GorillaTagger.Instance.myVRRig.RPC("InitializeNoobMaterial", 0, new object[]
			{
				int.MinValue,
				int.MinValue,
				int.MinValue,
				false
			});
			A_1 = 0;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0002C324 File Offset: 0x0002A524
		private static void AsUintEncoderExceptionFallbackBuffer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("SnowballProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_7 = gripDownR;
			int num = ((!A_7) ? 1 : 0) * 1 + 556;
			A_0 = num;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0002C3AC File Offset: 0x0002A5AC
		private static void GetAbbreviatedMonthNameGetInterfaces(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_4;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 10 + 402;
			A_0 = num;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0002C40C File Offset: 0x0002A60C
		private static void getUTFIsInteropXmlElement(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0002C424 File Offset: 0x0002A624
		public static void Platforms()
		{
			int num = 31;
			int num2 = 31;
			num2 = 31;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 31;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0002C45C File Offset: 0x0002A65C
		private static void FixedAddressValueTypeAttributeOpenExisting(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			bool flag = Mods.pointer == null;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 482;
			A_0 = num;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0002C4C4 File Offset: 0x0002A6C4
		private static void HexIntEnumInstallationReferences(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			bool flag = (string)A_7 == "true";
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 9 + 897;
			A_0 = num;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0002C534 File Offset: 0x0002A734
		private static void TimerQueueHelpLink(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref bool A_7, ref PhotonView A_8)
		{
			int num = A_5 + 1;
			A_5 = num;
			int num2 = ((A_5 < A_4.Length) ? 1 : 0) * -4 + 476;
			A_0 = num2;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0002C594 File Offset: 0x0002A794
		private static void FileAssociationDefaultIconTrue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref Vector3 A_5)
		{
			bool flag = Mods.smth46 < Time.time;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 5 + 73;
			A_0 = num;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0002C5F8 File Offset: 0x0002A7F8
		private static void AdjustSessionIdSecurityContextDisableFlow(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 5;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 117;
			A_0 = num;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0002C660 File Offset: 0x0002A860
		public unsafe static void AntiReportV2()
		{
			RuntimeTypeHandle[] array = new RuntimeTypeHandle[1];
			Type[] array2 = new Type[1];
			array[0] = typeof(object).TypeHandle;
			int num = 1;
			int num2 = num * 4;
			int num3 = 701;
			int num4 = 701;
			num4 = 701;
			try
			{
				IL_3F:
				object[] array3;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array4;
				int num10;
				int num18;
				int num19;
				int num20;
				int num21;
				int num22;
				int num23;
				int num26;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 3)
					{
						num4 = 701;
						if ((int)array3[0] != 0)
						{
							num5 = (int)array3[1];
							num6 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num5 + num2);
							for (num7 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + (int)array3[4] + num2) + num2); num7 != num6; num7 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num7 + num2))
							{
								num8 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num7 + 32 + num2);
								if (num8 != -1)
								{
									num9 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num8 + 40 + num2);
									array3[4] = num8;
									array3[6] = 0;
									num3 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num8 + 40 + num2);
									goto IL_3F;
								}
							}
							Exception ex = (Exception)array3[3];
							num9 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num5 + 40 + num2);
							ex2 = ex;
							array3 = (object[])array3[5];
							array4 = new object[8];
							array4[0] = 1;
							array4[5] = array3;
							array4[3] = ex;
							array4[4] = num5;
							array4[6] = 1;
							array3 = array4;
							num3 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num5 + 40 + num2);
							continue;
						}
						num10 = (int)array3[7];
						array3 = (object[])array3[5];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 4)
						{
							GameObject gameObject;
							Transform transform;
							int num13;
							Transform transform2;
							bool flag;
							bool flag2;
							string text;
							int num14;
							Transform transform3;
							bool flag3;
							bool flag4;
							Text text2;
							Transform transform4;
							bool flag5;
							bool flag6;
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag7;
							bool flag8;
							float num15;
							float num16;
							float num17;
							bool flag9;
							bool flag10;
							bool flag11;
							bool flag12;
							bool flag13;
							bool flag14;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,UnityEngine.GameObject&,UnityEngine.Transform&,System.Int32&,UnityEngine.Transform&,System.Boolean&,System.Boolean&,System.String&,System.Int32&,UnityEngine.Transform&,System.Boolean&,System.Boolean&,UnityEngine.UI.Text&,UnityEngine.Transform&,System.Boolean&,System.Boolean&,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&,System.Boolean&,System.Single&,System.Single&,System.Single&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref gameObject, ref transform, ref num13, ref transform2, ref flag, ref flag2, ref text, ref num14, ref transform3, ref flag3, ref flag4, ref text2, ref transform4, ref flag5, ref flag6, ref enumerator, ref vrrig, ref flag7, ref flag8, ref num15, ref num16, ref num17, ref flag9, ref flag10, ref flag11, ref flag12, ref flag13, ref flag14, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 701;
						num8 = num12;
						num11 = num8;
					}
					num18 = num3;
					num6 = num18;
					num10 = 0;
					num19 = 4;
					for (;;)
					{
						num20 = (num10 + num19) / 2;
						num21 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 272 + num20 * 64 + num2);
						num22 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 272 + num20 * 64 + 40 + num2);
						if (num6 < num21 + num22)
						{
							if (num21 <= num6)
							{
								break;
							}
							num19 = num20 - 1;
						}
						else
						{
							num10 = num20 + 1;
						}
					}
					num7 = num20;
					num9 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 272 + num7 * 64 + 32 + num2);
					num23 = num9;
					num22 = num11;
					num21 = 0;
					num20 = 4;
					for (;;)
					{
						num19 = (num21 + num20) / 2;
						num10 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 272 + num19 * 64 + num2);
						num6 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 272 + num19 * 64 + 40 + num2);
						if (num22 < num10 + num6)
						{
							if (num10 <= num22)
							{
								break;
							}
							num20 = num19 - 1;
						}
						else
						{
							num21 = num19 + 1;
						}
					}
					num7 = num19;
					num8 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 272 + num7 * 64 + 32 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num19 = 4;
					for (;;)
					{
						num20 = (num10 + num19) / 2;
						num21 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 592 + num20 * 64 + num2);
						num22 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 592 + num20 * 64 + 40 + num2);
						if (num6 < num21 + num22)
						{
							if (num21 <= num6)
							{
								break;
							}
							num19 = num20 - 1;
						}
						else
						{
							num10 = num20 + 1;
						}
					}
					num7 = num20;
					num5 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 592 + num7 * 64 + 32 + num2);
					num8 = num5;
					for (;;)
					{
						IL_A37:
						if (array3 == null || (int)array3[0] == 0)
						{
							num6 = num9;
							while (num6 != num23)
							{
								if (num6 != -1)
								{
									num6 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num6 + num2);
								}
								else
								{
									num10 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num23 + 32 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num23 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num23 + num2);
									goto IL_A37;
								}
							}
							goto IL_BD6;
						}
						int num24 = (int)array3[4];
						int num25;
						if (num23 == -1)
						{
							num25 = -1;
						}
						else
						{
							num26 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num23 + 16 + num2);
							num22 = 0;
							num21 = 4;
							for (;;)
							{
								num20 = (num22 + num21) / 2;
								num19 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 592 + num20 * 64 + num2);
								num10 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 592 + num20 * 64 + 40 + num2);
								if (num26 < num19 + num10)
								{
									if (num19 <= num26)
									{
										break;
									}
									num21 = num20 - 1;
								}
								else
								{
									num22 = num20 + 1;
								}
							}
							num5 = num20;
							num7 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 592 + num5 * 64 + 32 + num2);
							num25 = num7;
						}
						if (num24 == num25)
						{
							num7 = num9;
							while (num7 != num23)
							{
								if (num7 != -1)
								{
									num7 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num7 + num2);
								}
								else
								{
									num5 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num23 + 32 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num23 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num23 + num2);
									goto IL_A37;
								}
							}
							break;
						}
						if ((int)array3[4] == num8)
						{
							goto Block_55;
						}
						array3 = (object[])array3[5];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num5 + 40 + num2);
					array4 = new object[]
					{
						0,
						null,
						null,
						null,
						null,
						array3,
						null,
						num11
					};
					array4[4] = num5;
					array4[6] = 0;
					array3 = array4;
					num3 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num5 + 40 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_BD6:
					num3 = num11;
					continue;
					Block_58:
					num19 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num10 + 40 + num2);
					array4 = new object[]
					{
						0,
						null,
						null,
						null,
						null,
						array3,
						null,
						num11
					};
					array4[4] = num10;
					array4[6] = 0;
					array3 = array4;
					num3 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num10 + 40 + num2);
				}
				num4 = 701;
				return;
				IL_213:
				if (num6 != -1)
				{
					goto IL_21E;
				}
				goto IL_44E;
				IL_21E:
				num7 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num6 + 48 + num2);
				if (0 == num7)
				{
					goto IL_23E;
				}
				if (3 == num7)
				{
					goto IL_3D2;
				}
				goto IL_44E;
				IL_23E:
				num9 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num6 + 56 + num2);
				if (num9 == -1)
				{
					goto IL_28A;
				}
				Type type;
				if ((type = array2[num9]) != null)
				{
					goto IL_26F;
				}
				array2[num9] = Type.GetTypeFromHandle(array[num9]);
				type = array2[num9];
				IL_26F:
				if (type.IsInstanceOfType(array4[3]))
				{
					goto IL_28A;
				}
				num6 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num6 + 24 + num2);
				goto IL_213;
				IL_28A:
				num5 = num6;
				num8 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num5 + num2) + num2);
				num18 = (int)array4[2];
				IL_2AA:
				if (num18 != num8)
				{
					goto IL_32C;
				}
				int num27 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num5 + 40 + num2);
				ex2 = array4[3];
				array3 = (object[])array3[5];
				object[] array5 = new object[8];
				array5[0] = 1;
				array5[5] = array3;
				array5[3] = array4[3];
				array5[2] = (int)array4[2];
				array5[4] = num5;
				array5[6] = 1;
				array3 = array5;
				num3 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num5 + 40 + num2);
				goto IL_3F;
				IL_32C:
				num23 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num18 + 32 + num2);
				if (num23 == -1)
				{
					goto IL_3C2;
				}
				num27 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num23 + 40 + num2);
				array3 = (object[])array3[5];
				array5 = new object[8];
				array5[0] = 1;
				array5[5] = array3;
				array5[3] = array4[3];
				array5[2] = (int)array4[2];
				array5[4] = num23;
				array5[1] = num5;
				array5[6] = 0;
				array3 = array5;
				num3 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num23 + 40 + num2);
				goto IL_3F;
				IL_3C2:
				num18 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num18 + num2);
				goto IL_2AA;
				IL_3D2:
				num27 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num6 + 32 + num2);
				ex2 = array4[3];
				array3 = (object[])array3[5];
				array5 = new object[8];
				array5[0] = 1;
				array5[5] = array3;
				array5[3] = array4[3];
				array5[2] = (int)array4[2];
				array5[4] = num6;
				array5[6] = 2;
				array3 = array5;
				num3 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num6 + 32 + num2);
				goto IL_3F;
				IL_44E:
				array3 = (object[])array3[5];
				Exception ex3 = array4[3];
				int num28 = (int)array4[2];
				IL_46D:
				num6 = num3;
				num27 = num6;
				num26 = 0;
				num10 = 4;
				IL_47C:
				num19 = (num26 + num10) / 2;
				num20 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 272 + num19 * 64 + num2);
				num21 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 272 + num19 * 64 + 40 + num2);
				if (num27 >= num20 + num21)
				{
					goto IL_4C1;
				}
				if (num20 > num27)
				{
					goto IL_4C9;
				}
				num8 = num19;
				num5 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 272 + num8 * 64 + 32 + num2);
				num9 = num5;
				num18 = num9;
				goto IL_4F2;
				IL_4C1:
				num26 = num19 + 1;
				goto IL_47C;
				IL_4C9:
				num10 = num19 - 1;
				goto IL_47C;
				IL_4F2:
				if (array3 != null)
				{
					goto IL_4FD;
				}
				goto IL_68E;
				IL_4FD:
				if ((int)array3[0] != 0)
				{
					goto IL_5BE;
				}
				int num29 = (int)array3[4];
				if (num9 != -1)
				{
					goto IL_521;
				}
				int num30 = -1;
				goto IL_5A5;
				IL_521:
				num22 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num9 + 16 + num2);
				num21 = 0;
				num20 = 4;
				IL_535:
				num19 = (num21 + num20) / 2;
				num10 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 592 + num19 * 64 + num2);
				num26 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 592 + num19 * 64 + 40 + num2);
				if (num22 >= num10 + num26)
				{
					goto IL_57A;
				}
				if (num10 > num22)
				{
					goto IL_582;
				}
				num5 = num19;
				num8 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 592 + num5 * 64 + 32 + num2);
				num30 = num8;
				goto IL_5A5;
				IL_57A:
				num21 = num19 + 1;
				goto IL_535;
				IL_582:
				num20 = num19 - 1;
				goto IL_535;
				IL_5A5:
				if (num29 != num30)
				{
					goto IL_5AD;
				}
				goto IL_68E;
				IL_5AD:
				array3 = (object[])array3[5];
				goto IL_4F2;
				IL_5BE:
				num23 = (int)array3[6];
				if (num23 == 1 || num23 == 0)
				{
					goto IL_5DF;
				}
				if (num23 != 2)
				{
					goto IL_5DE;
				}
				array4 = array3;
				num6 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + (int)array4[4] + 24 + num2);
				goto IL_213;
				IL_5DE:
				IL_5DF:
				int num31 = (int)array3[4];
				if (num9 != -1)
				{
					goto IL_5F4;
				}
				int num32 = -1;
				goto IL_678;
				IL_5F4:
				num27 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num9 + 16 + num2);
				num26 = 0;
				num10 = 4;
				IL_608:
				num19 = (num26 + num10) / 2;
				num20 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 592 + num19 * 64 + num2);
				num21 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 592 + num19 * 64 + 40 + num2);
				if (num27 >= num20 + num21)
				{
					goto IL_64D;
				}
				if (num20 > num27)
				{
					goto IL_655;
				}
				num8 = num19;
				num5 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + 592 + num8 * 64 + 32 + num2);
				num32 = num5;
				goto IL_678;
				IL_64D:
				num26 = num19 + 1;
				goto IL_608;
				IL_655:
				num10 = num19 - 1;
				goto IL_608;
				IL_678:
				if (num31 != num32)
				{
					goto IL_67D;
				}
				goto IL_68E;
				IL_67D:
				array3 = (object[])array3[5];
				goto IL_4F2;
				IL_68E:
				if (-1 != num9)
				{
					goto IL_69A;
				}
				int num33 = 1;
				throw ex3;
				IL_69A:
				num7 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num9 + 24 + num2);
				num10 = num7;
				IL_6AC:
				if (num10 != -1)
				{
					goto IL_6C1;
				}
				num9 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num9 + num2);
				goto IL_4F2;
				IL_6C1:
				num20 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num10 + 48 + num2);
				if (0 == num20)
				{
					goto IL_6EB;
				}
				if (3 == num20)
				{
					goto IL_858;
				}
				num9 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num9 + num2);
				goto IL_4F2;
				IL_6EB:
				num19 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num10 + 56 + num2);
				if (num19 == -1)
				{
					goto IL_738;
				}
				Type type2;
				if ((type2 = array2[num19]) != null)
				{
					goto IL_71C;
				}
				array2[num19] = Type.GetTypeFromHandle(array[num19]);
				type2 = array2[num19];
				IL_71C:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_738;
				}
				num10 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num10 + 24 + num2);
				goto IL_6AC;
				IL_738:
				num5 = num10;
				num8 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num5 + num2) + num2);
				num22 = (num18 - num28) * ((num28 == -1) ? 1 : 0) + num28;
				IL_75D:
				if (num22 != num8)
				{
					goto IL_7C9;
				}
				num26 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num5 + 40 + num2);
				ex2 = ex3;
				array4 = new object[8];
				array4[0] = 1;
				array4[5] = array3;
				array4[3] = ex3;
				array4[2] = num18;
				array4[4] = num5;
				array4[6] = 1;
				array3 = array4;
				num3 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num5 + 40 + num2);
				goto IL_3F;
				IL_7C9:
				num21 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num22 + 32 + num2);
				if (num21 == -1)
				{
					goto IL_848;
				}
				num26 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num21 + 40 + num2);
				array4 = new object[8];
				array4[0] = 1;
				array4[5] = array3;
				array4[3] = ex3;
				array4[2] = num18;
				array4[4] = num21;
				array4[1] = num5;
				array4[6] = 0;
				array3 = array4;
				num3 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num21 + 40 + num2);
				goto IL_3F;
				IL_848:
				num22 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num22 + num2);
				goto IL_75D;
				IL_858:
				num26 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num10 + 32 + num2);
				ex2 = ex3;
				array4 = new object[8];
				array4[0] = 1;
				array4[5] = array3;
				array4[3] = ex3;
				array4[2] = num18;
				array4[4] = num10;
				array4[6] = 2;
				array3 = array4;
				num3 = *(ref GetLifetimeServiceinternalOptionsForReplicas.BuiltinDomainSidISCIIDecoder + num10 + 32 + num2);
				goto IL_3F;
			}
			catch (Exception ex4)
			{
				int num33;
				if (num33 != 1)
				{
					Exception ex3 = ex4;
					int num28 = -1;
					goto IL_46D;
				}
				throw ex4;
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0002D300 File Offset: 0x0002B500
		public static void ChangeColor2()
		{
			int num = 22;
			int num2 = 22;
			num2 = 22;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 22;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0002D338 File Offset: 0x0002B538
		private static void GetAccessControlIsTypeVisibleFromCom(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref PhotonView A_7, ref VRRig A_8, ref bool A_9, ref GameObject A_10)
		{
			bool flag = PhotonNetwork.CurrentRoom != null;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 9 + 233;
			A_0 = num;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0002D398 File Offset: 0x0002B598
		private static void workQueueMSIL(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(Mods.jump_left_local);
			Mods.jump_left_local = null;
			Mods.once_left = false;
			Mods.once_left_false = true;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_24 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(71, null, A_24, SendOptions.SendReliable);
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 417;
			A_0 = num;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0002D45C File Offset: 0x0002B65C
		private static void BindToFieldRange(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			A_13.colorKeys = Mods.colorKeysPlatformMonke2;
			A_0 = 904;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0002D48C File Offset: 0x0002B68C
		private static void GetFileSystemEntriesExtensionAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0002D4A4 File Offset: 0x0002B6A4
		private static void InterfaceRemotingProxy(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0002D4BC File Offset: 0x0002B6BC
		private static List<VRRig> StringWriterWdiContext(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -8 + 887;
			A_0 = num;
			List<VRRig> result;
			return result;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0002D508 File Offset: 0x0002B708
		private static void LdargaStartDTD(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("Environment Objects/PersistentObjects_Prefab/GlobalObjectPools").SetActive(false);
			A_1 = 0;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0002D538 File Offset: 0x0002B738
		private static void ReadAttributesTokenAccessInformation(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color green = Color.green;
			A_4 = green;
			bool flag = A_5 == 5;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 142;
			A_0 = num;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0002D5B8 File Offset: 0x0002B7B8
		private static void ManifestFormatsSysUInt(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("BucketGiftCoal", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0002D5FC File Offset: 0x0002B7FC
		public static void CrashAllInsta()
		{
			int num = 295;
			int num2 = 295;
			num2 = 295;
			while (num2 != 0)
			{
				int num3;
				Vector2 vector;
				Vector2 vector2;
				double num4;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,UnityEngine.Vector2&,UnityEngine.Vector2&,System.Double&), ref num, ref num2, ref num3, ref vector, ref vector2, ref num4, Mods.ControlThreadBadData[num]);
			}
			num2 = 295;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0002D644 File Offset: 0x0002B844
		private static void ArgArrayPlusOffTooSmallAccountDomainAdminsSid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = Mods.jump_right_local != null;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 400;
			A_0 = num;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0002D6AC File Offset: 0x0002B8AC
		private static void getCancellationTokenThread(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			A_1 = 0;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0002D6C4 File Offset: 0x0002B8C4
		private static void UsageAllowedMaximumSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			Mods.pointer = GameObject.CreatePrimitive(0);
			Object.Destroy(Mods.pointer.GetComponent<Rigidbody>());
			Object.Destroy(Mods.pointer.GetComponent<SphereCollider>());
			Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			Mods.pointer.GetComponent<Renderer>().material.color = Color.red;
			Mods.pointer.transform.position = A_5.point;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 4 + 459;
			A_0 = num;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0002D7B8 File Offset: 0x0002B9B8
		private static void SilverlightBrowserHome(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref bool A_7, ref PhotonView A_8)
		{
			Player player = A_4[A_5];
			A_6 = player;
			bool flag = A_6.UserId != PhotonNetwork.LocalPlayer.UserId;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 473;
			A_0 = num;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0002D850 File Offset: 0x0002BA50
		private static void EventRegistrationTokenListWithCountIsNestedFamANDAssem(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 647;
			A_0 = num;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0002D8AC File Offset: 0x0002BAAC
		public static void RoundSpam()
		{
			int num = 619;
			int num2 = 619;
			num2 = 619;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 619;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0002D8F0 File Offset: 0x0002BAF0
		private static void KerbInteractiveLogonPinningHelper(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("Environment Objects/PersistentObjects_Prefab/GlobalObjectPools").SetActive(true);
			A_1 = 0;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0002D920 File Offset: 0x0002BB20
		private static void ResourceTypeCodeCaseInsensitive(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref GorillaTagManager[] A_7, ref int A_8, ref GorillaTagManager A_9, ref bool A_10)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			A_1 = 0;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0002D950 File Offset: 0x0002BB50
		private static void PrepareMethodMultiDomainHost(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			Mods.pointer = GameObject.CreatePrimitive(0);
			Object.Destroy(Mods.pointer.GetComponent<Rigidbody>());
			Object.Destroy(Mods.pointer.GetComponent<SphereCollider>());
			Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			Mods.pointer.transform.position = A_4.point;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 252;
			A_0 = num;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0002DA28 File Offset: 0x0002BC28
		private static void setVersionFilter(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			string[] array = File.ReadAllLines("TemplatePrefs\\templateSavedPrefs.txt");
			A_4 = array;
			string[] array2 = A_4;
			A_5 = array2;
			int num = 0;
			A_6 = num;
			A_0 = 384;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0002DA8C File Offset: 0x0002BC8C
		private static void CTSSTOREASSEMBLYSTATUSMANIFESTONLY(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0002DAA4 File Offset: 0x0002BCA4
		public static void MakeAllAcid()
		{
			int num = 298;
			int num2 = 298;
			num2 = 298;
			while (num2 != 0)
			{
				int num3;
				ScienceExperimentManager.PlayerGameState[] array;
				int num4;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,GorillaTag.ScienceExperimentManager/PlayerGameState[]&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref array, ref num4, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 298;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0002DAEC File Offset: 0x0002BCEC
		private static void GetTypeHandlegetCurrentThread(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool flag = !WristMenu.triggerDownL;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 779;
			A_0 = num;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0002DB50 File Offset: 0x0002BD50
		public static void Fly()
		{
			int num = 425;
			int num2 = 425;
			num2 = 425;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 425;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0002DB94 File Offset: 0x0002BD94
		private static void DynamicInvokeManifestFormats(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			VRRig vrrig = A_6.Current;
			A_7 = vrrig;
			int num = (A_7.isOfflineVRRig ? 1 : 0) * 1 + 221;
			A_0 = num;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0002DBFC File Offset: 0x0002BDFC
		private static void SignHashIObjectHandle(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			A_0 = 791;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0002DC14 File Offset: 0x0002BE14
		private static void ChangeAclgetDeclaredNestedTypesd(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0002DC2C File Offset: 0x0002BE2C
		private static void InitobjC(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 659;
			A_0 = num;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0002DC88 File Offset: 0x0002BE88
		private static void RegistrationConnectionTypeReflectionContext(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_28 = num;
			A_0 = 422;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0002DCB8 File Offset: 0x0002BEB8
		private static void SetAddOnMethodgetBuffer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_left_local = GameObject.CreatePrimitive(3);
			Mods.jump_left_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_18 = A_31;
			int num = ((!A_18) ? 1 : 0) * 1 + 409;
			A_0 = num;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0002DD44 File Offset: 0x0002BF44
		private static void ThreadingModelUnsafeInterfaces(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -9 + 841;
			A_0 = num;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0002DD8C File Offset: 0x0002BF8C
		private static void ITrackingHandlerJaggedOffset(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("BucketGiftRoll", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0002DDD0 File Offset: 0x0002BFD0
		private static void DurationsetAll(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0002DDE8 File Offset: 0x0002BFE8
		private static void wMajorVerNumTryGetTarget(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("IceSlingshot_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_9 = gripDownR;
			int num = ((!A_9) ? 1 : 0) * 1 + 560;
			A_0 = num;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0002DE70 File Offset: 0x0002C070
		private static void InlineStringKeyName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			bool triggerDownL = WristMenu.triggerDownL;
			A_3 = triggerDownL;
			int num = ((!A_3) ? 1 : 0) * 4 + 187;
			A_0 = num;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0002DED0 File Offset: 0x0002C0D0
		private static void GenericParameterAttributesSetCOMIUnknown(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 9;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 125;
			A_0 = num;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0002DF38 File Offset: 0x0002C138
		private static void NotSupportedExceptionSink(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, Color A_4)
		{
			bool flag = GorillaComputer.instance.friendJoinCollider.playerIDsCurrentlyTouching.Contains(PhotonNetwork.LocalPlayer.UserId);
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 156;
			A_0 = num;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0002DFB0 File Offset: 0x0002C1B0
		private static void LockApplicationPathEraseEndOfFile(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", 0, new object[]
			{
				A_6.transform.position,
				Random.rotation,
				4f,
				100f,
				true,
				false
			});
			Mods.flushmanually();
			int num = (A_5.MoveNext() ? 1 : 0) * -6 + 62;
			A_0 = num;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0002E098 File Offset: 0x0002C298
		public static void headbackwordsoff()
		{
			int num = 9;
			int num2 = 9;
			num2 = 9;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 9;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0002E0D0 File Offset: 0x0002C2D0
		private static void AtImpliedNotYetChecked(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 650;
			A_0 = num;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0002E12C File Offset: 0x0002C32C
		public static void HZ()
		{
			int num = 260;
			int num2 = 260;
			num2 = 260;
			while (num2 != 0)
			{
				int num3;
				SnowballThrowable[] array;
				int num4;
				SnowballThrowable snowballThrowable;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,SnowballThrowable[]&,System.Int32&,SnowballThrowable&,System.Boolean&), ref num, ref num2, ref num3, ref array, ref num4, ref snowballThrowable, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 260;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0002E178 File Offset: 0x0002C378
		private static void KeyContainerPermissionAccessEntryEnumeratorIUnrestrictedPermission(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			Mods.BetaFireProjectileDelay("ScienceCandyProjectile", Player.Instance.leftControllerTransform.position, Vector3.forward, Color.green, false);
			bool gripDownL = WristMenu.gripDownL;
			A_6 = gripDownL;
			int num = ((!A_6) ? 1 : 0) * 1 + 689;
			A_0 = num;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0002E200 File Offset: 0x0002C400
		private static void grfFlagsNeutralCultures(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color black = Color.black;
			A_4 = black;
			A_1 = 0;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0002E230 File Offset: 0x0002C430
		private static void SetValuegetIsGenericParameter(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			int num = A_11 + 1;
			A_11 = num;
			bool flag = A_11 < A_7.childCount;
			A_30 = flag;
			int num2 = (A_30 ? 1 : 0) * -20 + 727;
			A_0 = num2;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0002E2C0 File Offset: 0x0002C4C0
		private static void LimitSizeRandomAccess(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7)
		{
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 494;
			A_0 = num;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0002E32C File Offset: 0x0002C52C
		private static void WindowsFoundationEventHandlerMutexAuditRule(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("CloudSlingshot_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.red, false);
			A_1 = 0;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0002E370 File Offset: 0x0002C570
		private static void ConcurrentExclusiveSchedulerPairDisableEvents(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			int num = ((!A_3) ? 1 : 0) * 3 + 35;
			A_0 = num;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0002E3D4 File Offset: 0x0002C5D4
		private static void AtNmTokensNumberBuffer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref GameObject A_5, ref GameObject A_6)
		{
			A_1 = 0;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0002E3EC File Offset: 0x0002C5EC
		private static void EndChildrenDate(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			bool flag = !A_7.isMyPlayer;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 4 + 223;
			A_0 = num;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0002E45C File Offset: 0x0002C65C
		private static void getSetupInformationGetReferencedAssemblies(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			bool flag = !A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>();
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 210;
			A_0 = num;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0002E4DC File Offset: 0x0002C6DC
		public static void SquareSpam()
		{
			int num = 622;
			int num2 = 622;
			num2 = 622;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 622;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0002E520 File Offset: 0x0002C720
		private static void ICustomFactoryOverideEventProvider(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref ExecuteCloudScriptRequest A_5, ref string A_6, ref Hashtable A_7)
		{
			bool flag = false;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 312;
			A_0 = num;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0002E57C File Offset: 0x0002C77C
		private static void ScrollLockOnResourceTypeResourcesDependency(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			VRRig vrrig = A_5.Current;
			A_6 = vrrig;
			int num = ((!A_6.mainSkin.material.name.Contains("orangealive")) ? 1 : 0) * 1 + 833;
			A_0 = num;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0002E5F8 File Offset: 0x0002C7F8
		public static void headspinoff()
		{
			int num = 1;
			int num2 = 1;
			num2 = 1;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 1;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0002E62C File Offset: 0x0002C82C
		private static void CULTURETraceLoggingChannel(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			bool flag = A_3;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 10 + 429;
			A_0 = num;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0002E6AC File Offset: 0x0002C8AC
		private static void HashValueSizeComplete(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 581;
			A_0 = num;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0002E708 File Offset: 0x0002C908
		private static void getUnicodeEncodedGetRegisteredActivatedServiceTypes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			Object.Destroy(Mods.pointer);
			A_1 = 0;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0002E72C File Offset: 0x0002C92C
		private static void CompletionStateBinaryMethodCall(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			SnowballThrowable snowballThrowable = A_3[A_4];
			A_5 = snowballThrowable;
			bool flag = !A_5.randomizeColor;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 268;
			A_0 = num;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0002E7BC File Offset: 0x0002C9BC
		private static void AddTicksCrossAppDomainDelegate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 7;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 121;
			A_0 = num;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0002E824 File Offset: 0x0002CA24
		public static void NexuStarUserESP()
		{
			int num = 891;
			int num2 = 891;
			num2 = 891;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Player[] array;
				int num4;
				Player player;
				object obj;
				bool flag2;
				bool flag3;
				VRRig vrrig;
				bool flag4;
				ColorChanger colorChanger;
				Gradient gradient;
				bool flag5;
				bool flag6;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,Photon.Realtime.Player[]&,System.Int32&,Photon.Realtime.Player&,System.Object&,System.Boolean&,System.Boolean&,VRRig&,System.Boolean&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref array, ref num4, ref player, ref obj, ref flag2, ref flag3, ref vrrig, ref flag4, ref colorChanger, ref gradient, ref flag5, ref flag6, Mods.ControlThreadBadData[num]);
			}
			num2 = 891;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0002E880 File Offset: 0x0002CA80
		private static void CMSTIMEUNITTYPEEscapedCodeBase(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -4 + 265;
			A_0 = num2;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0002E8E0 File Offset: 0x0002CAE0
		private static void InternalsVisibleToAttributeCurrencyDecimalSeparator(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			GorillaTagger.Instance.GetComponent<Rigidbody>().velocity += Vector3.Normalize(A_6.rightHandTransform.position - Mods.lastLeft[A_4]) * 10f;
			Mods.lastLeft[A_4] = A_6.leftHandTransform.position;
			int num = (A_5.MoveNext() ? 1 : 0) * -8 + 792;
			A_0 = num;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0002E9A4 File Offset: 0x0002CBA4
		private static void ReturnMessageAssemblyCopyrightAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(Mods.jump_left_local.GetComponent<Renderer>());
			Mods.jump_left_local.transform.localScale = Mods.scale;
			Mods.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position;
			Mods.jump_left_local.transform.rotation = Player.Instance.leftControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.leftControllerTransform.position,
				Player.Instance.leftControllerTransform.rotation
			};
			A_19 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_20 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(69, A_19, A_20, SendOptions.SendReliable);
			Mods.once_left = true;
			Mods.once_left_false = false;
			ColorChanger colorChanger = Mods.jump_left_local.AddComponent<ColorChanger>();
			A_21 = colorChanger;
			Gradient gradient = new Gradient();
			A_22 = gradient;
			A_22.colorKeys = Mods.colorKeysPlatformMonke;
			A_21.colors = A_22;
			A_21.Start();
			A_0 = 416;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0002EB68 File Offset: 0x0002CD68
		private static List<VRRig> SetCanonicalizationContextClosePunctuation(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -8 + 887;
			A_0 = num;
			List<VRRig> result;
			return result;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0002EBB4 File Offset: 0x0002CDB4
		private static void getIsGlobalTypeDefTokenNullableMarshaler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			int num = ((!Physics.Raycast(Player.Instance.rightControllerTransform.position - Player.Instance.rightControllerTransform.up, -Player.Instance.rightControllerTransform.up, ref A_5)) ? 1 : 0) * 1 + 42;
			A_0 = num;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0002EC34 File Offset: 0x0002CE34
		private static void UriMarshalerGetDeploymentComponentManifest(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			A_0 = 720;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0002EC4C File Offset: 0x0002CE4C
		public static void CupidArrowSpam()
		{
			int num = 592;
			int num2 = 592;
			num2 = 592;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 592;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0002EC90 File Offset: 0x0002CE90
		private static void getIsPrimitivegetAllData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, Color A_4)
		{
			A_1 = 0;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0002ECA8 File Offset: 0x0002CEA8
		private static void TimeZoneInfoCOMServerEntryFieldId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref string A_4)
		{
			Mods.name = PhotonNetwork.NickName;
			string text = Mods.RandomRoomName();
			A_4 = text;
			PhotonNetwork.LocalPlayer.NickName = A_4;
			PhotonNetwork.NickName = A_4;
			PhotonNetwork.NetworkingClient.NickName = A_4;
			Mods.OEIFJWEF = true;
			A_1 = 0;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0002ED24 File Offset: 0x0002CF24
		public static void DeadshotSpamSS()
		{
			int num = 637;
			int num2 = 637;
			num2 = 637;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 637;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0002ED68 File Offset: 0x0002CF68
		private static void getPkcsGetSignatureToken(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			A_1 = 0;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0002ED80 File Offset: 0x0002CF80
		private static void MvidValueSizegetPlatform(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("BucketGiftRound", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_17 = gripDownR;
			int num = ((!A_17) ? 1 : 0) * 1 + 576;
			A_0 = num;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0002EE08 File Offset: 0x0002D008
		private static void RaiseMethodCustomAttributeNamedArgument(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 629;
			A_0 = num;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0002EE64 File Offset: 0x0002D064
		private static void DomainManagerRegisterSoapActionForMethodBase(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.roll = false;
			RigShit.GetOwnVRRig().head.trackingRotationOffset.x = 0f;
			A_1 = 0;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0002EEA0 File Offset: 0x0002D0A0
		public static void Grabornament()
		{
			int num = 319;
			int num2 = 319;
			num2 = 319;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 319;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0002EEE4 File Offset: 0x0002D0E4
		public static void RollSpam()
		{
			int num = 616;
			int num2 = 616;
			num2 = 616;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 616;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0002EF28 File Offset: 0x0002D128
		private static void setAppDomainInitializerArgumentsCspProviderFlags(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_0 = 380;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0002EF40 File Offset: 0x0002D140
		private static void BooleanVARFLAGFRESTRICTED(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			PhotonView photonView = ((GorillaRopeSwing)A_4[A_5]).photonView;
			A_6 = photonView;
			string text = "SetVelocity";
			A_7 = text;
			RpcTarget rpcTarget = 0;
			A_8 = rpcTarget;
			object[] array = new object[4];
			A_9 = array;
			A_9[0] = 10;
			A_9[1] = new Vector3((float)Random.Range(10, 411646), Random.Range(10f, -2.262549E+09f), (float)Random.Range(10, 3826319));
			A_9[2] = true;
			A_6.RPC(A_7, A_8, A_9);
			Mods.flushmanually();
			int num = A_5 + 1;
			A_5 = num;
			bool flag = A_5 < A_4.Length;
			A_10 = flag;
			int num2 = (A_10 ? 1 : 0) * -2 + 190;
			A_0 = num2;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0002F0F0 File Offset: 0x0002D2F0
		private static void setPaddingParallelForEach(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			A_5.head.rigTarget.gameObject.AddComponent<LineRenderer>();
			A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>().startWidth = 0.025f;
			A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GorillaTag/UberShader");
			A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>().material.color = A_5.playerColor;
			A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>().SetPosition(0, A_5.head.rigTarget.gameObject.transform.position);
			A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>().SetPosition(1, GorillaTagger.Instance.offlineVRRig.rightHandTransform.position);
			int num = (A_4.MoveNext() ? 1 : 0) * -8 + 215;
			A_0 = num;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0002F270 File Offset: 0x0002D470
		private static void CreateConstructionReturnMessageResourceType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color white = Color.white;
			A_4 = white;
			bool flag = A_5 == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 86;
			A_0 = num;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0002F2F0 File Offset: 0x0002D4F0
		private static void GetSafeUninitializedObjectPOLICYAUDITLOGADMIN(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color green = Color.green;
			A_4 = green;
			bool flag = A_5 == 5;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 92;
			A_0 = num;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0002F370 File Offset: 0x0002D570
		public static void SpiderBowSpamSS()
		{
			int num = 676;
			int num2 = 676;
			num2 = 676;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 676;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0002F3B4 File Offset: 0x0002D5B4
		private static void setAbbreviatedDayNamesNewEnum(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			bool flag = false;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 4 + 171;
			A_0 = num;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0002F410 File Offset: 0x0002D610
		private static void ReadOnlyListLineNumberInfo(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("motdtext").GetComponent<Text>().text = "1";
			GameObject.Find("COC Text").GetComponent<Text>().text = "2";
			GameObject.Find("CodeOfConduct").GetComponent<Text>().text = "3";
			GameObject.Find("motd").GetComponent<Text>().text = "NEXU ON TOP 4";
			GameObject.Find("motdscreen").GetComponent<Renderer>().material.color = Color.magenta;
			A_1 = 0;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0002F4B0 File Offset: 0x0002D6B0
		public static void LongArmsOn()
		{
			int num = 29;
			int num2 = 29;
			num2 = 29;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 29;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0002F4E8 File Offset: 0x0002D6E8
		public static void DisableFallDecorationsCS()
		{
			int num = 499;
			int num2 = 499;
			num2 = 499;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 499;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0002F52C File Offset: 0x0002D72C
		private static void RunImpersonatedgetCompatibleFrameworksData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("CupidBow_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0002F570 File Offset: 0x0002D770
		private static void setUserQuotaUnsafeDeserialize(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			A_0 = 840;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0002F588 File Offset: 0x0002D788
		private static void getInvalidCultureIdsetSelfAffectingProcessMgmt(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_10 = gripDownR;
			int num = ((!A_10) ? 1 : 0) * 1 + 529;
			A_0 = num;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0002F5E4 File Offset: 0x0002D7E4
		private static void ConvertHexDigitThrowExceptionIfDisposedCancellationTokenSource(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			int num = ((!A_3) ? 1 : 0) * 3 + 692;
			A_0 = num;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0002F648 File Offset: 0x0002D848
		private static void RaiseOnDeserializingEventSignatureAlgorithm(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref ExecuteCloudScriptRequest A_5, ref string A_6, ref Hashtable A_7)
		{
			A_1 = 0;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0002F660 File Offset: 0x0002D860
		private static void getNumberDecimalDigitsICDF(ref int A_0, ref int A_1, ref int A_2, ref Vector2 A_3, ref double A_4)
		{
			A_3..ctor(0.2f, 2f);
			int num = (PhotonNetwork.InRoom ? 1 : 0) * 1 + 305;
			A_0 = num;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0002F6B8 File Offset: 0x0002D8B8
		private static void TrimToSizeRightToLeftOverride(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 390;
			A_0 = num;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0002F714 File Offset: 0x0002D914
		private static void GenerateManifestgetSecurityRuleSet(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("HornsSlingshotProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0002F758 File Offset: 0x0002D958
		private static void removeCancelKeyPressIsModule(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			Mods.projDebounce = Time.time + Mods.projDebounceType;
			A_1 = 0;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0002F784 File Offset: 0x0002D984
		private static void FqbnRelatedActivityId(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			Transform transform = A_7.Find("GorillaScoreBoard(Clone)");
			A_7 = transform;
			int num = 0;
			A_9 = num;
			A_0 = 771;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0002F7D8 File Offset: 0x0002D9D8
		private static void FromFileTimeUtcEnsureByteCapacity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color grey = Color.grey;
			A_4 = grey;
			bool flag = A_5 == 8;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 148;
			A_0 = num;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0002F858 File Offset: 0x0002DA58
		private static void SetDataConsoleKey(ref int A_0, ref int A_1, ref int A_2, ref ExecuteCloudScriptRequest A_3, ref Hashtable A_4)
		{
			ExecuteCloudScriptRequest executeCloudScriptRequest = new ExecuteCloudScriptRequest();
			A_3 = executeCloudScriptRequest;
			A_3.FunctionName = "RoomClosed";
			A_3.FunctionParameter = new
			{
				GameId = PhotonNetwork.CurrentRoom.Name,
				Region = Regex.Replace(PhotonNetwork.CloudRegion, "[^a-zA-Z0-9]", "").ToUpper()
			};
			PlayFabClientAPI.ExecuteCloudScript(A_3, delegate(ExecuteCloudScriptResult result)
			{
				int num = 2;
				int num2 = 2;
				num2 = 2;
				while (num2 != 0)
				{
					int num3;
					calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.<>c.ITupleBlockLongPaths[num]);
				}
				num2 = 2;
			}, null, null, null);
			Hashtable hashtable = new Hashtable();
			A_4 = hashtable;
			A_4.Add("gameMode", "forestDEFAULTMODDED_MODDED_INFECTION");
			PhotonNetwork.CurrentRoom.SetCustomProperties(A_4, null, null);
			A_1 = 0;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0002F948 File Offset: 0x0002DB48
		public static Color purple
		{
			get
			{
				int num = 816;
				int num2 = 816;
				num2 = 816;
				Color result;
				while (num2 != 0)
				{
					int num3;
					Color color;
					result = calli(UnityEngine.Color(System.Int32&,System.Int32&,System.Int32&,UnityEngine.Color&), ref num, ref num2, ref num3, ref color, Mods.ControlThreadBadData[num]);
				}
				num2 = 816;
				return result;
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0002F990 File Offset: 0x0002DB90
		private static void ImportAsAgnosticFixedSizeArrayList(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("CloudSlingshot_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_4 = gripDownR;
			int num = ((!A_4) ? 1 : 0) * 1 + 517;
			A_0 = num;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0002FA18 File Offset: 0x0002DC18
		private static void NullableAdjustGroups(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Color A_4, ref bool A_5, ref string A_6, ref List<ButtonInfo>.Enumerator A_7, ref ButtonInfo A_8, ref bool A_9)
		{
			A_1 = 0;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0002FA30 File Offset: 0x0002DC30
		private static void getIsDiscretionaryAclCanonicalgetLatencyMode(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
			A_1 = 0;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0002FA6C File Offset: 0x0002DC6C
		private static void AllowCurrencySymbolGetTypeCode(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			A_7.mainSkin.material = A_4;
			A_0 = 226;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0002FAA4 File Offset: 0x0002DCA4
		public static void OFFunrellesesweattter()
		{
			int num = 815;
			int num2 = 815;
			num2 = 815;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 815;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0002FAE8 File Offset: 0x0002DCE8
		private static void GREGORIANXLITFRENCHIsValidText(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			GorillaFriendCollider gorillaFriendCollider = A_8[A_9];
			A_10 = gorillaFriendCollider;
			A_5.collider.GetComponent<GorillaComputer>().OnGroupJoinButtonPress(Random.RandomRange(1, 3), A_10);
			int num = A_9 + 1;
			A_9 = num;
			int num2 = ((A_9 < A_8.Length) ? 1 : 0) * -2 + 437;
			A_0 = num2;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0002FB98 File Offset: 0x0002DD98
		private static void DirectorySecurityCULTURE(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_18 = gripDownR;
			int num = ((!A_18) ? 1 : 0) * 1 + 545;
			A_0 = num;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0002FBF4 File Offset: 0x0002DDF4
		private static void GetValueDirectStringToHGlobalAnsi(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Mods.ChangeMonkColor(A_4);
			Mods.flushmanually();
			A_1 = 0;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0002FC24 File Offset: 0x0002DE24
		private static void getRelatedActivityIdSetMarshal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 7;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 96;
			A_0 = num;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0002FC8C File Offset: 0x0002DE8C
		private static void GetEncodingJulianCenturies(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref bool A_7, ref PhotonView A_8)
		{
			PhotonView viewFromPlayer = RigShit.GetViewFromPlayer(A_6);
			A_8 = viewFromPlayer;
			A_8.OwnerActorNr = PhotonNetwork.LocalPlayer.ActorNumber;
			A_8.ControllerActorNr = PhotonNetwork.LocalPlayer.ActorNumber;
			PhotonNetwork.Destroy(A_8);
			PhotonNetwork.Destroy(A_8.gameObject);
			int num = A_5 + 1;
			A_5 = num;
			int num2 = ((A_5 < A_4.Length) ? 1 : 0) * -4 + 476;
			A_0 = num2;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0002FD60 File Offset: 0x0002DF60
		private static void wIDLFlagsoVft(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			bool flag = Mods.pointer != null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 696;
			A_0 = num;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0002FDC4 File Offset: 0x0002DFC4
		private static void getEncodedTypePermissionSetEntry(ref int A_0, ref int A_1, ref int A_2)
		{
			A_1 = 0;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0002FDDC File Offset: 0x0002DFDC
		private static void TRACEPROVIDERINSTANCEINFOEventWrittenEventArgs(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			Transform child = A_7.GetChild(A_11);
			A_12 = child;
			bool flag = A_12.name.Contains("GorillaPlayerScoreboardLine");
			A_13 = flag;
			bool flag2 = A_13;
			A_14 = flag2;
			int num = ((!A_14) ? 1 : 0) * 17 + 708;
			A_0 = num;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0002FE90 File Offset: 0x0002E090
		private static void UMALQURAWrapper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			A_1 = 0;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0002FEA8 File Offset: 0x0002E0A8
		private static void AtFixedWantsToListen(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_14 = gripDownR;
			int num = ((!A_14) ? 1 : 0) * 1 + 537;
			A_0 = num;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0002FF04 File Offset: 0x0002E104
		private static void getResponseXmlNamespaceTokenDefaultDacl(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			bool flag = Mods.pointer == null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 432;
			A_0 = num;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0002FF6C File Offset: 0x0002E16C
		private static void NumUTCTimeMarkgetXsdType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_11 = gripDownR;
			int num = ((!A_11) ? 1 : 0) * 1 + 564;
			A_0 = num;
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0002FFC8 File Offset: 0x0002E1C8
		private static void MaxDefinedAceTypeSetKey(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("SlingshotProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.magenta, false);
			A_1 = 0;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0003000C File Offset: 0x0002E20C
		private static void RemotingConfigurationGetStringConstant(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_4 = gripDownR;
			int num = ((!A_4) ? 1 : 0) * 1 + 550;
			A_0 = num;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00030068 File Offset: 0x0002E268
		private static void DispatchChannelSinkAccessToken(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			((IDisposable)A_4).Dispose();
			A_1 = 5;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00030090 File Offset: 0x0002E290
		private static void IConvertiblegetContextProperties(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 671;
			A_0 = num;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000300EC File Offset: 0x0002E2EC
		private static void SystemAlarmObjectDXYMN(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			A_1 = 0;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00030104 File Offset: 0x0002E304
		private static void SetErrorCOREIO(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color green = Color.green;
			A_4 = green;
			bool flag = A_5 == 5;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 117;
			A_0 = num;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00030184 File Offset: 0x0002E384
		private static void IsPathRootedXdrString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("ScienceCandyProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.blue, false);
			A_1 = 0;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000301C8 File Offset: 0x0002E3C8
		private static void OemCommaUniqueKeyContainerName(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			string text = A_7.gameObject.name;
			A_10 = text;
			Transform transform = A_7.Find("GorillaScoreBoard/LineParent");
			A_7 = transform;
			int num = 0;
			A_11 = num;
			A_0 = 726;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00030240 File Offset: 0x0002E440
		private static void TruncateIsConsoleEnabled(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_5 = enumerator;
			A_0 = 55;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0003027C File Offset: 0x0002E47C
		private static void ExecuteSynchronouslygetOriginalIssuer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("WaterBalloonProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_11 = gripDownR;
			int num = ((!A_11) ? 1 : 0) * 1 + 564;
			A_0 = num;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00030304 File Offset: 0x0002E504
		public static void SpiderBowSpam()
		{
			int num = 625;
			int num2 = 625;
			num2 = 625;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 625;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00030348 File Offset: 0x0002E548
		private static void SetTraitsGetTypeFromHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00030360 File Offset: 0x0002E560
		private static void FindEnumerableElementTypeAddAuditRule(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool rightControllerPrimaryButton = ControllerInputPoller.instance.rightControllerPrimaryButton;
			A_3 = rightControllerPrimaryButton;
			bool flag = A_3;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 870;
			A_0 = num;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000303E0 File Offset: 0x0002E5E0
		private static string SByteArrayTypeInfoBitConverter(ref int A_0, ref int A_1, ref int A_2, ref string A_3, ref int A_4, ref bool A_5, ref bool A_6, ref string A_7)
		{
			string text = A_3;
			A_7 = text;
			A_0 = 862;
			string result;
			return result;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00030418 File Offset: 0x0002E618
		private static void ObjectDisposedRegKeyClosedDelegateEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			int num = (((Mods.ropedelay < Time.time) ? 1 : 0) + -1) * -1 * 1 + 169;
			A_0 = num;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00030458 File Offset: 0x0002E658
		private static void EncoderNLSToOACurrency(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color red = Color.red;
			A_4 = red;
			bool flag = A_5 == 4;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 90;
			A_0 = num;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000304D8 File Offset: 0x0002E6D8
		private static void AssemblyReferenceDependentAssemblyEntryFieldIdPaused(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("BucketGiftSquare", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0003051C File Offset: 0x0002E71C
		private static void UIIReadOnlyDictionary(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			Mods.funn = GameObject.Find("CameraTablet(Clone)");
			Mods.funn.SetActive(false);
			A_1 = 0;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00030554 File Offset: 0x0002E754
		private static void ExecuteNameInvalid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 635;
			A_0 = num;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000305B0 File Offset: 0x0002E7B0
		private static void StoreOperationStageComponentFileGetName(ref int A_0, ref int A_1, ref int A_2, ref Vector2 A_3, ref double A_4)
		{
			double num = (double)Time.time;
			A_4 = num;
			ScienceExperimentManager.instance.photonView.RPC("SpawnSodaBubbleRPC", 0, new object[]
			{
				A_3,
				float.MinValue,
				9999f,
				A_4
			});
			A_1 = 0;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00030658 File Offset: 0x0002E858
		private static void COMServerConfiguredGuidUnregisterTrackingHandler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			A_1 = 0;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00030670 File Offset: 0x0002E870
		private static void HostResolvePolicyIDLFLAGFIN(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00030688 File Offset: 0x0002E888
		public static void Disconnect()
		{
			int num = 32;
			int num2 = 32;
			num2 = 32;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 32;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000306C0 File Offset: 0x0002E8C0
		private static void AccessDeniedCallbackDeploymentId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			GorillaTagger.Instance.offlineVRRig.transform.position = Vector3.zero;
			Object.Destroy(Mods.pointer);
			A_1 = 0;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00030714 File Offset: 0x0002E914
		private static void HostDllGetUrlsForObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			bool flag = GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("orange");
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 919;
			A_0 = num;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00030798 File Offset: 0x0002E998
		private static void CRMkeysNoFaultBlack(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -8 + 215;
			A_0 = num;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000307E0 File Offset: 0x0002E9E0
		private static void NativeObjectSecurityGetRuntimeBaseDefinition(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 641;
			A_0 = num;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0003083C File Offset: 0x0002EA3C
		private static void SXXSystemX(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			bool flag = false;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 23 + 750;
			A_0 = num;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00030898 File Offset: 0x0002EA98
		private static void ICustomPropertyBinaryAssemblyInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref PhotonView A_7, ref VRRig A_8, ref bool A_9, ref GameObject A_10)
		{
			bool flag = !A_7.IsMine;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 238;
			A_0 = num;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00030908 File Offset: 0x0002EB08
		public static void CandyCaneSpamSS()
		{
			int num = 661;
			int num2 = 661;
			num2 = 661;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 661;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0003094C File Offset: 0x0002EB4C
		private static void ClauseIsNaN(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetwork.Disconnect();
			PhotonNetwork.JoinRandomRoom();
			A_1 = 0;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00030970 File Offset: 0x0002EB70
		private static void CFBConcurrentDictionary(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			bool flag = Time.time > Mods.projDebounce;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 5 + 501;
			A_0 = num;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000309D4 File Offset: 0x0002EBD4
		private static string getReflectedTypeGetAvailableThreads(ref int A_0, ref int A_1, ref int A_2, ref string A_3, ref int A_4, ref bool A_5, ref bool A_6, ref string A_7)
		{
			string text = Mods.RandomRoomName();
			A_7 = text;
			A_0 = 862;
			string result;
			return result;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00030A08 File Offset: 0x0002EC08
		private static void InternalPrimitiveTypeEPm(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			PhotonNetwork.Disconnect();
			NotifiLib.SendNotification("<color=red>[ANTI-MODERATOR]</color> Someone with a STICK joined, disconnected.");
			int num = (A_4.MoveNext() ? 1 : 0) * -6 + 200;
			A_0 = num;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00030A64 File Offset: 0x0002EC64
		public static void TagAll()
		{
			int num = 441;
			int num2 = 441;
			num2 = 441;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Player[] array;
				int num4;
				Player player;
				GorillaTagManager[] array2;
				int num5;
				GorillaTagManager gorillaTagManager;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,Photon.Realtime.Player[]&,System.Int32&,Photon.Realtime.Player&,GorillaTagManager[]&,System.Int32&,GorillaTagManager&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref array, ref num4, ref player, ref array2, ref num5, ref gorillaTagManager, ref flag2, Mods.ControlThreadBadData[num]);
			}
			num2 = 441;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00030AB8 File Offset: 0x0002ECB8
		public static void headupsideoff()
		{
			int num = 15;
			int num2 = 15;
			num2 = 15;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 15;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00030AF0 File Offset: 0x0002ECF0
		private static void UnicodeByteArrayOrdinalRandomizedComparer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00030B08 File Offset: 0x0002ED08
		private static void ToUIntBStr(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref MeshCollider[] A_4, ref int A_5, ref MeshCollider A_6, ref MeshCollider[] A_7, ref int A_8, ref MeshCollider A_9)
		{
			MeshCollider[] array = Resources.FindObjectsOfTypeAll<MeshCollider>();
			A_7 = array;
			int num = 0;
			A_8 = num;
			A_0 = 165;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00030B50 File Offset: 0x0002ED50
		private static void WindowsRuntimeMetadataCurrencyGroupSeparator(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			PhotonNetwork.Disconnect();
			NotifiLib.SendNotification("<color=grey>[</color><color=purple>ANTI-REPORT</color><color=red>]</color> <color=red>Someone attempted to report you.</color>");
			int num = (A_16.MoveNext() ? 1 : 0) * -8 + 764;
			A_0 = num;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00030BAC File Offset: 0x0002EDAC
		public static void HeadBackwords()
		{
			int num = 6;
			int num2 = 6;
			num2 = 6;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 6;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00030BE0 File Offset: 0x0002EDE0
		public static void ChangeColorPaidMain()
		{
			int num = 20;
			int num2 = 20;
			num2 = 20;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 20;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00030C18 File Offset: 0x0002EE18
		private static void SurrogatesetLastAccessTimeUtc(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			int num = A_6 + 1;
			A_6 = num;
			bool flag = A_6 < A_5.childCount;
			A_23 = flag;
			int num2 = (A_23 ? 1 : 0) * -28 + 775;
			A_0 = num2;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00030CAC File Offset: 0x0002EEAC
		private static void getApplicationUrlArgMapper(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_1 = 5;
			A_2 = 371;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00030CD0 File Offset: 0x0002EED0
		private static void ZoneMembershipConditionInterfaceTypeAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_18 = gripDownR;
			int num = ((!A_18) ? 1 : 0) * 1 + 578;
			A_0 = num;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00030D2C File Offset: 0x0002EF2C
		private static string StructuralEqualityComparerGetDocument(ref int A_0, ref int A_1, ref int A_2, ref string A_3, ref int A_4, ref bool A_5, ref bool A_6, ref string A_7)
		{
			string text = "";
			A_3 = text;
			int num = 0;
			A_4 = num;
			A_0 = 858;
			string result;
			return result;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00030D74 File Offset: 0x0002EF74
		public static void RopeSpaz()
		{
			int num = 325;
			int num2 = 325;
			num2 = 325;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				GorillaRopeSwing[] array;
				int num4;
				PhotonView photonView;
				string text;
				RpcTarget rpcTarget;
				object[] array2;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,GorillaLocomotion.Gameplay.GorillaRopeSwing[]&,System.Int32&,Photon.Pun.PhotonView&,System.String&,Photon.Pun.RpcTarget&,System.Object[]&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref array, ref num4, ref photonView, ref text, ref rpcTarget, ref array2, ref flag2, Mods.ControlThreadBadData[num]);
			}
			num2 = 325;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00030DC8 File Offset: 0x0002EFC8
		public static void ONunrellesesweattter()
		{
			int num = 814;
			int num2 = 814;
			num2 = 814;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 814;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00030E0C File Offset: 0x0002F00C
		private static void ThreadingModelUnregisterDynamicProperty(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			A_1 = 0;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00030E24 File Offset: 0x0002F024
		private static void LocalSignatureMetadataTokenStartNew(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool rightControllerSecondaryButton = ControllerInputPoller.instance.rightControllerSecondaryButton;
			A_3 = rightControllerSecondaryButton;
			int num = ((!A_3) ? 1 : 0) * 1 + 426;
			A_0 = num;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00030E88 File Offset: 0x0002F088
		private static void EmptyStructgetDenySetInstance(ref int A_0, ref int A_1, ref int A_2)
		{
			WristMenu.FirstColor = Color.green;
			WristMenu.SecondColor = Color.cyan;
			A_1 = 0;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00030EB4 File Offset: 0x0002F0B4
		private static void VarargTryDequeueIf(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 317;
			A_0 = num;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00030F20 File Offset: 0x0002F120
		private static void RemoveEtwSessionIDisposable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color black = Color.black;
			A_4 = black;
			bool flag = A_5 == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 109;
			A_0 = num;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00030FA0 File Offset: 0x0002F1A0
		private static void mlockWasTakenEVENTINFOCLASS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.red;
			Mods.pointer.GetComponent<Renderer>().material.color = Color.red;
			A_0 = 465;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00030FF0 File Offset: 0x0002F1F0
		private static void PulsegetEncoding(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 180f;
			Mods.back = true;
			A_1 = 0;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00031034 File Offset: 0x0002F234
		private static void DirectorySeparatorCharVTCY(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("SnowballProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.magenta, false);
			A_1 = 0;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00031078 File Offset: 0x0002F278
		private static void HostFilepvReserved(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 602;
			A_0 = num;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000310D4 File Offset: 0x0002F2D4
		private static void getMonitoringIsEnabledLocalPop(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			string text = A_5[A_6];
			A_7 = text;
			List<ButtonInfo>.Enumerator enumerator = WristMenu.buttons.GetEnumerator();
			A_8 = enumerator;
			A_0 = 364;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0003112C File Offset: 0x0002F32C
		public static void LockOnGun()
		{
			int num = 810;
			int num2 = 810;
			num2 = 810;
			while (num2 != 0)
			{
				int num3;
				Player[] array;
				int num4;
				Player player;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,Photon.Realtime.Player[]&,System.Int32&,Photon.Realtime.Player&), ref num, ref num2, ref num3, ref array, ref num4, ref player, Mods.ControlThreadBadData[num]);
			}
			num2 = 810;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00031174 File Offset: 0x0002F374
		private static void DefaultValueAsBstr(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			bool flag = A_3;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 7 + 489;
			A_0 = num;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x000311F4 File Offset: 0x0002F3F4
		private static void getScheduledExclusiveLoadAssemblyFromString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			bool flag = Mods.pointer == null;
			A_6 = flag;
			bool flag2 = A_6;
			A_7 = flag2;
			int num = ((!A_7) ? 1 : 0) * 1 + 799;
			A_0 = num;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00031274 File Offset: 0x0002F474
		private static void TargetTypeConcurrentQueue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			A_10.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
			ColorChanger orAddComponent = GTExt.GetOrAddComponent<ColorChanger>(A_10.mainSkin.gameObject);
			A_12 = orAddComponent;
			Gradient gradient = new Gradient();
			A_13 = gradient;
			A_12.colors = A_13;
			int num = (A_10.mainSkin.material.name.Contains("fected") ? 1 : 0) * 1 + 899;
			A_0 = num;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0003134C File Offset: 0x0002F54C
		private static void AssemblyReferenceDependentAssemblyHashValuegetMetadataToken(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00031364 File Offset: 0x0002F564
		public static void DeadshotSpam()
		{
			int num = 586;
			int num2 = 586;
			num2 = 586;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 586;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000313A8 File Offset: 0x0002F5A8
		public static void KickAll()
		{
			int num = 303;
			int num2 = 303;
			num2 = 303;
			while (num2 != 0)
			{
				int num3;
				Hashtable hashtable;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ExitGames.Client.Photon.Hashtable&), ref num, ref num2, ref num3, ref hashtable, Mods.ControlThreadBadData[num]);
			}
			num2 = 303;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000313EC File Offset: 0x0002F5EC
		private static void IDeserializationCallbackHostAppDomainEvidence(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			A_0 = 440;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0003143C File Offset: 0x0002F63C
		private static void getBufferHeightUnknownToken(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7)
		{
			bool flag = Mods.pointer == null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 492;
			A_0 = num;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000314A4 File Offset: 0x0002F6A4
		private static void IUnknownConstantAttributeReadChars(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref ExecuteCloudScriptRequest A_5, ref string A_6, ref Hashtable A_7)
		{
			PhotonNetwork.CurrentRoom.CustomProperties.TryGetValue("gameMode", out A_3);
			int num = (A_3.ToString().Contains("MODDED") ? 1 : 0) * 3 + 308;
			A_0 = num;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00031514 File Offset: 0x0002F714
		public static void SnowballSpam()
		{
			int num = 589;
			int num2 = 589;
			num2 = 589;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 589;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00031558 File Offset: 0x0002F758
		private static void CultureDataFromAsyncTrimPromise(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -9 + 841;
			A_0 = num;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000315A0 File Offset: 0x0002F7A0
		private static void BufferHeightIStoreBindingResultBoundVersion(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			bool flag = A_9 < A_7.childCount;
			A_22 = flag;
			int num = (A_22 ? 1 : 0) * -21 + 772;
			A_0 = num;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00031610 File Offset: 0x0002F810
		private static void VolatileWritesetLeaseManagerPollTime(ref int A_0, ref int A_1, ref int A_2)
		{
			Process.Start("https://www.youtube.com/channel/UCxZln8hkhI_qREgs8o9Nh7g");
			A_1 = 0;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00031634 File Offset: 0x0002F834
		private static void ParentFieldResourceManagerFoundResourceSetInCacheUnexpected(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("BucketGiftRound", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00031678 File Offset: 0x0002F878
		public static void MosaSpeed()
		{
			int num = 466;
			int num2 = 466;
			num2 = 466;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 466;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000316BC File Offset: 0x0002F8BC
		public static void LagAllV2()
		{
			int num = 290;
			int num2 = 290;
			num2 = 290;
			while (num2 != 0)
			{
				int num3;
				Player[] array;
				int num4;
				Player player;
				MethodInfo methodInfo;
				object obj;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,Photon.Realtime.Player[]&,System.Int32&,Photon.Realtime.Player&,System.Reflection.MethodInfo&,System.Object&), ref num, ref num2, ref num3, ref array, ref num4, ref player, ref methodInfo, ref obj, Mods.ControlThreadBadData[num]);
			}
			num2 = 290;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00031708 File Offset: 0x0002F908
		public static void AllSpamersSS()
		{
			int num = 514;
			int num2 = 514;
			num2 = 514;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				bool flag7;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				bool flag12;
				bool flag13;
				bool flag14;
				bool flag15;
				bool flag16;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref flag7, ref flag8, ref flag9, ref flag10, ref flag11, ref flag12, ref flag13, ref flag14, ref flag15, ref flag16, Mods.ControlThreadBadData[num]);
			}
			num2 = 514;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0003176C File Offset: 0x0002F96C
		private static void CdeclClt(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref MethodInfo A_6, ref object A_7)
		{
			int num = ((A_4 < A_3.Length) ? 1 : 0) * -2 + 293;
			A_0 = num;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000317A8 File Offset: 0x0002F9A8
		private static void EndNoGCRegionStatusGetOrCreateValue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			int num = ((A_9 < A_8.Length) ? 1 : 0) * -2 + 437;
			A_0 = num;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000317E4 File Offset: 0x0002F9E4
		public static void HeadSpin()
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 1)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 0;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00031818 File Offset: 0x0002FA18
		private static void getChannelURIEventResetMode(ref int A_0, ref int A_1, ref int A_2, Mods A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0003183C File Offset: 0x0002FA3C
		public static void SlingshotSpamSS()
		{
			int num = 634;
			int num2 = 634;
			num2 = 634;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 634;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00031880 File Offset: 0x0002FA80
		private static void FqbnCheckedOneWay(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 662;
			A_0 = num;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000318DC File Offset: 0x0002FADC
		private static void ValueLengthIKeyValuePairEnumerator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 680;
			A_0 = num;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00031938 File Offset: 0x0002FB38
		public static void KickGun()
		{
			int num = 40;
			int num2 = 40;
			num2 = 40;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				RaycastHit raycastHit;
				bool flag3;
				bool flag4;
				GorillaFriendCollider[] array;
				int num4;
				GorillaFriendCollider gorillaFriendCollider;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,UnityEngine.RaycastHit&,System.Boolean&,System.Boolean&,GorillaFriendCollider[]&,System.Int32&,GorillaFriendCollider&), ref num, ref num2, ref num3, ref flag, ref flag2, ref raycastHit, ref flag3, ref flag4, ref array, ref num4, ref gorillaFriendCollider, Mods.ControlThreadBadData[num]);
			}
			num2 = 40;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00031980 File Offset: 0x0002FB80
		private static void TimerQueueTimerTargetFrameworkAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 1;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 134;
			A_0 = num;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000319E8 File Offset: 0x0002FBE8
		public static void ElfBowSpamSS()
		{
			int num = 649;
			int num2 = 649;
			num2 = 649;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 649;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00031A2C File Offset: 0x0002FC2C
		private static List<VRRig> MethodSpecChangeWrapperHandleStrength(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 884;
			A_0 = num;
			List<VRRig> result;
			return result;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00031A8C File Offset: 0x0002FC8C
		private static void BuiltinDomainSidmkey(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 590;
			A_0 = num;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00031AE8 File Offset: 0x0002FCE8
		public static void CoalSpamSS()
		{
			int num = 664;
			int num2 = 664;
			num2 = 664;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 664;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00031B2C File Offset: 0x0002FD2C
		private static void SetMinThreadsgetCurrentInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref MeshCollider[] A_4, ref int A_5, ref MeshCollider A_6, ref MeshCollider[] A_7, ref int A_8, ref MeshCollider A_9)
		{
			A_1 = 0;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00031B44 File Offset: 0x0002FD44
		private static void FUNCFLAGFNONBROWSABLEAssemblyIsolationByUser(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 6 + 405;
			A_0 = num;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00031BA0 File Offset: 0x0002FDA0
		private static void SystemDefinedImplKeyProperty(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			ButtonInfo buttonInfo = A_5.Current;
			A_6 = buttonInfo;
			bool? enabled = A_6.enabled;
			A_7 = enabled;
			bool flag = true;
			A_8 = flag;
			bool flag2 = A_7.GetValueOrDefault() == A_8 & A_7 != null;
			A_9 = flag2;
			int num = ((!A_9) ? 1 : 0) * 1 + 356;
			A_0 = num;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00031C64 File Offset: 0x0002FE64
		private static void RoleDSASignatureFormatter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref PhotonView A_7, ref VRRig A_8, ref bool A_9, ref GameObject A_10)
		{
			A_1 = 0;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00031C7C File Offset: 0x0002FE7C
		private static void GetPropertyPropsStringBuilderUnicode(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>().SetPosition(0, A_5.head.rigTarget.gameObject.transform.position);
			A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>().SetPosition(1, GorillaTagger.Instance.offlineVRRig.rightHandTransform.position);
			int num = (A_4.MoveNext() ? 1 : 0) * -8 + 215;
			A_0 = num;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00031D4C File Offset: 0x0002FF4C
		private static void setSiteDescriptionMetadataEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			A_0 = 908;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00031D68 File Offset: 0x0002FF68
		private static void IdentityObjectCOMServerEntryFieldId(ref int A_0, ref int A_1, ref int A_2, ref ScienceExperimentManager.PlayerGameState[] A_3, ref int A_4, ref bool A_5)
		{
			Traverse.Create(ScienceExperimentManager.instance).Field("inGamePlayerCount").SetValue(10);
			ScienceExperimentManager.PlayerGameState[] array = new ScienceExperimentManager.PlayerGameState[10];
			A_3 = array;
			int num = 0;
			A_4 = num;
			A_0 = 300;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00031DD8 File Offset: 0x0002FFD8
		private static void setDigitSubstitutionFindName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00031DF0 File Offset: 0x0002FFF0
		private static void CATEGORYCodeGroupPositionMarker(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_15 = gripDownR;
			int num = ((!A_15) ? 1 : 0) * 1 + 572;
			A_0 = num;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00031E4C File Offset: 0x0003004C
		private static void CustomAttributeDataUI(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 4;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 115;
			A_0 = num;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00031EB4 File Offset: 0x000300B4
		private static void getReferenceIdentitygetFrameworkDisplayName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_15 = gripDownR;
			int num = ((!A_15) ? 1 : 0) * 1 + 539;
			A_0 = num;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00031F10 File Offset: 0x00030110
		private static void StructPropertyWriterCreateFormatter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("BucketGiftCane", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_14 = gripDownR;
			int num = ((!A_14) ? 1 : 0) * 1 + 570;
			A_0 = num;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00031F98 File Offset: 0x00030198
		private static void CollectNOTSUPPORTED(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			ButtonInfo buttonInfo = A_5.Current;
			A_6 = buttonInfo;
			bool? enabled = A_6.enabled;
			A_7 = enabled;
			bool flag = true;
			A_8 = flag;
			bool flag2 = A_7.GetValueOrDefault() == A_8 & A_7 != null;
			A_9 = flag2;
			int num = ((!A_9) ? 1 : 0) * 1 + 347;
			A_0 = num;
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0003205C File Offset: 0x0003025C
		public static void IceSlingshotSpamSS()
		{
			int num = 646;
			int num2 = 646;
			num2 = 646;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 646;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000320A0 File Offset: 0x000302A0
		private static Color GetFileObfuscateAssemblyAttribute(ref int A_0, ref int A_1, ref int A_2, ref Color A_3)
		{
			Color color = new Color(0.7f, 0f, 0.9f, 1f);
			A_3 = color;
			A_0 = 817;
			Color result;
			return result;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000320E8 File Offset: 0x000302E8
		private static void getDriveTypeUNICODEINTPTRSTRING(ref int A_0, ref int A_1, ref int A_2, ref VRMap A_3)
		{
			VRMap head = RigShit.GetOwnVRRig().head;
			A_3 = head;
			A_3.trackingRotationOffset.x = A_3.trackingRotationOffset.x + 15f;
			Mods.roll = true;
			A_1 = 0;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00032154 File Offset: 0x00030354
		public static void WaterBend()
		{
			int num = 314;
			int num2 = 314;
			num2 = 314;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, Mods.ControlThreadBadData[num]);
			}
			num2 = 314;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0003219C File Offset: 0x0003039C
		private static void getImpersonationLevelLimitTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.balll2111 = Time.time + 0.01f;
			GorillaTagger.Instance.myVRRig.RPC("PlayHandTap", 1, new object[]
			{
				94,
				true,
				999f
			});
			Mods.flushmanually();
			A_1 = 0;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00032224 File Offset: 0x00030424
		private static void EncodeOption(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			int num = ((A_12 < A_11.Length) ? 1 : 0) * -2 + 804;
			A_0 = num;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00032260 File Offset: 0x00030460
		private static void SetGroupsetClaimsPrincipalSelector(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			PhotonNetwork.OpCleanActorRpcBuffer(PhotonNetwork.LocalPlayer.ActorNumber);
			PhotonNetwork.RemoveRPCs(GorillaTagger.Instance.myVRRig);
			PhotonNetwork.RemoveBufferedRPCs(GorillaTagger.Instance.myVRRig.ViewID, null, null);
			PhotonNetwork.SendAllOutgoingCommands();
			GorillaNot.instance.rpcCallLimit = int.MaxValue;
			PhotonNetwork.SendAllOutgoingCommands();
			PhotonNetwork.SendAllOutgoingCommands();
			PhotonNetwork.SendAllOutgoingCommands();
			A_1 = 0;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000322DC File Offset: 0x000304DC
		private static void ClaimsMarkAborted(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -4 + 359;
			A_0 = num;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00032324 File Offset: 0x00030524
		private static void ContentTypeSuppressMergeCheckAttribute(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			((IDisposable)A_4).Dispose();
			A_1 = 4;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0003234C File Offset: 0x0003054C
		private static void CharSizeCORINFOEHCLAUSE(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			bool flag = (double)A_20 < 0.35;
			A_21 = flag;
			int num = ((!A_21) ? 1 : 0) * 1 + 760;
			A_0 = num;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000323BC File Offset: 0x000305BC
		private static void getOperandTypegrfFlags(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("ScienceCandyProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00032400 File Offset: 0x00030600
		private static void GetEncoderPanic(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Color A_4, ref bool A_5, ref string A_6, ref List<ButtonInfo>.Enumerator A_7, ref ButtonInfo A_8, ref bool A_9)
		{
			int num = (A_7.MoveNext() ? 1 : 0) * -4 + 852;
			A_0 = num;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00032448 File Offset: 0x00030648
		private static void ConcurrentExclusiveTaskSchedulerStackCrawlMarkHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 111;
			A_0 = num;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x000324B0 File Offset: 0x000306B0
		private static void setExceptionMessagegetSequencePointCount(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			bool flag = A_3;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 27;
			A_0 = num;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00032530 File Offset: 0x00030730
		private static void NevergetTextInfo(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			A_1 = 1;
			A_2 = 352;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00032554 File Offset: 0x00030754
		private static void getLicenseFileopIncrement(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			VRRig vrrig = GorillaGameManager.instance.FindPlayerVRRig(A_6);
			A_10 = vrrig;
			bool flag = A_10 != null;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 7 + 898;
			A_0 = num;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x000325E0 File Offset: 0x000307E0
		private static void CMSSECTIONIDDIRECTORYSECTIONgetIetfLanguageTag(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			bool flag = false;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 4 + 179;
			A_0 = num;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0003263C File Offset: 0x0003083C
		private static void getFilterGetFileSystemEntries(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			Object.Destroy(Mods.pointer);
			A_1 = 0;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00032660 File Offset: 0x00030860
		private static void GetInspectableFixupData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(Mods.jump_right_network[A_26]);
			int num = A_26 + 1;
			A_26 = num;
			bool flag = A_26 < Mods.jump_right_network.Length;
			A_27 = flag;
			int num2 = (A_27 ? 1 : 0) * -2 + 420;
			A_0 = num2;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00032700 File Offset: 0x00030900
		public static void GrabBat()
		{
			int num = 322;
			int num2 = 322;
			num2 = 322;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 322;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00032744 File Offset: 0x00030944
		private static void ICustomFactoryPrivateImplementationDetails(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5)
		{
			A_1 = 0;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0003275C File Offset: 0x0003095C
		private static void IBindableVectorPermitOnly(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			WristMenu.buttons[1].enabled = new bool?(false);
			WristMenu.DestroyMenu();
			WristMenu.instance.Draw();
			List<string> list = new List<string>();
			A_4 = list;
			List<ButtonInfo>.Enumerator enumerator = WristMenu.buttons.GetEnumerator();
			A_5 = enumerator;
			A_0 = 354;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x000327D8 File Offset: 0x000309D8
		private static void DispIdAttributeViewAccessControl(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			bool flag = false;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 4 + 187;
			A_0 = num;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00032834 File Offset: 0x00030A34
		private static void ResourceTableMappingFinalStringMappedStringBuffer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			bool flag = GameObject.Find("CameraTablet(Clone)") != null;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 339;
			A_0 = num;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0003289C File Offset: 0x00030A9C
		private static void RemoveAuditSpecificAssemblyBuilder(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref Vector3 A_5)
		{
			Mods.smth46 = Time.time + 0.05f;
			int num = ((!WristMenu.gripDownL) ? 1 : 0) * 1 + 74;
			A_0 = num;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000328F0 File Offset: 0x00030AF0
		private static void SchemaVersionIMPLTYPEFLAGS(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.jumpMultiplier = 1f;
			Player.Instance.maxJumpSpeed = 1f;
			A_1 = 0;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00032928 File Offset: 0x00030B28
		private static void GetElementTypeIsNullOrEmpty(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			bool flag = true;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 901;
			A_0 = num;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00032984 File Offset: 0x00030B84
		private static void IdentityReferencegetInvariantCulture(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			Mods.lastLeft[A_4] = A_6.leftHandTransform.position;
			int num = (A_5.MoveNext() ? 1 : 0) * -8 + 792;
			A_0 = num;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x000329F4 File Offset: 0x00030BF4
		private static void SatellitegetInvariantCultureIgnoreCase(ref int A_0, ref int A_1, ref int A_2)
		{
			PhotonNetwork.Disconnect();
			A_1 = 0;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00032A14 File Offset: 0x00030C14
		private static void ResourceManagerCaseInsensitiveResourceStreamLookupSucceededsetApplicationName(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			int num = (A_19.MoveNext() ? 1 : 0) * -10 + 721;
			A_0 = num;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00032A5C File Offset: 0x00030C5C
		private static List<VRRig> AttributeNativeRegisterRelative(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			Mods.validRigs.Clear();
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_4 = enumerator;
			A_0 = 878;
			List<VRRig> result;
			return result;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00032AA8 File Offset: 0x00030CA8
		private static void FrameSecurityDescriptorWithResolvergetSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			int num = ((A_9 < A_8.Length) ? 1 : 0) * -2 + 49;
			A_0 = num;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00032AE4 File Offset: 0x00030CE4
		private static void getClaimsPrincipalSelectorCheckSubKeyReadPermission(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref MeshCollider[] A_5, ref int A_6, ref MeshCollider A_7, ref MeshCollider[] A_8, ref int A_9, ref MeshCollider A_10)
		{
			MeshCollider[] array = Resources.FindObjectsOfTypeAll<MeshCollider>();
			A_5 = array;
			int num = 0;
			A_6 = num;
			A_0 = 737;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00032B2C File Offset: 0x00030D2C
		private static void ToSerializedStringGetRuntimeMethod(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			Mods.balll2 = Time.time + 3.5f;
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_5 = enumerator;
			A_0 = 831;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00032B78 File Offset: 0x00030D78
		private static void CompareExchangesetChannelUris(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			List<VRRig>.Enumerator enumerator = GorillaParent.instance.vrrigs.GetEnumerator();
			A_4 = enumerator;
			A_0 = 193;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00032BB4 File Offset: 0x00030DB4
		private static void AppendsetWindowHeight(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			int num = ((A_4 < A_3.Length) ? 1 : 0) * -4 + 271;
			A_0 = num;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00032BF0 File Offset: 0x00030DF0
		private static void getMinorVersionopDivision(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 608;
			A_0 = num;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00032C4C File Offset: 0x00030E4C
		private static void HasValueCallerFilePathAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00032C64 File Offset: 0x00030E64
		private static void ParseDisplayNameIsVirtual(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("SnowballProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00032CA8 File Offset: 0x00030EA8
		private static void getOutArgsEtwManifestEventFormat(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("MoltenSlingshot_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.magenta, false);
			A_1 = 0;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00032CEC File Offset: 0x00030EEC
		private static void AssemblyKeyFileAttributeSyncRoot(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00032D04 File Offset: 0x00030F04
		private static void DllImportSearchPathUnbox(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			bool flag = true;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 838;
			A_0 = num;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00032D60 File Offset: 0x00030F60
		public unsafe static void Changeidentity()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 845;
			int num4 = 845;
			num4 = 845;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 4)
					{
						num4 = 845;
						if ((int)array[7] != 1)
						{
							num5 = (int)array[4];
							num6 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num5 + 56 + num2);
							for (num7 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + (int)array[5] + 56 + num2) + 72 + num2); num7 != num6; num7 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num7 + 72 + num2))
							{
								num8 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num7 + 64 + num2);
								if (num8 != -1)
								{
									num9 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num8 + 16 + num2);
									array[5] = num8;
									array[2] = 2;
									num3 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num8 + 16 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[1];
							num9 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num5 + 16 + num2);
							ex2 = ex;
							array = (object[])array[0];
							array2 = new object[]
							{
								null,
								null,
								null,
								null,
								null,
								null,
								null,
								0
							};
							array2[0] = array;
							array2[1] = ex;
							array2[5] = num5;
							array2[2] = 1;
							array = array2;
							num3 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num5 + 16 + num2);
							continue;
						}
						num10 = (int)array[3];
						array = (object[])array[0];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 5)
						{
							Color color;
							bool flag;
							string text;
							List<ButtonInfo>.Enumerator enumerator;
							ButtonInfo buttonInfo;
							bool flag2;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,UnityEngine.Color&,System.Boolean&,System.String&,System.Collections.Generic.List`1/Enumerator<ShibaGTTemplate.UI.ButtonInfo>&,ShibaGTTemplate.UI.ButtonInfo&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref color, ref flag, ref text, ref enumerator, ref buttonInfo, ref flag2, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 845;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 152 + num15 * 72 + 64 + num2);
						num17 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 152 + num15 * 72 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 152 + num7 * 72 + 48 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 152 + num14 * 72 + 64 + num2);
						num6 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 152 + num14 * 72 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 152 + num7 * 72 + 48 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 368 + num15 * 48 + 40 + num2);
						num17 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 368 + num15 * 48 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 368 + num7 * 48 + 32 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9C5:
						if (array == null || (int)array[7] == 1)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num6 + 72 + num2);
								}
								else
								{
									num10 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num18 + 64 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num18 + 72 + num2);
									goto IL_9C5;
								}
							}
							goto IL_B60;
						}
						int num19 = (int)array[5];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num18 + 24 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 368 + num15 * 48 + 40 + num2);
								num10 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 368 + num15 * 48 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 368 + num5 * 48 + 32 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num7 + 72 + num2);
								}
								else
								{
									num5 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num18 + 64 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num18 + 72 + num2);
									goto IL_9C5;
								}
							}
							break;
						}
						if ((int)array[5] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[0];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num5 + 16 + num2);
					array2 = new object[]
					{
						null,
						null,
						null,
						null,
						null,
						null,
						null,
						1
					};
					array2[0] = array;
					array2[3] = num11;
					array2[5] = num5;
					array2[2] = 2;
					array = array2;
					num3 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num5 + 16 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B60:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num10 + 16 + num2);
					array2 = new object[]
					{
						null,
						null,
						null,
						null,
						null,
						null,
						null,
						1
					};
					array2[0] = array;
					array2[3] = num11;
					array2[5] = num10;
					array2[2] = 2;
					array = array2;
					num3 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num10 + 16 + num2);
				}
				num4 = 845;
				return;
				IL_1CA:
				if (num6 != -1)
				{
					goto IL_1D5;
				}
				goto IL_3FA;
				IL_1D5:
				num7 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num6 + num2);
				if (4 == num7)
				{
					goto IL_1F1;
				}
				if (0 == num7)
				{
					goto IL_383;
				}
				goto IL_3FA;
				IL_1F1:
				num9 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num6 + 40 + num2);
				if (num9 == -1)
				{
					goto IL_23F;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_225;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_225:
				if (type.IsInstanceOfType(array2[1]))
				{
					goto IL_23F;
				}
				num6 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num6 + 48 + num2);
				goto IL_1CA;
				IL_23F:
				num5 = num6;
				num8 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num5 + 56 + num2) + 72 + num2);
				num13 = (int)array2[6];
				IL_263:
				if (num13 != num8)
				{
					goto IL_2E2;
				}
				int num22 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num5 + 16 + num2);
				ex2 = array2[1];
				array = (object[])array[0];
				object[] array5 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array5[0] = array;
				array5[1] = array2[1];
				array5[6] = (int)array2[6];
				array5[5] = num5;
				array5[2] = 1;
				array = array5;
				num3 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num5 + 16 + num2);
				goto IL_23;
				IL_2E2:
				num18 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num13 + 64 + num2);
				if (num18 == -1)
				{
					goto IL_371;
				}
				num22 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num18 + 16 + num2);
				array = (object[])array[0];
				array5 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array5[0] = array;
				array5[1] = array2[1];
				array5[6] = (int)array2[6];
				array5[5] = num18;
				array5[4] = num5;
				array5[2] = 2;
				array = array5;
				num3 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num18 + 16 + num2);
				goto IL_23;
				IL_371:
				num13 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num13 + 72 + num2);
				goto IL_263;
				IL_383:
				num22 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num6 + 8 + num2);
				ex2 = array2[1];
				array = (object[])array[0];
				array5 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array5[0] = array;
				array5[1] = array2[1];
				array5[6] = (int)array2[6];
				array5[5] = num6;
				array5[2] = 0;
				array = array5;
				num3 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num6 + 8 + num2);
				goto IL_23;
				IL_3FA:
				array = (object[])array[0];
				Exception ex3 = array2[1];
				int num23 = (int)array2[6];
				IL_419:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_427:
				num14 = (num21 + num10) / 2;
				num15 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 152 + num14 * 72 + 64 + num2);
				num16 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 152 + num14 * 72 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_46A;
				}
				if (num15 > num22)
				{
					goto IL_472;
				}
				num8 = num14;
				num5 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 152 + num8 * 72 + 48 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_49A;
				IL_46A:
				num21 = num14 + 1;
				goto IL_427;
				IL_472:
				num10 = num14 - 1;
				goto IL_427;
				IL_49A:
				if (array != null)
				{
					goto IL_4A5;
				}
				goto IL_62E;
				IL_4A5:
				if ((int)array[7] != 1)
				{
					goto IL_562;
				}
				int num24 = (int)array[5];
				if (num9 != -1)
				{
					goto IL_4C9;
				}
				int num25 = -1;
				goto IL_549;
				IL_4C9:
				num17 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num9 + 24 + num2);
				num16 = 0;
				num15 = 2;
				IL_4DC:
				num14 = (num16 + num15) / 2;
				num10 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 368 + num14 * 48 + 40 + num2);
				num21 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 368 + num14 * 48 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_51F;
				}
				if (num10 > num17)
				{
					goto IL_527;
				}
				num5 = num14;
				num8 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 368 + num5 * 48 + 32 + num2);
				num25 = num8;
				goto IL_549;
				IL_51F:
				num16 = num14 + 1;
				goto IL_4DC;
				IL_527:
				num15 = num14 - 1;
				goto IL_4DC;
				IL_549:
				if (num24 != num25)
				{
					goto IL_551;
				}
				goto IL_62E;
				IL_551:
				array = (object[])array[0];
				goto IL_49A;
				IL_562:
				num18 = (int)array[2];
				if (num18 == 1 || num18 == 2)
				{
					goto IL_583;
				}
				if (num18 != 0)
				{
					goto IL_582;
				}
				array2 = array;
				num6 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + (int)array2[5] + 48 + num2);
				goto IL_1CA;
				IL_582:
				IL_583:
				int num26 = (int)array[5];
				if (num9 != -1)
				{
					goto IL_598;
				}
				int num27 = -1;
				goto IL_618;
				IL_598:
				num22 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num9 + 24 + num2);
				num21 = 0;
				num10 = 2;
				IL_5AB:
				num14 = (num21 + num10) / 2;
				num15 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 368 + num14 * 48 + 40 + num2);
				num16 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 368 + num14 * 48 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5EE;
				}
				if (num15 > num22)
				{
					goto IL_5F6;
				}
				num8 = num14;
				num5 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + 368 + num8 * 48 + 32 + num2);
				num27 = num5;
				goto IL_618;
				IL_5EE:
				num21 = num14 + 1;
				goto IL_5AB;
				IL_5F6:
				num10 = num14 - 1;
				goto IL_5AB;
				IL_618:
				if (num26 != num27)
				{
					goto IL_61D;
				}
				goto IL_62E;
				IL_61D:
				array = (object[])array[0];
				goto IL_49A;
				IL_62E:
				if (-1 != num9)
				{
					goto IL_63A;
				}
				int num28 = 1;
				throw ex3;
				IL_63A:
				num7 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num9 + num2);
				num10 = num7;
				IL_648:
				if (num10 != -1)
				{
					goto IL_65F;
				}
				num9 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num9 + 72 + num2);
				goto IL_49A;
				IL_65F:
				num15 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num10 + num2);
				if (4 == num15)
				{
					goto IL_687;
				}
				if (0 == num15)
				{
					goto IL_7F5;
				}
				num9 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num9 + 72 + num2);
				goto IL_49A;
				IL_687:
				num14 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num10 + 40 + num2);
				if (num14 == -1)
				{
					goto IL_6D6;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6BB;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6BB:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6D6;
				}
				num10 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num10 + 48 + num2);
				goto IL_648;
				IL_6D6:
				num5 = num10;
				num8 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num5 + 56 + num2) + 72 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_6FF:
				if (num17 != num8)
				{
					goto IL_768;
				}
				num21 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num5 + 16 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array2[0] = array;
				array2[1] = ex3;
				array2[6] = num13;
				array2[5] = num5;
				array2[2] = 1;
				array = array2;
				num3 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num5 + 16 + num2);
				goto IL_23;
				IL_768:
				num16 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num17 + 64 + num2);
				if (num16 == -1)
				{
					goto IL_7E3;
				}
				num21 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num16 + 16 + num2);
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array2[0] = array;
				array2[1] = ex3;
				array2[6] = num13;
				array2[5] = num16;
				array2[4] = num5;
				array2[2] = 2;
				array = array2;
				num3 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num16 + 16 + num2);
				goto IL_23;
				IL_7E3:
				num17 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num17 + 72 + num2);
				goto IL_6FF;
				IL_7F5:
				num21 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num10 + 8 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array2[0] = array;
				array2[1] = ex3;
				array2[6] = num13;
				array2[5] = num10;
				array2[2] = 0;
				array = array2;
				num3 = *(ref getResolvedAssembliesRawDefaultValue.XNameDoNotAddrOfCspParentWindowHandle + num10 + 8 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_419;
				}
				throw ex4;
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00033988 File Offset: 0x00031B88
		private static void WinRTClassActivatorGetVarDesc(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 620;
			A_0 = num;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000339E4 File Offset: 0x00031BE4
		private static void RuntimeModuleRemotingConfigInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = A_26 < Mods.jump_right_network.Length;
			A_27 = flag;
			int num = (A_27 ? 1 : 0) * -2 + 420;
			A_0 = num;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00033A4C File Offset: 0x00031C4C
		private static void UCOMIBindCtxFailed(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color red = Color.red;
			A_4 = red;
			bool flag = A_5 == 4;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 115;
			A_0 = num;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00033ACC File Offset: 0x00031CCC
		private static void ProgIdRedirectionRedirectedGuidForegroundMask(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			Mods.weufewfjdfjn = true;
			A_1 = 0;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00033AF0 File Offset: 0x00031CF0
		public static void Noclip()
		{
			int num = 158;
			int num2 = 158;
			num2 = 158;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				MeshCollider[] array;
				int num4;
				MeshCollider meshCollider;
				MeshCollider[] array2;
				int num5;
				MeshCollider meshCollider2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.MeshCollider[]&,System.Int32&,UnityEngine.MeshCollider&,UnityEngine.MeshCollider[]&,System.Int32&,UnityEngine.MeshCollider&), ref num, ref num2, ref num3, ref flag, ref array, ref num4, ref meshCollider, ref array2, ref num5, ref meshCollider2, Mods.ControlThreadBadData[num]);
			}
			num2 = 158;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00033B40 File Offset: 0x00031D40
		private static void setWrapNonExceptionThrowsProcessorFallbackListValid(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -8 + 792;
			A_0 = num;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00033B88 File Offset: 0x00031D88
		private static string RegistryAccessRuleCOREISOSTORE(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			bool flag = A_3.ToString().Contains("basement");
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 285;
			A_0 = num;
			string result;
			return result;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00033BFC File Offset: 0x00031DFC
		public static void Beacons()
		{
			int num = 232;
			int num2 = 232;
			num2 = 232;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Player[] array;
				int num4;
				Player player;
				PhotonView photonView;
				VRRig vrrig;
				bool flag2;
				GameObject gameObject;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,Photon.Realtime.Player[]&,System.Int32&,Photon.Realtime.Player&,Photon.Pun.PhotonView&,VRRig&,System.Boolean&,UnityEngine.GameObject&), ref num, ref num2, ref num3, ref flag, ref array, ref num4, ref player, ref photonView, ref vrrig, ref flag2, ref gameObject, Mods.ControlThreadBadData[num]);
			}
			num2 = 232;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00033C50 File Offset: 0x00031E50
		private static void LocalDataStoreICustomProperty(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 614;
			A_0 = num;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00033CAC File Offset: 0x00031EAC
		private static void CollectionBaseVARDESC(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref Vector3 A_5)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_4 = gripDownR;
			int num = ((!A_4) ? 1 : 0) * 1 + 76;
			A_0 = num;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00033D0C File Offset: 0x00031F0C
		private static void ICMSUpdateKwdTriggers(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.fpcc = false;
			bool flag = Mods.funn != null;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 342;
			A_0 = num;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00033D78 File Offset: 0x00031F78
		public static void offrainbow()
		{
			int num = 66;
			int num2 = 66;
			num2 = 66;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 66;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00033DB0 File Offset: 0x00031FB0
		private static void VolumeSeparatorCharBufferWidth(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color white = Color.white;
			A_4 = white;
			bool flag = A_5 == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 136;
			A_0 = num;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00033E30 File Offset: 0x00032030
		private static void DaylightBiasSetLastWriteTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1);
			A_0 = 807;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00033E7C File Offset: 0x0003207C
		private static void NAMEMoveBufferArea(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00033E94 File Offset: 0x00032094
		private static void LongRunningCommand(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = new Color32(byte.MaxValue, 0, 0, 1);
			Player.Instance.GetComponent<Rigidbody>().transform.position = Mods.pointer.transform.position;
			Player.Instance.headCollider.transform.position = Mods.pointer.transform.position;
			Mods.pointer.GetComponent<Renderer>().material.color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1);
			A_0 = 487;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00033F5C File Offset: 0x0003215C
		private static void InlineBrTargetGCHandleType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref GorillaTagManager[] A_7, ref int A_8, ref GorillaTagManager A_9, ref bool A_10)
		{
			int num = A_8 + 1;
			A_8 = num;
			int num2 = ((A_8 < A_7.Length) ? 1 : 0) * -4 + 448;
			A_0 = num2;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00033FBC File Offset: 0x000321BC
		private static void InheritedObjectAceTypeGetOtherMethods(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = false;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 415;
			A_0 = num;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00034018 File Offset: 0x00032218
		private static void TextWriterSetActorAsReferenceWhenCopyingClaimsIdentity(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			bool gripDownL = WristMenu.gripDownL;
			A_5 = gripDownL;
			int num = ((!A_5) ? 1 : 0) * 1 + 687;
			A_0 = num;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00034074 File Offset: 0x00032274
		private static void NotSupportedSortedListNestedWriteEnvoySinks(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -4 + 359;
			A_0 = num;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000340BC File Offset: 0x000322BC
		private static void DisallowCodeDownloadForced(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			int num = A_7 + 1;
			A_7 = num;
			int num2 = ((A_7 < A_6.Length) ? 1 : 0) * -4 + 925;
			A_0 = num2;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0003411C File Offset: 0x0003231C
		public static void HoldRocket()
		{
			int num = 872;
			int num2 = 872;
			num2 = 872;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 872;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00034160 File Offset: 0x00032360
		private static void DowngradeFromWriterLockMissingMemberException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			Mods.BetaFireProjectileDelay("SnowballProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.magenta, false);
			bool gripDownL = WristMenu.gripDownL;
			A_5 = gripDownL;
			int num = ((!A_5) ? 1 : 0) * 1 + 687;
			A_0 = num;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000341E8 File Offset: 0x000323E8
		private static void TimeZoneUtcSetAccessRuleProtection(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			bool flag = !A_10.mainSkin.material.name.Contains("fected");
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 903;
			A_0 = num;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00034268 File Offset: 0x00032468
		private static void GetValueDirectFormatterConverter(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			A_1 = 5;
			A_2 = 231;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0003428C File Offset: 0x0003248C
		private static void GetAssemblyEvidenceFileSourceName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref MeshCollider[] A_4, ref int A_5, ref MeshCollider A_6, ref MeshCollider[] A_7, ref int A_8, ref MeshCollider A_9)
		{
			MeshCollider meshCollider = A_4[A_5];
			A_6 = meshCollider;
			A_6.enabled = false;
			int num = A_5 + 1;
			A_5 = num;
			int num2 = ((A_5 < A_4.Length) ? 1 : 0) * -2 + 162;
			A_0 = num2;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00034324 File Offset: 0x00032524
		private static void DiscretionaryAclPresentGenerateAssemblyEvidence(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 587;
			A_0 = num;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00034380 File Offset: 0x00032580
		private static List<VRRig> KoreanEraBaseChannelSinkWithProperties(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			List<VRRig> list = Mods.validRigs;
			A_7 = list;
			A_0 = 890;
			List<VRRig> result;
			return result;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x000343B4 File Offset: 0x000325B4
		private static void ListDictionaryInternalInlineNone(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			int num = (A_19.MoveNext() ? 1 : 0) * -10 + 721;
			A_0 = num;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000343FC File Offset: 0x000325FC
		private static void GetITypeInfoForTypeKeySpec(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			Mods.ropedelay = Time.time + 0.1f;
			A_1 = 0;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00034424 File Offset: 0x00032624
		private static void DayOfYearAclRevisionDS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GameObject.Find("Floating ornament Holdable").transform.position = Player.Instance.rightControllerTransform.position;
			A_1 = 0;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00034464 File Offset: 0x00032664
		private static string SetEnvironmentVariableCreatorOwnerServerSid(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			bool flag = A_3.ToString().Contains("beach");
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 281;
			A_0 = num;
			string result;
			return result;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000344D8 File Offset: 0x000326D8
		private static void SerializedStreamHeaderEndFullTrustZoneTrusted(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref bool A_7, ref PhotonView A_8)
		{
			Player[] playerList = PhotonNetwork.PlayerList;
			A_4 = playerList;
			int num = 0;
			A_5 = num;
			A_0 = 475;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00034520 File Offset: 0x00032720
		private static void lprgscodewMinorVerNum(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			A_1 = 0;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00034538 File Offset: 0x00032738
		private static void CryptAcquireContextFlagsworkStealingQueue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("BucketGiftSquare", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_18 = gripDownR;
			int num = ((!A_18) ? 1 : 0) * 1 + 545;
			A_0 = num;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000345C0 File Offset: 0x000327C0
		public static void MentosSpam()
		{
			int num = 628;
			int num2 = 628;
			num2 = 628;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 628;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00034604 File Offset: 0x00032804
		private static void XRestoreFlow(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			Transform child = A_5.GetChild(A_6);
			A_7 = child;
			int num = ((!A_7.gameObject.name.Contains("Anchor")) ? 1 : 0) * 1 + 748;
			A_0 = num;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00034688 File Offset: 0x00032888
		public static void MentosSpamSS()
		{
			int num = 679;
			int num2 = 679;
			num2 = 679;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 679;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000346CC File Offset: 0x000328CC
		private static void HaveSecondCryptographicException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			bool flag = Mods.pointer == null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 44;
			A_0 = num;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00034734 File Offset: 0x00032934
		private static void MethodImplAttributesEnter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.red;
			A_0 = 465;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00034768 File Offset: 0x00032968
		private static void PinnableBufferCacheSetCOMIUnknown(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			bool flag = A_5 < A_4.Length;
			A_10 = flag;
			int num = (A_10 ? 1 : 0) * -2 + 174;
			A_0 = num;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000347D4 File Offset: 0x000329D4
		public static void BetaFireProjectile(string projectileName, Vector3 position, Vector3 velocity, Color color, bool noDelay = false)
		{
			int num = 500;
			int num2 = 500;
			num2 = 500;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Vector3 vector;
				Vector3 vector2;
				Vector3 vector3;
				SnowballThrowable snowballThrowable;
				Vector3 vector4;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Vector3&,SnowballThrowable&,UnityEngine.Vector3&,System.Boolean&,UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Color,System.String,System.Boolean), ref num, ref num2, ref num3, ref flag, ref vector, ref vector2, ref vector3, ref snowballThrowable, ref vector4, ref flag2, position, velocity, color, projectileName, noDelay, Mods.ControlThreadBadData[num]);
			}
			num2 = 500;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0003482C File Offset: 0x00032A2C
		private static void LargestWindowWidthSetValueDirect(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref MeshCollider[] A_5, ref int A_6, ref MeshCollider A_7, ref MeshCollider[] A_8, ref int A_9, ref MeshCollider A_10)
		{
			MeshCollider meshCollider = A_5[A_6];
			A_7 = meshCollider;
			A_7.enabled = false;
			int num = A_6 + 1;
			A_6 = num;
			int num2 = ((A_6 < A_5.Length) ? 1 : 0) * -2 + 738;
			A_0 = num2;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000348C4 File Offset: 0x00032AC4
		private static void NamedArgumentsKnownAce(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 197;
			A_0 = num;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00034920 File Offset: 0x00032B20
		public static void GrabRig()
		{
			int num = 26;
			int num2 = 26;
			num2 = 26;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, Mods.ControlThreadBadData[num]);
			}
			num2 = 26;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0003495C File Offset: 0x00032B5C
		private static void setApplicationEvidenceOnSerializingAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 638;
			A_0 = num;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x000349B8 File Offset: 0x00032BB8
		private static string AsDecimalScopeName(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			bool flag = A_3.ToString().Contains("cave");
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 279;
			A_0 = num;
			string result;
			return result;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00034A2C File Offset: 0x00032C2C
		private static void GetApplicationComponentManifestcancellationToken(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref MethodInfo A_6, ref object A_7)
		{
			Player[] playerListOthers = PhotonNetwork.PlayerListOthers;
			A_3 = playerListOthers;
			int num = 0;
			A_4 = num;
			A_0 = 292;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00034A74 File Offset: 0x00032C74
		public static void LagSelf()
		{
			int num = 809;
			int num2 = 809;
			num2 = 809;
			while (num2 != 0)
			{
				int num3;
				PhotonView photonView;
				GorillaNot gorillaNot;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,Photon.Pun.PhotonView&,GorillaNot&), ref num, ref num2, ref num3, ref photonView, ref gorillaNot, Mods.ControlThreadBadData[num]);
			}
			num2 = 809;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00034ABC File Offset: 0x00032CBC
		private static void DecodeHexStringSetCachePath(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			int num = (A_16.MoveNext() ? 1 : 0) * -8 + 764;
			A_0 = num;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00034B04 File Offset: 0x00032D04
		private static void tailHighsetShortestDayNames(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("SnowballProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_7 = gripDownR;
			int num = ((!A_7) ? 1 : 0) * 1 + 523;
			A_0 = num;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00034B8C File Offset: 0x00032D8C
		public unsafe static void Save()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 344;
			int num4 = 344;
			num4 = 344;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 4)
					{
						num4 = 344;
						if ((int)array[5] != 1)
						{
							num5 = (int)array[1];
							num6 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num5 + 48 + num2);
							for (num7 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + (int)array[4] + 48 + num2) + 48 + num2); num7 != num6; num7 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num7 + 48 + num2))
							{
								num8 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num7 + 40 + num2);
								if (num8 != -1)
								{
									num9 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num8 + num2);
									array[4] = num8;
									array[0] = 2;
									num3 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num8 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[6];
							num9 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num5 + num2);
							ex2 = ex;
							array = (object[])array[2];
							array2 = new object[8];
							array2[5] = 0;
							array2[2] = array;
							array2[6] = ex;
							array2[4] = num5;
							array2[0] = 1;
							array = array2;
							num3 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num5 + num2);
							continue;
						}
						num10 = (int)array[7];
						array = (object[])array[2];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 1)
						{
							List<string> list;
							List<ButtonInfo>.Enumerator enumerator;
							ButtonInfo buttonInfo;
							bool? flag;
							bool flag2;
							bool flag3;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1<System.String>&,System.Collections.Generic.List`1/Enumerator<ShibaGTTemplate.UI.ButtonInfo>&,ShibaGTTemplate.UI.ButtonInfo&,System.Nullable`1<System.Boolean>&,System.Boolean&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref list, ref enumerator, ref buttonInfo, ref flag, ref flag2, ref flag3, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 344;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 152 + num15 * 64 + 40 + num2);
						num17 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 152 + num15 * 64 + 16 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 152 + num7 * 64 + 32 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 152 + num14 * 64 + 40 + num2);
						num6 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 152 + num14 * 64 + 16 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 152 + num7 * 64 + 32 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 344 + num15 * 40 + 24 + num2);
						num17 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 344 + num15 * 40 + 8 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 344 + num7 * 40 + 16 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9B7:
						if (array == null || (int)array[5] == 1)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num6 + 48 + num2);
								}
								else
								{
									num10 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num18 + 40 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num18 + 48 + num2);
									goto IL_9B7;
								}
							}
							goto IL_B4B;
						}
						int num19 = (int)array[4];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num18 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 344 + num15 * 40 + 24 + num2);
								num10 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 344 + num15 * 40 + 8 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 344 + num5 * 40 + 16 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num7 + 48 + num2);
								}
								else
								{
									num5 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num18 + 40 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num18 + 48 + num2);
									goto IL_9B7;
								}
							}
							break;
						}
						if ((int)array[4] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[2];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num5 + num2);
					array2 = new object[8];
					array2[5] = 1;
					array2[2] = array;
					array2[7] = num11;
					array2[4] = num5;
					array2[0] = 2;
					array = array2;
					num3 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num5 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B4B:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num10 + num2);
					array2 = new object[8];
					array2[5] = 1;
					array2[2] = array;
					array2[7] = num11;
					array2[4] = num10;
					array2[0] = 2;
					array = array2;
					num3 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num10 + num2);
				}
				num4 = 344;
				return;
				IL_1BE:
				if (num6 != -1)
				{
					goto IL_1C9;
				}
				goto IL_3E7;
				IL_1C9:
				num7 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num6 + 16 + num2);
				if (3 == num7)
				{
					goto IL_1E8;
				}
				if (1 == num7)
				{
					goto IL_36E;
				}
				goto IL_3E7;
				IL_1E8:
				num9 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num6 + 40 + num2);
				if (num9 == -1)
				{
					goto IL_236;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_21C;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_21C:
				if (type.IsInstanceOfType(array2[6]))
				{
					goto IL_236;
				}
				num6 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num6 + 56 + num2);
				goto IL_1BE;
				IL_236:
				num5 = num6;
				num8 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num5 + 48 + num2) + 48 + num2);
				num13 = (int)array2[3];
				IL_25A:
				if (num13 != num8)
				{
					goto IL_2D3;
				}
				int num22 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num5 + num2);
				ex2 = array2[6];
				array = (object[])array[2];
				object[] array5 = new object[8];
				array5[5] = 0;
				array5[2] = array;
				array5[6] = array2[6];
				array5[3] = (int)array2[3];
				array5[4] = num5;
				array5[0] = 1;
				array = array5;
				num3 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num5 + num2);
				goto IL_23;
				IL_2D3:
				num18 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num13 + 40 + num2);
				if (num18 == -1)
				{
					goto IL_35C;
				}
				num22 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num18 + num2);
				array = (object[])array[2];
				array5 = new object[8];
				array5[5] = 0;
				array5[2] = array;
				array5[6] = array2[6];
				array5[3] = (int)array2[3];
				array5[4] = num18;
				array5[1] = num5;
				array5[0] = 2;
				array = array5;
				num3 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num18 + num2);
				goto IL_23;
				IL_35C:
				num13 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num13 + 48 + num2);
				goto IL_25A;
				IL_36E:
				num22 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num6 + 32 + num2);
				ex2 = array2[6];
				array = (object[])array[2];
				array5 = new object[8];
				array5[5] = 0;
				array5[2] = array;
				array5[6] = array2[6];
				array5[3] = (int)array2[3];
				array5[4] = num6;
				array5[0] = 0;
				array = array5;
				num3 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num6 + 32 + num2);
				goto IL_23;
				IL_3E7:
				array = (object[])array[2];
				Exception ex3 = array2[6];
				int num23 = (int)array2[3];
				IL_406:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_414:
				num14 = (num21 + num10) / 2;
				num15 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 152 + num14 * 64 + 40 + num2);
				num16 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 152 + num14 * 64 + 16 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_45A;
				}
				if (num15 > num22)
				{
					goto IL_462;
				}
				num8 = num14;
				num5 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 152 + num8 * 64 + 32 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_48A;
				IL_45A:
				num21 = num14 + 1;
				goto IL_414;
				IL_462:
				num10 = num14 - 1;
				goto IL_414;
				IL_48A:
				if (array != null)
				{
					goto IL_495;
				}
				goto IL_61C;
				IL_495:
				if ((int)array[5] != 1)
				{
					goto IL_551;
				}
				int num24 = (int)array[4];
				if (num9 != -1)
				{
					goto IL_4B9;
				}
				int num25 = -1;
				goto IL_538;
				IL_4B9:
				num17 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num9 + num2);
				num16 = 0;
				num15 = 2;
				IL_4C9:
				num14 = (num16 + num15) / 2;
				num10 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 344 + num14 * 40 + 24 + num2);
				num21 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 344 + num14 * 40 + 8 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_50E;
				}
				if (num10 > num17)
				{
					goto IL_516;
				}
				num5 = num14;
				num8 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 344 + num5 * 40 + 16 + num2);
				num25 = num8;
				goto IL_538;
				IL_50E:
				num16 = num14 + 1;
				goto IL_4C9;
				IL_516:
				num15 = num14 - 1;
				goto IL_4C9;
				IL_538:
				if (num24 != num25)
				{
					goto IL_540;
				}
				goto IL_61C;
				IL_540:
				array = (object[])array[2];
				goto IL_48A;
				IL_551:
				num18 = (int)array[0];
				if (num18 == 1 || num18 == 2)
				{
					goto IL_572;
				}
				if (num18 != 0)
				{
					goto IL_571;
				}
				array2 = array;
				num6 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + (int)array2[4] + 56 + num2);
				goto IL_1BE;
				IL_571:
				IL_572:
				int num26 = (int)array[4];
				if (num9 != -1)
				{
					goto IL_587;
				}
				int num27 = -1;
				goto IL_606;
				IL_587:
				num22 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num9 + num2);
				num21 = 0;
				num10 = 2;
				IL_597:
				num14 = (num21 + num10) / 2;
				num15 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 344 + num14 * 40 + 24 + num2);
				num16 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 344 + num14 * 40 + 8 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5DC;
				}
				if (num15 > num22)
				{
					goto IL_5E4;
				}
				num8 = num14;
				num5 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + 344 + num8 * 40 + 16 + num2);
				num27 = num5;
				goto IL_606;
				IL_5DC:
				num21 = num14 + 1;
				goto IL_597;
				IL_5E4:
				num10 = num14 - 1;
				goto IL_597;
				IL_606:
				if (num26 != num27)
				{
					goto IL_60B;
				}
				goto IL_61C;
				IL_60B:
				array = (object[])array[2];
				goto IL_48A;
				IL_61C:
				if (-1 != num9)
				{
					goto IL_628;
				}
				int num28 = 1;
				throw ex3;
				IL_628:
				num7 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num9 + 16 + num2);
				num10 = num7;
				IL_639:
				if (num10 != -1)
				{
					goto IL_650;
				}
				num9 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num9 + 48 + num2);
				goto IL_48A;
				IL_650:
				num15 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num10 + 16 + num2);
				if (3 == num15)
				{
					goto IL_67B;
				}
				if (1 == num15)
				{
					goto IL_7DD;
				}
				num9 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num9 + 48 + num2);
				goto IL_48A;
				IL_67B:
				num14 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num10 + 40 + num2);
				if (num14 == -1)
				{
					goto IL_6CA;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6AF;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6AF:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6CA;
				}
				num10 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num10 + 56 + num2);
				goto IL_639;
				IL_6CA:
				num5 = num10;
				num8 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num5 + 48 + num2) + 48 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_6F3:
				if (num17 != num8)
				{
					goto IL_756;
				}
				num21 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num5 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[5] = 0;
				array2[2] = array;
				array2[6] = ex3;
				array2[3] = num13;
				array2[4] = num5;
				array2[0] = 1;
				array = array2;
				num3 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num5 + num2);
				goto IL_23;
				IL_756:
				num16 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num17 + 40 + num2);
				if (num16 == -1)
				{
					goto IL_7CB;
				}
				num21 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num16 + num2);
				array2 = new object[8];
				array2[5] = 0;
				array2[2] = array;
				array2[6] = ex3;
				array2[3] = num13;
				array2[4] = num16;
				array2[1] = num5;
				array2[0] = 2;
				array = array2;
				num3 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num16 + num2);
				goto IL_23;
				IL_7CB:
				num17 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num17 + 48 + num2);
				goto IL_6F3;
				IL_7DD:
				num21 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num10 + 32 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[5] = 0;
				array2[2] = array;
				array2[6] = ex3;
				array2[3] = num13;
				array2[4] = num10;
				array2[0] = 0;
				array = array2;
				num3 = *(ref AcquireReaderLockUnmanagedMemoryStream.UpdateTimerCodebase + num10 + 32 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_406;
				}
				throw ex4;
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00035798 File Offset: 0x00033998
		private static void thisResolveSystemPolicy(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			int num = (A_6.MoveNext() ? 1 : 0) * -9 + 229;
			A_0 = num;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x000357E0 File Offset: 0x000339E0
		private static void setXmlNamespacegetIsThreadPoolThread(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = ((A_6 < A_5.Length) ? 1 : 0) * -10 + 373;
			A_0 = num;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0003581C File Offset: 0x00033A1C
		private static void WriteAsyncGetStandardSandbox(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref GameObject A_5, ref GameObject A_6)
		{
			bool rightControllerSecondaryButton = ControllerInputPoller.instance.rightControllerSecondaryButton;
			A_3 = rightControllerSecondaryButton;
			bool flag = A_3;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 257;
			A_0 = num;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0003589C File Offset: 0x00033A9C
		private static void ClaimsPrincipalDESCKINDFUNCDESC(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color black = Color.black;
			A_4 = black;
			Mods.ChangeMonkColor(A_4);
			Mods.flushmanually();
			A_1 = 0;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000358E4 File Offset: 0x00033AE4
		private static void getCalendarsetDigestAlgorithm(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color cyan = Color.cyan;
			A_4 = cyan;
			bool flag = A_5 == 7;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 146;
			A_0 = num;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00035964 File Offset: 0x00033B64
		private static void IsEventIFormatProvider(ref int A_0, ref int A_1, ref int A_2, PhotonView A_3)
		{
			PhotonNetwork.OpCleanActorRpcBuffer(A_3.Owner.ActorNumber);
			PhotonNetwork.OpCleanRpcBuffer(A_3);
			A_1 = 0;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0003599C File Offset: 0x00033B9C
		public static void LobbyHop()
		{
			int num = 808;
			int num2 = 808;
			num2 = 808;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 808;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000359E0 File Offset: 0x00033BE0
		public Mods()
		{
			int num = 932;
			int num2 = 932;
			num2 = 932;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.Mods), ref num, ref num2, ref num3, this, Mods.ControlThreadBadData[num]);
			}
			num2 = 932;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00035A24 File Offset: 0x00033C24
		private static void SuppressIldasmAttributeOpcodes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			Mods.pointer = GameObject.CreatePrimitive(0);
			Object.Destroy(Mods.pointer.GetComponent<Rigidbody>());
			Object.Destroy(Mods.pointer.GetComponent<SphereCollider>());
			Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			Mods.pointer.transform.position = A_5.point;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 4 + 46;
			A_0 = num;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00035B18 File Offset: 0x00033D18
		private static void AddPropertyGenericAcl(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 10;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 1 + 102;
			A_0 = num;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00035B80 File Offset: 0x00033D80
		private static void IsCompatibilityBehaviorDefinedDemand(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			PhotonView photonView = ((GorillaRopeSwing)A_4[A_5]).photonView;
			A_6 = photonView;
			string text = "SetVelocity";
			A_7 = text;
			RpcTarget rpcTarget = 0;
			A_8 = rpcTarget;
			object[] array = new object[4];
			A_9 = array;
			A_9[0] = 10;
			A_9[1] = new Vector3((float)Random.Range(10, 415169), (float)Random.Range(10, 241161099), (float)Random.Range(10, 3826319));
			A_9[2] = true;
			A_6.RPC(A_7, A_8, A_9);
			Mods.flushmanually();
			int num = A_5 + 1;
			A_5 = num;
			bool flag = A_5 < A_4.Length;
			A_10 = flag;
			int num2 = (A_10 ? 1 : 0) * -2 + 182;
			A_0 = num2;
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00035D30 File Offset: 0x00033F30
		private static void cancellationTokenHashtableDebugView(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref GorillaTagManager[] A_7, ref int A_8, ref GorillaTagManager A_9, ref bool A_10)
		{
			int num = A_5 + 1;
			A_5 = num;
			int num2 = ((A_5 < A_4.Length) ? 1 : 0) * -7 + 450;
			A_0 = num2;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00035D90 File Offset: 0x00033F90
		private static void BidiCategoryUnrestricted(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GorillaRopeSwing[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			A_1 = 0;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00035DA8 File Offset: 0x00033FA8
		private static void setActivationArgumentssetUsageAllowed(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref Vector3 A_5)
		{
			bool flag = false;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 76;
			A_0 = num;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00035E04 File Offset: 0x00034004
		private static void OnNextInterfaceForwardingSupport(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00035E1C File Offset: 0x0003401C
		private static void BuiltinUsersSidPublisherMembershipCondition(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			GorillaFriendCollider gorillaFriendCollider = A_8[A_9];
			A_10 = gorillaFriendCollider;
			A_5.collider.GetComponent<GorillaComputer>().OnGroupJoinButtonPress(Random.RandomRange(1, 3), A_10);
			int num = A_9 + 1;
			A_9 = num;
			int num2 = ((A_9 < A_8.Length) ? 1 : 0) * -2 + 49;
			A_0 = num2;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00035ECC File Offset: 0x000340CC
		private static void getFriendlyNamePROCESSORIDARRAY(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00035EE4 File Offset: 0x000340E4
		private static void FUNCVIRTUALBeginScope(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("HornsSlingshotProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_6 = gripDownR;
			int num = ((!A_6) ? 1 : 0) * 1 + 554;
			A_0 = num;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00035F6C File Offset: 0x0003416C
		private static void getLargeObjectHeapCompactionModeStartProfile(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("BucketGiftRound", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00035FB0 File Offset: 0x000341B0
		private static void setCurrencyGroupSeparatorTimeZoneInfoOptions(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			Debug.LogError("Odd error, no name");
			int num = A_9 + 1;
			A_9 = num;
			bool flag = A_9 < A_7.childCount;
			A_22 = flag;
			int num2 = (A_22 ? 1 : 0) * -21 + 772;
			A_0 = num2;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00036050 File Offset: 0x00034250
		private static void NegClone(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			Player player = A_11[A_12];
			A_13 = player;
			string text = string.Concat(new string[]
			{
				A_10,
				"/nPlayer Name: ",
				A_13.NickName,
				" , Player ID: ",
				A_13.UserId
			});
			A_10 = text;
			int num = A_12 + 1;
			A_12 = num;
			int num2 = ((A_12 < A_11.Length) ? 1 : 0) * -2 + 804;
			A_0 = num2;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00036144 File Offset: 0x00034344
		private static void TYPEFLAGFCANCREATENotOnCanceled(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = (A_8.MoveNext() ? 1 : 0) * -4 + 381;
			A_0 = num;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0003618C File Offset: 0x0003438C
		public static void LagGun()
		{
			int num = 453;
			int num2 = 453;
			num2 = 453;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				RaycastHit raycastHit;
				bool flag3;
				bool flag4;
				GorillaFriendCollider[] array;
				int num4;
				GorillaFriendCollider gorillaFriendCollider;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,UnityEngine.RaycastHit&,System.Boolean&,System.Boolean&,GorillaFriendCollider[]&,System.Int32&,GorillaFriendCollider&), ref num, ref num2, ref num3, ref flag, ref flag2, ref raycastHit, ref flag3, ref flag4, ref array, ref num4, ref gorillaFriendCollider, Mods.ControlThreadBadData[num]);
			}
			num2 = 453;
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000361E0 File Offset: 0x000343E0
		private static void MonitoringTotalAllocatedMemorySizeBgtUnS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref GorillaTagManager[] A_7, ref int A_8, ref GorillaTagManager A_9, ref bool A_10)
		{
			A_0 = 452;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000361F8 File Offset: 0x000343F8
		private static void setClipboardgetRefusedSet(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			A_5.randomizeColor = true;
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -4 + 271;
			A_0 = num2;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0003626C File Offset: 0x0003446C
		private static void EnumSByteTypeInfosetOutputEncoding(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("MoltenSlingshot_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x000362B0 File Offset: 0x000344B0
		private static void getProxyTypeNameBinaryObject(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref MeshCollider[] A_5, ref int A_6, ref MeshCollider A_7, ref MeshCollider[] A_8, ref int A_9, ref MeshCollider A_10)
		{
			MeshCollider meshCollider = A_8[A_9];
			A_10 = meshCollider;
			A_10.enabled = true;
			int num = A_9 + 1;
			A_9 = num;
			int num2 = ((A_9 < A_8.Length) ? 1 : 0) * -2 + 742;
			A_0 = num2;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00036348 File Offset: 0x00034548
		public static void fpc()
		{
			int num = 336;
			int num2 = 336;
			num2 = 336;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, Mods.ControlThreadBadData[num]);
			}
			num2 = 336;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00036390 File Offset: 0x00034590
		private static void EnterpriseControllersSidToStringArray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = Mods.jump_left_local != null;
			A_23 = flag;
			int num = ((!A_23) ? 1 : 0) * 1 + 415;
			A_0 = num;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000363F8 File Offset: 0x000345F8
		public static void Kickgun()
		{
			int num = 428;
			int num2 = 428;
			num2 = 428;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				RaycastHit raycastHit;
				bool flag3;
				bool flag4;
				GorillaFriendCollider[] array;
				int num4;
				GorillaFriendCollider gorillaFriendCollider;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,UnityEngine.RaycastHit&,System.Boolean&,System.Boolean&,GorillaFriendCollider[]&,System.Int32&,GorillaFriendCollider&), ref num, ref num2, ref num3, ref flag, ref flag2, ref raycastHit, ref flag3, ref flag4, ref array, ref num4, ref gorillaFriendCollider, Mods.ControlThreadBadData[num]);
			}
			num2 = 428;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0003644C File Offset: 0x0003464C
		private static string MinimumLevelsetXML(ref int A_0, ref int A_1, ref int A_2, ref string A_3, ref int A_4, ref bool A_5, ref bool A_6, ref string A_7)
		{
			string text = A_3 + Mods.roomCharacters.Substring(Random.Range(0, Mods.roomCharacters.Length), 1);
			A_3 = text;
			int num = A_4 + 1;
			A_4 = num;
			bool flag = A_4 < 7;
			A_5 = flag;
			int num2 = (A_5 ? 1 : 0) * -2 + 859;
			A_0 = num2;
			string result;
			return result;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0003651C File Offset: 0x0003471C
		private static void IsFaultedgetPermissionState(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Color A_4, ref bool A_5, ref string A_6, ref List<ButtonInfo>.Enumerator A_7, ref ButtonInfo A_8, ref bool A_9)
		{
			A_1 = 5;
			A_2 = 854;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00036540 File Offset: 0x00034740
		private static void getSubcategoryGenGcCallback(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color clear = Color.clear;
			A_4 = clear;
			bool flag = A_5 == 9;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 125;
			A_0 = num;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000365C0 File Offset: 0x000347C0
		private static void SetAllDateTimePatternsBoolean(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref MeshCollider[] A_5, ref int A_6, ref MeshCollider A_7, ref MeshCollider[] A_8, ref int A_9, ref MeshCollider A_10)
		{
			int num = ((A_9 < A_8.Length) ? 1 : 0) * -2 + 742;
			A_0 = num;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000365FC File Offset: 0x000347FC
		private static void VARKINDRuntimeTypeHandle(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			((IDisposable)A_5).Dispose();
			A_1 = 4;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00036624 File Offset: 0x00034824
		private static void UnicodeByteArrayHideScheduler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 515;
			A_0 = num;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00036680 File Offset: 0x00034880
		private static void IsAbstractReadOnlyDictionaryHelpers(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = !PhotonNetwork.InRoom;
			A_25 = flag;
			int num = ((!A_25) ? 1 : 0) * 7 + 417;
			A_0 = num;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x000366E4 File Offset: 0x000348E4
		public static void AllSpamersCS()
		{
			int num = 547;
			int num2 = 547;
			num2 = 547;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				bool flag7;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				bool flag12;
				bool flag13;
				bool flag14;
				bool flag15;
				bool flag16;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref flag7, ref flag8, ref flag9, ref flag10, ref flag11, ref flag12, ref flag13, ref flag14, ref flag15, ref flag16, Mods.ControlThreadBadData[num]);
			}
			num2 = 547;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00036748 File Offset: 0x00034948
		public unsafe static List<VRRig> GetValidChoosableRigs()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 877;
			int num4 = 877;
			num4 = 877;
			List<VRRig> result;
			try
			{
				IL_23:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 1)
					{
						num4 = 877;
						if ((int)array[7] != 1)
						{
							num5 = (int)array[1];
							num6 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num5 + 80 + num2);
							for (num7 = *(ref BaseOctetCustomMarshaler.VariantgetToday + *(ref BaseOctetCustomMarshaler.VariantgetToday + (int)array[6] + 80 + num2) + 80 + num2); num7 != num6; num7 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num7 + 80 + num2))
							{
								num8 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num7 + 72 + num2);
								if (num8 != -1)
								{
									num9 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num8 + 8 + num2);
									array[6] = num8;
									array[0] = 2;
									num3 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num8 + 8 + num2);
									goto IL_23;
								}
							}
							Exception ex = (Exception)array[5];
							num9 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num5 + 8 + num2);
							ex2 = ex;
							array = (object[])array[3];
							array2 = new object[]
							{
								null,
								null,
								null,
								null,
								null,
								null,
								null,
								0
							};
							array2[3] = array;
							array2[5] = ex;
							array2[6] = num5;
							array2[0] = 0;
							array = array2;
							num3 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num5 + 8 + num2);
							continue;
						}
						num10 = (int)array[2];
						array = (object[])array[3];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 5)
						{
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag;
							List<VRRig> list;
							result = calli(System.Collections.Generic.List`1<VRRig>(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&,System.Collections.Generic.List`1<VRRig>&), ref num3, ref num4, ref num12, ex2, ref enumerator, ref vrrig, ref flag, ref list, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 877;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 176 + num15 * 80 + 72 + num2);
						num17 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 176 + num15 * 80 + 40 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 176 + num7 * 80 + 64 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 176 + num14 * 80 + 72 + num2);
						num6 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 176 + num14 * 80 + 40 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 176 + num7 * 80 + 64 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 416 + num15 * 40 + 32 + num2);
						num17 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 416 + num15 * 40 + 16 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 416 + num7 * 40 + 24 + num2);
					num8 = num5;
					for (;;)
					{
						IL_9D4:
						if (array == null || (int)array[7] == 1)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num6 + 80 + num2);
								}
								else
								{
									num10 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num18 + 72 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num18 + 80 + num2);
									goto IL_9D4;
								}
							}
							goto IL_B6F;
						}
						int num19 = (int)array[6];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num18 + 8 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 416 + num15 * 40 + 32 + num2);
								num10 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 416 + num15 * 40 + 16 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 416 + num5 * 40 + 24 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num7 + 80 + num2);
								}
								else
								{
									num5 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num18 + 72 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num18 + 80 + num2);
									goto IL_9D4;
								}
							}
							break;
						}
						if ((int)array[6] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[3];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num5 + 8 + num2);
					array2 = new object[]
					{
						null,
						null,
						null,
						null,
						null,
						null,
						null,
						1
					};
					array2[3] = array;
					array2[2] = num11;
					array2[6] = num5;
					array2[0] = 2;
					array = array2;
					num3 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num5 + 8 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B6F:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num10 + 8 + num2);
					array2 = new object[]
					{
						null,
						null,
						null,
						null,
						null,
						null,
						null,
						1
					};
					array2[3] = array;
					array2[2] = num11;
					array2[6] = num10;
					array2[0] = 2;
					array = array2;
					num3 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num10 + 8 + num2);
				}
				num4 = 877;
				return result;
				IL_1C4:
				if (num6 != -1)
				{
					goto IL_1CF;
				}
				goto IL_3F5;
				IL_1CF:
				num7 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num6 + 40 + num2);
				if (4 == num7)
				{
					goto IL_1EE;
				}
				if (2 == num7)
				{
					goto IL_37C;
				}
				goto IL_3F5;
				IL_1EE:
				num9 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num6 + 72 + num2);
				if (num9 == -1)
				{
					goto IL_23C;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_222;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_222:
				if (type.IsInstanceOfType(array2[5]))
				{
					goto IL_23C;
				}
				num6 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num6 + 56 + num2);
				goto IL_1C4;
				IL_23C:
				num5 = num6;
				num8 = *(ref BaseOctetCustomMarshaler.VariantgetToday + *(ref BaseOctetCustomMarshaler.VariantgetToday + num5 + 80 + num2) + 80 + num2);
				num13 = (int)array2[4];
				IL_260:
				if (num13 != num8)
				{
					goto IL_2DD;
				}
				int num22 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num5 + 8 + num2);
				ex2 = array2[5];
				array = (object[])array[3];
				object[] array5 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array5[3] = array;
				array5[5] = array2[5];
				array5[4] = (int)array2[4];
				array5[6] = num5;
				array5[0] = 0;
				array = array5;
				num3 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num5 + 8 + num2);
				goto IL_23;
				IL_2DD:
				num18 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num13 + 72 + num2);
				if (num18 == -1)
				{
					goto IL_36A;
				}
				num22 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num18 + 8 + num2);
				array = (object[])array[3];
				array5 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array5[3] = array;
				array5[5] = array2[5];
				array5[4] = (int)array2[4];
				array5[6] = num18;
				array5[1] = num5;
				array5[0] = 2;
				array = array5;
				num3 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num18 + 8 + num2);
				goto IL_23;
				IL_36A:
				num13 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num13 + 80 + num2);
				goto IL_260;
				IL_37C:
				num22 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num6 + 64 + num2);
				ex2 = array2[5];
				array = (object[])array[3];
				array5 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array5[3] = array;
				array5[5] = array2[5];
				array5[4] = (int)array2[4];
				array5[6] = num6;
				array5[0] = 1;
				array = array5;
				num3 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num6 + 64 + num2);
				goto IL_23;
				IL_3F5:
				array = (object[])array[3];
				Exception ex3 = array2[5];
				int num23 = (int)array2[4];
				IL_414:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_422:
				num14 = (num21 + num10) / 2;
				num15 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 176 + num14 * 80 + 72 + num2);
				num16 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 176 + num14 * 80 + 40 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_468;
				}
				if (num15 > num22)
				{
					goto IL_470;
				}
				num8 = num14;
				num5 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 176 + num8 * 80 + 64 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_498;
				IL_468:
				num21 = num14 + 1;
				goto IL_422;
				IL_470:
				num10 = num14 - 1;
				goto IL_422;
				IL_498:
				if (array != null)
				{
					goto IL_4A3;
				}
				goto IL_630;
				IL_4A3:
				if ((int)array[7] != 1)
				{
					goto IL_562;
				}
				int num24 = (int)array[6];
				if (num9 != -1)
				{
					goto IL_4C7;
				}
				int num25 = -1;
				goto IL_549;
				IL_4C7:
				num17 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num9 + 8 + num2);
				num16 = 0;
				num15 = 2;
				IL_4D9:
				num14 = (num16 + num15) / 2;
				num10 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 416 + num14 * 40 + 32 + num2);
				num21 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 416 + num14 * 40 + 16 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_51F;
				}
				if (num10 > num17)
				{
					goto IL_527;
				}
				num5 = num14;
				num8 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 416 + num5 * 40 + 24 + num2);
				num25 = num8;
				goto IL_549;
				IL_51F:
				num16 = num14 + 1;
				goto IL_4D9;
				IL_527:
				num15 = num14 - 1;
				goto IL_4D9;
				IL_549:
				if (num24 != num25)
				{
					goto IL_551;
				}
				goto IL_630;
				IL_551:
				array = (object[])array[3];
				goto IL_498;
				IL_562:
				num18 = (int)array[0];
				if (num18 == 0 || num18 == 2)
				{
					goto IL_583;
				}
				if (num18 != 1)
				{
					goto IL_582;
				}
				array2 = array;
				num6 = *(ref BaseOctetCustomMarshaler.VariantgetToday + (int)array2[6] + 56 + num2);
				goto IL_1C4;
				IL_582:
				IL_583:
				int num26 = (int)array[6];
				if (num9 != -1)
				{
					goto IL_598;
				}
				int num27 = -1;
				goto IL_61A;
				IL_598:
				num22 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num9 + 8 + num2);
				num21 = 0;
				num10 = 2;
				IL_5AA:
				num14 = (num21 + num10) / 2;
				num15 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 416 + num14 * 40 + 32 + num2);
				num16 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 416 + num14 * 40 + 16 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5F0;
				}
				if (num15 > num22)
				{
					goto IL_5F8;
				}
				num8 = num14;
				num5 = *(ref BaseOctetCustomMarshaler.VariantgetToday + 416 + num8 * 40 + 24 + num2);
				num27 = num5;
				goto IL_61A;
				IL_5F0:
				num21 = num14 + 1;
				goto IL_5AA;
				IL_5F8:
				num10 = num14 - 1;
				goto IL_5AA;
				IL_61A:
				if (num26 != num27)
				{
					goto IL_61F;
				}
				goto IL_630;
				IL_61F:
				array = (object[])array[3];
				goto IL_498;
				IL_630:
				if (-1 != num9)
				{
					goto IL_63C;
				}
				int num28 = 1;
				throw ex3;
				IL_63C:
				num7 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num9 + 40 + num2);
				num10 = num7;
				IL_64D:
				if (num10 != -1)
				{
					goto IL_664;
				}
				num9 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num9 + 80 + num2);
				goto IL_498;
				IL_664:
				num15 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num10 + 40 + num2);
				if (4 == num15)
				{
					goto IL_68F;
				}
				if (2 == num15)
				{
					goto IL_7F9;
				}
				num9 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num9 + 80 + num2);
				goto IL_498;
				IL_68F:
				num14 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num10 + 72 + num2);
				if (num14 == -1)
				{
					goto IL_6DE;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_6C3;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_6C3:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6DE;
				}
				num10 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num10 + 56 + num2);
				goto IL_64D;
				IL_6DE:
				num5 = num10;
				num8 = *(ref BaseOctetCustomMarshaler.VariantgetToday + *(ref BaseOctetCustomMarshaler.VariantgetToday + num5 + 80 + num2) + 80 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_707:
				if (num17 != num8)
				{
					goto IL_76E;
				}
				num21 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num5 + 8 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array2[3] = array;
				array2[5] = ex3;
				array2[4] = num13;
				array2[6] = num5;
				array2[0] = 0;
				array = array2;
				num3 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num5 + 8 + num2);
				goto IL_23;
				IL_76E:
				num16 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num17 + 72 + num2);
				if (num16 == -1)
				{
					goto IL_7E7;
				}
				num21 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num16 + 8 + num2);
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array2[3] = array;
				array2[5] = ex3;
				array2[4] = num13;
				array2[6] = num16;
				array2[1] = num5;
				array2[0] = 2;
				array = array2;
				num3 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num16 + 8 + num2);
				goto IL_23;
				IL_7E7:
				num17 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num17 + 80 + num2);
				goto IL_707;
				IL_7F9:
				num21 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num10 + 64 + num2);
				ex2 = ex3;
				array2 = new object[]
				{
					null,
					null,
					null,
					null,
					null,
					null,
					null,
					0
				};
				array2[3] = array;
				array2[5] = ex3;
				array2[4] = num13;
				array2[6] = num10;
				array2[0] = 1;
				array = array2;
				num3 = *(ref BaseOctetCustomMarshaler.VariantgetToday + num10 + 64 + num2);
				goto IL_23;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_414;
				}
				throw ex4;
			}
			return result;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0003737C File Offset: 0x0003557C
		private static void getIIDGuidEventSourceException(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			bool flag = false;
			A_8 = flag;
			bool flag2 = A_8;
			A_9 = flag2;
			int num = ((!A_9) ? 1 : 0) * 22 + 706;
			A_0 = num;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000373F4 File Offset: 0x000355F4
		private static void ParameterTokenBuiltIn(ref int A_0, ref int A_1, ref int A_2)
		{
			Mods.rainboww = false;
			A_1 = 0;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00037418 File Offset: 0x00035618
		private static void getCodebaseMscorlibCollectionDebugView(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_8 = gripDownR;
			int num = ((!A_8) ? 1 : 0) * 1 + 558;
			A_0 = num;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00037474 File Offset: 0x00035674
		private static void getImplementedClsidAsyncMessageHelper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("BucketGiftRound", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_17 = gripDownR;
			int num = ((!A_17) ? 1 : 0) * 1 + 543;
			A_0 = num;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x000374FC File Offset: 0x000356FC
		private static void ProviderNamesThreadLocal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref PhotonView A_7, ref VRRig A_8, ref bool A_9, ref GameObject A_10)
		{
			Player player = A_4[A_5];
			A_6 = player;
			PhotonView photonView = GorillaGameManager.instance.FindVRRigForPlayer(A_6);
			A_7 = photonView;
			VRRig vrrig = GorillaGameManager.instance.FindPlayerVRRig(A_6);
			A_8 = vrrig;
			int num = (A_8.isOfflineVRRig ? 1 : 0) * 2 + 235;
			A_0 = num;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000375B4 File Offset: 0x000357B4
		private static void AllowCurrencySymbolPrivateBinPath(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			A_1 = 0;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000375CC File Offset: 0x000357CC
		private static void PARAMFLAGFOUTNotHandled(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 668;
			A_0 = num;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00037628 File Offset: 0x00035828
		private static void CreateAppDomainLevelAccountDomainGuestsSid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			Mods.funn = GameObject.Find("Third Person Camera");
			Mods.funn.SetActive(false);
			bool flag = GameObject.Find("CameraTablet(Clone)") != null;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 1 + 339;
			A_0 = num;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000376B0 File Offset: 0x000358B0
		private static void TYPEFLAGFREVERSEBINDSetBufferSize(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.jumpMultiplier = 1.3f;
			Player.Instance.maxJumpSpeed = 7.5f;
			A_1 = 0;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x000376E8 File Offset: 0x000358E8
		private static void ReadCharsAssemblyNameFlags(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaTagger.Instance.offlineVRRig.transform.position = GorillaTagger.Instance.bodyCollider.transform.position;
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			A_1 = 0;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00037740 File Offset: 0x00035940
		private static void CategoryMembershipSubcategoryMembershipsetHostCanGenerate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color magenta = Color.magenta;
			A_4 = magenta;
			bool flag = A_5 == 6;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 119;
			A_0 = num;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x000377C0 File Offset: 0x000359C0
		private static void IIDIEnumSTOREDEPLOYMENTMETADATAReplacementCultures(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000377D8 File Offset: 0x000359D8
		private static void getFailureKindShr(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("ElfBow_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_10 = gripDownR;
			int num = ((!A_10) ? 1 : 0) * 1 + 529;
			A_0 = num;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00037860 File Offset: 0x00035A60
		private static void FieldEntryTokenSandBoxInert(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref bool A_6, ref float A_7, ref bool A_8, ref bool A_9)
		{
			int num = ((A_4 < A_3.Length) ? 1 : 0) * -8 + 827;
			A_0 = num;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0003789C File Offset: 0x00035A9C
		private static void SecurityStateUnhandledException(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -8 + 215;
			A_0 = num;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000378E4 File Offset: 0x00035AE4
		public static void WaterGun()
		{
			int num = 488;
			int num2 = 488;
			num2 = 488;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				RaycastHit raycastHit;
				bool flag3;
				bool flag4;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,UnityEngine.RaycastHit&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref flag2, ref raycastHit, ref flag3, ref flag4, Mods.ControlThreadBadData[num]);
			}
			num2 = 488;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00037930 File Offset: 0x00035B30
		private static void EventLogClassicMicrosoftTelemetry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref MeshCollider[] A_4, ref int A_5, ref MeshCollider A_6, ref MeshCollider[] A_7, ref int A_8, ref MeshCollider A_9)
		{
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0.4f;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 4 + 159;
			A_0 = num;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0003799C File Offset: 0x00035B9C
		private static void SetAuditgetIsNotPublic(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Color A_4, ref bool A_5, ref string A_6, ref List<ButtonInfo>.Enumerator A_7, ref ButtonInfo A_8, ref bool A_9)
		{
			Mods.namelist.Clear();
			WristMenu.DestroyMenu();
			WristMenu.instance.Draw();
			A_1 = 0;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000379D0 File Offset: 0x00035BD0
		public static void fpcoff()
		{
			int num = 341;
			int num2 = 341;
			num2 = 341;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 341;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00037A14 File Offset: 0x00035C14
		private static void OffEnumBuilder(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			bool flag = Mods.pointer != null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 696;
			A_0 = num;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00037A78 File Offset: 0x00035C78
		private static void ICMSNewobj(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			Mods.pointer = GameObject.CreatePrimitive(0);
			Object.Destroy(Mods.pointer.GetComponent<Rigidbody>());
			Object.Destroy(Mods.pointer.GetComponent<SphereCollider>());
			Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			Mods.pointer.transform.position = A_4.point;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 484;
			A_0 = num;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00037B50 File Offset: 0x00035D50
		private static void StrongNameTokenFromAssemblysetPersist(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -4 + 350;
			A_0 = num;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00037B98 File Offset: 0x00035D98
		private static void CompletedsetTimeSeparator(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			bool flag = A_6.playerText.text != PhotonNetwork.LocalPlayer.NickName;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 1 + 59;
			A_0 = num;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00037C18 File Offset: 0x00035E18
		private static void IsDirtygetLengthInTextElements(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			Mods.pointer.transform.position = A_4.point;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 484;
			A_0 = num;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00037C9C File Offset: 0x00035E9C
		private static string RandomRoomName()
		{
			int num = 856;
			int num2 = 856;
			num2 = 856;
			string result;
			while (num2 != 0)
			{
				int num3;
				string text;
				int num4;
				bool flag;
				bool flag2;
				string text2;
				result = calli(System.String(System.Int32&,System.Int32&,System.Int32&,System.String&,System.Int32&,System.Boolean&,System.Boolean&,System.String&), ref num, ref num2, ref num3, ref text, ref num4, ref flag, ref flag2, ref text2, Mods.ControlThreadBadData[num]);
			}
			num2 = 856;
			return result;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00037CEC File Offset: 0x00035EEC
		private static void SpecificCulturesgetSupportsDaylightSavingTime(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("MoltenSlingshot_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_13 = gripDownR;
			int num = ((!A_13) ? 1 : 0) * 1 + 568;
			A_0 = num;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00037D74 File Offset: 0x00035F74
		private static void GetTagSmuggledMethodCallMessage(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			A_13.colorKeys = Mods.colorKeysPlatformMonke;
			A_0 = 908;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00037DA4 File Offset: 0x00035FA4
		private static void LeftToRightEmbeddingFAggregatable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_13 = gripDownR;
			int num = ((!A_13) ? 1 : 0) * 1 + 568;
			A_0 = num;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00037E00 File Offset: 0x00036000
		private static void GetCurrentThreadIdEndsWith(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			A_0 = 702;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00037E18 File Offset: 0x00036018
		private static void AssemblyRequestpermissionSetIDEncodedEnumType(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			bool triggerDownL = WristMenu.triggerDownL;
			A_4 = triggerDownL;
			int num = ((!A_4) ? 1 : 0) * 11 + 54;
			A_0 = num;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00037E74 File Offset: 0x00036074
		private static void CurrentIMap(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			A_0 = 214;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00037E8C File Offset: 0x0003608C
		public static void ChangeColorFreeMenuMain()
		{
			int num = 21;
			int num2 = 21;
			num2 = 21;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 21;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00037EC4 File Offset: 0x000360C4
		private static void ConsoleSpecialKeyAssemblyReferenceDependentAssembly(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = A_6 + 1;
			A_6 = num;
			int num2 = ((A_6 < A_5.Length) ? 1 : 0) * -10 + 373;
			A_0 = num2;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00037F24 File Offset: 0x00036124
		private static void FromIdMatchExactVersion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00037F3C File Offset: 0x0003613C
		public static void ChangeColor4()
		{
			int num = 24;
			int num2 = 24;
			num2 = 24;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 24;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00037F74 File Offset: 0x00036174
		private static void ReferenceIdentitygetUTF(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			string text = A_5[A_6];
			A_7 = text;
			List<ButtonInfo>.Enumerator enumerator = WristMenu.settingsbuttons.GetEnumerator();
			A_8 = enumerator;
			A_0 = 376;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00037FCC File Offset: 0x000361CC
		public static void BetaFireProjectileDelay(string projectileName, Vector3 position, Vector3 velocity, Color color, bool Delay = false)
		{
			int num = 507;
			int num2 = 507;
			num2 = 507;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Vector3 vector;
				Vector3 vector2;
				Vector3 vector3;
				SnowballThrowable snowballThrowable;
				Vector3 vector4;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.Vector3&,UnityEngine.Vector3&,UnityEngine.Vector3&,SnowballThrowable&,UnityEngine.Vector3&,System.Boolean&,UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Color,System.String,System.Boolean), ref num, ref num2, ref num3, ref flag, ref vector, ref vector2, ref vector3, ref snowballThrowable, ref vector4, ref flag2, position, velocity, color, projectileName, Delay, Mods.ControlThreadBadData[num]);
			}
			num2 = 507;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00038024 File Offset: 0x00036224
		private static void AddMethodTokenListCount(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Player.Instance.transform.position += Player.Instance.headCollider.transform.forward * Time.deltaTime * 20.5f;
			Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
			A_1 = 0;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00038098 File Offset: 0x00036298
		private static void TaskCompletionSourceDescription(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 86;
			A_0 = num;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00038100 File Offset: 0x00036300
		private static void SqmGetSrcItfType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			bool flag = A_3;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 10 + 796;
			A_0 = num;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00038180 File Offset: 0x00036380
		private static void getOptionalCalendarsPermissionTokenKeyComparer(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref bool A_7, ref PhotonView A_8)
		{
			bool triggerDownL = WristMenu.triggerDownL;
			A_3 = triggerDownL;
			int num = ((!A_3) ? 1 : 0) * 6 + 471;
			A_0 = num;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x000381DC File Offset: 0x000363DC
		private static void getEncodedEnumTypelptcomp(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("HornsSlingshotProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_6 = gripDownR;
			int num = ((!A_6) ? 1 : 0) * 1 + 521;
			A_0 = num;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00038264 File Offset: 0x00036464
		private static void OpFlagsStringBuilderAnsi(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			A_0 = 908;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00038280 File Offset: 0x00036480
		private static void NestedFamANDAssemsetPercentNegativePattern(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref ExecuteCloudScriptRequest A_5, ref string A_6, ref Hashtable A_7)
		{
			int num = ((!PhotonNetwork.IsConnectedAndReady) ? 1 : 0) * 1 + 310;
			A_0 = num;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x000382C4 File Offset: 0x000364C4
		private static void IServerChannelSinkgetProcessArchitecture(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			bool flag = !A_5.isMyPlayer;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 3 + 209;
			A_0 = num;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00038330 File Offset: 0x00036530
		private static void FreeHGlobalDeclaredFields(ref int A_0, ref int A_1, ref int A_2)
		{
			VRMap head = RigShit.GetOwnVRRig().head;
			head.trackingRotationOffset.y = head.trackingRotationOffset.y + 15f;
			A_1 = 1;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00038368 File Offset: 0x00036568
		private static void NaNSymbolRemotingMethodCachedData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_13 = gripDownR;
			int num = ((!A_13) ? 1 : 0) * 1 + 535;
			A_0 = num;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000383C4 File Offset: 0x000365C4
		private static void EnvironmentStringExpressionSetMergeLogic(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 584;
			A_0 = num;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00038420 File Offset: 0x00036620
		public static void AimBot()
		{
			int num = 912;
			int num2 = 912;
			num2 = 912;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				VRRig vrrig;
				bool flag2;
				SlingshotProjectile[] array;
				int num4;
				SlingshotProjectile slingshotProjectile;
				bool flag3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,VRRig&,System.Boolean&,SlingshotProjectile[]&,System.Int32&,SlingshotProjectile&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref vrrig, ref flag2, ref array, ref num4, ref slingshotProjectile, ref flag3, Mods.ControlThreadBadData[num]);
			}
			num2 = 912;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00038470 File Offset: 0x00036670
		private static string FullDateTimePatternTotalHours(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			bool flag = A_3.ToString().Contains("city");
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 275;
			A_0 = num;
			string result;
			return result;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000384E4 File Offset: 0x000366E4
		private static void ProcessorArchitectureUNKNOWNgrfMode(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 6;
			A_12 = flag;
			int num = ((!A_12) ? 1 : 0) * 1 + 144;
			A_0 = num;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0003854C File Offset: 0x0003674C
		private static void AppDomainIDsetDataPointer(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			A_0 = 349;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00038564 File Offset: 0x00036764
		private static void SetLastWriteTimeHasValue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 4;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 140;
			A_0 = num;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x000385CC File Offset: 0x000367CC
		private static void getCurrentPrincipalgetResolver(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 457;
			A_0 = num;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00038628 File Offset: 0x00036828
		private static void RevertAssertSetException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_11 = gripDownR;
			int num = ((!A_11) ? 1 : 0) * 1 + 531;
			A_0 = num;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00038684 File Offset: 0x00036884
		private static void getCommandMemberPrimitiveTyped(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			Player player = A_4[A_5];
			A_6 = player;
			int num = ((!A_6.CustomProperties.TryGetValue("NexuStar", out A_7)) ? 1 : 0) * 1 + 894;
			A_0 = num;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00038704 File Offset: 0x00036904
		private static void asyncWaiterLifetimeEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref GorillaTagManager[] A_7, ref int A_8, ref GorillaTagManager A_9, ref bool A_10)
		{
			Player[] playerListOthers = PhotonNetwork.PlayerListOthers;
			A_4 = playerListOthers;
			int num = 0;
			A_5 = num;
			A_0 = 449;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0003874C File Offset: 0x0003694C
		private static void CharUnknownLowEventHandlerType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			bool flag = Mods.jump_right_local == null;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 6 + 390;
			A_0 = num;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x000387B4 File Offset: 0x000369B4
		private static void PredicateObjectEqualityComparer(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			A_1 = 1;
			A_2 = 777;
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000387DC File Offset: 0x000369DC
		private static void GetCelestialStemCheckOpenSubKeyPermission(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 7;
			A_13 = flag;
			int num = ((!A_13) ? 1 : 0) * 1 + 146;
			A_0 = num;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00038844 File Offset: 0x00036A44
		private static void SuspendRequestedGetRefTypeInfo(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = A_6 + 1;
			A_6 = num;
			int num2 = ((A_6 < A_5.Length) ? 1 : 0) * -10 + 385;
			A_0 = num2;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000388A4 File Offset: 0x00036AA4
		private static void BackgroundRedEnumAssemblies(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			A_4 = A_10;
			A_5 = A_11;
			Vector3 velocity = GorillaTagger.Instance.GetComponent<Rigidbody>().velocity;
			A_6 = velocity;
			GorillaTagger.Instance.GetComponent<Rigidbody>().velocity = A_5;
			SnowballThrowable component = GameObject.Find("Player Objects/Local VRRig/Local Gorilla Player/rig/body/shoulder.R/upper_arm.R/forearm.R/hand.R/palm.01.R/TransferrableItemRightHand/SnowballRightAnchor").transform.Find("LMACF.").GetComponent<SnowballThrowable>();
			A_7 = component;
			Vector3 position = A_7.transform.position;
			A_8 = position;
			A_7.randomizeColor = true;
			GorillaTagger.Instance.offlineVRRig.SetThrowableProjectileColor(false, A_12);
			A_7.transform.position = A_4;
			A_7.projectilePrefab.tag = A_13;
			A_7.OnRelease(null, null);
			Mods.FlushRPCS();
			A_7.transform.position = A_8;
			GorillaTagger.Instance.GetComponent<Rigidbody>().velocity = A_6;
			A_7.randomizeColor = false;
			A_7.projectilePrefab.tag = "WaterballoonProjectile(Clone)";
			int num = (((Mods.projDebounceType > 1E+10f) ? 1 : 0) + -1) * -1 * 1 + 509;
			A_0 = num;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00038A74 File Offset: 0x00036C74
		private static List<VRRig> GetAsyncResultInteropXmlTypeEntry(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			bool flag = !(A_5 == null);
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 884;
			A_0 = num;
			List<VRRig> result;
			return result;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00038AEC File Offset: 0x00036CEC
		private static void DataCollectionStartgetGlobalAssemblyCache(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			A_1 = 0;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00038B04 File Offset: 0x00036D04
		private static void TextToReferenceFinalize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color yellow = Color.yellow;
			A_4 = yellow;
			bool flag = A_5 == 3;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 1 + 138;
			A_0 = num;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00038B84 File Offset: 0x00036D84
		private static void KeyedCollectionDXDSN(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6)
		{
			Mods.BetaFireProjectileDelay("ScienceCandyProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.green, false);
			bool gripDownR = WristMenu.gripDownR;
			A_4 = gripDownR;
			int num = ((!A_4) ? 1 : 0) * 1 + 685;
			A_0 = num;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00038C0C File Offset: 0x00036E0C
		private static void NetClientPOLICYCREATEPRIVILEGE(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 623;
			A_0 = num;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00038C68 File Offset: 0x00036E68
		private static void getIsReadOnlyStringIds(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			SlingshotProjectile[] componentsInChildren = GameObject.Find("Environment Objects/PersistentObjects_Prefab/GlobalObjectPools").GetComponentsInChildren<SlingshotProjectile>();
			A_6 = componentsInChildren;
			int num = 0;
			A_7 = num;
			A_0 = 924;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00038CB8 File Offset: 0x00036EB8
		private static void AssumeLocalThreadLocal(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref bool A_6, ref float A_7, ref bool A_8, ref bool A_9)
		{
			Player[] playerList = PhotonNetwork.PlayerList;
			A_3 = playerList;
			int num = 0;
			A_4 = num;
			A_0 = 826;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00038D00 File Offset: 0x00036F00
		private static void UnmappedIdentitiesSoapTypeAttribute(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			A_4.Add(A_6.buttonText);
			int num = (A_5.MoveNext() ? 1 : 0) * -4 + 350;
			A_0 = num;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00038D68 File Offset: 0x00036F68
		public static void impossibleColors()
		{
			int num = 698;
			int num2 = 698;
			num2 = 698;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 698;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00038DAC File Offset: 0x00036FAC
		private static void ApplicationDirectoryMembershipConditiongetIsFieldDef(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			Mods.smth496 = Time.time + 0.05f;
			VRRig rigFromPlayer = RigShit.GetRigFromPlayer(RigShit.GetRandomPlayer(false));
			A_4 = rigFromPlayer;
			int num = ((!A_4.mainSkin.material.name.Contains("orangealive")) ? 1 : 0) * 1 + 914;
			A_0 = num;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00038E3C File Offset: 0x0003703C
		private static void getExtraInfoSpinLock(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			int num = (A_5.MoveNext() ? 1 : 0) * -6 + 62;
			A_0 = num;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00038E84 File Offset: 0x00037084
		private static void ModuleResolveEventHandlerSerializationName(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref bool A_6, ref float A_7, ref bool A_8, ref bool A_9)
		{
			Player player = A_3[A_4];
			A_5 = player;
			bool flag = !GorillaGameManager.instance.FindPlayerVRRig(A_5).isMyPlayer;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 5 + 820;
			A_0 = num;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00038F20 File Offset: 0x00037120
		public static void freezerig()
		{
			int num = 778;
			int num2 = 778;
			num2 = 778;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 778;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00038F64 File Offset: 0x00037164
		private static void getCanReadProgramFiles(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5)
		{
			Player player = A_3[A_4];
			A_5 = player;
			Mods.pointer.transform.position = GorillaTagger.Instance.offlineVRRig.transform.position;
			Mods.pointer.transform.rotation = GorillaTagger.Instance.offlineVRRig.transform.rotation;
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -2 + 813;
			A_0 = num2;
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00039030 File Offset: 0x00037230
		private static void TopDESCKINDFUNCDESC(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_1 = 0;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00039048 File Offset: 0x00037248
		private static void InitobjUCOMIEnumString(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7)
		{
			A_0 = 61;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00039060 File Offset: 0x00037260
		private static void StatusMatchAllVersions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			A_0 = 908;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00039078 File Offset: 0x00037278
		private static void ToLowerCheckSubTreeWritePermission(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			A_1 = 0;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00039090 File Offset: 0x00037290
		private static void OnStartGetReader(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Color A_4, ref bool A_5, ref string A_6, ref List<ButtonInfo>.Enumerator A_7, ref ButtonInfo A_8, ref bool A_9)
		{
			string text = Mods.namelist[Random.Range(0, Mods.namelist.ToArray().Length)];
			A_6 = text;
			GorillaComputer.instance.offlineVRRigNametagText.text = A_6;
			PhotonNetwork.NickName = A_6;
			GorillaComputer.instance.savedName = A_6;
			PlayerPrefs.SetString("playerName", A_6);
			PlayerPrefs.Save();
			GorillaTagger.Instance.UpdateColor(A_4.r, A_4.g, A_4.b);
			GorillaTagger.Instance.myVRRig.RPC("InitializeNoobMaterial", 0, new object[]
			{
				A_4.r,
				A_4.g,
				A_4.b,
				false
			});
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			List<ButtonInfo>.Enumerator enumerator = WristMenu.buttons.GetEnumerator();
			A_7 = enumerator;
			A_0 = 847;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0003921C File Offset: 0x0003741C
		private static void SetCallContextSiteMembershipCondition(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool flag = Mods.balll2111 < Time.time;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 70;
			A_0 = num;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00039280 File Offset: 0x00037480
		private static void CleanUpNativeDatagetFileName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			A_0 = 52;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000392B4 File Offset: 0x000374B4
		private static void SyncStreamDidNotExist(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			int num = (A_4.MoveNext() ? 1 : 0) * -6 + 200;
			A_0 = num;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000392FC File Offset: 0x000374FC
		private static void getWritableTypegetBuildVersion(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4)
		{
			Mods.fpcc = true;
			bool flag = GameObject.Find("Third Person Camera") != null;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 337;
			A_0 = num;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00039370 File Offset: 0x00037570
		private static void GetImplTypeCustDatacbAlignment(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			VRRig vrrig = A_5.Current;
			A_6 = vrrig;
			bool flag = A_6 != GorillaTagger.Instance.offlineVRRig;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 5 + 785;
			A_0 = num;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000393FC File Offset: 0x000375FC
		private static Color INVOKEPROPERTYPUTREFNullTypeInfo(ref int A_0, ref int A_1, ref int A_2, ref Color A_3)
		{
			Color result = A_3;
			A_1 = 0;
			return result;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0003941C File Offset: 0x0003761C
		private static void DoubleQuotegetIsOut(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			A_1 = 0;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00039434 File Offset: 0x00037634
		private static void SameProcessSetGetMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 596;
			A_0 = num;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00039490 File Offset: 0x00037690
		private static void ImpersonateRank(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref MethodInfo A_6, ref object A_7)
		{
			A_1 = 0;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x000394A8 File Offset: 0x000376A8
		private static void NativeRegisterStackIWindowClassEntry(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x000394C0 File Offset: 0x000376C0
		private static void FixedSizeArrayListRestrictedCodeSid(ref int A_0, ref int A_1, ref int A_2)
		{
			WristMenu.FirstColor = Color.magenta;
			WristMenu.SecondColor = Color.black;
			A_1 = 0;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000394EC File Offset: 0x000376EC
		private static void CommonStartupArgsInArray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			int num = ((!A_3) ? 1 : 0) * 1 + 320;
			A_0 = num;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00039550 File Offset: 0x00037750
		private static void setExcludegetUI(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref ExecuteCloudScriptRequest A_5, ref string A_6, ref Hashtable A_7)
		{
			bool isConnected = PhotonNetwork.IsConnected;
			A_4 = isConnected;
			int num = ((!A_4) ? 1 : 0) * 1 + 312;
			A_0 = num;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x000395B0 File Offset: 0x000377B0
		private static void ReflectionMemberAccessNodeKeyValueEnumerator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("ScienceCandyProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000395F4 File Offset: 0x000377F4
		private static void StringArrayStateOrProvince(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			VRRig rigFromPlayer = RigShit.GetRigFromPlayer(RigShit.GetRandomPlayer(false));
			A_4 = rigFromPlayer;
			SlingshotProjectile[] componentsInChildren = GameObject.Find("Environment Objects/PersistentObjects_Prefab/GlobalObjectPools").GetComponentsInChildren<SlingshotProjectile>();
			A_6 = componentsInChildren;
			int num = 0;
			A_7 = num;
			A_0 = 924;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00039664 File Offset: 0x00037864
		private static void EtwManifestEventFormatFormatDouble(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			bool flag = true;
			A_28 = flag;
			bool flag2 = A_28;
			A_29 = flag2;
			int num = ((!A_29) ? 1 : 0) * 1 + 717;
			A_0 = num;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000396DC File Offset: 0x000378DC
		private static void getIsCanceledAppDomainManagerAssembly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("CupidBow_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_8 = gripDownR;
			int num = ((!A_8) ? 1 : 0) * 1 + 558;
			A_0 = num;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00039764 File Offset: 0x00037964
		private static void EnumAppPathAppendAllText(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			int num = (GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("blue") ? 1 : 0) * 3 + 834;
			A_0 = num;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000397C4 File Offset: 0x000379C4
		private static void setResponseXmlElementNameEmptyArray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_right_local = GameObject.CreatePrimitive(0);
			A_0 = 393;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x000397EC File Offset: 0x000379EC
		public static void IceSlingshotSpam()
		{
			int num = 595;
			int num2 = 595;
			num2 = 595;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 595;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00039830 File Offset: 0x00037A30
		private static void AssemblyReferenceDependentAssemblyResourceFallbackCulturePaddingFor(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			PhotonNetwork.LocalPlayer.NickName = Mods.name;
			PhotonNetwork.NickName = Mods.name;
			PhotonNetwork.NetworkingClient.NickName = Mods.name;
			Mods.OEIFJWEF = false;
			A_1 = 0;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00039880 File Offset: 0x00037A80
		private static void EventInfoTemplates(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			A_0 = 416;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00039898 File Offset: 0x00037A98
		private static void getIsCaseInsensitiveJoin(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			Mods.lastRight[A_4] = A_6.rightHandTransform.position;
			bool flag = (double)Vector3.Distance(A_6.leftHandTransform.position, A_9) < 0.25;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 788;
			A_0 = num;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00039944 File Offset: 0x00037B44
		private static void FaultedGetCommandLineArgs(ref int A_0, ref int A_1, ref int A_2, ref SnowballThrowable[] A_3, ref int A_4, ref SnowballThrowable A_5, ref bool A_6)
		{
			SnowballThrowable[] array = Object.FindObjectsOfType<SnowballThrowable>();
			A_3 = array;
			int num = 0;
			A_4 = num;
			A_0 = 264;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0003998C File Offset: 0x00037B8C
		private static void DependentOSDataDeserializationEventHandler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref MeshCollider[] A_4, ref int A_5, ref MeshCollider A_6, ref MeshCollider[] A_7, ref int A_8, ref MeshCollider A_9)
		{
			A_0 = 167;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000399A4 File Offset: 0x00037BA4
		private static void ContractOptionAttributeIDictionary(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			Mods.kowfjwefwjnef = true;
			A_1 = 0;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000399C8 File Offset: 0x00037BC8
		private static void IsVerifiedOtherNumber(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			Object[] array = Object.FindObjectsOfType(typeof(GorillaRopeSwing));
			A_4 = array;
			int num = 0;
			A_5 = num;
			A_0 = 181;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00039A18 File Offset: 0x00037C18
		private static void TaskFactoryResourceManagerLookupStarted(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			bool flag = true;
			A_21 = flag;
			int num = ((!A_21) ? 1 : 0) * 1 + 760;
			A_0 = num;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00039A74 File Offset: 0x00037C74
		private static void GetComObjectDataUnlockRegion(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5, ref bool A_6, ref float A_7, ref bool A_8, ref bool A_9)
		{
			A_1 = 0;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00039A8C File Offset: 0x00037C8C
		private static void SubOvfFieldToken(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("SlingshotProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_5 = gripDownR;
			int num = ((!A_5) ? 1 : 0) * 1 + 519;
			A_0 = num;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00039B14 File Offset: 0x00037D14
		private static void CheckAssertionOnDeserialized(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			bool flag = A_11 < A_7.childCount;
			A_30 = flag;
			int num = (A_30 ? 1 : 0) * -20 + 727;
			A_0 = num;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00039B84 File Offset: 0x00037D84
		private static void CATEGORYSUBCATEGORYGetYear(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			RigShit.GetOwnVRRig().head.trackingRotationOffset.x = 180f;
			Mods.upside = true;
			A_1 = 0;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00039BC0 File Offset: 0x00037DC0
		private static void DebuggerDisplayAttributeCompletedSynchronously(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			bool flag = false;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 11 + 896;
			A_0 = num;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00039C1C File Offset: 0x00037E1C
		private static void HasCreationContextITrackingHandler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			A_1 = 0;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00039C34 File Offset: 0x00037E34
		private static void getSecurityZoneFull(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref int A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref Vector3 A_8, ref Vector3 A_9, ref bool A_10, ref bool A_11)
		{
			GorillaTagger.Instance.GetComponent<Rigidbody>().velocity += Vector3.Normalize(A_6.rightHandTransform.position - Mods.lastRight[A_4]) * 10f;
			Mods.lastRight[A_4] = A_6.rightHandTransform.position;
			bool flag = (double)Vector3.Distance(A_6.leftHandTransform.position, A_9) < 0.25;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 788;
			A_0 = num;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00039D34 File Offset: 0x00037F34
		private static void IsValueFaultedObfuscateAssemblyAttribute(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00039D4C File Offset: 0x00037F4C
		private static void SynchronizedQueueEraInfo(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			((IDisposable)A_8).Dispose();
			A_1 = 4;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00039D74 File Offset: 0x00037F74
		private static void ProcessorArchitectureUNKNOWNDecoder(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_3 = gripDownR;
			int num = ((!A_3) ? 1 : 0) * 1 + 653;
			A_0 = num;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00039DD0 File Offset: 0x00037FD0
		private static void SyncSortedListbodyWithLocal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref Vector3 A_5)
		{
			A_1 = 0;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00039DE8 File Offset: 0x00037FE8
		private static void ExtraInfoBleUnS(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref MeshCollider[] A_5, ref int A_6, ref MeshCollider A_7, ref MeshCollider[] A_8, ref int A_9, ref MeshCollider A_10)
		{
			int num = ((A_6 < A_5.Length) ? 1 : 0) * -2 + 738;
			A_0 = num;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00039E24 File Offset: 0x00038024
		private static void GregorianCalendarTypesInputBlockSize(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			ButtonInfo buttonInfo = A_8.Current;
			A_9 = buttonInfo;
			bool flag = A_9.buttonText == A_7;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 378;
			A_0 = num;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00039EB4 File Offset: 0x000380B4
		private static void setTagsgetChannelInfo(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00039ECC File Offset: 0x000380CC
		// Note: this type is marked as 'beforefieldinit'.
		static Mods()
		{
			Mods.ShadowCopyFilesValueFileSystemSecurity();
			int num = 933;
			int num2 = 933;
			num2 = 933;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 933;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00039F14 File Offset: 0x00038114
		private static void getIsCaseInsensitiveMaxValue(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			A_4.Add(A_6.buttonText);
			int num = (A_5.MoveNext() ? 1 : 0) * -4 + 359;
			A_0 = num;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00039F7C File Offset: 0x0003817C
		private static void FileObjectPolicyManager(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			Transform child = A_5.GetChild(A_6);
			A_7 = child;
			int num = ((!A_7.gameObject.name.Contains("Anchor")) ? 1 : 0) * 1 + 704;
			A_0 = num;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0003A000 File Offset: 0x00038200
		private static void CausalitySynchronousWorksetPrimaryIdentitySelector(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			int num = ((A_6 < A_5.Length) ? 1 : 0) * -10 + 385;
			A_0 = num;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0003A03C File Offset: 0x0003823C
		private static void ASSEMBLYFLAGSUNKNOWNTrademark(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = (Mods.once_right ? 1 : 0) * 1 + 388;
			A_0 = num;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0003A080 File Offset: 0x00038280
		private static void LdtokenAdministrator(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref VRRig A_4, ref bool A_5, ref SlingshotProjectile[] A_6, ref int A_7, ref SlingshotProjectile A_8, ref bool A_9)
		{
			int num = ((A_7 < A_6.Length) ? 1 : 0) * -4 + 925;
			A_0 = num;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0003A0BC File Offset: 0x000382BC
		private static void setSignedFileEvidenceCollection(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref MeshCollider[] A_4, ref int A_5, ref MeshCollider A_6, ref MeshCollider[] A_7, ref int A_8, ref MeshCollider A_9)
		{
			int num = ((A_5 < A_4.Length) ? 1 : 0) * -2 + 162;
			A_0 = num;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0003A0F8 File Offset: 0x000382F8
		private static void RestoreLockFailFast(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Mods.jump_right_local.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
			A_8 = A_31;
			int num = ((!A_8) ? 1 : 0) * 1 + 394;
			A_0 = num;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0003A174 File Offset: 0x00038374
		private static void EventManifestOptionsSerializationEventsCache(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0003A18C File Offset: 0x0003838C
		private static void getEndOffsetFormatterAlgorithm(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color white = Color.white;
			A_4 = white;
			bool flag = A_5 == 2;
			A_8 = flag;
			int num = ((!A_8) ? 1 : 0) * 1 + 111;
			A_0 = num;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0003A20C File Offset: 0x0003840C
		private static void PlatformsThing(bool invis, bool sticky)
		{
			int num = 386;
			int num2 = 386;
			num2 = 386;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				object[] array;
				RaiseEventOptions raiseEventOptions;
				ColorChanger colorChanger;
				Gradient gradient;
				bool flag7;
				RaiseEventOptions raiseEventOptions2;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				object[] array2;
				RaiseEventOptions raiseEventOptions3;
				ColorChanger colorChanger2;
				Gradient gradient2;
				bool flag12;
				RaiseEventOptions raiseEventOptions4;
				bool flag13;
				int num4;
				bool flag14;
				int num5;
				bool flag15;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Object[]&,Photon.Realtime.RaiseEventOptions&,ShibaGTTemplate.Utilities.ColorChanger&,UnityEngine.Gradient&,System.Boolean&,Photon.Realtime.RaiseEventOptions&,System.Boolean&,System.Int32&,System.Boolean&,System.Int32&,System.Boolean&,System.Boolean,System.Boolean), ref num, ref num2, ref num3, ref flag, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref array, ref raiseEventOptions, ref colorChanger, ref gradient, ref flag7, ref raiseEventOptions2, ref flag8, ref flag9, ref flag10, ref flag11, ref array2, ref raiseEventOptions3, ref colorChanger2, ref gradient2, ref flag12, ref raiseEventOptions4, ref flag13, ref num4, ref flag14, ref num5, ref flag15, sticky, invis, Mods.ControlThreadBadData[num]);
			}
			num2 = 386;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0003A288 File Offset: 0x00038488
		private static void getIsGenericMethodDiscretionaryAclUntrusted(ref int A_0, ref int A_1, ref int A_2)
		{
			Player.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
			A_1 = 0;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0003A2C4 File Offset: 0x000384C4
		private static void CancellationTokenTokenType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_8 = gripDownR;
			int num = ((!A_8) ? 1 : 0) * 1 + 525;
			A_0 = num;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0003A320 File Offset: 0x00038520
		private static void DllNotFoundExceptionFUNCDESC(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			bool flag = Mods.balll2 < Time.time;
			A_4 = flag;
			int num = ((!A_4) ? 1 : 0) * 14 + 830;
			A_0 = num;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0003A384 File Offset: 0x00038584
		private static void CriticalFinalizerObjectIsHighSurrogate(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("Fall2023Forest").SetActive(false);
			GameObject.Find("Fall2023City").SetActive(false);
			GameObject.Find("Fall2023Basement").SetActive(false);
			GameObject.Find("Fall2023Canyon").SetActive(false);
			GameObject.Find("Fall2023Beach").SetActive(false);
			GameObject.Find("Fall2023SkyJungle").SetActive(false);
			GameObject.Find("Fall2023Mountain").SetActive(false);
			A_1 = 0;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0003A430 File Offset: 0x00038630
		private static void TitlegetResult(ref int A_0, ref int A_1, ref int A_2)
		{
			RigShit.GetOwnVRRig().head.trackingRotationOffset.y = 0f;
			A_1 = 0;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0003A464 File Offset: 0x00038664
		private static void CacheTypeDevPathValue(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			Object.Destroy(Mods.pointer);
			GorillaTagger.Instance.offlineVRRig.headBodyOffset = Vector3.zero;
			A_1 = 0;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0003A49C File Offset: 0x0003869C
		private static void LocalSigByteLength(ref int A_0, ref int A_1, ref int A_2, ref Hashtable A_3)
		{
			Hashtable hashtable = new Hashtable();
			A_3 = hashtable;
			A_3.Add("gameMode", PhotonNetwork.CurrentRoom.CustomProperties["gameMode"].ToString().Replace(Mods.CurrentMap, ""));
			PhotonNetwork.CurrentRoom.SetCustomProperties(A_3, null, null);
			A_1 = 0;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0003A51C File Offset: 0x0003871C
		private static void DecimalConstantAttributeIsDefined(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			Mods.pointer = GameObject.CreatePrimitive(0);
			Object.Destroy(Mods.pointer.GetComponent<Rigidbody>());
			Object.Destroy(Mods.pointer.GetComponent<SphereCollider>());
			Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			Mods.pointer.transform.position = A_5.point;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 4 + 434;
			A_0 = num;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0003A610 File Offset: 0x00038810
		public static void RpcPatcher(VRRig rig)
		{
			int num = 67;
			int num2 = 67;
			num2 = 67;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 67;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0003A648 File Offset: 0x00038848
		private static void AbsHasDefault(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("BucketGiftSquare", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0003A68C File Offset: 0x0003888C
		public static void CandyCaneSpam()
		{
			int num = 610;
			int num2 = 610;
			num2 = 610;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 610;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0003A6D0 File Offset: 0x000388D0
		public static void CloudSpam()
		{
			int num = 580;
			int num2 = 580;
			num2 = 580;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 580;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0003A714 File Offset: 0x00038914
		private static void RanToCompletiongetRandomlyGenerated(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			((IDisposable)A_19).Dispose();
			A_1 = 3;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0003A73C File Offset: 0x0003893C
		public static void bordetext()
		{
			int num = 335;
			int num2 = 335;
			num2 = 335;
			while (num2 != 0)
			{
				int num3;
				Material material;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,UnityEngine.Material&), ref num, ref num2, ref num3, ref material, Mods.ControlThreadBadData[num]);
			}
			num2 = 335;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0003A780 File Offset: 0x00038980
		private static void WhenAllPromisegetWrappedException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 5;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 142;
			A_0 = num;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0003A7E8 File Offset: 0x000389E8
		private static void FormCDisallowUnassignedgetindex(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Color A_4, ref bool A_5, ref string A_6, ref List<ButtonInfo>.Enumerator A_7, ref ButtonInfo A_8, ref bool A_9)
		{
			((IDisposable)A_7).Dispose();
			A_1 = 4;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0003A810 File Offset: 0x00038A10
		private static void OrdergetIsFinal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			bool flag = A_5 == 5;
			A_11 = flag;
			int num = ((!A_11) ? 1 : 0) * 1 + 92;
			A_0 = num;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0003A878 File Offset: 0x00038A78
		private static void setTargetTypeNameBaseName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectile("IceSlingshot_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0003A8BC File Offset: 0x00038ABC
		private static void setAceFlagsGetOrderableDynamicPartitions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			int num = ((A_9 < A_8.Length) ? 1 : 0) * -2 + 462;
			A_0 = num;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0003A8F8 File Offset: 0x00038AF8
		private static void getAppDomainInitializergetParameterType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			bool flag = false;
			A_5 = flag;
			int num = ((!A_5) ? 1 : 0) * 1 + 250;
			A_0 = num;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0003A954 File Offset: 0x00038B54
		private static void getSyncRootgetKeyHandle(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Mods.ChangeMonkColor(A_4);
			Mods.flushmanually();
			A_1 = 0;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0003A984 File Offset: 0x00038B84
		private static void IsUsedUpOtherSymbol(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			A_0 = 52;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0003A9D4 File Offset: 0x00038BD4
		private static void CMSUSAGEPATTERNSCOPEPROCESSToStringArray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			bool flag = false;
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 432;
			A_0 = num;
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0003AA30 File Offset: 0x00038C30
		private static void PowParseFlags(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color black = Color.black;
			A_4 = black;
			Mods.ChangeMonkColor(A_4);
			Mods.flushmanually();
			A_1 = 0;
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0003AA78 File Offset: 0x00038C78
		public static void offanticrash()
		{
			int num = 203;
			int num2 = 203;
			num2 = 203;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 203;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0003AABC File Offset: 0x00038CBC
		private static string InnerExceptiongetAsUint(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			string text = null;
			A_5 = text;
			A_0 = 289;
			string result;
			return result;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0003AAEC File Offset: 0x00038CEC
		private static void getIsFinalCheckAccessOnOverride(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			Object.Destroy(Mods.jump_right_local.GetComponent<Renderer>());
			Mods.jump_right_local.transform.localScale = Mods.scale;
			Mods.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position;
			Mods.jump_right_local.transform.rotation = Player.Instance.rightControllerTransform.rotation;
			object[] array = new object[]
			{
				new Vector3(0f, -0.01f, 0f) + Player.Instance.rightControllerTransform.position,
				Player.Instance.rightControllerTransform.rotation
			};
			A_9 = array;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				Receivers = 0
			};
			A_10 = raiseEventOptions;
			PhotonNetwork.RaiseEvent(70, A_9, A_10, SendOptions.SendReliable);
			Mods.once_right = true;
			Mods.once_right_false = false;
			ColorChanger colorChanger = Mods.jump_right_local.AddComponent<ColorChanger>();
			A_11 = colorChanger;
			Gradient gradient = new Gradient();
			A_12 = gradient;
			A_12.colorKeys = Mods.colorKeysPlatformMonke;
			A_11.colors = A_12;
			A_11.Start();
			A_0 = 401;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0003ACB0 File Offset: 0x00038EB0
		private static string WinSecurityContextNullableTypeInfo(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref string A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12)
		{
			string text = "mountain";
			A_5 = text;
			A_0 = 289;
			string result;
			return result;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0003ACE4 File Offset: 0x00038EE4
		private static void PEFileKindsStoreTransaction(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			bool flag = A_5.concatStringOfCosmeticsAllowed.Contains("LBAAK");
			A_6 = flag;
			int num = ((!A_6) ? 1 : 0) * 1 + 197;
			A_0 = num;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0003AD58 File Offset: 0x00038F58
		private static void setViewAccessControlAddTask(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			A_0 = 769;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0003AD74 File Offset: 0x00038F74
		private static void RemoveMethodTryStartNoGCRegion(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			GameObject gameObject = GameObject.Find("Environment Objects/PersistentObjects_Prefab/GorillaUI");
			A_4 = gameObject;
			Transform transform = A_4.transform;
			A_5 = transform;
			int num = 0;
			A_6 = num;
			A_0 = 729;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0003ADDC File Offset: 0x00038FDC
		public static void LagAll()
		{
			int num = 470;
			int num2 = 470;
			num2 = 470;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Player[] array;
				int num4;
				Player player;
				bool flag2;
				PhotonView photonView;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,Photon.Realtime.Player[]&,System.Int32&,Photon.Realtime.Player&,System.Boolean&,Photon.Pun.PhotonView&), ref num, ref num2, ref num3, ref flag, ref array, ref num4, ref player, ref flag2, ref photonView, Mods.ControlThreadBadData[num]);
			}
			num2 = 470;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0003AE2C File Offset: 0x0003902C
		private static void getAuditRuleTypeMarkAborted(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Player[] A_4, ref int A_5, ref Player A_6, ref object A_7, ref bool A_8, ref bool A_9, ref VRRig A_10, ref bool A_11, ref ColorChanger A_12, ref Gradient A_13, ref bool A_14, ref bool A_15)
		{
			int num = ((A_5 < A_4.Length) ? 1 : 0) * -17 + 910;
			A_0 = num;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0003AE68 File Offset: 0x00039068
		private static void OtherArraySetData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			A_4 = A_10;
			A_5 = A_11;
			Vector3 velocity = GorillaTagger.Instance.GetComponent<Rigidbody>().velocity;
			A_6 = velocity;
			GorillaTagger.Instance.GetComponent<Rigidbody>().velocity = A_5;
			SnowballThrowable component = GameObject.Find("Player Objects/Local VRRig/Local Gorilla Player/rig/body/shoulder.R/upper_arm.R/forearm.R/hand.R/palm.01.R/TransferrableItemRightHand/SnowballRightAnchor").transform.Find("LMACF.").GetComponent<SnowballThrowable>();
			A_7 = component;
			Vector3 position = A_7.transform.position;
			A_8 = position;
			A_7.randomizeColor = true;
			GorillaTagger.Instance.offlineVRRig.SetThrowableProjectileColor(false, A_12);
			A_7.transform.position = A_4;
			A_7.projectilePrefab.tag = A_13;
			A_7.OnRelease(null, null);
			Mods.FlushRPCS();
			A_7.transform.position = A_8;
			GorillaTagger.Instance.GetComponent<Rigidbody>().velocity = A_6;
			A_7.randomizeColor = false;
			A_7.projectilePrefab.tag = "WaterballoonProjectile(Clone)";
			int num = (((Mods.projDebounceType > 0f) ? 1 : 0) + -1) * -1 * 1 + 502;
			A_0 = num;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0003B038 File Offset: 0x00039238
		private static void getHasVarArgsGetValueKind(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("BucketGiftRoll", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_16 = gripDownR;
			int num = ((!A_16) ? 1 : 0) * 1 + 541;
			A_0 = num;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0003B0C0 File Offset: 0x000392C0
		private static void ApplicationDirectoryIEnumSTORECATEGORY(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref ExecuteCloudScriptRequest A_5, ref string A_6, ref Hashtable A_7)
		{
			ExecuteCloudScriptRequest executeCloudScriptRequest = new ExecuteCloudScriptRequest();
			A_5 = executeCloudScriptRequest;
			A_5.FunctionName = "RoomClosed";
			A_5.FunctionParameter = new
			{
				GameId = PhotonNetwork.CurrentRoom.Name,
				Region = Regex.Replace(PhotonNetwork.CloudRegion, "[^a-zA-Z0-9]", "").ToUpper(),
				UserId = PhotonNetwork.MasterClient.UserId,
				ActorNr = 1,
				ActorCount = 1,
				AppVersion = PhotonNetwork.AppVersion
			};
			PlayFabClientAPI.ExecuteCloudScript(A_5, delegate(ExecuteCloudScriptResult result)
			{
				int num = 3;
				int num2 = 3;
				num2 = 3;
				while (num2 != 0)
				{
					int num3;
					calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.<>c.ITupleBlockLongPaths[num]);
				}
				num2 = 3;
			}, null, null, null);
			string text = PhotonNetwork.CurrentRoom.CustomProperties["gameMode"].ToString().Replace(GorillaComputer.instance.currentQueue, GorillaComputer.instance.currentQueue + "MODDED_MODDED_");
			A_6 = text;
			Hashtable hashtable = new Hashtable();
			hashtable.Add("gameMode", A_6);
			Hashtable hashtable2 = hashtable;
			A_7 = hashtable2;
			PhotonNetwork.CurrentRoom.SetCustomProperties(A_7, null, null);
			A_1 = 0;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0003B218 File Offset: 0x00039418
		private static List<VRRig> XsdTypeEncoderExceptionFallbackBuffer(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			Mods.validRigs.Add(A_5);
			int num = (A_4.MoveNext() ? 1 : 0) * -8 + 887;
			A_0 = num;
			List<VRRig> result;
			return result;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0003B278 File Offset: 0x00039478
		private static List<VRRig> GCHandlesetDefaultThreadCurrentUICulture(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref List<VRRig> A_7)
		{
			int num = (PhotonNetwork.InRoom ? 1 : 0) * 1 + 881;
			A_0 = num;
			List<VRRig> result;
			return result;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0003B2C0 File Offset: 0x000394C0
		private static void setSizeGetAscii(ref int A_0, ref int A_1, ref int A_2, ref Vector2 A_3, ref Vector2 A_4, ref double A_5)
		{
			double num = (double)Time.time;
			A_5 = num;
			ScienceExperimentManager.instance.photonView.RPC("SpawnSodaBubbleRPC", 0, new object[]
			{
				A_4,
				100000f,
				9999999f,
				A_5
			});
			A_1 = 0;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0003B368 File Offset: 0x00039568
		private static void ClassPtrToStringHString(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref GorillaRopeSwing[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			GorillaRopeSwing[] array = Object.FindObjectsOfType<GorillaRopeSwing>();
			A_4 = array;
			int num = 0;
			A_5 = num;
			A_0 = 328;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0003B3AC File Offset: 0x000395AC
		private static void DomainCompressedStackgetManagedThreadId(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0003B3C4 File Offset: 0x000395C4
		private static void DISPPARAMSvmTpInitialized(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref RaycastHit A_4, ref bool A_5, ref bool A_6)
		{
			A_1 = 0;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0003B3DC File Offset: 0x000395DC
		private static void UnmanagedCodeTypeLimitingDeserializationBinder(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7)
		{
			GorillaTagger.Instance.offlineVRRig.enabled = false;
			GorillaTagger.Instance.offlineVRRig.transform.position = Mods.pointer.transform.position;
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			GorillaTagger.Instance.myVRRig.RPC("PlaySplashEffect", 0, new object[]
			{
				Mods.pointer.transform.position,
				Mods.pointer.transform.rotation,
				4f,
				100f,
				true,
				false
			});
			GorillaTagger.Instance.offlineVRRig.enabled = true;
			GorillaTagger.Instance.offlineVRRig.transform.position = Vector3.zero;
			Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
			A_0 = 497;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0003B530 File Offset: 0x00039730
		private static void BrowserFavoritesAddOrUpdate(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("BucketGiftRoll", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			A_1 = 0;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0003B574 File Offset: 0x00039774
		private static void RoamingIStringableHelper(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			int num = (((Mods.ropedelay < Time.time) ? 1 : 0) + -1) * -1 * 1 + 185;
			A_0 = num;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0003B5B4 File Offset: 0x000397B4
		private static void InvariantInfoClientAsyncReplyTerminatorSink(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			A_1 = 4;
			A_2 = 361;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0003B5D8 File Offset: 0x000397D8
		private static void getDemandedResourcescParams(ref int A_0, ref int A_1, ref int A_2, ref Vector2 A_3, ref Vector2 A_4, ref double A_5)
		{
			double time = PhotonNetwork.Time;
			A_5 = time;
			ScienceExperimentManager.instance.photonView.RPC("SpawnSodaBubbleRPC", 0, new object[]
			{
				A_4,
				100000f,
				9999999f,
				A_5
			});
			A_1 = 0;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0003B678 File Offset: 0x00039878
		private static void LoopTimerLoadedAssembly(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref string[] A_4, ref string[] A_5, ref int A_6, ref string A_7, ref List<ButtonInfo>.Enumerator A_8, ref ButtonInfo A_9, ref bool A_10)
		{
			A_9.enabled = new bool?(true);
			int num = (A_8.MoveNext() ? 1 : 0) * -4 + 369;
			A_0 = num;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0003B6D8 File Offset: 0x000398D8
		private static void getIsMailNewsSaveAssemblyHashAlgorithm(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			int num = A_6 + 1;
			A_6 = num;
			bool flag = A_6 < A_5.childCount;
			A_31 = flag;
			int num2 = (A_31 ? 1 : 0) * -27 + 730;
			A_0 = num2;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0003B768 File Offset: 0x00039968
		private static void UseSoapFormatgetDelaySign(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectileDelay("BucketGiftCoal", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_15 = gripDownR;
			int num = ((!A_15) ? 1 : 0) * 1 + 539;
			A_0 = num;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0003B7F0 File Offset: 0x000399F0
		private static void IDLDESCsetCertificate(ref int A_0, ref int A_1, ref int A_2, ref Player[] A_3, ref int A_4, ref Player A_5)
		{
			Player player = A_3[A_4];
			A_5 = player;
			PhotonNetwork.CurrentRoom.StorePlayer(A_5);
			PhotonNetwork.CurrentRoom.Players.Remove(A_5.ActorNumber);
			PhotonNetwork.OpRemoveCompleteCacheOfPlayer(A_5.ActorNumber);
			int num = A_4 + 1;
			A_4 = num;
			int num2 = ((A_4 < A_3.Length) ? 1 : 0) * -2 + 930;
			A_0 = num2;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0003B8B8 File Offset: 0x00039AB8
		private static void PrefixgetAccessControlType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			Mods.BetaFireProjectileDelay("ScienceCandyProjectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.green, false);
			A_1 = 0;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0003B8FC File Offset: 0x00039AFC
		private static void ServerIdentityDays(ref int A_0, ref int A_1, ref int A_2, ref Hashtable A_3)
		{
			PlayerPrefs.SetString("tutorial", "false");
			Hashtable hashtable = new Hashtable();
			A_3 = hashtable;
			A_3.Add("didTutorial", true);
			PhotonNetwork.LocalPlayer.SetCustomProperties(A_3, null, null);
			PlayerPrefs.Save();
			Mods.stuiejrf99 = false;
			A_1 = 0;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0003B980 File Offset: 0x00039B80
		private static void UntrustedControlCDelegateData(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			Mods.projDebounce = Time.time + Mods.projDebounceType;
			A_1 = 0;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0003B9AC File Offset: 0x00039BAC
		private static void LockTypegetXmlTypeNamespace(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref Material A_4, ref Material A_5, ref List<VRRig>.Enumerator A_6, ref VRRig A_7, ref bool A_8, ref bool A_9)
		{
			A_1 = 0;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0003B9C4 File Offset: 0x00039BC4
		private static void IgnoreNonSpaceWindowApplication(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color grey = Color.grey;
			A_4 = grey;
			bool flag = A_5 == 8;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 98;
			A_0 = num;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0003BA44 File Offset: 0x00039C44
		private static void GetPublicKeyStringSIDANDATTRIBUTES(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			int num = (((Mods.ropedelay < Time.time) ? 1 : 0) + -1) * -1 * 1 + 177;
			A_0 = num;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0003BA84 File Offset: 0x00039C84
		private static void LookForMeUnsafeLoadFrom(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref GameObject A_5, ref GameObject A_6)
		{
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0.4f;
			A_3 = flag;
			bool flag2 = A_3;
			A_4 = flag2;
			int num = ((!A_4) ? 1 : 0) * 1 + 332;
			A_0 = num;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0003BB08 File Offset: 0x00039D08
		private static void setEventHandleIntPtrgetManifestModule(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			A_0 = 746;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0003BB20 File Offset: 0x00039D20
		public static void ChangeMonkColor(Color color)
		{
			int num = 155;
			int num2 = 155;
			num2 = 155;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.Color), ref num, ref num2, ref num3, ref flag, color, Mods.ControlThreadBadData[num]);
			}
			num2 = 155;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0003BB68 File Offset: 0x00039D68
		private static void ComRedirectionProxyFUsesGetLastError(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref object[] A_9, ref RaiseEventOptions A_10, ref ColorChanger A_11, ref Gradient A_12, ref bool A_13, ref RaiseEventOptions A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18, ref object[] A_19, ref RaiseEventOptions A_20, ref ColorChanger A_21, ref Gradient A_22, ref bool A_23, ref RaiseEventOptions A_24, ref bool A_25, ref int A_26, ref bool A_27, ref int A_28, ref bool A_29, bool A_30, bool A_31)
		{
			int num = 0;
			A_26 = num;
			A_0 = 419;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0003BB98 File Offset: 0x00039D98
		private static void AccountDomainGuestsSidVersionCompatibility(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref MeshCollider[] A_5, ref int A_6, ref MeshCollider A_7, ref MeshCollider[] A_8, ref int A_9, ref MeshCollider A_10)
		{
			Mods.input = GameObject.Find("Player Objects/Player VR Controller/GorillaPlayer").GetComponent<ControllerInputPoller>();
			bool activeSelf = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom").activeSelf;
			A_3 = activeSelf;
			int num = ((!A_3) ? 1 : 0) * 10 + 734;
			A_0 = num;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0003BC14 File Offset: 0x00039E14
		private static void StrongNameFreeBufferIActContext(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			bool gripDownR = WristMenu.gripDownR;
			A_9 = gripDownR;
			int num = ((!A_9) ? 1 : 0) * 1 + 527;
			A_0 = num;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0003BC70 File Offset: 0x00039E70
		private static void TAIWANStringBuilder(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			((IDisposable)A_5).Dispose();
			A_1 = 4;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0003BC98 File Offset: 0x00039E98
		private static void RenewalMaxSize(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref GorillaFriendCollider[] A_8, ref int A_9, ref GorillaFriendCollider A_10)
		{
			Mods.pointer.transform.position = A_5.point;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_7 = flag;
			int num = ((!A_7) ? 1 : 0) * 4 + 459;
			A_0 = num;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0003BD1C File Offset: 0x00039F1C
		private static void RemoveInheritedAcesGenerateGuidForType(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref bool A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16, ref bool A_17, ref bool A_18)
		{
			Mods.BetaFireProjectile("ElfBow_Projectile", Player.Instance.rightControllerTransform.position, Vector3.forward, Color.white, false);
			bool gripDownR = WristMenu.gripDownR;
			A_10 = gripDownR;
			int num = ((!A_10) ? 1 : 0) * 1 + 562;
			A_0 = num;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0003BDA4 File Offset: 0x00039FA4
		private static void SystemGetRaiseMethod(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0003BDBC File Offset: 0x00039FBC
		private static void PayloadNamesRfcPattern(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, ref RaycastHit A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref string A_10, ref Player[] A_11, ref int A_12, ref Player A_13)
		{
			Mods.pointer = GameObject.CreatePrimitive(0);
			Object.Destroy(Mods.pointer.GetComponent<Rigidbody>());
			Object.Destroy(Mods.pointer.GetComponent<SphereCollider>());
			Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			Mods.pointer.transform.position = A_5.point;
			bool flag = ControllerInputPoller.instance.rightControllerIndexFloat > 0f;
			A_8 = flag;
			bool flag2 = A_8;
			A_9 = flag2;
			int num = ((!A_9) ? 1 : 0) * 4 + 801;
			A_0 = num;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0003BEB0 File Offset: 0x0003A0B0
		private static void CreateDirectoryBuiltinIncomingForestTrustBuildersSid(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color blue = Color.blue;
			A_4 = blue;
			bool flag = A_5 == 10;
			A_16 = flag;
			int num = ((!A_16) ? 1 : 0) * 1 + 102;
			A_0 = num;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0003BF30 File Offset: 0x0003A130
		public static void disablenetworktriggers()
		{
			int num = 302;
			int num2 = 302;
			num2 = 302;
			while (num2 != 0)
			{
				int num3;
				Hashtable hashtable;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ExitGames.Client.Photon.Hashtable&), ref num, ref num2, ref num3, ref hashtable, Mods.ControlThreadBadData[num]);
			}
			num2 = 302;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0003BF74 File Offset: 0x0003A174
		private static void AccountComputersSidsetAssertion(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref int A_9, ref Transform A_10, ref bool A_11, ref Text A_12, ref Transform A_13, ref bool A_14, ref bool A_15, ref List<VRRig>.Enumerator A_16, ref VRRig A_17, ref bool A_18, ref float A_19, ref float A_20, ref bool A_21, ref bool A_22, ref bool A_23)
		{
			A_0 = 763;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0003BF8C File Offset: 0x0003A18C
		public static void CleanActorAndRPCBuffers(PhotonView photonView)
		{
			int num = 68;
			int num2 = 68;
			num2 = 68;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,Photon.Pun.PhotonView), ref num, ref num2, ref num3, photonView, Mods.ControlThreadBadData[num]);
			}
			num2 = 68;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0003BFC4 File Offset: 0x0003A1C4
		private static void IsAllocatedModifierLetter(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color clear = Color.clear;
			A_4 = clear;
			bool flag = A_5 == 9;
			A_15 = flag;
			int num = ((!A_15) ? 1 : 0) * 1 + 150;
			A_0 = num;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0003C044 File Offset: 0x0003A244
		public static void LongArmsOff()
		{
			int num = 30;
			int num2 = 30;
			num2 = 30;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&), ref num, ref num2, ref num3, Mods.ControlThreadBadData[num]);
			}
			num2 = 30;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0003C07C File Offset: 0x0003A27C
		private static void MLangDecodergetRemoveMethod(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6, ref bool A_7, ref bool A_8)
		{
			A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>().startWidth = 0.025f;
			A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>().material.shader = Shader.Find("GorillaTag/UberShader");
			A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>().material.color = A_5.playerColor;
			A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>().SetPosition(0, A_5.head.rigTarget.gameObject.transform.position);
			A_5.head.rigTarget.gameObject.GetComponent<LineRenderer>().SetPosition(1, GorillaTagger.Instance.offlineVRRig.rightHandTransform.position);
			int num = (A_4.MoveNext() ? 1 : 0) * -8 + 215;
			A_0 = num;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0003C1DC File Offset: 0x0003A3DC
		private static void PUBLICKEYRijndaelManaged(ref int A_0, ref int A_1, ref int A_2)
		{
			Mods.inSettings = false;
			Mods.invisplat = false;
			Mods.stickyplatforms = false;
			Mods.weufewfjdfjn = false;
			Mods.cooldown = 0f;
			Mods.rattatuoie = 0;
			Mods.esiuhkfdjmcsl = false;
			Mods.validRigs = new List<VRRig>();
			Mods.rayResults = new RaycastHit[1];
			Mods.balll = 0f;
			Mods.scale = new Vector3(0.0125f, 0.28f, 0.3825f);
			Mods.colorKeysPlatformMonke9 = new GradientColorKey[3];
			Mods.colorKeysPlatformMonke2 = new GradientColorKey[3];
			Mods.kowfjwefwjnef = false;
			Mods.projectiletrailhash = 1432124712;
			Mods.projectilehash = -820530352;
			Mods.projectiletrail = 0;
			Mods.projectilecycle1 = 0;
			Mods.projectilehashc1 = -820530352;
			Mods.projectilecycle2 = 0;
			Mods.namelist = new List<string>();
			Mods.projectilehashc2 = -820530352;
			Mods.projectilecycle3 = 0;
			Mods.fuckyoucsharp = 0;
			Mods.projectilehashc3 = -820530352;
			Mods.projectilecycle4 = 0;
			Mods.roomCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
			Mods.cycle = false;
			Mods.stuiejrf99 = true;
			Mods.projectilehashc4 = -820530352;
			Mods.CycleSpeed = 0.07f;
			Mods.ihate = new GradientColorKey[6];
			Mods.erm = null;
			Mods.distance = 2f;
			Mods.rainboww = false;
			Mods.positions = new Vector3[]
			{
				new Vector3(Mods.distance, 0f, Mods.distance),
				new Vector3(0f, 0f, Mods.distance),
				new Vector3(-Mods.distance, 0f, Mods.distance),
				new Vector3(Mods.distance, 0f, 0f),
				new Vector3(0f, 0f, 0f),
				new Vector3(-Mods.distance, 0f, 0f),
				new Vector3(Mods.distance, 0f, -Mods.distance),
				new Vector3(0f, 0f, -Mods.distance),
				new Vector3(-Mods.distance, 0f, -Mods.distance)
			};
			Mods.lastLeft = new Vector3[]
			{
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero
			};
			Mods.lastRight = new Vector3[]
			{
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero,
				Vector3.zero
			};
			Mods.wallpositions = new List<Vector3>();
			Mods.projcolor = Color.black;
			Mods.jump_left_network = new GameObject[9999];
			Mods.jump_right_network = new GameObject[9999];
			Mods.jump_left_local = null;
			Mods.jump_right_local = null;
			Mods.colorKeysPlatformMonke = new GradientColorKey[4];
			A_1 = 0;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0003C648 File Offset: 0x0003A848
		private static void ConcurrentSetItemReadString(ref int A_0, ref int A_1, ref int A_2, ref ScienceExperimentManager.PlayerGameState[] A_3, ref int A_4, ref bool A_5)
		{
			Traverse.Create(ScienceExperimentManager.instance).Field("inGamePlayerStates").SetValue(A_3);
			A_1 = 0;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0003C684 File Offset: 0x0003A884
		private static void AreAuditRulesCanonicalSparseArray(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color red = Color.red;
			A_4 = red;
			bool flag = A_5 == 4;
			A_10 = flag;
			int num = ((!A_10) ? 1 : 0) * 1 + 140;
			A_0 = num;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0003C704 File Offset: 0x0003A904
		private static void ApplicationBasePathINVOKEPROPERTYPUTREF(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			bool rightGrab = ControllerInputPoller.instance.rightGrab;
			A_3 = rightGrab;
			int num = ((!A_3) ? 1 : 0) * 1 + 323;
			A_0 = num;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0003C768 File Offset: 0x0003A968
		private static void getStreamingContextAmbiguousMatchException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			GorillaNot.instance.rpcCallLimit = int.MaxValue;
			PhotonNetwork.SendAllOutgoingCommands();
			PhotonNetwork.SendAllOutgoingCommands();
			PhotonNetwork.SendAllOutgoingCommands();
			A_1 = 0;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0003C7A4 File Offset: 0x0003A9A4
		private static void SurnameOtherLetter(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<string> A_4, ref List<ButtonInfo>.Enumerator A_5, ref ButtonInfo A_6, ref bool? A_7, ref bool A_8, ref bool A_9)
		{
			Directory.CreateDirectory("TemplatePrefs");
			File.WriteAllLines("TemplatePrefs\\templateSavedPrefs.txt", A_4);
			A_1 = 0;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0003C7DC File Offset: 0x0003A9DC
		public unsafe static void AntiReport()
		{
			RuntimeTypeHandle[] array = new RuntimeTypeHandle[1];
			Type[] array2 = new Type[1];
			array[0] = typeof(object).TypeHandle;
			int num = 1;
			int num2 = num * 4;
			int num3 = 745;
			int num4 = 745;
			num4 = 745;
			try
			{
				IL_3F:
				object[] array3;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array4;
				int num10;
				int num17;
				int num18;
				int num19;
				int num20;
				int num21;
				int num22;
				int num25;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 4)
					{
						num4 = 745;
						if ((int)array3[4] != 1)
						{
							num5 = (int)array3[7];
							num6 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num5 + 48 + num2);
							for (num7 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + *(ref StartDocumentIncreaseQuota.VerboseCapiNative + (int)array3[3] + 48 + num2) + 40 + num2); num7 != num6; num7 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num7 + 40 + num2))
							{
								num8 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num7 + 32 + num2);
								if (num8 != -1)
								{
									num9 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num8 + 56 + num2);
									array3[3] = num8;
									array3[6] = 1;
									num3 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num8 + 56 + num2);
									goto IL_3F;
								}
							}
							Exception ex = (Exception)array3[5];
							num9 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num5 + 56 + num2);
							ex2 = ex;
							array3 = (object[])array3[2];
							array4 = new object[8];
							array4[4] = 0;
							array4[2] = array3;
							array4[5] = ex;
							array4[3] = num5;
							array4[6] = 2;
							array3 = array4;
							num3 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num5 + 56 + num2);
							continue;
						}
						num10 = (int)array3[0];
						array3 = (object[])array3[2];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 1)
						{
							GameObject gameObject;
							Transform transform;
							int num13;
							Transform transform2;
							bool flag;
							int num14;
							Transform transform3;
							bool flag2;
							Text text;
							Transform transform4;
							bool flag3;
							bool flag4;
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag5;
							float num15;
							float num16;
							bool flag6;
							bool flag7;
							bool flag8;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,UnityEngine.GameObject&,UnityEngine.Transform&,System.Int32&,UnityEngine.Transform&,System.Boolean&,System.Int32&,UnityEngine.Transform&,System.Boolean&,UnityEngine.UI.Text&,UnityEngine.Transform&,System.Boolean&,System.Boolean&,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&,System.Single&,System.Single&,System.Boolean&,System.Boolean&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref gameObject, ref transform, ref num13, ref transform2, ref flag, ref num14, ref transform3, ref flag2, ref text, ref transform4, ref flag3, ref flag4, ref enumerator, ref vrrig, ref flag5, ref num15, ref num16, ref flag6, ref flag7, ref flag8, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 745;
						num8 = num12;
						num11 = num8;
					}
					num17 = num3;
					num6 = num17;
					num10 = 0;
					num18 = 4;
					for (;;)
					{
						num19 = (num10 + num18) / 2;
						num20 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 304 + num19 * 56 + 32 + num2);
						num21 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 304 + num19 * 56 + 16 + num2);
						if (num6 < num20 + num21)
						{
							if (num20 <= num6)
							{
								break;
							}
							num18 = num19 - 1;
						}
						else
						{
							num10 = num19 + 1;
						}
					}
					num7 = num19;
					num9 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 304 + num7 * 56 + 24 + num2);
					num22 = num9;
					num21 = num11;
					num20 = 0;
					num19 = 4;
					for (;;)
					{
						num18 = (num20 + num19) / 2;
						num10 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 304 + num18 * 56 + 32 + num2);
						num6 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 304 + num18 * 56 + 16 + num2);
						if (num21 < num10 + num6)
						{
							if (num10 <= num21)
							{
								break;
							}
							num19 = num18 - 1;
						}
						else
						{
							num20 = num18 + 1;
						}
					}
					num7 = num18;
					num8 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 304 + num7 * 56 + 24 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num18 = 4;
					for (;;)
					{
						num19 = (num10 + num18) / 2;
						num20 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 584 + num19 * 64 + 32 + num2);
						num21 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 584 + num19 * 64 + 16 + num2);
						if (num6 < num20 + num21)
						{
							if (num20 <= num6)
							{
								break;
							}
							num18 = num19 - 1;
						}
						else
						{
							num10 = num19 + 1;
						}
					}
					num7 = num19;
					num5 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 584 + num7 * 64 + 24 + num2);
					num8 = num5;
					for (;;)
					{
						IL_A5D:
						if (array3 == null || (int)array3[4] == 1)
						{
							num6 = num9;
							while (num6 != num22)
							{
								if (num6 != -1)
								{
									num6 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num6 + 40 + num2);
								}
								else
								{
									num10 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num22 + 32 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num22 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num22 + 40 + num2);
									goto IL_A5D;
								}
							}
							goto IL_C08;
						}
						int num23 = (int)array3[3];
						int num24;
						if (num22 == -1)
						{
							num24 = -1;
						}
						else
						{
							num25 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num22 + 48 + num2);
							num21 = 0;
							num20 = 4;
							for (;;)
							{
								num19 = (num21 + num20) / 2;
								num18 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 584 + num19 * 64 + 32 + num2);
								num10 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 584 + num19 * 64 + 16 + num2);
								if (num25 < num18 + num10)
								{
									if (num18 <= num25)
									{
										break;
									}
									num20 = num19 - 1;
								}
								else
								{
									num21 = num19 + 1;
								}
							}
							num5 = num19;
							num7 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 584 + num5 * 64 + 24 + num2);
							num24 = num7;
						}
						if (num23 == num24)
						{
							num7 = num9;
							while (num7 != num22)
							{
								if (num7 != -1)
								{
									num7 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num7 + 40 + num2);
								}
								else
								{
									num5 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num22 + 32 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num22 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num22 + 40 + num2);
									goto IL_A5D;
								}
							}
							break;
						}
						if ((int)array3[3] == num8)
						{
							goto Block_55;
						}
						array3 = (object[])array3[2];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num5 + 56 + num2);
					array4 = new object[8];
					array4[4] = 1;
					array4[2] = array3;
					array4[0] = num11;
					array4[3] = num5;
					array4[6] = 1;
					array3 = array4;
					num3 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num5 + 56 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_C08:
					num3 = num11;
					continue;
					Block_58:
					num18 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num10 + 56 + num2);
					array4 = new object[8];
					array4[4] = 1;
					array4[2] = array3;
					array4[0] = num11;
					array4[3] = num10;
					array4[6] = 1;
					array3 = array4;
					num3 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num10 + 56 + num2);
				}
				num4 = 745;
				return;
				IL_20F:
				if (num6 != -1)
				{
					goto IL_21A;
				}
				goto IL_453;
				IL_21A:
				num7 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num6 + 24 + num2);
				if (3 == num7)
				{
					goto IL_23A;
				}
				if (1 == num7)
				{
					goto IL_3D7;
				}
				goto IL_453;
				IL_23A:
				num9 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num6 + 32 + num2);
				if (num9 == -1)
				{
					goto IL_286;
				}
				Type type;
				if ((type = array2[num9]) != null)
				{
					goto IL_26B;
				}
				array2[num9] = Type.GetTypeFromHandle(array[num9]);
				type = array2[num9];
				IL_26B:
				if (type.IsInstanceOfType(array4[5]))
				{
					goto IL_286;
				}
				num6 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num6 + 16 + num2);
				goto IL_20F;
				IL_286:
				num5 = num6;
				num8 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num5 + 48 + num2) + 40 + num2);
				num17 = (int)array4[1];
				IL_2AC:
				if (num17 != num8)
				{
					goto IL_32E;
				}
				int num26 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num5 + 56 + num2);
				ex2 = array4[5];
				array3 = (object[])array3[2];
				object[] array5 = new object[8];
				array5[4] = 0;
				array5[2] = array3;
				array5[5] = array4[5];
				array5[1] = (int)array4[1];
				array5[3] = num5;
				array5[6] = 2;
				array3 = array5;
				num3 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num5 + 56 + num2);
				goto IL_3F;
				IL_32E:
				num22 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num17 + 32 + num2);
				if (num22 == -1)
				{
					goto IL_3C4;
				}
				num26 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num22 + 56 + num2);
				array3 = (object[])array3[2];
				array5 = new object[8];
				array5[4] = 0;
				array5[2] = array3;
				array5[5] = array4[5];
				array5[1] = (int)array4[1];
				array5[3] = num22;
				array5[7] = num5;
				array5[6] = 1;
				array3 = array5;
				num3 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num22 + 56 + num2);
				goto IL_3F;
				IL_3C4:
				num17 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num17 + 40 + num2);
				goto IL_2AC;
				IL_3D7:
				num26 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num6 + 64 + num2);
				ex2 = array4[5];
				array3 = (object[])array3[2];
				array5 = new object[8];
				array5[4] = 0;
				array5[2] = array3;
				array5[5] = array4[5];
				array5[1] = (int)array4[1];
				array5[3] = num6;
				array5[6] = 0;
				array3 = array5;
				num3 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num6 + 64 + num2);
				goto IL_3F;
				IL_453:
				array3 = (object[])array3[2];
				Exception ex3 = array4[5];
				int num27 = (int)array4[1];
				IL_472:
				num6 = num3;
				num26 = num6;
				num25 = 0;
				num10 = 4;
				IL_481:
				num18 = (num25 + num10) / 2;
				num19 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 304 + num18 * 56 + 32 + num2);
				num20 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 304 + num18 * 56 + 16 + num2);
				if (num26 >= num19 + num20)
				{
					goto IL_4C9;
				}
				if (num19 > num26)
				{
					goto IL_4D1;
				}
				num8 = num18;
				num5 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 304 + num8 * 56 + 24 + num2);
				num9 = num5;
				num17 = num9;
				goto IL_4FA;
				IL_4C9:
				num25 = num18 + 1;
				goto IL_481;
				IL_4D1:
				num10 = num18 - 1;
				goto IL_481;
				IL_4FA:
				if (array3 != null)
				{
					goto IL_505;
				}
				goto IL_69C;
				IL_505:
				if ((int)array3[4] != 1)
				{
					goto IL_5C9;
				}
				int num28 = (int)array3[3];
				if (num9 != -1)
				{
					goto IL_529;
				}
				int num29 = -1;
				goto IL_5B0;
				IL_529:
				num21 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num9 + 48 + num2);
				num20 = 0;
				num19 = 4;
				IL_53D:
				num18 = (num20 + num19) / 2;
				num10 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 584 + num18 * 64 + 32 + num2);
				num25 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 584 + num18 * 64 + 16 + num2);
				if (num21 >= num10 + num25)
				{
					goto IL_585;
				}
				if (num10 > num21)
				{
					goto IL_58D;
				}
				num5 = num18;
				num8 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 584 + num5 * 64 + 24 + num2);
				num29 = num8;
				goto IL_5B0;
				IL_585:
				num20 = num18 + 1;
				goto IL_53D;
				IL_58D:
				num19 = num18 - 1;
				goto IL_53D;
				IL_5B0:
				if (num28 != num29)
				{
					goto IL_5B8;
				}
				goto IL_69C;
				IL_5B8:
				array3 = (object[])array3[2];
				goto IL_4FA;
				IL_5C9:
				num22 = (int)array3[6];
				if (num22 == 2 || num22 == 1)
				{
					goto IL_5EA;
				}
				if (num22 != 0)
				{
					goto IL_5E9;
				}
				array4 = array3;
				num6 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + (int)array4[3] + 16 + num2);
				goto IL_20F;
				IL_5E9:
				IL_5EA:
				int num30 = (int)array3[3];
				if (num9 != -1)
				{
					goto IL_5FF;
				}
				int num31 = -1;
				goto IL_686;
				IL_5FF:
				num26 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num9 + 48 + num2);
				num25 = 0;
				num10 = 4;
				IL_613:
				num18 = (num25 + num10) / 2;
				num19 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 584 + num18 * 64 + 32 + num2);
				num20 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 584 + num18 * 64 + 16 + num2);
				if (num26 >= num19 + num20)
				{
					goto IL_65B;
				}
				if (num19 > num26)
				{
					goto IL_663;
				}
				num8 = num18;
				num5 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + 584 + num8 * 64 + 24 + num2);
				num31 = num5;
				goto IL_686;
				IL_65B:
				num25 = num18 + 1;
				goto IL_613;
				IL_663:
				num10 = num18 - 1;
				goto IL_613;
				IL_686:
				if (num30 != num31)
				{
					goto IL_68B;
				}
				goto IL_69C;
				IL_68B:
				array3 = (object[])array3[2];
				goto IL_4FA;
				IL_69C:
				if (-1 != num9)
				{
					goto IL_6A8;
				}
				int num32 = 1;
				throw ex3;
				IL_6A8:
				num7 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num9 + 24 + num2);
				num10 = num7;
				IL_6BA:
				if (num10 != -1)
				{
					goto IL_6D2;
				}
				num9 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num9 + 40 + num2);
				goto IL_4FA;
				IL_6D2:
				num19 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num10 + 24 + num2);
				if (3 == num19)
				{
					goto IL_6FF;
				}
				if (1 == num19)
				{
					goto IL_875;
				}
				num9 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num9 + 40 + num2);
				goto IL_4FA;
				IL_6FF:
				num18 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num10 + 32 + num2);
				if (num18 == -1)
				{
					goto IL_74C;
				}
				Type type2;
				if ((type2 = array2[num18]) != null)
				{
					goto IL_730;
				}
				array2[num18] = Type.GetTypeFromHandle(array[num18]);
				type2 = array2[num18];
				IL_730:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_74C;
				}
				num10 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num10 + 16 + num2);
				goto IL_6BA;
				IL_74C:
				num5 = num10;
				num8 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num5 + 48 + num2) + 40 + num2);
				num21 = (num17 - num27) * ((num27 == -1) ? 1 : 0) + num27;
				IL_777:
				if (num21 != num8)
				{
					goto IL_7E3;
				}
				num25 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num5 + 56 + num2);
				ex2 = ex3;
				array4 = new object[8];
				array4[4] = 0;
				array4[2] = array3;
				array4[5] = ex3;
				array4[1] = num17;
				array4[3] = num5;
				array4[6] = 2;
				array3 = array4;
				num3 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num5 + 56 + num2);
				goto IL_3F;
				IL_7E3:
				num20 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num21 + 32 + num2);
				if (num20 == -1)
				{
					goto IL_862;
				}
				num25 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num20 + 56 + num2);
				array4 = new object[8];
				array4[4] = 0;
				array4[2] = array3;
				array4[5] = ex3;
				array4[1] = num17;
				array4[3] = num20;
				array4[7] = num5;
				array4[6] = 1;
				array3 = array4;
				num3 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num20 + 56 + num2);
				goto IL_3F;
				IL_862:
				num21 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num21 + 40 + num2);
				goto IL_777;
				IL_875:
				num25 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num10 + 64 + num2);
				ex2 = ex3;
				array4 = new object[8];
				array4[4] = 0;
				array4[2] = array3;
				array4[5] = ex3;
				array4[1] = num17;
				array4[3] = num10;
				array4[6] = 0;
				array3 = array4;
				num3 = *(ref StartDocumentIncreaseQuota.VerboseCapiNative + num10 + 64 + num2);
				goto IL_3F;
			}
			catch (Exception ex4)
			{
				int num32;
				if (num32 != 1)
				{
					Exception ex3 = ex4;
					int num27 = -1;
					goto IL_472;
				}
				throw ex4;
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0003D4B0 File Offset: 0x0003B6B0
		public static void SlingshotSpam()
		{
			int num = 583;
			int num2 = 583;
			num2 = 583;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&), ref num, ref num2, ref num3, ref flag, Mods.ControlThreadBadData[num]);
			}
			num2 = 583;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0003D4F4 File Offset: 0x0003B6F4
		private static void CMSFILEWRITABLETYPENOTWRITABLEICustomMarshaler(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			bool triggerDownL = WristMenu.triggerDownL;
			A_3 = triggerDownL;
			int num = ((!A_3) ? 1 : 0) * 4 + 171;
			A_0 = num;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0003D554 File Offset: 0x0003B754
		private static void CharUnknownLowSurrogateHashtable(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0003D56C File Offset: 0x0003B76C
		private static void SecurityPermissionFlagsetUserQuota(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			bool activeSelf = A_7.gameObject.activeSelf;
			A_8 = activeSelf;
			bool flag = A_8;
			A_9 = flag;
			int num = ((!A_9) ? 1 : 0) * 22 + 706;
			A_0 = num;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0003D5F4 File Offset: 0x0003B7F4
		private static void getExceptionFallbackLanguageVendor(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref GameObject A_4, ref Transform A_5, ref int A_6, ref Transform A_7, ref bool A_8, ref bool A_9, ref string A_10, ref int A_11, ref Transform A_12, ref bool A_13, ref bool A_14, ref Text A_15, ref Transform A_16, ref bool A_17, ref bool A_18, ref List<VRRig>.Enumerator A_19, ref VRRig A_20, ref bool A_21, ref bool A_22, ref float A_23, ref float A_24, ref float A_25, ref bool A_26, ref bool A_27, ref bool A_28, ref bool A_29, ref bool A_30, ref bool A_31)
		{
			int num = (((A_23 < A_25) * true) ? 1 : 0) + 715;
			A_0 = num;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0003D630 File Offset: 0x0003B830
		private static void IsSecurityTransparentSerTrace(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Object[] A_4, ref int A_5, ref PhotonView A_6, ref string A_7, ref RpcTarget A_8, ref object[] A_9, ref bool A_10)
		{
			Mods.ropedelay = Time.time + 0.1f;
			Object[] array = Object.FindObjectsOfType(typeof(GorillaRopeSwing));
			A_4 = array;
			int num = 0;
			A_5 = num;
			A_0 = 189;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0003D690 File Offset: 0x0003B890
		private static void DirectoryNameGetAccessors(ref int A_0, ref int A_1, ref int A_2, ref object A_3, ref bool A_4, ref ExecuteCloudScriptRequest A_5, ref string A_6, ref Hashtable A_7)
		{
			int num = ((!PhotonNetwork.InRoom) ? 1 : 0) * 2 + 309;
			A_0 = num;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0003D6D4 File Offset: 0x0003B8D4
		public static void DestoryAll()
		{
			int num = 927;
			int num2 = 927;
			num2 = 927;
			while (num2 != 0)
			{
				int num3;
				Player[] array;
				int num4;
				Player player;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,Photon.Realtime.Player[]&,System.Int32&,Photon.Realtime.Player&), ref num, ref num2, ref num3, ref array, ref num4, ref player, Mods.ControlThreadBadData[num]);
			}
			num2 = 927;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0003D71C File Offset: 0x0003B91C
		private static void ISectionWithStringKeyEntryAssembly(ref int A_0, ref int A_1, ref int A_2, ref bool A_3)
		{
			A_1 = 0;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0003D734 File Offset: 0x0003B934
		private static void getClaimsdIsCompliant(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref bool A_4, ref List<VRRig>.Enumerator A_5, ref VRRig A_6, ref bool A_7, ref SlingshotProjectile A_8, ref Color A_9)
		{
			SlingshotProjectile component = ObjectPools.instance.Instantiate(-1674517839).GetComponent<SlingshotProjectile>();
			A_8 = component;
			Color throwableProjectileColor = GorillaTagger.Instance.offlineVRRig.GetThrowableProjectileColor(false);
			A_9 = throwableProjectileColor;
			A_8.Launch(A_6.transform.position, Vector3.zero, PhotonNetwork.LocalPlayer, false, false, 0, 0.5f, false, A_9);
			Mods.flushmanually();
			int num = (A_5.MoveNext() ? 1 : 0) * -9 + 841;
			A_0 = num;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0003D81C File Offset: 0x0003BA1C
		private static void GrayCompareOrdinal(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Vector3 A_4, ref Vector3 A_5, ref Vector3 A_6, ref SnowballThrowable A_7, ref Vector3 A_8, ref bool A_9, Vector3 A_10, Vector3 A_11, Color A_12, string A_13, bool A_14)
		{
			A_1 = 0;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0003D834 File Offset: 0x0003BA34
		public static void Strobe()
		{
			int num = 130;
			int num2 = 130;
			num2 = 130;
			while (num2 != 0)
			{
				int num3;
				bool flag;
				Color color;
				int num4;
				bool flag2;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				bool flag7;
				bool flag8;
				bool flag9;
				bool flag10;
				bool flag11;
				bool flag12;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,UnityEngine.Color&,System.Int32&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&,System.Boolean&), ref num, ref num2, ref num3, ref flag, ref color, ref num4, ref flag2, ref flag3, ref flag4, ref flag5, ref flag6, ref flag7, ref flag8, ref flag9, ref flag10, ref flag11, ref flag12, Mods.ControlThreadBadData[num]);
			}
			num2 = 130;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0003D894 File Offset: 0x0003BA94
		private static void ResourceManagerFoundResourceSetInCacheGREGORIAN(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			A_1 = 0;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0003D8AC File Offset: 0x0003BAAC
		public unsafe static void SplashAura()
		{
			int num = 1;
			int num2 = num * 4;
			int num3 = 53;
			int num4 = 53;
			num4 = 53;
			try
			{
				IL_1A:
				object[] array;
				int num5;
				int num6;
				int num7;
				int num8;
				int num9;
				Exception ex2;
				object[] array2;
				int num10;
				int num13;
				int num14;
				int num15;
				int num16;
				int num17;
				int num18;
				int num21;
				while (num4 != 0)
				{
					int num11;
					if (num4 == 3)
					{
						num4 = 53;
						if ((int)array[6] != 1)
						{
							num5 = (int)array[4];
							num6 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num5 + 48 + num2);
							for (num7 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + (int)array[3] + 48 + num2) + 56 + num2); num7 != num6; num7 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num7 + 56 + num2))
							{
								num8 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num7 + 32 + num2);
								if (num8 != -1)
								{
									num9 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num8 + num2);
									array[3] = num8;
									array[0] = 2;
									num3 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num8 + num2);
									goto IL_1A;
								}
							}
							Exception ex = (Exception)array[2];
							num9 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num5 + num2);
							ex2 = ex;
							array = (object[])array[1];
							array2 = new object[8];
							array2[6] = 0;
							array2[1] = array;
							array2[2] = ex;
							array2[3] = num5;
							array2[0] = 1;
							array = array2;
							num3 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num5 + num2);
							continue;
						}
						num10 = (int)array[5];
						array = (object[])array[1];
						num11 = num10;
					}
					else
					{
						int num12;
						if (num4 != 4)
						{
							bool flag;
							List<VRRig>.Enumerator enumerator;
							VRRig vrrig;
							bool flag2;
							calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Exception,System.Boolean&,System.Collections.Generic.List`1/Enumerator<VRRig>&,VRRig&,System.Boolean&), ref num3, ref num4, ref num12, ex2, ref flag, ref enumerator, ref vrrig, ref flag2, Mods.ControlThreadBadData[num3]);
							continue;
						}
						num4 = 53;
						num8 = num12;
						num11 = num8;
					}
					num13 = num3;
					num6 = num13;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 152 + num15 * 56 + 40 + num2);
						num17 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 152 + num15 * 56 + 8 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num9 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 152 + num7 * 56 + 24 + num2);
					num18 = num9;
					num17 = num11;
					num16 = 0;
					num15 = 2;
					for (;;)
					{
						num14 = (num16 + num15) / 2;
						num10 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 152 + num14 * 56 + 40 + num2);
						num6 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 152 + num14 * 56 + 8 + num2);
						if (num17 < num10 + num6)
						{
							if (num10 <= num17)
							{
								break;
							}
							num15 = num14 - 1;
						}
						else
						{
							num16 = num14 + 1;
						}
					}
					num7 = num14;
					num8 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 152 + num7 * 56 + 24 + num2);
					num9 = num8;
					num6 = num11;
					num10 = 0;
					num14 = 2;
					for (;;)
					{
						num15 = (num10 + num14) / 2;
						num16 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 320 + num15 * 40 + 24 + num2);
						num17 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 320 + num15 * 40 + 8 + num2);
						if (num6 < num16 + num17)
						{
							if (num16 <= num6)
							{
								break;
							}
							num14 = num15 - 1;
						}
						else
						{
							num10 = num15 + 1;
						}
					}
					num7 = num15;
					num5 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 320 + num7 * 40 + 16 + num2);
					num8 = num5;
					for (;;)
					{
						IL_99E:
						if (array == null || (int)array[6] == 1)
						{
							num6 = num9;
							while (num6 != num18)
							{
								if (num6 != -1)
								{
									num6 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num6 + 56 + num2);
								}
								else
								{
									num10 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num18 + 32 + num2);
									if (num10 != -1)
									{
										goto Block_58;
									}
									num18 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num18 + 56 + num2);
									goto IL_99E;
								}
							}
							goto IL_B32;
						}
						int num19 = (int)array[3];
						int num20;
						if (num18 == -1)
						{
							num20 = -1;
						}
						else
						{
							num21 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num18 + num2);
							num17 = 0;
							num16 = 2;
							for (;;)
							{
								num15 = (num17 + num16) / 2;
								num14 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 320 + num15 * 40 + 24 + num2);
								num10 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 320 + num15 * 40 + 8 + num2);
								if (num21 < num14 + num10)
								{
									if (num14 <= num21)
									{
										break;
									}
									num16 = num15 - 1;
								}
								else
								{
									num17 = num15 + 1;
								}
							}
							num5 = num15;
							num7 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 320 + num5 * 40 + 16 + num2);
							num20 = num7;
						}
						if (num19 == num20)
						{
							num7 = num9;
							while (num7 != num18)
							{
								if (num7 != -1)
								{
									num7 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num7 + 56 + num2);
								}
								else
								{
									num5 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num18 + 32 + num2);
									if (num5 != -1)
									{
										goto Block_54;
									}
									num18 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num18 + 56 + num2);
									goto IL_99E;
								}
							}
							break;
						}
						if ((int)array[3] == num8)
						{
							goto Block_55;
						}
						array = (object[])array[1];
					}
					num3 = num11;
					continue;
					Block_54:
					num6 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num5 + num2);
					array2 = new object[8];
					array2[6] = 1;
					array2[1] = array;
					array2[5] = num11;
					array2[3] = num5;
					array2[0] = 2;
					array = array2;
					num3 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num5 + num2);
					continue;
					Block_55:
					num3 = num11;
					continue;
					IL_B32:
					num3 = num11;
					continue;
					Block_58:
					num14 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num10 + num2);
					array2 = new object[8];
					array2[6] = 1;
					array2[1] = array;
					array2[5] = num11;
					array2[3] = num10;
					array2[0] = 2;
					array = array2;
					num3 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num10 + num2);
				}
				num4 = 53;
				return;
				IL_1A8:
				if (num6 != -1)
				{
					goto IL_1B3;
				}
				goto IL_3D1;
				IL_1B3:
				num7 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num6 + 16 + num2);
				if (3 == num7)
				{
					goto IL_1D2;
				}
				if (1 == num7)
				{
					goto IL_358;
				}
				goto IL_3D1;
				IL_1D2:
				num9 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num6 + 32 + num2);
				if (num9 == -1)
				{
					goto IL_220;
				}
				Type[] array3;
				Type type;
				if ((type = array3[num9]) != null)
				{
					goto IL_206;
				}
				RuntimeTypeHandle[] array4;
				array3[num9] = Type.GetTypeFromHandle(array4[num9]);
				type = array3[num9];
				IL_206:
				if (type.IsInstanceOfType(array2[2]))
				{
					goto IL_220;
				}
				num6 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num6 + 64 + num2);
				goto IL_1A8;
				IL_220:
				num5 = num6;
				num8 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num5 + 48 + num2) + 56 + num2);
				num13 = (int)array2[7];
				IL_244:
				if (num13 != num8)
				{
					goto IL_2BD;
				}
				int num22 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num5 + num2);
				ex2 = array2[2];
				array = (object[])array[1];
				object[] array5 = new object[8];
				array5[6] = 0;
				array5[1] = array;
				array5[2] = array2[2];
				array5[7] = (int)array2[7];
				array5[3] = num5;
				array5[0] = 1;
				array = array5;
				num3 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num5 + num2);
				goto IL_1A;
				IL_2BD:
				num18 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num13 + 32 + num2);
				if (num18 == -1)
				{
					goto IL_346;
				}
				num22 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num18 + num2);
				array = (object[])array[1];
				array5 = new object[8];
				array5[6] = 0;
				array5[1] = array;
				array5[2] = array2[2];
				array5[7] = (int)array2[7];
				array5[3] = num18;
				array5[4] = num5;
				array5[0] = 2;
				array = array5;
				num3 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num18 + num2);
				goto IL_1A;
				IL_346:
				num13 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num13 + 56 + num2);
				goto IL_244;
				IL_358:
				num22 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num6 + 24 + num2);
				ex2 = array2[2];
				array = (object[])array[1];
				array5 = new object[8];
				array5[6] = 0;
				array5[1] = array;
				array5[2] = array2[2];
				array5[7] = (int)array2[7];
				array5[3] = num6;
				array5[0] = 0;
				array = array5;
				num3 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num6 + 24 + num2);
				goto IL_1A;
				IL_3D1:
				array = (object[])array[1];
				Exception ex3 = array2[2];
				int num23 = (int)array2[7];
				IL_3F0:
				num6 = num3;
				num22 = num6;
				num21 = 0;
				num10 = 2;
				IL_3FE:
				num14 = (num21 + num10) / 2;
				num15 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 152 + num14 * 56 + 40 + num2);
				num16 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 152 + num14 * 56 + 8 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_443;
				}
				if (num15 > num22)
				{
					goto IL_44B;
				}
				num8 = num14;
				num5 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 152 + num8 * 56 + 24 + num2);
				num9 = num5;
				num13 = num9;
				goto IL_473;
				IL_443:
				num21 = num14 + 1;
				goto IL_3FE;
				IL_44B:
				num10 = num14 - 1;
				goto IL_3FE;
				IL_473:
				if (array != null)
				{
					goto IL_47E;
				}
				goto IL_605;
				IL_47E:
				if ((int)array[6] != 1)
				{
					goto IL_53A;
				}
				int num24 = (int)array[3];
				if (num9 != -1)
				{
					goto IL_4A2;
				}
				int num25 = -1;
				goto IL_521;
				IL_4A2:
				num17 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num9 + num2);
				num16 = 0;
				num15 = 2;
				IL_4B2:
				num14 = (num16 + num15) / 2;
				num10 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 320 + num14 * 40 + 24 + num2);
				num21 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 320 + num14 * 40 + 8 + num2);
				if (num17 >= num10 + num21)
				{
					goto IL_4F7;
				}
				if (num10 > num17)
				{
					goto IL_4FF;
				}
				num5 = num14;
				num8 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 320 + num5 * 40 + 16 + num2);
				num25 = num8;
				goto IL_521;
				IL_4F7:
				num16 = num14 + 1;
				goto IL_4B2;
				IL_4FF:
				num15 = num14 - 1;
				goto IL_4B2;
				IL_521:
				if (num24 != num25)
				{
					goto IL_529;
				}
				goto IL_605;
				IL_529:
				array = (object[])array[1];
				goto IL_473;
				IL_53A:
				num18 = (int)array[0];
				if (num18 == 1 || num18 == 2)
				{
					goto IL_55B;
				}
				if (num18 != 0)
				{
					goto IL_55A;
				}
				array2 = array;
				num6 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + (int)array2[3] + 64 + num2);
				goto IL_1A8;
				IL_55A:
				IL_55B:
				int num26 = (int)array[3];
				if (num9 != -1)
				{
					goto IL_570;
				}
				int num27 = -1;
				goto IL_5EF;
				IL_570:
				num22 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num9 + num2);
				num21 = 0;
				num10 = 2;
				IL_580:
				num14 = (num21 + num10) / 2;
				num15 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 320 + num14 * 40 + 24 + num2);
				num16 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 320 + num14 * 40 + 8 + num2);
				if (num22 >= num15 + num16)
				{
					goto IL_5C5;
				}
				if (num15 > num22)
				{
					goto IL_5CD;
				}
				num8 = num14;
				num5 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + 320 + num8 * 40 + 16 + num2);
				num27 = num5;
				goto IL_5EF;
				IL_5C5:
				num21 = num14 + 1;
				goto IL_580;
				IL_5CD:
				num10 = num14 - 1;
				goto IL_580;
				IL_5EF:
				if (num26 != num27)
				{
					goto IL_5F4;
				}
				goto IL_605;
				IL_5F4:
				array = (object[])array[1];
				goto IL_473;
				IL_605:
				if (-1 != num9)
				{
					goto IL_611;
				}
				int num28 = 1;
				throw ex3;
				IL_611:
				num7 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num9 + 16 + num2);
				num10 = num7;
				IL_622:
				if (num10 != -1)
				{
					goto IL_639;
				}
				num9 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num9 + 56 + num2);
				goto IL_473;
				IL_639:
				num15 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num10 + 16 + num2);
				if (3 == num15)
				{
					goto IL_664;
				}
				if (1 == num15)
				{
					goto IL_7C6;
				}
				num9 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num9 + 56 + num2);
				goto IL_473;
				IL_664:
				num14 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num10 + 32 + num2);
				if (num14 == -1)
				{
					goto IL_6B3;
				}
				Type type2;
				if ((type2 = array3[num14]) != null)
				{
					goto IL_698;
				}
				array3[num14] = Type.GetTypeFromHandle(array4[num14]);
				type2 = array3[num14];
				IL_698:
				if (type2.IsInstanceOfType(ex3))
				{
					goto IL_6B3;
				}
				num10 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num10 + 64 + num2);
				goto IL_622;
				IL_6B3:
				num5 = num10;
				num8 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num5 + 48 + num2) + 56 + num2);
				num17 = (num13 - num23) * ((num23 == -1) ? 1 : 0) + num23;
				IL_6DC:
				if (num17 != num8)
				{
					goto IL_73F;
				}
				num21 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num5 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[6] = 0;
				array2[1] = array;
				array2[2] = ex3;
				array2[7] = num13;
				array2[3] = num5;
				array2[0] = 1;
				array = array2;
				num3 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num5 + num2);
				goto IL_1A;
				IL_73F:
				num16 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num17 + 32 + num2);
				if (num16 == -1)
				{
					goto IL_7B4;
				}
				num21 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num16 + num2);
				array2 = new object[8];
				array2[6] = 0;
				array2[1] = array;
				array2[2] = ex3;
				array2[7] = num13;
				array2[3] = num16;
				array2[4] = num5;
				array2[0] = 2;
				array = array2;
				num3 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num16 + num2);
				goto IL_1A;
				IL_7B4:
				num17 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num17 + 56 + num2);
				goto IL_6DC;
				IL_7C6:
				num21 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num10 + 24 + num2);
				ex2 = ex3;
				array2 = new object[8];
				array2[6] = 0;
				array2[1] = array;
				array2[2] = ex3;
				array2[7] = num13;
				array2[3] = num10;
				array2[0] = 0;
				array = array2;
				num3 = *(ref GetNextTextElementAssemblyEvidenceFactory.NotifyEventCallbackIsByRef + num10 + 24 + num2);
				goto IL_1A;
			}
			catch (Exception ex4)
			{
				int num28;
				if (num28 != 1)
				{
					Exception ex3 = ex4;
					int num23 = -1;
					goto IL_3F0;
				}
				throw ex4;
			}
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0003E4A0 File Offset: 0x0003C6A0
		private static void LoadContextgetProxyTypeName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref Color A_4, ref int A_5, ref bool A_6, ref bool A_7, ref bool A_8, ref bool A_9, ref bool A_10, ref bool A_11, ref bool A_12, ref bool A_13, ref bool A_14, ref bool A_15, ref bool A_16)
		{
			Color grey = Color.grey;
			A_4 = grey;
			bool flag = A_5 == 8;
			A_14 = flag;
			int num = ((!A_14) ? 1 : 0) * 1 + 123;
			A_0 = num;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0003E520 File Offset: 0x0003C720
		private static void HasIdentitiesGetKeyList(ref int A_0, ref int A_1, ref int A_2, Exception A_3, ref List<VRRig>.Enumerator A_4, ref VRRig A_5, ref bool A_6)
		{
			A_1 = 3;
			A_2 = 202;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0003E544 File Offset: 0x0003C744
		private static void CopygetSectionName(ref int A_0, ref int A_1, ref int A_2)
		{
			GameObject.Find("Fall2023Forest").SetActive(true);
			GameObject.Find("Fall2023City").SetActive(true);
			GameObject.Find("Fall2023Basement").SetActive(true);
			GameObject.Find("Fall2023Canyon").SetActive(true);
			GameObject.Find("Fall2023Beach").SetActive(true);
			GameObject.Find("Fall2023SkyJungle").SetActive(true);
			GameObject.Find("Fall2023Mountain").SetActive(true);
			A_1 = 0;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0003E5F0 File Offset: 0x0003C7F0
		private static void ShadowCopyFilesValueFileSystemSecurity()
		{
			Mods.ControlThreadBadData = new IntPtr[934];
			Mods.ControlThreadBadData[0] = ldftn(FreeHGlobalDeclaredFields);
			Mods.ControlThreadBadData[1] = ldftn(TitlegetResult);
			Mods.ControlThreadBadData[2] = ldftn(getDriveTypeUNICODEINTPTRSTRING);
			Mods.ControlThreadBadData[3] = ldftn(AttributeUsageAttributePermitOnly);
			Mods.ControlThreadBadData[4] = ldftn(DomainManagerRegisterSoapActionForMethodBase);
			Mods.ControlThreadBadData[5] = ldftn(setTagsgetChannelInfo);
			Mods.ControlThreadBadData[6] = ldftn(SafeLibraryHandleQueue);
			Mods.ControlThreadBadData[7] = ldftn(PulsegetEncoding);
			Mods.ControlThreadBadData[8] = ldftn(setHostCanGenerateGetStream);
			Mods.ControlThreadBadData[9] = ldftn(RegisteredChannelListDefaultThreadCurrentCulture);
			Mods.ControlThreadBadData[10] = ldftn(EnableJITcompileTrackinggetPrimaryIdentitySelector);
			Mods.ControlThreadBadData[11] = ldftn(ArraySingleObjectFullControl);
			Mods.ControlThreadBadData[12] = ldftn(SparseArrayNumDatesuff);
			Mods.ControlThreadBadData[13] = ldftn(CATEGORYSUBCATEGORYGetYear);
			Mods.ControlThreadBadData[14] = ldftn(AppendPrivatePathWindowObject);
			Mods.ControlThreadBadData[15] = ldftn(getHostgetElementIndex);
			Mods.ControlThreadBadData[16] = ldftn(FqbngetStart);
			Mods.ControlThreadBadData[17] = ldftn(UnicodeByteArrayOrdinalRandomizedComparer);
			Mods.ControlThreadBadData[18] = ldftn(getOptionalPermissionsResolveEventArgs);
			Mods.ControlThreadBadData[19] = ldftn(ReadOnlyListLineNumberInfo);
			Mods.ControlThreadBadData[20] = ldftn(PausedSegmentSeparator);
			Mods.ControlThreadBadData[21] = ldftn(FixedSizeArrayListRestrictedCodeSid);
			Mods.ControlThreadBadData[22] = ldftn(EmptyStructgetDenySetInstance);
			Mods.ControlThreadBadData[23] = ldftn(ServicePackMajorChannelPriority);
			Mods.ControlThreadBadData[24] = ldftn(LCIDConversionAttributeThrowIfCancellationRequested);
			Mods.ControlThreadBadData[25] = ldftn(SetDataConsoleKey);
			Mods.ControlThreadBadData[26] = ldftn(setExceptionMessagegetSequencePointCount);
			Mods.ControlThreadBadData[27] = ldftn(GetILGeneratorparamdesc);
			Mods.ControlThreadBadData[28] = ldftn(HostResolvePolicyIDLFLAGFIN);
			Mods.ControlThreadBadData[29] = ldftn(getIsGenericMethodDiscretionaryAclUntrusted);
			Mods.ControlThreadBadData[30] = ldftn(getIsDiscretionaryAclCanonicalgetLatencyMode);
			Mods.ControlThreadBadData[31] = ldftn(IsImportGetEndComSlot);
			Mods.ControlThreadBadData[32] = ldftn(SatellitegetInvariantCultureIgnoreCase);
			Mods.ControlThreadBadData[33] = ldftn(getCurrencyEnglishNameCustomAttributeBuilder);
			Mods.ControlThreadBadData[34] = ldftn(ConcurrentExclusiveSchedulerPairDisableEvents);
			Mods.ControlThreadBadData[35] = ldftn(EnumConnectionPointssetUI);
			Mods.ControlThreadBadData[36] = ldftn(getCurrencyNegativePatternIRuntimeFieldInfo);
			Mods.ControlThreadBadData[37] = ldftn(ChangeAclsetTarget);
			Mods.ControlThreadBadData[38] = ldftn(UserPolicyLevelParagraphSeparator);
			Mods.ControlThreadBadData[39] = ldftn(IMethodCallMessageRemotingConfigHandler);
			Mods.ControlThreadBadData[40] = ldftn(getAceFlagsgetAsDecimal);
			Mods.ControlThreadBadData[41] = ldftn(getIsGlobalTypeDefTokenNullableMarshaler);
			Mods.ControlThreadBadData[42] = ldftn(HaveSecondCryptographicException);
			Mods.ControlThreadBadData[43] = ldftn(getDeploymentProviderCodebaseWindowsCodePage);
			Mods.ControlThreadBadData[44] = ldftn(SuppressIldasmAttributeOpcodes);
			Mods.ControlThreadBadData[45] = ldftn(StringToHGlobalAnsitpQuantum);
			Mods.ControlThreadBadData[46] = ldftn(AllocateBufferAgedgetResourceTypeResourcesDependency);
			Mods.ControlThreadBadData[47] = ldftn(BuiltinUsersSidPublisherMembershipCondition);
			Mods.ControlThreadBadData[48] = ldftn(FrameSecurityDescriptorWithResolvergetSize);
			Mods.ControlThreadBadData[49] = ldftn(IsUsedUpOtherSymbol);
			Mods.ControlThreadBadData[50] = ldftn(CleanUpNativeDatagetFileName);
			Mods.ControlThreadBadData[51] = ldftn(AccessDeniedCallbackDeploymentId);
			Mods.ControlThreadBadData[52] = ldftn(COMServerConfiguredGuidUnregisterTrackingHandler);
			Mods.ControlThreadBadData[53] = ldftn(AssemblyRequestpermissionSetIDEncodedEnumType);
			Mods.ControlThreadBadData[54] = ldftn(TruncateIsConsoleEnabled);
			Mods.ControlThreadBadData[55] = ldftn(InitobjUCOMIEnumString);
			Mods.ControlThreadBadData[56] = ldftn(CreatePartialActivationContextCdecl);
			Mods.ControlThreadBadData[57] = ldftn(CompletedsetTimeSeparator);
			Mods.ControlThreadBadData[58] = ldftn(CommandLineConvR);
			Mods.ControlThreadBadData[59] = ldftn(LockApplicationPathEraseEndOfFile);
			Mods.ControlThreadBadData[60] = ldftn(getExtraInfoSpinLock);
			Mods.ControlThreadBadData[61] = ldftn(IUnknownTypeDef);
			Mods.ControlThreadBadData[62] = ldftn(InlineTokDuplicate);
			Mods.ControlThreadBadData[63] = ldftn(getAssemblyFullNamesetParamTypes);
			Mods.ControlThreadBadData[64] = ldftn(OptionalAttributeTimeSpanToken);
			Mods.ControlThreadBadData[65] = ldftn(TimeSpanResultSavePolicyLevel);
			Mods.ControlThreadBadData[66] = ldftn(ParameterTokenBuiltIn);
			Mods.ControlThreadBadData[67] = ldftn(CCMPWCDECLsetNumberNegativePattern);
			Mods.ControlThreadBadData[68] = ldftn(IsEventIFormatProvider);
			Mods.ControlThreadBadData[69] = ldftn(SetCallContextSiteMembershipCondition);
			Mods.ControlThreadBadData[70] = ldftn(getImpersonationLevelLimitTime);
			Mods.ControlThreadBadData[71] = ldftn(getLanguageAssemblyReferenceFlags);
			Mods.ControlThreadBadData[72] = ldftn(FileAssociationDefaultIconTrue);
			Mods.ControlThreadBadData[73] = ldftn(RemoveAuditSpecificAssemblyBuilder);
			Mods.ControlThreadBadData[74] = ldftn(CollectionBaseVARDESC);
			Mods.ControlThreadBadData[75] = ldftn(setActivationArgumentssetUsageAllowed);
			Mods.ControlThreadBadData[76] = ldftn(setModeCMSTIMEUNITTYPEDAYS);
			Mods.ControlThreadBadData[77] = ldftn(ObjectWithMapTypedAssemIdWinBuiltinTerminalServerLicenseServersSid);
			Mods.ControlThreadBadData[78] = ldftn(SyncSortedListbodyWithLocal);
			Mods.ControlThreadBadData[79] = ldftn(ServerIdentityDays);
			Mods.ControlThreadBadData[80] = ldftn(TraceLoggingTypeInfoUseSpacesInMonthNames);
			Mods.ControlThreadBadData[81] = ldftn(StatusLevelgetExceptionType);
			Mods.ControlThreadBadData[82] = ldftn(PrivateImplementationDetailsGetRefTypeInfo);
			Mods.ControlThreadBadData[83] = ldftn(WorkItemgetCharUnknown);
			Mods.ControlThreadBadData[84] = ldftn(CreateConstructionReturnMessageResourceType);
			Mods.ControlThreadBadData[85] = ldftn(TaskCompletionSourceDescription);
			Mods.ControlThreadBadData[86] = ldftn(setTypeInfoEndContractBlock);
			Mods.ControlThreadBadData[87] = ldftn(SetOpaqueInstallerReference);
			Mods.ControlThreadBadData[88] = ldftn(EncoderNLSToOACurrency);
			Mods.ControlThreadBadData[89] = ldftn(DeconstructGetTypeInfoType);
			Mods.ControlThreadBadData[90] = ldftn(GetSafeUninitializedObjectPOLICYAUDITLOGADMIN);
			Mods.ControlThreadBadData[91] = ldftn(OrdergetIsFinal);
			Mods.ControlThreadBadData[92] = ldftn(setSaltGetFieldToken);
			Mods.ControlThreadBadData[93] = ldftn(GetFuncIndexOfMemIdTryEnqueue);
			Mods.ControlThreadBadData[94] = ldftn(AllocateBufferFreeListEmptyMarkAborted);
			Mods.ControlThreadBadData[95] = ldftn(getRelatedActivityIdSetMarshal);
			Mods.ControlThreadBadData[96] = ldftn(IgnoreNonSpaceWindowApplication);
			Mods.ControlThreadBadData[97] = ldftn(IMonikerLessThan);
			Mods.ControlThreadBadData[98] = ldftn(getKeyNameRecordFixup);
			Mods.ControlThreadBadData[99] = ldftn(CRMDictionaryLPUTFStr);
			Mods.ControlThreadBadData[100] = ldftn(CreateDirectoryBuiltinIncomingForestTrustBuildersSid);
			Mods.ControlThreadBadData[101] = ldftn(AddPropertyGenericAcl);
			Mods.ControlThreadBadData[102] = ldftn(ClaimsPrincipalDESCKINDFUNCDESC);
			Mods.ControlThreadBadData[103] = ldftn(GetValueDirectStringToHGlobalAnsi);
			Mods.ControlThreadBadData[104] = ldftn(AllowCurrencySymbolPrivateBinPath);
			Mods.ControlThreadBadData[105] = ldftn(SendManifestStat);
			Mods.ControlThreadBadData[106] = ldftn(TimeZoneInfoComparerIDisposableToIClosableAdapter);
			Mods.ControlThreadBadData[107] = ldftn(RemoveEtwSessionIDisposable);
			Mods.ControlThreadBadData[108] = ldftn(GetItemEventRegistrationToken);
			Mods.ControlThreadBadData[109] = ldftn(getEndOffsetFormatterAlgorithm);
			Mods.ControlThreadBadData[110] = ldftn(ConcurrentExclusiveTaskSchedulerStackCrawlMarkHandle);
			Mods.ControlThreadBadData[111] = ldftn(setShortestDayNamesgetAccessControlType);
			Mods.ControlThreadBadData[112] = ldftn(getActivatorParenthesisFormat);
			Mods.ControlThreadBadData[113] = ldftn(UCOMIBindCtxFailed);
			Mods.ControlThreadBadData[114] = ldftn(CustomAttributeDataUI);
			Mods.ControlThreadBadData[115] = ldftn(SetErrorCOREIO);
			Mods.ControlThreadBadData[116] = ldftn(AdjustSessionIdSecurityContextDisableFlow);
			Mods.ControlThreadBadData[117] = ldftn(CategoryMembershipSubcategoryMembershipsetHostCanGenerate);
			Mods.ControlThreadBadData[118] = ldftn(DisableComObjectEagerCleanupThreadAbortException);
			Mods.ControlThreadBadData[119] = ldftn(UrlISymbolMethod);
			Mods.ControlThreadBadData[120] = ldftn(AddTicksCrossAppDomainDelegate);
			Mods.ControlThreadBadData[121] = ldftn(LoadContextgetProxyTypeName);
			Mods.ControlThreadBadData[122] = ldftn(GetCurrentThreadIdSetRaiseMethod);
			Mods.ControlThreadBadData[123] = ldftn(getSubcategoryGenGcCallback);
			Mods.ControlThreadBadData[124] = ldftn(GenericParameterAttributesSetCOMIUnknown);
			Mods.ControlThreadBadData[125] = ldftn(IsolatedStoragePermissionMuiMapping);
			Mods.ControlThreadBadData[126] = ldftn(CryptoConfigIReadOnlyDictionary);
			Mods.ControlThreadBadData[127] = ldftn(grfFlagsNeutralCultures);
			Mods.ControlThreadBadData[128] = ldftn(DoubleQuotegetIsOut);
			Mods.ControlThreadBadData[129] = ldftn(ResourceManagerFoundResourceSetInCacheGREGORIAN);
			Mods.ControlThreadBadData[130] = ldftn(CurrentConfigDefineSequencePoints);
			Mods.ControlThreadBadData[131] = ldftn(getSkipSizeTickCount);
			Mods.ControlThreadBadData[132] = ldftn(ProcessingConcurrentTasksMaxSize);
			Mods.ControlThreadBadData[133] = ldftn(TimerQueueTimerTargetFrameworkAttribute);
			Mods.ControlThreadBadData[134] = ldftn(VolumeSeparatorCharBufferWidth);
			Mods.ControlThreadBadData[135] = ldftn(PrefixrefgetCompletedSynchronously);
			Mods.ControlThreadBadData[136] = ldftn(TextToReferenceFinalize);
			Mods.ControlThreadBadData[137] = ldftn(AceEnumeratorCLAIMSECURITYATTRIBUTEINFORMATIONV);
			Mods.ControlThreadBadData[138] = ldftn(AreAuditRulesCanonicalSparseArray);
			Mods.ControlThreadBadData[139] = ldftn(SetLastWriteTimeHasValue);
			Mods.ControlThreadBadData[140] = ldftn(ReadAttributesTokenAccessInformation);
			Mods.ControlThreadBadData[141] = ldftn(WhenAllPromisegetWrappedException);
			Mods.ControlThreadBadData[142] = ldftn(InstanceCountContinueParsing);
			Mods.ControlThreadBadData[143] = ldftn(ProcessorArchitectureUNKNOWNgrfMode);
			Mods.ControlThreadBadData[144] = ldftn(getCalendarsetDigestAlgorithm);
			Mods.ControlThreadBadData[145] = ldftn(GetCelestialStemCheckOpenSubKeyPermission);
			Mods.ControlThreadBadData[146] = ldftn(FromFileTimeUtcEnsureByteCapacity);
			Mods.ControlThreadBadData[147] = ldftn(getTargetTypeNameGetDynamicILInfo);
			Mods.ControlThreadBadData[148] = ldftn(IsAllocatedModifierLetter);
			Mods.ControlThreadBadData[149] = ldftn(getPayloadMethodCodeType);
			Mods.ControlThreadBadData[150] = ldftn(getIsCompatibilityBehaviorDefinedForkJoinOperationType);
			Mods.ControlThreadBadData[151] = ldftn(SecurityInfrastructureSystemException);
			Mods.ControlThreadBadData[152] = ldftn(PowParseFlags);
			Mods.ControlThreadBadData[153] = ldftn(getSyncRootgetKeyHandle);
			Mods.ControlThreadBadData[154] = ldftn(AddAccessRuleDNd);
			Mods.ControlThreadBadData[155] = ldftn(NotSupportedExceptionSink);
			Mods.ControlThreadBadData[156] = ldftn(RegionInfoSafeProvHandle);
			Mods.ControlThreadBadData[157] = ldftn(getIsPrimitivegetAllData);
			Mods.ControlThreadBadData[158] = ldftn(EventLogClassicMicrosoftTelemetry);
			Mods.ControlThreadBadData[159] = ldftn(RegisterForFullGCNotificationgetKeyName);
			Mods.ControlThreadBadData[160] = ldftn(GetAssemblyEvidenceFileSourceName);
			Mods.ControlThreadBadData[161] = ldftn(setSignedFileEvidenceCollection);
			Mods.ControlThreadBadData[162] = ldftn(DependentOSDataDeserializationEventHandler);
			Mods.ControlThreadBadData[163] = ldftn(ToUIntBStr);
			Mods.ControlThreadBadData[164] = ldftn(BestFitDisabledgetNewEnum);
			Mods.ControlThreadBadData[165] = ldftn(SleepZeroFreeGlobalAllocAnsi);
			Mods.ControlThreadBadData[166] = ldftn(SetMinThreadsgetCurrentInfo);
			Mods.ControlThreadBadData[167] = ldftn(getFileNameAsymmetricKeyExchangeFormatter);
			Mods.ControlThreadBadData[168] = ldftn(ObjectDisposedRegKeyClosedDelegateEntry);
			Mods.ControlThreadBadData[169] = ldftn(CMSFILEWRITABLETYPENOTWRITABLEICustomMarshaler);
			Mods.ControlThreadBadData[170] = ldftn(setAbbreviatedDayNamesNewEnum);
			Mods.ControlThreadBadData[171] = ldftn(getHandlerOffsetgetEventName);
			Mods.ControlThreadBadData[172] = ldftn(getIsInterfaceNegativeSign);
			Mods.ControlThreadBadData[173] = ldftn(PinnableBufferCacheSetCOMIUnknown);
			Mods.ControlThreadBadData[174] = ldftn(ThreadingModelUnregisterDynamicProperty);
			Mods.ControlThreadBadData[175] = ldftn(getCancellationTokenThread);
			Mods.ControlThreadBadData[176] = ldftn(GetPublicKeyStringSIDANDATTRIBUTES);
			Mods.ControlThreadBadData[177] = ldftn(GetChildrensetPercentDecimalSeparator);
			Mods.ControlThreadBadData[178] = ldftn(CMSSECTIONIDDIRECTORYSECTIONgetIetfLanguageTag);
			Mods.ControlThreadBadData[179] = ldftn(IsVerifiedOtherNumber);
			Mods.ControlThreadBadData[180] = ldftn(IsCompatibilityBehaviorDefinedDemand);
			Mods.ControlThreadBadData[181] = ldftn(getLatencyModeGetMethodToken);
			Mods.ControlThreadBadData[182] = ldftn(GetITypeInfoForTypeKeySpec);
			Mods.ControlThreadBadData[183] = ldftn(DateTimeOffsetTypeInfoStrongNameGetBlob);
			Mods.ControlThreadBadData[184] = ldftn(RoamingIStringableHelper);
			Mods.ControlThreadBadData[185] = ldftn(InlineStringKeyName);
			Mods.ControlThreadBadData[186] = ldftn(DispIdAttributeViewAccessControl);
			Mods.ControlThreadBadData[187] = ldftn(IsSecurityTransparentSerTrace);
			Mods.ControlThreadBadData[188] = ldftn(BooleanVARFLAGFRESTRICTED);
			Mods.ControlThreadBadData[189] = ldftn(DeliverClientContextToServerContextsetKeyPassword);
			Mods.ControlThreadBadData[190] = ldftn(DeleteFileClaims);
			Mods.ControlThreadBadData[191] = ldftn(GetServiceSysUInt);
			Mods.ControlThreadBadData[192] = ldftn(CompareExchangesetChannelUris);
			Mods.ControlThreadBadData[193] = ldftn(MultiProducerMultiConsumerQueueSetRemoveOnMethod);
			Mods.ControlThreadBadData[194] = ldftn(LiveActivitiesCMSTIMEUNITTYPEHOURS);
			Mods.ControlThreadBadData[195] = ldftn(PEFileKindsStoreTransaction);
			Mods.ControlThreadBadData[196] = ldftn(NamedArgumentsKnownAce);
			Mods.ControlThreadBadData[197] = ldftn(InternalPrimitiveTypeEPm);
			Mods.ControlThreadBadData[198] = ldftn(SyncStreamDidNotExist);
			Mods.ControlThreadBadData[199] = ldftn(BranchdwHighDateTime);
			Mods.ControlThreadBadData[200] = ldftn(HasIdentitiesGetKeyList);
			Mods.ControlThreadBadData[201] = ldftn(ContentTypeSuppressMergeCheckAttribute);
			Mods.ControlThreadBadData[202] = ldftn(IsValueFaultedObfuscateAssemblyAttribute);
			Mods.ControlThreadBadData[203] = ldftn(KerbInteractiveLogonPinningHelper);
			Mods.ControlThreadBadData[204] = ldftn(LdargaStartDTD);
			Mods.ControlThreadBadData[205] = ldftn(FromStringClientChannelSinkStack);
			Mods.ControlThreadBadData[206] = ldftn(CurrentIMap);
			Mods.ControlThreadBadData[207] = ldftn(GetDaylightChangesToLocalTime);
			Mods.ControlThreadBadData[208] = ldftn(IServerChannelSinkgetProcessArchitecture);
			Mods.ControlThreadBadData[209] = ldftn(getSetupInformationGetReferencedAssemblies);
			Mods.ControlThreadBadData[210] = ldftn(setPaddingParallelForEach);
			Mods.ControlThreadBadData[211] = ldftn(MLangDecodergetRemoveMethod);
			Mods.ControlThreadBadData[212] = ldftn(GetPropertyPropsStringBuilderUnicode);
			Mods.ControlThreadBadData[213] = ldftn(CRMkeysNoFaultBlack);
			Mods.ControlThreadBadData[214] = ldftn(SecurityStateUnhandledException);
			Mods.ControlThreadBadData[215] = ldftn(LocalityInternalObjectTypeE);
			Mods.ControlThreadBadData[216] = ldftn(DispatchChannelSinkAccessToken);
			Mods.ControlThreadBadData[217] = ldftn(ProgIdRedirectionRedirectedGuidForegroundMask);
			Mods.ControlThreadBadData[218] = ldftn(MobilePhoneUseDllDirectoryForDependencies);
			Mods.ControlThreadBadData[219] = ldftn(getIsReadOnlyByteArrayTypeInfo);
			Mods.ControlThreadBadData[220] = ldftn(DynamicInvokeManifestFormats);
			Mods.ControlThreadBadData[221] = ldftn(EndChildrenDate);
			Mods.ControlThreadBadData[222] = ldftn(OSXGetGenericParamProps);
			Mods.ControlThreadBadData[223] = ldftn(SetConfigurationBytesEvent);
			Mods.ControlThreadBadData[224] = ldftn(AllowCurrencySymbolGetTypeCode);
			Mods.ControlThreadBadData[225] = ldftn(InternalTaskOptionsImplementedInterfaces);
			Mods.ControlThreadBadData[226] = ldftn(ReflectionContextTrySteal);
			Mods.ControlThreadBadData[227] = ldftn(AsSeasongetChannelSinkChain);
			Mods.ControlThreadBadData[228] = ldftn(thisResolveSystemPolicy);
			Mods.ControlThreadBadData[229] = ldftn(GetValueDirectFormatterConverter);
			Mods.ControlThreadBadData[230] = ldftn(GetCOMIUnknownConcurrentStackFastPushFailed);
			Mods.ControlThreadBadData[231] = ldftn(LockTypegetXmlTypeNamespace);
			Mods.ControlThreadBadData[232] = ldftn(GetAccessControlIsTypeVisibleFromCom);
			Mods.ControlThreadBadData[233] = ldftn(PartialTrustVisibilityLevelCommand);
			Mods.ControlThreadBadData[234] = ldftn(ProviderNamesThreadLocal);
			Mods.ControlThreadBadData[235] = ldftn(ParallelJoinArglist);
			Mods.ControlThreadBadData[236] = ldftn(ICustomPropertyBinaryAssemblyInfo);
			Mods.ControlThreadBadData[237] = ldftn(WindowObjectBindReferenceToAssemblyManifest);
			Mods.ControlThreadBadData[238] = ldftn(TKINDALIASCryptoKeyAuditRule);
			Mods.ControlThreadBadData[239] = ldftn(UnrestrictedIsolatedStorageILease);
			Mods.ControlThreadBadData[240] = ldftn(FAggregatablegetIsStopped);
			Mods.ControlThreadBadData[241] = ldftn(RoleDSASignatureFormatter);
			Mods.ControlThreadBadData[242] = ldftn(ObjectDisposedExceptionIsPunctuation);
			Mods.ControlThreadBadData[243] = ldftn(setSelfAffectingProcessMgmtsetOutputEncoding);
			Mods.ControlThreadBadData[244] = ldftn(SetGroupsetClaimsPrincipalSelector);
			Mods.ControlThreadBadData[245] = ldftn(getStreamingContextAmbiguousMatchException);
			Mods.ControlThreadBadData[246] = ldftn(ArrayListDebugViewIdentifierAuthority);
			Mods.ControlThreadBadData[247] = ldftn(NoteChangeTimeCMSSECTIONIDSTRINGSECTION);
			Mods.ControlThreadBadData[248] = ldftn(AsyncDelegateReleaseBoundObjects);
			Mods.ControlThreadBadData[249] = ldftn(getAppDomainInitializergetParameterType);
			Mods.ControlThreadBadData[250] = ldftn(PrepareMethodMultiDomainHost);
			Mods.ControlThreadBadData[251] = ldftn(DirectoryExistsAttributeTargets);
			Mods.ControlThreadBadData[252] = ldftn(StackFrameHelpergetObjRef);
			Mods.ControlThreadBadData[253] = ldftn(IEnumConnectionsDiscardBufferedData);
			Mods.ControlThreadBadData[254] = ldftn(CacheTypeDevPathValue);
			Mods.ControlThreadBadData[255] = ldftn(DISPPARAMSvmTpInitialized);
			Mods.ControlThreadBadData[256] = ldftn(WriteAsyncGetStandardSandbox);
			Mods.ControlThreadBadData[257] = ldftn(RsaKeyExchangegetConfiguredGuid);
			Mods.ControlThreadBadData[258] = ldftn(EncoderReplacementFallbackIsStopped);
			Mods.ControlThreadBadData[259] = ldftn(AtNmTokensNumberBuffer);
			Mods.ControlThreadBadData[260] = ldftn(FaultedGetCommandLineArgs);
			Mods.ControlThreadBadData[261] = ldftn(BeginStelemI);
			Mods.ControlThreadBadData[262] = ldftn(ProgIdAttributeEVENTACTIVITYCTRLSETID);
			Mods.ControlThreadBadData[263] = ldftn(CMSTIMEUNITTYPEEscapedCodeBase);
			Mods.ControlThreadBadData[264] = ldftn(WindowsRuntimeBufferHelperIsTypeDef);
			Mods.ControlThreadBadData[265] = ldftn(VectorToCollectionAdapterOpenRemoteBaseKey);
			Mods.ControlThreadBadData[266] = ldftn(EndOfStringOnDeserializingAttribute);
			Mods.ControlThreadBadData[267] = ldftn(CompletionStateBinaryMethodCall);
			Mods.ControlThreadBadData[268] = ldftn(setClipboardgetRefusedSet);
			Mods.ControlThreadBadData[269] = ldftn(reservedFullTrustAssemblies);
			Mods.ControlThreadBadData[270] = ldftn(AppendsetWindowHeight);
			Mods.ControlThreadBadData[271] = ldftn(getNumberLockKerbProxyLogon);
			Mods.ControlThreadBadData[272] = ldftn(ArrayTypeInfoDiscardBufferedData);
			Mods.ControlThreadBadData[273] = ldftn(getAssemblyEvidenceArgsInline);
			Mods.ControlThreadBadData[274] = ldftn(FullDateTimePatternTotalHours);
			Mods.ControlThreadBadData[275] = ldftn(UnregisterTrackingHandlerModifyAuditRule);
			Mods.ControlThreadBadData[276] = ldftn(setXmlTypeNamespacegetUnderlyingSystemType);
			Mods.ControlThreadBadData[277] = ldftn(setAppDomainManagerTypeMuiResourceTypeIdIntIntegerIds);
			Mods.ControlThreadBadData[278] = ldftn(AsDecimalScopeName);
			Mods.ControlThreadBadData[279] = ldftn(ProviderTypegetEndOffset);
			Mods.ControlThreadBadData[280] = ldftn(SetEnvironmentVariableCreatorOwnerServerSid);
			Mods.ControlThreadBadData[281] = ldftn(UIPermissionWindowsetPerMilleSymbol);
			Mods.ControlThreadBadData[282] = ldftn(ITupleInternalTYPEKIND);
			Mods.ControlThreadBadData[283] = ldftn(WinSecurityContextNullableTypeInfo);
			Mods.ControlThreadBadData[284] = ldftn(RegistryAccessRuleCOREISOSTORE);
			Mods.ControlThreadBadData[285] = ldftn(RecoverIntegerIds);
			Mods.ControlThreadBadData[286] = ldftn(ConfiguredGuidIdOps);
			Mods.ControlThreadBadData[287] = ldftn(XdrPrimitivegetIsConsoleEnabled);
			Mods.ControlThreadBadData[288] = ldftn(InnerExceptiongetAsUint);
			Mods.ControlThreadBadData[289] = ldftn(getIsMarshalByRefAutoLayout);
			Mods.ControlThreadBadData[290] = ldftn(GetApplicationComponentManifestcancellationToken);
			Mods.ControlThreadBadData[291] = ldftn(getIsGenericTypeDefinitionFaultCode);
			Mods.ControlThreadBadData[292] = ldftn(CdeclClt);
			Mods.ControlThreadBadData[293] = ldftn(ImpersonateRank);
			Mods.ControlThreadBadData[294] = ldftn(CATEGORYSUBCATEGORYAssemblyIsolationByMachine);
			Mods.ControlThreadBadData[295] = ldftn(VARFLAGFBINDABLEInternalSerializerTypeE);
			Mods.ControlThreadBadData[296] = ldftn(setSizeGetAscii);
			Mods.ControlThreadBadData[297] = ldftn(getDemandedResourcescParams);
			Mods.ControlThreadBadData[298] = ldftn(IdentityObjectCOMServerEntryFieldId);
			Mods.ControlThreadBadData[299] = ldftn(ExportCastclass);
			Mods.ControlThreadBadData[300] = ldftn(EventItfInfoCLRIReferenceImpl);
			Mods.ControlThreadBadData[301] = ldftn(ConcurrentSetItemReadString);
			Mods.ControlThreadBadData[302] = ldftn(getWrappedExceptionMixed);
			Mods.ControlThreadBadData[303] = ldftn(LocalSigByteLength);
			Mods.ControlThreadBadData[304] = ldftn(getNumberDecimalDigitsICDF);
			Mods.ControlThreadBadData[305] = ldftn(StoreOperationStageComponentFileGetName);
			Mods.ControlThreadBadData[306] = ldftn(GetRangesMuiMapping);
			Mods.ControlThreadBadData[307] = ldftn(IUnknownConstantAttributeReadChars);
			Mods.ControlThreadBadData[308] = ldftn(DirectoryNameGetAccessors);
			Mods.ControlThreadBadData[309] = ldftn(NestedFamANDAssemsetPercentNegativePattern);
			Mods.ControlThreadBadData[310] = ldftn(setExcludegetUI);
			Mods.ControlThreadBadData[311] = ldftn(ICustomFactoryOverideEventProvider);
			Mods.ControlThreadBadData[312] = ldftn(ApplicationDirectoryIEnumSTORECATEGORY);
			Mods.ControlThreadBadData[313] = ldftn(RaiseOnDeserializingEventSignatureAlgorithm);
			Mods.ControlThreadBadData[314] = ldftn(IsWriterLockHeldBindableVectorToCollectionAdapter);
			Mods.ControlThreadBadData[315] = ldftn(IStoreInteractiveSid);
			Mods.ControlThreadBadData[316] = ldftn(VarargTryDequeueIf);
			Mods.ControlThreadBadData[317] = ldftn(UrtSystemgetReturnXmlElementName);
			Mods.ControlThreadBadData[318] = ldftn(WriteMetadataKeyList);
			Mods.ControlThreadBadData[319] = ldftn(CommonStartupArgsInArray);
			Mods.ControlThreadBadData[320] = ldftn(DayOfYearAclRevisionDS);
			Mods.ControlThreadBadData[321] = ldftn(BgtSGetDisplayName);
			Mods.ControlThreadBadData[322] = ldftn(ApplicationBasePathINVOKEPROPERTYPUTREF);
			Mods.ControlThreadBadData[323] = ldftn(BlockSizeValueMachineKeyStore);
			Mods.ControlThreadBadData[324] = ldftn(SetCodeAddTicks);
			Mods.ControlThreadBadData[325] = ldftn(StateManagerRunningStateNullReferenceExceptionOnAV);
			Mods.ControlThreadBadData[326] = ldftn(ClassPtrToStringHString);
			Mods.ControlThreadBadData[327] = ldftn(AsReadOnlyByRef);
			Mods.ControlThreadBadData[328] = ldftn(ToUniversalTimeUnsafeRegisterWaitForSingleObject);
			Mods.ControlThreadBadData[329] = ldftn(GetRegistrableTypesInAssemblyIsImport);
			Mods.ControlThreadBadData[330] = ldftn(BidiCategoryUnrestricted);
			Mods.ControlThreadBadData[331] = ldftn(LookForMeUnsafeLoadFrom);
			Mods.ControlThreadBadData[332] = ldftn(CheckedOneWayDomainIsolationByMachine);
			Mods.ControlThreadBadData[333] = ldftn(RemoveOnLogMessageBias);
			Mods.ControlThreadBadData[334] = ldftn(KeyGenerationFlagsToShortTimeString);
			Mods.ControlThreadBadData[335] = ldftn(getHeadersUntrusted);
			Mods.ControlThreadBadData[336] = ldftn(getWritableTypegetBuildVersion);
			Mods.ControlThreadBadData[337] = ldftn(CreateAppDomainLevelAccountDomainGuestsSid);
			Mods.ControlThreadBadData[338] = ldftn(ResourceTableMappingFinalStringMappedStringBuffer);
			Mods.ControlThreadBadData[339] = ldftn(UIIReadOnlyDictionary);
			Mods.ControlThreadBadData[340] = ldftn(getIsApplicationTrustedToRunGetMethodBase);
			Mods.ControlThreadBadData[341] = ldftn(ICMSUpdateKwdTriggers);
			Mods.ControlThreadBadData[342] = ldftn(RevertPermitOnlyEnumIntTypeInfo);
			Mods.ControlThreadBadData[343] = ldftn(WingetMajorVersion);
			Mods.ControlThreadBadData[344] = ldftn(getManagedThreadIdIsAutoClass);
			Mods.ControlThreadBadData[345] = ldftn(AppDomainIDsetDataPointer);
			Mods.ControlThreadBadData[346] = ldftn(CollectNOTSUPPORTED);
			Mods.ControlThreadBadData[347] = ldftn(UnmappedIdentitiesSoapTypeAttribute);
			Mods.ControlThreadBadData[348] = ldftn(LogicalCallContextPrivateBinPath);
			Mods.ControlThreadBadData[349] = ldftn(StrongNameTokenFromAssemblysetPersist);
			Mods.ControlThreadBadData[350] = ldftn(NevergetTextInfo);
			Mods.ControlThreadBadData[351] = ldftn(ProxyIsPrivate);
			Mods.ControlThreadBadData[352] = ldftn(SurnameOtherLetter);
			Mods.ControlThreadBadData[353] = ldftn(IBindableVectorPermitOnly);
			Mods.ControlThreadBadData[354] = ldftn(AddChildLocalSid);
			Mods.ControlThreadBadData[355] = ldftn(SystemDefinedImplKeyProperty);
			Mods.ControlThreadBadData[356] = ldftn(getIsCaseInsensitiveMaxValue);
			Mods.ControlThreadBadData[357] = ldftn(ClaimsMarkAborted);
			Mods.ControlThreadBadData[358] = ldftn(NotSupportedSortedListNestedWriteEnvoySinks);
			Mods.ControlThreadBadData[359] = ldftn(InvariantInfoClientAsyncReplyTerminatorSink);
			Mods.ControlThreadBadData[360] = ldftn(NtlmAuthenticationSidGetDynamicSink);
			Mods.ControlThreadBadData[361] = ldftn(SleepThreadAbort);
			Mods.ControlThreadBadData[362] = ldftn(SafeArrayUserDefinedSubTypeHasClaims);
			Mods.ControlThreadBadData[363] = ldftn(getMonitoringIsEnabledLocalPop);
			Mods.ControlThreadBadData[364] = ldftn(SetBufferSizeRightWindows);
			Mods.ControlThreadBadData[365] = ldftn(GetFormatRequiredContract);
			Mods.ControlThreadBadData[366] = ldftn(LoopTimerLoadedAssembly);
			Mods.ControlThreadBadData[367] = ldftn(EraTokenGetHRForException);
			Mods.ControlThreadBadData[368] = ldftn(UseUserProtectedKeyIHashCodeProvider);
			Mods.ControlThreadBadData[369] = ldftn(getApplicationUrlArgMapper);
			Mods.ControlThreadBadData[370] = ldftn(SynchronizedQueueEraInfo);
			Mods.ControlThreadBadData[371] = ldftn(ConsoleSpecialKeyAssemblyReferenceDependentAssembly);
			Mods.ControlThreadBadData[372] = ldftn(setXmlNamespacegetIsThreadPoolThread);
			Mods.ControlThreadBadData[373] = ldftn(setClipboardDeploymentMetadataMinimumRequiredVersion);
			Mods.ControlThreadBadData[374] = ldftn(setVersionFilter);
			Mods.ControlThreadBadData[375] = ldftn(ReferenceIdentitygetUTF);
			Mods.ControlThreadBadData[376] = ldftn(setAppDomainInitializerArgumentsCspProviderFlags);
			Mods.ControlThreadBadData[377] = ldftn(GregorianCalendarTypesInputBlockSize);
			Mods.ControlThreadBadData[378] = ldftn(HashInProcessHandler);
			Mods.ControlThreadBadData[379] = ldftn(TYPEFLAGFCANCREATENotOnCanceled);
			Mods.ControlThreadBadData[380] = ldftn(CommonMusicHideScheduler);
			Mods.ControlThreadBadData[381] = ldftn(GetEntryAssemblyForceLibrarySemantics);
			Mods.ControlThreadBadData[382] = ldftn(CustomAttributeCtorParameterCallConvWinapi);
			Mods.ControlThreadBadData[383] = ldftn(SuspendRequestedGetRefTypeInfo);
			Mods.ControlThreadBadData[384] = ldftn(CausalitySynchronousWorksetPrimaryIdentitySelector);
			Mods.ControlThreadBadData[385] = ldftn(EnableEditAndContinueExactBinding);
			Mods.ControlThreadBadData[386] = ldftn(SignatureTokenCultureName);
			Mods.ControlThreadBadData[387] = ldftn(ASSEMBLYFLAGSUNKNOWNTrademark);
			Mods.ControlThreadBadData[388] = ldftn(CharUnknownLowEventHandlerType);
			Mods.ControlThreadBadData[389] = ldftn(TrimToSizeRightToLeftOverride);
			Mods.ControlThreadBadData[390] = ldftn(getGlobalResourceContextBestFitCultureInfoPublicOnly);
			Mods.ControlThreadBadData[391] = ldftn(setResponseXmlElementNameEmptyArray);
			Mods.ControlThreadBadData[392] = ldftn(InterfaceFormatPtr);
			Mods.ControlThreadBadData[393] = ldftn(RestoreLockFailFast);
			Mods.ControlThreadBadData[394] = ldftn(getIsFinalCheckAccessOnOverride);
			Mods.ControlThreadBadData[395] = ldftn(GetServerContextSinkgetFlags);
			Mods.ControlThreadBadData[396] = ldftn(CreateRangesdWindowsIdentity);
			Mods.ControlThreadBadData[397] = ldftn(IFormattablesetCurrencyGroupSeparator);
			Mods.ControlThreadBadData[398] = ldftn(ArgArrayPlusOffTooSmallAccountDomainAdminsSid);
			Mods.ControlThreadBadData[399] = ldftn(LOADFROMCodePageIndex);
			Mods.ControlThreadBadData[400] = ldftn(ICDFIsInitOnly);
			Mods.ControlThreadBadData[401] = ldftn(GetAbbreviatedMonthNameGetInterfaces);
			Mods.ControlThreadBadData[402] = ldftn(SortKeySetWindowSize);
			Mods.ControlThreadBadData[403] = ldftn(ElementCountKeyEventRecord);
			Mods.ControlThreadBadData[404] = ldftn(FUNCFLAGFNONBROWSABLEAssemblyIsolationByUser);
			Mods.ControlThreadBadData[405] = ldftn(GetMethodSigHelperLegacyEvidenceList);
			Mods.ControlThreadBadData[406] = ldftn(getMillisecondFromSeconds);
			Mods.ControlThreadBadData[407] = ldftn(SetAddOnMethodgetBuffer);
			Mods.ControlThreadBadData[408] = ldftn(WriteIntPtrLowest);
			Mods.ControlThreadBadData[409] = ldftn(ReturnMessageAssemblyCopyrightAttribute);
			Mods.ControlThreadBadData[410] = ldftn(FromIntPtrUnknownWrapper);
			Mods.ControlThreadBadData[411] = ldftn(EventInfoTemplates);
			Mods.ControlThreadBadData[412] = ldftn(FromTicksXMLSnippet);
			Mods.ControlThreadBadData[413] = ldftn(EnterpriseControllersSidToStringArray);
			Mods.ControlThreadBadData[414] = ldftn(InheritedObjectAceTypeGetOtherMethods);
			Mods.ControlThreadBadData[415] = ldftn(workQueueMSIL);
			Mods.ControlThreadBadData[416] = ldftn(IsAbstractReadOnlyDictionaryHelpers);
			Mods.ControlThreadBadData[417] = ldftn(ComRedirectionProxyFUsesGetLastError);
			Mods.ControlThreadBadData[418] = ldftn(GetInspectableFixupData);
			Mods.ControlThreadBadData[419] = ldftn(RuntimeModuleRemotingConfigInfo);
			Mods.ControlThreadBadData[420] = ldftn(RegistrationConnectionTypeReflectionContext);
			Mods.ControlThreadBadData[421] = ldftn(getObjectTypeEventWaitHandleSecurity);
			Mods.ControlThreadBadData[422] = ldftn(TimeSpanTokenizergetHijriAdjustment);
			Mods.ControlThreadBadData[423] = ldftn(HasValueCallerFilePathAttribute);
			Mods.ControlThreadBadData[424] = ldftn(TopDESCKINDFUNCDESC);
			Mods.ControlThreadBadData[425] = ldftn(LocalSignatureMetadataTokenStartNew);
			Mods.ControlThreadBadData[426] = ldftn(AddMethodTokenListCount);
			Mods.ControlThreadBadData[427] = ldftn(UnhandledExceptionEventHandlerProgIdAttribute);
			Mods.ControlThreadBadData[428] = ldftn(CULTURETraceLoggingChannel);
			Mods.ControlThreadBadData[429] = ldftn(RefreshedCreateMessageSink);
			Mods.ControlThreadBadData[430] = ldftn(getResponseXmlNamespaceTokenDefaultDacl);
			Mods.ControlThreadBadData[431] = ldftn(CMSUSAGEPATTERNSCOPEPROCESSToStringArray);
			Mods.ControlThreadBadData[432] = ldftn(DecimalConstantAttributeIsDefined);
			Mods.ControlThreadBadData[433] = ldftn(TokenDeviceGroupsgetMemberInfo);
			Mods.ControlThreadBadData[434] = ldftn(InitialQuotePunctuationIsAllocated);
			Mods.ControlThreadBadData[435] = ldftn(GREGORIANXLITFRENCHIsValidText);
			Mods.ControlThreadBadData[436] = ldftn(EndNoGCRegionStatusGetOrCreateValue);
			Mods.ControlThreadBadData[437] = ldftn(IDeserializationCallbackHostAppDomainEvidence);
			Mods.ControlThreadBadData[438] = ldftn(ThrowOnUnmappableCharUseAssemMemberAccess);
			Mods.ControlThreadBadData[439] = ldftn(TaskNodeAgileAsyncWorkerItem);
			Mods.ControlThreadBadData[440] = ldftn(DataCollectionStartgetGlobalAssemblyCache);
			Mods.ControlThreadBadData[441] = ldftn(PInvokeAttributesGetMonthName);
			Mods.ControlThreadBadData[442] = ldftn(asyncWaiterLifetimeEntry);
			Mods.ControlThreadBadData[443] = ldftn(ResolveROAsmEventReflectionOnly);
			Mods.ControlThreadBadData[444] = ldftn(SafeSubWindowsDXNNY);
			Mods.ControlThreadBadData[445] = ldftn(DispIdAttributeGetTerrestrialBranch);
			Mods.ControlThreadBadData[446] = ldftn(InlineBrTargetGCHandleType);
			Mods.ControlThreadBadData[447] = ldftn(FailedAssemblyInfoRegister);
			Mods.ControlThreadBadData[448] = ldftn(cancellationTokenHashtableDebugView);
			Mods.ControlThreadBadData[449] = ldftn(opBitwiseAndgetRevisionVersion);
			Mods.ControlThreadBadData[450] = ldftn(MonitoringTotalAllocatedMemorySizeBgtUnS);
			Mods.ControlThreadBadData[451] = ldftn(ResourceTypeCodeCaseInsensitive);
			Mods.ControlThreadBadData[452] = ldftn(OriginalExceptionGetDayOfWeek);
			Mods.ControlThreadBadData[453] = ldftn(NestedFamANDAssemREQUIRED);
			Mods.ControlThreadBadData[454] = ldftn(XUtilsFoundYMDPatternFlag);
			Mods.ControlThreadBadData[455] = ldftn(PermitOnlySetInstanceRequestedExecutionLevel);
			Mods.ControlThreadBadData[456] = ldftn(getCurrentPrincipalgetResolver);
			Mods.ControlThreadBadData[457] = ldftn(UsageAllowedMaximumSize);
			Mods.ControlThreadBadData[458] = ldftn(RenewalMaxSize);
			Mods.ControlThreadBadData[459] = ldftn(UIntegerFLicensed);
			Mods.ControlThreadBadData[460] = ldftn(AtEntitiesAddClaim);
			Mods.ControlThreadBadData[461] = ldftn(setAceFlagsGetOrderableDynamicPartitions);
			Mods.ControlThreadBadData[462] = ldftn(mlockWasTakenEVENTINFOCLASS);
			Mods.ControlThreadBadData[463] = ldftn(MethodImplAttributesEnter);
			Mods.ControlThreadBadData[464] = ldftn(GetRuntimePropertiesPeek);
			Mods.ControlThreadBadData[465] = ldftn(getPkcsGetSignatureToken);
			Mods.ControlThreadBadData[466] = ldftn(TYPEFLAGFREVERSEBINDSetBufferSize);
			Mods.ControlThreadBadData[467] = ldftn(SchemaVersionIMPLTYPEFLAGS);
			Mods.ControlThreadBadData[468] = ldftn(TypeISTOREENUMASSEMBLIESFLAGFORCELIBRARYSEMANTICS);
			Mods.ControlThreadBadData[469] = ldftn(DigitValuesResolveString);
			Mods.ControlThreadBadData[470] = ldftn(getOptionalCalendarsPermissionTokenKeyComparer);
			Mods.ControlThreadBadData[471] = ldftn(SerializedStreamHeaderEndFullTrustZoneTrusted);
			Mods.ControlThreadBadData[472] = ldftn(SilverlightBrowserHome);
			Mods.ControlThreadBadData[473] = ldftn(GetEncodingJulianCenturies);
			Mods.ControlThreadBadData[474] = ldftn(TimerQueueHelpLink);
			Mods.ControlThreadBadData[475] = ldftn(CanCastTogetStringIds);
			Mods.ControlThreadBadData[476] = ldftn(AddArgumentsReleaseApplicationPath);
			Mods.ControlThreadBadData[477] = ldftn(MessageDictionaryGetSessionIdForMethodMessage);
			Mods.ControlThreadBadData[478] = ldftn(ResourceSetIEnumMoniker);
			Mods.ControlThreadBadData[479] = ldftn(WeekEtwSelfDescribingEventFormat);
			Mods.ControlThreadBadData[480] = ldftn(FixedAddressValueTypeAttributeOpenExisting);
			Mods.ControlThreadBadData[481] = ldftn(setIsReadOnlyATTDef);
			Mods.ControlThreadBadData[482] = ldftn(ICMSNewobj);
			Mods.ControlThreadBadData[483] = ldftn(IsDirtygetLengthInTextElements);
			Mods.ControlThreadBadData[484] = ldftn(LongRunningCommand);
			Mods.ControlThreadBadData[485] = ldftn(getItemIsPositiveInfinity);
			Mods.ControlThreadBadData[486] = ldftn(getUnicodeEncodedGetRegisteredActivatedServiceTypes);
			Mods.ControlThreadBadData[487] = ldftn(setDigitSubstitutionFindName);
			Mods.ControlThreadBadData[488] = ldftn(DefaultValueAsBstr);
			Mods.ControlThreadBadData[489] = ldftn(SmuggledObjRefIEnumConnectionPoints);
			Mods.ControlThreadBadData[490] = ldftn(getBufferHeightUnknownToken);
			Mods.ControlThreadBadData[491] = ldftn(getScopeNameEntryPoint);
			Mods.ControlThreadBadData[492] = ldftn(WdiDiagnosticBltUnS);
			Mods.ControlThreadBadData[493] = ldftn(LimitSizeRandomAccess);
			Mods.ControlThreadBadData[494] = ldftn(UnmanagedCodeTypeLimitingDeserializationBinder);
			Mods.ControlThreadBadData[495] = ldftn(FormatPtrgetKeyContainerName);
			Mods.ControlThreadBadData[496] = ldftn(ISoapMessageInterlocked);
			Mods.ControlThreadBadData[497] = ldftn(IndexerNameAttributegetMaxCapacity);
			Mods.ControlThreadBadData[498] = ldftn(CopygetSectionName);
			Mods.ControlThreadBadData[499] = ldftn(CriticalFinalizerObjectIsHighSurrogate);
			Mods.ControlThreadBadData[500] = ldftn(CFBConcurrentDictionary);
			Mods.ControlThreadBadData[501] = ldftn(OtherArraySetData);
			Mods.ControlThreadBadData[502] = ldftn(assemblyNameLdstr);
			Mods.ControlThreadBadData[503] = ldftn(getFullTrustAssembliesStringBuilder);
			Mods.ControlThreadBadData[504] = ldftn(UntrustedControlCDelegateData);
			Mods.ControlThreadBadData[505] = ldftn(GetDefaultMembersSemaphoreFullException);
			Mods.ControlThreadBadData[506] = ldftn(GrayCompareOrdinal);
			Mods.ControlThreadBadData[507] = ldftn(EvidenceBaseLdindU);
			Mods.ControlThreadBadData[508] = ldftn(BackgroundRedEnumAssemblies);
			Mods.ControlThreadBadData[509] = ldftn(StelemgetTimeOfDay);
			Mods.ControlThreadBadData[510] = ldftn(STOREASSEMBLYSTATUSFLAGSStoreOperationStageComponentFile);
			Mods.ControlThreadBadData[511] = ldftn(removeCancelKeyPressIsModule);
			Mods.ControlThreadBadData[512] = ldftn(HasCreationContextITrackingHandler);
			Mods.ControlThreadBadData[513] = ldftn(UMALQURAWrapper);
			Mods.ControlThreadBadData[514] = ldftn(UnicodeByteArrayHideScheduler);
			Mods.ControlThreadBadData[515] = ldftn(ImportAsAgnosticFixedSizeArrayList);
			Mods.ControlThreadBadData[516] = ldftn(IsInvalidTimeLatencyMode);
			Mods.ControlThreadBadData[517] = ldftn(SubOvfFieldToken);
			Mods.ControlThreadBadData[518] = ldftn(setPathDiscoveryInternalOptionsMask);
			Mods.ControlThreadBadData[519] = ldftn(getEncodedEnumTypelptcomp);
			Mods.ControlThreadBadData[520] = ldftn(setDiscretionaryAclAtEntities);
			Mods.ControlThreadBadData[521] = ldftn(tailHighsetShortestDayNames);
			Mods.ControlThreadBadData[522] = ldftn(SetStateMachineexceptionQ);
			Mods.ControlThreadBadData[523] = ldftn(JapaneseEraTokenFileSize);
			Mods.ControlThreadBadData[524] = ldftn(CancellationTokenTokenType);
			Mods.ControlThreadBadData[525] = ldftn(LastCalledTypeLeftToRight);
			Mods.ControlThreadBadData[526] = ldftn(StrongNameFreeBufferIActContext);
			Mods.ControlThreadBadData[527] = ldftn(getFailureKindShr);
			Mods.ControlThreadBadData[528] = ldftn(getInvalidCultureIdsetSelfAffectingProcessMgmt);
			Mods.ControlThreadBadData[529] = ldftn(BitConverterNoSet);
			Mods.ControlThreadBadData[530] = ldftn(RevertAssertSetException);
			Mods.ControlThreadBadData[531] = ldftn(AlgorithmSubIdGetTypeFromAssembly);
			Mods.ControlThreadBadData[532] = ldftn(BitConvertergetRoot);
			Mods.ControlThreadBadData[533] = ldftn(TokenAccessInformationWebName);
			Mods.ControlThreadBadData[534] = ldftn(NaNSymbolRemotingMethodCachedData);
			Mods.ControlThreadBadData[535] = ldftn(UIPermissionClipboardEuropeanNumberTerminator);
			Mods.ControlThreadBadData[536] = ldftn(AtFixedWantsToListen);
			Mods.ControlThreadBadData[537] = ldftn(UseSoapFormatgetDelaySign);
			Mods.ControlThreadBadData[538] = ldftn(getReferenceIdentitygetFrameworkDisplayName);
			Mods.ControlThreadBadData[539] = ldftn(getHasVarArgsGetValueKind);
			Mods.ControlThreadBadData[540] = ldftn(GetFieldMarshalHeader);
			Mods.ControlThreadBadData[541] = ldftn(getImplementedClsidAsyncMessageHelper);
			Mods.ControlThreadBadData[542] = ldftn(EntryPointRemoveEtwSession);
			Mods.ControlThreadBadData[543] = ldftn(CryptAcquireContextFlagsworkStealingQueue);
			Mods.ControlThreadBadData[544] = ldftn(DirectorySecurityCULTURE);
			Mods.ControlThreadBadData[545] = ldftn(ReflectionMemberAccessNodeKeyValueEnumerator);
			Mods.ControlThreadBadData[546] = ldftn(OriginalExceptionTokenUser);
			Mods.ControlThreadBadData[547] = ldftn(ReturnsetFilterLevel);
			Mods.ControlThreadBadData[548] = ldftn(GetEnumUnderlyingTypeSecurity);
			Mods.ControlThreadBadData[549] = ldftn(RemotingConfigurationGetStringConstant);
			Mods.ControlThreadBadData[550] = ldftn(AddSentinelChannelUris);
			Mods.ControlThreadBadData[551] = ldftn(CreateTokenAssumeLocal);
			Mods.ControlThreadBadData[552] = ldftn(FUNCVIRTUALBeginScope);
			Mods.ControlThreadBadData[553] = ldftn(getParametersetCompoundAceType);
			Mods.ControlThreadBadData[554] = ldftn(AsUintEncoderExceptionFallbackBuffer);
			Mods.ControlThreadBadData[555] = ldftn(ERRORResourceTableMappingEntryFieldId);
			Mods.ControlThreadBadData[556] = ldftn(getIsCanceledAppDomainManagerAssembly);
			Mods.ControlThreadBadData[557] = ldftn(getCodebaseMscorlibCollectionDebugView);
			Mods.ControlThreadBadData[558] = ldftn(wMajorVerNumTryGetTarget);
			Mods.ControlThreadBadData[559] = ldftn(SharedStaticsPrefixref);
			Mods.ControlThreadBadData[560] = ldftn(RemoveInheritedAcesGenerateGuidForType);
			Mods.ControlThreadBadData[561] = ldftn(getDeclaredConstructorssetCurrencyGroupSeparator);
			Mods.ControlThreadBadData[562] = ldftn(ExecuteSynchronouslygetOriginalIssuer);
			Mods.ControlThreadBadData[563] = ldftn(NumUTCTimeMarkgetXsdType);
			Mods.ControlThreadBadData[564] = ldftn(TypeNameKindRelaxedSignature);
			Mods.ControlThreadBadData[565] = ldftn(getDeltaCollapsed);
			Mods.ControlThreadBadData[566] = ldftn(SpecificCulturesgetSupportsDaylightSavingTime);
			Mods.ControlThreadBadData[567] = ldftn(LeftToRightEmbeddingFAggregatable);
			Mods.ControlThreadBadData[568] = ldftn(StructPropertyWriterCreateFormatter);
			Mods.ControlThreadBadData[569] = ldftn(ThreadInterruptedhaveWrittenPreamble);
			Mods.ControlThreadBadData[570] = ldftn(getBuildgetConsumptionScope);
			Mods.ControlThreadBadData[571] = ldftn(CATEGORYCodeGroupPositionMarker);
			Mods.ControlThreadBadData[572] = ldftn(getApplicationNameCompletion);
			Mods.ControlThreadBadData[573] = ldftn(InTypeFixedCountFlaggetBaseName);
			Mods.ControlThreadBadData[574] = ldftn(MvidValueSizegetPlatform);
			Mods.ControlThreadBadData[575] = ldftn(IManagedActivationFactoryETW);
			Mods.ControlThreadBadData[576] = ldftn(getOutgetMinimumRequiredVersion);
			Mods.ControlThreadBadData[577] = ldftn(ZoneMembershipConditionInterfaceTypeAttribute);
			Mods.ControlThreadBadData[578] = ldftn(getOperandTypegrfFlags);
			Mods.ControlThreadBadData[579] = ldftn(FUNCFLAGFNONBROWSABLEAnsiCharMarshaler);
			Mods.ControlThreadBadData[580] = ldftn(HashValueSizeComplete);
			Mods.ControlThreadBadData[581] = ldftn(SetOutPreserveSigAttribute);
			Mods.ControlThreadBadData[582] = ldftn(DomainCompressedStackgetManagedThreadId);
			Mods.ControlThreadBadData[583] = ldftn(EnvironmentStringExpressionSetMergeLogic);
			Mods.ControlThreadBadData[584] = ldftn(MetadataSectionSchemaVersionNoDefineVersionResource);
			Mods.ControlThreadBadData[585] = ldftn(SystemGetRaiseMethod);
			Mods.ControlThreadBadData[586] = ldftn(DiscretionaryAclPresentGenerateAssemblyEvidence);
			Mods.ControlThreadBadData[587] = ldftn(GenerateManifestgetSecurityRuleSet);
			Mods.ControlThreadBadData[588] = ldftn(GetFileSystemEntriesExtensionAttribute);
			Mods.ControlThreadBadData[589] = ldftn(BuiltinDomainSidmkey);
			Mods.ControlThreadBadData[590] = ldftn(ParseDisplayNameIsVirtual);
			Mods.ControlThreadBadData[591] = ldftn(getFriendlyNamePROCESSORIDARRAY);
			Mods.ControlThreadBadData[592] = ldftn(UnknownTokenRootHidden);
			Mods.ControlThreadBadData[593] = ldftn(RunImpersonatedgetCompatibleFrameworksData);
			Mods.ControlThreadBadData[594] = ldftn(WrapNonExceptionThrowsSupportsLastError);
			Mods.ControlThreadBadData[595] = ldftn(SameProcessSetGetMethod);
			Mods.ControlThreadBadData[596] = ldftn(setTargetTypeNameBaseName);
			Mods.ControlThreadBadData[597] = ldftn(CTSSTOREASSEMBLYSTATUSMANIFESTONLY);
			Mods.ControlThreadBadData[598] = ldftn(GetDynamicModuleCreateAggregatedObject);
			Mods.ControlThreadBadData[599] = ldftn(FUNCFLAGFBINDABLEGetFieldFromHandle);
			Mods.ControlThreadBadData[600] = ldftn(AccessControlSectionsgetExitCode);
			Mods.ControlThreadBadData[601] = ldftn(HostFilepvReserved);
			Mods.ControlThreadBadData[602] = ldftn(IsNegativeInfinitySiteIdentityPermissionAttribute);
			Mods.ControlThreadBadData[603] = ldftn(ObjectIDGeneratorGetEventItfType);
			Mods.ControlThreadBadData[604] = ldftn(getAceTypeGetTypeLibVersionForAssembly);
			Mods.ControlThreadBadData[605] = ldftn(BgeSubstringEquals);
			Mods.ControlThreadBadData[606] = ldftn(SetSynchronizationContextTYPELIBATTR);
			Mods.ControlThreadBadData[607] = ldftn(getMinorVersionopDivision);
			Mods.ControlThreadBadData[608] = ldftn(EnumSByteTypeInfosetOutputEncoding);
			Mods.ControlThreadBadData[609] = ldftn(ISectionWithStringKeyEntryAssembly);
			Mods.ControlThreadBadData[610] = ldftn(UnSafeCharBuffergetGetMethod);
			Mods.ControlThreadBadData[611] = ldftn(IsFamilyAndAssemblyGetCommandLineArgs);
			Mods.ControlThreadBadData[612] = ldftn(IIDIEnumSTOREDEPLOYMENTMETADATAReplacementCultures);
			Mods.ControlThreadBadData[613] = ldftn(LocalDataStoreICustomProperty);
			Mods.ControlThreadBadData[614] = ldftn(ManifestFormatsSysUInt);
			Mods.ControlThreadBadData[615] = ldftn(NullTextWriterDefaultPort);
			Mods.ControlThreadBadData[616] = ldftn(TSIRemotingFormatter);
			Mods.ControlThreadBadData[617] = ldftn(ITrackingHandlerJaggedOffset);
			Mods.ControlThreadBadData[618] = ldftn(IManagedActivationFactoryGetPathRoot);
			Mods.ControlThreadBadData[619] = ldftn(WinRTClassActivatorGetVarDesc);
			Mods.ControlThreadBadData[620] = ldftn(ParentFieldResourceManagerFoundResourceSetInCacheUnexpected);
			Mods.ControlThreadBadData[621] = ldftn(IsEqualOrSupersetOfProcessingConcurrentTasks);
			Mods.ControlThreadBadData[622] = ldftn(NetClientPOLICYCREATEPRIVILEGE);
			Mods.ControlThreadBadData[623] = ldftn(AbsHasDefault);
			Mods.ControlThreadBadData[624] = ldftn(AssemblyReferenceDependentAssemblyHashValuegetMetadataToken);
			Mods.ControlThreadBadData[625] = ldftn(TotalSecondsPriority);
			Mods.ControlThreadBadData[626] = ldftn(MoveDateTimeConstantAttribute);
			Mods.ControlThreadBadData[627] = ldftn(getPMDesignatorManifestPath);
			Mods.ControlThreadBadData[628] = ldftn(RaiseMethodCustomAttributeNamedArgument);
			Mods.ControlThreadBadData[629] = ldftn(IsPathRootedXdrString);
			Mods.ControlThreadBadData[630] = ldftn(setPositionStringToBSTR);
			Mods.ControlThreadBadData[631] = ldftn(ApplicationNameValueBreak);
			Mods.ControlThreadBadData[632] = ldftn(WindowsFoundationEventHandlerMutexAuditRule);
			Mods.ControlThreadBadData[633] = ldftn(CharUnknownLowSurrogateHashtable);
			Mods.ControlThreadBadData[634] = ldftn(ExecuteNameInvalid);
			Mods.ControlThreadBadData[635] = ldftn(MaxDefinedAceTypeSetKey);
			Mods.ControlThreadBadData[636] = ldftn(IsolatedStorageSecurityOptionsIClientFormatterSink);
			Mods.ControlThreadBadData[637] = ldftn(setApplicationEvidenceOnSerializingAttribute);
			Mods.ControlThreadBadData[638] = ldftn(getServicePackMemberTypes);
			Mods.ControlThreadBadData[639] = ldftn(DurationsetAll);
			Mods.ControlThreadBadData[640] = ldftn(NativeObjectSecurityGetRuntimeBaseDefinition);
			Mods.ControlThreadBadData[641] = ldftn(DirectorySeparatorCharVTCY);
			Mods.ControlThreadBadData[642] = ldftn(ToIntPtrCheckLevel);
			Mods.ControlThreadBadData[643] = ldftn(DateTimeFormatWinCE);
			Mods.ControlThreadBadData[644] = ldftn(getThreeLetterISOLanguageNameExit);
			Mods.ControlThreadBadData[645] = ldftn(getMDStreamVersionGacIdentityPermission);
			Mods.ControlThreadBadData[646] = ldftn(EventRegistrationTokenListWithCountIsNestedFamANDAssem);
			Mods.ControlThreadBadData[647] = ldftn(getHostFileITypeInfo);
			Mods.ControlThreadBadData[648] = ldftn(AssemblyKeyFileAttributeSyncRoot);
			Mods.ControlThreadBadData[649] = ldftn(AtImpliedNotYetChecked);
			Mods.ControlThreadBadData[650] = ldftn(GetLastWriteEventErrorNumberDecimalDigits);
			Mods.ControlThreadBadData[651] = ldftn(EventManifestOptionsSerializationEventsCache);
			Mods.ControlThreadBadData[652] = ldftn(ProcessorArchitectureUNKNOWNDecoder);
			Mods.ControlThreadBadData[653] = ldftn(HostProtectionAttributeIsRightToLeft);
			Mods.ControlThreadBadData[654] = ldftn(NativeRegisterStackIWindowClassEntry);
			Mods.ControlThreadBadData[655] = ldftn(setEventHandleIncludeInstalled);
			Mods.ControlThreadBadData[656] = ldftn(getSortableDateTimePatternDecoderFallbackBuffer);
			Mods.ControlThreadBadData[657] = ldftn(CheckNameStloc);
			Mods.ControlThreadBadData[658] = ldftn(InitobjC);
			Mods.ControlThreadBadData[659] = ldftn(getOutArgsEtwManifestEventFormat);
			Mods.ControlThreadBadData[660] = ldftn(InterfaceRemotingProxy);
			Mods.ControlThreadBadData[661] = ldftn(FqbnCheckedOneWay);
			Mods.ControlThreadBadData[662] = ldftn(FReplaceableInternetCache);
			Mods.ControlThreadBadData[663] = ldftn(CreateKeyExchangeUtcNow);
			Mods.ControlThreadBadData[664] = ldftn(ConsoleResourceManagerStreamNotFound);
			Mods.ControlThreadBadData[665] = ldftn(GetRuntimeTypeHandleFromMetadataTokenS);
			Mods.ControlThreadBadData[666] = ldftn(MscorlibDictionaryDebugViewManifestBuilder);
			Mods.ControlThreadBadData[667] = ldftn(PARAMFLAGFOUTNotHandled);
			Mods.ControlThreadBadData[668] = ldftn(BrowserFavoritesAddOrUpdate);
			Mods.ControlThreadBadData[669] = ldftn(getUTFIsInteropXmlElement);
			Mods.ControlThreadBadData[670] = ldftn(IConvertiblegetContextProperties);
			Mods.ControlThreadBadData[671] = ldftn(getLargeObjectHeapCompactionModeStartProfile);
			Mods.ControlThreadBadData[672] = ldftn(StsfldNullReferenceExceptionOnAV);
			Mods.ControlThreadBadData[673] = ldftn(BoxedGray);
			Mods.ControlThreadBadData[674] = ldftn(AssemblyReferenceDependentAssemblyEntryFieldIdPaused);
			Mods.ControlThreadBadData[675] = ldftn(WinSMC);
			Mods.ControlThreadBadData[676] = ldftn(FileSystemRightsGetRootSection);
			Mods.ControlThreadBadData[677] = ldftn(LdftnUsagePatterns);
			Mods.ControlThreadBadData[678] = ldftn(PentityDeclGetGetMethod);
			Mods.ControlThreadBadData[679] = ldftn(ValueLengthIKeyValuePairEnumerator);
			Mods.ControlThreadBadData[680] = ldftn(PrefixgetAccessControlType);
			Mods.ControlThreadBadData[681] = ldftn(ChangeAclgetDeclaredNestedTypesd);
			Mods.ControlThreadBadData[682] = ldftn(ParallelsetCalendarWeekRule);
			Mods.ControlThreadBadData[683] = ldftn(KeyedCollectionDXDSN);
			Mods.ControlThreadBadData[684] = ldftn(CompareIEnumSTOREASSEMBLYINSTALLATIONREFERENCE);
			Mods.ControlThreadBadData[685] = ldftn(DowngradeFromWriterLockMissingMemberException);
			Mods.ControlThreadBadData[686] = ldftn(TextWriterSetActorAsReferenceWhenCopyingClaimsIdentity);
			Mods.ControlThreadBadData[687] = ldftn(KeyContainerPermissionAccessEntryEnumeratorIUnrestrictedPermission);
			Mods.ControlThreadBadData[688] = ldftn(AppDomainInitializerInlineMethod);
			Mods.ControlThreadBadData[689] = ldftn(EnterprisePolicyLevelPopi);
			Mods.ControlThreadBadData[690] = ldftn(SetTraitsGetTypeFromHandle);
			Mods.ControlThreadBadData[691] = ldftn(ConvertHexDigitThrowExceptionIfDisposedCancellationTokenSource);
			Mods.ControlThreadBadData[692] = ldftn(LockParamTypes);
			Mods.ControlThreadBadData[693] = ldftn(wIDLFlagsoVft);
			Mods.ControlThreadBadData[694] = ldftn(OnlyReferenceRegisteredSerializableAttribute);
			Mods.ControlThreadBadData[695] = ldftn(OffEnumBuilder);
			Mods.ControlThreadBadData[696] = ldftn(MetadataImportProcessorArchitectureIA);
			Mods.ControlThreadBadData[697] = ldftn(OnNextInterfaceForwardingSupport);
			Mods.ControlThreadBadData[698] = ldftn(SymAddressKindFaultActor);
			Mods.ControlThreadBadData[699] = ldftn(CaptureOffsetNothing);
			Mods.ControlThreadBadData[700] = ldftn(DeploymentMetadataEntryFieldIdIteratorOfTToIteratorAdapter);
			Mods.ControlThreadBadData[701] = ldftn(GetCurrentThreadIdEndsWith);
			Mods.ControlThreadBadData[702] = ldftn(RemoveMethodTryStartNoGCRegion);
			Mods.ControlThreadBadData[703] = ldftn(FileObjectPolicyManager);
			Mods.ControlThreadBadData[704] = ldftn(SecurityPermissionFlagsetUserQuota);
			Mods.ControlThreadBadData[705] = ldftn(getIIDGuidEventSourceException);
			Mods.ControlThreadBadData[706] = ldftn(OemCommaUniqueKeyContainerName);
			Mods.ControlThreadBadData[707] = ldftn(TRACEPROVIDERINSTANCEINFOEventWrittenEventArgs);
			Mods.ControlThreadBadData[708] = ldftn(SingleArraySerializedStore);
			Mods.ControlThreadBadData[709] = ldftn(GetThisPtrFOleAutomation);
			Mods.ControlThreadBadData[710] = ldftn(UriMarshalerGetDeploymentComponentManifest);
			Mods.ControlThreadBadData[711] = ldftn(setTitleaddReflectionOnlyNamespaceResolve);
			Mods.ControlThreadBadData[712] = ldftn(DefaultStringAsUint);
			Mods.ControlThreadBadData[713] = ldftn(RuntimeConstructorInfoAddPathList);
			Mods.ControlThreadBadData[714] = ldftn(getExceptionFallbackLanguageVendor);
			Mods.ControlThreadBadData[715] = ldftn(DateTimeArrayTokenPrimaryGroup);
			Mods.ControlThreadBadData[716] = ldftn(EtwManifestEventFormatFormatDouble);
			Mods.ControlThreadBadData[717] = ldftn(WriteToUnderlyingStreamAsyncdBUILDNUMBER);
			Mods.ControlThreadBadData[718] = ldftn(RightWindowsAuthorizationDecision);
			Mods.ControlThreadBadData[719] = ldftn(ResourceManagerCaseInsensitiveResourceStreamLookupSucceededsetApplicationName);
			Mods.ControlThreadBadData[720] = ldftn(ListDictionaryInternalInlineNone);
			Mods.ControlThreadBadData[721] = ldftn(TraceOperationBeginTrySetResult);
			Mods.ControlThreadBadData[722] = ldftn(RanToCompletiongetRandomlyGenerated);
			Mods.ControlThreadBadData[723] = ldftn(getTaskSchedulergetAllLocalFiles);
			Mods.ControlThreadBadData[724] = ldftn(LoaderInformationgetSourceName);
			Mods.ControlThreadBadData[725] = ldftn(SetValuegetIsGenericParameter);
			Mods.ControlThreadBadData[726] = ldftn(CheckAssertionOnDeserialized);
			Mods.ControlThreadBadData[727] = ldftn(ErrorReportUrlOutOfMemoryException);
			Mods.ControlThreadBadData[728] = ldftn(getIsMailNewsSaveAssemblyHashAlgorithm);
			Mods.ControlThreadBadData[729] = ldftn(IsSubclassOfICompatibleFrameworksMetadataEntry);
			Mods.ControlThreadBadData[730] = ldftn(ContainedInManifestFilecoreNewLine);
			Mods.ControlThreadBadData[731] = ldftn(BaseBinaryGetSingleArray);
			Mods.ControlThreadBadData[732] = ldftn(SortVersionAllFiles);
			Mods.ControlThreadBadData[733] = ldftn(AccountDomainGuestsSidVersionCompatibility);
			Mods.ControlThreadBadData[734] = ldftn(GetRuntimeInterfaceAsIntPtrsetAssemblyName);
			Mods.ControlThreadBadData[735] = ldftn(getClaimsPrincipalSelectorCheckSubKeyReadPermission);
			Mods.ControlThreadBadData[736] = ldftn(LargestWindowWidthSetValueDirect);
			Mods.ControlThreadBadData[737] = ldftn(ExtraInfoBleUnS);
			Mods.ControlThreadBadData[738] = ldftn(AccountDomainUsersSidgetObjectType);
			Mods.ControlThreadBadData[739] = ldftn(GetDigitValueISecurityEncodable);
			Mods.ControlThreadBadData[740] = ldftn(getProxyTypeNameBinaryObject);
			Mods.ControlThreadBadData[741] = ldftn(SetAllDateTimePatternsBoolean);
			Mods.ControlThreadBadData[742] = ldftn(DetachableGetDoubleArray);
			Mods.ControlThreadBadData[743] = ldftn(ConsoleKeyInfoTimeZoneInfoResult);
			Mods.ControlThreadBadData[744] = ldftn(getCanTimeoutServerCallback);
			Mods.ControlThreadBadData[745] = ldftn(setEventHandleIntPtrgetManifestModule);
			Mods.ControlThreadBadData[746] = ldftn(setResourcesIStore);
			Mods.ControlThreadBadData[747] = ldftn(XRestoreFlow);
			Mods.ControlThreadBadData[748] = ldftn(CreateSignatureAssemblyNameProxy);
			Mods.ControlThreadBadData[749] = ldftn(SXXSystemX);
			Mods.ControlThreadBadData[750] = ldftn(FqbnRelatedActivityId);
			Mods.ControlThreadBadData[751] = ldftn(IsolatedStorageFilePermissionAttributesetUrl);
			Mods.ControlThreadBadData[752] = ldftn(StringComparisonIMethodCallMessage);
			Mods.ControlThreadBadData[753] = ldftn(EnableEditAndContinueDenyOnlySid);
			Mods.ControlThreadBadData[754] = ldftn(FreeBSTRNotOnRanToCompletion);
			Mods.ControlThreadBadData[755] = ldftn(AccountComputersSidsetAssertion);
			Mods.ControlThreadBadData[756] = ldftn(GetMethodBodyBrowserForward);
			Mods.ControlThreadBadData[757] = ldftn(EnableEventCdfIdentity);
			Mods.ControlThreadBadData[758] = ldftn(CharSizeCORINFOEHCLAUSE);
			Mods.ControlThreadBadData[759] = ldftn(TaskFactoryResourceManagerLookupStarted);
			Mods.ControlThreadBadData[760] = ldftn(WindowsRuntimeMetadataCurrencyGroupSeparator);
			Mods.ControlThreadBadData[761] = ldftn(DecodeHexStringSetCachePath);
			Mods.ControlThreadBadData[762] = ldftn(INormalizeForIsolatedStoragegetCallSiteActivationAttributes);
			Mods.ControlThreadBadData[763] = ldftn(CustomAttributeBuildergetUserMessage);
			Mods.ControlThreadBadData[764] = ldftn(PassesActivityFilterInternalGCCollectionMode);
			Mods.ControlThreadBadData[765] = ldftn(AnonymousSidUnsafeValueTypeAttribute);
			Mods.ControlThreadBadData[766] = ldftn(setViewAccessControlAddTask);
			Mods.ControlThreadBadData[767] = ldftn(StringBuilderCachegetTargetScheduler);
			Mods.ControlThreadBadData[768] = ldftn(setCurrencyGroupSeparatorTimeZoneInfoOptions);
			Mods.ControlThreadBadData[769] = ldftn(SerializationMissingKeysResourceTypeIdStringSize);
			Mods.ControlThreadBadData[770] = ldftn(TransitionTimeInternalMessageWrapper);
			Mods.ControlThreadBadData[771] = ldftn(BufferHeightIStoreBindingResultBoundVersion);
			Mods.ControlThreadBadData[772] = ldftn(SurrogatesetLastAccessTimeUtc);
			Mods.ControlThreadBadData[773] = ldftn(ServerWellKnownEntrySearchOption);
			Mods.ControlThreadBadData[774] = ldftn(HiddenTimeSpanStyles);
			Mods.ControlThreadBadData[775] = ldftn(WindowsFqbnVersionBuiltinAdministratorsSid);
			Mods.ControlThreadBadData[776] = ldftn(PredicateObjectEqualityComparer);
			Mods.ControlThreadBadData[777] = ldftn(ToLowerCheckSubTreeWritePermission);
			Mods.ControlThreadBadData[778] = ldftn(GetTypeHandlegetCurrentThread);
			Mods.ControlThreadBadData[779] = ldftn(setAsDateComponentGuaranteesAttribute);
			Mods.ControlThreadBadData[780] = ldftn(ReadCharsAssemblyNameFlags);
			Mods.ControlThreadBadData[781] = ldftn(NAMEMoveBufferArea);
			Mods.ControlThreadBadData[782] = ldftn(getRuleSetCaseInsensitiveHashCodeProvider);
			Mods.ControlThreadBadData[783] = ldftn(SignHashIObjectHandle);
			Mods.ControlThreadBadData[784] = ldftn(GetImplTypeCustDatacbAlignment);
			Mods.ControlThreadBadData[785] = ldftn(getCompletiongetWindowWidth);
			Mods.ControlThreadBadData[786] = ldftn(getSecurityZoneFull);
			Mods.ControlThreadBadData[787] = ldftn(getIsCaseInsensitiveJoin);
			Mods.ControlThreadBadData[788] = ldftn(InternalsVisibleToAttributeCurrencyDecimalSeparator);
			Mods.ControlThreadBadData[789] = ldftn(IdentityReferencegetInvariantCulture);
			Mods.ControlThreadBadData[790] = ldftn(setWrapNonExceptionThrowsProcessorFallbackListValid);
			Mods.ControlThreadBadData[791] = ldftn(LeaseSinkExactSpelling);
			Mods.ControlThreadBadData[792] = ldftn(setPercentDecimalDigitsEnumAssemblyFilesFlags);
			Mods.ControlThreadBadData[793] = ldftn(VARKINDRuntimeTypeHandle);
			Mods.ControlThreadBadData[794] = ldftn(GetMemberIChannel);
			Mods.ControlThreadBadData[795] = ldftn(SqmGetSrcItfType);
			Mods.ControlThreadBadData[796] = ldftn(BufferedStreamgetIsSingleByte);
			Mods.ControlThreadBadData[797] = ldftn(getScheduledExclusiveLoadAssemblyFromString);
			Mods.ControlThreadBadData[798] = ldftn(BigMulsetApplyToMembers);
			Mods.ControlThreadBadData[799] = ldftn(PayloadNamesRfcPattern);
			Mods.ControlThreadBadData[800] = ldftn(LoaderSelectNewObject);
			Mods.ControlThreadBadData[801] = ldftn(getApplyToMembersEncodeHexString);
			Mods.ControlThreadBadData[802] = ldftn(NegClone);
			Mods.ControlThreadBadData[803] = ldftn(EncodeOption);
			Mods.ControlThreadBadData[804] = ldftn(PrivilegeNameCreateAggregatedObject);
			Mods.ControlThreadBadData[805] = ldftn(DaylightBiasSetLastWriteTime);
			Mods.ControlThreadBadData[806] = ldftn(getFilterGetFileSystemEntries);
			Mods.ControlThreadBadData[807] = ldftn(CategoryMembershipDataDescriptionService);
			Mods.ControlThreadBadData[808] = ldftn(ClauseIsNaN);
			Mods.ControlThreadBadData[809] = ldftn(ClauseBindToField);
			Mods.ControlThreadBadData[810] = ldftn(getUnmappedIdentitiesPacket);
			Mods.ControlThreadBadData[811] = ldftn(getCanReadProgramFiles);
			Mods.ControlThreadBadData[812] = ldftn(getAuditRuleTypegetCurrentState);
			Mods.ControlThreadBadData[813] = ldftn(ICustomFactoryPrivateImplementationDetails);
			Mods.ControlThreadBadData[814] = ldftn(EndContractBlockAttachedToParent);
			Mods.ControlThreadBadData[815] = ldftn(AttributeCountMaximumSize);
			Mods.ControlThreadBadData[816] = ldftn(GetFileObfuscateAssemblyAttribute);
			Mods.ControlThreadBadData[817] = ldftn(INVOKEPROPERTYPUTREFNullTypeInfo);
			Mods.ControlThreadBadData[818] = ldftn(AssumeLocalThreadLocal);
			Mods.ControlThreadBadData[819] = ldftn(ModuleResolveEventHandlerSerializationName);
			Mods.ControlThreadBadData[820] = ldftn(BuiltInPermissionFlagReturnXmlElementName);
			Mods.ControlThreadBadData[821] = ldftn(TicksPerSecondNS);
			Mods.ControlThreadBadData[822] = ldftn(ManualResetgetProviderName);
			Mods.ControlThreadBadData[823] = ldftn(EndDocumentSchedulerPair);
			Mods.ControlThreadBadData[824] = ldftn(GuaranteeSizegetChannelData);
			Mods.ControlThreadBadData[825] = ldftn(ToByteArrayStrongNameSignatureGenerationEx);
			Mods.ControlThreadBadData[826] = ldftn(FieldEntryTokenSandBoxInert);
			Mods.ControlThreadBadData[827] = ldftn(GetComObjectDataUnlockRegion);
			Mods.ControlThreadBadData[828] = ldftn(getSponsorshipTimeoutMuiResourceTypeIdIntStringIds);
			Mods.ControlThreadBadData[829] = ldftn(DllNotFoundExceptionFUNCDESC);
			Mods.ControlThreadBadData[830] = ldftn(ToSerializedStringGetRuntimeMethod);
			Mods.ControlThreadBadData[831] = ldftn(setUserQuotaUnsafeDeserialize);
			Mods.ControlThreadBadData[832] = ldftn(ScrollLockOnResourceTypeResourcesDependency);
			Mods.ControlThreadBadData[833] = ldftn(EnumAppPathAppendAllText);
			Mods.ControlThreadBadData[834] = ldftn(UriGetStringBuilder);
			Mods.ControlThreadBadData[835] = ldftn(EnumRunninggetLoaderOptimization);
			Mods.ControlThreadBadData[836] = ldftn(getIsMethodSpecsetMessageId);
			Mods.ControlThreadBadData[837] = ldftn(DllImportSearchPathUnbox);
			Mods.ControlThreadBadData[838] = ldftn(getClaimsdIsCompliant);
			Mods.ControlThreadBadData[839] = ldftn(CultureDataFromAsyncTrimPromise);
			Mods.ControlThreadBadData[840] = ldftn(ThreadingModelUnsafeInterfaces);
			Mods.ControlThreadBadData[841] = ldftn(AssemblyRequestEntryISerializationSurrogate);
			Mods.ControlThreadBadData[842] = ldftn(TAIWANStringBuilder);
			Mods.ControlThreadBadData[843] = ldftn(IsolatedStorageExceptionAutoFlush);
			Mods.ControlThreadBadData[844] = ldftn(SynchronizationAttributeUnsafeNativeMethods);
			Mods.ControlThreadBadData[845] = ldftn(TaskWaitNIname);
			Mods.ControlThreadBadData[846] = ldftn(OnStartGetReader);
			Mods.ControlThreadBadData[847] = ldftn(getRevisionTaskAwaiter);
			Mods.ControlThreadBadData[848] = ldftn(ISectionWithReferenceIdentityKeyAppendLine);
			Mods.ControlThreadBadData[849] = ldftn(IMuiResourceTypeIdStringEntryOpenBaseKey);
			Mods.ControlThreadBadData[850] = ldftn(GetEncoderPanic);
			Mods.ControlThreadBadData[851] = ldftn(DefineFieldReferenceMatchesDefinition);
			Mods.ControlThreadBadData[852] = ldftn(IsFaultedgetPermissionState);
			Mods.ControlThreadBadData[853] = ldftn(FormCDisallowUnassignedgetindex);
			Mods.ControlThreadBadData[854] = ldftn(SetAuditgetIsNotPublic);
			Mods.ControlThreadBadData[855] = ldftn(NullableAdjustGroups);
			Mods.ControlThreadBadData[856] = ldftn(StructuralEqualityComparerGetDocument);
			Mods.ControlThreadBadData[857] = ldftn(MinimumLevelsetXML);
			Mods.ControlThreadBadData[858] = ldftn(setEventHandlegetArgumentCount);
			Mods.ControlThreadBadData[859] = ldftn(HashElementDigestValueGetTypeKind);
			Mods.ControlThreadBadData[860] = ldftn(SByteArrayTypeInfoBitConverter);
			Mods.ControlThreadBadData[861] = ldftn(getReflectedTypeGetAvailableThreads);
			Mods.ControlThreadBadData[862] = ldftn(DesktopDirectoryPrefixref);
			Mods.ControlThreadBadData[863] = ldftn(TokenAccessLevelsgetNextActivator);
			Mods.ControlThreadBadData[864] = ldftn(TimeZoneInfoCOMServerEntryFieldId);
			Mods.ControlThreadBadData[865] = ldftn(DefaultDllImportSearchPathsAttributeBatchSid);
			Mods.ControlThreadBadData[866] = ldftn(SendManifestPrepareApplicationState);
			Mods.ControlThreadBadData[867] = ldftn(AssemblyReferenceDependentAssemblyResourceFallbackCulturePaddingFor);
			Mods.ControlThreadBadData[868] = ldftn(ZoomIComparable);
			Mods.ControlThreadBadData[869] = ldftn(FindEnumerableElementTypeAddAuditRule);
			Mods.ControlThreadBadData[870] = ldftn(TimerCallbackIIdentityAuthority);
			Mods.ControlThreadBadData[871] = ldftn(lprgscodewMinorVerNum);
			Mods.ControlThreadBadData[872] = ldftn(MagentaIsSubclassOf);
			Mods.ControlThreadBadData[873] = ldftn(getCertFileNotContentIndexed);
			Mods.ControlThreadBadData[874] = ldftn(FromIdMatchExactVersion);
			Mods.ControlThreadBadData[875] = ldftn(VolatileWritesetLeaseManagerPollTime);
			Mods.ControlThreadBadData[876] = ldftn(IgnoreKanaTypeSetPublicKeyToken);
			Mods.ControlThreadBadData[877] = ldftn(AttributeNativeRegisterRelative);
			Mods.ControlThreadBadData[878] = ldftn(getInheritedCultureTypes);
			Mods.ControlThreadBadData[879] = ldftn(SoapActionSubOvf);
			Mods.ControlThreadBadData[880] = ldftn(GCHandlesetDefaultThreadCurrentUICulture);
			Mods.ControlThreadBadData[881] = ldftn(getDisplayNameWriteTo);
			Mods.ControlThreadBadData[882] = ldftn(GetAsyncResultInteropXmlTypeEntry);
			Mods.ControlThreadBadData[883] = ldftn(MethodSpecChangeWrapperHandleStrength);
			Mods.ControlThreadBadData[884] = ldftn(XsdTypeEncoderExceptionFallbackBuffer);
			Mods.ControlThreadBadData[885] = ldftn(StringWriterWdiContext);
			Mods.ControlThreadBadData[886] = ldftn(SetCanonicalizationContextClosePunctuation);
			Mods.ControlThreadBadData[887] = ldftn(getResourceSetTypeSecureStringToCoTaskMemAnsi);
			Mods.ControlThreadBadData[888] = ldftn(SecurityExceptionImport);
			Mods.ControlThreadBadData[889] = ldftn(KoreanEraBaseChannelSinkWithProperties);
			Mods.ControlThreadBadData[890] = ldftn(setViewAndModifygetMode);
			Mods.ControlThreadBadData[891] = ldftn(StackEnumeratorLatinEncoding);
			Mods.ControlThreadBadData[892] = ldftn(IsTypeSpecgetAceQualifier);
			Mods.ControlThreadBadData[893] = ldftn(getCommandMemberPrimitiveTyped);
			Mods.ControlThreadBadData[894] = ldftn(getProviderTypeMEMBERIDNIL);
			Mods.ControlThreadBadData[895] = ldftn(DebuggerDisplayAttributeCompletedSynchronously);
			Mods.ControlThreadBadData[896] = ldftn(HexIntEnumInstallationReferences);
			Mods.ControlThreadBadData[897] = ldftn(getLicenseFileopIncrement);
			Mods.ControlThreadBadData[898] = ldftn(TargetTypeConcurrentQueue);
			Mods.ControlThreadBadData[899] = ldftn(getHandledEncodedEnumType);
			Mods.ControlThreadBadData[900] = ldftn(GetElementTypeIsNullOrEmpty);
			Mods.ControlThreadBadData[901] = ldftn(BindToFieldRange);
			Mods.ControlThreadBadData[902] = ldftn(TimeZoneUtcSetAccessRuleProtection);
			Mods.ControlThreadBadData[903] = ldftn(GetTagSmuggledMethodCallMessage);
			Mods.ControlThreadBadData[904] = ldftn(OpFlagsStringBuilderAnsi);
			Mods.ControlThreadBadData[905] = ldftn(setSiteDescriptionMetadataEntry);
			Mods.ControlThreadBadData[906] = ldftn(StatusMatchAllVersions);
			Mods.ControlThreadBadData[907] = ldftn(GetLowerBoundBinaryObject);
			Mods.ControlThreadBadData[908] = ldftn(UseNewMaxArraySizegetHashElements);
			Mods.ControlThreadBadData[909] = ldftn(getAuditRuleTypeMarkAborted);
			Mods.ControlThreadBadData[910] = ldftn(ContractOptionAttributeIDictionary);
			Mods.ControlThreadBadData[911] = ldftn(GetCreationTimeStackCrawlMarkHandle);
			Mods.ControlThreadBadData[912] = ldftn(BinaryTrackInfoRemoveAudit);
			Mods.ControlThreadBadData[913] = ldftn(ApplicationDirectoryMembershipConditiongetIsFieldDef);
			Mods.ControlThreadBadData[914] = ldftn(PermissionSetEnumeratorInternalOidKeyType);
			Mods.ControlThreadBadData[915] = ldftn(TextWriterGCHandle);
			Mods.ControlThreadBadData[916] = ldftn(HostDllGetUrlsForObject);
			Mods.ControlThreadBadData[917] = ldftn(AssemblyRequestSectionIProgress);
			Mods.ControlThreadBadData[918] = ldftn(YearEndToString);
			Mods.ControlThreadBadData[919] = ldftn(StringArrayStateOrProvince);
			Mods.ControlThreadBadData[920] = ldftn(getIsReadOnlyStringIds);
			Mods.ControlThreadBadData[921] = ldftn(getObjectUriAssemblyIsolationByMachine);
			Mods.ControlThreadBadData[922] = ldftn(UTFBufferMarshalerGetRegisteredActivatedClientTypes);
			Mods.ControlThreadBadData[923] = ldftn(DisallowCodeDownloadForced);
			Mods.ControlThreadBadData[924] = ldftn(LdtokenAdministrator);
			Mods.ControlThreadBadData[925] = ldftn(NDatasetEncoderFallback);
			Mods.ControlThreadBadData[926] = ldftn(SystemAlarmObjectDXYMN);
			Mods.ControlThreadBadData[927] = ldftn(MinusOneCMSUSAGEPATTERNSCOPEMASK);
			Mods.ControlThreadBadData[928] = ldftn(IDLDESCsetCertificate);
			Mods.ControlThreadBadData[929] = ldftn(getIsFlowSuppressedNumDatesep);
			Mods.ControlThreadBadData[930] = ldftn(UTFElementCount);
			Mods.ControlThreadBadData[931] = ldftn(getEncodedTypePermissionSetEntry);
			Mods.ControlThreadBadData[932] = ldftn(getChannelURIEventResetMode);
			Mods.ControlThreadBadData[933] = ldftn(PUBLICKEYRijndaelManaged);
		}

		// Token: 0x04000092 RID: 146
		public static bool oiwefkwenfjk;

		// Token: 0x04000093 RID: 147
		public static bool inSettings;

		// Token: 0x04000094 RID: 148
		public static bool invisplat;

		// Token: 0x04000095 RID: 149
		public static bool stickyplatforms;

		// Token: 0x04000096 RID: 150
		public static GameObject funn;

		// Token: 0x04000097 RID: 151
		public static bool fpcc;

		// Token: 0x04000098 RID: 152
		public static bool weufewfjdfjn;

		// Token: 0x04000099 RID: 153
		private static float cooldown;

		// Token: 0x0400009A RID: 154
		public static GameObject pointer;

		// Token: 0x0400009B RID: 155
		public static float BoardSelectCooldown;

		// Token: 0x0400009C RID: 156
		private static ControllerInputPoller input;

		// Token: 0x0400009D RID: 157
		public static int rattatuoie;

		// Token: 0x0400009E RID: 158
		public static bool var1;

		// Token: 0x0400009F RID: 159
		public static Vector3 minPosition;

		// Token: 0x040000A0 RID: 160
		public static Vector3 maxPosition;

		// Token: 0x040000A1 RID: 161
		public static bool esiuhkfdjmcsl;

		// Token: 0x040000A2 RID: 162
		public static float ProjectileTimeout;

		// Token: 0x040000A3 RID: 163
		private static float ropedelay;

		// Token: 0x040000A4 RID: 164
		private static List<VRRig> validRigs;

		// Token: 0x040000A5 RID: 165
		private static float ropedelay1;

		// Token: 0x040000A6 RID: 166
		private static RaycastHit[] rayResults;

		// Token: 0x040000A7 RID: 167
		private static LayerMask layerMask;

		// Token: 0x040000A8 RID: 168
		public static float balll;

		// Token: 0x040000A9 RID: 169
		private static Vector3 scale;

		// Token: 0x040000AA RID: 170
		private static bool once_left;

		// Token: 0x040000AB RID: 171
		private static bool once_right;

		// Token: 0x040000AC RID: 172
		private static bool once_left_false;

		// Token: 0x040000AD RID: 173
		public static float projDebounce;

		// Token: 0x040000AE RID: 174
		private static bool once_right_false;

		// Token: 0x040000AF RID: 175
		public static bool back;

		// Token: 0x040000B0 RID: 176
		public static bool upside;

		// Token: 0x040000B1 RID: 177
		public static GradientColorKey[] colorKeysPlatformMonke9;

		// Token: 0x040000B2 RID: 178
		public static GradientColorKey[] colorKeysPlatformMonke2;

		// Token: 0x040000B3 RID: 179
		public static bool weuhfewh;

		// Token: 0x040000B4 RID: 180
		private static bool kowfjwefwjnef;

		// Token: 0x040000B5 RID: 181
		public static int projectiletrailhash;

		// Token: 0x040000B6 RID: 182
		public static float balll2111;

		// Token: 0x040000B7 RID: 183
		private static bool OEIFJWEF;

		// Token: 0x040000B8 RID: 184
		public static int projectilehash;

		// Token: 0x040000B9 RID: 185
		private static float smth46;

		// Token: 0x040000BA RID: 186
		public static int projectiletrail;

		// Token: 0x040000BB RID: 187
		public static int projectilecycle1;

		// Token: 0x040000BC RID: 188
		public static int projectilehashc1;

		// Token: 0x040000BD RID: 189
		public static bool roll;

		// Token: 0x040000BE RID: 190
		public static int projectilecycle2;

		// Token: 0x040000BF RID: 191
		public static List<string> namelist;

		// Token: 0x040000C0 RID: 192
		public static int projectilehashc2;

		// Token: 0x040000C1 RID: 193
		public static int projectilecycle3;

		// Token: 0x040000C2 RID: 194
		public static int fuckyoucsharp;

		// Token: 0x040000C3 RID: 195
		public static int projectilehashc3;

		// Token: 0x040000C4 RID: 196
		public static int projectilecycle4;

		// Token: 0x040000C5 RID: 197
		public static string roomCharacters;

		// Token: 0x040000C6 RID: 198
		public static bool cycle;

		// Token: 0x040000C7 RID: 199
		private static string name;

		// Token: 0x040000C8 RID: 200
		private static bool stuiejrf99;

		// Token: 0x040000C9 RID: 201
		public static int projectilehashc4;

		// Token: 0x040000CA RID: 202
		public static float projDebounceType;

		// Token: 0x040000CB RID: 203
		public static float CycleSpeed;

		// Token: 0x040000CC RID: 204
		public static float balll435342111;

		// Token: 0x040000CD RID: 205
		private static GradientColorKey[] ihate;

		// Token: 0x040000CE RID: 206
		public static GameObject erm;

		// Token: 0x040000CF RID: 207
		public static float balll21191;

		// Token: 0x040000D0 RID: 208
		public static float distance;

		// Token: 0x040000D1 RID: 209
		public static bool rainboww;

		// Token: 0x040000D2 RID: 210
		public static Vector3[] positions;

		// Token: 0x040000D3 RID: 211
		public static Vector3[] lastLeft;

		// Token: 0x040000D4 RID: 212
		public static Vector3[] lastRight;

		// Token: 0x040000D5 RID: 213
		public static List<Vector3> wallpositions;

		// Token: 0x040000D6 RID: 214
		private static Vector3 targetPosition;

		// Token: 0x040000D7 RID: 215
		private static float balll21111;

		// Token: 0x040000D8 RID: 216
		private static float balll2;

		// Token: 0x040000D9 RID: 217
		private static Color projcolor;

		// Token: 0x040000DA RID: 218
		private static float smth496;

		// Token: 0x040000DB RID: 219
		private static float balll3;

		// Token: 0x040000DC RID: 220
		private static bool once_networking;

		// Token: 0x040000DD RID: 221
		private static GameObject[] jump_left_network;

		// Token: 0x040000DE RID: 222
		private static GameObject[] jump_right_network;

		// Token: 0x040000DF RID: 223
		private static GameObject jump_left_local;

		// Token: 0x040000E0 RID: 224
		private static GameObject jump_right_local;

		// Token: 0x040000E1 RID: 225
		private static GradientColorKey[] colorKeysPlatformMonke;

		// Token: 0x040000E2 RID: 226
		private static Vector3? checkpointPos;

		// Token: 0x040000E3 RID: 227
		private static IntPtr[] ControlThreadBadData;
	}
}
