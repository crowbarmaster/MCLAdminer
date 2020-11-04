namespace MCL_Adminer
{
    public class FormProvider
    {
        public static MainMenuForm MainMenu
        {
            get
            {
                if (mainMenu == null || mainMenu.IsDisposed)
                {
                    mainMenu = new MainMenuForm();
                }
                return mainMenu;
            }
        }

        public static ManageRooms ManageRooms
        {
            get
            {
                if (manageRooms == null || manageRooms.IsDisposed)
                {
                    manageRooms = new ManageRooms();
                }
                return manageRooms;
            }
        }

        public static ManageUsers ManageUsers
        {
            get
            {
                if (manageUsers == null || manageUsers.IsDisposed)
                {
                    manageUsers = new ManageUsers();
                }
                return manageUsers;
            }
        }

        public static UserForm UserForm
        {
            get
            {
                if (userForm == null || userForm.IsDisposed)
                {
                    userForm = new UserForm();
                }
                return userForm;
            }
        }

        public static RoomForm RoomForm
        {
            get
            {
                if (roomForm == null || roomForm.IsDisposed)
                {
                    roomForm = new RoomForm();
                }
                return roomForm;
            }
        }

        public static ReportSelect ReportSelect
        {
            get
            {
                if (reportSelect == null || reportSelect.IsDisposed)
                {
                    reportSelect = new ReportSelect();
                }
                return reportSelect;
            }
        }

        public static PrintReport PrintReport
        {
            get
            {
                if (printReport == null || printReport.IsDisposed)
                {
                    printReport = new PrintReport();
                }
                return printReport;
            }
        }

        public static UserRoomSelect UserRoomSelect
        {
            get
            {
                if (userRoomSelect == null || userRoomSelect.IsDisposed)
                {
                    userRoomSelect = new UserRoomSelect();
                }
                return userRoomSelect;
            }
        }

        private static MainMenuForm mainMenu;
        private static ManageRooms manageRooms;
        private static ManageUsers manageUsers;
        private static ReportSelect reportSelect;
        private static PrintReport printReport;
        private static UserForm userForm;
        private static UserRoomSelect userRoomSelect;
        private static RoomForm roomForm;
    }
}
