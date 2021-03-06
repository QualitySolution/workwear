﻿using QS.DomainModel.UoW;
using QS.Project.Domain;
using QSOrmProject.Domain;
using workwear.Domain.Users;

namespace workwear.Repository
{
	public static class UserRepository
	{
		public static UserBase GetMyUser(IUnitOfWork uow)
		{
			return uow.GetById<UserBase> (QSProjectsLib.QSMain.User.Id);
		}

		/// <summary>
		/// По возможности не используйте напрямую этот метод, для получения настроек используйте класс CurrentUserSettings
		/// </summary>
		public static UserSettings GetCurrentUserSettings(IUnitOfWork uow)
		{
			return uow.Session.QueryOver<UserSettings>()
				.Where(s => s.User.Id == QSProjectsLib.QSMain.User.Id)
				.SingleOrDefault();
		}

	}
}

