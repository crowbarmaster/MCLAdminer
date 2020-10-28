using System;

namespace MCL_Adminer
{
	public class FormProvider
	{
		public static MainMenuForm MainMenu
		{
			get
			{
				if (_mainMenu == null)
				{
                    _mainMenu = new MainMenuForm();
				}
				return _mainMenu;
			}
		}

		public static ManageRooms ManageRooms
		{
			get
			{
				if (_manageRooms == null)
				{
                    _manageRooms = new ManageRooms();
				}
				return _manageRooms;
			}
		}

		public static ManageUsers ManageUsers
		{
			get
			{
				if (_manageUsers == null)
				{
                    _manageUsers = new ManageUsers();
				}
				return _manageUsers;
			}
		}

		private static MainMenuForm _mainMenu;
		private static ManageRooms _manageRooms;
		private static ManageUsers _manageUsers;
	}
}
