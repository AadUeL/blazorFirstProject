namespace dragon1.ApiRequests.Models
{
    public class UserDataShort
    {
        public int idUser { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int? roleId { get; set; }
    }

    //Вывод пользователей
    public class UserData
    { 
        public bool status { get; set; }
        public UserDataContainer data { get; set; }

    }

    public class UserDataContainer
    {
        public List<UserDataShort> users { get; set; }
    }

    //Регистрация
    public class ReqDataUser
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
    }

    public class StatusData
    {
        public bool status { get; set; }
    }


    //Авторизация
    public class ReqAuthUser
    {
        public string LoginName { get; set; }
        public string Password { get; set; }
    }

    public class AuthUserData
    {
        public bool status { get; set; }
        public UserDataShort user { get; set; }
    }

    //Update
    public class ReqUpdateUser
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }


}
