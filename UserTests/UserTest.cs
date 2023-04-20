namespace UserNamespace
{
    public class UserTest
    {
        [Fact]
        public void User_Constructor_InitializesVariables()
        {
            User user1 = new User("John Userexample", "John@aol.com");

            Assert.Equal("John Userexample", user1.Name);
            Assert.Equal("John@aol.com", user1.Email);
            Assert.False(user1.IsLoggedIn);
        }

        [Fact]
        public void User_IsSetupComplete_ReturnsBool()
        {
            User user1 = new User("John Userexample", "John@aol.com");

            Assert.False(user1.IsSetupComplete());

            user1.CreatePassword("John@aol.com", "Password");
            Assert.True(user1.IsSetupComplete());
        }

        [Fact]
        public void User_CreatePassword_SetsPasswordToString()
        {
            User user1 = new User("John Userexample", "John@aol.com");
            user1.CreatePassword("John@aol.com", "Password");

            Assert.True(user1.IsSetupComplete());
        }

        [Fact]
        public void User_LogIn_SetsIsLoggedInToTrue()
        {
            User user1 = new User("John Userexample", "John@aol.com");
            user1.CreatePassword("John@aol.com", "Password");

            user1.LogIn("Password");
            Assert.True(user1.IsLoggedIn);
        }

        [Fact]
        public void User_LogOut_SetsIsLoggedInToFalse()
        {
            User user1 = new User("John Userexample", "John@aol.com");
            user1.CreatePassword("John@aol.com", "Password");

            user1.LogIn("Password");
            user1.LogOut();

            Assert.False(user1.IsLoggedIn);
        }
    }
}