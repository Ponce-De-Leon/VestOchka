using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VestOchka
{
    public class User
    {
        private Position _Position;
        public User(Position Position)
        {
            if (Position != null)
            {
                _Position = Position;
            }
            else
            {   
                throw new Exception("Пустое значение должности пользователя");
            }
        }
        public User(): this(null){ }

    }
}