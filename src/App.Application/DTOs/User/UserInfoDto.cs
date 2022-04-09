namespace App.Application.DTOs.User;

public class UserInfoDto
{
    public string Name { get; set; }

    public string Token { get; set; }

    public static UserInfoDto Factory(string name, string token)
    {
        return new UserInfoDto 
        {
            Name = name,
            Token = token
        };
    }
}
