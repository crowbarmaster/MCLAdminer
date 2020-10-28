using System;
using System.Runtime.CompilerServices;

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

		public static UserForm UserForm
		{
			get
			{
				if (_userForm == null)
				{
                    _userForm = new UserForm();
				}
				return _userForm;
			}
		}
		
		public static RoomForm RoomForm
		{
			get
			{
				if (_roomForm == null)
				{
                    _roomForm = new RoomForm();
				}
				return _roomForm;
			}
		}
				
		public static ReportSelect ReportSelect
		{
			get
			{
				if (_reportSelect == null)
				{
                    _reportSelect = new ReportSelect();
				}
				return _reportSelect;
			}
		}
				
		public static PrintReport PrintReport
		{
			get
			{
				if (_printReport == null)
				{
                    _printReport = new PrintReport();
				}
				return _printReport;
			}
			set
            {
				_printReport = PrintReport;
            }
		}

		private static MainMenuForm _mainMenu;
		private static ManageRooms _manageRooms;
		private static ManageUsers _manageUsers;
		private static ReportSelect _reportSelect;
		private static PrintReport _printReport;
		private static UserForm _userForm;
		private static RoomForm _roomForm;
	}
}
