using System;
using System.Collections.Generic;
using System.Text;

namespace RefitSample.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        MyPage
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
