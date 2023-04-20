namespace User.Tests//need the same namespace UserTests -> User.Tests
{
    public class UserTest
    {
        [Fact]
        public void User_Constructor_UserIsCreated()
        {
            var user1 = new User("Rafi", "rafiwick@gmail.com");
            Assert.Equal("Rafi", user1.Name);
            Assert.Equal("rafiwick@gmail.com", user1.Email);
            Assert.False(user1.IsLoggedIn);
        }
        [Fact]
        public void User_CreatePassword_CreatesPassword()
        {
            var user1 = new User("Rafi", "rafiwick@gmail.com");
            user1.CreatePassword("rafiwick@gmail.com", "abcdefgh");
            Assert.Equal("Password Created", user1.confirmation);
        }
        [Fact]
        public void User_IsSetupComplete_ReturnsTrueIfSetupCompleate()
        {
            var user1 = new User("Rafi", "rafiwick@gmail.com");
            Assert.False(user1.IsSetupComplete());
            user1.CreatePassword("rafiwick@gmail.com", "abcdefgh");
            Assert.True(user1.IsSetupComplete());
        }
        [Fact]
        public void User_LogIn_LogsInOnlyWithCorrectPassword()
        {
            var user1 = new User("Rafi", "rafiwick@gmail.com");
            user1.CreatePassword("rafiwick@gmail.com", "abcdefgh");
            Assert.Equal("Not Logged In", user1.LogIn("abcdefg"));
            Assert.False(user1.IsLoggedIn);
            Assert.Equal("Logged In", user1.LogIn("abcdefgh"));
            Assert.True(user1.IsLoggedIn);
        }
        [Fact]
        public void User_LogOut_ChangesIsLoggedInToFalse()
        {
            var user1 = new User("Rafi", "rafiwick@gmail.com");
            user1.CreatePassword("rafiwick@gmail.com", "abcdefgh");
            Assert.Equal("Logged In", user1.LogIn("abcdefgh"));
            user1.LogOut();
            Assert.False(user1.IsLoggedIn);
        }
    }
}