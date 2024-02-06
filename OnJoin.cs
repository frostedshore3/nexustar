using System;
using GTAG_NotificationLib;
using HarmonyLib;
using Photon.Realtime;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000017 RID: 23
	[HarmonyPatch(typeof(GorillaNot))]
	[HarmonyPatch("OnPlayerEnteredRoom", 0)]
	internal class OnJoin : HarmonyPatch
	{
		// Token: 0x0600032B RID: 811 RVA: 0x0001ACFC File Offset: 0x00018EFC
		private static void IsTypeSpecgetIsAutoLayout(ref int A_0, ref int A_1, ref int A_2, OnJoin A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0001AD20 File Offset: 0x00018F20
		private static void RuntimeConstructorInfoObjectAuditRule(ref int A_0, ref int A_1, ref int A_2, Player A_3)
		{
			NotifiLib.SendNotification("<color=green>[ROOM]:</color> Player " + A_3.NickName + " Joined Lobby");
			A_1 = 2;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0001AD58 File Offset: 0x00018F58
		private static void Prefix(Player newPlayer)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 2)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,Photon.Realtime.Player), ref num, ref num2, ref num3, newPlayer, OnJoin.IKeyValuePairEnumeratorThreadTransferReceiveObj[num]);
			}
			num2 = 0;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0001AD8C File Offset: 0x00018F8C
		public OnJoin()
		{
			int num = 1;
			int num2 = 1;
			num2 = 1;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.OnJoin), ref num, ref num2, ref num3, this, OnJoin.IKeyValuePairEnumeratorThreadTransferReceiveObj[num]);
			}
			num2 = 1;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0001ADC0 File Offset: 0x00018FC0
		// Note: this type is marked as 'beforefieldinit'.
		static OnJoin()
		{
			OnJoin.getRuntimeVersiongetProgID();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0001ADD4 File Offset: 0x00018FD4
		private static void getRuntimeVersiongetProgID()
		{
			OnJoin.IKeyValuePairEnumeratorThreadTransferReceiveObj = new IntPtr[2];
			OnJoin.IKeyValuePairEnumeratorThreadTransferReceiveObj[0] = ldftn(RuntimeConstructorInfoObjectAuditRule);
			OnJoin.IKeyValuePairEnumeratorThreadTransferReceiveObj[1] = ldftn(IsTypeSpecgetIsAutoLayout);
		}

		// Token: 0x04000090 RID: 144
		private static IntPtr[] IKeyValuePairEnumeratorThreadTransferReceiveObj;
	}
}
