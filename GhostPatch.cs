using System;
using HarmonyLib;
using UnityEngine;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000016 RID: 22
	[HarmonyPatch(typeof(VRRig), "OnDisable")]
	internal class GhostPatch : MonoBehaviour
	{
		// Token: 0x06000322 RID: 802 RVA: 0x0001AAE8 File Offset: 0x00018CE8
		private static bool getRevisionFlushAsyncInternald(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = false;
			A_4 = flag;
			A_0 = 3;
			bool result;
			return result;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0001AB1C File Offset: 0x00018D1C
		public GhostPatch()
		{
			int num = 4;
			int num2 = 4;
			num2 = 4;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.GhostPatch), ref num, ref num2, ref num3, this, GhostPatch.IdentityAuthorityTKINDMODULE[num]);
			}
			num2 = 4;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0001AB50 File Offset: 0x00018D50
		private static bool ThisOrganizationSidMarshalTypeRef(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = A_5 == GorillaTagger.Instance.offlineVRRig;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 1;
			A_0 = num;
			bool result;
			return result;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0001ABC0 File Offset: 0x00018DC0
		private static void DynamicDaylightTimeDisabledgetIsPointer(ref int A_0, ref int A_1, ref int A_2, GhostPatch A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0001ABE4 File Offset: 0x00018DE4
		private static bool getUnderlyingFieldGetMaxCharCount(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = true;
			A_4 = flag;
			A_0 = 3;
			bool result;
			return result;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0001AC18 File Offset: 0x00018E18
		public static bool Prefix(VRRig __instance)
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
				result = calli(System.Boolean(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,VRRig), ref num, ref num2, ref num3, ref flag, ref flag2, __instance, GhostPatch.IdentityAuthorityTKINDMODULE[num]);
			}
			num2 = 0;
			return result;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0001AC54 File Offset: 0x00018E54
		private static bool getSupportUrlCallContext(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool result = A_4;
			A_1 = 4;
			return result;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0001AC74 File Offset: 0x00018E74
		// Note: this type is marked as 'beforefieldinit'.
		static GhostPatch()
		{
			GhostPatch.GetProxiedTypeHashElements();
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0001AC88 File Offset: 0x00018E88
		private static void GetProxiedTypeHashElements()
		{
			GhostPatch.IdentityAuthorityTKINDMODULE = new IntPtr[5];
			GhostPatch.IdentityAuthorityTKINDMODULE[0] = ldftn(ThisOrganizationSidMarshalTypeRef);
			GhostPatch.IdentityAuthorityTKINDMODULE[1] = ldftn(getRevisionFlushAsyncInternald);
			GhostPatch.IdentityAuthorityTKINDMODULE[2] = ldftn(getUnderlyingFieldGetMaxCharCount);
			GhostPatch.IdentityAuthorityTKINDMODULE[3] = ldftn(getSupportUrlCallContext);
			GhostPatch.IdentityAuthorityTKINDMODULE[4] = ldftn(DynamicDaylightTimeDisabledgetIsPointer);
		}

		// Token: 0x0400008F RID: 143
		private static IntPtr[] IdentityAuthorityTKINDMODULE;
	}
}
