
namespace builder_pattern_dotnet
{
    public class UserBuilder : IHasName, IHasBirth
    {
        private readonly User _user = new();

        public static IHasName Instance => new UserBuilder();

        private UserBuilder() { }

        public IHasBirth SetName(string name)
        {
            _user.Name = name;
            return this;
        }

        public UserBuilder SetBirth(DateTime birth)
        {
            _user.Birth = birth;
            return this;
        }

        public UserBuilder SetNickname(string nickname)
        {
            _user.Nickname = nickname;
            return this;
        }

        public User Build() => _user;
    }
}
