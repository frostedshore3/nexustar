using System;
using GTAG_NotificationLib;
using HarmonyLib;
using Photon.Pun;
using UnityEngine;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000015 RID: 21
	[HarmonyPatch(typeof(GorillaNot), "SendReport")]
	internal class anticheatnotif : MonoBehaviour
	{
		// Token: 0x06000319 RID: 793 RVA: 0x0001A8BC File Offset: 0x00018ABC
		public anticheatnotif()
		{
			int num = 4;
			int num2 = 4;
			num2 = 4;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.anticheatnotif), ref num, ref num2, ref num3, this, anticheatnotif.RanToCompletionMachineKeyStore[num]);
			}
			num2 = 4;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0001A8F0 File Offset: 0x00018AF0
		private static bool getIsSingleByteInterfaceMethods(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, string A_5, string A_6)
		{
			NotifiLib.SendNotification("<color=red>[ANTICHEAT] REPORTED FOR: " + A_6 + "</color>");
			bool flag = false;
			A_4 = flag;
			A_0 = 3;
			bool result;
			return result;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0001A93C File Offset: 0x00018B3C
		private static bool Prefix(string susReason, string susId, string susNick)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			bool result;
			while (num2 != 4)
			{
				int num3;
				bool flag;
				bool flag2;
				result = calli(System.Boolean(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,System.String,System.String), ref num, ref num2, ref num3, ref flag, ref flag2, susId, susReason, anticheatnotif.RanToCompletionMachineKeyStore[num]);
			}
			num2 = 0;
			return result;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0001A978 File Offset: 0x00018B78
		private static void TaskWaitContinuationStartedGetDeclaredField(ref int A_0, ref int A_1, ref int A_2, anticheatnotif A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0001A99C File Offset: 0x00018B9C
		private static bool getIsRetvalCreateIdentityPermission(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, string A_5, string A_6)
		{
			bool flag = A_5 == PhotonNetwork.LocalPlayer.UserId;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 1;
			A_0 = num;
			bool result;
			return result;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0001AA0C File Offset: 0x00018C0C
		private static bool ResourceTypeIdStringsearchOption(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, string A_5, string A_6)
		{
			bool result = A_4;
			A_1 = 4;
			return result;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0001AA2C File Offset: 0x00018C2C
		private static bool getCustomErrorsModeGetPartitions(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, string A_5, string A_6)
		{
			bool flag = false;
			A_4 = flag;
			A_0 = 3;
			bool result;
			return result;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0001AA60 File Offset: 0x00018C60
		// Note: this type is marked as 'beforefieldinit'.
		static anticheatnotif()
		{
			anticheatnotif.IsCompatibilitySwitchSetCrossMachine();
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0001AA74 File Offset: 0x00018C74
		private static void IsCompatibilitySwitchSetCrossMachine()
		{
			anticheatnotif.RanToCompletionMachineKeyStore = new IntPtr[5];
			anticheatnotif.RanToCompletionMachineKeyStore[0] = ldftn(getIsRetvalCreateIdentityPermission);
			anticheatnotif.RanToCompletionMachineKeyStore[1] = ldftn(getIsSingleByteInterfaceMethods);
			anticheatnotif.RanToCompletionMachineKeyStore[2] = ldftn(getCustomErrorsModeGetPartitions);
			anticheatnotif.RanToCompletionMachineKeyStore[3] = ldftn(ResourceTypeIdStringsearchOption);
			anticheatnotif.RanToCompletionMachineKeyStore[4] = ldftn(TaskWaitContinuationStartedGetDeclaredField);
		}

		// Token: 0x0400008E RID: 142
		private static IntPtr[] RanToCompletionMachineKeyStore;
	}
}
