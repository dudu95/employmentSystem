using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GraduationProject.Helper
{
    public static class Paging
    {
        public static List<T> ListPaging<T>(this List<T> list, int PageIndex, int pageSize)
        {
            List<T> newList = new List<T>();
            if (pageSize <= 0)
            {
                pageSize = 10;
            }
            if (PageIndex > 0)
            {
                newList = list.Skip((PageIndex - 1) * pageSize).Take(pageSize).ToList();
            }
            else
            {
                newList = list.Skip(0).Take(pageSize).ToList();
            }
            return newList;
        }
    }
}