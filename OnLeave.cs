using System;
using GTAG_NotificationLib;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000018 RID: 24
	[HarmonyPatch(typeof(GorillaNot))]
	[HarmonyPatch("OnPlayerLeftRoom", 0)]
	internal class OnLeave : HarmonyPatch
	{
		// Token: 0x06000331 RID: 817 RVA: 0x0001AE14 File Offset: 0x00019014
		private static void AreAccessRulesProtectedUrlIdentityPermission(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			A_1 = 6;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0001AE2C File Offset: 0x0001902C
		private static void CountedUtfJsonNullableEqualityComparer(ref int A_0, ref int A_1, ref int A_2, OnLeave A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0001AE50 File Offset: 0x00019050
		private static void Prefix(Player otherPlayer)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 6)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,Photon.Realtime.Player), ref num, ref num2, ref num3, ref flag, ref flag2, otherPlayer, OnLeave.NestedCurrencyGroupSizes[num]);
			}
			num2 = 0;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001AE88 File Offset: 0x00019088
		public OnLeave()
		{
			int num = 5;
			int num2 = 5;
			num2 = 5;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.OnLeave), ref num, ref num2, ref num3, this, OnLeave.NestedCurrencyGroupSizes[num]);
			}
			num2 = 5;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0001AEBC File Offset: 0x000190BC
		private static void BoxStackTrace(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			NotifiLib.SendNotification("<color=red>[ROOM]:</color> Player " + A_5.NickName + " Left Lobby");
			bool isMasterClient = PhotonNetwork.IsMasterClient;
			A_4 = isMasterClient;
			int num = ((!A_4) ? 1 : 0) * 1 + 2;
			A_0 = num;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0001AF38 File Offset: 0x00019138
		private static void asyncResultgetFrameworkDisplayName(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			A_1 = 6;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0001AF50 File Offset: 0x00019150
		private static void QueueUserWorkItemGetDefaultMembers(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			bool flag = A_5 != PhotonNetwork.LocalPlayer;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 3 + 1;
			A_0 = num;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0001AFBC File Offset: 0x000191BC
		private static void NotifyEventFormatWithInnerException(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			NotifiLib.SendNotification("<color=yellow>[ROOM]: YOU ARE NOW MASTER CLIENT!</color>");
			A_1 = 6;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0001AFE4 File Offset: 0x000191E4
		// Note: this type is marked as 'beforefieldinit'.
		static OnLeave()
		{
			OnLeave.IHashCodeProviderAdmin();
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0001AFF8 File Offset: 0x000191F8
		private static void IHashCodeProviderAdmin()
		{
			OnLeave.NestedCurrencyGroupSizes = new IntPtr[6];
			OnLeave.NestedCurrencyGroupSizes[0] = ldftn(QueueUserWorkItemGetDefaultMembers);
			OnLeave.NestedCurrencyGroupSizes[1] = ldftn(BoxStackTrace);
			OnLeave.NestedCurrencyGroupSizes[2] = ldftn(NotifyEventFormatWithInnerException);
			OnLeave.NestedCurrencyGroupSizes[3] = ldftn(asyncResultgetFrameworkDisplayName);
			OnLeave.NestedCurrencyGroupSizes[4] = ldftn(AreAccessRulesProtectedUrlIdentityPermission);
			OnLeave.NestedCurrencyGroupSizes[5] = ldftn(CountedUtfJsonNullableEqualityComparer);
		}

		// Token: 0x04000091 RID: 145
		private static IntPtr[] NestedCurrencyGroupSizes;
	}
}
