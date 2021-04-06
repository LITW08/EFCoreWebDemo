using System;
using System.Collections.Generic;
using EFCoreWebDemo.Data;

namespace EFCoreWebDemo.Web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class HomePageViewModel
    {
        public List<Person> People { get; set; }
    }

    public class EditPageViewModel
    {
        public Person Person { get; set; }
    }
}
