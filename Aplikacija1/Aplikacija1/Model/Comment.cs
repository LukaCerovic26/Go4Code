using System;
namespace Aplikacija1.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PostId { get; set; }
        public String UserId {get; set;}

        //SAMO U COMMENT RESPONSE VIDI I ZA PRISTUP TOKENU 
        public String UserName { get; set; }
    }
}

