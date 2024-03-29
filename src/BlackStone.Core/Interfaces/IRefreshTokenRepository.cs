﻿using BlackStone.Core.Entities;

namespace BlackStone.Core.Interfaces {
	public interface IRefreshTokenRepository {
		Task<RefreshToken> GetRefreshTokenByUserId(long userId, string refreshTokenKey);
		Task<bool> Insert(RefreshToken jWTRefreshToken);
		Task<bool> Update(RefreshToken jWTRefreshToken);
		Task<bool> CheckRefreshTokenIsValid(long userId, string refreshToken);
	}
}
