﻿using BlackStone.Core.Base;

namespace BlackStone.Core.Entities {
	public class AccountType : EntityBase {
		#region private declarations
		private long accountTypeId;
		private string? accountTypeName;
		#endregion

		public long AccountTypeId {
			get => accountTypeId; 
			set {
				accountTypeId = value;
				EntityModified();
			}
		}
		public string? AccountTypeName {
			get => accountTypeName; 
			set {
				accountTypeName = value; 
				EntityModified();
			}
		}
	}
}
