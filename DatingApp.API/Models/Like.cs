namespace DatingApp.API.Models
{
    public class Like
    {
        public int LikerId { get; set; }  //Id of user who likes other user
        public int LikeeId { get; set; }  //Id of the user thats beeing liked by another user
        public User Liker { get; set; }
        public User Likee { get; set; }
    }
}