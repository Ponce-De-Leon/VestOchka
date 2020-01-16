using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VestOchka
{
    public class Position
    {
        private Int64 _ID;
        private String _Name;
        public Position(Int64 ID,String Name)
        {
            _ID = ID;
            if (!String.IsNullOrEmpty(Name))
            {
                _Name = Name;
            }
            else
            {
                throw new Exception("Пустое наименование должности");
            }
        }
        public Position() : this(0,"Нет наименования должности") { }
        public Int64 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _Name = value;
                }
            }
        }
    }
}