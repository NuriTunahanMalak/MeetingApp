namespace MeetingApp.Models
{
    public class Repository
    {
        public static List<UserInfo> _userInfos = new List<UserInfo>();
        public static Repository _repository;
        static  Repository()
        {
            _userInfos.Add(new UserInfo() {Id=1,Name="Ali",Email="info@gmail.com",Phone="161518465",WillAttend=true});
        }
        public static List<UserInfo> GetUserInfos()
        {
            return _userInfos;
        }
        public static void CreateUserInfos(UserInfo userInfo) 
        {
            userInfo.Id = _userInfos.Count + 1;
            _userInfos.Add(userInfo);
        }
        public static UserInfo? GetUserById(int id)
        {
            return _userInfos.FirstOrDefault(u => u.Id == id);
        }
    }
}
